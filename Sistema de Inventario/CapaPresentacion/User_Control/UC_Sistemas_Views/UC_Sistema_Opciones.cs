using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.User_Control.UC_Sistemas_Views
{
	public partial class UC_Sistema_Opciones : UserControl
	{
		private int usuario_id;
		public UC_Sistema_Opciones(int usuario_id)
		{
			InitializeComponent();
			this.usuario_id = usuario_id;
		}
	}
}
