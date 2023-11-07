using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras.Genéricas {
	[Serializable]
	public class NodoÁrbolBinario<T> where T: IComparable, IComparable<T> {
		public NodoÁrbolBinario(T valor) {
			this.Valor = valor;
		}

		public T Valor { get; set; }

		public NodoÁrbolBinario<T> Izquierdo { get; set; }

		public NodoÁrbolBinario<T> Derecho { get; set; }

		public bool Extremo {
			get { return this.Izquierdo is null && this.Derecho is null; }
		}

		/// <summary>
		/// Coloca un nodo en alguno de los suárboles directos o indirectos basado en su valor respecto a los mismos
		/// </summary>
		/// <returns><see langword="true"/> si el proceso finalizó con este mismo nodo, <see langword="false"/> de lo contrario</returns>
		public bool Apendar(NodoÁrbolBinario<T> nodo) {
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
