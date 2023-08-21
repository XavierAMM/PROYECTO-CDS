using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.User_Control
{

    /// <summary>
    /// Esta clase va a mostrar todos las transacciones hechas.
    /// </summary>
    public partial class UC_Ver_Movimientos : UserControl
    {
        private ToolTip cmbTooltip = new ToolTip();
        private CN_Validacion objectCN = new CN_Validacion();

        /// <summary>
        /// Constructor de la clase que va a mostrar todos las transacciones hechas.
        /// </summary>
        /// <param name="usuario_id"></param>
        public UC_Ver_Movimientos(int usuario_id)
        {
            InitializeComponent();
            CD_Parametros[] p = { new CD_Parametros("@usuario_id", usuario_id) };
            llenarComboBox(cmb_Bodega, "VISTA_BODEGAS", "bodega_id", "Seleccione bodega...");
        }

        /// <summary>
		/// Este método va a llenar el combobox con su table indicada.
		/// </summary>
		/// <param name="cmb">El combobox a llenarle datos</param>
		/// <param name="procedureName">El nombre del procedimiento a llamar</param>
		/// <param name="p">Parámetro del procedureName en el SQL Server</param>
		/// <param name="valueMember">El id del dato. Ej. "modulo_id"</param>
		/// <param name="textoMostrar">El texto que se mostrará al no elegir uno.</param>
		private void llenarComboBox(ComboBox cmb, String procedureName, String valueMember, String textoMostrar)
        {
            cmbTooltip.SetToolTip(cmb, "");
            DataTable dt = objectCN.obtenerVistaTabla(procedureName);
            cmb.DataSource = dt;
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = valueMember;
            cmbAgregarTextoMuestra(cmb, valueMember, textoMostrar);
            cmb.SelectedIndex = 0;
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

        private void cmb_Inventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Bodega.SelectedIndex != 0)
            {
                if (cmb_Inventario.SelectedIndex != 0)
                {
                    pnl_Filtro.Enabled = true;
                    pnl_Tabla.Enabled = true;
                    llenarTabla();
                    agregarTooltipCombobox(cmb_Inventario);
                    return;
                }
            }
            pnl_Filtro.Enabled = false;
            pnl_Tabla.Enabled = false;
            dgv_Transacciones.DataSource = null;
        }

        private void llenarTabla()
        {
            int inv_id = (int)cmb_Inventario.SelectedValue;
            CD_Parametros[] p =
            {
                        new CD_Parametros("@inventario_id",inv_id),
                        new CD_Parametros("@fecha_min", date_Fecha_Min.Value),
                        new CD_Parametros("@fecha_max", date_Fecha_Max.Value),
                    };
            DataTable dt = objectCN.obtenerTabla("PD_OBTENER_TRANSACCION_SEGUN_INVENTARIO", p);
            dgv_Transacciones.DataSource = dt;
            dgv_Transacciones.ClearSelection();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Length > 0)
            {
                int inv_id = (int)cmb_Inventario.SelectedValue;
                CD_Parametros[] p =
                {
                        new CD_Parametros("@inventario_id",inv_id),
                        new CD_Parametros("@fecha_min", date_Fecha_Min.Value),
                        new CD_Parametros("@fecha_max", date_Fecha_Max.Value),
                        new CD_Parametros("@filtro", txt_Buscar.Text)
                    };
                DataTable dt = objectCN.obtenerTabla("PD_OBTENER_TRANSACCION_SEGUN_INVENTARIO_FILTRO", p);
                dgv_Transacciones.DataSource = dt;
                dgv_Transacciones.ClearSelection();
            }
            else llenarTabla();            
            
        }

    }
}
