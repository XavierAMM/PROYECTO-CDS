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
            this.dgv_Modulos = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.chb_Inactivos = new System.Windows.Forms.CheckBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Inactivar_Activar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Filtro_Nombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Actualizar = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.pnl_Nuevo = new System.Windows.Forms.Panel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            this.txt_Objeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Cancelar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_Actualizar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnl_Fondo.SuspendLayout();
            this.pnl_Nuevo.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Modulos
            // 
            this.dgv_Modulos.AllowUserToAddRows = false;
            this.dgv_Modulos.AllowUserToDeleteRows = false;
            this.dgv_Modulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Modulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Modulos.Location = new System.Drawing.Point(0, 28);
            this.dgv_Modulos.MultiSelect = false;
            this.dgv_Modulos.Name = "dgv_Modulos";
            this.dgv_Modulos.ReadOnly = true;
            this.dgv_Modulos.RowTemplate.Height = 25;
            this.dgv_Modulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Modulos.Size = new System.Drawing.Size(442, 312);
            this.dgv_Modulos.TabIndex = 0;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnl_Actualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 380);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Modulos);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(184, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 380);
            this.panel4.TabIndex = 6;
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
            this.panel5.TabIndex = 4;
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
            this.txt_Filtro_Nombre.PlaceholderText = "Buscar por nombre";
            this.txt_Filtro_Nombre.Size = new System.Drawing.Size(145, 23);
            this.txt_Filtro_Nombre.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Nuevo);
            this.panel2.Controls.Add(this.btn_Inactivar_Activar);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 40);
            this.panel2.TabIndex = 3;
            // 
            // pnl_Actualizar
            // 
            this.pnl_Actualizar.Controls.Add(this.panel8);
            this.pnl_Actualizar.Controls.Add(this.pnl_Fondo);
            this.pnl_Actualizar.Controls.Add(this.panel6);
            this.pnl_Actualizar.Controls.Add(this.panel3);
            this.pnl_Actualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Actualizar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Actualizar.Name = "pnl_Actualizar";
            this.pnl_Actualizar.Size = new System.Drawing.Size(184, 380);
            this.pnl_Actualizar.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Aceptar);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 227);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(172, 53);
            this.panel8.TabIndex = 9;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Aceptar.ForeColor = System.Drawing.Color.Black;
            this.btn_Aceptar.Location = new System.Drawing.Point(34, 8);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(97, 33);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.AutoScroll = true;
            this.pnl_Fondo.Controls.Add(this.pnl_Nuevo);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 46);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(172, 181);
            this.pnl_Fondo.TabIndex = 8;
            // 
            // pnl_Nuevo
            // 
            this.pnl_Nuevo.Controls.Add(this.txt_Nombre);
            this.pnl_Nuevo.Controls.Add(this.txt_Orden);
            this.pnl_Nuevo.Controls.Add(this.txt_Objeto);
            this.pnl_Nuevo.Controls.Add(this.label1);
            this.pnl_Nuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Nuevo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Nuevo.Name = "pnl_Nuevo";
            this.pnl_Nuevo.Size = new System.Drawing.Size(172, 181);
            this.pnl_Nuevo.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(8, 15);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre del Módulo";
            this.txt_Nombre.Size = new System.Drawing.Size(154, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Orden
            // 
            this.txt_Orden.Location = new System.Drawing.Point(59, 82);
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.PlaceholderText = "Orden";
            this.txt_Orden.Size = new System.Drawing.Size(103, 23);
            this.txt_Orden.TabIndex = 4;
            // 
            // txt_Objeto
            // 
            this.txt_Objeto.Location = new System.Drawing.Point(8, 47);
            this.txt_Objeto.Name = "txt_Objeto";
            this.txt_Objeto.PlaceholderText = "Nombre del Objeto";
            this.txt_Objeto.Size = new System.Drawing.Size(154, 23);
            this.txt_Objeto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Orden:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_Mensaje);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 46);
            this.panel6.TabIndex = 7;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mensaje.Location = new System.Drawing.Point(12, 8);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(50, 20);
            this.lbl_Mensaje.TabIndex = 1;
            this.lbl_Mensaje.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.lbl_Cancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(172, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 380);
            this.panel3.TabIndex = 2;
            // 
            // lbl_Cancelar
            // 
            this.lbl_Cancelar.AutoSize = true;
            this.lbl_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cancelar.ForeColor = System.Drawing.Color.White;
            this.lbl_Cancelar.Location = new System.Drawing.Point(-1, 6);
            this.lbl_Cancelar.Name = "lbl_Cancelar";
            this.lbl_Cancelar.Size = new System.Drawing.Size(15, 15);
            this.lbl_Cancelar.TabIndex = 3;
            this.lbl_Cancelar.Text = "X";
            // 
            // UC_Sistema_Modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Sistema_Modulo";
            this.Size = new System.Drawing.Size(626, 380);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_Actualizar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Nuevo.ResumeLayout(false);
            this.pnl_Nuevo.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dgv_Modulos;
		private Button btn_Nuevo;
		private CheckBox chb_Inactivos;
		private Button btn_Editar;
		private Button btn_Inactivar_Activar;
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
		private Panel pnl_Nuevo;
		private Panel panel6;
		private TextBox txt_Filtro_Nombre;
		private PictureBox pictureBox1;
	}
}
