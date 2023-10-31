using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras {
	[Serializable]
	public class NodoÁrbolBinario {
		public enum Orden {
			In = 0,
			Pre,
			Post,
		}

		public NodoÁrbolBinario(IComparable valor, NodoÁrbolBinario nodo1, NodoÁrbolBinario nodo2) {
			this.Valor = valor;

			if(nodo1 is object)
				this.Colocar(nodo1);

			if(nodo2 is object)
				this.Colocar(nodo2);
		}

		public NodoÁrbolBinario(IComparable valor, NodoÁrbolBinario nodo): this(valor, nodo, null) {}

		public NodoÁrbolBinario(IComparable valor): this(valor, null) { }

		public IComparable Valor { get; set; }

		public NodoÁrbolBinario Izquierdo { get; set; }

		public NodoÁrbolBinario Derecho { get; set; }

		/// <summary>
		/// Coloca un nodo en alguno de los suárboles directos o indirectos basado en su valor respecto a los mismos
		/// </summary>
		/// <returns><see langword="true"/> si el proceso finalizó con este mismo nodo, <see langword="false"/> de lo contrario</returns>
		public bool Colocar(NodoÁrbolBinario nodo) {
			if(nodo is null)
				return true;

			if(nodo.Valor.CompareTo(this.Valor) < 0)
				return this.Apendar(this.Izquierdo, ref nodo);
			else
				return this.Apendar(this.Derecho, ref nodo);
		}

		/// <summary>
		/// Busca un nodo en los subárboles izquierdos y derechos. Si no lo encuentra, hace que los mismos sigan buscando
		/// </summary>
		/// <remarks>Si se especifica, solo se buscará hasta una cierta <paramref name="profundidad"/> de subárboles indicados</remarks>
		/// <param name="valor">Valor a buscar en subárboles</param>
		/// <param name="profundidad">Profundidad, desde este nodo, hasta la cual buscar en los subárboles</param>
		/// <returns></returns>
		public IComparable Buscar(IComparable valor, int profundidad = -1) {
			if(profundidad == 0)
				return null;

			if(profundidad > 0)
				profundidad--;

			if(valor.CompareTo(this.Valor) < 0)
				return this.Izquierdo.Buscar(profundidad);
			else if(valor.CompareTo(this.Valor) > 0)
				return this.Derecho.Buscar(profundidad);
			else
				return this.Valor;
		}

		/// <summary>
		/// Apenda un <paramref name="nuevo"/> <see cref="NodoÁrbolBinario"/> al <paramref name="receptor"/> indicado
		/// </summary>
		/// <param name="nuevo"><see cref="NodoÁrbolBinario"/> a incorporar al árbol del <paramref name="receptor"/></param>
		/// <param name="receptor"><see cref="NodoÁrbolBinario"/> que recibe al <paramref name="nuevo"/></param>
		/// <returns>Si se finalizó el apéndice directo o el nodo se pasó a un subárbol existente</returns>
		private bool Apendar(NodoÁrbolBinario nuevo, ref NodoÁrbolBinario receptor) {
			if(receptor is null) {
				receptor = nuevo;
				return true;
			} else {
				receptor.Colocar(nuevo);
				return false;
			}
		}
	}
}
