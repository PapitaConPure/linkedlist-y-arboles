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
	public partial class FTablaHash: Form {
		private readonly TablaHash<string, double> tablaHash;
		private readonly FEntrada fEntrada;

		public FTablaHash() {
			this.InitializeComponent();
		}

		public FTablaHash(TablaHash<string, double> tablaHash) {
			this.InitializeComponent();
			this.tablaHash = tablaHash;
			this.fEntrada = new FEntrada();
			this.pgbCoberturaMáxima.Value = 80;
			this.ActualizarListBoxYBarra();
		}

		private void BtnInsertar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarTodo();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			this.tablaHash.Insertar(this.fEntrada.Clave, this.fEntrada.Valor);
			this.ActualizarListBoxYBarra();
		}

		private void BtnQuitar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			this.tablaHash.Quitar(this.fEntrada.Clave);
			this.ActualizarListBoxYBarra();
		}

		private void BtnBuscar_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			string clave = this.fEntrada.Clave;
			double encontrado;
			
			if(this.tablaHash.Buscar(clave, out encontrado)) {
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
				double encontrado = this.tablaHash.Encontrar(clave);
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
				"¿Estás seguro de que deseas limpiar la tabla? No podrás recuperar los datos de la misma luego",
				"Confirmar limpiar tabla",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if(resultado == DialogResult.Yes) {
				this.tablaHash.Limpiar();
				this.ActualizarListBoxYBarra();
			}
		}

		private void BtnContieneClave_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloClave();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			string clave = this.fEntrada.Clave;

			if(this.tablaHash.ContieneClave(clave))
				MessageBox.Show($"La clave existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"La clave NO existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnContieneValor_Click(object sender, EventArgs e) {
			this.fEntrada.ActivarSoloValor();
			if(this.fEntrada.ShowDialog() != DialogResult.OK)
				return;

			double valor = this.fEntrada.Valor;

			if(this.tablaHash.ContieneValor(valor))
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

			if(this.tablaHash.Contiene(entrada))
				MessageBox.Show($"La entrada existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"La entrada NO existe", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnMinimizarCapacidad_Click(object sender, EventArgs e) {
			this.tablaHash.MinimizarCapacidad();
			this.ActualizarListBoxYBarra();
		}

		private void ActualizarListBoxYBarra() {
			this.lsbElementos.Items.Clear();

			foreach(ParOrdenado<string, double> elemento in this.tablaHash.AVector())
				this.lsbElementos.Items.Add(elemento);

			int cobertura = (int)Math.Ceiling(this.tablaHash.Cobertura * this.tablaHash.Capacidad);
			this.tbCantidad.Text = this.tablaHash.Cantidad.ToString();
			this.tbCobertura.Text = cobertura.ToString();
			this.tbCapacidad.Text = this.tablaHash.Capacidad.ToString();
			this.pgbCoberturaCapacidad.Maximum = this.tablaHash.Capacidad;
			this.pgbCoberturaCapacidad.Value = cobertura;
		}
	}
}
