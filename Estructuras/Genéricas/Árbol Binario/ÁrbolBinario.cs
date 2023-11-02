using System;

namespace Estructuras.Genéricas {
	[Serializable]
	public class ÁrbolBinario {
		private NodoÁrbolBinario raíz;
		public enum Orden {
			In = 0,
			Pre,
			Post,
		}

		public ÁrbolBinario(NodoÁrbolBinario raíz) {
			this.raíz = raíz;
		}

		public ÁrbolBinario(): this(null) { }

		/// <summary>
		/// Devuelve el <see cref="NodoÁrbolBinario"/> Raíz del <see cref="ÁrbolBinario"/>
		/// </summary>
		public NodoÁrbolBinario Raíz {
			get { return this.raíz; }
		}

		public bool Vacío {
			get { return this.raíz is null; }
		}

		public int Cantidad { get; private set; }

		public bool Contiene(IComparable valor) {
			return this.BuscarNodo(this.raíz, valor) is NodoÁrbolBinario;
		}

		public IComparable Buscar(IComparable valor, out IComparable izquierdo, out IComparable derecho) {
			NodoÁrbolBinario encontrado = this.BuscarNodo(this.raíz, valor);

			izquierdo = derecho = null;

			if(encontrado is null)
				return null;

			if(encontrado.Izquierdo is NodoÁrbolBinario)
				izquierdo = encontrado.Izquierdo.Valor;

			if(encontrado.Derecho is NodoÁrbolBinario)
				derecho = encontrado.Derecho.Valor;

			return encontrado.Valor;
		}

		public void Agregar(IComparable valor) {
			if(this.Vacío) {
				this.raíz = new NodoÁrbolBinario(valor);
			} else {
				this.AgregarNodo(this.raíz, valor);
			}

			this.Cantidad++;
		}

		public bool Quitar(IComparable valor) {
			int comparación = -1;
			if(this.raíz.Valor.GetType() == valor.GetType())
				comparación = this.raíz.Valor.CompareTo(valor);

			if(this.Cantidad == 1 && comparación == 0) {
				this.raíz = null;
				this.Cantidad--;
				return true;
			}

			NodoÁrbolBinario resultado = this.QuitarNodo(this.raíz, valor);

			if(resultado is null)
				return false;

			this.raíz = resultado;
			this.Cantidad--;
			return resultado is NodoÁrbolBinario;
		}

		public void Limpiar() {
			this.raíz = null;
			this.Cantidad = 0;
		}

		public IComparable[] AVector(Orden orden) {
			ListaLigada lista = new ListaLigada();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			IComparable[] vector = new IComparable[lista.Cantidad];
			lista.CopiarEn(vector);
			return vector;
		}

		private NodoÁrbolBinario BuscarNodo(NodoÁrbolBinario nodo, IComparable valor) {
			if(nodo is null)
				return null;

			int comparación = -1;
			if(nodo.Valor.GetType() == valor.GetType())
				comparación = valor.CompareTo(nodo.Valor);

			if(comparación < 0)
				return this.BuscarNodo(nodo.Izquierdo, valor);

			if(comparación > 0)
				return this.BuscarNodo(nodo.Derecho, valor);

			return nodo;
		}

		private void RecorrerNodo(ListaLigada lista, NodoÁrbolBinario nodo, Orden orden) {
			if(nodo is null)
				return;

			switch(orden) {
			case Orden.Pre:
				lista.AgregarÚltimo(nodo.Valor);
				this.RecorrerNodo(lista, nodo.Izquierdo, orden);
				this.RecorrerNodo(lista, nodo.Derecho, orden);
				break;

			case Orden.In:
				this.RecorrerNodo(lista, nodo.Izquierdo, orden);
				lista.AgregarÚltimo(nodo.Valor);
				this.RecorrerNodo(lista, nodo.Derecho, orden);
				break;

			case Orden.Post:
				this.RecorrerNodo(lista, nodo.Izquierdo, orden);
				this.RecorrerNodo(lista, nodo.Derecho, orden);
				lista.AgregarÚltimo(nodo.Valor);
				break;
			}
		}

		private void AgregarNodo(NodoÁrbolBinario nodo, IComparable valor) {
			int comparación = -1;
			if(nodo.Valor.GetType() == valor.GetType())
				comparación = valor.CompareTo(nodo.Valor);

			if(comparación < 0) {
				if(nodo.Izquierdo is null)
					nodo.Izquierdo = new NodoÁrbolBinario(valor);
				else
					this.AgregarNodo(nodo.Izquierdo, valor);
			} else {
				if(nodo.Derecho is null)
					nodo.Derecho = new NodoÁrbolBinario(valor);
				else
					this.AgregarNodo(nodo.Derecho, valor);
			}
		}

		private NodoÁrbolBinario QuitarNodo(NodoÁrbolBinario nodo, IComparable valor) {
			if(nodo is null)
				return null;

			int comparación = -1;
			if(nodo.Valor.GetType() == valor.GetType())
				comparación = valor.CompareTo(nodo.Valor);

			if(comparación < 0) {
				nodo.Izquierdo = this.QuitarNodo(nodo.Izquierdo, valor);
				return nodo;
			}
			
			if(comparación > 0) {
				nodo.Derecho = this.QuitarNodo(nodo.Derecho, valor);
				return nodo;
			}

			if(nodo.Izquierdo is null)
				return nodo.Derecho;

			if(nodo.Derecho is null)
				return nodo.Izquierdo;

			IComparable nuevoValor = this.CalcularMenorValor(nodo.Derecho);
			nodo.Valor = nuevoValor;
			nodo.Derecho = this.QuitarNodo(nodo.Derecho, nuevoValor);

			return nodo;
		}

		private IComparable CalcularMenorValor(NodoÁrbolBinario nodo) {
			while(nodo.Izquierdo is NodoÁrbolBinario)
				nodo = nodo.Izquierdo;

			return nodo.Valor;
		}
	}
}
