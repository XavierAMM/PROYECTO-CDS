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
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.User_Control
{
	public partial class UC_Mi_Perfil : UserControl
	{
		private int usuario_id;
		private CN_Validacion objectCN = new CN_Validacion();
		public UC_Mi_Perfil(int usuario_id)
		{
			this.usuario_id = usuario_id;
			InitializeComponent();
			pnl_Contrasena.Visible = false;
			pnl_Mensaje.Visible = false;

			llenarDatosUsuario();

		}

		private void llenarDatosUsuario()
		{
			CD_Parametros[] para = { new CD_Parametros("@usuario_id", usuario_id) };
			DataTable usuario = objectCN.obtenerTabla("PD_OBTENER_USUARIO", para);
			DataRow r = usuario.Rows[0];
			txt_Usuario.Text = r["usuario"].ToString();
			txt_Contrasena.Text = r["contraseña"].ToString();
			txt_Contrasena2.Text = txt_Contrasena.Text;
			txt_Nombre.Text = r["nombre"].ToString();
			txt_Apellido.Text = r["apellido"].ToString();
			txt_Telefono.Text = r["telefono"].ToString();
			txt_Correo.Text = r["correo_electronico"].ToString();
			date_Fecha_Nacimiento.Text = r["fecha_nacimiento"].ToString();
			txt_Direccion.Text = r["direccion_hogar"].ToString();
			txt_Perfil.Text = r["perfil"].ToString();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			TextBox txt;
			PictureBox pic;
			if (sender is TextBox)
			{
				txt = (TextBox)sender;
				if (txt.ReadOnly) return;
				pic = Controls.Find(txt.Tag.ToString(), true).FirstOrDefault() as PictureBox;
			}
			else
			{
				pic = (PictureBox)sender;
				txt = Controls.Find(pic.Tag.ToString(), true).FirstOrDefault() as TextBox;
			}
			activarEdicionControl(txt, pic);
		}

		private void activarEdicionControl(TextBox txt, PictureBox pic)
		{
			if (txt.ReadOnly)
			{
				txt.ReadOnly = false;
				pic.Image = Properties.Resources.ico_check;
				txt.Focus();
			}
			else
			{
				txt.ReadOnly = true;
				pic.Image = Properties.Resources.ico_editar;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			activarEdicionControl(txt_Contrasena, pictureBox2);
			if (txt_Contrasena.ReadOnly) pnl_Contrasena.Visible = false;
			else pnl_Contrasena.Visible = true;
		}

		private void pictureBox16_Click(object sender, EventArgs e)
		{
			DateTimePicker dtime;
			PictureBox pic;
			if (sender is DateTimePicker)
			{
				dtime = (DateTimePicker)sender;
				if (!dtime.Enabled) return;
				pic = Controls.Find(dtime.Tag.ToString(), true).FirstOrDefault() as PictureBox;
			}
			else
			{
				pic = (PictureBox)sender;
				dtime = Controls.Find(pic.Tag.ToString(), true).FirstOrDefault() as DateTimePicker;
			}
			activarEdicionDateTimePicker();
		}

		private void activarEdicionDateTimePicker()
		{
			if (!date_Fecha_Nacimiento.Enabled)
			{
				date_Fecha_Nacimiento.Enabled = true;
				pictureBox16.Image = Properties.Resources.ico_check;
				date_Fecha_Nacimiento.Focus();
			}
			else
			{
				date_Fecha_Nacimiento.Enabled = false;
				pictureBox16.Image = Properties.Resources.ico_editar;
			}
		}

		private CD_Parametros[] obtenerDatosUsuario()
		{
			if (validarFormulario())
			{
				if (txt_Direccion.Text.Trim() == "") txt_Direccion.Text = " ";
				return new CD_Parametros[]
				{
					new CD_Parametros("@usuario_id",usuario_id),
					new CD_Parametros("@usuario",txt_Usuario.Text.Trim()),
					new CD_Parametros("@contraseña",txt_Contrasena.Text),
					new CD_Parametros("@nombre1",txt_Nombre.Text.Trim()),
					new CD_Parametros("@apellido1",txt_Apellido.Text.Trim()),
					new CD_Parametros("@telefono",txt_Telefono.Text.Trim()),
					new CD_Parametros("@correo_electronico",txt_Correo.Text.Trim()),
					new CD_Parametros("@fecha_nacimiento",date_Fecha_Nacimiento.Value),
					new CD_Parametros("@direccion_hogar",txt_Direccion.Text),
				};
			}
			else throw new Exception("Rellene todos los formularios.");
		}

		private bool validarFormulario()
		{
			return
			txt_Usuario.Text.Trim() != "" &&
			txt_Contrasena.Text != "" &&
			txt_Nombre.Text.Trim() != "" &&
			txt_Apellido.Text.Trim() != "" &&
			txt_Telefono.Text.Trim() != "" &&
			txt_Correo.Text.Trim() != "" &&
			date_Fecha_Nacimiento.Text != "";
		}

		private void mostrarMensajeError(string txt)
		{
			lbl_Mensaje.Text = txt;
			pnl_Mensaje.Visible = true;
		}

		private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
		}

		private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)) e.Handled = true;
		}

		private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsWhiteSpace(e.KeyChar) || !Char.IsDigit(e.KeyChar) || txt_Telefono.Text.Length >= 10)
				e.Handled = true;
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			try
			{
				CD_Parametros[] p ={ new CD_Parametros("@usuario", txt_Usuario.Text.Trim()), new CD_Parametros("@usuario_id", usuario_id) };
				if (objectCN.obtenerDatoEntero("PD_EVALUAR_EDITAR_NOMBRE_USUARIO_UNICO", p) == 0) throw new Exception("Ya existe un usuario con ese nombre.");
				p = obtenerDatosUsuario();
				if (txt_Contrasena.Text != txt_Contrasena2.Text) throw new Exception("Las contraseñas deben ser iguales.");
				if (txt_Telefono.Text.Length != 10) throw new Exception("El teléfono debe tener 10 dígitos");
				objectCN.actualizarTabla("PD_EDITAR_USUARIO", p);
				MessageBox.Show("Cambios guardados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				pnl_Mensaje.Visible = false;
				llenarDatosUsuario();
			}
			catch (Exception ex)
			{
				mostrarMensajeError(ex.Message);
			}
		}
	}
}
