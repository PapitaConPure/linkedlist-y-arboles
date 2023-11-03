using System;

namespace Estructuras.Genéricas {
	[Serializable]
	public class ÁrbolBinario<T>: IColección<T> where T: IComparable, IComparable<T> {
		private NodoÁrbolBinario<T> raíz;

		/// <summary>
		/// Especifica el orden de recorrido recursivo de los nodos del árbol
		/// </summary>
		public enum Orden {
			/// <summary>
			/// Procesa el subárbol izquierdo, luego el valor del nodo, luego el subárbol derecho
			/// </summary>
			In = 0,
			/// <summary>
			/// Procesa el valor del nodo, luego el subárbol izquierdo, luego el subárbol derecho
			/// </summary>
			Pre,
			/// <summary>
			/// Procesa el subárbol izquierdo, luego el subárbol derecho, luego el valor del nodo
			/// </summary>
			Post,
		}

		/// <summary>
		/// Crea una nueva instancia de <see cref="ÁrbolBinario{T}"/> con un <see cref="NodoÁrbolBinario{T}"/> raíz
		/// </summary>
		/// <param name="raíz">Nodo raíz del <see cref="ÁrbolBinario{T}"/></param>
		public ÁrbolBinario(NodoÁrbolBinario<T> raíz) {
			this.raíz = raíz;
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoÁrbolBinario{T}"/> vacía
		/// </summary>
		public ÁrbolBinario(): this(null) {}

		/// <summary>
		/// Obtiene el <see cref="NodoÁrbolBinario{T}"/> Raíz del <see cref="ÁrbolBinario{T}"/>
		/// </summary>
		public NodoÁrbolBinario<T> Raíz {
			get { return this.raíz; }
		}

		/// <summary>
		/// Determina si el <see cref="ÁrbolBinario{T}"/> está vacío (<see langword="true"/>) o no (<see langword="false"/>)
		/// </summary>
		public bool Vacío {
			get { return this.raíz is null; }
		}

		/// <summary>
		/// Indica la cantidad de elementos del <see cref="ÁrbolBinario{T}"/>
		/// </summary>
		public int Cantidad { get; private set; }

		/// <summary>
		/// Revisa el <see cref="ÁrbolBinario{T}"/> en busca del valor especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool Contiene(T valor) {
			return this.BuscarNodo(this.raíz, valor) is NodoÁrbolBinario<T>;
		}

		/// <summary>
		/// Busca el <paramref name="valor"/> especificado en el <see cref="ÁrbolBinario{T}"/> y, si se encontró, 
		/// asigna <paramref name="izquierdo"/> y <paramref name="derecho"/> a los valores inmediatos de los subárboles izquierdo y derecho respectivamente. 
		/// </summary>
		/// <remarks>Si el <paramref name="valor"/> buscado no se encuentra, asigna el valor por defecto de <typeparamref name="T"/> a <paramref name="izquierdo"/> y <paramref name="derecho"/></remarks>
		/// <param name="valor">Valor a buscar</param>
		/// <param name="izquierdo">Valor resultado del subárbol inmediato izquierdo</param>
		/// <param name="derecho">Valor resultado del subárbol inmediato derecho</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool Buscar(T valor, out T izquierdo, out T derecho) {
			NodoÁrbolBinario<T> nodo = this.BuscarNodo(this.raíz, valor);

			izquierdo = derecho = default;

			if(nodo is null)
				return false;

			if(nodo.Izquierdo is object)
				izquierdo = nodo.Izquierdo.Valor;

			if(nodo.Derecho is object)
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

		public void CopiarEn(T[] destino, Orden orden, int índiceInicio = -1, int cantidad = -1) {
			ListaLigada<T> lista = new ListaLigada<T>();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			lista.CopiarEn(destino, índiceInicio, cantidad);
		}

		public void CopiarEn(T[] destino, int índiceInicio = -1, int cantidad = -1) {
			this.CopiarEn(destino, Orden.In, índiceInicio, cantidad);
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
				lista.Agregar(nodo.Valor);
				this.RecorrerNodo(lista, nodo.Izquierdo, orden);
				this.RecorrerNodo(lista, nodo.Derecho, orden);
				break;

			case Orden.In:
				this.RecorrerNodo(lista, nodo.Izquierdo, orden);
				lista.Agregar(nodo.Valor);
				this.RecorrerNodo(lista, nodo.Derecho, orden);
				break;

			case Orden.Post:
				this.RecorrerNodo(lista, nodo.Izquierdo, orden);
				this.RecorrerNodo(lista, nodo.Derecho, orden);
				lista.Agregar(nodo.Valor);
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
