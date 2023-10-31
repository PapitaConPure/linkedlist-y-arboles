using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructuras;

namespace LinkedList {
	public partial class FPila: Form {
		private readonly Pila pila;
		private readonly FElemento fElemento;

		public FPila() {
			this.InitializeComponent();
		}

		public FPila(Pila pila) {
			this.InitializeComponent();
			this.pila = pila;
			this.fElemento = new FElemento();
			this.ActualizarListBox();
		}

		private void FPila_FormClosed(object sender, FormClosedEventArgs e) {
			this.fElemento.Dispose();
		}

		private void BtnApilar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			this.pila.Apilar(this.fElemento.Obtenido);
			this.ActualizarListBox();
		}

		private void BtnDesapilar_Click(object sender, EventArgs e) {
			object quitado = this.pila.Desapilar();

			if(quitado is object)
				MessageBox.Show($"Se quitó: {quitado}", "Elemento quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("No se quitó ningún elemento", "Pila vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnRevisar_Click(object sender, EventArgs e) {
			object quitado = this.pila.Revisar();

			if(quitado is object)
				MessageBox.Show($"Revisado: {quitado}", "Revisión", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("La pila está vacía", "Pila vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			DialogResult resultado = MessageBox.Show(
				"¿Estás seguro de que deseas limpiar la pila? No podrás recuperar los datos de la misma luego",
				"Confirmar limpiar pila",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.pila.Limpiar();
				this.ActualizarListBox();
			}
		}

		private void BtnContiene_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			string mensaje;

			if(this.pila.Contiene(this.fElemento.Obtenido))
				mensaje = "El elemento existe";
			else
				mensaje = "El elemento NO existe";

			MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ActualizarListBox() {
			this.lsbElementos.Items.Clear();
			int c = 0;

			foreach(object elemento in this.pila.AVector())
				this.lsbElementos.Items.Add($"[{c++}] {elemento}");
		}
	}
}
