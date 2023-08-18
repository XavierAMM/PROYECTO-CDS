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
		private int modo;
		private int accion;
		private string procedureName;
		private DataGridViewRow opcion_editar;
		private CD_Parametros[] p;
		private DataTable opciones;
		private CN_Validacion objectCN = new CN_Validacion();
		private ToolTip cmbTooltip = new ToolTip();
		private int activar_desactivar = 0;

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
			llenarComboBoxModulos();
			pnl_Actualizar.Visible = false;

		}

		/// <summary>
		/// Este método va a llenar el combobox de módulos. 
		/// </summary>
		private void llenarComboBoxModulos()
		{
			cmbTooltip.SetToolTip(cmb_Modulos, "");
			DataTable modulos = objectCN.obtenerVistaTabla("VISTA_OBTENER_MODULOS");
			cmb_Modulos.DataSource = modulos;
			cmb_Modulos.DisplayMember = "nombre";
			cmb_Modulos.ValueMember = "modulo_id";
			cmbAgregarTextoMuestra(modulos);
			cmb_Modulos.SelectedIndex = 0;
		}

		/// <summary>
		/// Este método va a añadir el elemento 0 al combobox de módulos.
		/// Este será únicamente una opción que diga "Seleccione módulo...".
		/// </summary>
		/// <param name="dt">Vista de la tabla de módulos.</param>
		private void cmbAgregarTextoMuestra(DataTable dt)
		{
			DataRow r = dt.NewRow();
			r["modulo_id"] = 0;
			r["nombre"] = "Seleccione módulo...";
			r["estado_id"] = 1;
			dt.Rows.InsertAt(r, 0);
		}

		/// <summary>
		/// Este método va a llenar los datos de la tabla de opciones de módulos considerando si el
		/// textbox del filtro tiene contenido o no. Si lo tiene, entonces lo priorizará y 
		/// mostrará opciones cuyo filtro contengan la cadena de texto.
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

		/// <summary>
		/// Este método se ejecutará cuando se haga clic en el botón "Nuevo"
		/// </summary>	
		private void btn_Nuevo_Click(object sender, EventArgs e)
		{
			vaciarFormularios();
			mostrarPanelActualizar("Nueva opción");
			accion = 0;
			txt_Orden.Text = (opciones.Rows.Count + 1).ToString();
		}

		/// <summary>
		/// Este método va a vaciar los formularios después de haber añadido uno
		/// nuevo o de haber editado.
		/// </summary>
		private void vaciarFormularios()
		{
			txt_Nombre.Text = string.Empty;
			txt_Objeto.Text = string.Empty;
			cmb_Modulos.SelectedIndex = 0;
			txt_Descripcion.Text = string.Empty;
			txt_Orden.Text = string.Empty;
		}

		/// <summary>
		/// Este método va a mostrar el panel izquierdo, ya sea para añadir una nueva
		/// opción o para editar uno.
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
		/// Este método se activará cuando se eliga una opción en el combobox de 
		/// módulos. Este mostrará un tooltip cuando el usuario ponga 
		/// el mouse encima de este en caso que no se alcance a leer.
		/// </summary>	
		private void cmb_Modulos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Modulos.SelectedIndex != -1)
			{
				string itemText = cmb_Modulos.GetItemText(cmb_Modulos.SelectedItem);
				cmbTooltip.SetToolTip(cmb_Modulos, itemText);
			}
			else cmbTooltip.SetToolTip(cmb_Modulos, "");
		}

		/// <summary>
		/// Este método se ejecutará cuando se quiera editar una opción. Se debe hacer
		/// clic en una fila de la tabla y se abrirá el panel izquierdo con los datos
		/// de la opción seleccionada.
		/// </summary>
		private void btn_Editar_Click(object sender, EventArgs e)
		{
			vaciarFormularios();
			if (dgv_Opciones.SelectedRows.Count > 0)
			{
				opcion_editar = dgv_Opciones.SelectedRows[0];
				int opcion_id = (int)opcion_editar.Cells["opcion_id"].Value;
				mostrarPanelActualizar("Editar Opción " + opcion_id);
				accion = 1;
				llenarDatosEdicion();
			}
			else MessageBox.Show("Selecciona una opción de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// Este método va a llenar los textbox con la información de la opción que se
		/// quiera editar.
		/// </summary>
		private void llenarDatosEdicion()
		{
			txt_Nombre.Text = opcion_editar.Cells["nombre"].Value.ToString();
			txt_Objeto.Text = opcion_editar.Cells["nombre_objeto"].Value.ToString();
			cmb_Modulos.SelectedValue = opcion_editar.Cells["modulo_id"].Value;
			txt_Descripcion.Text = opcion_editar.Cells["descripcion"].Value.ToString();
			txt_Orden.Text = opcion_editar.Cells["orden"].Value.ToString();
		}

		/// <summary>
		/// Este método se ejecutará al dar clic al botón aceptar al querer añadir
		/// una nueva opción o al editar una. Recogerá los datos de los textbox y
		/// ejecutará el comando respectivo (nuevo o editar).
		/// </summary>	
		private void btn_Aceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (validarFormularios())
				{
					CD_Parametros[] p = obtenerDatosOpcion();
					if (accion == 0) objectCN.actualizarTabla("PD_AGREGAR_OPCION", p);
					else if (accion == 1) objectCN.actualizarTabla("PD_EDITAR_OPCION", p);
					MessageBox.Show("Cambios realizados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					llenarTablaOpciones();
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
		/// Este método va a obtener los datos de los formularios para ser enviados
		/// como parámetros al SQL Server.
		/// </summary>
		/// <returns>Un arreglo CD_Parametro de los datos de la opción.</returns>
		private CD_Parametros[] obtenerDatosOpcion()
		{
			CD_Parametros[] p = null;
			if (accion == 0) // Nuevo
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@nombre", txt_Nombre.Text.Trim()),
					new CD_Parametros("@nombre_objeto", txt_Objeto.Text.Trim()),
					new CD_Parametros("@descripcion", txt_Descripcion.Text),
					new CD_Parametros("@modulo_id", (int)cmb_Modulos.SelectedValue),
					new CD_Parametros("@orden", txt_Orden.Text.Trim())
				};
			}
			else
			{
				p = new CD_Parametros[]
				 {
					new CD_Parametros("@opcion_id", (int)opcion_editar.Cells["opcion_id"].Value),
					new CD_Parametros("@nombre", txt_Nombre.Text.Trim()),
					new CD_Parametros("@nombre_objeto", txt_Objeto.Text.Trim()),
					new CD_Parametros("@descripcion", txt_Descripcion.Text),
					new CD_Parametros("@modulo_id", (int)cmb_Modulos.SelectedValue),
					new CD_Parametros("@orden", txt_Orden.Text.Trim())
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
			if (txt_Nombre.Text != "" && txt_Objeto.Text != "" && txt_Orden.Text != "")
			{
				if (cmb_Modulos.SelectedIndex != 0) return true;
				else throw new Exception("Seleccione un módulo.");
			}
			else return false;
		}

		/// <summary>
		/// Este método se activará al darle click al botón Inactivar/Activar. Este
		/// va a activar la opción si ya estaba inactivo o hará lo contrario. Va a 
		/// cancelar la operación si se intenta inactivar la opción con id 11 ya que
		/// esa es la opción que permite editar otras opciones (en el que nos encontramos 
		/// actualmente).
		/// </summary>	
		private void btn_Inactivar_Activar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgv_Opciones.SelectedRows.Count > 0)
				{
					string msj = "";
					int opcion_id = (int)dgv_Opciones.SelectedRows[0].Cells["opcion_id"].Value;
					if (opcion_id == 11) throw new Exception("No se puede inactivar esa opción.");
					if (activar_desactivar == 1) msj = "inactivar";
					else msj = "activar";
					DialogResult result = MessageBox.Show("¿Estás seguro que deseas " + msj + " la opción " + opcion_id + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes) eliminarOpcion(opcion_id);
				}
				else throw new Exception("Selecciona una opción de la lista.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Este método va a realizar la operación de inactivar/activar la opción desde el SQL server.
		/// </summary>
		/// <param name="opcion_id">El id de la opción a inactivar/activar</param>
		private void eliminarOpcion(int opcion_id)
		{
			CD_Parametros[] para =
			{
				new CD_Parametros("@accion", activar_desactivar),
				new CD_Parametros("@opcion_id", opcion_id)
			};
			objectCN.actualizarTabla("PD_INACTIVAR_ACTIVAR_OPCION", para);
			llenarTablaOpciones();
			MessageBox.Show("Opción actualizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Este método va a cambiar el botón de Activar/Inactivar dependiendo del
		/// estado_id de la opción seleccionada.
		/// </summary>
		private void dgv_Opciones_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_Opciones.SelectedRows.Count > 0)
			{
				DataGridViewRow r = dgv_Opciones.SelectedRows[0];
				int estado_id = (int)r.Cells["estado_id"].Value;
				formaBotonActivarInactivar(estado_id);
			}
		}

		/// <summary>
		/// Este método va a cambiar el color y el texto del botón de activar o 
		/// inactivar dependiendo de la opción que se esté seleccionando.
		/// </summary>
		/// <param name="estado_id">Estado actual de la opción seleccionada</param>
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
		/// Este método va a llenar la tabla de módulos filtrando el texto del textbox.
		/// </summary>	
		private void txt_Filtro_Nombre_TextChanged(object sender, EventArgs e)
		{
			llenarTablaOpciones();
		}

		/// <summary>
		/// Este método va a controlar que en el textbox del nombre de objeto no
		/// se puedan ingresar espacios en blanco.
		/// </summary>	
		private void txt_Objeto_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
		}

		/// <summary>
		/// Este método va a controlar que en el textbox de orden solo se ingresen
		/// números.
		/// </summary>
		private void txt_Orden_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
		}
	}
}
