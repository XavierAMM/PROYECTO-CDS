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
            this.pnl_Actualizar = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.cmb_Modulos = new System.Windows.Forms.ComboBox();
            this.txt_Objeto = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Cancelar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_Opciones = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Inactivar_Activar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Filtro_Nombre = new System.Windows.Forms.TextBox();
            this.chb_Inactivos = new System.Windows.Forms.CheckBox();
            this.pnl_Actualizar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Opciones)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel9.Controls.Add(this.btn_Aceptar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 316);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(172, 48);
            this.panel9.TabIndex = 3;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Aceptar.ForeColor = System.Drawing.Color.Black;
            this.btn_Aceptar.Location = new System.Drawing.Point(34, 8);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(97, 33);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_Orden);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txt_Descripcion);
            this.panel8.Controls.Add(this.cmb_Modulos);
            this.panel8.Controls.Add(this.txt_Objeto);
            this.panel8.Controls.Add(this.txt_Nombre);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(172, 270);
            this.panel8.TabIndex = 2;
            // 
            // txt_Orden
            // 
            this.txt_Orden.Location = new System.Drawing.Point(60, 232);
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.PlaceholderText = "Orden";
            this.txt_Orden.Size = new System.Drawing.Size(103, 23);
            this.txt_Orden.TabIndex = 6;
            this.txt_Orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Orden_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Orden:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(10, 124);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.PlaceholderText = "Descripción de la opción";
            this.txt_Descripcion.Size = new System.Drawing.Size(153, 97);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // cmb_Modulos
            // 
            this.cmb_Modulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Modulos.FormattingEnabled = true;
            this.cmb_Modulos.Location = new System.Drawing.Point(9, 90);
            this.cmb_Modulos.Name = "cmb_Modulos";
            this.cmb_Modulos.Size = new System.Drawing.Size(154, 23);
            this.cmb_Modulos.TabIndex = 2;
            this.cmb_Modulos.SelectedIndexChanged += new System.EventHandler(this.cmb_Modulos_SelectedIndexChanged);
            // 
            // txt_Objeto
            // 
            this.txt_Objeto.Location = new System.Drawing.Point(9, 51);
            this.txt_Objeto.Name = "txt_Objeto";
            this.txt_Objeto.PlaceholderText = "Nombre de Objeto";
            this.txt_Objeto.Size = new System.Drawing.Size(154, 23);
            this.txt_Objeto.TabIndex = 1;
            this.txt_Objeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Objeto_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(9, 16);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre de la Opción";
            this.txt_Nombre.Size = new System.Drawing.Size(154, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_Mensaje);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 46);
            this.panel7.TabIndex = 1;
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
            this.panel6.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 380);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_Opciones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 308);
            this.panel5.TabIndex = 2;
            // 
            // dgv_Opciones
            // 
            this.dgv_Opciones.AllowUserToAddRows = false;
            this.dgv_Opciones.AllowUserToDeleteRows = false;
            this.dgv_Opciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Opciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Opciones.Location = new System.Drawing.Point(0, 0);
            this.dgv_Opciones.MultiSelect = false;
            this.dgv_Opciones.Name = "dgv_Opciones";
            this.dgv_Opciones.ReadOnly = true;
            this.dgv_Opciones.RowTemplate.Height = 25;
            this.dgv_Opciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Opciones.Size = new System.Drawing.Size(442, 308);
            this.dgv_Opciones.TabIndex = 1;
            this.dgv_Opciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Opciones_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Inactivar_Activar);
            this.panel4.Controls.Add(this.btn_Editar);
            this.panel4.Controls.Add(this.btn_Nuevo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 44);
            this.panel4.TabIndex = 1;
            // 
            // btn_Inactivar_Activar
            // 
            this.btn_Inactivar_Activar.BackColor = System.Drawing.Color.Red;
            this.btn_Inactivar_Activar.ForeColor = System.Drawing.Color.White;
            this.btn_Inactivar_Activar.Location = new System.Drawing.Point(212, 3);
            this.btn_Inactivar_Activar.Name = "btn_Inactivar_Activar";
            this.btn_Inactivar_Activar.Size = new System.Drawing.Size(97, 33);
            this.btn_Inactivar_Activar.TabIndex = 5;
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
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.Green;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Location = new System.Drawing.Point(6, 3);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(97, 33);
            this.btn_Nuevo.TabIndex = 2;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txt_Filtro_Nombre);
            this.panel3.Controls.Add(this.chb_Inactivos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 28);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ico_search;
            this.pictureBox1.Location = new System.Drawing.Point(145, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Filtro_Nombre
            // 
            this.txt_Filtro_Nombre.Location = new System.Drawing.Point(165, 3);
            this.txt_Filtro_Nombre.Name = "txt_Filtro_Nombre";
            this.txt_Filtro_Nombre.PlaceholderText = "Buscar por nombre, descripción, módulo";
            this.txt_Filtro_Nombre.Size = new System.Drawing.Size(225, 23);
            this.txt_Filtro_Nombre.TabIndex = 5;
            this.txt_Filtro_Nombre.TextChanged += new System.EventHandler(this.txt_Filtro_Nombre_TextChanged);
            // 
            // chb_Inactivos
            // 
            this.chb_Inactivos.AutoSize = true;
            this.chb_Inactivos.Location = new System.Drawing.Point(6, 6);
            this.chb_Inactivos.Name = "chb_Inactivos";
            this.chb_Inactivos.Size = new System.Drawing.Size(117, 19);
            this.chb_Inactivos.TabIndex = 3;
            this.chb_Inactivos.Text = "Mostrar Inactivos";
            this.chb_Inactivos.UseVisualStyleBackColor = true;
            this.chb_Inactivos.CheckedChanged += new System.EventHandler(this.chb_Inactivos_CheckedChanged);
            // 
            // UC_Sistema_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Actualizar);
            this.Name = "UC_Sistema_Opciones";
            this.Size = new System.Drawing.Size(626, 380);
            this.pnl_Actualizar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Opciones)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
