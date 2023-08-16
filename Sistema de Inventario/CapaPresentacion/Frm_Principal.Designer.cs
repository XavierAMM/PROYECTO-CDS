namespace CapaPresentacion
{
	partial class Frm_Principal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			lbl_Cerrar = new Label();
			pnl_Fondo = new Panel();
			pnl_Menu = new Panel();
			pnl_Divisor2 = new Panel();
			pnl_MiUsuario = new Panel();
			lbl_Perfil = new Label();
			lbl_Usuario = new Label();
			pic_Usuario = new PictureBox();
			pnl_Divisor = new Panel();
			pnl_Logo = new Panel();
			pic_Logo = new PictureBox();
			pnl_View = new Panel();
			panel1.SuspendLayout();
			pnl_Fondo.SuspendLayout();
			pnl_MiUsuario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pic_Usuario).BeginInit();
			pnl_Logo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightSeaGreen;
			panel1.Controls.Add(lbl_Cerrar);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 16);
			panel1.TabIndex = 4;
			// 
			// lbl_Cerrar
			// 
			lbl_Cerrar.AutoSize = true;
			lbl_Cerrar.Dock = DockStyle.Right;
			lbl_Cerrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_Cerrar.ForeColor = Color.White;
			lbl_Cerrar.Location = new Point(784, 0);
			lbl_Cerrar.Name = "lbl_Cerrar";
			lbl_Cerrar.Size = new Size(16, 16);
			lbl_Cerrar.TabIndex = 0;
			lbl_Cerrar.Text = "X";
			lbl_Cerrar.Click += lbl_Cerrar_Click;
			// 
			// pnl_Fondo
			// 
			pnl_Fondo.AutoScroll = true;
			pnl_Fondo.BackColor = Color.FromArgb(6, 30, 38);
			pnl_Fondo.Controls.Add(pnl_Menu);
			pnl_Fondo.Controls.Add(pnl_Divisor2);
			pnl_Fondo.Controls.Add(pnl_MiUsuario);
			pnl_Fondo.Controls.Add(pnl_Divisor);
			pnl_Fondo.Controls.Add(pnl_Logo);
			pnl_Fondo.Dock = DockStyle.Left;
			pnl_Fondo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			pnl_Fondo.Location = new Point(0, 16);
			pnl_Fondo.Name = "pnl_Fondo";
			pnl_Fondo.Size = new Size(183, 434);
			pnl_Fondo.TabIndex = 5;
			// 
			// pnl_Menu
			// 
			pnl_Menu.AutoScroll = true;
			pnl_Menu.BackColor = Color.Transparent;
			pnl_Menu.Dock = DockStyle.Fill;
			pnl_Menu.Location = new Point(0, 84);
			pnl_Menu.Name = "pnl_Menu";
			pnl_Menu.Size = new Size(183, 303);
			pnl_Menu.TabIndex = 3;
			// 
			// pnl_Divisor2
			// 
			pnl_Divisor2.BackColor = Color.White;
			pnl_Divisor2.Dock = DockStyle.Bottom;
			pnl_Divisor2.Location = new Point(0, 387);
			pnl_Divisor2.Name = "pnl_Divisor2";
			pnl_Divisor2.Size = new Size(183, 5);
			pnl_Divisor2.TabIndex = 3;
			// 
			// pnl_MiUsuario
			// 
			pnl_MiUsuario.Controls.Add(lbl_Perfil);
			pnl_MiUsuario.Controls.Add(lbl_Usuario);
			pnl_MiUsuario.Controls.Add(pic_Usuario);
			pnl_MiUsuario.Dock = DockStyle.Bottom;
			pnl_MiUsuario.Location = new Point(0, 392);
			pnl_MiUsuario.Name = "pnl_MiUsuario";
			pnl_MiUsuario.Size = new Size(183, 42);
			pnl_MiUsuario.TabIndex = 1;
			// 
			// lbl_Perfil
			// 
			lbl_Perfil.AutoEllipsis = true;
			lbl_Perfil.AutoSize = true;
			lbl_Perfil.ForeColor = Color.White;
			lbl_Perfil.Location = new Point(44, 19);
			lbl_Perfil.Name = "lbl_Perfil";
			lbl_Perfil.Size = new Size(89, 13);
			lbl_Perfil.TabIndex = 2;
			lbl_Perfil.Text = "Perfil: Sin Asignar";
			// 
			// lbl_Usuario
			// 
			lbl_Usuario.AutoEllipsis = true;
			lbl_Usuario.AutoSize = true;
			lbl_Usuario.ForeColor = Color.White;
			lbl_Usuario.Location = new Point(43, 3);
			lbl_Usuario.Name = "lbl_Usuario";
			lbl_Usuario.Size = new Size(83, 13);
			lbl_Usuario.TabIndex = 1;
			lbl_Usuario.Text = "Usuario: usuario";
			// 
			// pic_Usuario
			// 
			pic_Usuario.BackColor = Color.FromArgb(192, 255, 255);
			pic_Usuario.Image = Properties.Resources.ico_usuario;
			pic_Usuario.Location = new Point(6, 3);
			pic_Usuario.Name = "pic_Usuario";
			pic_Usuario.Size = new Size(33, 33);
			pic_Usuario.SizeMode = PictureBoxSizeMode.StretchImage;
			pic_Usuario.TabIndex = 0;
			pic_Usuario.TabStop = false;
			// 
			// pnl_Divisor
			// 
			pnl_Divisor.BackColor = Color.White;
			pnl_Divisor.Dock = DockStyle.Top;
			pnl_Divisor.Location = new Point(0, 79);
			pnl_Divisor.Name = "pnl_Divisor";
			pnl_Divisor.Size = new Size(183, 5);
			pnl_Divisor.TabIndex = 2;
			// 
			// pnl_Logo
			// 
			pnl_Logo.Controls.Add(pic_Logo);
			pnl_Logo.Dock = DockStyle.Top;
			pnl_Logo.Location = new Point(0, 0);
			pnl_Logo.Name = "pnl_Logo";
			pnl_Logo.Size = new Size(183, 79);
			pnl_Logo.TabIndex = 0;
			// 
			// pic_Logo
			// 
			pic_Logo.Image = Properties.Resources.logo_sistema_inventario;
			pic_Logo.Location = new Point(3, 6);
			pic_Logo.Name = "pic_Logo";
			pic_Logo.Size = new Size(174, 62);
			pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
			pic_Logo.TabIndex = 0;
			pic_Logo.TabStop = false;
			// 
			// pnl_View
			// 
			pnl_View.BackColor = Color.White;
			pnl_View.Dock = DockStyle.Fill;
			pnl_View.Location = new Point(183, 16);
			pnl_View.Name = "pnl_View";
			pnl_View.Size = new Size(617, 434);
			pnl_View.TabIndex = 6;
			// 
			// Frm_Principal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pnl_View);
			Controls.Add(pnl_Fondo);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_Principal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Frm_Principal";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			pnl_Fondo.ResumeLayout(false);
			pnl_MiUsuario.ResumeLayout(false);
			pnl_MiUsuario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pic_Usuario).EndInit();
			pnl_Logo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label lbl_Cerrar;
		private Panel pnl_Fondo;
		private Panel pnl_Logo;
		private PictureBox pic_Logo;
		private Panel pnl_MiUsuario;
		private Label lbl_Usuario;
		private PictureBox pic_Usuario;
		private Label lbl_Perfil;
		private Panel pnl_Divisor;
		private Panel pnl_Menu;
		private Panel pnl_View;
		private Panel pnl_Divisor2;
	}
}