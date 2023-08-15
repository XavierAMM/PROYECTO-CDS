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

namespace CapaPresentacion.User_Control
{

	/// <summary>
	/// Este control de usuario servirá para cambiar la contraseña del usuario a partir de
	/// su correo y su nombre de usuario en caso de que se haya olvidado.
	/// </summary>
	public partial class UC_Recuperar_Contraseña : UserControl
	{
		private ToolTip cmbToolTip = new ToolTip();
		private DataTable tableUsuario;
		private int usuario_id = 0;
		private CN_Validacion objectCN = new CN_Validacion();

		/// <summary>
		/// Este control de usuario servirá para cambiar la contraseña del usuario a partir de
		/// su correo y su nombre de usuario en caso de que se haya olvidado.
		/// </summary>
		public UC_Recuperar_Contraseña()
		{
			InitializeComponent();
			esconderComponentes();
		}

		/// <summary>
		/// Este método va a olcultar los componentes que no se mostrarán al inicio como el 
		/// mensaje de error, el panel de pregunta y el de cambiar contraseña.
		/// </summary>
		private void esconderComponentes()
		{
			esconderMensaje();
			togglePregunta(false);
			toggleContraseña(false);
		}

		/// <summary>
		/// Este método va a esconder o mostrar el panel de cambiar contraseña dependiendo de
		/// qué parte del proceso se encuentre.
		/// </summary>
		/// <param name="mostrar">Bool. True = Mostrar. False = Ocultar</param>
		private void toggleContraseña(bool mostrar)
		{
			if (mostrar)
				pnl_Contraseña.Visible = true;
			else
			{
				pnl_Contraseña.Visible = false;
				txt_Contraseña.Text = "";
				txt_Contraseña2.Text = "";
			}
		}

		/// <summary>
		/// Este método ocultará el mensaje de error una vez sea necesario.
		/// </summary>
		private void esconderMensaje()
		{
			pnl_Mensaje.Visible = false;
			lbl_Mensaje.Text = "";
		}

		/// <summary>
		/// Este método va a esconder o mostrar el panel de pregunta de seguridad dependiendo de
		/// qué parte del proceso se encuentre.
		/// </summary>
		/// <param name="mostrar">Bool. True = Mostrar. False = Ocultar</param>
		private void togglePregunta(bool mostrar)
		{
			if (mostrar)
			{
				pnl_Pregunta.Visible = true;
			}
			else
			{
				pnl_Pregunta.Visible = false;
				cmb_Pregunta_Seguridad.DataSource = new DataTable();
				txt_Respuesta.Text = "";
			}
		}

		/// <summary>
		/// Al darle clicl a botón de buscar, el programa ejecutará un stored procedure
		/// que valide si el usuario y correo existen en el sistema.
		/// </summary>		
		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			esconderComponentes();
			try
			{
				string usuario = txt_Usuario.Text.Trim();
				string correo = txt_Correo.Text.Trim();
				CD_Parametros[] param =
				{
					new CD_Parametros("@usuario", usuario),
					new CD_Parametros("@correo_electronico", correo)
				};
				int result = objectCN.obtenerDatoEntero("PD_OBTENER_USUARIO_X_USUARIO_CORREO", param);
				validarResultado(result);
			}
			catch (Exception ex)
			{
				mostrarMensajeError(ex.Message);
			}
		}

		/// <summary>
		/// Este método se ejecutaré cuando se haya obtenido el resultado del stored procedure para
		/// validar el usuario y el correo ingresados.
		/// </summary>
		/// <param name="result">El resultado obtenido del stored procedure</param>
		private void validarResultado(int result)
		{
			if (result == 0)
				mostrarMensajeError("No se ha encontrado el usuario.");
			else if (result == -1)
				mostrarMensajeError("Su cuenta ha sido desactivada. Póngase en contacto con un administrador.");
			else
			{
				toggleUsuarioCorreo(false);
				usuario_id = result;
				buscarPregunta(result);
			}
		}

		/// <summary>
		/// Este método va a activar o desactivar los textbox de usuario y correo 
		/// dependiendo qué parte del proceso se encuentre.
		/// </summary>
		/// <param name="mostrar">Bool. True = Activar. False = Desactivar</param>
		private void toggleUsuarioCorreo(bool activar)
		{
			if (activar)
			{
				txt_Usuario.ReadOnly = false;
				txt_Correo.ReadOnly = false;
				btn_Buscar.Enabled = true;
			}
			else
			{
				txt_Usuario.ReadOnly = true;
				txt_Correo.ReadOnly = true;
				btn_Buscar.Enabled = false;
			}
		}

		/// <summary>
		/// Este método va a asignarle la pregunta de seguridad adecuada después de
		/// haber encontrado al usuario cuyo usuario y correo coincidan.
		/// </summary>
		/// <param name="usuario_id">El id del usuario cuyo correo y usuario hayan coincidido.</param>
		private void buscarPregunta(int usuario_id)
		{
			togglePregunta(true);
			cmbToolTip.SetToolTip(cmb_Pregunta_Seguridad, "");
			CD_Parametros[] param = { new CD_Parametros("@usuario_id", usuario_id) };
			tableUsuario = objectCN.obtenerTabla("PD_OBTENER_USUARIO", param);
			cmb_Pregunta_Seguridad.DataSource = tableUsuario;
			cmb_Pregunta_Seguridad.DisplayMember = "pregunta";
			cmb_Pregunta_Seguridad.ValueMember = "tipo_pregunta_id";
			cmb_Pregunta_Seguridad.SelectedIndex = 0;
		}

		/// <summary>
		/// Este método activará el panel del mensaje de error y mostrará el mensaje querido.
		/// </summary>
		/// <param name="msg">El mensaje de error que se mostrará en la etiqueta.</param>
		private void mostrarMensajeError(String msj)
		{
			lbl_Mensaje.Text = msj;
			pnl_Mensaje.Visible = true;
		}

		/// <summary>
		/// Al dar click al botón Aceptar, se va a validar si la respuesta de la pregunta de seguridad sea 
		/// exactamente la misma que el usuario ingresó al momento de haberse registrado.
		/// </summary>		
		private void btn_Aceptar_Click(object sender, EventArgs e)
		{
			if (validarPregunta())
			{
				toggleContraseña(true);
				togglePregunta(false);
			}
			else
			{
				toggleUsuarioCorreo(true);
				mostrarMensajeError("Respuesta de la pregunta de seguridad incorrecta.");
			}

		}

		/// <summary>
		/// Este método es el que va a hacer la validación si la respuesta de la pregunta 
		/// de seguridad sea exactamente la misma que el usuario ingresó al momento de 
		/// haberse registrado.
		/// </summary>
		/// <returns>Si la respuesta es la correcta o incorrecta (true or false).</returns>
		private bool validarPregunta()
		{
			int tipo_pregunta_id = (int)cmb_Pregunta_Seguridad.SelectedValue;
			string respuesta = txt_Respuesta.Text.Trim();
			int usu_tipo_pregunta_id = (int)tableUsuario.Rows[0]["tipo_pregunta_id"];
			string usu_respuesta = tableUsuario.Rows[0]["respuesta_pregunta"].ToString();
			return (tipo_pregunta_id == usu_tipo_pregunta_id && respuesta == usu_respuesta);
		}

		/// <summary>
		/// Al darle click al botón guardar, se ejecutará este método. Este va a primero
		/// verificar que las contraseñas no estén vacías y que sean iguales para después
		/// actualizar la tabla de usuarios y cambiar la contraseña del usuario.
		/// </summary>		
		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			string contraseña = txt_Contraseña.Text;
			string contraseña2 = txt_Contraseña2.Text;
			if (contraseña == contraseña2)
			{
				try
				{
					CD_Parametros[] param =
					{
						new CD_Parametros("@usuario_id", usuario_id),
						new CD_Parametros("@contraseña", contraseña)
					};
					objectCN.actualizarTabla("PD_ACTUALIZAR_CONTRASEÑA", param);
					esconderComponentes();
					toggleUsuarioCorreo(true);
					MessageBox.Show("Contaseña cambiada con éxito!", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					mostrarMensajeError(ex.Message);
				}
			}
			else mostrarMensajeError("Las contraseñas deben ser iguales.");
		}

		/// <summary>
		/// Este método se activará cuando aparezca una opción en el combobox de 
		/// pregunta de seguridad. Este mostrará un tooltip cuando el usuario ponga 
		/// el mouse encima de la pregunta en caso que no se alcance a leer toda.
		/// </summary>	
		private void cmb_Pregunta_Seguridad_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Pregunta_Seguridad.SelectedIndex != -1)
			{
				string itemText = cmb_Pregunta_Seguridad.GetItemText(cmb_Pregunta_Seguridad.SelectedItem);
				cmbToolTip.SetToolTip(cmb_Pregunta_Seguridad, itemText);
			}
			else cmbToolTip.SetToolTip(cmb_Pregunta_Seguridad, "");
		}
	}
}
