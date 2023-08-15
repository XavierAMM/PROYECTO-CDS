namespace CapaPresentacion
{
	partial class Frm_InicioSesion
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
			txt_Usuario = new TextBox();
			txt_Contraseña = new TextBox();
			btn_Ingresar = new Button();
			panel1 = new Panel();
			lbl_Cerrar = new Label();
			panel2 = new Panel();
			panel6 = new Panel();
			pictureBox1 = new PictureBox();
			lbl_OlvideContraseña = new LinkLabel();
			pictureBox2 = new PictureBox();
			pnl_Mensaje = new Panel();
			lbl_Mensaje = new Label();
			panel4 = new Panel();
			label1 = new Label();
			panel3 = new Panel();
			btn_Registrarse = new Button();
			label2 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			pnl_Mensaje.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// txt_Usuario
			// 
			txt_Usuario.Location = new Point(54, 6);
			txt_Usuario.Name = "txt_Usuario";
			txt_Usuario.PlaceholderText = "Usuario";
			txt_Usuario.Size = new Size(152, 23);
			txt_Usuario.TabIndex = 0;
			// 
			// txt_Contraseña
			// 
			txt_Contraseña.Location = new Point(54, 35);
			txt_Contraseña.Name = "txt_Contraseña";
			txt_Contraseña.PasswordChar = '*';
			txt_Contraseña.PlaceholderText = "Contraseña";
			txt_Contraseña.Size = new Size(152, 23);
			txt_Contraseña.TabIndex = 1;
			txt_Contraseña.UseSystemPasswordChar = true;
			// 
			// btn_Ingresar
			// 
			btn_Ingresar.BackColor = SystemColors.MenuHighlight;
			btn_Ingresar.FlatStyle = FlatStyle.Popup;
			btn_Ingresar.ForeColor = SystemColors.Window;
			btn_Ingresar.Location = new Point(68, 67);
			btn_Ingresar.Name = "btn_Ingresar";
			btn_Ingresar.Size = new Size(91, 23);
			btn_Ingresar.TabIndex = 2;
			btn_Ingresar.Text = "Ingresar";
			btn_Ingresar.UseVisualStyleBackColor = false;
			btn_Ingresar.Click += btn_Ingresar_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightSeaGreen;
			panel1.Controls.Add(lbl_Cerrar);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(330, 16);
			panel1.TabIndex = 3;
			// 
			// lbl_Cerrar
			// 
			lbl_Cerrar.AutoSize = true;
			lbl_Cerrar.Dock = DockStyle.Right;
			lbl_Cerrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_Cerrar.ForeColor = Color.White;
			lbl_Cerrar.Location = new Point(314, 0);
			lbl_Cerrar.Name = "lbl_Cerrar";
			lbl_Cerrar.Size = new Size(16, 16);
			lbl_Cerrar.TabIndex = 0;
			lbl_Cerrar.Text = "X";
			lbl_Cerrar.Click += lbl_Cerrar_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.WhiteSmoke;
			panel2.Controls.Add(panel6);
			panel2.Controls.Add(pnl_Mensaje);
			panel2.Controls.Add(panel4);
			panel2.ImeMode = ImeMode.On;
			panel2.Location = new Point(50, 39);
			panel2.Name = "panel2";
			panel2.Size = new Size(231, 198);
			panel2.TabIndex = 6;
			// 
			// panel6
			// 
			panel6.Controls.Add(pictureBox1);
			panel6.Controls.Add(txt_Usuario);
			panel6.Controls.Add(lbl_OlvideContraseña);
			panel6.Controls.Add(txt_Contraseña);
			panel6.Controls.Add(btn_Ingresar);
			panel6.Controls.Add(pictureBox2);
			panel6.Dock = DockStyle.Fill;
			panel6.Location = new Point(0, 63);
			panel6.Name = "panel6";
			panel6.Size = new Size(231, 135);
			panel6.TabIndex = 9;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.Image = Properties.Resources.ico_usuario;
			pictureBox1.Location = new Point(25, 6);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(23, 23);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// lbl_OlvideContraseña
			// 
			lbl_OlvideContraseña.AutoSize = true;
			lbl_OlvideContraseña.Location = new Point(57, 104);
			lbl_OlvideContraseña.Name = "lbl_OlvideContraseña";
			lbl_OlvideContraseña.Size = new Size(119, 15);
			lbl_OlvideContraseña.TabIndex = 6;
			lbl_OlvideContraseña.TabStop = true;
			lbl_OlvideContraseña.Text = "Olvidé mi contraseña";
			lbl_OlvideContraseña.LinkClicked += lbl_OlvideContraseña_LinkClicked;
			// 
			// pictureBox2
			// 
			pictureBox2.BackgroundImageLayout = ImageLayout.None;
			pictureBox2.Image = Properties.Resources.ico_contraseña;
			pictureBox2.Location = new Point(25, 35);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(23, 23);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// pnl_Mensaje
			// 
			pnl_Mensaje.Controls.Add(lbl_Mensaje);
			pnl_Mensaje.Dock = DockStyle.Top;
			pnl_Mensaje.Location = new Point(0, 35);
			pnl_Mensaje.Name = "pnl_Mensaje";
			pnl_Mensaje.Size = new Size(231, 28);
			pnl_Mensaje.TabIndex = 8;
			// 
			// lbl_Mensaje
			// 
			lbl_Mensaje.AutoSize = true;
			lbl_Mensaje.Dock = DockStyle.Top;
			lbl_Mensaje.ForeColor = Color.Red;
			lbl_Mensaje.Location = new Point(0, 0);
			lbl_Mensaje.MaximumSize = new Size(231, 0);
			lbl_Mensaje.Name = "lbl_Mensaje";
			lbl_Mensaje.Size = new Size(95, 15);
			lbl_Mensaje.TabIndex = 0;
			lbl_Mensaje.Text = "Mensaje de error";
			// 
			// panel4
			// 
			panel4.Controls.Add(label1);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(231, 35);
			panel4.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.DarkCyan;
			label1.Location = new Point(45, 5);
			label1.Name = "label1";
			label1.Size = new Size(141, 25);
			label1.TabIndex = 3;
			label1.Text = "Iniciar Sesión";
			// 
			// panel3
			// 
			panel3.Controls.Add(btn_Registrarse);
			panel3.Controls.Add(label2);
			panel3.Location = new Point(50, 243);
			panel3.Name = "panel3";
			panel3.Size = new Size(231, 81);
			panel3.TabIndex = 7;
			// 
			// btn_Registrarse
			// 
			btn_Registrarse.BackColor = Color.GreenYellow;
			btn_Registrarse.FlatStyle = FlatStyle.Popup;
			btn_Registrarse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Registrarse.ForeColor = SystemColors.ActiveCaptionText;
			btn_Registrarse.Location = new Point(37, 34);
			btn_Registrarse.Name = "btn_Registrarse";
			btn_Registrarse.Size = new Size(161, 33);
			btn_Registrarse.TabIndex = 1;
			btn_Registrarse.Text = "Registrarse ahora";
			btn_Registrarse.UseVisualStyleBackColor = false;
			btn_Registrarse.Click += btn_Registrarse_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(64, 13);
			label2.Name = "label2";
			label2.Size = new Size(101, 18);
			label2.TabIndex = 0;
			label2.Text = "¿No tienes cuenta?";
			// 
			// Frm_InicioSesion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ClientSize = new Size(330, 377);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_InicioSesion";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Frm_InicioSesion";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			pnl_Mensaje.ResumeLayout(false);
			pnl_Mensaje.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txt_Usuario;
		private TextBox txt_Contraseña;
		private Button btn_Ingresar;
		private Panel panel1;
		private Label lbl_Cerrar;
		private Panel panel2;
		private Label label1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private LinkLabel lbl_OlvideContraseña;
		private Panel panel3;
		private Button btn_Registrarse;
		private Label label2;
		private Panel panel6;
		private Panel pnl_Mensaje;
		private Panel panel4;
		private Label lbl_Mensaje;
	}
}