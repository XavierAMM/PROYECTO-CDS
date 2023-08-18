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

namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	/// <summary>
	/// Esta clase es la vista para editar los perfiles.
	/// </summary>
	public partial class UC_Sistema_Perfil : UserControl
	{
		private int modo;
		private int accion;
		private string procedureName;
		private DataGridViewRow perfil_editar;
		private CD_Parametros[] p;
		private DataTable perfiles;
		private CN_Validacion objectCN = new CN_Validacion();
		private ToolTip cmbTooltip = new ToolTip();
		private int activar_desactivar = 0;

		/// <summary>
		/// Constructor para la clase que es la vista para editar los perfiles.
		/// </summary>
		public UC_Sistema_Perfil()
		{
			InitializeComponent();
			modo = 0;
			procedureName = "PD_OBTENER_PERFILES_MODO";
			llenarTablaPerfiles();
			pnl_Actualizar.Visible = false;
		}

		/// <summary>
		/// Este método va a llenar los datos de la tabla de perfiles considerando si el
		/// textbox del filtro tiene contenido o no. Si lo tiene, entonces lo priorizará y 
		/// mostrará perfiles cuyo filtro contengan la cadena de texto.
		/// Caso contrario, mostrará todos los datos. Para ambos casos, se considerará el checkbox
		/// de mostrar inactivos.
		/// </summary>
		private void llenarTablaPerfiles()
		{
			if (txt_Filtro_Nombre.Text.Length > 0)
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@modo", modo),
					new CD_Parametros("@nombre", txt_Filtro_Nombre.Text),
				};
				procedureName = "PD_OBTENER_PERFILES_FILTRAR";
			}
			else
			{
				p = new CD_Parametros[] { new CD_Parametros("@modo", modo) };
				procedureName = "PD_OBTENER_PERFILES_MODO";
			}
			perfiles = objectCN.obtenerTabla(procedureName, p);
			dgv_Perfiles.DataSource = perfiles;
			dgv_Perfiles.ClearSelection();
			cambiarColorInactivos(Color.Salmon);
		}

		/// <summary>
		/// Este método va a ponerle un color específico a las filas cuyo
		/// estado_id sea inactivo (2)
		/// </summary>
		/// <param name="c">El color de la fila.</param>
		private void cambiarColorInactivos(Color c)
		{
			foreach (DataGridViewRow r in dgv_Perfiles.Rows)
			{
				if ((int)r.Cells["estado_id"].Value == 2)
					r.DefaultCellStyle.BackColor = c;
			}
		}

		/// <summary>
		/// Este método se ejecutará cuando un el checkbox se active o desactive.
		/// </summary>	
		private void chb_Inactivos_CheckedChanged(object sender, EventArgs e)
		{
			if (chb_Inactivos.Checked) modo = 1;
			else modo = 0;
			llenarTablaPerfiles();
		}

		/// <summary>
		/// Este método se ejecutará cuando se haga clic en el botón "Nuevo"
		/// </summary>	
		private void btn_Nuevo_Click(object sender, EventArgs e)
		{
			vaciarFormularios();
			mostrarPanelActualizar("Nuevo perfil");
			accion = 0;
			DataRow[] r = perfiles.Select($"perfil_id = {7}");
			int prioridad = (int)r[0]["prioridad"];
			txt_Prioridad.Text = (prioridad - 1).ToString();
		}

		/// <summary>
		/// Este método va a vaciar los formularios después de haber añadido uno
		/// nuevo o de haber editado.
		/// </summary>
		private void vaciarFormularios()
		{
			txt_Nombre.Text = string.Empty;
			txt_Descripcion.Text = string.Empty;
			txt_Prioridad.Text = string.Empty;
		}

		/// <summary>
		/// Este método va a mostrar el panel izquierdo, ya sea para añadir un nuevo
		/// perfil o para editar uno.
		/// </summary>
		/// <param name="txt">El texto que aparecerá en el lado superior del 
		/// panel izquierdo.</param>
		private void mostrarPanelActualizar(string txt)
		{
			pnl_Actualizar.Visible = true;
			lbl_Mensaje.Text = txt;
		}

		/// <summary>
		/// Este método se ejecutará cuando se haga clic a la "X" en el panel de
		/// editar o añadir nuevo módulo.
		/// </summary>
		private void lbl_Cancelar_Click(object sender, EventArgs e)
		{
			pnl_Actualizar.Visible = false;
		}

		/// <summary>
		/// Este método se ejecutará cuando se quiera editar un perfil. Se debe hacer
		/// clic en una fila de la tabla y se abrirá el panel izquierdo con los datos
		/// del perfil seleccionado.
		/// </summary>
		private void btn_Editar_Click(object sender, EventArgs e)
		{
			vaciarFormularios();
			if (dgv_Perfiles.SelectedRows.Count > 0)
			{
				perfil_editar = dgv_Perfiles.SelectedRows[0];
				int perfil_id = (int)perfil_editar.Cells["perfil_id"].Value;
				if (perfil_id == 7) txt_Nombre.Enabled = false;
				else txt_Nombre.Enabled = true;
				mostrarPanelActualizar("Editar Perfil " + perfil_id);
				accion = 1;
				llenarDatosEdicion();
			}
			else MessageBox.Show("Selecciona un perfil de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// Este método va a llenar los textbox con la información del perfil que se
		/// quiera editar.
		/// </summary>
		private void llenarDatosEdicion()
		{
			txt_Nombre.Text = perfil_editar.Cells["nombre"].Value.ToString();
			txt_Descripcion.Text = perfil_editar.Cells["descripcion"].Value.ToString();
			txt_Prioridad.Text = perfil_editar.Cells["prioridad"].Value.ToString();
		}

		/// <summary>
		/// Este método se ejecutará al dar clic al botón aceptar al querer añadir
		/// un nuevo perfil o al editar uno. Recogerá los datos de los textbox y
		/// ejecutará el comando respectivo (nuevo o editar).
		/// </summary>	
		private void btn_Aceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (validarFormularios())
				{
					validarPrioridad();
					CD_Parametros[] p = obtenerDatosPerfil();
					if (accion == 0) objectCN.actualizarTabla("PD_AGREGAR_PERFIL", p);
					else if (accion == 1) objectCN.actualizarTabla("PD_EDITAR_PERFIL", p);
					MessageBox.Show("Cambios realizados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					llenarTablaPerfiles();
					pnl_Actualizar.Visible = false;
				}
				else throw new Exception("Rellene todos los formularios.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Este método va a validar que la prioridad ingresada no sea mayor al del
		/// administrador. O, si estamos editando al administrador, que su prioridad
		/// siempre sea la más alta.
		/// </summary>
		/// <exception cref="Exception"></exception>
		private void validarPrioridad()
		{
			DataRow[] r = perfiles.Select($"perfil_id = {7}");
			int prioridad_admin = (int)r[0]["prioridad"];
			if (accion == 1 && (int)perfil_editar.Cells["perfil_id"].Value == 7)
			{
				CD_Parametros[] para = { new CD_Parametros("@modo",1)};
				DataTable dt = objectCN.obtenerTabla("PD_OBTENER_PERFILES_MODO", para);
				int maxPrio = 0;
				foreach(DataRow i in dt.Rows)
				{
					int currentPrio = (int)i["prioridad"];
					if(currentPrio > maxPrio && (int)i["perfil_id"] != 7) maxPrio = currentPrio;
				}
				if (int.Parse(txt_Prioridad.Text) <= maxPrio) throw new Exception("El adminisitrador debe tener la prioridad más alta.");
			}
			else
			{
				if (int.Parse(txt_Prioridad.Text) >= prioridad_admin)
				throw new Exception("Un perfil no puede tener una prioridad mayor al del administrador (" + prioridad_admin + ")");
			}
		}

		/// <summary>
		/// Este método va a obtener los datos de los formularios para ser enviados
		/// como parámetros al SQL Server.
		/// </summary>
		/// <returns>Un arreglo CD_Parametro de los datos del perfil.</returns>
		private CD_Parametros[] obtenerDatosPerfil()
		{
			CD_Parametros[] p = null;
			if (accion == 0) // Nuevo
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@nombre", txt_Nombre.Text.Trim()),
					new CD_Parametros("@descripcion", txt_Descripcion.Text),
					new CD_Parametros("@prioridad", txt_Prioridad.Text.Trim())
				};
			}
			else
			{
				p = new CD_Parametros[]
				 {
					new CD_Parametros("@perfil_id", (int)perfil_editar.Cells["perfil_id"].Value),
					new CD_Parametros("@nombre", txt_Nombre.Text.Trim()),
					new CD_Parametros("@descripcion", txt_Descripcion.Text),
					new CD_Parametros("@prioridad", txt_Prioridad.Text.Trim())
				 };
			}
			return p;
		}

		/// <summary>
		/// Este método va a evaluar si los formularios del panel izquierdo están
		/// vacíos o no.
		/// </summary>
		/// <returns>True si no están vacíos, False si uno está vacío.</returns>
		private bool validarFormularios()
		{
			if (txt_Descripcion.Text.Trim() == "") txt_Descripcion.Text = " ";
			return txt_Nombre.Text != "" && txt_Prioridad.Text != "";
		}

		/// <summary>
		/// Este método se activará al darle click al botón Inactivar/Activar. Este
		/// va a activar la opción si ya estaba inactivo o hará lo contrario. Va a 
		/// cancelar la operación si se intenta inactivar el perfil con id 7 ya que
		/// ese es el perfil de administrador.		
		/// </summary>	
		private void btn_Inactivar_Activar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgv_Perfiles.SelectedRows.Count > 0)
				{
					string msj = "";
					int perfil_id = (int)dgv_Perfiles.SelectedRows[0].Cells["perfil_id"].Value;
					if (perfil_id == 7) throw new Exception("No se puede inactivar ese perfil.");
					if (activar_desactivar == 1) msj = "inactivar";
					else msj = "activar";
					DialogResult result = MessageBox.Show("¿Estás seguro que deseas " + msj + " el perfil " + perfil_id + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes) eliminarPerfil(perfil_id);
				}
				else throw new Exception("Selecciona un perfil de la lista.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Este método va a realizar la operación de inactivar/activar el perfil desde el SQL server.
		/// </summary>
		/// <param name="modulo_id">El id del perfil a inactivar/activar</param>
		private void eliminarPerfil(int perfil_id)
		{
			CD_Parametros[] para =
			{
				new CD_Parametros("@accion", activar_desactivar),
				new CD_Parametros("@perfil_id", perfil_id)
			};
			objectCN.actualizarTabla("PD_INACTIVAR_ACTIVAR_PERFIL", para);
			llenarTablaPerfiles();
			MessageBox.Show("Perfil actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Este método va a cambiar el botón de Activar/Inactivar dependiendo del
		/// estado_id del perfil seleccionado.
		/// </summary>
		private void dgv_Perfiles_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_Perfiles.SelectedRows.Count > 0)
			{
				DataGridViewRow r = dgv_Perfiles.SelectedRows[0];
				int estado_id = (int)r.Cells["estado_id"].Value;
				formaBotonActivarInactivar(estado_id);
			}
		}

		/// <summary>
		/// Este método va a cambiar el color y el texto del botón de activar o 
		/// inactivar dependiendo del perfil que se esté seleccionando.
		/// </summary>
		/// <param name="estado_id">Estado actual del perfil seleccionado</param>
		private void formaBotonActivarInactivar(int estado_id)
		{
			if (estado_id == 1)
			{
				btn_Inactivar_Activar.BackColor = Color.Red;
				btn_Inactivar_Activar.Text = "Inactivar";
			}
			else if (estado_id == 2)
			{
				btn_Inactivar_Activar.BackColor = Color.Blue;
				btn_Inactivar_Activar.Text = "Activar";
			}
			activar_desactivar = estado_id;
		}

		/// <summary>
		/// Este método va a llenar la tabla de perfiles filtrando el texto del textbox.
		/// </summary>
		private void txt_Filtro_Nombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			llenarTablaPerfiles();
		}

		/// <summary>
		/// Este método va a controlar que en el textbox de prioridad solo se ingresen
		/// números.
		/// </summary>
		private void txt_Prioridad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
		}
	}
}
