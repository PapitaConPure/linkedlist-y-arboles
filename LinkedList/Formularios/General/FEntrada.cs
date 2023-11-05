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
	public partial class FEntrada: Form {
		/// <summary>
		/// Devuelve la clave ingresada por el usuario (atajo para FEntrada.tbClave.Text)
		/// </summary>
		public string Clave {
			get { return this.tbClave.Text; }
		}

		/// <summary>
		/// Devuelve la clave ingresada por el usuario (atajo para (double)FEntrada.nudValor.Value)
		/// </summary>
		public double Valor {
			get { return (double)this.nudValor.Value; }
		}

		public FEntrada() {
			this.InitializeComponent();
		}

		public void ActivarTodo() {
			this.lblClave.Enabled = this.tbClave.Enabled = true;
			this.lblValor.Enabled = this.nudValor.Enabled = true;
		}

		public void ActivarSoloClave() {
			this.lblClave.Enabled = this.tbClave.Enabled = true;
			this.lblValor.Enabled = this.nudValor.Enabled = false;
		}

		public void ActivarSoloValor() {
			this.lblClave.Enabled = this.tbClave.Enabled = false;
			this.lblValor.Enabled = this.nudValor.Enabled = true;
		}

		private void TbClave_EnterOrFocus(object sender, EventArgs e) {
			this.tbClave.SelectAll();
		}

		private void NudValor_EnterOrFocus(object sender, EventArgs e) {
			this.nudValor.Select(0, 20);
		}

		private void FEntrada_Activated(object sender, EventArgs e) {
			if(this.tbClave.Enabled) {
				this.tbClave.Focus();
				this.tbClave.SelectAll();
			} else {
				this.nudValor.Focus();
				this.nudValor.Select(0, 20);
			}
		}
	}
}
