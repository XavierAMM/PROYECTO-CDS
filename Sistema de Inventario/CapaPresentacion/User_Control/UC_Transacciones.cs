using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
			lbl_Tipo_Unidad.Text = string.Empty;
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
				agregarTooltipCombobox(cmb_Bodega);
			}
		}

		private void cmb_Inventario_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Bodega.SelectedIndex != 0)
			{
				if (cmb_Inventario.SelectedIndex != 0)
				{
					activarPanelTablaProductos((int)cmb_Inventario.SelectedValue);
					cambiarColorExcesosFaltantes();
                    dgv_Productos.ClearSelection();
                    dgv_Temp_Transacciones.ClearSelection();
					agregarTooltipCombobox(cmb_Inventario);
                    return;
				}
			}
			pnl_Tabla_Productos.Enabled = false;
			pnl_Temp_Transaccion.Enabled = false;
            pnl_Producto.Enabled = false;
            dgv_Temp_Transacciones.DataSource = null;
			dgv_Productos.DataSource = null;
            limpiarFormulario(true);
		}

        /// <summary>
        /// Este método se activará cuando se eliga una opción en un combobox.
        /// Este mostrará un tooltip cuando el usuario ponga 
        /// el mouse encima de este en caso que no se alcance a leer.
        /// </summary>	
        /// <param name="cmb">El combobox ha añadirle el tooltip</param>
        private void agregarTooltipCombobox(ComboBox cmb)
        {
            if (cmb.SelectedIndex != -1)
            {
                string itemText = cmb.GetItemText(cmb.SelectedItem);
                cmbTooltip.SetToolTip(cmb, itemText);
            }
            else cmbTooltip.SetToolTip(cmb, "");
        }

        private void activarPanelTablaProductos(int inventario_id)
		{
			pnl_Tabla_Productos.Enabled = true;
			pnl_Temp_Transaccion.Enabled = true;
			CD_Parametros[] p = { new CD_Parametros("@inventario_id", inventario_id) };
			DataTable dt = objectCN.obtenerTabla("PD_OBTENER_PRODUCTOS_TRANSACCIONES", p);
			dgv_Productos.DataSource = dt;
			p = new CD_Parametros[] 
			{ 
				new CD_Parametros("@inventario_id", inventario_id),
                new CD_Parametros("@usuario_id", usuario_id)
            };
			dt = objectCN.obtenerTabla("PD_OBTENER_TEMP_TRANSACCION", p);
			dgv_Temp_Transacciones.DataSource = dt;			
		}

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dgv_Productos.Rows.Count > 0)
			{
				pnl_Producto.Enabled = true;
				DataGridViewRow r = dgv_Productos.Rows[0];
				llenarDatosProducto(r);
			}
        }

		private void limpiarFormulario(bool filtro)
		{
			txt_Nombre.Text = string.Empty;
			txt_Categoria.Text = string.Empty;
			txt_Proveedor.Text = string.Empty;
			txt_Cantidad.Text = string.Empty;
			txt_Cant_Min.Text = string.Empty;
			txt_Cant_Max.Text = string.Empty;
			txt_Ingresar_Cant.Text = string.Empty;
            lbl_Tipo_Unidad.Text = string.Empty;
            if (filtro) txt_Buscar.Text = string.Empty;
            pic_Warning_Cantidad.Visible = false;
            cmbTooltip.SetToolTip(pic_Warning_Cantidad, "");
            txt_Cantidad.BackColor = SystemColors.Control;
        }

		private void llenarDatosProducto(DataGridViewRow r)
		{
            if (dgv_Productos.Rows.Count > 0)
            {
				txt_Nombre.Text = r.Cells["nombre"].Value.ToString();
                txt_Categoria.Text = r.Cells["categoria"].Value.ToString();
                txt_Proveedor.Text = r.Cells["proveedor"].Value.ToString();
				txt_Cantidad.Text = r.Cells["cantidad"].Value.ToString();
                txt_Cant_Min.Text = r.Cells["cantidad_minima"].Value.ToString();
                txt_Cant_Max.Text = r.Cells["cantidad_maxima"].Value.ToString();
                lbl_Tipo_Unidad.Text = r.Cells["tipo_unidad"].Value.ToString();
				if (existenExcesosFaltantes(r))
				{
					pic_Warning_Cantidad.Visible = true;
					string warning = "La cantidad establecida supera o es inferior a los límites esttablecidos.";
					cmbTooltip.SetToolTip(pic_Warning_Cantidad, warning);
					txt_Cantidad.BackColor = Color.Salmon;
				}
				else 
				{ 
					pic_Warning_Cantidad.Visible = false;
                    cmbTooltip.SetToolTip(pic_Warning_Cantidad, "");
                    txt_Cantidad.BackColor = SystemColors.Control;
                }
            }
        }

        /// <summary>
        /// Este método va a controlar que en el textbox de Cantidad solo se ingresen
        /// números.
        /// </summary>
        private void txt_Ingresar_Cant_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar!='.') e.Handled = true;
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
			if(txt_Buscar.Text.Length > 0)
			{
                CD_Parametros[] p =
                {
                new CD_Parametros("@inventario_id", (int)cmb_Inventario.SelectedValue),
                new CD_Parametros("@filtro", txt_Buscar.Text)
				};
                DataTable dt = objectCN.obtenerTabla("PD_OBTENER_PRODUCTOS_TRANSACCIONES_FILTRO", p);
                dgv_Productos.DataSource = dt;
            }else activarPanelTablaProductos((int)cmb_Inventario.SelectedValue);
			
        }

        private bool existenExcesosFaltantes(DataGridViewRow r)
        {
            Decimal cantidad, cant_max, cant_min;
            if (Decimal.TryParse((string)r.Cells["cantidad"].Value.ToString(), NumberStyles.Number, new CultureInfo("en-US"), out cantidad))
            {
                if (Decimal.TryParse((string)r.Cells["cantidad_maxima"].Value.ToString(), NumberStyles.Number, new CultureInfo("en-US"), out cant_max))
                {
                    if (Decimal.TryParse((string)r.Cells["cantidad_minima"].Value.ToString(), NumberStyles.Number, new CultureInfo("en-US"), out cant_min))
                    {
						if (cantidad > cant_max || cantidad < cant_min) return true;
                    }
                }
            }
            return false;
        }

        
		private void cambiarColorExcesosFaltantes()
		{
			bool encontrado = false;
			foreach (DataGridViewRow r in dgv_Productos.Rows)
			{
				if (existenExcesosFaltantes(r)) {
					encontrado = true;
					r.DefaultCellStyle.BackColor = Color.Salmon;
				}
			}
            if (encontrado) pnl_Warning.Visible = true;
            else pnl_Warning.Visible = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
