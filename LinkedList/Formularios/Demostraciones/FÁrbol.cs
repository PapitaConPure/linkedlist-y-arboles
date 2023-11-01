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
		private readonly ÁrbolBinario árbolBinario;
		private readonly FElemento fElemento;
		NodoÁrbolBinario mostrado;

		public FÁrbol() {
			this.InitializeComponent();
		}

		public FÁrbol(ÁrbolBinario árbolBinario) {
			this.InitializeComponent();
			this.árbolBinario = árbolBinario;
			this.fElemento = new FElemento();
			this.ActualizarListBoxYVisualizador();
			this.mostrado = this.árbolBinario.Raíz;
		}

		private void FÁrbol_FormClosed(object sender, FormClosedEventArgs e) {
			this.fElemento.Dispose();
		}

		private void BtnBuscar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			IComparable elemento = this.TextoUNúmero();
			IComparable izquierdo, derecho;
			IComparable encontrado = this.árbolBinario.Buscar(elemento, out izquierdo, out derecho);

			ListaLigada líneas = new ListaLigada();

			if(encontrado is object) líneas.AgregarÚltimo($"Encontrado: {encontrado}");
			if(izquierdo is object)  líneas.AgregarÚltimo($"Izquierdo:  {izquierdo}");
			if(derecho is object)    líneas.AgregarÚltimo($"Derecho:    {derecho}");

			MessageBox.Show(string.Join("\n", líneas.AVector()));
		}

		private void BtnContiene_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			IComparable elemento = this.TextoUNúmero();
			this.árbolBinario.Contiene(elemento);
		}

		private void BtnAgregar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			IComparable elemento = this.TextoUNúmero();
			this.árbolBinario.Agregar(elemento);

			this.ActualizarListBoxYVisualizador();
		}

		private void BtnQuitar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			IComparable elemento = this.TextoUNúmero();
			bool quitado = this.árbolBinario.Quitar(elemento);

			if(quitado)
				MessageBox.Show($"Se quitó: {elemento}", "Elemento quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"No se encontró: {elemento}", "Elemento no quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBoxYVisualizador();
		}

		private IComparable TextoUNúmero() {
			decimal num;
			IComparable elemento = this.fElemento.Obtenido;
			if(decimal.TryParse(elemento as string, out num))
				elemento = num;
			return elemento;
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			DialogResult resultado = MessageBox.Show(
				"¿Estás seguro de que deseas limpiar el árbol? No podrás recuperar los datos del mismo luego",
				"Confirmar limpiar árbol",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.árbolBinario.Limpiar();
				this.ActualizarListBoxYVisualizador();
			}
		}

		private void BtnNodoSuperior_Click(object sender, EventArgs e) {
			this.mostrado = this.árbolBinario.Raíz;
			this.ActualizarVistaÁrbol();
		}

		private void BtnNodoActual_Click(object sender, EventArgs e) {
			this.ActualizarVistaÁrbol();
		}

		private void BtnSubnodoIzquierdo_Click(object sender, EventArgs e) {
			if(this.mostrado is NodoÁrbolBinario && this.mostrado.Izquierdo is NodoÁrbolBinario)
				this.mostrado = this.mostrado.Izquierdo;

			this.ActualizarVistaÁrbol();
		}

		private void BtnSubnodoDerecho_Click(object sender, EventArgs e) {
			if(this.mostrado is NodoÁrbolBinario && this.mostrado.Derecho is NodoÁrbolBinario)
				this.mostrado = this.mostrado.Derecho;

			this.ActualizarVistaÁrbol();
		}

		private void ActualizarListBoxYVisualizador() {
			this.lsbElementos.Items.Clear();
			int c = 0;

			foreach(object elemento in this.árbolBinario.AVector(ÁrbolBinario.Orden.In))
				this.lsbElementos.Items.Add($"[{c++}] {elemento}");

			this.mostrado = this.árbolBinario.Raíz;
			this.ActualizarVistaÁrbol();
		}

		private void ActualizarVistaÁrbol() {
			this.MostrarNodo(this.tbNodoRaíz, this.árbolBinario.Raíz);
			this.MostrarNodo(this.tbNodoActual, this.mostrado);
			if(this.mostrado is NodoÁrbolBinario) {
				this.MostrarNodo(this.tbSubnodoIzquierdo, this.mostrado.Izquierdo);
				this.MostrarNodo(this.tbSubnodoDerecho, this.mostrado.Derecho);
			} else {
				this.MostrarNodo(this.tbSubnodoIzquierdo, null);
				this.MostrarNodo(this.tbSubnodoDerecho, null);
			}
		}

		private void MostrarNodo(TextBox tbNodo, NodoÁrbolBinario nodo) {
			if(nodo is NodoÁrbolBinario && nodo.Valor is object)
				tbNodo.Text = nodo.Valor.ToString();
			else
				tbNodo.Text = "";
		}
	}
}
