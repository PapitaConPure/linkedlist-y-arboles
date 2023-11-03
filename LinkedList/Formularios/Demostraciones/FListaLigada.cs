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
using Estructuras.Genéricas;

namespace LinkedList {
	public partial class FListaLigada: Form {
		private readonly ListaLigada<string> listaLigada;
		private readonly FElemento fElemento;

		public FListaLigada() {
			this.InitializeComponent();
		}

		public FListaLigada(ListaLigada<string> listaLigada) {
			this.InitializeComponent();
			this.listaLigada = listaLigada;
			this.fElemento = new FElemento();
			this.ActualizarListBox();
		}

		private int Índice {
			get { return (int)this.lsbElementos.SelectedIndex; }
		}

		private void FListaLigada_FormClosed(object sender, FormClosedEventArgs e) {
			this.fElemento.Dispose();
		}

		private void BtnAgregarPrimero_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			this.listaLigada.AgregarPrimero(this.fElemento.Obtenido);
			this.ActualizarListBox();
		}

		private void BtnAgregarÚltimo_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			this.listaLigada.Agregar(this.fElemento.Obtenido);
			this.ActualizarListBox();
		}

		private void BtnInsertar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			try {
				this.listaLigada.Insertar(this.Índice, this.fElemento.Obtenido);
				this.ActualizarListBox();
			} catch(ArgumentOutOfRangeException ex) {
				MessageBox.Show(ex.Message, "Fuera de rango");
			}
		}

		private void BtnQuitarPrimero_Click(object sender, EventArgs e) {
			object quitado = this.listaLigada.QuitarPrimero();

			if(quitado is object)
				MessageBox.Show($"Se quitó: {quitado}", "Elemento quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("No se quitó ningún elemento", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnQuitarÚltimo_Click(object sender, EventArgs e) {
			object quitado = this.listaLigada.QuitarÚltimo();

			if(quitado is object)
				MessageBox.Show($"Se quitó: {quitado}", "Elemento quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("No se quitó ningún elemento", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnQuitar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			int idx = this.listaLigada.Quitar(this.fElemento.Obtenido);

			if(idx >= 0)
				MessageBox.Show($"Índice donde se quitó: [{idx}]");
			else
				MessageBox.Show("Elemento no encontrado", "Elemento no quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBox();
		}

		private void BtnQuitarEn_Click(object sender, EventArgs e) {
			try {
				object quitado = this.listaLigada.QuitarEn(this.Índice);
				MessageBox.Show($"Valor quitado: {quitado}");
				this.ActualizarListBox();
			} catch(ArgumentOutOfRangeException ex) {
				MessageBox.Show(ex.Message, "Fuera de rango");
			}
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			DialogResult resultado = MessageBox.Show(
				"¿Estás seguro de que deseas limpiar la lista? No podrás recuperar los datos de la misma luego",
				"Confirmar limpiar lista",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.listaLigada.Limpiar();
				this.ActualizarListBox();
			}
		}

		private void BtnÍndiceDe_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			try {
				int idx = this.listaLigada.ÍndiceDe(this.fElemento.Obtenido);

				if(idx >= 0)
					MessageBox.Show($"Índice del elemento: [{idx}]", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Elemento no encontrado", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(ArgumentOutOfRangeException ex) {
				MessageBox.Show(ex.Message, "Fuera de rango");
			}
		}

		private void BtnValorEn_Click(object sender, EventArgs e) {
			try {
				object valor = this.listaLigada.ValorEn(this.Índice);
				string mensaje;

				if(valor is object)
					mensaje = $"Se encontró: {valor}";
				else
					mensaje = "No se encontró ningún elemento";

				MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(ArgumentOutOfRangeException ex) {
				MessageBox.Show(ex.Message, "Fuera de rango");
			}
		}

		private void BtnContiene_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			string mensaje;

			if(this.listaLigada.Contiene(this.fElemento.Obtenido))
				mensaje = "El elemento existe";
			else
				mensaje = "El elemento NO existe";

			MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ActualizarListBox() {
			this.lsbElementos.Items.Clear();
			int c = 0;

			foreach(object elemento in this.listaLigada.AVector())
				this.lsbElementos.Items.Add($"[{c++}] {elemento}");
		}
	}
}
