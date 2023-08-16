namespace CapaPresentacion.User_Control
{
	partial class UC_Registrarse
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
			label1 = new Label();
			txt_Nombre = new TextBox();
			txt_Apellido = new TextBox();
			panel1 = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			date_Fecha_Nacimiento = new DateTimePicker();
			pictureBox4 = new PictureBox();
			pic_nombre = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			txt_Telefono = new TextBox();
			pictureBox1 = new PictureBox();
			txt_Correo = new TextBox();
			label2 = new Label();
			panel2 = new Panel();
			tableLayoutPanel2 = new TableLayoutPanel();
			pictureBox6 = new PictureBox();
			txt_Contraseña2 = new TextBox();
			pictureBox8 = new PictureBox();
			txt_Contraseña = new TextBox();
			pictureBox9 = new PictureBox();
			txt_Usuario = new TextBox();
			txt_Respuesta_Pregunta = new TextBox();
			cmb_Pregunta_Seguridad = new ComboBox();
			pictureBox5 = new PictureBox();
			label3 = new Label();
			btn_Registrarse = new Button();
			panel3 = new Panel();
			pnl_Mensaje = new Panel();
			lbl_Mensaje = new Label();
			panel5 = new Panel();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pic_nombre).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			panel3.SuspendLayout();
			pnl_Mensaje.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(156, 5);
			label1.Name = "label1";
			label1.Size = new Size(289, 31);
			label1.TabIndex = 0;
			label1.Text = "Formulario de Registro";
			// 
			// txt_Nombre
			// 
			txt_Nombre.Location = new Point(32, 3);
			txt_Nombre.Name = "txt_Nombre";
			txt_Nombre.PlaceholderText = "Ingrese su Nombre *";
			txt_Nombre.Size = new Size(217, 23);
			txt_Nombre.TabIndex = 1;
			// 
			// txt_Apellido
			// 
			txt_Apellido.Location = new Point(32, 40);
			txt_Apellido.Name = "txt_Apellido";
			txt_Apellido.PlaceholderText = "Ingrese su Apellido *";
			txt_Apellido.Size = new Size(217, 23);
			txt_Apellido.TabIndex = 2;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(3, 7);
			panel1.Name = "panel1";
			panel1.Size = new Size(299, 265);
			panel1.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.Controls.Add(date_Fecha_Nacimiento, 1, 4);
			tableLayoutPanel1.Controls.Add(pictureBox4, 0, 4);
			tableLayoutPanel1.Controls.Add(pic_nombre, 0, 0);
			tableLayoutPanel1.Controls.Add(pictureBox2, 0, 3);
			tableLayoutPanel1.Controls.Add(pictureBox3, 0, 2);
			tableLayoutPanel1.Controls.Add(txt_Telefono, 1, 3);
			tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
			tableLayoutPanel1.Controls.Add(txt_Apellido, 1, 1);
			tableLayoutPanel1.Controls.Add(txt_Nombre, 1, 0);
			tableLayoutPanel1.Controls.Add(txt_Correo, 1, 2);
			tableLayoutPanel1.Location = new Point(13, 52);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(263, 189);
			tableLayoutPanel1.TabIndex = 4;
			// 
			// date_Fecha_Nacimiento
			// 
			date_Fecha_Nacimiento.Format = DateTimePickerFormat.Short;
			date_Fecha_Nacimiento.Location = new Point(32, 151);
			date_Fecha_Nacimiento.Name = "date_Fecha_Nacimiento";
			date_Fecha_Nacimiento.Size = new Size(217, 23);
			date_Fecha_Nacimiento.TabIndex = 7;
			date_Fecha_Nacimiento.Value = new DateTime(2023, 7, 26, 15, 10, 12, 0);
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.ico_fecha_nacimiento;
			pictureBox4.Location = new Point(3, 151);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(23, 23);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 12;
			pictureBox4.TabStop = false;
			// 
			// pic_nombre
			// 
			pic_nombre.Image = Properties.Resources.ico_nombre_apellido;
			pic_nombre.Location = new Point(3, 3);
			pic_nombre.Name = "pic_nombre";
			pic_nombre.Size = new Size(23, 23);
			pic_nombre.SizeMode = PictureBoxSizeMode.StretchImage;
			pic_nombre.TabIndex = 8;
			pic_nombre.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.ico_telefono;
			pictureBox2.Location = new Point(3, 114);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(23, 23);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 10;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.ico_correo_electronico;
			pictureBox3.Location = new Point(3, 77);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(23, 23);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 11;
			pictureBox3.TabStop = false;
			// 
			// txt_Telefono
			// 
			txt_Telefono.Location = new Point(32, 114);
			txt_Telefono.Name = "txt_Telefono";
			txt_Telefono.PlaceholderText = "Ingrese su Número de Teléfono";
			txt_Telefono.Size = new Size(217, 23);
			txt_Telefono.TabIndex = 5;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.ico_nombre_apellido;
			pictureBox1.Location = new Point(3, 40);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(23, 23);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// txt_Correo
			// 
			txt_Correo.Location = new Point(32, 77);
			txt_Correo.Name = "txt_Correo";
			txt_Correo.PlaceholderText = "Ingrese su Correo Electrónico *";
			txt_Correo.Size = new Size(217, 23);
			txt_Correo.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(47, 15);
			label2.Name = "label2";
			label2.Size = new Size(182, 25);
			label2.TabIndex = 3;
			label2.Text = "Datos Personales";
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Control;
			panel2.Controls.Add(tableLayoutPanel2);
			panel2.Controls.Add(label3);
			panel2.Location = new Point(306, 7);
			panel2.Name = "panel2";
			panel2.Size = new Size(308, 265);
			panel2.TabIndex = 5;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(pictureBox6, 0, 0);
			tableLayoutPanel2.Controls.Add(txt_Contraseña2, 1, 2);
			tableLayoutPanel2.Controls.Add(pictureBox8, 0, 1);
			tableLayoutPanel2.Controls.Add(txt_Contraseña, 1, 1);
			tableLayoutPanel2.Controls.Add(pictureBox9, 0, 2);
			tableLayoutPanel2.Controls.Add(txt_Usuario, 1, 0);
			tableLayoutPanel2.Controls.Add(txt_Respuesta_Pregunta, 1, 4);
			tableLayoutPanel2.Controls.Add(cmb_Pregunta_Seguridad, 1, 3);
			tableLayoutPanel2.Controls.Add(pictureBox5, 0, 3);
			tableLayoutPanel2.Location = new Point(11, 52);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 5;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(283, 189);
			tableLayoutPanel2.TabIndex = 4;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = Properties.Resources.ico_usuario;
			pictureBox6.Location = new Point(3, 3);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(23, 23);
			pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox6.TabIndex = 8;
			pictureBox6.TabStop = false;
			// 
			// txt_Contraseña2
			// 
			txt_Contraseña2.Location = new Point(32, 77);
			txt_Contraseña2.Name = "txt_Contraseña2";
			txt_Contraseña2.PasswordChar = '*';
			txt_Contraseña2.PlaceholderText = "Vuelva a Ingresar su Contraseña *";
			txt_Contraseña2.Size = new Size(251, 23);
			txt_Contraseña2.TabIndex = 4;
			txt_Contraseña2.UseSystemPasswordChar = true;
			// 
			// pictureBox8
			// 
			pictureBox8.Image = Properties.Resources.ico_contraseña;
			pictureBox8.Location = new Point(3, 40);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new Size(23, 23);
			pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox8.TabIndex = 9;
			pictureBox8.TabStop = false;
			// 
			// txt_Contraseña
			// 
			txt_Contraseña.Location = new Point(32, 40);
			txt_Contraseña.Name = "txt_Contraseña";
			txt_Contraseña.PasswordChar = '*';
			txt_Contraseña.PlaceholderText = "Ingrese su Contraseña *";
			txt_Contraseña.Size = new Size(251, 23);
			txt_Contraseña.TabIndex = 2;
			txt_Contraseña.UseSystemPasswordChar = true;
			// 
			// pictureBox9
			// 
			pictureBox9.Image = Properties.Resources.ico_contraseña;
			pictureBox9.Location = new Point(3, 77);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new Size(23, 23);
			pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox9.TabIndex = 10;
			pictureBox9.TabStop = false;
			// 
			// txt_Usuario
			// 
			txt_Usuario.Location = new Point(32, 3);
			txt_Usuario.Name = "txt_Usuario";
			txt_Usuario.PlaceholderText = "Ingrese su Nombre de Usuario *";
			txt_Usuario.Size = new Size(251, 23);
			txt_Usuario.TabIndex = 1;
			// 
			// txt_Respuesta_Pregunta
			// 
			txt_Respuesta_Pregunta.Location = new Point(32, 151);
			txt_Respuesta_Pregunta.Name = "txt_Respuesta_Pregunta";
			txt_Respuesta_Pregunta.PlaceholderText = "Ingrese la Respuesta *";
			txt_Respuesta_Pregunta.Size = new Size(251, 23);
			txt_Respuesta_Pregunta.TabIndex = 11;
			// 
			// cmb_Pregunta_Seguridad
			// 
			cmb_Pregunta_Seguridad.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Pregunta_Seguridad.FlatStyle = FlatStyle.System;
			cmb_Pregunta_Seguridad.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			cmb_Pregunta_Seguridad.ItemHeight = 13;
			cmb_Pregunta_Seguridad.Items.AddRange(new object[] { "Seleccione Pregunta de Seguridad *", "Seleccione Pregunta de Seguridad *", "Seleccione Pregunta de Seguridad *", "Seleccione Pregunta de Seguridad *" });
			cmb_Pregunta_Seguridad.Location = new Point(32, 114);
			cmb_Pregunta_Seguridad.MinimumSize = new Size(251, 0);
			cmb_Pregunta_Seguridad.Name = "cmb_Pregunta_Seguridad";
			cmb_Pregunta_Seguridad.Size = new Size(251, 21);
			cmb_Pregunta_Seguridad.TabIndex = 12;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = Properties.Resources.ico_pregunta;
			pictureBox5.Location = new Point(3, 114);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(23, 23);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 13;
			pictureBox5.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(58, 15);
			label3.Name = "label3";
			label3.Size = new Size(178, 25);
			label3.TabIndex = 3;
			label3.Text = "Datos de Usuario";
			// 
			// btn_Registrarse
			// 
			btn_Registrarse.BackColor = Color.SpringGreen;
			btn_Registrarse.FlatAppearance.BorderSize = 0;
			btn_Registrarse.FlatStyle = FlatStyle.Popup;
			btn_Registrarse.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Registrarse.Location = new Point(223, 278);
			btn_Registrarse.Name = "btn_Registrarse";
			btn_Registrarse.Size = new Size(154, 39);
			btn_Registrarse.TabIndex = 6;
			btn_Registrarse.Text = "Registrarse";
			btn_Registrarse.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			panel3.Controls.Add(label1);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(617, 56);
			panel3.TabIndex = 7;
			// 
			// pnl_Mensaje
			// 
			pnl_Mensaje.Controls.Add(lbl_Mensaje);
			pnl_Mensaje.Dock = DockStyle.Top;
			pnl_Mensaje.Location = new Point(0, 56);
			pnl_Mensaje.Name = "pnl_Mensaje";
			pnl_Mensaje.Size = new Size(617, 30);
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
			lbl_Mensaje.TabIndex = 1;
			lbl_Mensaje.Text = "Mensaje de error";
			// 
			// panel5
			// 
			panel5.Controls.Add(panel1);
			panel5.Controls.Add(panel2);
			panel5.Controls.Add(btn_Registrarse);
			panel5.Dock = DockStyle.Fill;
			panel5.Location = new Point(0, 86);
			panel5.Name = "panel5";
			panel5.Size = new Size(617, 348);
			panel5.TabIndex = 9;
			// 
			// UC_Registrarse
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(panel5);
			Controls.Add(pnl_Mensaje);
			Controls.Add(panel3);
			Name = "UC_Registrarse";
			Size = new Size(617, 434);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pic_nombre).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			pnl_Mensaje.ResumeLayout(false);
			pnl_Mensaje.PerformLayout();
			panel5.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox txt_Nombre;
		private TextBox txt_Apellido;
		private Panel panel1;
		private TextBox txt_Telefono;
		private Label label2;
		private DateTimePicker date_Fecha_Nacimiento;
		private TextBox txt_Correo;
		private PictureBox pictureBox4;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private PictureBox pic_nombre;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel2;
		private TableLayoutPanel tableLayoutPanel2;
		private PictureBox pictureBox6;
		private TextBox txt_Contraseña2;
		private PictureBox pictureBox8;
		private TextBox txt_Contraseña;
		private PictureBox pictureBox9;
		private TextBox txt_Usuario;
		private Label label3;
		private Button btn_Registrarse;
		private Panel panel3;
		private Panel pnl_Mensaje;
		private Panel panel5;
		private Label lbl_Mensaje;
		private TextBox txt_Respuesta_Pregunta;
		private ComboBox cmb_Pregunta_Seguridad;
		private PictureBox pictureBox5;
	}
}
