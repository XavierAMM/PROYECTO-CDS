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
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			cmb_Inventario = new ComboBox();
			cmb_Bodega = new ComboBox();
			dgv_Productos = new DataGridView();
			txt_Buscar = new TextBox();
			pictureBox4 = new PictureBox();
			pnl_Tabla_Productos = new Panel();
			pnl_Producto = new Panel();
			btn_Limpiar = new Button();
			btn_Eliminar = new Button();
			panel2 = new Panel();
			btn_Quitar = new PictureBox();
			btn_Agregar = new PictureBox();
			txt_Ingresar_Cant = new TextBox();
			dgv_Temp_Transacciones = new DataGridView();
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			txt_Nombre = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			txt_Categoria = new TextBox();
			txt_Proveedor = new TextBox();
			txt_Cantidad = new TextBox();
			txt_Cant_Max = new TextBox();
			txt_Cant_Min = new TextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			pnl_Tabla_Productos.SuspendLayout();
			pnl_Producto.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btn_Quitar).BeginInit();
			((System.ComponentModel.ISupportInitialize)btn_Agregar).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_Temp_Transacciones).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(cmb_Inventario);
			panel1.Controls.Add(cmb_Bodega);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(617, 37);
			panel1.TabIndex = 0;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.ico_inventario;
			pictureBox2.Location = new Point(318, 7);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(23, 23);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 3;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.ico_bodega;
			pictureBox1.Location = new Point(107, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(23, 23);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// cmb_Inventario
			// 
			cmb_Inventario.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Inventario.FormattingEnabled = true;
			cmb_Inventario.Location = new Point(347, 7);
			cmb_Inventario.Name = "cmb_Inventario";
			cmb_Inventario.Size = new Size(154, 23);
			cmb_Inventario.TabIndex = 1;
			// 
			// cmb_Bodega
			// 
			cmb_Bodega.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_Bodega.FormattingEnabled = true;
			cmb_Bodega.Location = new Point(136, 7);
			cmb_Bodega.Name = "cmb_Bodega";
			cmb_Bodega.Size = new Size(154, 23);
			cmb_Bodega.TabIndex = 0;
			cmb_Bodega.Click += cmb_Bodega_Click;
			// 
			// dgv_Productos
			// 
			dgv_Productos.AllowUserToAddRows = false;
			dgv_Productos.AllowUserToDeleteRows = false;
			dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Productos.Location = new Point(14, 36);
			dgv_Productos.MultiSelect = false;
			dgv_Productos.Name = "dgv_Productos";
			dgv_Productos.ReadOnly = true;
			dgv_Productos.RowTemplate.Height = 25;
			dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Productos.Size = new Size(587, 159);
			dgv_Productos.TabIndex = 2;
			// 
			// txt_Buscar
			// 
			txt_Buscar.Location = new Point(180, 7);
			txt_Buscar.Name = "txt_Buscar";
			txt_Buscar.Size = new Size(250, 23);
			txt_Buscar.TabIndex = 3;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.ico_search;
			pictureBox4.Location = new Point(156, 7);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(23, 23);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 5;
			pictureBox4.TabStop = false;
			// 
			// pnl_Tabla_Productos
			// 
			pnl_Tabla_Productos.Controls.Add(pictureBox4);
			pnl_Tabla_Productos.Controls.Add(dgv_Productos);
			pnl_Tabla_Productos.Controls.Add(txt_Buscar);
			pnl_Tabla_Productos.Dock = DockStyle.Top;
			pnl_Tabla_Productos.Enabled = false;
			pnl_Tabla_Productos.Location = new Point(0, 37);
			pnl_Tabla_Productos.Name = "pnl_Tabla_Productos";
			pnl_Tabla_Productos.Size = new Size(617, 201);
			pnl_Tabla_Productos.TabIndex = 6;
			// 
			// pnl_Producto
			// 
			pnl_Producto.Controls.Add(btn_Limpiar);
			pnl_Producto.Controls.Add(btn_Eliminar);
			pnl_Producto.Controls.Add(panel2);
			pnl_Producto.Controls.Add(dgv_Temp_Transacciones);
			pnl_Producto.Controls.Add(tableLayoutPanel1);
			pnl_Producto.Dock = DockStyle.Fill;
			pnl_Producto.Enabled = false;
			pnl_Producto.Location = new Point(0, 238);
			pnl_Producto.Name = "pnl_Producto";
			pnl_Producto.Size = new Size(617, 196);
			pnl_Producto.TabIndex = 7;
			// 
			// btn_Limpiar
			// 
			btn_Limpiar.BackColor = Color.Tomato;
			btn_Limpiar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Limpiar.Location = new Point(514, 160);
			btn_Limpiar.Name = "btn_Limpiar";
			btn_Limpiar.Size = new Size(87, 25);
			btn_Limpiar.TabIndex = 6;
			btn_Limpiar.Text = "Limpiar";
			btn_Limpiar.UseVisualStyleBackColor = false;
			// 
			// btn_Eliminar
			// 
			btn_Eliminar.BackColor = Color.IndianRed;
			btn_Eliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Eliminar.Location = new Point(399, 159);
			btn_Eliminar.Name = "btn_Eliminar";
			btn_Eliminar.Size = new Size(87, 25);
			btn_Eliminar.TabIndex = 5;
			btn_Eliminar.Text = "Eliminar";
			btn_Eliminar.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.LightGray;
			panel2.Controls.Add(btn_Quitar);
			panel2.Controls.Add(btn_Agregar);
			panel2.Controls.Add(txt_Ingresar_Cant);
			panel2.Location = new Point(107, 104);
			panel2.Name = "panel2";
			panel2.Size = new Size(201, 80);
			panel2.TabIndex = 4;
			// 
			// btn_Quitar
			// 
			btn_Quitar.Image = Properties.Resources.img_minus;
			btn_Quitar.Location = new Point(133, 36);
			btn_Quitar.Name = "btn_Quitar";
			btn_Quitar.Size = new Size(40, 40);
			btn_Quitar.SizeMode = PictureBoxSizeMode.StretchImage;
			btn_Quitar.TabIndex = 5;
			btn_Quitar.TabStop = false;
			// 
			// btn_Agregar
			// 
			btn_Agregar.Image = Properties.Resources.img_add;
			btn_Agregar.Location = new Point(27, 36);
			btn_Agregar.Name = "btn_Agregar";
			btn_Agregar.Size = new Size(40, 40);
			btn_Agregar.SizeMode = PictureBoxSizeMode.StretchImage;
			btn_Agregar.TabIndex = 4;
			btn_Agregar.TabStop = false;
			// 
			// txt_Ingresar_Cant
			// 
			txt_Ingresar_Cant.Location = new Point(51, 7);
			txt_Ingresar_Cant.Name = "txt_Ingresar_Cant";
			txt_Ingresar_Cant.PlaceholderText = "Ingresar cantidad";
			txt_Ingresar_Cant.Size = new Size(100, 23);
			txt_Ingresar_Cant.TabIndex = 0;
			txt_Ingresar_Cant.TextAlign = HorizontalAlignment.Center;
			// 
			// dgv_Temp_Transacciones
			// 
			dgv_Temp_Transacciones.AllowUserToAddRows = false;
			dgv_Temp_Transacciones.AllowUserToDeleteRows = false;
			dgv_Temp_Transacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Temp_Transacciones.Location = new Point(397, 7);
			dgv_Temp_Transacciones.MultiSelect = false;
			dgv_Temp_Transacciones.Name = "dgv_Temp_Transacciones";
			dgv_Temp_Transacciones.ReadOnly = true;
			dgv_Temp_Transacciones.RowTemplate.Height = 25;
			dgv_Temp_Transacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Temp_Transacciones.Size = new Size(204, 147);
			dgv_Temp_Transacciones.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(txt_Nombre, 1, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 1);
			tableLayoutPanel1.Controls.Add(label3, 0, 2);
			tableLayoutPanel1.Controls.Add(label6, 2, 0);
			tableLayoutPanel1.Controls.Add(label7, 2, 1);
			tableLayoutPanel1.Controls.Add(label8, 2, 2);
			tableLayoutPanel1.Controls.Add(txt_Categoria, 1, 1);
			tableLayoutPanel1.Controls.Add(txt_Proveedor, 1, 2);
			tableLayoutPanel1.Controls.Add(txt_Cantidad, 3, 0);
			tableLayoutPanel1.Controls.Add(txt_Cant_Max, 3, 1);
			tableLayoutPanel1.Controls.Add(txt_Cant_Min, 3, 2);
			tableLayoutPanel1.Location = new Point(16, 7);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.Size = new Size(378, 90);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 7);
			label1.Margin = new Padding(3, 7, 3, 0);
			label1.Name = "label1";
			label1.Size = new Size(54, 15);
			label1.TabIndex = 0;
			label1.Text = "Nombre:";
			// 
			// txt_Nombre
			// 
			txt_Nombre.Location = new Point(73, 3);
			txt_Nombre.Name = "txt_Nombre";
			txt_Nombre.ReadOnly = true;
			txt_Nombre.Size = new Size(103, 23);
			txt_Nombre.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 36);
			label2.Margin = new Padding(3, 7, 3, 0);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 1;
			label2.Text = "Categoría:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 65);
			label3.Margin = new Padding(3, 7, 3, 0);
			label3.Name = "label3";
			label3.Size = new Size(64, 15);
			label3.TabIndex = 2;
			label3.Text = "Proveedor:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(182, 7);
			label6.Margin = new Padding(3, 7, 3, 0);
			label6.Name = "label6";
			label6.Size = new Size(58, 15);
			label6.TabIndex = 5;
			label6.Text = "Cantidad:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(182, 36);
			label7.Margin = new Padding(3, 7, 3, 0);
			label7.Name = "label7";
			label7.Size = new Size(84, 15);
			label7.TabIndex = 6;
			label7.Text = "Cantidad Max:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(182, 65);
			label8.Margin = new Padding(3, 7, 3, 0);
			label8.Name = "label8";
			label8.Size = new Size(82, 15);
			label8.TabIndex = 7;
			label8.Text = "Cantidad Min:";
			// 
			// txt_Categoria
			// 
			txt_Categoria.Location = new Point(73, 32);
			txt_Categoria.Name = "txt_Categoria";
			txt_Categoria.ReadOnly = true;
			txt_Categoria.Size = new Size(103, 23);
			txt_Categoria.TabIndex = 10;
			// 
			// txt_Proveedor
			// 
			txt_Proveedor.Location = new Point(73, 61);
			txt_Proveedor.Name = "txt_Proveedor";
			txt_Proveedor.ReadOnly = true;
			txt_Proveedor.Size = new Size(103, 23);
			txt_Proveedor.TabIndex = 11;
			// 
			// txt_Cantidad
			// 
			txt_Cantidad.Location = new Point(272, 3);
			txt_Cantidad.Name = "txt_Cantidad";
			txt_Cantidad.ReadOnly = true;
			txt_Cantidad.Size = new Size(103, 23);
			txt_Cantidad.TabIndex = 14;
			// 
			// txt_Cant_Max
			// 
			txt_Cant_Max.Location = new Point(272, 32);
			txt_Cant_Max.Name = "txt_Cant_Max";
			txt_Cant_Max.ReadOnly = true;
			txt_Cant_Max.Size = new Size(103, 23);
			txt_Cant_Max.TabIndex = 15;
			// 
			// txt_Cant_Min
			// 
			txt_Cant_Min.Location = new Point(272, 61);
			txt_Cant_Min.Name = "txt_Cant_Min";
			txt_Cant_Min.ReadOnly = true;
			txt_Cant_Min.Size = new Size(103, 23);
			txt_Cant_Min.TabIndex = 16;
			// 
			// UC_Transacciones
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(pnl_Producto);
			Controls.Add(pnl_Tabla_Productos);
			Controls.Add(panel1);
			Name = "UC_Transacciones";
			Size = new Size(617, 434);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			pnl_Tabla_Productos.ResumeLayout(false);
			pnl_Tabla_Productos.PerformLayout();
			pnl_Producto.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)btn_Quitar).EndInit();
			((System.ComponentModel.ISupportInitialize)btn_Agregar).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_Temp_Transacciones).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
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
	}
}
