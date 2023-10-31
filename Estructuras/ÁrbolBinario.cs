using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras {
	[Serializable]
	public class ÁrbolBinario {
		private NodoÁrbolBinario raíz;

		public ÁrbolBinario(NodoÁrbolBinario raíz) {
			this.raíz = raíz;
		}

		public ÁrbolBinario(): this(null) { }

		public bool Vacío {
			get { return this.raíz is null; }
		}

		public int Cantidad { get; private set; }

		public IComparable MenorValor {
			get {
				NodoÁrbolBinario nodo = this.raíz;

				while(nodo.Izquierdo is object)
					nodo = nodo.Izquierdo;

				return nodo.Valor;
			}
		}

		public IComparable MayorValor {
			get {
				NodoÁrbolBinario nodo = this.raíz;

				while(nodo.Derecho is object)
					nodo = nodo.Derecho;

				return nodo.Valor;
			}
		}

		public int Profundidad { get; private set; }

		public void Limpiar() {
			this.raíz = null;
			this.Cantidad = this.Profundidad = 0;
		}

		public IComparable[] AVector() {
			return new IComparable[0]; //Pendiente
		}

		public void RecalcularProfundidad() {
			int mayorProfundidad = 0;

			//Hacer algo acá

			this.Profundidad = mayorProfundidad;
		}
	}
}
