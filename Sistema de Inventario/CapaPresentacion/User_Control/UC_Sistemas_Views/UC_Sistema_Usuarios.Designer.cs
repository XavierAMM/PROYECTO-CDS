namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	partial class UC_Sistema_Usuarios
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Filtro_Nombre = new System.Windows.Forms.TextBox();
            this.chb_Inactivos = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Inactivar_Activar = new System.Windows.Forms.Button();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txt_Filtro_Nombre);
            this.panel5.Controls.Add(this.chb_Inactivos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(626, 28);
            this.panel5.TabIndex = 7;
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
            this.txt_Filtro_Nombre.Size = new System.Drawing.Size(232, 23);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Inactivar_Activar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 40);
            this.panel4.TabIndex = 8;
            // 
            // btn_Inactivar_Activar
            // 
            this.btn_Inactivar_Activar.BackColor = System.Drawing.Color.Red;
            this.btn_Inactivar_Activar.ForeColor = System.Drawing.Color.White;
            this.btn_Inactivar_Activar.Location = new System.Drawing.Point(259, 4);
            this.btn_Inactivar_Activar.Name = "btn_Inactivar_Activar";
            this.btn_Inactivar_Activar.Size = new System.Drawing.Size(97, 33);
            this.btn_Inactivar_Activar.TabIndex = 4;
            this.btn_Inactivar_Activar.Text = "Inactivar";
            this.btn_Inactivar_Activar.UseVisualStyleBackColor = false;
            this.btn_Inactivar_Activar.Click += new System.EventHandler(this.btn_Inactivar_Activar_Click);
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(7, 34);
            this.dgv_Usuarios.MultiSelect = false;
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowTemplate.Height = 25;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(604, 286);
            this.dgv_Usuarios.TabIndex = 9;
            this.dgv_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuarios_CellClick);
            // 
            // UC_Sistema_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "UC_Sistema_Usuarios";
            this.Size = new System.Drawing.Size(626, 380);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Panel panel5;
		private PictureBox pictureBox1;
		private TextBox txt_Filtro_Nombre;
		private CheckBox chb_Inactivos;
		private Panel panel4;
		private Button btn_Inactivar_Activar;
		private DataGridView dgv_Usuarios;
	}
}
