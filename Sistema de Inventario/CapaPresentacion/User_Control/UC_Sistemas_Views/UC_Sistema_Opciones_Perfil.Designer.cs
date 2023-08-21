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
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.cmb_Modulo = new System.Windows.Forms.ComboBox();
            this.cmb_Perfil = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Perfil_Opciones = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Inactivar_Activar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Filtro_Nombre = new System.Windows.Forms.TextBox();
            this.chb_Inactivos = new System.Windows.Forms.CheckBox();
            this.pnl_Actualizar = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Cancelar = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Perfil_Opciones)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Actualizar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Opcion
            // 
            this.cmb_Opcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Opcion.FormattingEnabled = true;
            this.cmb_Opcion.Location = new System.Drawing.Point(9, 97);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(154, 23);
            this.cmb_Opcion.TabIndex = 2;
            this.cmb_Opcion.SelectedIndexChanged += new System.EventHandler(this.cmb_Opcion_SelectedIndexChanged);
            // 
            // cmb_Modulo
            // 
            this.cmb_Modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Modulo.FormattingEnabled = true;
            this.cmb_Modulo.Location = new System.Drawing.Point(9, 59);
            this.cmb_Modulo.Name = "cmb_Modulo";
            this.cmb_Modulo.Size = new System.Drawing.Size(154, 23);
            this.cmb_Modulo.TabIndex = 1;
            this.cmb_Modulo.SelectedIndexChanged += new System.EventHandler(this.cmb_Modulo_SelectedIndexChanged);
            // 
            // cmb_Perfil
            // 
            this.cmb_Perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Perfil.FormattingEnabled = true;
            this.cmb_Perfil.Location = new System.Drawing.Point(9, 20);
            this.cmb_Perfil.Name = "cmb_Perfil";
            this.cmb_Perfil.Size = new System.Drawing.Size(154, 23);
            this.cmb_Perfil.TabIndex = 0;
            this.cmb_Perfil.SelectedIndexChanged += new System.EventHandler(this.cmb_Perfil_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Perfil_Opciones);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 380);
            this.panel2.TabIndex = 1;
            // 
            // dgv_Perfil_Opciones
            // 
            this.dgv_Perfil_Opciones.AllowUserToAddRows = false;
            this.dgv_Perfil_Opciones.AllowUserToDeleteRows = false;
            this.dgv_Perfil_Opciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Perfil_Opciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Perfil_Opciones.Location = new System.Drawing.Point(0, 28);
            this.dgv_Perfil_Opciones.MultiSelect = false;
            this.dgv_Perfil_Opciones.Name = "dgv_Perfil_Opciones";
            this.dgv_Perfil_Opciones.ReadOnly = true;
            this.dgv_Perfil_Opciones.RowTemplate.Height = 25;
            this.dgv_Perfil_Opciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Perfil_Opciones.Size = new System.Drawing.Size(442, 312);
            this.dgv_Perfil_Opciones.TabIndex = 8;
            this.dgv_Perfil_Opciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Perfil_Opciones_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Nuevo);
            this.panel4.Controls.Add(this.btn_Inactivar_Activar);
            this.panel4.Controls.Add(this.btn_Editar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 40);
            this.panel4.TabIndex = 7;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.Green;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Location = new System.Drawing.Point(6, 3);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(97, 33);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Inactivar_Activar
            // 
            this.btn_Inactivar_Activar.BackColor = System.Drawing.Color.Red;
            this.btn_Inactivar_Activar.ForeColor = System.Drawing.Color.White;
            this.btn_Inactivar_Activar.Location = new System.Drawing.Point(212, 3);
            this.btn_Inactivar_Activar.Name = "btn_Inactivar_Activar";
            this.btn_Inactivar_Activar.Size = new System.Drawing.Size(97, 33);
            this.btn_Inactivar_Activar.TabIndex = 4;
            this.btn_Inactivar_Activar.Text = "Inactivar";
            this.btn_Inactivar_Activar.UseVisualStyleBackColor = false;
            this.btn_Inactivar_Activar.Click += new System.EventHandler(this.btn_Inactivar_Activar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Orange;
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(109, 3);
            this.btn_Editar.MaximumSize = new System.Drawing.Size(97, 33);
            this.btn_Editar.MinimumSize = new System.Drawing.Size(97, 33);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(97, 33);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txt_Filtro_Nombre);
            this.panel5.Controls.Add(this.chb_Inactivos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 28);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ico_search;
            this.pictureBox1.Location = new System.Drawing.Point(145, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Filtro_Nombre
            // 
            this.txt_Filtro_Nombre.Location = new System.Drawing.Point(165, 3);
            this.txt_Filtro_Nombre.Name = "txt_Filtro_Nombre";
            this.txt_Filtro_Nombre.PlaceholderText = "Buscar por perfil, módulo, opción";
            this.txt_Filtro_Nombre.Size = new System.Drawing.Size(191, 23);
            this.txt_Filtro_Nombre.TabIndex = 3;
            this.txt_Filtro_Nombre.TextChanged += new System.EventHandler(this.txt_Filtro_Nombre_TextChanged);
            // 
            // chb_Inactivos
            // 
            this.chb_Inactivos.AutoSize = true;
            this.chb_Inactivos.Location = new System.Drawing.Point(6, 6);
            this.chb_Inactivos.Name = "chb_Inactivos";
            this.chb_Inactivos.Size = new System.Drawing.Size(117, 19);
            this.chb_Inactivos.TabIndex = 2;
            this.chb_Inactivos.Text = "Mostrar Inactivos";
            this.chb_Inactivos.UseVisualStyleBackColor = true;
            this.chb_Inactivos.CheckedChanged += new System.EventHandler(this.chb_Inactivos_CheckedChanged);
            // 
            // pnl_Actualizar
            // 
            this.pnl_Actualizar.Controls.Add(this.panel9);
            this.pnl_Actualizar.Controls.Add(this.panel8);
            this.pnl_Actualizar.Controls.Add(this.panel7);
            this.pnl_Actualizar.Controls.Add(this.panel6);
            this.pnl_Actualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Actualizar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Actualizar.Name = "pnl_Actualizar";
            this.pnl_Actualizar.Size = new System.Drawing.Size(184, 380);
            this.pnl_Actualizar.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_Asignar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 195);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(172, 48);
            this.panel9.TabIndex = 4;
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Asignar.ForeColor = System.Drawing.Color.Black;
            this.btn_Asignar.Location = new System.Drawing.Point(34, 8);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(97, 33);
            this.btn_Asignar.TabIndex = 7;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = false;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cmb_Opcion);
            this.panel8.Controls.Add(this.cmb_Modulo);
            this.panel8.Controls.Add(this.cmb_Perfil);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(172, 149);
            this.panel8.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_Mensaje);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 46);
            this.panel7.TabIndex = 2;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mensaje.Location = new System.Drawing.Point(12, 8);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(50, 20);
            this.lbl_Mensaje.TabIndex = 2;
            this.lbl_Mensaje.Text = "label1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Brown;
            this.panel6.Controls.Add(this.lbl_Cancelar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(172, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 380);
            this.panel6.TabIndex = 1;
            // 
            // lbl_Cancelar
            // 
            this.lbl_Cancelar.AutoSize = true;
            this.lbl_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cancelar.ForeColor = System.Drawing.Color.White;
            this.lbl_Cancelar.Location = new System.Drawing.Point(-1, 6);
            this.lbl_Cancelar.Name = "lbl_Cancelar";
            this.lbl_Cancelar.Size = new System.Drawing.Size(15, 15);
            this.lbl_Cancelar.TabIndex = 4;
            this.lbl_Cancelar.Text = "X";
            this.lbl_Cancelar.Click += new System.EventHandler(this.lbl_Cancelar_Click);
            // 
            // UC_Sistema_Opciones_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Actualizar);
            this.Name = "UC_Sistema_Opciones_Perfil";
            this.Size = new System.Drawing.Size(626, 380);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Perfil_Opciones)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Actualizar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

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
