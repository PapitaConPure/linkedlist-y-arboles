using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList {
	public partial class FElemento: Form {
		public FElemento() {
			this.InitializeComponent();
		}

		/// <summary>
		/// Devuelve el elemento ingresado por el usuario (atajo para FElemento.tbElemento.Text)
		/// </summary>
		public string Obtenido {
			get { return this.tbElemento.Text; }
		}

		private void TbElemento_EnterOrFocus(object sender, EventArgs e) {
			this.tbElemento.SelectAll();
		}

		private void FElemento_Activated(object sender, EventArgs e) {
			this.tbElemento.Focus();
			this.tbElemento.SelectAll();
		}
	}
}
