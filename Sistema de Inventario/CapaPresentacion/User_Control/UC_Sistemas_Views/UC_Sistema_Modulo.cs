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
    /// Esta clase es la vista para editar los módulos.
    /// </summary>
    public partial class UC_Sistema_Modulo : UserControl
    {
        private CN_Validacion objectCN = new CN_Validacion();
        private DataTable modulos;
        public UC_Sistema_Modulo(int usuario_id)
        {
            InitializeComponent();
            colocarDatosModulos(0);
            pnl_Actualizar.Visible = false;
        }

        private void colocarDatosModulos(int modo)
        {
            CD_Parametros[] p = { new CD_Parametros("@modo",modo) };
            modulos = objectCN.obtenerTabla("PD_OBTENER_MODULOS",p);
            dgv_Modulos.DataSource = modulos;
        }

        private void chb_Inactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Inactivos.Checked) colocarDatosModulos(1);
            else colocarDatosModulos(0);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            mostrarPanelActualizar("Nuevo Módulo...");
            txt_Orden.Text = (modulos.Rows.Count + 1).ToString();
        }

        private void mostrarPanelActualizar(string txt)
        {
            pnl_Actualizar.Visible = true;
            lbl_Mensaje.Text = txt;
        }

        private void lbl_Cancelar_Click(object sender, EventArgs e)
        {
            pnl_Actualizar.Visible = false;
        }
    }
}
