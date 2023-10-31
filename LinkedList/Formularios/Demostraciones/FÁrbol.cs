using Estructuras;
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
	public partial class FÁrbol: Form {
		private ÁrbolBinario árbolBinario;
		private readonly FElemento fElemento;

		public FÁrbol() {
			this.InitializeComponent();
		}

		public FÁrbol(ÁrbolBinario árbolBinario) {
			this.InitializeComponent();
			this.árbolBinario = árbolBinario;
			this.fElemento = new FElemento();
			this.ActualizarListBox();
		}

		private void FÁrbol_FormClosed(object sender, FormClosedEventArgs e) {
			this.fElemento.Dispose();
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			DialogResult resultado = MessageBox.Show(
				"¿Estás seguro de que deseas limpiar el árbol? No podrás recuperar los datos del mismo luego",
				"Confirmar limpiar árbol",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.árbolBinario.Limpiar();
				this.ActualizarListBox();
			}
		}

		private void ActualizarListBox() {
			this.lsbElementos.Items.Clear();
			int c = 0;

			foreach(object elemento in this.árbolBinario.AVector())
				this.lsbElementos.Items.Add($"[{c++}] {elemento}");
		}
	}
}
