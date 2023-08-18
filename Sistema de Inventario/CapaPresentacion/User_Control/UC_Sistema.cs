using CapaPresentacion.User_Control.UC_Sistemas_Views;

namespace CapaPresentacion.User_Control
{
	/// <summary>
	/// En esta clase se encontrarán los elementos a cambiar del sistema en general. Módulos, opciones, perfiles y usuarios.
	/// </summary>
	public partial class UC_Sistema : UserControl
	{
		int usuario_id;
		/// <summary>
		/// Constructor de la clase en la que se encontrarán los elementos a cambiar del sistema en general. Módulos, opciones, perfiles y usuarios.
		/// </summary>
		/// <param name="usuario_id">Id del usuario que ha ingresado al sistema.</param>
		public UC_Sistema(int usuario_id)
		{
			InitializeComponent();
			this.usuario_id = usuario_id;
			addViewModulos();
		}

		/// <summary>
		/// Muestra el user control específico en el panel de la derecha.
		/// </summary>
		/// <param name="uc">El User Control que se quiera mostrar.</param>
		private void addUserControl(UserControl uc)
		{
			uc.Dock = DockStyle.Fill;
			pnl_Main.Controls.Clear();
			pnl_Main.Controls.Add(uc);
			uc.BringToFront();
		}

		/// <summary>
		/// Este método va a colocar en la pantalla la vista de UC_Sistema_Modulo
		/// </summary>
		private void addViewModulos()
		{
			UC_Sistema_Modulo uc = new UC_Sistema_Modulo(usuario_id);
			addUserControl(uc);
		}

		/// <summary>
		/// Este método se ejecutará al darle click al botón de "Módulos". Va a colocar
		/// la vista UC_Sistema_Modulo en pantalla. Se activará por defecto.
		/// </summary>		
		private void btn_Modulos_Click(object sender, EventArgs e)
		{
			addViewModulos();
		}

		/// <summary>
		/// Este método se ejecutará al darle click al botón de "Opciones". Va a colocar
		/// la vista UC_Sistema_Opciones en pantalla.
		/// </summary>
		private void btn_Opciones_Click(object sender, EventArgs e)
		{
			UC_Sistema_Opciones uc = new UC_Sistema_Opciones(usuario_id);
			addUserControl(uc);
		}

		private void btn_Perfiles_Click(object sender, EventArgs e)
		{
			UC_Sistema_Perfil uc = new UC_Sistema_Perfil();
			addUserControl(uc);
		}
	}
}
