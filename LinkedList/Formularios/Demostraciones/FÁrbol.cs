using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructuras.Genéricas;

namespace LinkedList {
	public partial class FÁrbol: Form {
		private readonly ÁrbolBinario<string> árbolBinario;
		private readonly FElemento fElemento;
		NodoÁrbolBinario<string> mostrado;

		public FÁrbol() {
			this.InitializeComponent();
		}

		public FÁrbol(ÁrbolBinario<string> árbolBinario) {
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

			string elemento = this.fElemento.Obtenido;
			string encontrado, izquierdo, derecho;
			bool encontró = this.árbolBinario.Buscar(elemento, out encontrado, out izquierdo, out derecho);

			ListaLigada<string> líneas = new ListaLigada<string>();

			if(encontró) {
				líneas.AgregarÚltimo($"Encontrado: {encontrado}");

				if(izquierdo is object)
					líneas.AgregarÚltimo($"Izquierdo:  {izquierdo}");

				if(derecho is object)
					líneas.AgregarÚltimo($"Derecho:    {derecho}");
			} else {
				líneas.AgregarÚltimo("Sin resultados.");
			}

			string mensaje = string.Join("\n", líneas.AVector());
			MessageBox.Show(mensaje, "Búsqueda realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnContiene_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			string elemento = this.fElemento.Obtenido;
			string mensaje;

			if(this.árbolBinario.Contiene(elemento))
				mensaje = "El elemento existe";
			else
				mensaje = "El elemento NO existe";

			MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnAgregar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			string elemento = this.fElemento.Obtenido;
			this.árbolBinario.Agregar(elemento);

			this.ActualizarListBoxYVisualizador();
		}

		private void BtnQuitar_Click(object sender, EventArgs e) {
			if(this.fElemento.ShowDialog() != DialogResult.OK)
				return;

			string elemento = this.fElemento.Obtenido;
			bool quitado = this.árbolBinario.Quitar(elemento);

			if(quitado)
				MessageBox.Show($"Se quitó: {elemento}", "Elemento quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"No se encontró: {elemento}", "Elemento no quitado", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.ActualizarListBoxYVisualizador();
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
			if(this.mostrado is object && this.mostrado.Izquierdo is object)
				this.mostrado = this.mostrado.Izquierdo;

			this.ActualizarVistaÁrbol();
		}

		private void BtnSubnodoDerecho_Click(object sender, EventArgs e) {
			if(this.mostrado is object && this.mostrado.Derecho is object)
				this.mostrado = this.mostrado.Derecho;

			this.ActualizarVistaÁrbol();
		}

		private void ActualizarListBoxYVisualizador() {
			this.lsbElementos.Items.Clear();
			int c = 0;

			foreach(object elemento in this.árbolBinario.AVector(ÁrbolBinario<string>.Orden.In))
				this.lsbElementos.Items.Add($"[{c++}] {elemento}");

			this.mostrado = this.árbolBinario.Raíz;
			this.ActualizarVistaÁrbol();
		}

		private void ActualizarVistaÁrbol() {
			this.MostrarNodo(this.tbNodoRaíz, this.árbolBinario.Raíz);
			this.MostrarNodo(this.tbNodoActual, this.mostrado);
			if(this.mostrado is object) {
				this.MostrarNodo(this.tbSubnodoIzquierdo, this.mostrado.Izquierdo);
				this.MostrarNodo(this.tbSubnodoDerecho, this.mostrado.Derecho);
			} else {
				this.MostrarNodo(this.tbSubnodoIzquierdo, null);
				this.MostrarNodo(this.tbSubnodoDerecho, null);
			}
		}

		private void MostrarNodo(TextBox tbNodo, NodoÁrbolBinario<string> nodo) {
			if(nodo is object && nodo.Valor is object)
				tbNodo.Text = nodo.Valor.ToString();
			else
				tbNodo.Text = "";
		}
	}
}
