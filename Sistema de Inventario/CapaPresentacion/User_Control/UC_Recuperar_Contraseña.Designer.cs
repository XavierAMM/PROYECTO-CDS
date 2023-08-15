namespace CapaPresentacion.User_Control
{
	partial class UC_Recuperar_Contraseña
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			lbl_Titulo = new Label();
			pnl_Titulo = new Panel();
			lbl_Mensaje = new Label();
			pnl_Mensaje = new Panel();
			panel1 = new Panel();
			pnl_Contraseña = new Panel();
			label3 = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			pictureBox2 = new PictureBox();
			pictureBox9 = new PictureBox();
			txt_Contraseña = new TextBox();
			txt_Contraseña2 = new TextBox();
			btn_Guardar = new Button();
			pnl_Pregunta = new Panel();
			label2 = new Label();
			cmb_Pregunta_Seguridad = new ComboBox();
			txt_Respuesta = new TextBox();
			btn_Aceptar = new Button();
			panel2 = new Panel();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			pictureBox3 = new PictureBox();
			txt_Correo = new TextBox();
			txt_Usuario = new TextBox();
			pictureBox1 = new PictureBox();
			btn_Buscar = new Button();
			tableLayoutPanel3 = new TableLayoutPanel();
			pictureBox4 = new PictureBox();
			textBox3 = new TextBox();
			panel3 = new Panel();
			pnl_Titulo.SuspendLayout();
			pnl_Mensaje.SuspendLayout();
			panel1.SuspendLayout();
			pnl_Contraseña.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			pnl_Pregunta.SuspendLayout();
			panel2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// lbl_Titulo
			// 
			lbl_Titulo.AutoSize = true;
			lbl_Titulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Titulo.Location = new Point(163, 5);
			lbl_Titulo.Name = "lbl_Titulo";
			lbl_Titulo.Size = new Size(289, 31);
			lbl_Titulo.TabIndex = 0;
			lbl_Titulo.Text = "Recuperar Contraseña";
			// 
			// pnl_Titulo
			// 
			pnl_Titulo.Controls.Add(lbl_Titulo);
			pnl_Titulo.Dock = DockStyle.Top;
			pnl_Titulo.Location = new Point(0, 0);
			pnl_Titulo.Name = "pnl_Titulo";
			pnl_Titulo.Size = new Size(617, 56);
			pnl_Titulo.TabIndex = 8;
			// 
			// lbl_Mensaje
			// 
			lbl_Mensaje.AutoSize = true;
			lbl_Mensaje.Dock = DockStyle.Top;
			lbl_Mensaje.ForeColor = Color.Red;
			lbl_Mensaje.Location = new Point(0, 0);
			lbl_Mensaje.MaximumSize = new Size(617, 0);
			lbl_Mensaje.Name = "lbl_Mensaje";
			lbl_Mensaje.Size = new Size(95, 15);
			lbl_Mensaje.TabIndex = 1;
			lbl_Mensaje.Text = "Mensaje de error";
			// 
			// pnl_Mensaje
			// 
			pnl_Mensaje.Controls.Add(lbl_Mensaje);
			pnl_Mensaje.Dock = DockStyle.Top;
			pnl_Mensaje.Location = new Point(0, 56);
			pnl_Mensaje.Name = "pnl_Mensaje";
			pnl_Mensaje.Size = new Size(617, 26);
			pnl_Mensaje.TabIndex = 9;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(pnl_Contraseña);
			panel1.Controls.Add(pnl_Pregunta);
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(156, 16);
			panel1.Name = "panel1";
			panel1.Size = new Size(307, 311);
			panel1.TabIndex = 10;
			// 
			// pnl_Contraseña
			// 
			pnl_Contraseña.Controls.Add(label3);
			pnl_Contraseña.Controls.Add(tableLayoutPanel2);
			pnl_Contraseña.Controls.Add(btn_Guardar);
			pnl_Contraseña.Dock = DockStyle.Top;
			pnl_Contraseña.Location = new Point(0, 310);
			pnl_Contraseña.Name = "pnl_Contraseña";
			pnl_Contraseña.Size = new Size(290, 155);
			pnl_Contraseña.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(31, 13);
			label3.Name = "label3";
			label3.Size = new Size(156, 15);
			label3.TabIndex = 13;
			label3.Text = "Ingrese la contraseña nueva.";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(pictureBox2, 0, 1);
			tableLayoutPanel2.Controls.Add(pictureBox9, 0, 0);
			tableLayoutPanel2.Controls.Add(txt_Contraseña, 1, 0);
			tableLayoutPanel2.Controls.Add(txt_Contraseña2, 1, 1);
			tableLayoutPanel2.Location = new Point(35, 41);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(235, 71);
			tableLayoutPanel2.TabIndex = 12;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.ico_contraseña;
			pictureBox2.Location = new Point(3, 38);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(23, 23);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 14;
			pictureBox2.TabStop = false;
			// 
			// pictureBox9
			// 
			pictureBox9.Image = Properties.Resources.ico_contraseña;
			pictureBox9.Location = new Point(3, 3);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new Size(23, 23);
			pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox9.TabIndex = 13;
			pictureBox9.TabStop = false;
			// 
			// txt_Contraseña
			// 
			txt_Contraseña.Location = new Point(32, 3);
			txt_Contraseña.Name = "txt_Contraseña";
			txt_Contraseña.PasswordChar = '*';
			txt_Contraseña.PlaceholderText = "Contraseña";
			txt_Contraseña.Size = new Size(200, 23);
			txt_Contraseña.TabIndex = 0;
			txt_Contraseña.UseSystemPasswordChar = true;
			// 
			// txt_Contraseña2
			// 
			txt_Contraseña2.Location = new Point(32, 38);
			txt_Contraseña2.Name = "txt_Contraseña2";
			txt_Contraseña2.PasswordChar = '*';
			txt_Contraseña2.PlaceholderText = "Confirmar Contraseña";
			txt_Contraseña2.Size = new Size(200, 23);
			txt_Contraseña2.TabIndex = 1;
			txt_Contraseña2.UseSystemPasswordChar = true;
			// 
			// btn_Guardar
			// 
			btn_Guardar.BackColor = Color.White;
			btn_Guardar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Guardar.Location = new Point(112, 118);
			btn_Guardar.Name = "btn_Guardar";
			btn_Guardar.Size = new Size(94, 23);
			btn_Guardar.TabIndex = 2;
			btn_Guardar.Text = "Guardar";
			btn_Guardar.UseVisualStyleBackColor = false;
			btn_Guardar.Click += btn_Guardar_Click;
			// 
			// pnl_Pregunta
			// 
			pnl_Pregunta.BackColor = SystemColors.Control;
			pnl_Pregunta.Controls.Add(label2);
			pnl_Pregunta.Controls.Add(cmb_Pregunta_Seguridad);
			pnl_Pregunta.Controls.Add(txt_Respuesta);
			pnl_Pregunta.Controls.Add(btn_Aceptar);
			pnl_Pregunta.Dock = DockStyle.Top;
			pnl_Pregunta.Location = new Point(0, 155);
			pnl_Pregunta.Name = "pnl_Pregunta";
			pnl_Pregunta.Size = new Size(290, 155);
			pnl_Pregunta.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 16);
			label2.Name = "label2";
			label2.Size = new Size(230, 15);
			label2.TabIndex = 13;
			label2.Text = "Ingrese la respuesta de seguridad correcta.";
			// 
			// cmb_Pregunta_Seguridad
			// 
			cmb_Pregunta_Seguridad.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Pregunta_Seguridad.FormattingEnabled = true;
			cmb_Pregunta_Seguridad.Location = new Point(21, 49);
			cmb_Pregunta_Seguridad.Name = "cmb_Pregunta_Seguridad";
			cmb_Pregunta_Seguridad.Size = new Size(255, 23);
			cmb_Pregunta_Seguridad.TabIndex = 3;
			cmb_Pregunta_Seguridad.SelectedIndexChanged += cmb_Pregunta_Seguridad_SelectedIndexChanged;
			// 
			// txt_Respuesta
			// 
			txt_Respuesta.Location = new Point(21, 88);
			txt_Respuesta.Name = "txt_Respuesta";
			txt_Respuesta.PlaceholderText = "Escriba la Respuesta";
			txt_Respuesta.Size = new Size(255, 23);
			txt_Respuesta.TabIndex = 4;
			// 
			// btn_Aceptar
			// 
			btn_Aceptar.BackColor = Color.Yellow;
			btn_Aceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Aceptar.Location = new Point(112, 124);
			btn_Aceptar.Name = "btn_Aceptar";
			btn_Aceptar.Size = new Size(94, 23);
			btn_Aceptar.TabIndex = 5;
			btn_Aceptar.Text = "Aceptar";
			btn_Aceptar.UseVisualStyleBackColor = false;
			btn_Aceptar.Click += btn_Aceptar_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(label1);
			panel2.Controls.Add(tableLayoutPanel1);
			panel2.Controls.Add(btn_Buscar);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(290, 155);
			panel2.TabIndex = 6;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(35, 11);
			label1.Name = "label1";
			label1.Size = new Size(236, 15);
			label1.TabIndex = 12;
			label1.Text = "Ingrese sus credenciales de inicio de sesión.";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.Controls.Add(pictureBox3, 0, 1);
			tableLayoutPanel1.Controls.Add(txt_Correo, 1, 1);
			tableLayoutPanel1.Controls.Add(txt_Usuario, 1, 0);
			tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
			tableLayoutPanel1.Location = new Point(35, 40);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(235, 71);
			tableLayoutPanel1.TabIndex = 11;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.ico_correo_electronico;
			pictureBox3.Location = new Point(3, 38);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(23, 23);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 12;
			pictureBox3.TabStop = false;
			// 
			// txt_Correo
			// 
			txt_Correo.Location = new Point(32, 38);
			txt_Correo.Name = "txt_Correo";
			txt_Correo.PlaceholderText = "Ingrese su Correo";
			txt_Correo.Size = new Size(203, 23);
			txt_Correo.TabIndex = 1;
			// 
			// txt_Usuario
			// 
			txt_Usuario.Location = new Point(32, 3);
			txt_Usuario.Name = "txt_Usuario";
			txt_Usuario.PlaceholderText = "Ingrese su Usuario";
			txt_Usuario.Size = new Size(203, 23);
			txt_Usuario.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.Image = Properties.Resources.ico_usuario;
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(23, 23);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// btn_Buscar
			// 
			btn_Buscar.BackColor = Color.Green;
			btn_Buscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Buscar.ForeColor = Color.White;
			btn_Buscar.Location = new Point(112, 117);
			btn_Buscar.Name = "btn_Buscar";
			btn_Buscar.Size = new Size(94, 23);
			btn_Buscar.TabIndex = 2;
			btn_Buscar.Text = "Buscar";
			btn_Buscar.UseVisualStyleBackColor = false;
			btn_Buscar.Click += btn_Buscar_Click;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.Controls.Add(pictureBox4, 0, 1);
			tableLayoutPanel3.Location = new Point(0, 0);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Size = new Size(200, 100);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.ico_correo_electronico;
			pictureBox4.Location = new Point(3, 23);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(23, 23);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 12;
			pictureBox4.TabStop = false;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(32, 3);
			textBox3.Name = "textBox3";
			textBox3.PlaceholderText = "Ingrese su Correo";
			textBox3.Size = new Size(188, 23);
			textBox3.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Controls.Add(panel1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 82);
			panel3.Name = "panel3";
			panel3.Size = new Size(617, 352);
			panel3.TabIndex = 11;
			// 
			// UC_Recuperar_Contraseña
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(panel3);
			Controls.Add(pnl_Mensaje);
			Controls.Add(pnl_Titulo);
			Name = "UC_Recuperar_Contraseña";
			Size = new Size(617, 434);
			pnl_Titulo.ResumeLayout(false);
			pnl_Titulo.PerformLayout();
			pnl_Mensaje.ResumeLayout(false);
			pnl_Mensaje.PerformLayout();
			panel1.ResumeLayout(false);
			pnl_Contraseña.ResumeLayout(false);
			pnl_Contraseña.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			pnl_Pregunta.ResumeLayout(false);
			pnl_Pregunta.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label lbl_Titulo;
		private Panel pnl_Titulo;
		private Label lbl_Mensaje;
		private Panel pnl_Mensaje;
		private Panel panel1;
		private Button btn_Buscar;
		private TextBox txt_Correo;
		private TextBox txt_Usuario;
		private Panel pnl_Contraseña;
		private Button btn_Guardar;
		private TextBox txt_Contraseña2;
		private TextBox txt_Contraseña;
		private Panel pnl_Pregunta;
		private ComboBox cmb_Pregunta_Seguridad;
		private TextBox txt_Respuesta;
		private Button btn_Aceptar;
		private Panel panel2;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox3;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private PictureBox pictureBox4;
		private TextBox textBox3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox9;
		private Panel panel3;
		private Label label2;
		private Label label1;
		private Label label3;
	}
}
