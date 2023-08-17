namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	partial class UC_Sistema_Modulo
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
			dgv_Modulos = new DataGridView();
			btn_Nuevo = new Button();
			chb_Inactivos = new CheckBox();
			btn_Editar = new Button();
			btn_Eliminar = new Button();
			panel1 = new Panel();
			panel4 = new Panel();
			panel5 = new Panel();
			txt_Filtro_Nombre = new TextBox();
			panel2 = new Panel();
			pnl_Actualizar = new Panel();
			panel8 = new Panel();
			btn_Aceptar = new Button();
			pnl_Fondo = new Panel();
			pnl_Nuevo = new Panel();
			cmb_Estado = new ComboBox();
			txt_Nombre = new TextBox();
			txt_Orden = new TextBox();
			txt_Objeto = new TextBox();
			label1 = new Label();
			panel6 = new Panel();
			lbl_Mensaje = new Label();
			panel3 = new Panel();
			lbl_Cancelar = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)dgv_Modulos).BeginInit();
			panel1.SuspendLayout();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			panel2.SuspendLayout();
			pnl_Actualizar.SuspendLayout();
			panel8.SuspendLayout();
			pnl_Fondo.SuspendLayout();
			pnl_Nuevo.SuspendLayout();
			panel6.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dgv_Modulos
			// 
			dgv_Modulos.AllowUserToAddRows = false;
			dgv_Modulos.AllowUserToDeleteRows = false;
			dgv_Modulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Modulos.Dock = DockStyle.Fill;
			dgv_Modulos.Location = new Point(0, 28);
			dgv_Modulos.MultiSelect = false;
			dgv_Modulos.Name = "dgv_Modulos";
			dgv_Modulos.ReadOnly = true;
			dgv_Modulos.RowTemplate.Height = 25;
			dgv_Modulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Modulos.Size = new Size(442, 312);
			dgv_Modulos.TabIndex = 0;
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
			// btn_Eliminar
			// 
			btn_Eliminar.BackColor = Color.Red;
			btn_Eliminar.ForeColor = Color.White;
			btn_Eliminar.Location = new Point(212, 3);
			btn_Eliminar.Name = "btn_Eliminar";
			btn_Eliminar.Size = new Size(97, 33);
			btn_Eliminar.TabIndex = 4;
			btn_Eliminar.Text = "Eliminar";
			btn_Eliminar.UseVisualStyleBackColor = false;
			btn_Eliminar.Click += btn_Eliminar_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(panel4);
			panel1.Controls.Add(pnl_Actualizar);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(626, 380);
			panel1.TabIndex = 5;
			// 
			// panel4
			// 
			panel4.Controls.Add(dgv_Modulos);
			panel4.Controls.Add(panel5);
			panel4.Controls.Add(panel2);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(184, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(442, 380);
			panel4.TabIndex = 6;
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
			panel5.TabIndex = 4;
			// 
			// txt_Filtro_Nombre
			// 
			txt_Filtro_Nombre.Location = new Point(165, 3);
			txt_Filtro_Nombre.Name = "txt_Filtro_Nombre";
			txt_Filtro_Nombre.PlaceholderText = "Buscar por nombre";
			txt_Filtro_Nombre.Size = new Size(145, 23);
			txt_Filtro_Nombre.TabIndex = 3;
			txt_Filtro_Nombre.TextChanged += txt_Filtro_Nombre_TextChanged;
			// 
			// panel2
			// 
			panel2.Controls.Add(btn_Nuevo);
			panel2.Controls.Add(btn_Eliminar);
			panel2.Controls.Add(btn_Editar);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 340);
			panel2.Name = "panel2";
			panel2.Size = new Size(442, 40);
			panel2.TabIndex = 3;
			// 
			// pnl_Actualizar
			// 
			pnl_Actualizar.Controls.Add(panel8);
			pnl_Actualizar.Controls.Add(pnl_Fondo);
			pnl_Actualizar.Controls.Add(panel6);
			pnl_Actualizar.Controls.Add(panel3);
			pnl_Actualizar.Dock = DockStyle.Left;
			pnl_Actualizar.Location = new Point(0, 0);
			pnl_Actualizar.Name = "pnl_Actualizar";
			pnl_Actualizar.Size = new Size(184, 380);
			pnl_Actualizar.TabIndex = 7;
			// 
			// panel8
			// 
			panel8.Controls.Add(btn_Aceptar);
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 227);
			panel8.Name = "panel8";
			panel8.Size = new Size(172, 53);
			panel8.TabIndex = 9;
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
			// pnl_Fondo
			// 
			pnl_Fondo.AutoScroll = true;
			pnl_Fondo.Controls.Add(pnl_Nuevo);
			pnl_Fondo.Dock = DockStyle.Top;
			pnl_Fondo.Location = new Point(0, 46);
			pnl_Fondo.Name = "pnl_Fondo";
			pnl_Fondo.Size = new Size(172, 181);
			pnl_Fondo.TabIndex = 8;
			// 
			// pnl_Nuevo
			// 
			pnl_Nuevo.Controls.Add(cmb_Estado);
			pnl_Nuevo.Controls.Add(txt_Nombre);
			pnl_Nuevo.Controls.Add(txt_Orden);
			pnl_Nuevo.Controls.Add(txt_Objeto);
			pnl_Nuevo.Controls.Add(label1);
			pnl_Nuevo.Dock = DockStyle.Top;
			pnl_Nuevo.Location = new Point(0, 0);
			pnl_Nuevo.Name = "pnl_Nuevo";
			pnl_Nuevo.Size = new Size(172, 181);
			pnl_Nuevo.TabIndex = 6;
			// 
			// cmb_Estado
			// 
			cmb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Estado.FormattingEnabled = true;
			cmb_Estado.Items.AddRange(new object[] { "A", "I" });
			cmb_Estado.Location = new Point(8, 122);
			cmb_Estado.Name = "cmb_Estado";
			cmb_Estado.Size = new Size(152, 23);
			cmb_Estado.TabIndex = 6;
			// 
			// txt_Nombre
			// 
			txt_Nombre.Location = new Point(8, 15);
			txt_Nombre.Name = "txt_Nombre";
			txt_Nombre.PlaceholderText = "Nombre del Módulo";
			txt_Nombre.Size = new Size(154, 23);
			txt_Nombre.TabIndex = 0;
			// 
			// txt_Orden
			// 
			txt_Orden.Location = new Point(59, 82);
			txt_Orden.Name = "txt_Orden";
			txt_Orden.PlaceholderText = "Orden";
			txt_Orden.Size = new Size(103, 23);
			txt_Orden.TabIndex = 4;
			txt_Orden.KeyPress += txt_Orden_KeyPress;
			// 
			// txt_Objeto
			// 
			txt_Objeto.Location = new Point(8, 47);
			txt_Objeto.Name = "txt_Objeto";
			txt_Objeto.PlaceholderText = "Nombre del Objeto";
			txt_Objeto.Size = new Size(154, 23);
			txt_Objeto.TabIndex = 3;
			txt_Objeto.KeyPress += txt_Objeto_Nuevo_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(8, 85);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 5;
			label1.Text = "Orden:";
			// 
			// panel6
			// 
			panel6.Controls.Add(lbl_Mensaje);
			panel6.Dock = DockStyle.Top;
			panel6.Location = new Point(0, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(172, 46);
			panel6.TabIndex = 7;
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
			panel3.TabIndex = 2;
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
			// UC_Sistema_Modulo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel1);
			Name = "UC_Sistema_Modulo";
			Size = new Size(626, 380);
			((System.ComponentModel.ISupportInitialize)dgv_Modulos).EndInit();
			panel1.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel2.ResumeLayout(false);
			pnl_Actualizar.ResumeLayout(false);
			panel8.ResumeLayout(false);
			pnl_Fondo.ResumeLayout(false);
			pnl_Nuevo.ResumeLayout(false);
			pnl_Nuevo.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgv_Modulos;
		private Button btn_Nuevo;
		private CheckBox chb_Inactivos;
		private Button btn_Editar;
		private Button btn_Eliminar;
		private Panel panel1;
		private Panel panel4;
		private Panel panel5;
		private Panel panel2;
		private Panel pnl_Actualizar;
		private TextBox txt_Nombre;
		private Label lbl_Mensaje;
		private Panel panel3;
		private Label lbl_Cancelar;
		private TextBox txt_Orden;
		private TextBox txt_Objeto;
		private Button btn_Aceptar;
		private Label label1;
		private Panel panel8;
		private Panel pnl_Fondo;
		private ComboBox cmb_Estado;
		private Panel pnl_Nuevo;
		private Panel panel6;
		private TextBox txt_Filtro_Nombre;
		private PictureBox pictureBox1;
	}
}
