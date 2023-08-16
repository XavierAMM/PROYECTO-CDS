using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        private int accion; // 0 = nuevo, 1 = editar.
        private DataGridViewRow modulo_editar;
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
            accionarCheckBoxInactivo();
        }

        private void accionarCheckBoxInactivo()
        {
            if (chb_Inactivos.Checked) colocarDatosModulos(1);
            else colocarDatosModulos(0);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            vaciarFormularios();
            mostrarPanelActualizar("Nuevo Módulo...");            
            cmb_Estado.Visible = false;
            accion = 0;
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

        private void txt_Orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txt_Objeto_Nuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            vaciarFormularios();
            if (dgv_Modulos.SelectedRows.Count > 0)
            {
                modulo_editar = dgv_Modulos.SelectedRows[0];
                int modulo_id = (int)modulo_editar.Cells["modulo_id"].Value;
                mostrarPanelActualizar("Editar Módulo " + modulo_id + "...");                
                cmb_Estado.Visible = true;
                accion = 1;
                llenarDatosEdicion();
            }
            else MessageBox.Show("Selecciona un módulo de la lista.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void llenarDatosEdicion()
        {            
            txt_Nombre.Text = modulo_editar.Cells["nombre"].Value.ToString();
            txt_Objeto.Text = modulo_editar.Cells["nombre_objeto"].Value.ToString();
            txt_Orden.Text = modulo_editar.Cells["orden"].Value.ToString();
            llenarComboBoxEstado(modulo_editar);
        }

        private void llenarComboBoxEstado(DataGridViewRow r)
        {
            DataTable dt = objectCN.obtenerVistaTabla("VISTA_ESTADO_A_I");
            cmb_Estado.DataSource = dt;
            cmb_Estado.DisplayMember = "nombre";
            cmb_Estado.ValueMember = "estado_id";
            cmb_Estado.SelectedValue = r.Cells["estado_id"].Value;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgv_Modulos.SelectedRows[0];
            if (validarFormularios())
            {
                CD_Parametros[] p = obtenerDatosModulo();
                if (accion == 0) objectCN.actualizarTabla("PD_AGREGAR_MODULO", p);
                else if (accion == 1) objectCN.actualizarTabla("PD_ACTUALIZAR_MODULO", p);
                MessageBox.Show("Cambios realizados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accionarCheckBoxInactivo();
                pnl_Actualizar.Visible = false;
            }
            else MessageBox.Show("Rellene todos los formularios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool validarFormularios()
        {
            if (txt_Nombre.Text != "" && txt_Objeto.Text != "" && txt_Orden.Text != "") return true;
            return false;
        }

        private CD_Parametros[] obtenerDatosModulo()
        {
            CD_Parametros[] p = null;
            if (accion == 0) // Nuevo
            {
                p = new CD_Parametros[]
                { 
                    new CD_Parametros("@nombre", txt_Nombre.Text.Trim()),
                    new CD_Parametros("@nombre_objeto", txt_Objeto.Text.Trim()),
                    new CD_Parametros("@orden", txt_Orden.Text.Trim())
                };
            }
            else
            {
                p = new CD_Parametros[]
                 {
                    new CD_Parametros("@modulo_id", (int)modulo_editar.Cells["modulo_id"].Value),
                    new CD_Parametros("@nombre", txt_Nombre.Text.Trim()),
                    new CD_Parametros("@nombre_objeto", txt_Objeto.Text.Trim()),
                    new CD_Parametros("@estado_id", (int)cmb_Estado.SelectedValue),
                    new CD_Parametros("@orden", txt_Orden.Text.Trim())
                 };
            }
            return p;
        }

        private void vaciarFormularios()
        {
            txt_Nombre.Text = string.Empty;
            txt_Objeto.Text = string.Empty;
            txt_Orden.Text = string.Empty;
            cmb_Estado.SelectedIndex = 0;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Modulos.SelectedRows.Count > 0)
            {
                int modulo_id = (int)dgv_Modulos.SelectedRows[0].Cells["modulo_id"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar el módulo " + modulo_id + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    CD_Parametros[] p ={new CD_Parametros("@modulo_id",modulo_id)};
                    objectCN.actualizarTabla("PD_ELIMINAR_MODULO", p);
                    accionarCheckBoxInactivo();
                    MessageBox.Show("Módulo eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                              
            }
            else MessageBox.Show("Selecciona un módulo de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
