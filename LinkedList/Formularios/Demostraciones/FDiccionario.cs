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
	public partial class FDiccionario: Form {
		private readonly Diccionario<string, double> diccionario;
		private readonly FEntrada fEntrada;

		public FDiccionario() {
			this.InitializeComponent();
		}

		public FDiccionario(Diccionario<string, double> diccionario) {
			this.InitializeComponent();
			this.diccionario = diccionario;
			this.fEntrada = new FEntrada();
			this.ActualizarListBoxYBarra();
		}

		private void BtnInsertar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarTodo();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			this.diccionario.Insertar(this.fEntrada.Clave, this.fEntrada.Valor);
			this.ActualizarListBoxYBarra();
		}

		private void BtnQuitar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			this.diccionario.Quitar(this.fEntrada.Clave);
			this.ActualizarListBoxYBarra();
		}

		private void BtnBuscar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			string clave = this.fEntrada.Clave;
			double encontrado;

			if(this.diccionario.Buscar(clave, out encontrado)) {
				MessageBox.Show($"Encontrado: {encontrado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				MessageBox.Show(
					$"No se encontró un valor con la clave '{clave}'",
					"Sin resultados",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		private void BtnEncontrar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			//Lo mismo que arriba pero tira una excepción si la clave no existe
			string clave = this.fEntrada.Clave;
			try {
				double encontrado = this.diccionario.Encontrar(clave);
				MessageBox.Show($"Encontrado: {encontrado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch(Exception ex) {
				MessageBox.Show(
					$"Ocurrió un problema al buscar la clave '{clave}':\n{ex.Message}",
					"Error de búsqueda",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			DialogResult resultado = MessageBox.Show(
				"¿Estás seguro de que deseas limpiar el diccionario? No podrás recuperar los datos del mismo luego",
				"Confirmar limpiar diccionario",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.diccionario.Limpiar();
				this.ActualizarListBoxYBarra();
			}
		}

		private void BtnContieneClave_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			string clave = this.fEntrada.Clave;

			if(this.diccionario.ContieneClave(clave))
				MessageBox.Show($"La clave existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"La clave NO existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnContieneValor_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloValor();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			double valor = this.fEntrada.Valor;

			if(this.diccionario.ContieneValor(valor))
				MessageBox.Show($"El valor existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"El valor NO existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnContiene_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarTodo();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			string clave = this.fEntrada.Clave;
			double valor = this.fEntrada.Valor;
			ParOrdenado<string, double> entrada = new ParOrdenado<string, double>(clave, valor);

			if(this.diccionario.Contiene(entrada))
				MessageBox.Show($"La entrada existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"La entrada NO existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnMinimizarCapacidad_Click(object sender, EventArgs e) {
			this.diccionario.MinimizarTamaño();
			this.ActualizarListBoxYBarra();
		}

		private void ActualizarListBoxYBarra() {
			this.lsbElementos.Items.Clear();

			foreach(ParOrdenado<string, double> elemento in this.diccionario.AVector())
				this.lsbElementos.Items.Add(elemento);

			int cantidad = this.diccionario.Cantidad;
			int capacidad = this.diccionario.Capacidad;

			this.tbCantidad.Text = cantidad.ToString();
			this.tbCapacidad.Text = capacidad.ToString();
			this.pgbCantidadCapacidad.Maximum = capacidad;
			this.pgbCantidadCapacidad.Value = cantidad;
		}
	}
}
