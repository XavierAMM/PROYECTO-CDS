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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Cerrar = new System.Windows.Forms.Label();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Divisor2 = new System.Windows.Forms.Panel();
            this.pnl_MiUsuario = new System.Windows.Forms.Panel();
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pic_Usuario = new System.Windows.Forms.PictureBox();
            this.pnl_Divisor = new System.Windows.Forms.Panel();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_View = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_Fondo.SuspendLayout();
            this.pnl_MiUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Usuario)).BeginInit();
            this.pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lbl_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 16);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Cerrar
            // 
            this.lbl_Cerrar.AutoSize = true;
            this.lbl_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cerrar.ForeColor = System.Drawing.Color.White;
            this.lbl_Cerrar.Location = new System.Drawing.Point(784, 0);
            this.lbl_Cerrar.Name = "lbl_Cerrar";
            this.lbl_Cerrar.Size = new System.Drawing.Size(16, 16);
            this.lbl_Cerrar.TabIndex = 0;
            this.lbl_Cerrar.Text = "X";
            this.lbl_Cerrar.Click += new System.EventHandler(this.lbl_Cerrar_Click);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.AutoScroll = true;
            this.pnl_Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.pnl_Fondo.Controls.Add(this.pnl_Menu);
            this.pnl_Fondo.Controls.Add(this.pnl_Divisor2);
            this.pnl_Fondo.Controls.Add(this.pnl_MiUsuario);
            this.pnl_Fondo.Controls.Add(this.pnl_Divisor);
            this.pnl_Fondo.Controls.Add(this.pnl_Logo);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 16);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(183, 434);
            this.pnl_Fondo.TabIndex = 5;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.AutoScroll = true;
            this.pnl_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 84);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(183, 303);
            this.pnl_Menu.TabIndex = 3;
            // 
            // pnl_Divisor2
            // 
            this.pnl_Divisor2.BackColor = System.Drawing.Color.White;
            this.pnl_Divisor2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Divisor2.Location = new System.Drawing.Point(0, 387);
            this.pnl_Divisor2.Name = "pnl_Divisor2";
            this.pnl_Divisor2.Size = new System.Drawing.Size(183, 5);
            this.pnl_Divisor2.TabIndex = 3;
            // 
            // pnl_MiUsuario
            // 
            this.pnl_MiUsuario.Controls.Add(this.lbl_Perfil);
            this.pnl_MiUsuario.Controls.Add(this.lbl_Usuario);
            this.pnl_MiUsuario.Controls.Add(this.pic_Usuario);
            this.pnl_MiUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MiUsuario.Location = new System.Drawing.Point(0, 392);
            this.pnl_MiUsuario.Name = "pnl_MiUsuario";
            this.pnl_MiUsuario.Size = new System.Drawing.Size(183, 42);
            this.pnl_MiUsuario.TabIndex = 1;
            // 
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoEllipsis = true;
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.ForeColor = System.Drawing.Color.White;
            this.lbl_Perfil.Location = new System.Drawing.Point(44, 19);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(89, 13);
            this.lbl_Perfil.TabIndex = 2;
            this.lbl_Perfil.Text = "Perfil: Sin Asignar";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoEllipsis = true;
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(43, 3);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(83, 13);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuario: usuario";
            // 
            // pic_Usuario
            // 
            this.pic_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pic_Usuario.Image = global::CapaPresentacion.Properties.Resources.ico_usuario;
            this.pic_Usuario.Location = new System.Drawing.Point(6, 3);
            this.pic_Usuario.Name = "pic_Usuario";
            this.pic_Usuario.Size = new System.Drawing.Size(33, 33);
            this.pic_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Usuario.TabIndex = 0;
            this.pic_Usuario.TabStop = false;
            // 
            // pnl_Divisor
            // 
            this.pnl_Divisor.BackColor = System.Drawing.Color.White;
            this.pnl_Divisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Divisor.Location = new System.Drawing.Point(0, 79);
            this.pnl_Divisor.Name = "pnl_Divisor";
            this.pnl_Divisor.Size = new System.Drawing.Size(183, 5);
            this.pnl_Divisor.TabIndex = 2;
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.Controls.Add(this.pic_Logo);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(183, 79);
            this.pnl_Logo.TabIndex = 0;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::CapaPresentacion.Properties.Resources.logo_sistema_inventario;
            this.pic_Logo.Location = new System.Drawing.Point(3, 6);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(174, 62);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // pnl_View
            // 
            this.pnl_View.BackColor = System.Drawing.Color.White;
            this.pnl_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_View.Location = new System.Drawing.Point(183, 16);
            this.pnl_View.Name = "pnl_View";
            this.pnl_View.Size = new System.Drawing.Size(617, 434);
            this.pnl_View.TabIndex = 6;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_View);
            this.Controls.Add(this.pnl_Fondo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_MiUsuario.ResumeLayout(false);
            this.pnl_MiUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Usuario)).EndInit();
            this.pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

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