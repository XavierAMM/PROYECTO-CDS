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
			textBox1 = new TextBox();
			pictureBox4 = new PictureBox();
			pnl_Tabla_Productos = new Panel();
			pnl_Producto = new Panel();
			button2 = new Button();
			button1 = new Button();
			panel2 = new Panel();
			pictureBox5 = new PictureBox();
			pictureBox3 = new PictureBox();
			textBox5 = new TextBox();
			dataGridView1 = new DataGridView();
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			textBox9 = new TextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			pnl_Tabla_Productos.SuspendLayout();
			pnl_Producto.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
			cmb_Inventario.FormattingEnabled = true;
			cmb_Inventario.Location = new Point(347, 7);
			cmb_Inventario.Name = "cmb_Inventario";
			cmb_Inventario.Size = new Size(154, 23);
			cmb_Inventario.TabIndex = 1;
			// 
			// cmb_Bodega
			// 
			cmb_Bodega.FormattingEnabled = true;
			cmb_Bodega.Location = new Point(136, 7);
			cmb_Bodega.Name = "cmb_Bodega";
			cmb_Bodega.Size = new Size(154, 23);
			cmb_Bodega.TabIndex = 0;
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
			// textBox1
			// 
			textBox1.Location = new Point(180, 7);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(250, 23);
			textBox1.TabIndex = 3;
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
			pnl_Tabla_Productos.Controls.Add(textBox1);
			pnl_Tabla_Productos.Dock = DockStyle.Top;
			pnl_Tabla_Productos.Location = new Point(0, 37);
			pnl_Tabla_Productos.Name = "pnl_Tabla_Productos";
			pnl_Tabla_Productos.Size = new Size(617, 201);
			pnl_Tabla_Productos.TabIndex = 6;
			// 
			// pnl_Producto
			// 
			pnl_Producto.Controls.Add(button2);
			pnl_Producto.Controls.Add(button1);
			pnl_Producto.Controls.Add(panel2);
			pnl_Producto.Controls.Add(dataGridView1);
			pnl_Producto.Controls.Add(tableLayoutPanel1);
			pnl_Producto.Dock = DockStyle.Fill;
			pnl_Producto.Enabled = false;
			pnl_Producto.Location = new Point(0, 238);
			pnl_Producto.Name = "pnl_Producto";
			pnl_Producto.Size = new Size(617, 196);
			pnl_Producto.TabIndex = 7;
			// 
			// button2
			// 
			button2.BackColor = Color.Tomato;
			button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(514, 160);
			button2.Name = "button2";
			button2.Size = new Size(87, 25);
			button2.TabIndex = 6;
			button2.Text = "Limpiar";
			button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = Color.IndianRed;
			button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(399, 159);
			button1.Name = "button1";
			button1.Size = new Size(87, 25);
			button1.TabIndex = 5;
			button1.Text = "Eliminar";
			button1.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.LightGray;
			panel2.Controls.Add(pictureBox5);
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(textBox5);
			panel2.Location = new Point(107, 104);
			panel2.Name = "panel2";
			panel2.Size = new Size(201, 80);
			panel2.TabIndex = 4;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = Properties.Resources.img_minus;
			pictureBox5.Location = new Point(133, 36);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(40, 40);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 5;
			pictureBox5.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.img_add;
			pictureBox3.Location = new Point(27, 36);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(40, 40);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 4;
			pictureBox3.TabStop = false;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(49, 7);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(100, 23);
			textBox5.TabIndex = 0;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(397, 7);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(204, 147);
			dataGridView1.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 1);
			tableLayoutPanel1.Controls.Add(label3, 0, 2);
			tableLayoutPanel1.Controls.Add(label6, 2, 0);
			tableLayoutPanel1.Controls.Add(label7, 2, 1);
			tableLayoutPanel1.Controls.Add(label8, 2, 2);
			tableLayoutPanel1.Controls.Add(textBox3, 1, 1);
			tableLayoutPanel1.Controls.Add(textBox4, 1, 2);
			tableLayoutPanel1.Controls.Add(textBox7, 3, 0);
			tableLayoutPanel1.Controls.Add(textBox8, 3, 1);
			tableLayoutPanel1.Controls.Add(textBox9, 3, 2);
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
			// textBox2
			// 
			textBox2.Location = new Point(73, 3);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(103, 23);
			textBox2.TabIndex = 1;
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
			// textBox3
			// 
			textBox3.Location = new Point(73, 32);
			textBox3.Name = "textBox3";
			textBox3.ReadOnly = true;
			textBox3.Size = new Size(103, 23);
			textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(73, 61);
			textBox4.Name = "textBox4";
			textBox4.ReadOnly = true;
			textBox4.Size = new Size(103, 23);
			textBox4.TabIndex = 11;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(272, 3);
			textBox7.Name = "textBox7";
			textBox7.ReadOnly = true;
			textBox7.Size = new Size(103, 23);
			textBox7.TabIndex = 14;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(272, 32);
			textBox8.Name = "textBox8";
			textBox8.ReadOnly = true;
			textBox8.Size = new Size(103, 23);
			textBox8.TabIndex = 15;
			// 
			// textBox9
			// 
			textBox9.Location = new Point(272, 61);
			textBox9.Name = "textBox9";
			textBox9.ReadOnly = true;
			textBox9.Size = new Size(103, 23);
			textBox9.TabIndex = 16;
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
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
		private TextBox textBox1;
		private PictureBox pictureBox4;
		private Panel pnl_Tabla_Productos;
		private Panel pnl_Producto;
		private TextBox textBox2;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private DataGridView dataGridView1;
		private Label label2;
		private Label label3;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox7;
		private TextBox textBox8;
		private TextBox textBox9;
		private Panel panel2;
		private PictureBox pictureBox3;
		private TextBox textBox5;
		private Button button2;
		private Button button1;
		private PictureBox pictureBox5;
	}
}
