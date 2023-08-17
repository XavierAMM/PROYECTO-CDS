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
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			panel5 = new Panel();
			panel6 = new Panel();
			panel7 = new Panel();
			panel8 = new Panel();
			panel9 = new Panel();
			lbl_Cancelar = new Label();
			dgv_Opciones = new DataGridView();
			chb_Inactivos = new CheckBox();
			pnl_Actualizar.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel5.SuspendLayout();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_Opciones).BeginInit();
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
			pnl_Actualizar.Size = new Size(178, 380);
			pnl_Actualizar.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(panel5);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(178, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(448, 380);
			panel2.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Controls.Add(chb_Inactivos);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(448, 28);
			panel3.TabIndex = 0;
			// 
			// panel4
			// 
			panel4.Dock = DockStyle.Bottom;
			panel4.Location = new Point(0, 336);
			panel4.Name = "panel4";
			panel4.Size = new Size(448, 44);
			panel4.TabIndex = 1;
			// 
			// panel5
			// 
			panel5.Controls.Add(dgv_Opciones);
			panel5.Dock = DockStyle.Fill;
			panel5.Location = new Point(0, 28);
			panel5.Name = "panel5";
			panel5.Size = new Size(448, 308);
			panel5.TabIndex = 2;
			// 
			// panel6
			// 
			panel6.BackColor = Color.Brown;
			panel6.Controls.Add(lbl_Cancelar);
			panel6.Dock = DockStyle.Right;
			panel6.Location = new Point(166, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(12, 380);
			panel6.TabIndex = 0;
			// 
			// panel7
			// 
			panel7.Dock = DockStyle.Top;
			panel7.Location = new Point(0, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(166, 46);
			panel7.TabIndex = 1;
			// 
			// panel8
			// 
			panel8.Dock = DockStyle.Top;
			panel8.Location = new Point(0, 46);
			panel8.Name = "panel8";
			panel8.Size = new Size(166, 190);
			panel8.TabIndex = 2;
			// 
			// panel9
			// 
			panel9.Dock = DockStyle.Top;
			panel9.Location = new Point(0, 236);
			panel9.Name = "panel9";
			panel9.Size = new Size(166, 72);
			panel9.TabIndex = 3;
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
			dgv_Opciones.Size = new Size(448, 308);
			dgv_Opciones.TabIndex = 1;
			// 
			// chb_Inactivos
			// 
			chb_Inactivos.AutoSize = true;
			chb_Inactivos.Location = new Point(100, 6);
			chb_Inactivos.Name = "chb_Inactivos";
			chb_Inactivos.Size = new Size(117, 19);
			chb_Inactivos.TabIndex = 3;
			chb_Inactivos.Text = "Mostrar Inactivos";
			chb_Inactivos.UseVisualStyleBackColor = true;
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
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel5.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgv_Opciones).EndInit();
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
	}
}
