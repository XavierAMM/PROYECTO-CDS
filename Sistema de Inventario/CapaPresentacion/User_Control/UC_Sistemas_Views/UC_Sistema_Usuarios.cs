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
	/// Esta clase es la vista para activar o inactivar los usuarios.
	/// </summary>
	public partial class UC_Sistema_Usuarios : UserControl
	{
		private int modo;
		private int accion;
		private string procedureName;
		private CD_Parametros[] p;
		private DataTable usuarios;
		private CN_Validacion objectCN = new CN_Validacion();
		private int activar_desactivar = 0;

		/// <summary>
		/// Este es el constructor de la clase  que es la vista para 
		/// activar o inactivar los usuarios.
		/// </summary>
		public UC_Sistema_Usuarios()
		{
			InitializeComponent();
			modo = 0;
			procedureName = "PD_OBTENER_USUARIO_MODO";
			llenarTablaUsuarios();
		}

		/// <summary>
		/// Este método va a llenar los datos de la tabla de usuarios considerando si el
		/// textbox del filtro tiene contenido o no. Si lo tiene, entonces lo priorizará y 
		/// mostrará usuarios cuyo filtro contengan la cadena de texto.
		/// Caso contrario, mostrará todos los datos. Para ambos casos, se considerará el checkbox
		/// de mostrar inactivos.
		/// </summary>
		private void llenarTablaUsuarios()
		{
			if (txt_Filtro_Nombre.Text.Length > 0)
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@modo", modo),
					new CD_Parametros("@nombre", txt_Filtro_Nombre.Text),
				};
				procedureName = "PD_OBTENER_USUARIOS_FILTRAR";
			}
			else
			{
				p = new CD_Parametros[] { new CD_Parametros("@modo", modo) };
				procedureName = "PD_OBTENER_USUARIO_MODO";
			}
			usuarios = objectCN.obtenerTabla(procedureName, p);
			dgv_Usuarios.DataSource = usuarios;
			dgv_Usuarios.ClearSelection();
			cambiarColorInactivos(Color.Salmon);
		}

		/// <summary>
		/// Este método va a ponerle un color específico a las filas cuyo
		/// estado_id sea inactivo (2)
		/// </summary>
		/// <param name="c">El color de la fila.</param>
		private void cambiarColorInactivos(Color c)
		{
			foreach (DataGridViewRow r in dgv_Usuarios.Rows)
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
			llenarTablaUsuarios();
		}

		/// <summary>
		/// Este método se activará al darle click al botón Inactivar/Activar. Este
		/// va a activar el usuario si ya estaba inactivo o hará lo contrario. Va a 
		/// cancelar la operación si se intenta inactivar algun usuario cuyo perfil 
		/// sea 7 ya que ese es el administrador.
		/// </summary>	
		private void btn_Inactivar_Activar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgv_Usuarios.SelectedRows.Count > 0)
				{
					string msj = "";
					int usuario_id = (int)dgv_Usuarios.SelectedRows[0].Cells["usuario_id"].Value;
					int perfil_id = (int)dgv_Usuarios.SelectedRows[0].Cells["perfil_id"].Value;
					if (perfil_id == 7) throw new Exception("No se puede inactivar un usuario cuyo perfil es administrador.");
					if (activar_desactivar == 1) msj = "inactivar";
					else msj = "activar";
					DialogResult result = MessageBox.Show("¿Estás seguro que deseas " + msj + " el usuario " + usuario_id + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes) eliminarUsuario(usuario_id);
				}
				else throw new Exception("Selecciona un usuario de la lista.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Este método va a realizar la operación de inactivar/activar el usuario desde el SQL server.
		/// </summary>
		/// <param name="usuario_id">El id de la opción de perfil a inactivar/activar</param>
		private void eliminarUsuario(int usuario_id)
		{
			CD_Parametros[] para =
			{
				new CD_Parametros("@accion", activar_desactivar),
				new CD_Parametros("@usuario_id", usuario_id)
			};
			objectCN.actualizarTabla("PD_INACTIVAR_ACTIVAR_USUARIO", para);
			llenarTablaUsuarios();
			MessageBox.Show("Usuario actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Este método va a cambiar el botón de Activar/Inactivar dependiendo del
		/// estado_id del usuario seleccionado.
		/// </summary>
		private void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_Usuarios.SelectedRows.Count > 0)
			{
				DataGridViewRow r = dgv_Usuarios.SelectedRows[0];
				int estado_id = (int)r.Cells["estado_id"].Value;
				formaBotonActivarInactivar(estado_id);
			}
		}

		/// <summary>
		/// Este método va a cambiar el color y el texto del botón de activar o 
		/// inactivar dependiendo del usuario que se esté seleccionando.
		/// </summary>
		/// <param name="estado_id">Estado actual del usuario seleccionado</param>
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
		/// Este método va a llenar la tabla de usuarios filtrando el texto del textbox.
		/// </summary>
		private void txt_Filtro_Nombre_TextChanged(object sender, EventArgs e)
		{
			llenarTablaUsuarios();
		}
	}
}
