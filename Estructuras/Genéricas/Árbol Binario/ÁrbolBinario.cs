using System;

namespace Estructuras.Genéricas {
	[Serializable]
	public class ÁrbolBinario<T>: IColección<T> where T: IComparable, IComparable<T> {
		private NodoÁrbolBinario<T> raíz;

		public enum Orden {
			In = 0,
			Pre,
			Post,
		}

		public ÁrbolBinario(NodoÁrbolBinario<T> raíz) {
			this.raíz = raíz;
		}

		public ÁrbolBinario(): this(null) {}

		/// <summary>
		/// Devuelve el <see cref="NodoÁrbolBinario{T}"/> Raíz del <see cref="ÁrbolBinario{T}"/>
		/// </summary>
		public NodoÁrbolBinario<T> Raíz {
			get { return this.raíz; }
		}

		public bool Vacío {
			get { return this.raíz is null; }
		}

		public int Cantidad { get; private set; }

		public bool Contiene(T valor) {
			return this.BuscarNodo(this.raíz, valor) is NodoÁrbolBinario<T>;
		}

		public bool Buscar(T valor, out T encontrado, out T izquierdo, out T derecho) {
			NodoÁrbolBinario<T> nodo = this.BuscarNodo(this.raíz, valor);

			encontrado = izquierdo = derecho = default;

			if(nodo is null)
				return false;

			encontrado = nodo.Valor;

			if(nodo.Izquierdo is NodoÁrbolBinario<T>)
				izquierdo = nodo.Izquierdo.Valor;

			if(nodo.Derecho is NodoÁrbolBinario<T>)
				derecho = nodo.Derecho.Valor;

			return true;
		}

		public void Agregar(T valor) {
			if(this.Vacío) {
				this.raíz = new NodoÁrbolBinario<T>(valor);
			} else {
				this.AgregarNodo(this.raíz, valor);
			}

			this.Cantidad++;
		}

		public bool Quitar(T valor) {
			int comparación = this.raíz.Valor.CompareTo(valor);

			if(this.Cantidad == 1 && comparación == 0) {
				this.raíz = null;
				this.Cantidad--;
				return true;
			}

			NodoÁrbolBinario<T> resultado = this.QuitarNodo(this.raíz, valor);

			if(resultado is null)
				return false;

			this.raíz = resultado;
			this.Cantidad--;
			return resultado is NodoÁrbolBinario<T>;
		}

		public void Limpiar() {
			this.raíz = null;
			this.Cantidad = 0;
		}

		public T[] AVector(Orden orden) {
			ListaLigada<T> lista = new ListaLigada<T>();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			T[] vector = new T[lista.Cantidad];
			lista.CopiarEn(vector);
			return vector;
		}

		public T[] AVector() {
			return this.AVector(Orden.In);
		}

		private NodoÁrbolBinario<T> BuscarNodo(NodoÁrbolBinario<T> nodo, T valor) {
			if(nodo is null)
				return null;

			int comparación = valor.CompareTo(nodo.Valor);

			if(comparación < 0)
				return this.BuscarNodo(nodo.Izquierdo, valor);

			if(comparación > 0)
				return this.BuscarNodo(nodo.Derecho, valor);

			return nodo;
		}

		private void RecorrerNodo(ListaLigada<T> lista, NodoÁrbolBinario<T> nodo, Orden orden) {
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

		private void AgregarNodo(NodoÁrbolBinario<T> nodo, T valor) {
			int comparación = valor.CompareTo(nodo.Valor);

			if(comparación < 0) {
				if(nodo.Izquierdo is null)
					nodo.Izquierdo = new NodoÁrbolBinario<T>(valor);
				else
					this.AgregarNodo(nodo.Izquierdo, valor);
			} else {
				if(nodo.Derecho is null)
					nodo.Derecho = new NodoÁrbolBinario<T>(valor);
				else
					this.AgregarNodo(nodo.Derecho, valor);
			}
		}

		private NodoÁrbolBinario<T> QuitarNodo(NodoÁrbolBinario<T> nodo, T valor) {
			if(nodo is null)
				return null;

			int comparación = valor.CompareTo(nodo.Valor);

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

			T nuevoValor = this.CalcularMenorValor(nodo.Derecho);
			nodo.Valor = nuevoValor;
			nodo.Derecho = this.QuitarNodo(nodo.Derecho, nuevoValor);

			return nodo;
		}

		private T CalcularMenorValor(NodoÁrbolBinario<T> nodo) {
			while(nodo.Izquierdo is NodoÁrbolBinario<T>)
				nodo = nodo.Izquierdo;

			return nodo.Valor;
		}
	}
}
