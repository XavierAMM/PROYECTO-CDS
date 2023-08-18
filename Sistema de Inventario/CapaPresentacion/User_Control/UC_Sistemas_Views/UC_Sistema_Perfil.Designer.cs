namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	partial class UC_Sistema_Perfil
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
			pnl_Actualizar = new Panel();
			panel8 = new Panel();
			btn_Aceptar = new Button();
			pnl_Nuevo = new Panel();
			txt_Descripcion = new TextBox();
			txt_Nombre = new TextBox();
			txt_Prioridad = new TextBox();
			panel6 = new Panel();
			lbl_Mensaje = new Label();
			panel3 = new Panel();
			lbl_Cancelar = new Label();
			panel2 = new Panel();
			dgv_Perfiles = new DataGridView();
			panel5 = new Panel();
			pictureBox1 = new PictureBox();
			txt_Filtro_Nombre = new TextBox();
			chb_Inactivos = new CheckBox();
			panel4 = new Panel();
			btn_Nuevo = new Button();
			btn_Inactivar_Activar = new Button();
			btn_Editar = new Button();
			pnl_Actualizar.SuspendLayout();
			panel8.SuspendLayout();
			pnl_Nuevo.SuspendLayout();
			panel6.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_Perfiles).BeginInit();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// pnl_Actualizar
			// 
			pnl_Actualizar.Controls.Add(panel8);
			pnl_Actualizar.Controls.Add(pnl_Nuevo);
			pnl_Actualizar.Controls.Add(panel6);
			pnl_Actualizar.Controls.Add(panel3);
			pnl_Actualizar.Dock = DockStyle.Left;
			pnl_Actualizar.Location = new Point(0, 0);
			pnl_Actualizar.Name = "pnl_Actualizar";
			pnl_Actualizar.Size = new Size(184, 380);
			pnl_Actualizar.TabIndex = 0;
			// 
			// panel8
			// 
			panel8.Controls.Add(btn_Aceptar);
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 256);
			panel8.Name = "panel8";
			panel8.Size = new Size(172, 53);
			panel8.TabIndex = 10;
			// 
			// btn_Aceptar
			// 
			btn_Aceptar.BackColor = SystemColors.Control;
			btn_Aceptar.ForeColor = Color.Black;
			btn_Aceptar.Location = new Point(34, 8);
			btn_Aceptar.Name = "btn_Aceptar";
			btn_Aceptar.Size = new Size(97, 33);
			btn_Aceptar.TabIndex = 6;
			btn_Aceptar.Text = "Aceptar";
			btn_Aceptar.UseVisualStyleBackColor = false;
			btn_Aceptar.Click += btn_Aceptar_Click;
			// 
			// pnl_Nuevo
			// 
			pnl_Nuevo.Controls.Add(txt_Descripcion);
			pnl_Nuevo.Controls.Add(txt_Nombre);
			pnl_Nuevo.Controls.Add(txt_Prioridad);
			pnl_Nuevo.Dock = DockStyle.Top;
			pnl_Nuevo.Location = new Point(0, 46);
			pnl_Nuevo.Name = "pnl_Nuevo";
			pnl_Nuevo.Size = new Size(172, 210);
			pnl_Nuevo.TabIndex = 9;
			// 
			// txt_Descripcion
			// 
			txt_Descripcion.Location = new Point(8, 53);
			txt_Descripcion.Multiline = true;
			txt_Descripcion.Name = "txt_Descripcion";
			txt_Descripcion.PlaceholderText = "Descripción del Perfil";
			txt_Descripcion.Size = new Size(153, 97);
			txt_Descripcion.TabIndex = 5;
			// 
			// txt_Nombre
			// 
			txt_Nombre.Location = new Point(8, 15);
			txt_Nombre.Name = "txt_Nombre";
			txt_Nombre.PlaceholderText = "Nombre del Perfil";
			txt_Nombre.Size = new Size(154, 23);
			txt_Nombre.TabIndex = 0;
			// 
			// txt_Prioridad
			// 
			txt_Prioridad.Location = new Point(12, 163);
			txt_Prioridad.Name = "txt_Prioridad";
			txt_Prioridad.PlaceholderText = "Prioridad";
			txt_Prioridad.Size = new Size(150, 23);
			txt_Prioridad.TabIndex = 4;
			txt_Prioridad.KeyPress += txt_Prioridad_KeyPress;
			// 
			// panel6
			// 
			panel6.Controls.Add(lbl_Mensaje);
			panel6.Dock = DockStyle.Top;
			panel6.Location = new Point(0, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(172, 46);
			panel6.TabIndex = 8;
			// 
			// lbl_Mensaje
			// 
			lbl_Mensaje.AutoSize = true;
			lbl_Mensaje.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Mensaje.Location = new Point(12, 8);
			lbl_Mensaje.Name = "lbl_Mensaje";
			lbl_Mensaje.Size = new Size(50, 20);
			lbl_Mensaje.TabIndex = 1;
			lbl_Mensaje.Text = "label1";
			// 
			// panel3
			// 
			panel3.BackColor = Color.Brown;
			panel3.Controls.Add(lbl_Cancelar);
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(172, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(12, 380);
			panel3.TabIndex = 3;
			// 
			// lbl_Cancelar
			// 
			lbl_Cancelar.AutoSize = true;
			lbl_Cancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Cancelar.ForeColor = Color.White;
			lbl_Cancelar.Location = new Point(-1, 6);
			lbl_Cancelar.Name = "lbl_Cancelar";
			lbl_Cancelar.Size = new Size(15, 15);
			lbl_Cancelar.TabIndex = 3;
			lbl_Cancelar.Text = "X";
			lbl_Cancelar.Click += lbl_Cancelar_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(dgv_Perfiles);
			panel2.Controls.Add(panel5);
			panel2.Controls.Add(panel4);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(184, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(442, 380);
			panel2.TabIndex = 1;
			// 
			// dgv_Perfiles
			// 
			dgv_Perfiles.AllowUserToAddRows = false;
			dgv_Perfiles.AllowUserToDeleteRows = false;
			dgv_Perfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Perfiles.Dock = DockStyle.Fill;
			dgv_Perfiles.Location = new Point(0, 28);
			dgv_Perfiles.MultiSelect = false;
			dgv_Perfiles.Name = "dgv_Perfiles";
			dgv_Perfiles.ReadOnly = true;
			dgv_Perfiles.RowTemplate.Height = 25;
			dgv_Perfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Perfiles.Size = new Size(442, 312);
			dgv_Perfiles.TabIndex = 6;
			dgv_Perfiles.CellClick += dgv_Perfiles_CellClick;
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
			panel5.TabIndex = 5;
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
			txt_Filtro_Nombre.PlaceholderText = "Buscar por nombre, descripción";
			txt_Filtro_Nombre.Size = new Size(191, 23);
			txt_Filtro_Nombre.TabIndex = 3;
			txt_Filtro_Nombre.KeyPress += txt_Filtro_Nombre_KeyPress;
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
			chb_Inactivos.CheckedChanged += chb_Inactivos_CheckedChanged;
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
			panel4.TabIndex = 4;
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
			// UC_Sistema_Perfil
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel2);
			Controls.Add(pnl_Actualizar);
			Name = "UC_Sistema_Perfil";
			Size = new Size(626, 380);
			pnl_Actualizar.ResumeLayout(false);
			panel8.ResumeLayout(false);
			pnl_Nuevo.ResumeLayout(false);
			pnl_Nuevo.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_Perfiles).EndInit();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel4.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnl_Actualizar;
		private Panel panel2;
		private Panel panel3;
		private Label lbl_Cancelar;
		private Panel panel6;
		private Label lbl_Mensaje;
		private Panel pnl_Nuevo;
		private TextBox txt_Nombre;
		private TextBox txt_Prioridad;
		private Panel panel8;
		private Button btn_Aceptar;
		private Panel panel4;
		private Button btn_Nuevo;
		private Button btn_Inactivar_Activar;
		private Button btn_Editar;
		private Panel panel5;
		private PictureBox pictureBox1;
		private TextBox txt_Filtro_Nombre;
		private CheckBox chb_Inactivos;
		private DataGridView dgv_Perfiles;
		private TextBox txt_Descripcion;
	}
}
