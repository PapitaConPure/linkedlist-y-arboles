using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Estructuras.Genéricas;

namespace LinkedList {
	public partial class FPrincipal: Form {
		private Sistema sistema;
		private string rutaBin;

		public FPrincipal() {
			this.InitializeComponent();
		}

		#region Serialización
		private void FPrincipal_Load(object sender, EventArgs e) {
			string rutaDir = Application.StartupPath;
			this.rutaBin = Path.Combine(rutaDir, ".data");

			FileStream fs = null;
			try {
				if(File.Exists(this.rutaBin)) {
					fs = new FileStream(this.rutaBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.sistema = bf.Deserialize(fs) as Sistema;
					this.sistema.Actualizar();
				}
			} catch {
			} finally {
				if(fs is FileStream)
					fs.Close();
			}

			if(this.sistema is null)
				this.sistema = new Sistema();
		}

		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			FileStream fs = null;
			try {
				fs = new FileStream(this.rutaBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, this.sistema);
			} catch {
			} finally {
				if(fs is FileStream)
					fs.Close();
			}
		}
		#endregion

		#region Demostraciones
		private void BtnListaLigada_Click(object sender, EventArgs e) {
			FListaLigada fListaLigada = new FListaLigada(this.sistema.ListaLigada);
			fListaLigada.ShowDialog();
			fListaLigada.Dispose();
		}

		private void BtnListaDoblementeLigada_Click(object sender, EventArgs e) {
			FListaLigada fListaLigada = new FListaLigada(this.sistema.ListaDoblementeLigada); //Herencia, papá. Tomá pa' vos
			fListaLigada.Text = "Demostración de Lista Doblemente Ligada";
			fListaLigada.ShowDialog();
			fListaLigada.Dispose();
		}

		private void BtnPila_Click(object sender, EventArgs e) {
			FPila fPila = new FPila(this.sistema.Pila);
			fPila.ShowDialog();
			fPila.Dispose();
		}

		private void BtnCola_Click(object sender, EventArgs e) {
			FCola fCola = new FCola(this.sistema.Cola);
			fCola.ShowDialog();
			fCola.Dispose();
		}

		private void BtnÁrbolBinario_Click(object sender, EventArgs e) {
			FÁrbol fÁrbol = new FÁrbol(this.sistema.ÁrbolBinario);
			fÁrbol.ShowDialog();
			fÁrbol.Dispose();
		}

		private void BtnTablaHash_Click(object sender, EventArgs e) {
			FTablaHash fÁrbol = new FTablaHash(this.sistema.TablaHash);
			fÁrbol.ShowDialog();
			fÁrbol.Dispose();
		}

		private void BtnDiccionario_Click(object sender, EventArgs e) {
			MessageBox.Show("No implementado", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
		#endregion

		private void BtnSalir_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
