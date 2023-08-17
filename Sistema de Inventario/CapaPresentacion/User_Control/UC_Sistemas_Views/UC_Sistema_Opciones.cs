using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	/// <summary>
	/// Esta clase es la vista para editar las opciones de módulos.
	/// </summary>
	public partial class UC_Sistema_Opciones : UserControl
	{
		private int usuario_id;
		private int modo;
		private string procedureName;
		private CD_Parametros[] p;
		private DataTable opciones;
		private CN_Validacion objectCN = new CN_Validacion();

		/// <summary>
		/// Constructor para la clase que es la vista para editar las opciones de módulos.
		/// </summary>
		/// <param name="usuario_id">Id del usuario que ha ingresado al sistema.</param>
		public UC_Sistema_Opciones(int usuario_id)
		{
			InitializeComponent();
			modo = 0;
			procedureName = "PD_OBTENER_OPCIONES_MODO";
			llenarTablaOpciones();
			pnl_Actualizar.Visible = false;

		}

		/// <summary>
		/// Este método va a llenar los datos de la tabla de opciones de módulos considerando si el
		/// textbox del filtro tiene contenido o no. Si lo tiene, entonces lo priorizará y 
		/// mostrará módulos cuyo filtro contengan la cadena de texto.
		/// Caso contrario, mostrará todos los datos. Para ambos casos, se considerará el checkbox
		/// de mostrar inactivos.
		/// </summary>
		private void llenarTablaOpciones()
		{
			if (txt_Filtro_Nombre.Text.Length > 0)
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@modo", modo),
					new CD_Parametros("@nombre", txt_Filtro_Nombre.Text),
				};
				procedureName = "PD_OBTENER_OPCIONES_FILTRAR";
			}
			else
			{
				p = new CD_Parametros[] { new CD_Parametros("@modo", modo) };
				procedureName = "PD_OBTENER_OPCIONES_MODO";
			}
			opciones = objectCN.obtenerTabla(procedureName, p);
			dgv_Opciones.DataSource = opciones;
			dgv_Opciones.ClearSelection();
			cambiarColorInactivos(Color.Salmon);
		}

		/// <summary>
		/// Este método va a ponerle un color específico a las filas cuyo
		/// estado_id sea inactivo (2)
		/// </summary>
		/// <param name="c">El color de la fila.</param>
		private void cambiarColorInactivos(Color c)
		{
			foreach (DataGridViewRow r in dgv_Opciones.Rows)
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
			llenarTablaOpciones();
		}

		private void lbl_Cancelar_Click(object sender, EventArgs e)
		{
			pnl_Actualizar.Visible = false;
		}

		private void btn_Nuevo_Click(object sender, EventArgs e)
		{
			mostrarPanelActualizar("Nueva opción...");
		}

		/// <summary>
		/// Este método va a mostrar el panel izquierdo, ya sea para añadir un nuevo
		/// módulo o para editar uno.
		/// </summary>
		/// <param name="txt">El texto que aparecerá en el lado superior del 
		/// panel izquierdo.</param>
		private void mostrarPanelActualizar(string txt)
		{
			pnl_Actualizar.Visible = true;
			lbl_Mensaje.Text = txt;
		}


	}
}
