namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	partial class UC_Sistema_Opciones
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
			panel9 = new Panel();
			btn_Aceptar = new Button();
			panel8 = new Panel();
			txt_Orden = new TextBox();
			label1 = new Label();
			txt_Descripcion = new TextBox();
			cmb_Modulos = new ComboBox();
			txt_Objeto = new TextBox();
			txt_Nombre = new TextBox();
			panel7 = new Panel();
			lbl_Mensaje = new Label();
			panel6 = new Panel();
			lbl_Cancelar = new Label();
			panel2 = new Panel();
			panel5 = new Panel();
			dgv_Opciones = new DataGridView();
			panel4 = new Panel();
			btn_Inactivar_Activar = new Button();
			btn_Editar = new Button();
			btn_Nuevo = new Button();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			txt_Filtro_Nombre = new TextBox();
			chb_Inactivos = new CheckBox();
			pnl_Actualizar.SuspendLayout();
			panel9.SuspendLayout();
			panel8.SuspendLayout();
			panel7.SuspendLayout();
			panel6.SuspendLayout();
			panel2.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_Opciones).BeginInit();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
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
			panel9.Controls.Add(btn_Aceptar);
			panel9.Dock = DockStyle.Top;
			panel9.Location = new Point(0, 316);
			panel9.Name = "panel9";
			panel9.Size = new Size(172, 48);
			panel9.TabIndex = 3;
			// 
			// btn_Aceptar
			// 
			btn_Aceptar.BackColor = SystemColors.Control;
			btn_Aceptar.ForeColor = Color.Black;
			btn_Aceptar.Location = new Point(34, 8);
			btn_Aceptar.Name = "btn_Aceptar";
			btn_Aceptar.Size = new Size(97, 33);
			btn_Aceptar.TabIndex = 7;
			btn_Aceptar.Text = "Aceptar";
			btn_Aceptar.UseVisualStyleBackColor = false;
			btn_Aceptar.Click += btn_Aceptar_Click;
			// 
			// panel8
			// 
			panel8.Controls.Add(txt_Orden);
			panel8.Controls.Add(label1);
			panel8.Controls.Add(txt_Descripcion);
			panel8.Controls.Add(cmb_Modulos);
			panel8.Controls.Add(txt_Objeto);
			panel8.Controls.Add(txt_Nombre);
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 46);
			panel8.Name = "panel8";
			panel8.Size = new Size(172, 270);
			panel8.TabIndex = 2;
			// 
			// txt_Orden
			// 
			txt_Orden.Location = new Point(60, 232);
			txt_Orden.Name = "txt_Orden";
			txt_Orden.PlaceholderText = "Orden";
			txt_Orden.Size = new Size(103, 23);
			txt_Orden.TabIndex = 6;
			txt_Orden.KeyPress += txt_Orden_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 235);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 7;
			label1.Text = "Orden:";
			// 
			// txt_Descripcion
			// 
			txt_Descripcion.Location = new Point(10, 124);
			txt_Descripcion.Multiline = true;
			txt_Descripcion.Name = "txt_Descripcion";
			txt_Descripcion.PlaceholderText = "Descripción de la opción";
			txt_Descripcion.Size = new Size(153, 97);
			txt_Descripcion.TabIndex = 3;
			// 
			// cmb_Modulos
			// 
			cmb_Modulos.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Modulos.FormattingEnabled = true;
			cmb_Modulos.Location = new Point(9, 90);
			cmb_Modulos.Name = "cmb_Modulos";
			cmb_Modulos.Size = new Size(154, 23);
			cmb_Modulos.TabIndex = 2;
			cmb_Modulos.SelectedIndexChanged += cmb_Modulos_SelectedIndexChanged;
			// 
			// txt_Objeto
			// 
			txt_Objeto.Location = new Point(9, 51);
			txt_Objeto.Name = "txt_Objeto";
			txt_Objeto.PlaceholderText = "Nombre de Objeto";
			txt_Objeto.Size = new Size(154, 23);
			txt_Objeto.TabIndex = 1;
			txt_Objeto.KeyPress += txt_Objeto_KeyPress;
			// 
			// txt_Nombre
			// 
			txt_Nombre.Location = new Point(9, 16);
			txt_Nombre.Name = "txt_Nombre";
			txt_Nombre.PlaceholderText = "Nombre de la Opción";
			txt_Nombre.Size = new Size(154, 23);
			txt_Nombre.TabIndex = 0;
			// 
			// panel7
			// 
			panel7.Controls.Add(lbl_Mensaje);
			panel7.Dock = DockStyle.Top;
			panel7.Location = new Point(0, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(172, 46);
			panel7.TabIndex = 1;
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
			panel6.TabIndex = 0;
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
			// panel2
			// 
			panel2.Controls.Add(panel5);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(184, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(442, 380);
			panel2.TabIndex = 1;
			// 
			// panel5
			// 
			panel5.Controls.Add(dgv_Opciones);
			panel5.Dock = DockStyle.Fill;
			panel5.Location = new Point(0, 28);
			panel5.Name = "panel5";
			panel5.Size = new Size(442, 308);
			panel5.TabIndex = 2;
			// 
			// dgv_Opciones
			// 
			dgv_Opciones.AllowUserToAddRows = false;
			dgv_Opciones.AllowUserToDeleteRows = false;
			dgv_Opciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Opciones.Dock = DockStyle.Fill;
			dgv_Opciones.Location = new Point(0, 0);
			dgv_Opciones.MultiSelect = false;
			dgv_Opciones.Name = "dgv_Opciones";
			dgv_Opciones.ReadOnly = true;
			dgv_Opciones.RowTemplate.Height = 25;
			dgv_Opciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Opciones.Size = new Size(442, 308);
			dgv_Opciones.TabIndex = 1;
			dgv_Opciones.CellClick += dgv_Opciones_CellClick;
			// 
			// panel4
			// 
			panel4.Controls.Add(btn_Inactivar_Activar);
			panel4.Controls.Add(btn_Editar);
			panel4.Controls.Add(btn_Nuevo);
			panel4.Dock = DockStyle.Bottom;
			panel4.Location = new Point(0, 336);
			panel4.Name = "panel4";
			panel4.Size = new Size(442, 44);
			panel4.TabIndex = 1;
			// 
			// btn_Inactivar_Activar
			// 
			btn_Inactivar_Activar.BackColor = Color.Red;
			btn_Inactivar_Activar.ForeColor = Color.White;
			btn_Inactivar_Activar.Location = new Point(212, 3);
			btn_Inactivar_Activar.Name = "btn_Inactivar_Activar";
			btn_Inactivar_Activar.Size = new Size(97, 33);
			btn_Inactivar_Activar.TabIndex = 5;
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
			btn_Editar.TabIndex = 4;
			btn_Editar.Text = "Editar";
			btn_Editar.UseVisualStyleBackColor = false;
			btn_Editar.Click += btn_Editar_Click;
			// 
			// btn_Nuevo
			// 
			btn_Nuevo.BackColor = Color.Green;
			btn_Nuevo.ForeColor = Color.White;
			btn_Nuevo.Location = new Point(6, 3);
			btn_Nuevo.Name = "btn_Nuevo";
			btn_Nuevo.Size = new Size(97, 33);
			btn_Nuevo.TabIndex = 2;
			btn_Nuevo.Text = "Nuevo";
			btn_Nuevo.UseVisualStyleBackColor = false;
			btn_Nuevo.Click += btn_Nuevo_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(pictureBox1);
			panel3.Controls.Add(txt_Filtro_Nombre);
			panel3.Controls.Add(chb_Inactivos);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(442, 28);
			panel3.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.ico_search;
			pictureBox1.Location = new Point(145, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(20, 20);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// txt_Filtro_Nombre
			// 
			txt_Filtro_Nombre.Location = new Point(165, 3);
			txt_Filtro_Nombre.Name = "txt_Filtro_Nombre";
			txt_Filtro_Nombre.PlaceholderText = "Buscar por nombre, descripción, módulo";
			txt_Filtro_Nombre.Size = new Size(225, 23);
			txt_Filtro_Nombre.TabIndex = 5;
			txt_Filtro_Nombre.TextChanged += txt_Filtro_Nombre_TextChanged;
			// 
			// chb_Inactivos
			// 
			chb_Inactivos.AutoSize = true;
			chb_Inactivos.Location = new Point(6, 6);
			chb_Inactivos.Name = "chb_Inactivos";
			chb_Inactivos.Size = new Size(117, 19);
			chb_Inactivos.TabIndex = 3;
			chb_Inactivos.Text = "Mostrar Inactivos";
			chb_Inactivos.UseVisualStyleBackColor = true;
			chb_Inactivos.CheckedChanged += chb_Inactivos_CheckedChanged;
			// 
			// UC_Sistema_Opciones
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel2);
			Controls.Add(pnl_Actualizar);
			Name = "UC_Sistema_Opciones";
			Size = new Size(626, 380);
			pnl_Actualizar.ResumeLayout(false);
			panel9.ResumeLayout(false);
			panel8.ResumeLayout(false);
			panel8.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel2.ResumeLayout(false);
			panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_Opciones).EndInit();
			panel4.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnl_Actualizar;
		private Panel panel2;
		private Panel panel9;
		private Panel panel8;
		private Panel panel7;
		private Panel panel6;
		private Panel panel5;
		private Panel panel4;
		private Panel panel3;
		private Label lbl_Cancelar;
		private DataGridView dgv_Opciones;
		private CheckBox chb_Inactivos;
		private PictureBox pictureBox1;
		private TextBox txt_Filtro_Nombre;
		private Label lbl_Mensaje;
		private Button btn_Aceptar;
		private Button btn_Nuevo;
		private Button btn_Editar;
		private Button btn_Inactivar_Activar;
		private TextBox txt_Nombre;
		private TextBox txt_Objeto;
		private ComboBox cmb_Modulos;
		private TextBox txt_Descripcion;
		private TextBox txt_Orden;
		private Label label1;
	}
}
