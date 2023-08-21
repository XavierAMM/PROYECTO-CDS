using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.User_Control
{
	/// <summary>
	/// Esta clase va a contener la vista del formulario de registro. 
	/// El usuario ingresará todos los datos necesarios para crear una cuenta 
	/// en el sistema. El perfil por defecto será "Consultor".
	/// </summary>
	public partial class UC_Registrarse : UserControl
	{
		private CN_Validacion objectCN = new CN_Validacion();
		private ToolTip cmbToolTip = new ToolTip();

		/// <summary>
		/// Esta clase va a contener la vista del formulario de registro. 
		/// El usuario ingresará todos los datos necesarios para crear una cuenta 
		/// en el sistema. El perfil por defecto será "Consultor".
		/// </summary>
		public UC_Registrarse()
		{
			InitializeComponent();
			pnl_Mensaje.Visible = false;
			inicializarComboBox();
		}

		/// <summary>
		/// Este método va a llenar el combobox de la pregunta de seguridad. Ingresará 
		/// al procedimiento almacenado y obtendrá la vista de la tabla "Tipo_Pregunta".
		/// </summary>
		private void inicializarComboBox()
		{
			cmbToolTip.SetToolTip(cmb_Pregunta_Seguridad, "");
			DataTable dt = objectCN.obtenerVistaTabla("VIEW_TIPO_PREGUNTA");
			cmb_Pregunta_Seguridad.DataSource = dt;
			cmb_Pregunta_Seguridad.DisplayMember = "pregunta";
			cmb_Pregunta_Seguridad.ValueMember = "tipo_pregunta_id";
			comboboxAñadirTextoMuestra(dt);
			cmb_Pregunta_Seguridad.SelectedIndex = 0;
		}

		/// <summary>
		/// Este método va a añadir el elemento 0 al combobox de la pregunta de seguridad.
		/// Este será únicamente una opción que diga "Seleccione Pregunta de Seguridad * ".
		/// </summary>
		/// <param name="dt">Vista de la tabla de tipo pregunta.</param>
		private void comboboxAñadirTextoMuestra(DataTable dt)
		{
			DataRow newRow = dt.NewRow();
			newRow["tipo_pregunta_id"] = 0;
			newRow["pregunta"] = "Seleccione Pregunta de Seguridad *";
			newRow["estado_id"] = 1;
			dt.Rows.InsertAt(newRow, 0);
		}

		/// <summary>
		/// Este botón obtendrá todos los datos del formulario y los validará antes de guardarlos en
		/// las respectivas tablas.
		/// </summary>		
		private void btn_Registrarse_Click(object sender, EventArgs e)
		{
			try
			{
				CD_Parametros[] persona = obtenerDatosPersona();				
				int persona_id = objectCN.obtenerDatoEntero("PD_AÑADIR_NUEVA_PERSONA", persona);
                CD_Parametros[] usuario = obtenerDatosUsuario(persona_id);
                objectCN.actualizarTabla("PD_AÑADIR_NUEVO_USUARIO", usuario);
				esconderMensajeError();
				vaciarFormularios();
				MessageBox.Show("Usuario creado con éxito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				mensajeError(ex.Message);
			}
		}

		/// <summary>
		/// Este método va a limpiar todos los elementos del formulario para que el usuario pueda
		/// registrar otro usuario si así lo desea. Este método solo se ejecutará después de haber
		/// registrado satisfactoriamente un usuario.
		/// </summary>
		private void vaciarFormularios()
		{
			txt_Nombre.Text = string.Empty;
			txt_Apellido.Text = string.Empty;
			txt_Telefono.Text = string.Empty;
			txt_Correo.Text = string.Empty;
			date_Fecha_Nacimiento.Text = string.Empty;
			txt_Usuario.Text = string.Empty;
			txt_Contraseña.Text = string.Empty;
			txt_Contraseña2.Text = string.Empty;
			cmb_Pregunta_Seguridad.SelectedIndex = 0;
			txt_Respuesta_Pregunta.Text = string.Empty;
		}

		/// <summary>
		/// Este método va a guardar los datos de tipo usuario del formulario y los validará antes de
		/// hacer el return.
		/// </summary>
		/// <param name="persona_id">El id de los datos de la persona para ser asignado al 
		/// nuevo usuario.</param>
		/// <returns>Un objeto de tipo parámetros con todos los valores necesarios para registrar 
		/// un nuevo usuario.</returns>
		/// <exception cref="Exception">Error cuando el usuario ya existe, cuando no se ha elegido 
		/// una pregunta de seguridad o cuando las contraseñas son diferentes.</exception>
		private CD_Parametros[] obtenerDatosUsuario(int persona_id)
		{
			string usuario = txt_Usuario.Text.Trim();
			string contraseña = txt_Contraseña.Text;
			string contraseña2 = txt_Contraseña2.Text;
			int tipo_pregunta_id = (int)cmb_Pregunta_Seguridad.SelectedValue;
			string respuesta_pregunta = txt_Respuesta_Pregunta.Text.Trim();
			if (contraseña == contraseña2)
			{
				if (tipo_pregunta_id != 0)
				{
					CD_Parametros[] param = { new CD_Parametros("@usuario", usuario) };
					if (objectCN.obtenerDatoEntero("PD_USUARIO_UNICO", param) == 1)
					{
						return new CD_Parametros[]
						{
                            new CD_Parametros("@persona_id", persona_id),
                            new CD_Parametros("@usuario", usuario),
							new CD_Parametros("@contraseña", contraseña),
							new CD_Parametros("@tipo_pregunta_id", tipo_pregunta_id),
							new CD_Parametros("@respuesta_pregunta", respuesta_pregunta),
						};
					}
					else throw new Exception("Ya existe un usuario con ese nombre.");
				}
				else throw new Exception("Elija una pregunta de seguridad.");
			}
			else throw new Exception("Las contraseñas deben ser iguales.");
		}

		/// <summary>
		/// Este método va a guardar los datos de tipo persona del formulario y los validará antes de
		/// hacer el return.
		/// </summary>
		/// <returns>Un objeto de tipo parámetros con todos los valores necesarios para registrar 
		/// un nueva persona</returns>
		/// <exception cref="Exception">Error si el número de teléfono no tiene 10 dígitos.</exception>
		private CD_Parametros[] obtenerDatosPersona()
		{
			string nombre1 = txt_Nombre.Text.Trim();
			string apellido1 = txt_Apellido.Text.Trim();
			string telefono = txt_Telefono.Text.Trim();
			string correo = txt_Correo.Text.Trim();
			DateTime fecha_nacimmiento = date_Fecha_Nacimiento.Value;
			if (telefono == "" || (telefono != "" && telefono.Length == 10))
			{
				return new CD_Parametros[]
				{
				new CD_Parametros("@nombre1", nombre1),
				new CD_Parametros("@apellido1", apellido1),
				new CD_Parametros("@telefono", telefono),
				new CD_Parametros("@correo_electronico", correo),
				new CD_Parametros("@fecha_nacimiento", fecha_nacimmiento)
				};
			}
			else throw new Exception("El número de teléfono debe tener 10 dígitos");
		}

		/// <summary>
		/// Este método activará el panel del mensaje de error y mostrará el mensaje querido.
		/// </summary>
		/// <param name="msg">El mensaje de error que se mostrará en la etiqueta.</param>
		private void mensajeError(string msg)
		{
			lbl_Mensaje.Text = msg;
			pnl_Mensaje.Visible = true;
		}

		/// <summary>
		/// Este método ocultará el panel del mensaje de error.
		/// </summary>
		private void esconderMensajeError()
		{
			pnl_Mensaje.Visible = false;
		}

		/// <summary>
		/// Este método se activará cuando se eliga una opción en el combobox de 
		/// pregunta de seguridad. Este mostrará un tooltip cuando el usuario ponga 
		/// el mouse encima de la pregunta en caso que no se alcance a leer toda.
		/// </summary>		
		private void cmb_Pregunta_Seguridad_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Pregunta_Seguridad.SelectedIndex != -1)
			{
				string itemText = cmb_Pregunta_Seguridad.GetItemText(cmb_Pregunta_Seguridad.SelectedItem);
				cmbToolTip.SetToolTip(cmb_Pregunta_Seguridad, itemText);
			}
			else cmbToolTip.SetToolTip(cmb_Pregunta_Seguridad, "");
		}

		/// <summary>
		/// Este método valida si el botón presionado dentro del textbox
		/// sea una letra, caso contrario, no lo pone.
		/// </summary>		
		private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = true; }
		}

		/// <summary>
		/// Este método valida si el botón presionado dentro del textbox
		/// sea una letra, caso contrario, no lo pone.
		/// </summary>		
		private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) { e.Handled = true; }
		}

		/// <summary>
		/// Este método valida si el botón presionado dentro del textbox
		/// sea un número, que no pase de 10 dígitos y que no hayan espacios 
		/// en blanco, caso contrario, no lo pone.
		/// </summary>		
		private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) || txt_Telefono.TextLength >= 10 || Char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
		}

		/// <summary>
		/// Va a evaluar que en correo no se ingresen espacios en blanco.
		/// </summary>
		private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
		}

		/// <summary>
		/// Va a evaluar que en correo no se ingresen espacios en blanco.
		/// </summary>
		private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
		}
	}
}
