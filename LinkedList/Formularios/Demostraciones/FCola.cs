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
	public partial class FCola: Form {
		private readonly Cola cola;
		private readonly FElemento fElemento;

		public FCola() {
			this.InitializeComponent();
		}

		public FCola(Cola cola) {
			this.InitializeComponent();
			this.cola = cola;
			this.fElemento = new FElemento();
		}

		private void FCola_FormClosed(object sender, FormClosedEventArgs e) {
			this.fElemento.Dispose();
		}

		private void BtnEncolar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			this.cola.Encolar(this.fElemento.Obtenido);
			this.ActualizarListBox();
		}

		private void BtnDesencolar_Click(object sender, EventArgs e) {
			object quitado = this.cola.Desencolar();

			if(quitado is object)
				MessageBox.Show($"Se quitó: {quitado}", "Elemento quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("No se quitó ningún elemento", "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnRevisar_Click(object sender, EventArgs e) {
			object quitado = this.cola.Revisar();

			if(quitado is object)
				MessageBox.Show($"Revisado: {quitado}", "Revisión", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("La cola está vacía", "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			DialogResult resultado = MessageBox.Show(
				"¿Estás seguro de que deseas limpiar la cola? No podrás recuperar los datos de la misma luego",
				"Confirmar limpiar cola",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.cola.Limpiar();
				this.ActualizarListBox();
			}
		}

		private void BtnContiene_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			string mensaje;

			if(this.cola.Contiene(this.fElemento.Obtenido))
				mensaje = "El elemento existe";
			else
				mensaje = "El elemento NO existe";

			MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ActualizarListBox() {
			this.lsbElementos.Items.Clear();
			int c = 0;

			foreach(object elemento in this.cola.AVector())
				this.lsbElementos.Items.Add($"[{c++}] {elemento}");
		}
	}
}
