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

		/// <summary>
		/// Agrega un valor al <see cref="ÁrbolBinario{T}"/> de forma ordenada
		/// </summary>
		/// <param name="valor">El valor a integrar</param>
		public void Agregar(T valor) {
			if(this.Vacío) {
				this.raíz = new NodoÁrbolBinario<T>(valor);
				this.Cantidad++;
			} else {
				this.AgregarNodo(this.raíz, valor);
			}
		}

		/// <summary>
		/// Quita la ocurrencia más temprana del <paramref name="valor"/> indicado del <see cref="ÁrbolBinario{T}"/>
		/// </summary>
		/// <param name="valor">El valor a quitar</param>
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
			return !(resultado is null);
		}

		/// <summary>
		/// Quita la raíz del <see cref="ÁrbolBinario{T}"/> junto a todas sus ramas
		/// </summary>
		public void Limpiar() {
			this.raíz = null;
			this.Cantidad = 0;
		}

		/// <inheritdoc cref="AVector(Orden)"/>
		/// <inheritdoc cref="AVector(int, int)"/>
		public T[] AVector(Orden orden, int índiceInicio, int cantidad = -1) {
			ListaLigada<T> lista = new ListaLigada<T>();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			return lista.AVector(índiceInicio, cantidad);
		}

		/// <inheritdoc cref="AVector()"/>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento del <see cref="ÁrbolBinario{T}"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar del <see cref="ÁrbolBinario{T}"/>, -1 copia todo</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T[] AVector(int índiceInicio, int cantidad = -1) {
			return this.AVector(Orden.In, índiceInicio, cantidad);
		}

		/// <inheritdoc cref="AVector()"/>
		/// <param name="orden">Orden de recorrido a utilizar para construir el nuevo vector</param>
		/// <returns>Un nuevo vector con los elementos de este <see cref="ÁrbolBinario{T}"/>, acorde al <paramref name="orden"/> indicado</returns>
		public T[] AVector(Orden orden) {
			return this.AVector(orden, 0);
		}

		/// <summary>
		/// Copia todos los elementos del <see cref="ÁrbolBinario{T}"/> en un nuevo vector
		/// </summary>
		/// <returns>Un nuevo vector con los elementos de este <see cref="ÁrbolBinario{T}"/>, de forma ordenada</returns>
		public T[] AVector() {
			return this.AVector(Orden.In);
		}

		/// <inheritdoc cref="CopiarEn(T[], Orden)"/>
		/// <inheritdoc cref="CopiarEn(T[], int, int)"/>
		public void CopiarEn(T[] destino, Orden orden, int índiceInicio, int cantidad = -1) {
			ListaLigada<T> lista = new ListaLigada<T>();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			lista.CopiarEn(destino, índiceInicio, cantidad);
		}

		/// <inheritdoc cref="CopiarEn(T[])"/>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento del <see cref="ÁrbolBinario{T}"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar del <see cref="ÁrbolBinario{T}"/>, -1 copia todo</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public void CopiarEn(T[] destino, int índiceInicio, int cantidad = -1) {
			this.CopiarEn(destino, Orden.In, índiceInicio, cantidad);
		}

		/// <inheritdoc cref="CopiarEn(T[])"/>
		/// <remarks>Los elementos a copiar y/o su posición varían dependiendo del <paramref name="orden"/> de recorrido indicado para la operación</remarks>
		/// <param name="orden">Orden de recorrido del <see cref="ÁrbolBinario{T}"/> a utilizar para popular el vector <paramref name="destino"/></param>
		public void CopiarEn(T[] destino, Orden orden) {
			this.CopiarEn(destino, orden, 0);
		}

		/// <summary>
		/// Copia los elementos del <see cref="ÁrbolBinario{T}"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <param name="destino">El vector al cual copiar los elementos del <see cref="ÁrbolBinario{T}"/></param>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(T[] destino) {
			this.CopiarEn(destino, 0);
		}

		/// <summary>
		/// Busca un <see cref="NodoÁrbolBinario{T}"/> con el <paramref name="valor"/> entre los subárboles inmediatos
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="nodo"><see cref="NodoÁrbolBinario{T}"/> en el cual buscar el <paramref name="valor"/> indicado</param>
		/// <param name="valor">Valor a buscar en el <see cref="NodoÁrbolBinario{T}"/> actual o los subárboles inmediatos</param>
		/// <returns>
		/// El <see cref="NodoÁrbolBinario{T}"/> con el <paramref name="valor"/> indicado, 
		/// o <see langword="null"/> si no se lo encontró en ninguna de las posteriores llamadas (o el nodo actual no existe)
		/// </returns>
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

		/// <summary>
		/// Procesa un <see cref="NodoÁrbolBinario{T}"/> y sus subárboles inmediatos para compilar el resultado en la <paramref name="lista"/> indicada según el <paramref name="orden"/> deseado
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="lista">La <see cref="ListaLigada{T}"/> sobre la cual volcar el resultado del recorrido</param>
		/// <param name="orden">Orden de recorrido del <see cref="ÁrbolBinario{T}"/> a utilizar para popular el vector <paramref name="destino"/></param>
		/// <param name="nodo"><see cref="NodoÁrbolBinario{T}"/> a recorrer</param>
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

		/// <summary>
		/// Agrega un <see cref="NodoÁrbolBinario{T}"/> con el <paramref name="valor"/> deseado en el subárbol que cumpla las condiciones necesarias
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="nodo"><see cref="NodoÁrbolBinario{T}"/> a recorrer</param>
		/// <param name="valor">Nuevo valor a incluir</param>
		private void AgregarNodo(NodoÁrbolBinario<T> nodo, T valor) {
			int comparación = valor.CompareTo(nodo.Valor);

			if(comparación is 0)
				return;

			if(comparación < 0) {
				if(nodo.Izquierdo is null) {
					nodo.Izquierdo = new NodoÁrbolBinario<T>(valor);
					this.Cantidad++;
				} else
					this.AgregarNodo(nodo.Izquierdo, valor);
			} else {
				if(nodo.Derecho is null) {
					nodo.Derecho = new NodoÁrbolBinario<T>(valor);
					this.Cantidad++;
				} else
					this.AgregarNodo(nodo.Derecho, valor);
			}
		}

		/// <summary>
		/// Busca un <see cref="NodoÁrbolBinario{T}"/> con el <paramref name="valor"/> entre los subárboles inmediatos. 
		/// Si este mismo tiene lo que se busca, se lo reemplaza por el subárbol inferior más correcto para mantener el orden
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="nodo"><see cref="NodoÁrbolBinario{T}"/> en el cual buscar el <paramref name="valor"/> indicado</param>
		/// <param name="valor">Valor a buscar en el <see cref="NodoÁrbolBinario{T}"/> actual o los subárboles inmediatos</param>
		/// <returns>
		/// El <see cref="NodoÁrbolBinario{T}"/> con el <paramref name="valor"/> indicado, 
		/// o <see langword="null"/> si no se lo encontró en ninguna de las posteriores llamadas (o el nodo actual no existe)
		/// </returns>
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

		/// <summary>
		/// Busca e identifica el valor del <see cref="NodoÁrbolBinario{T}"/> más a la izquierda desde el <paramref name="nodo"/> actual
		/// </summary>
		/// <param name="nodo"><see cref="NodoÁrbolBinario{T}"/> desde el cuál buscar</param>
		/// <returns>El menor valor encontrado</returns>
		private T CalcularMenorValor(NodoÁrbolBinario<T> nodo) {
			while(!(nodo.Izquierdo is null))
				nodo = nodo.Izquierdo;

			return nodo.Valor;
		}
	}
}
