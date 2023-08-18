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
	/// Esta clase es la vista para editar las opciones de los perfiles.
	/// </summary>
	public partial class UC_Sistema_Opciones_Perfil : UserControl
	{
		private int modo;
		private int accion;
		private string procedureName;
		private DataGridViewRow perfil_opciones_editar;
		private CD_Parametros[] p;
		private DataTable perfilOpciones;
		private CN_Validacion objectCN = new CN_Validacion();
		private ToolTip cmbTooltip = new ToolTip();
		private int activar_desactivar = 0;
		private ToolTip cmbToolTip = new ToolTip();

		/// <summary>
		/// Constructor para la clase que es la vista para editar las 
		/// opciones de los perfiles.
		/// </summary>
		public UC_Sistema_Opciones_Perfil()
		{
			InitializeComponent();
			modo = 0;
			procedureName = "PD_OBTENER_PERFIL_X_OPCION_MODO";
			llenarTablaPerfilOpciones();
			llenarComboBox(cmb_Perfil, "PD_PERFIL_NO_ADMIN", "perfil_id", "Seleccionar perfil...");
			llenarComboBox(cmb_Modulo, "PD_OBTENER_MODULOS", "modulo_id", "Seleccionar módulo...");
			cmb_Opcion.Enabled = false;
			pnl_Actualizar.Visible = false;
		}

		/// <summary>
		/// Este método va a llenar el combobox con su table indicada.
		/// </summary>
		/// <param name="cmb">El combobox a llenarle datos</param>
		/// <param name="procedureName">El nombre del procedimiento a llamar</param>
		/// <param name="valueMember">El id del dato. Ej. "modulo_id"</param>
		/// <param name="textoMostrar">El texto que se mostrará al no elegir uno.</param>
		private void llenarComboBox(ComboBox cmb, String procedureName, String valueMember, String textoMostrar)
		{
			cmbTooltip.SetToolTip(cmb, "");
			CD_Parametros[] param = { new CD_Parametros("@modo", 0) };
			DataTable dt = objectCN.obtenerTabla(procedureName, param);
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

		/// <summary>
		/// Este método va a llenar los datos de la tabla de las opciones de perfil considerando si el
		/// textbox del filtro tiene contenido o no. Si lo tiene, entonces lo priorizará y 
		/// mostrará opciones de perfil cuyo filtro contengan la cadena de texto.
		/// Caso contrario, mostrará todos los datos. Para ambos casos, se considerará el checkbox
		/// de mostrar inactivos.
		/// </summary>
		private void llenarTablaPerfilOpciones()
		{
			if (txt_Filtro_Nombre.Text.Length > 0)
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@modo", modo),
					new CD_Parametros("@nombre", txt_Filtro_Nombre.Text),
				};
				procedureName = "PD_OBTENER_PERFILES_X_OPCION_FILTRAR";
			}
			else
			{
				p = new CD_Parametros[] { new CD_Parametros("@modo", modo) };
				procedureName = "PD_OBTENER_PERFIL_X_OPCION_MODO";
			}
			perfilOpciones = objectCN.obtenerTabla(procedureName, p);
			dgv_Perfil_Opciones.DataSource = perfilOpciones;
			dgv_Perfil_Opciones.ClearSelection();
			cambiarColorInactivos(Color.Salmon);
		}

		/// <summary>
		/// Este método va a ponerle un color específico a las filas cuyo
		/// estado_id sea inactivo (2)
		/// </summary>
		/// <param name="c">El color de la fila.</param>
		private void cambiarColorInactivos(Color c)
		{
			foreach (DataGridViewRow r in dgv_Perfil_Opciones.Rows)
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
			llenarTablaPerfilOpciones();
		}

		/// <summary>
		/// Este método se ejecutará cuando se haga clic en el botón "Nuevo"
		/// </summary>	
		private void btn_Nuevo_Click(object sender, EventArgs e)
		{
			vaciarFormularios();
			mostrarPanelActualizar("Nuevo Perfil-Opción");
			accion = 0;
		}

		/// <summary>
		/// Este método va a vaciar los combobox después de haber añadido uno
		/// nuevo o de haber editado.
		/// </summary>
		private void vaciarFormularios()
		{
			cmb_Perfil.SelectedIndex = 0;
			cmb_Modulo.SelectedIndex = 0;
			cmb_Opcion.DataSource = null;
		}

		/// <summary>
		/// Este método va a mostrar el panel izquierdo, ya sea para añadir una nueva
		/// opción de perfil o para editar uno.
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

		/// <summary>
		/// Este método se ejecutará cuando el usuario elija una opción del combobox.
		/// </summary>		
		private void cmb_Perfil_SelectedIndexChanged(object sender, EventArgs e)
		{
			agregarTooltipCombobox(cmb_Perfil);
		}

		/// <summary>
		/// Este método se ejecutará cuando el usuario elija una opción del combobox.
		/// </summary>		
		private void cmb_Modulo_SelectedIndexChanged(object sender, EventArgs e)
		{
			agregarTooltipCombobox(cmb_Modulo);
			if (cmb_Modulo.SelectedIndex != 0)
			{
				cmb_Opcion.Enabled = true;
				llenarComboBoxOpcion();
			}
			else
			{
				cmb_Opcion.DataSource = null;
				cmb_Opcion.Enabled = false;
			}
		}

		/// <summary>
		/// Este método va a llenar el combobox de opción según el módulo elegido en 
		/// el combobox de módulo.
		/// </summary>
		private void llenarComboBoxOpcion()
		{
			CD_Parametros[] para = { new CD_Parametros("@modulo_id", cmb_Modulo.SelectedValue) };
			DataTable dt = objectCN.obtenerTabla("PD_OBTENER_OPCIONES_MODULO", para);
			cmb_Opcion.DataSource = dt;
			cmb_Opcion.DisplayMember = "nombre";
			cmb_Opcion.ValueMember = "opcion_id";
			cmbAgregarTextoMuestra(cmb_Opcion, "opcion_id", "Seleccionar opción...");
			cmb_Opcion.SelectedIndex = 0;
		}

		/// <summary>
		/// Este método se ejecutará cuando el usuario elija una opción del combobox.
		/// </summary>
		private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
		{
			agregarTooltipCombobox(cmb_Opcion);
		}

		/// <summary>
		/// Este método se ejecutará cuando se quiera editar una opción de perfil. Se debe hacer
		/// clic en una fila de la tabla y se abrirá el panel izquierdo con los datos
		/// de la opción de perfil seleccionada.
		/// </summary>
		private void btn_Editar_Click(object sender, EventArgs e)
		{
			try
			{
				vaciarFormularios();
				if (dgv_Perfil_Opciones.SelectedRows.Count > 0)
				{
					perfil_opciones_editar = dgv_Perfil_Opciones.SelectedRows[0];
					int perfil_id = (int)perfil_opciones_editar.Cells["perfil_id"].Value;
					if (perfil_id == 7) throw new Exception("No se puede editar esa opción con perfil administrador");
					int perfil_opcion_id = (int)perfil_opciones_editar.Cells["perfil_x_opcion_id"].Value;
					mostrarPanelActualizar("Editar Perfil-Opción " + perfil_opcion_id);
					accion = 1;
					llenarDatosEdicion();
				}
				else throw new Exception("Selecciona una opción de perfil de la lista.");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		/// <summary>
		/// Este método va a llenar los textbox con la información de la opción que se
		/// quiera editar.
		/// </summary>
		private void llenarDatosEdicion()
		{
			cmb_Perfil.SelectedValue = perfil_opciones_editar.Cells["perfil_id"].Value;
			cmb_Modulo.SelectedValue = perfil_opciones_editar.Cells["modulo_id"].Value;
			cmb_Opcion.SelectedValue = perfil_opciones_editar.Cells["opcion_id"].Value;
		}

		/// <summary>
		/// Este método se ejecutará al dar clic al botón asignar al querer añadir
		/// una nueva opción de perfil o al editar una. Recogerá los datos de los combobox y
		/// ejecutará el comando respectivo (nuevo o editar).
		/// </summary>	
		private void btn_Asignar_Click(object sender, EventArgs e)
		{
			try
			{
				if (validarFormularios())
				{
					CD_Parametros[] p = obtenerDatosPerfilOpciones();
					evaluarNuevaOpcion(p);
					if (accion == 0) objectCN.actualizarTabla("PD_AGREGAR_PERFIL_X_OPCION", p);
					else if (accion == 1) objectCN.actualizarTabla("PD_EDITAR_PERFIL_X_OPCION", p);
					MessageBox.Show("Cambios realizados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
					llenarTablaPerfilOpciones();
					pnl_Actualizar.Visible = false;
				}
				else throw new Exception("Rellene todos los formularios.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void evaluarNuevaOpcion(CD_Parametros[] param)
		{
			int result = objectCN.obtenerDatoEntero("PD_EVALUAR_NUEVO_PERFIL_X_OPCION", param);
			if (result == 1) throw new Exception("Dicho perfil ya cuenta asignado esa opción");
			if (result == -1) throw new Exception("Dicho perfil ya cuenta asignado esa opción pero se encuentra inactivo");
		}

		/// <summary>
		/// Este método va a obtener los datos de los formularios para ser enviados
		/// como parámetros al SQL Server.
		/// </summary>
		/// <returns>Un arreglo CD_Parametro de los datos de la opción de perfil.</returns>
		private CD_Parametros[] obtenerDatosPerfilOpciones()
		{
			CD_Parametros[] p = null;
			if (accion == 0) // Nuevo
			{
				p = new CD_Parametros[]
				{
					new CD_Parametros("@perfil_id", cmb_Perfil.SelectedValue),
					new CD_Parametros("@opcion_id", cmb_Opcion.SelectedValue)
				};
			}
			else
			{
				p = new CD_Parametros[]
				 {
					new CD_Parametros("@perfil_x_opcion_id", (int)perfil_opciones_editar.Cells["@perfil_x_opcion_id"].Value),
					new CD_Parametros("@perfil_id", cmb_Perfil.SelectedValue),
					new CD_Parametros("@opcion_id", cmb_Opcion.SelectedValue)
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
			return (int)cmb_Perfil.SelectedValue != 0 && (int)cmb_Opcion.SelectedValue != 0;
		}

		/// <summary>
		/// Este método se activará al darle click al botón Inactivar/Activar. Este
		/// va a activar la opción de perfil si ya estaba inactivo o hará lo contrario. Va a 
		/// cancelar la operación si se intenta inactivar alguna opción de perfil con un perfil_id 7 ya que
		/// esa es el administrador (siempre tiene todas las opciones).
		/// </summary>	
		private void btn_Inactivar_Activar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgv_Perfil_Opciones.SelectedRows.Count > 0)
				{
					string msj = "";
					int perfil_opcion_id = (int)dgv_Perfil_Opciones.SelectedRows[0].Cells["perfil_x_opcion_id"].Value;
					int perfil_id = (int)dgv_Perfil_Opciones.SelectedRows[0].Cells["perfil_id"].Value;
					if (perfil_id == 7) throw new Exception("No se puede inactivar una opción de un administrador.");
					if (activar_desactivar == 1) msj = "inactivar";
					else msj = "activar";
					DialogResult result = MessageBox.Show("¿Estás seguro que deseas " + msj + " la opción de perfil " + perfil_opcion_id + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes) eliminarPerfilOpcion(perfil_opcion_id);
				}
				else throw new Exception("Selecciona una opción de perfil de la lista.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Este método va a realizar la operación de inactivar/activar la opción de perfil desde el SQL server.
		/// </summary>
		/// <param name="perfil_opcion_id">El id de la opción de perfil a inactivar/activar</param>
		private void eliminarPerfilOpcion(int perfil_opcion_id)
		{
			CD_Parametros[] para =
			{
				new CD_Parametros("@accion", activar_desactivar),
				new CD_Parametros("@perfil_x_opcion_id", perfil_opcion_id)
			};
			objectCN.actualizarTabla("PD_INACTIVAR_ACTIVAR_PERFIL_X_OPCION", para);
			llenarTablaPerfilOpciones();
			MessageBox.Show("Opción de perfil actualizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Este método va a cambiar el botón de Activar/Inactivar dependiendo del
		/// estado_id de la opción de perfil seleccionada.
		/// </summary>
		private void dgv_Perfil_Opciones_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_Perfil_Opciones.SelectedRows.Count > 0)
			{
				DataGridViewRow r = dgv_Perfil_Opciones.SelectedRows[0];
				int estado_id = (int)r.Cells["estado_id"].Value;
				formaBotonActivarInactivar(estado_id);
			}
		}

		/// <summary>
		/// Este método va a cambiar el color y el texto del botón de activar o 
		/// inactivar dependiendo de la opción de perfil que se esté seleccionando.
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
	}
}
