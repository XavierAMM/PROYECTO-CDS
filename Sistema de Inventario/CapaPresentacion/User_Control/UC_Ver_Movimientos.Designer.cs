namespace CapaPresentacion.User_Control
{
    partial class UC_Ver_Movimientos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_Inventario = new System.Windows.Forms.ComboBox();
            this.cmb_Bodega = new System.Windows.Forms.ComboBox();
            this.pnl_Filtro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Fecha_Max = new System.Windows.Forms.DateTimePicker();
            this.date_Fecha_Min = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dgv_Transacciones = new System.Windows.Forms.DataGridView();
            this.pnl_Tabla = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transacciones)).BeginInit();
            this.pnl_Tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmb_Inventario);
            this.panel1.Controls.Add(this.cmb_Bodega);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 37);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.ico_inventario;
            this.pictureBox2.Location = new System.Drawing.Point(318, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ico_bodega;
            this.pictureBox1.Location = new System.Drawing.Point(107, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_Inventario
            // 
            this.cmb_Inventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Inventario.Enabled = false;
            this.cmb_Inventario.FormattingEnabled = true;
            this.cmb_Inventario.Location = new System.Drawing.Point(347, 7);
            this.cmb_Inventario.Name = "cmb_Inventario";
            this.cmb_Inventario.Size = new System.Drawing.Size(154, 23);
            this.cmb_Inventario.TabIndex = 1;
            this.cmb_Inventario.SelectedIndexChanged += new System.EventHandler(this.cmb_Inventario_SelectedIndexChanged);
            // 
            // cmb_Bodega
            // 
            this.cmb_Bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bodega.FormattingEnabled = true;
            this.cmb_Bodega.Location = new System.Drawing.Point(136, 7);
            this.cmb_Bodega.Name = "cmb_Bodega";
            this.cmb_Bodega.Size = new System.Drawing.Size(154, 23);
            this.cmb_Bodega.TabIndex = 0;
            this.cmb_Bodega.SelectedIndexChanged += new System.EventHandler(this.cmb_Bodega_SelectedIndexChanged);
            // 
            // pnl_Filtro
            // 
            this.pnl_Filtro.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Filtro.Controls.Add(this.label2);
            this.pnl_Filtro.Controls.Add(this.date_Fecha_Max);
            this.pnl_Filtro.Controls.Add(this.date_Fecha_Min);
            this.pnl_Filtro.Controls.Add(this.label1);
            this.pnl_Filtro.Controls.Add(this.pictureBox4);
            this.pnl_Filtro.Controls.Add(this.txt_Buscar);
            this.pnl_Filtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Filtro.Location = new System.Drawing.Point(0, 37);
            this.pnl_Filtro.Name = "pnl_Filtro";
            this.pnl_Filtro.Size = new System.Drawing.Size(617, 29);
            this.pnl_Filtro.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "hasta";
            // 
            // date_Fecha_Max
            // 
            this.date_Fecha_Max.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Fecha_Max.Location = new System.Drawing.Point(488, 2);
            this.date_Fecha_Max.Name = "date_Fecha_Max";
            this.date_Fecha_Max.Size = new System.Drawing.Size(112, 23);
            this.date_Fecha_Max.TabIndex = 9;
            this.date_Fecha_Max.Value = new System.DateTime(2023, 8, 20, 0, 0, 0, 0);
            this.date_Fecha_Max.ValueChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // date_Fecha_Min
            // 
            this.date_Fecha_Min.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Fecha_Min.Location = new System.Drawing.Point(336, 2);
            this.date_Fecha_Min.Name = "date_Fecha_Min";
            this.date_Fecha_Min.Size = new System.Drawing.Size(112, 23);
            this.date_Fecha_Min.TabIndex = 8;
            this.date_Fecha_Min.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date_Fecha_Min.ValueChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "desde";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.ico_search;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(27, 3);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.PlaceholderText = "Buscar por nombre, categoria, proveedor";
            this.txt_Buscar.Size = new System.Drawing.Size(262, 23);
            this.txt_Buscar.TabIndex = 3;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dgv_Transacciones
            // 
            this.dgv_Transacciones.AllowUserToAddRows = false;
            this.dgv_Transacciones.AllowUserToDeleteRows = false;
            this.dgv_Transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transacciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Transacciones.Location = new System.Drawing.Point(0, 0);
            this.dgv_Transacciones.MultiSelect = false;
            this.dgv_Transacciones.Name = "dgv_Transacciones";
            this.dgv_Transacciones.ReadOnly = true;
            this.dgv_Transacciones.RowTemplate.Height = 25;
            this.dgv_Transacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Transacciones.Size = new System.Drawing.Size(617, 368);
            this.dgv_Transacciones.TabIndex = 11;
            // 
            // pnl_Tabla
            // 
            this.pnl_Tabla.Controls.Add(this.dgv_Transacciones);
            this.pnl_Tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tabla.Location = new System.Drawing.Point(0, 66);
            this.pnl_Tabla.Name = "pnl_Tabla";
            this.pnl_Tabla.Size = new System.Drawing.Size(617, 368);
            this.pnl_Tabla.TabIndex = 12;
            // 
            // UC_Ver_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Tabla);
            this.Controls.Add(this.pnl_Filtro);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Ver_Movimientos";
            this.Size = new System.Drawing.Size(617, 434);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Filtro.ResumeLayout(false);
            this.pnl_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transacciones)).EndInit();
            this.pnl_Tabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cmb_Inventario;
        private ComboBox cmb_Bodega;
        private Panel pnl_Filtro;
        private Label label1;
        private PictureBox pictureBox4;
        private TextBox txt_Buscar;
        private Label label2;
        private DateTimePicker date_Fecha_Max;
        private DateTimePicker date_Fecha_Min;
        private DataGridView dgv_Transacciones;
        private Panel pnl_Tabla;
    }
}
