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
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Cerrar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_OlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Mensaje = new System.Windows.Forms.Panel();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Mensaje.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(54, 6);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(152, 23);
            this.txt_Usuario.TabIndex = 0;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(54, 35);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.PlaceholderText = "Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(152, 23);
            this.txt_Contraseña.TabIndex = 1;
            this.txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Ingresar.Location = new System.Drawing.Point(68, 67);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(91, 23);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lbl_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 16);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Cerrar
            // 
            this.lbl_Cerrar.AutoSize = true;
            this.lbl_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cerrar.ForeColor = System.Drawing.Color.White;
            this.lbl_Cerrar.Location = new System.Drawing.Point(314, 0);
            this.lbl_Cerrar.Name = "lbl_Cerrar";
            this.lbl_Cerrar.Size = new System.Drawing.Size(16, 16);
            this.lbl_Cerrar.TabIndex = 0;
            this.lbl_Cerrar.Text = "X";
            this.lbl_Cerrar.Click += new System.EventHandler(this.lbl_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.pnl_Mensaje);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(50, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 198);
            this.panel2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.txt_Usuario);
            this.panel6.Controls.Add(this.lbl_OlvideContraseña);
            this.panel6.Controls.Add(this.txt_Contraseña);
            this.panel6.Controls.Add(this.btn_Ingresar);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 135);
            this.panel6.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ico_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(25, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_OlvideContraseña
            // 
            this.lbl_OlvideContraseña.AutoSize = true;
            this.lbl_OlvideContraseña.Location = new System.Drawing.Point(57, 104);
            this.lbl_OlvideContraseña.Name = "lbl_OlvideContraseña";
            this.lbl_OlvideContraseña.Size = new System.Drawing.Size(119, 15);
            this.lbl_OlvideContraseña.TabIndex = 6;
            this.lbl_OlvideContraseña.TabStop = true;
            this.lbl_OlvideContraseña.Text = "Olvidé mi contraseña";
            this.lbl_OlvideContraseña.Click += new System.EventHandler(this.lbl_OlvideContraseña_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.ico_contraseña;
            this.pictureBox2.Location = new System.Drawing.Point(25, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_Mensaje
            // 
            this.pnl_Mensaje.Controls.Add(this.lbl_Mensaje);
            this.pnl_Mensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Mensaje.Location = new System.Drawing.Point(0, 35);
            this.pnl_Mensaje.Name = "pnl_Mensaje";
            this.pnl_Mensaje.Size = new System.Drawing.Size(231, 28);
            this.pnl_Mensaje.TabIndex = 8;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mensaje.Location = new System.Drawing.Point(0, 0);
            this.lbl_Mensaje.MaximumSize = new System.Drawing.Size(231, 0);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(95, 15);
            this.lbl_Mensaje.TabIndex = 0;
            this.lbl_Mensaje.Text = "Mensaje de error";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 35);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar Sesión";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Registrarse);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(50, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 81);
            this.panel3.TabIndex = 7;
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registrarse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Registrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Registrarse.Location = new System.Drawing.Point(37, 34);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(161, 33);
            this.btn_Registrarse.TabIndex = 1;
            this.btn_Registrarse.Text = "Registrarse ahora";
            this.btn_Registrarse.UseVisualStyleBackColor = false;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "¿No tienes cuenta?";
            // 
            // Frm_InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(330, 377);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InicioSesion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Mensaje.ResumeLayout(false);
            this.pnl_Mensaje.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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