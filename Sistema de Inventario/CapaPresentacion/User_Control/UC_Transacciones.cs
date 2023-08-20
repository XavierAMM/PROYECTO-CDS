using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.User_Control
{

	/// <summary>
	/// Esta clase va a realizar las transacciones en el sistema de inventarios.
	/// </summary>
	public partial class UC_Transacciones : UserControl
	{
		private int usuario_id;
		private ToolTip cmbTooltip = new ToolTip();
		private CN_Validacion objectCN = new CN_Validacion();

		/// <summary>
		/// Constructor de la clase que va a realizar las transacciones en el sistema de inventarios.
		/// </summary>
		/// <param name="usuario_id">Id del usuario que ingresó al sistema</param>
		public UC_Transacciones(int usuario_id)
		{
			this.usuario_id = usuario_id;
			InitializeComponent();
			CD_Parametros[] p = { new CD_Parametros("@usuario_id", usuario_id) };
			llenarComboBox(cmb_Bodega, "PD_OBTENER_BODEGA_USUARIO_ID", p, "bodega_id", "Seleccione bodega...");
		}

		private void evaluarUsuarioTieneBodega(CD_Parametros[] p)
		{

		}

		/// <summary>
		/// Este método va a llenar el combobox con su table indicada.
		/// </summary>
		/// <param name="cmb">El combobox a llenarle datos</param>
		/// <param name="procedureName">El nombre del procedimiento a llamar</param>
		/// <param name="p">Parámetro del procedureName en el SQL Server</param>
		/// <param name="valueMember">El id del dato. Ej. "modulo_id"</param>
		/// <param name="textoMostrar">El texto que se mostrará al no elegir uno.</param>
		private void llenarComboBox(ComboBox cmb, String procedureName, CD_Parametros[] p, String valueMember, String textoMostrar)
		{
			cmbTooltip.SetToolTip(cmb, "");
			DataTable dt = objectCN.obtenerTabla(procedureName, p);
			cmb.DataSource = dt;
			cmb.DisplayMember = "nombre";
			cmb.ValueMember = valueMember;
			cmbAgregarTextoMuestra(cmb, valueMember, textoMostrar);
			cmb.SelectedIndex = 0;
		}

		/// <summary>
		/// Este método va a añadir el elemento 0 al combobox indicado.
		/// Este será únicamente una opción que diga "Seleccione xxxx...".
		/// </summary>
		/// <param name="cmb">El combobox a llenarle datos</param>		
		/// <param name="valueMember">El id del dato. Ej. "modulo_id"</param>
		/// <param name="displayText">El texto que se mostrará al no elegir uno.</param>
		private void cmbAgregarTextoMuestra(ComboBox cmb, string valueMember, string displayText)
		{
			DataRow newRow = ((DataTable)cmb.DataSource).NewRow();
			foreach (DataColumn column in ((DataTable)cmb.DataSource).Columns)
			{
				newRow[column.ColumnName] = column.DataType.IsValueType ? Activator.CreateInstance(column.DataType) : null;
			}
			newRow[((DataTable)cmb.DataSource).Columns[0].ColumnName] = 0;
			newRow[((DataTable)cmb.DataSource).Columns[1].ColumnName] = displayText;

			((DataTable)cmb.DataSource).Rows.InsertAt(newRow, 0);
		}

		private void cmb_Bodega_Click(object sender, EventArgs e)
		{
			CD_Parametros[] p = { new CD_Parametros("@usuario_id", usuario_id) };
			int result = objectCN.obtenerDatoEntero("PD_EVALUAR_PERSONAL_TIENE_BODEGA", p);
			if (result == 0) MessageBox.Show("Usted no cuenta con ninguna bodega asignada. Por favor, póngase en contacto con algún encargado de bodegas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void cmb_Bodega_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Bodega.SelectedIndex == 0)
			{
				cmb_Inventario.Enabled = false;
				cmb_Inventario.DataSource = null;
			}
			else
			{
				cmb_Inventario.Enabled = true;
				int bodega_id = (int)cmb_Bodega.SelectedValue;
				CD_Parametros[] p = { new CD_Parametros("@bodega_id", bodega_id) };
				llenarComboBox(cmb_Inventario, "PD_OBTENER_INVENTARIO_SEGUN_BODEGA_ID", p, "inventario_id", "Seleccionar inventario...");
			}
		}

		private void cmb_Inventario_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Bodega.SelectedIndex != 0)
			{
				if (cmb_Inventario.SelectedIndex != 0)
				{
					activarPanelTablaProductos((int)cmb_Inventario.SelectedValue);
					return;
				}
			}
			pnl_Tabla_Productos.Enabled = false;
		}

		private void activarPanelTablaProductos(int inventario_id)
		{
			pnl_Tabla_Productos.Enabled = true;
			pnl_Temp_Transaccion.Enabled = true;
			CD_Parametros[] p = { new CD_Parametros("@inventario_id", inventario_id) };
			DataTable dt = objectCN.obtenerTabla("PD_OBTENER_PRODUCTOS_TRANSACCIONES", p);
			dgv_Productos.DataSource = dt;
			// llenar aqui la tabla de temp transaccion
		}
	}
}
