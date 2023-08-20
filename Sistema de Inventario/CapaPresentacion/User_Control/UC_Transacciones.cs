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
	}
}
