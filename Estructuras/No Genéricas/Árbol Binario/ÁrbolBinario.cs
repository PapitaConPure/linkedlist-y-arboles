using System;

namespace Estructuras {
	[Serializable]
	public class ÁrbolBinario: IColección {
		private NodoÁrbolBinario raíz;

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
		/// Crea una nueva instancia de <see cref="ÁrbolBinario"/> con un <see cref="NodoÁrbolBinario"/> raíz
		/// </summary>
		/// <param name="raíz">Nodo raíz del <see cref="ÁrbolBinario"/></param>
		public ÁrbolBinario(NodoÁrbolBinario raíz) {
			this.raíz = raíz;
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoÁrbolBinario"/> vacía
		/// </summary>
		public ÁrbolBinario(): this(null) {}

		/// <summary>
		/// Obtiene el <see cref="NodoÁrbolBinario"/> Raíz del <see cref="ÁrbolBinario"/>
		/// </summary>
		public NodoÁrbolBinario Raíz {
			get { return this.raíz; }
		}

		/// <summary>
		/// Determina si el <see cref="ÁrbolBinario"/> está vacío (<see langword="true"/>) o no (<see langword="false"/>)
		/// </summary>
		public bool Vacío {
			get { return this.raíz is null; }
		}

		/// <summary>
		/// Indica la cantidad de elementos del <see cref="ÁrbolBinario"/>
		/// </summary>
		public int Cantidad { get; private set; }

		/// <summary>
		/// Revisa el <see cref="ÁrbolBinario"/> en busca del valor especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool Contiene(object valor) {
			if(valor is IComparable)
				return this.BuscarNodo(this.raíz, valor as IComparable) is NodoÁrbolBinario;
			else
				throw new ArgumentException("El valor que se intenta buscar no implementa la interfaz IComparable");
		}

		/// <summary>
		/// Busca el <paramref name="valor"/> especificado en el <see cref="ÁrbolBinario"/> y, si se encontró, 
		/// asigna <paramref name="izquierdo"/> y <paramref name="derecho"/> a los valores inmediatos de los subárboles izquierdo y derecho respectivamente. 
		/// </summary>
		/// <remarks>Si el <paramref name="valor"/> buscado no se encuentra, asigna <see langword="null"/> a <paramref name="izquierdo"/> y <paramref name="derecho"/></remarks>
		/// <param name="valor">Valor a buscar</param>
		/// <param name="izquierdo">Valor resultado del subárbol inmediato izquierdo</param>
		/// <param name="derecho">Valor resultado del subárbol inmediato derecho</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool Buscar(IComparable valor, out IComparable izquierdo, out IComparable derecho) {
			NodoÁrbolBinario encontrado = this.BuscarNodo(this.raíz, valor);

			izquierdo = derecho = null;

			if(encontrado is null)
				return false;

			if(encontrado.Izquierdo is NodoÁrbolBinario)
				izquierdo = encontrado.Izquierdo.Valor;

			if(encontrado.Derecho is NodoÁrbolBinario)
				derecho = encontrado.Derecho.Valor;

			return true;
		}

		/// <summary>
		/// Agrega un valor al <see cref="ÁrbolBinario"/> de forma ordenada
		/// </summary>
		/// <param name="valor">El valor a integrar</param>
		public void Agregar(IComparable valor) {
			if(this.Vacío) {
				this.raíz = new NodoÁrbolBinario(valor);
			} else {
				this.AgregarNodo(this.raíz, valor);
			}

			this.Cantidad++;
		}

		/// <summary>
		/// Quita la ocurrencia más temprana del <paramref name="valor"/> indicado del <see cref="ÁrbolBinario"/>
		/// </summary>
		/// <param name="valor">El valor a quitar</param>
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

		/// <summary>
		/// Quita la raíz del <see cref="ÁrbolBinario"/> junto a todas sus ramas
		/// </summary>
		public void Limpiar() {
			this.raíz = null;
			this.Cantidad = 0;
		}

		/// <summary>
		/// Copia todos los elementos del <see cref="ÁrbolBinario"/> en un nuevo vector
		/// </summary>
		/// <param name="orden">Orden de recorrido a utilizar para construir el nuevo vector</param>
		/// <returns>Un nuevo vector con los elementos de este <see cref="ÁrbolBinario"/>, acorde al <paramref name="orden"/> indicado</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object[] AVector(Orden orden) {
			ListaLigada lista = new ListaLigada();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			IComparable[] vector = new IComparable[lista.Cantidad];
			lista.CopiarEn(vector);
			return vector;
		}

		/// <summary>
		/// Copia todos los elementos del <see cref="ÁrbolBinario"/> en un nuevo vector
		/// </summary>
		/// <returns>Un nuevo vector con los elementos de este <see cref="ÁrbolBinario"/>, de forma ordenada</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object[] AVector() {
			return this.AVector(Orden.In);
		}

		/// <summary>
		/// Copia los elementos del <see cref="ÁrbolBinario"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <remarks>Los elementos a copiar y/o su posición varían dependiendo del <paramref name="orden"/> de recorrido indicado para la operación</remarks>
		/// <param name="destino">El vector al cual copiar los elementos del <see cref="ÁrbolBinario"/></param>
		/// <param name="orden">Orden de recorrido del <see cref="ÁrbolBinario"/> a utilizar para popular el vector <paramref name="destino"/></param>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento del <see cref="ÁrbolBinario"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar del <see cref="ÁrbolBinario"/></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(object[] destino, Orden orden, int índiceInicio = -1, int cantidad = -1) {
			ListaLigada lista = new ListaLigada();
			this.RecorrerNodo(lista, this.raíz, orden);
			this.Cantidad = lista.Cantidad;

			lista.CopiarEn(destino, índiceInicio, cantidad);
		}

		/// <summary>
		/// Copia los elementos del <see cref="ÁrbolBinario"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <param name="destino">El vector al cual copiar los elementos del <see cref="ÁrbolBinario"/></param>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento del <see cref="ÁrbolBinario"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar del <see cref="ÁrbolBinario"/></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(object[] destino, int índiceInicio = -1, int cantidad = -1) {
			this.CopiarEn(destino, Orden.In, índiceInicio, cantidad);
		}

		/// <summary>
		/// Busca un <see cref="NodoÁrbolBinario"/> con el <paramref name="valor"/> entre los subárboles inmediatos
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="nodo"><see cref="NodoÁrbolBinario"/> en el cual buscar el <paramref name="valor"/> indicado</param>
		/// <param name="valor">Valor a buscar en el <see cref="NodoÁrbolBinario"/> actual o los subárboles inmediatos</param>
		/// <returns>
		/// El <see cref="NodoÁrbolBinario"/> con el <paramref name="valor"/> indicado, 
		/// o <see langword="null"/> si no se lo encontró en ninguna de las posteriores llamadas (o el nodo actual no existe)
		/// </returns>
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

		/// <summary>
		/// Procesa un <see cref="NodoÁrbolBinario"/> y sus subárboles inmediatos para compilar el resultado en la <paramref name="lista"/> indicada según el <paramref name="orden"/> deseado
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="lista">La <see cref="ListaLigada"/> sobre la cual volcar el resultado del recorrido</param>
		/// <param name="orden">Orden de recorrido del <see cref="ÁrbolBinario"/> a utilizar para popular el vector <paramref name="destino"/></param>
		/// <param name="nodo"><see cref="NodoÁrbolBinario"/> a recorrer</param>
		private void RecorrerNodo(ListaLigada lista, NodoÁrbolBinario nodo, Orden orden) {
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
		/// Agrega un <see cref="NodoÁrbolBinario"/> con el <paramref name="valor"/> deseado en el subárbol que cumpla las condiciones necesarias
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="nodo"><see cref="NodoÁrbolBinario"/> a recorrer</param>
		/// <param name="valor">Nuevo valor a incluir</param>
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

		/// <summary>
		/// Busca un <see cref="NodoÁrbolBinario"/> con el <paramref name="valor"/> entre los subárboles inmediatos. 
		/// Si este mismo tiene lo que se busca, se lo reemplaza por el subárbol inferior más correcto para mantener el orden
		/// </summary>
		/// <remarks>Usado para recorrido recursivo</remarks>
		/// <param name="nodo"><see cref="NodoÁrbolBinario"/> en el cual buscar el <paramref name="valor"/> indicado</param>
		/// <param name="valor">Valor a buscar en el <see cref="NodoÁrbolBinario"/> actual o los subárboles inmediatos</param>
		/// <returns>
		/// El <see cref="NodoÁrbolBinario"/> con el <paramref name="valor"/> indicado, 
		/// o <see langword="null"/> si no se lo encontró en ninguna de las posteriores llamadas (o el nodo actual no existe)
		/// </returns>
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

		/// <summary>
		/// Busca e identifica el valor del <see cref="NodoÁrbolBinario"/> más a la izquierda desde el <paramref name="nodo"/> actual
		/// </summary>
		/// <param name="nodo"><see cref="NodoÁrbolBinario"/> desde el cuál buscar</param>
		/// <returns>El menor valor encontrado</returns>
		private IComparable CalcularMenorValor(NodoÁrbolBinario nodo) {
			while(nodo.Izquierdo is NodoÁrbolBinario)
				nodo = nodo.Izquierdo;

			return nodo.Valor;
		}
	}
}
