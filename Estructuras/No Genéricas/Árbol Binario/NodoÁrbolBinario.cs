using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras {
	[Serializable]
	public class NodoÁrbolBinario {
		public NodoÁrbolBinario(IComparable valor, NodoÁrbolBinario nodo1, NodoÁrbolBinario nodo2) {
			this.Valor = valor;

			if(nodo1 is object)
				this.Apendar(nodo1);

			if(nodo2 is object)
				this.Apendar(nodo2);
		}

		public NodoÁrbolBinario(IComparable valor, NodoÁrbolBinario nodo): this(valor, nodo, null) {}

		public NodoÁrbolBinario(IComparable valor): this(valor, null) {}

		public IComparable Valor { get; set; }

		public NodoÁrbolBinario Izquierdo { get; set; }

		public NodoÁrbolBinario Derecho { get; set; }

		public bool Extremo {
			get { return this.Izquierdo is null && this.Derecho is null; }
		}

		/// <summary>
		/// Coloca un nodo en alguno de los suárboles directos o indirectos basado en su valor respecto a los mismos
		/// </summary>
		/// <returns><see langword="true"/> si el proceso finalizó con este mismo nodo, <see langword="false"/> de lo contrario</returns>
		public bool Apendar(NodoÁrbolBinario nodo) {
			if(nodo is null)
				return true;

			if(nodo.Valor.CompareTo(this.Valor) < 0) {
				if(this.Izquierdo is null) {
					this.Izquierdo = nodo;
					return true;
				} else {
					this.Izquierdo.Apendar(nodo);
					return false;
				}
			} else {
				if(this.Derecho is null) {
					this.Derecho = nodo;
					return true;
				} else {
					this.Derecho.Apendar(nodo);
					return false;
				}
			}
		}
	}
}
