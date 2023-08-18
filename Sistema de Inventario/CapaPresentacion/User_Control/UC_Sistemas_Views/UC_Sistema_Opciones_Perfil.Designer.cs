namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	partial class UC_Sistema_Opciones_Perfil
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
			cmb_Opcion = new ComboBox();
			cmb_Modulo = new ComboBox();
			cmb_Perfil = new ComboBox();
			panel2 = new Panel();
			dgv_Perfil_Opciones = new DataGridView();
			panel4 = new Panel();
			btn_Nuevo = new Button();
			btn_Inactivar_Activar = new Button();
			btn_Editar = new Button();
			panel5 = new Panel();
			pictureBox1 = new PictureBox();
			txt_Filtro_Nombre = new TextBox();
			chb_Inactivos = new CheckBox();
			pnl_Actualizar = new Panel();
			panel9 = new Panel();
			btn_Asignar = new Button();
			panel8 = new Panel();
			panel7 = new Panel();
			lbl_Mensaje = new Label();
			panel6 = new Panel();
			lbl_Cancelar = new Label();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_Perfil_Opciones).BeginInit();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			pnl_Actualizar.SuspendLayout();
			panel9.SuspendLayout();
			panel8.SuspendLayout();
			panel7.SuspendLayout();
			panel6.SuspendLayout();
			SuspendLayout();
			// 
			// cmb_Opcion
			// 
			cmb_Opcion.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Opcion.FormattingEnabled = true;
			cmb_Opcion.Location = new Point(9, 97);
			cmb_Opcion.Name = "cmb_Opcion";
			cmb_Opcion.Size = new Size(154, 23);
			cmb_Opcion.TabIndex = 2;
			cmb_Opcion.SelectedIndexChanged += cmb_Opcion_SelectedIndexChanged;
			// 
			// cmb_Modulo
			// 
			cmb_Modulo.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Modulo.FormattingEnabled = true;
			cmb_Modulo.Location = new Point(9, 59);
			cmb_Modulo.Name = "cmb_Modulo";
			cmb_Modulo.Size = new Size(154, 23);
			cmb_Modulo.TabIndex = 1;
			cmb_Modulo.SelectedIndexChanged += cmb_Modulo_SelectedIndexChanged;
			// 
			// cmb_Perfil
			// 
			cmb_Perfil.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Perfil.FormattingEnabled = true;
			cmb_Perfil.Location = new Point(9, 20);
			cmb_Perfil.Name = "cmb_Perfil";
			cmb_Perfil.Size = new Size(154, 23);
			cmb_Perfil.TabIndex = 0;
			cmb_Perfil.SelectedIndexChanged += cmb_Perfil_SelectedIndexChanged;
			// 
			// panel2
			// 
			panel2.Controls.Add(dgv_Perfil_Opciones);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel5);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(184, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(442, 380);
			panel2.TabIndex = 1;
			// 
			// dgv_Perfil_Opciones
			// 
			dgv_Perfil_Opciones.AllowUserToAddRows = false;
			dgv_Perfil_Opciones.AllowUserToDeleteRows = false;
			dgv_Perfil_Opciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Perfil_Opciones.Dock = DockStyle.Fill;
			dgv_Perfil_Opciones.Location = new Point(0, 28);
			dgv_Perfil_Opciones.MultiSelect = false;
			dgv_Perfil_Opciones.Name = "dgv_Perfil_Opciones";
			dgv_Perfil_Opciones.ReadOnly = true;
			dgv_Perfil_Opciones.RowTemplate.Height = 25;
			dgv_Perfil_Opciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Perfil_Opciones.Size = new Size(442, 312);
			dgv_Perfil_Opciones.TabIndex = 8;
			dgv_Perfil_Opciones.CellClick += dgv_Perfil_Opciones_CellClick;
			// 
			// panel4
			// 
			panel4.Controls.Add(btn_Nuevo);
			panel4.Controls.Add(btn_Inactivar_Activar);
			panel4.Controls.Add(btn_Editar);
			panel4.Dock = DockStyle.Bottom;
			panel4.Location = new Point(0, 340);
			panel4.Name = "panel4";
			panel4.Size = new Size(442, 40);
			panel4.TabIndex = 7;
			// 
			// btn_Nuevo
			// 
			btn_Nuevo.BackColor = Color.Green;
			btn_Nuevo.ForeColor = Color.White;
			btn_Nuevo.Location = new Point(6, 3);
			btn_Nuevo.Name = "btn_Nuevo";
			btn_Nuevo.Size = new Size(97, 33);
			btn_Nuevo.TabIndex = 1;
			btn_Nuevo.Text = "Nuevo";
			btn_Nuevo.UseVisualStyleBackColor = false;
			btn_Nuevo.Click += btn_Nuevo_Click;
			// 
			// btn_Inactivar_Activar
			// 
			btn_Inactivar_Activar.BackColor = Color.Red;
			btn_Inactivar_Activar.ForeColor = Color.White;
			btn_Inactivar_Activar.Location = new Point(212, 3);
			btn_Inactivar_Activar.Name = "btn_Inactivar_Activar";
			btn_Inactivar_Activar.Size = new Size(97, 33);
			btn_Inactivar_Activar.TabIndex = 4;
			btn_Inactivar_Activar.Text = "Inactivar";
			btn_Inactivar_Activar.UseVisualStyleBackColor = false;
			btn_Inactivar_Activar.Click += btn_Inactivar_Activar_Click;
			// 
			// btn_Editar
			// 
			btn_Editar.BackColor = Color.Orange;
			btn_Editar.ForeColor = Color.White;
			btn_Editar.Location = new Point(109, 3);
			btn_Editar.MaximumSize = new Size(97, 33);
			btn_Editar.MinimumSize = new Size(97, 33);
			btn_Editar.Name = "btn_Editar";
			btn_Editar.Size = new Size(97, 33);
			btn_Editar.TabIndex = 3;
			btn_Editar.Text = "Editar";
			btn_Editar.UseVisualStyleBackColor = false;
			btn_Editar.Click += btn_Editar_Click;
			// 
			// panel5
			// 
			panel5.Controls.Add(pictureBox1);
			panel5.Controls.Add(txt_Filtro_Nombre);
			panel5.Controls.Add(chb_Inactivos);
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(442, 28);
			panel5.TabIndex = 6;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.ico_search;
			pictureBox1.Location = new Point(145, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(20, 20);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// txt_Filtro_Nombre
			// 
			txt_Filtro_Nombre.Location = new Point(165, 3);
			txt_Filtro_Nombre.Name = "txt_Filtro_Nombre";
			txt_Filtro_Nombre.PlaceholderText = "Buscar por perfil, módulo, opción";
			txt_Filtro_Nombre.Size = new Size(191, 23);
			txt_Filtro_Nombre.TabIndex = 3;
			// 
			// chb_Inactivos
			// 
			chb_Inactivos.AutoSize = true;
			chb_Inactivos.Location = new Point(6, 6);
			chb_Inactivos.Name = "chb_Inactivos";
			chb_Inactivos.Size = new Size(117, 19);
			chb_Inactivos.TabIndex = 2;
			chb_Inactivos.Text = "Mostrar Inactivos";
			chb_Inactivos.UseVisualStyleBackColor = true;
			chb_Inactivos.Click += chb_Inactivos_CheckedChanged;
			// 
			// pnl_Actualizar
			// 
			pnl_Actualizar.Controls.Add(panel9);
			pnl_Actualizar.Controls.Add(panel8);
			pnl_Actualizar.Controls.Add(panel7);
			pnl_Actualizar.Controls.Add(panel6);
			pnl_Actualizar.Dock = DockStyle.Left;
			pnl_Actualizar.Location = new Point(0, 0);
			pnl_Actualizar.Name = "pnl_Actualizar";
			pnl_Actualizar.Size = new Size(184, 380);
			pnl_Actualizar.TabIndex = 0;
			// 
			// panel9
			// 
			panel9.Controls.Add(btn_Asignar);
			panel9.Dock = DockStyle.Top;
			panel9.Location = new Point(0, 195);
			panel9.Name = "panel9";
			panel9.Size = new Size(172, 48);
			panel9.TabIndex = 4;
			// 
			// btn_Asignar
			// 
			btn_Asignar.BackColor = SystemColors.Control;
			btn_Asignar.ForeColor = Color.Black;
			btn_Asignar.Location = new Point(34, 8);
			btn_Asignar.Name = "btn_Asignar";
			btn_Asignar.Size = new Size(97, 33);
			btn_Asignar.TabIndex = 7;
			btn_Asignar.Text = "Asignar";
			btn_Asignar.UseVisualStyleBackColor = false;
			btn_Asignar.Click += btn_Asignar_Click;
			// 
			// panel8
			// 
			panel8.Controls.Add(cmb_Opcion);
			panel8.Controls.Add(cmb_Modulo);
			panel8.Controls.Add(cmb_Perfil);
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 46);
			panel8.Name = "panel8";
			panel8.Size = new Size(172, 149);
			panel8.TabIndex = 3;
			// 
			// panel7
			// 
			panel7.Controls.Add(lbl_Mensaje);
			panel7.Dock = DockStyle.Top;
			panel7.Location = new Point(0, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(172, 46);
			panel7.TabIndex = 2;
			// 
			// lbl_Mensaje
			// 
			lbl_Mensaje.AutoSize = true;
			lbl_Mensaje.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Mensaje.Location = new Point(12, 8);
			lbl_Mensaje.Name = "lbl_Mensaje";
			lbl_Mensaje.Size = new Size(50, 20);
			lbl_Mensaje.TabIndex = 2;
			lbl_Mensaje.Text = "label1";
			// 
			// panel6
			// 
			panel6.BackColor = Color.Brown;
			panel6.Controls.Add(lbl_Cancelar);
			panel6.Dock = DockStyle.Right;
			panel6.Location = new Point(172, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(12, 380);
			panel6.TabIndex = 1;
			// 
			// lbl_Cancelar
			// 
			lbl_Cancelar.AutoSize = true;
			lbl_Cancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Cancelar.ForeColor = Color.White;
			lbl_Cancelar.Location = new Point(-1, 6);
			lbl_Cancelar.Name = "lbl_Cancelar";
			lbl_Cancelar.Size = new Size(15, 15);
			lbl_Cancelar.TabIndex = 4;
			lbl_Cancelar.Text = "X";
			lbl_Cancelar.Click += lbl_Cancelar_Click;
			// 
			// UC_Sistema_Opciones_Perfil
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel2);
			Controls.Add(pnl_Actualizar);
			Name = "UC_Sistema_Opciones_Perfil";
			Size = new Size(626, 380);
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_Perfil_Opciones).EndInit();
			panel4.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			pnl_Actualizar.ResumeLayout(false);
			panel9.ResumeLayout(false);
			panel8.ResumeLayout(false);
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel2;
		private Panel panel5;
		private PictureBox pictureBox1;
		private TextBox txt_Filtro_Nombre;
		private CheckBox chb_Inactivos;
		private Panel panel4;
		private Button btn_Nuevo;
		private Button btn_Inactivar_Activar;
		private Button btn_Editar;
		private ComboBox cmb_Perfil;
		private DataGridView dgv_Perfil_Opciones;
		private ComboBox cmb_Opcion;
		private ComboBox cmb_Modulo;
		private Panel pnl_Actualizar;
		private Panel panel6;
		private Label lbl_Cancelar;
		private Panel panel7;
		private Label lbl_Mensaje;
		private Panel panel8;
		private Panel panel9;
		private Button btn_Asignar;
	}
}
