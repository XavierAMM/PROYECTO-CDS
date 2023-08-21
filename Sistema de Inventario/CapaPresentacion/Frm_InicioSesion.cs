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

namespace CapaPresentacion
{
	/// <summary>
	/// En este formulario se encontarán elementos básicos para iniciar sesión. 
	/// Como el textbox de usuario, contraseña, botones para registrarse y 
	/// recuperar contraseña.
	/// </summary>
	public partial class Frm_InicioSesion : Form
	{
		private CN_Validacion objectCN = new CN_Validacion();
		public Frm_InicioSesion()
		{
			InitializeComponent();
			pnl_Mensaje.Visible = false;
		}

		/// <summary>
		/// Este evento de click va a remplazar el de cerrar la aplicación.
		/// </summary>		
		private void lbl_Cerrar_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		/// <summary>
		/// Al darle clic a ingresar, va a validar si el usuario y contraseña 
		/// son válidos. Si es así, ingresa al Frm_Principal con el usuario_id como parámetro.
		/// </summary>		
		private void btn_Ingresar_Click(object sender, EventArgs e)
		{
			int result;
			try
			{
				string usuario = txt_Usuario.Text.Trim();
				string contraseña = txt_Contraseña.Text.Trim();
				CD_Parametros[] param = {
					new CD_Parametros("@usuario", usuario),
					new CD_Parametros("@contraseña", contraseña)
				};
				result = objectCN.obtenerDatoEntero("PD_VALIDAR_INICIO_SESION", param);
				validarResultadoInicioSesion(result);
			}
			catch (Exception ex)
			{
				mostrarMensajeError(ex.Message);
			}
		}

		/// <summary>
		/// Este método va a realizar la acción de validar el resultado obtenido 
		/// del procedimiento almacenado de iniciar sesión. Si el resultado es 0, 
		/// quiere decir que el usuario y contraseña son incorrectos. Si el resultado 
		/// es -1, quiere decir que el usuario ha sido desactivada. Caso contrario, 
		/// devolverá el id de ese usuario.
		/// </summary>		
		/// <param name="result">El resultado obtenido después de ejecutar el 
		/// procedimiento almacenado.</param>
		private void validarResultadoInicioSesion(int result)
		{
			if (result == 0)
				mostrarMensajeError("Usuario o contraseña incorrectos.");
			else if (result == -1)
				mostrarMensajeError("Su cuenta ha sido desactivada. Póngase en contacto con un administrador.");
			else
				ingresarFormularioPrincipal(result);
		}

		/// <summary>
		/// Este método va a abrir el Frm_Principal enviando el id del usuario al mismo.
		/// </summary>
		/// <param name="id_usuario">Id del usuario después de ejecutar el procedimiento 
		/// almacenado de iniciar sesión</param>
		private void ingresarFormularioPrincipal(int id_usuario)
		{
			esconderMensajeError();
			Frm_Principal frm = new Frm_Principal(id_usuario);
			frm.ShowDialog();
		}

		/// <summary>
		/// Este método activará el panel del mensaje de error y mostrará el mensaje querido.
		/// </summary>
		/// <param name="mensaje">El mensaje de error que se mostrará en la etiqueta.</param>
		private void mostrarMensajeError(string mensaje)
		{
			lbl_Mensaje.Text = mensaje;
			pnl_Mensaje.Visible = true;
		}

		/// <summary>
		/// Este método ocultará el panel del mensaje de error.
		/// </summary>
		private void esconderMensajeError()
		{
			pnl_Mensaje.Visible = false;
		}

		/// <summary>
		/// Al darle click al botón de registrarse, se abrirá el formulario principal 
		/// junto con el control de usuario UC_Registrarse.
		/// </summary>		
		private void btn_Registrarse_Click(object sender, EventArgs e)
		{
			Frm_Principal frm = new Frm_Principal(true);
			frm.ShowDialog();
		}

		/// <summary>
		/// Al darle click a olvidé mi contraseña, se abrirá el formulario principal 
		/// junto con el control de usuario UC_Recuperar_Contraseña
		/// </summary>		
		private void lbl_OlvideContraseña_LinkClicked(object sender, EventArgs e)
        {
            Frm_Principal frm = new Frm_Principal(false);
            frm.ShowDialog();
        }
    }
}
