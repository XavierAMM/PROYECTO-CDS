namespace CapaPresentacion.User_Control
{
	partial class UC_Transacciones
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
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl_Tabla_Productos = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_Warning = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_Producto = new System.Windows.Forms.Panel();
            this.pic_Warning_Cantidad = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Tipo_Unidad = new System.Windows.Forms.Label();
            this.btn_Quitar = new System.Windows.Forms.PictureBox();
            this.btn_Agregar = new System.Windows.Forms.PictureBox();
            this.txt_Ingresar_Cant = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Cant_Max = new System.Windows.Forms.TextBox();
            this.txt_Cant_Min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgv_Temp_Transacciones = new System.Windows.Forms.DataGridView();
            this.pnl_Temp_Transaccion = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl_Tabla_Productos.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_Warning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning_Cantidad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Temp_Transacciones)).BeginInit();
            this.pnl_Temp_Transaccion.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            // dgv_Productos
            // 
            this.dgv_Productos.AllowUserToAddRows = false;
            this.dgv_Productos.AllowUserToDeleteRows = false;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Productos.Location = new System.Drawing.Point(0, 0);
            this.dgv_Productos.MultiSelect = false;
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.RowTemplate.Height = 25;
            this.dgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Productos.Size = new System.Drawing.Size(617, 142);
            this.dgv_Productos.TabIndex = 2;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(180, 2);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.PlaceholderText = "Buscar por nombre, categoria, proveedor";
            this.txt_Buscar.Size = new System.Drawing.Size(250, 23);
            this.txt_Buscar.TabIndex = 3;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.ico_search;
            this.pictureBox4.Location = new System.Drawing.Point(156, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pnl_Tabla_Productos
            // 
            this.pnl_Tabla_Productos.Controls.Add(this.panel);
            this.pnl_Tabla_Productos.Controls.Add(this.panel4);
            this.pnl_Tabla_Productos.Controls.Add(this.pnl_Warning);
            this.pnl_Tabla_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tabla_Productos.Enabled = false;
            this.pnl_Tabla_Productos.Location = new System.Drawing.Point(0, 37);
            this.pnl_Tabla_Productos.Name = "pnl_Tabla_Productos";
            this.pnl_Tabla_Productos.Size = new System.Drawing.Size(617, 187);
            this.pnl_Tabla_Productos.TabIndex = 6;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.dgv_Productos);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(617, 142);
            this.panel.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.txt_Buscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 29);
            this.panel4.TabIndex = 9;
            // 
            // pnl_Warning
            // 
            this.pnl_Warning.Controls.Add(this.label5);
            this.pnl_Warning.Controls.Add(this.pictureBox3);
            this.pnl_Warning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Warning.Location = new System.Drawing.Point(0, 171);
            this.pnl_Warning.Name = "pnl_Warning";
            this.pnl_Warning.Size = new System.Drawing.Size(617, 16);
            this.pnl_Warning.TabIndex = 8;
            this.pnl_Warning.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(516, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "La tabla tiene producto(s) cuya(s) cantidad(es) superan o son inferiores a los lí" +
    "mites establecidos.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.ico_warning;
            this.pictureBox3.Location = new System.Drawing.Point(14, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pnl_Producto
            // 
            this.pnl_Producto.Controls.Add(this.pic_Warning_Cantidad);
            this.pnl_Producto.Controls.Add(this.panel2);
            this.pnl_Producto.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Producto.Enabled = false;
            this.pnl_Producto.Location = new System.Drawing.Point(0, 224);
            this.pnl_Producto.Name = "pnl_Producto";
            this.pnl_Producto.Size = new System.Drawing.Size(617, 210);
            this.pnl_Producto.TabIndex = 7;
            // 
            // pic_Warning_Cantidad
            // 
            this.pic_Warning_Cantidad.Image = global::CapaPresentacion.Properties.Resources.ico_warning;
            this.pic_Warning_Cantidad.Location = new System.Drawing.Point(379, 12);
            this.pic_Warning_Cantidad.Name = "pic_Warning_Cantidad";
            this.pic_Warning_Cantidad.Size = new System.Drawing.Size(20, 20);
            this.pic_Warning_Cantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning_Cantidad.TabIndex = 8;
            this.pic_Warning_Cantidad.TabStop = false;
            this.pic_Warning_Cantidad.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lbl_Tipo_Unidad);
            this.panel2.Controls.Add(this.btn_Quitar);
            this.panel2.Controls.Add(this.btn_Agregar);
            this.panel2.Controls.Add(this.txt_Ingresar_Cant);
            this.panel2.Location = new System.Drawing.Point(400, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 90);
            this.panel2.TabIndex = 4;
            // 
            // lbl_Tipo_Unidad
            // 
            this.lbl_Tipo_Unidad.AutoSize = true;
            this.lbl_Tipo_Unidad.Location = new System.Drawing.Point(51, 3);
            this.lbl_Tipo_Unidad.MaximumSize = new System.Drawing.Size(100, 15);
            this.lbl_Tipo_Unidad.MinimumSize = new System.Drawing.Size(100, 15);
            this.lbl_Tipo_Unidad.Name = "lbl_Tipo_Unidad";
            this.lbl_Tipo_Unidad.Size = new System.Drawing.Size(100, 15);
            this.lbl_Tipo_Unidad.TabIndex = 6;
            this.lbl_Tipo_Unidad.Text = "Unidades";
            this.lbl_Tipo_Unidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Image = global::CapaPresentacion.Properties.Resources.img_minus;
            this.btn_Quitar.Location = new System.Drawing.Point(132, 51);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(35, 35);
            this.btn_Quitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Quitar.TabIndex = 5;
            this.btn_Quitar.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::CapaPresentacion.Properties.Resources.img_add;
            this.btn_Agregar.Location = new System.Drawing.Point(26, 51);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(35, 35);
            this.btn_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.TabStop = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Ingresar_Cant
            // 
            this.txt_Ingresar_Cant.Location = new System.Drawing.Point(26, 22);
            this.txt_Ingresar_Cant.Name = "txt_Ingresar_Cant";
            this.txt_Ingresar_Cant.PlaceholderText = "Ingresar cantidad";
            this.txt_Ingresar_Cant.Size = new System.Drawing.Size(141, 23);
            this.txt_Ingresar_Cant.TabIndex = 0;
            this.txt_Ingresar_Cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Ingresar_Cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ingresar_Cant_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Categoria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Proveedor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cantidad, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cant_Max, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cant_Min, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 90);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(73, 3);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(103, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad Max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad Min:";
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(73, 32);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.ReadOnly = true;
            this.txt_Categoria.Size = new System.Drawing.Size(103, 23);
            this.txt_Categoria.TabIndex = 10;
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(73, 61);
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.ReadOnly = true;
            this.txt_Proveedor.Size = new System.Drawing.Size(103, 23);
            this.txt_Proveedor.TabIndex = 11;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(272, 3);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.ReadOnly = true;
            this.txt_Cantidad.Size = new System.Drawing.Size(103, 23);
            this.txt_Cantidad.TabIndex = 14;
            // 
            // txt_Cant_Max
            // 
            this.txt_Cant_Max.Location = new System.Drawing.Point(272, 32);
            this.txt_Cant_Max.Name = "txt_Cant_Max";
            this.txt_Cant_Max.ReadOnly = true;
            this.txt_Cant_Max.Size = new System.Drawing.Size(103, 23);
            this.txt_Cant_Max.TabIndex = 15;
            // 
            // txt_Cant_Min
            // 
            this.txt_Cant_Min.Location = new System.Drawing.Point(272, 61);
            this.txt_Cant_Min.Name = "txt_Cant_Min";
            this.txt_Cant_Min.ReadOnly = true;
            this.txt_Cant_Min.Size = new System.Drawing.Size(103, 23);
            this.txt_Cant_Min.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agregados recientemente...";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.Location = new System.Drawing.Point(508, 24);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(87, 25);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Tomato;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Limpiar.Location = new System.Drawing.Point(508, 83);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(87, 25);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(508, 54);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(87, 25);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // dgv_Temp_Transacciones
            // 
            this.dgv_Temp_Transacciones.AllowUserToAddRows = false;
            this.dgv_Temp_Transacciones.AllowUserToDeleteRows = false;
            this.dgv_Temp_Transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Temp_Transacciones.Location = new System.Drawing.Point(18, 22);
            this.dgv_Temp_Transacciones.MultiSelect = false;
            this.dgv_Temp_Transacciones.Name = "dgv_Temp_Transacciones";
            this.dgv_Temp_Transacciones.ReadOnly = true;
            this.dgv_Temp_Transacciones.RowTemplate.Height = 25;
            this.dgv_Temp_Transacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Temp_Transacciones.Size = new System.Drawing.Size(471, 86);
            this.dgv_Temp_Transacciones.TabIndex = 3;
            // 
            // pnl_Temp_Transaccion
            // 
            this.pnl_Temp_Transaccion.Controls.Add(this.label4);
            this.pnl_Temp_Transaccion.Controls.Add(this.btn_Guardar);
            this.pnl_Temp_Transaccion.Controls.Add(this.dgv_Temp_Transacciones);
            this.pnl_Temp_Transaccion.Controls.Add(this.btn_Limpiar);
            this.pnl_Temp_Transaccion.Controls.Add(this.btn_Eliminar);
            this.pnl_Temp_Transaccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Temp_Transaccion.Enabled = false;
            this.pnl_Temp_Transaccion.Location = new System.Drawing.Point(0, 320);
            this.pnl_Temp_Transaccion.Name = "pnl_Temp_Transaccion";
            this.pnl_Temp_Transaccion.Size = new System.Drawing.Size(617, 114);
            this.pnl_Temp_Transaccion.TabIndex = 9;
            // 
            // UC_Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Temp_Transaccion);
            this.Controls.Add(this.pnl_Producto);
            this.Controls.Add(this.pnl_Tabla_Productos);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Transacciones";
            this.Size = new System.Drawing.Size(617, 434);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl_Tabla_Productos.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_Warning.ResumeLayout(false);
            this.pnl_Warning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_Producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning_Cantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Temp_Transacciones)).EndInit();
            this.pnl_Temp_Transaccion.ResumeLayout(false);
            this.pnl_Temp_Transaccion.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private ComboBox cmb_Inventario;
		private ComboBox cmb_Bodega;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private DataGridView dgv_Productos;
		private TextBox txt_Buscar;
		private PictureBox pictureBox4;
		private Panel pnl_Tabla_Productos;
		private Panel pnl_Producto;
		private TextBox txt_Nombre;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private DataGridView dgv_Temp_Transacciones;
		private Label label2;
		private Label label3;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox txt_Categoria;
		private TextBox txt_Proveedor;
		private TextBox txt_Cantidad;
		private TextBox txt_Cant_Max;
		private TextBox txt_Cant_Min;
		private Panel panel2;
		private PictureBox btn_Agregar;
		private TextBox txt_Ingresar_Cant;
		private Button btn_Limpiar;
		private Button btn_Eliminar;
		private PictureBox btn_Quitar;
		private Button btn_Guardar;
		private Label label4;
		private Panel pnl_Temp_Transaccion;
        private Label lbl_Tipo_Unidad;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel;
        private Panel panel4;
        private Panel pnl_Warning;
        private PictureBox pic_Warning_Cantidad;
    }
}
