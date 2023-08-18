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
			panel5 = new Panel();
			pictureBox1 = new PictureBox();
			txt_Filtro_Nombre = new TextBox();
			chb_Inactivos = new CheckBox();
			panel4 = new Panel();
			btn_Inactivar_Activar = new Button();
			dgv_Usuarios = new DataGridView();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_Usuarios).BeginInit();
			SuspendLayout();
			// 
			// panel5
			// 
			panel5.Controls.Add(pictureBox1);
			panel5.Controls.Add(txt_Filtro_Nombre);
			panel5.Controls.Add(chb_Inactivos);
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(626, 28);
			panel5.TabIndex = 7;
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
			txt_Filtro_Nombre.Size = new Size(232, 23);
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
			// 
			// panel4
			// 
			panel4.Controls.Add(btn_Inactivar_Activar);
			panel4.Dock = DockStyle.Bottom;
			panel4.Location = new Point(0, 340);
			panel4.Name = "panel4";
			panel4.Size = new Size(626, 40);
			panel4.TabIndex = 8;
			// 
			// btn_Inactivar_Activar
			// 
			btn_Inactivar_Activar.BackColor = Color.Red;
			btn_Inactivar_Activar.ForeColor = Color.White;
			btn_Inactivar_Activar.Location = new Point(259, 4);
			btn_Inactivar_Activar.Name = "btn_Inactivar_Activar";
			btn_Inactivar_Activar.Size = new Size(97, 33);
			btn_Inactivar_Activar.TabIndex = 4;
			btn_Inactivar_Activar.Text = "Inactivar";
			btn_Inactivar_Activar.UseVisualStyleBackColor = false;
			// 
			// dgv_Usuarios
			// 
			dgv_Usuarios.AllowUserToAddRows = false;
			dgv_Usuarios.AllowUserToDeleteRows = false;
			dgv_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Usuarios.Location = new Point(7, 34);
			dgv_Usuarios.MultiSelect = false;
			dgv_Usuarios.Name = "dgv_Usuarios";
			dgv_Usuarios.ReadOnly = true;
			dgv_Usuarios.RowTemplate.Height = 25;
			dgv_Usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Usuarios.Size = new Size(604, 286);
			dgv_Usuarios.TabIndex = 9;
			// 
			// UC_Sistema_Usuarios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(dgv_Usuarios);
			Controls.Add(panel4);
			Controls.Add(panel5);
			Name = "UC_Sistema_Usuarios";
			Size = new Size(626, 380);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_Usuarios).EndInit();
			ResumeLayout(false);
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
