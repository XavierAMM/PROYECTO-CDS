using CapaDatos;
using CapaNegocio;
using CapaPresentacion.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
	/// <summary>
	/// Este formulario mostrará todo el programa y el menú en el lado izquierdo. 
	/// Las diferentes ventanas se mostrarán al ingresar a una opción específica y 
	/// se mostrarán los controles de usuarios dentro del panel principal.
	/// </summary>
	public partial class Frm_Principal : Form
	{
		private DataTable modulos;
		private CN_Validacion objectCN = new CN_Validacion();
		private int usuario_id = 0;
		private bool registro;

		/// <summary>
		/// Constructor principal para ejecutar el Frm_Principal de manera normal. 
		/// Los distintos módulos y opciones se mostrarán en el menú del lado izquierdo.
		/// </summary>
		/// <param name="usuario_id">Id del usuario que inició sesión.</param>
		public Frm_Principal(int usuario_id)
		{
			InitializeComponent();
			this.registro = false;
			this.usuario_id = usuario_id;
			colocarValoresUsuarioPrincipal();
			crearMenu();
		}

		/// <summary>
		/// Subconstructor que ejecuta el Frm_Principal y crea la vista para registro 
		/// o de recuperar contraseña dependiendo del parámetro enviado.
		/// </summary>
		/// <param name="registro">Booleano. True si es para registro. False si es para 
		/// recuperar contraseña</param>
		public Frm_Principal(bool registro)
		{
			InitializeComponent();
			this.registro = true;
			pnl_MiUsuario.Visible = false;
			pnl_Divisor2.Visible = false;
			if (registro) crearVistaRegistro();
			else crearVistaRecuperarContraseña();
		}

		/// <summary>
		/// Este método buscará el perfil del usuario a partir del usuario_id enviado en el 
		/// constructor normal.
		/// </summary>
		/// <returns>El id del perfil del usuario.</returns>
		private int obtenerIDPerfilUsuario()
		{
			CD_Parametros[] param = { new CD_Parametros("@usuario_id", usuario_id) };
			return objectCN.obtenerDatoEntero("PD_OBTENER_PERFIL_USUARIO", param);
		}

		/// <summary>
		/// Se ejecuta al abrir el formulario. Este método se encargará de crear el menú 
		/// principal con todos los módulos y opciones disponibles.
		/// </summary>
		private void crearMenu()
		{
			modulos = objectCN.obtenerVistaTabla("VISTA_OBTENER_MODULOS");
			foreach (DataRow row in modulos.Rows)
			{
				Button btn_Menu = crearBoton(row["nombre"].ToString(), row["nombre_objeto"].ToString());
				CD_Parametros[] param = { new CD_Parametros("@modulo_id", (int)row["modulo_id"]) };
				DataTable opciones = objectCN.obtenerTabla("PD_OBTENER_OPCIONES_MODULO", param);
				if (opciones.Rows.Count > 0)
				{
					Panel pnl_Dropdown = crearPanelDropDown("pnl_" + row["nombre"].ToString(), btn_Menu.Size.Height, opciones.Rows.Count);
					btn_Menu.Tag = pnl_Dropdown.Name;
					btn_Menu.Click += btn_Menu_Click;
					pnl_Menu.Controls.Add(pnl_Dropdown);
					añadirBotonesOpcion(opciones, pnl_Dropdown);
				}				
				pnl_Menu.Controls.Add(btn_Menu);
			}
		}

		/// <summary>
		/// Este método se ejecuta dentro del bucle de crear menú. Si el módulo tiene 
		/// sub-opciones, llamará a este método para irle añadiendo los botones correspondientes.
		/// </summary>
		/// <param name="opciones">La tabla de opciones obtenida a partir del modulo_id</param>
		/// <param name="pnl">El panel dropDown a la cual se van a añadir las opciones.</param>
		private void añadirBotonesOpcion(DataTable opciones, Panel pnl)
		{
			foreach (DataRow r in opciones.Rows)
			{
				Button btn_Opcion = crearBoton(r["nombre"].ToString(), r["nombre_objeto"].ToString());
				pnl.Controls.Add(btn_Opcion);
				btn_Opcion.Click += btn_Opcion_Click;
			}
		}

		/// <summary>
		/// Evento al que se suscribirán los botones que son módulos que tienen opciones. 
		/// Pueden existir módulos que abran directamente un user control sin necesidad 
		/// de tener opciones. Este método hará que al darle click al botón, se abra o 
		/// se cierre el panel de las subopciones.
		/// </summary>		
		private void btn_Menu_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			string nombre_panelDropdown = button.Tag.ToString();
			foreach (Control c in pnl_Menu.Controls)
			{
				if (c is Panel)
				{
					if (c.Name == nombre_panelDropdown)
					{
						if (c.Visible)
						{
							button.BackColor = Color.Transparent;
							c.Visible = false;
						}
						else
						{
							button.BackColor = Color.SeaGreen;
							c.Visible = true;
						}
					}
				}
			}
		}

		/// <summary>
		/// Muestra el user control específico en el panel de la derecha.
		/// </summary>
		/// <param name="uc">El User Control que se quiera mostrar.</param>
		private void addUserControl(UserControl uc)
		{
			uc.Dock = DockStyle.Fill;
			pnl_View.Controls.Clear();
			pnl_View.Controls.Add(uc);
			uc.BringToFront();
		}

		/// <summary>
		/// Evento al que se suscriben los botones que muestren un user control. 
		/// Por lo general, serán botones de opciones dentro de módulos, pero, 
		/// pueden existir módulos que no contengan opciones y que abran directamente 
		/// un user control. Para este último caso, se los suscribiría a este evento.
		/// </summary>		
		private void btn_Opcion_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			string nombre_objeto = button.Tag.ToString();
			Type UCType = obtenerTipoUserControl(nombre_objeto);
			CD_Parametros[] param = {
						new CD_Parametros("@perfil_id",obtenerIDPerfilUsuario()),
						new CD_Parametros("@nombre_objeto",nombre_objeto),

			};
			if (objectCN.obtenerDatoEntero("PD_VALIDAR_PERFIL_X_OPCION", param) == 1)
			{
				if (UCType != null)
				{
					UserControl uc = obtenerUserControl(UCType);
					if (uc != null) addUserControl(uc);
					else MessageBox.Show("El UserControl no tiene un constructor que acepte el parámetro requerido.");
				}
				else MessageBox.Show("No se ha encontrado la ventana: " + nombre_objeto);
			}
			else MessageBox.Show("No tiene permiso para acceder a esta opción según su perfil.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop);

		}

		/// <summary>
		/// Este método comprobará si el nombre proporcionado es de tipo User Control.
		/// </summary>
		/// <param name="nombre_objeto">El nombre del User Control que se debería de 
		/// encontrar dentro de la carpeta CapaPresentación > User_Control</param>
		/// <returns></returns>
		private Type obtenerTipoUserControl(string nombre_objeto)
		{
			Type UCType = Type.GetType("CapaPresentacion.User_Control." + nombre_objeto);
			if (UCType != null && UCType.IsSubclassOf(typeof(UserControl)))
			{
				return UCType;
			}
			else return null;
		}

		/// <summary>
		/// Este método va a crear el user control que va a ser abierto por un botón de opción. 
		/// Estos user control tendrán todos como parámetro en su constructor el usuario_id.
		/// </summary>
		/// <param name="UCType">Tipo de objeto que se quiere verificar. En este caso, UserControl.</param>
		/// <returns>El UserControl adecuado para cada botón de opción.</returns>
		private UserControl obtenerUserControl(Type UCType)
		{
			int parametroParaUserControl = usuario_id;
			ConstructorInfo constructor = UCType.GetConstructor(new Type[] { typeof(int) });
			if (constructor != null)
			{
				UserControl uc = (UserControl)constructor.Invoke(new object[] { parametroParaUserControl });
				return uc;
			}
			else return null;
		}

		/// <summary>
		/// Este método va a colocar los datos de usuario y perfil en la parte inferior de la pantalla
		/// a partir del usuario_id de inicio de sesión.
		/// </summary>
		private void colocarValoresUsuarioPrincipal()
		{
			CD_Parametros[] param = { new CD_Parametros("@usuario_id", usuario_id) };
			DataTable tabla = objectCN.obtenerTabla("PD_OBTENER_USUARIO", param);
			if (tabla.Rows.Count > 0)
			{
				string usuario = tabla.Rows[0]["usuario"].ToString();
				string perfil = tabla.Rows[0]["perfil"].ToString();
				lbl_Usuario.Text = "Usuario: " + usuario;
				lbl_Perfil.Text = "Perfil: " + tabla.Rows[0]["perfil"].ToString();

			}
		}

		/// <summary>
		/// Este evento de click va a remplazar el de cerrar la aplicación.
		/// </summary>	
		private void lbl_Cerrar_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		/// <summary>
		/// Este método va a crear un botón con todos los atributos, colores, tamaños, etc.
		/// específicos para la ventana.
		/// </summary>
		/// <param name="name">Nombre con el que se reconocerá al botón.</param>
		/// <param name="tag">Texto que se guardará en la propiedad Tag del botón.
		/// Normalmente será el nombre del user control que va a abrirse.</param>
		/// <returns>El botón creado.</returns>
		private Button crearBoton(string name, string tag)
		{
			Button button = new Button();
			button.Tag = tag;
			button.BackColor = Color.Transparent;
			button.Dock = DockStyle.Top;
			button.FlatStyle = FlatStyle.Flat;
			button.ForeColor = Color.White;
			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.MouseDownBackColor = Color.Transparent;
			button.FlatAppearance.MouseOverBackColor = Color.Aqua;
			button.Size = new Size(187, 45);
			button.Text = name;
			button.Font = new Font("Microsoft Sans Serif", 8.25f);
			return button;
		}

		/// <summary>
		/// Este método va a crear el panel que se abrirá con los botones de 
		/// módulo que contendrá todas las opciones de dicho módulo. El panel 
		/// tendrá todas las propiedades y atributos necesarios.
		/// </summary>
		/// <param name="name">Nombre con el que se reconocerá al panel.</param>
		/// <param name="btnHeight">Altura normal de los botones.</param>
		/// <param name="cantButtons">Cantidad de botones que tendrá dicho panel.</param>
		/// <returns></returns>
		private Panel crearPanelDropDown(string name, int btnHeight, int cantButtons)
		{
			Panel panel = new Panel();
			panel.Name = name;
			panel.BackColor = Color.DarkSlateGray;
			panel.Dock = DockStyle.Top;
			panel.Size = new Size(panel.Size.Width, btnHeight * cantButtons);
			pnl_Menu.Controls.Add(panel);
			panel.Visible = false;
			return panel;
		}

		/// <summary>
		/// Este método creará la vista para el constructor de recuperar contraseña. 
		/// Mostrará un botón de "Regresar" y añadirá el control de usuario "Recuperar Contraseña"
		/// a la vista principal.
		/// </summary>
		private void crearVistaRecuperarContraseña()
		{
			Button btn_Regresar = crearBoton("Regresar", "");
			pnl_Menu.Controls.Add(btn_Regresar);
			addUserControl(new UC_Recuperar_Contraseña());
			btn_Regresar.Click += (s, args) => { this.Dispose(); };
		}

		/// <summary>
		/// Este método creará la vista para el constructor de registro. 
		/// Mostrará un botón de "Regresar" y añadirá el control de usuario "Registrarse"
		/// a la vista principal.
		/// </summary>
		private void crearVistaRegistro()
		{
			Button btn_Regresar = crearBoton("Regresar", "");
			pnl_Menu.Controls.Add(btn_Regresar);
			addUserControl(new UC_Registrarse());
			btn_Regresar.Click += (s, args) => { this.Dispose(); };
		}
	}
}
