using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos secuencial de carácter de lista en la cual cada elemento hace referencia al siguiente
	/// </summary>
	[Serializable]
	public class ListaLigada<T>: IColección<T>, ILista<T> {
		protected NodoListaLigada<T> cabeza;
		protected NodoListaLigada<T> cola;

		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaLigada{T}"/> cuyos valores iniciales son dados por el vector facilitado
		/// </summary>
		/// <param name="valores">Valores con los cuales inicializar la <see cref="ListaLigada{T}"/></param>
		/// <remarks>Los valores se ingresan en el orden que fueron recibidos, siendo el primero la cabeza o principio y el último la cola o final</remarks>
		public ListaLigada(T[] valores) {
			this.cabeza = null;
			foreach(T valor in valores)
				this.Agregar(valor);
		}

		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaLigada{T}"/> vacía
		/// </summary>
		public ListaLigada() {
			this.cabeza = null;
			this.cola = null;
		}

		/// <summary>
		/// Determina si la <see cref="ListaLigada{T}"/> está vacía (<see langword="true"/>) o no (<see langword="false"/>)
		/// </summary>
		public bool Vacía {
			get { return this.cabeza is null; }
		}

		/// <summary>
		/// Indica la cantidad de elementos involucrados en la <see cref="ListaLigada{T}"/>
		/// </summary>
		public int Cantidad { get; protected set; } = 0;

		/// <summary>
		/// Devuelve el primer valor de la <see cref="ListaLigada{T}"/>
		/// </summary>
		/// <exception cref="InvalidOperationException"></exception>
		public T PrimerValor {
			get {
				if(this.Vacía)
					throw new InvalidOperationException("La lista está vacía");

				return this.cabeza.Valor;
			}
		}

		/// <summary>
		/// Devuelve el primer valor de la <see cref="ListaLigada{T}"/> o el valor por defecto de <typeparamref name="T"/>
		/// </summary>
		public T PrimerValorOPorDefecto {
			get {
				if(this.Vacía)
					return default;

				return this.cabeza.Valor;
			}
		}

		/// <summary>
		/// Devuelve el último valor de la <see cref="ListaLigada{T}"/>
		/// </summary>
		/// <exception cref="InvalidOperationException"></exception>
		public T ÚltimoValor {
			get {
				if(this.Vacía)
					throw new InvalidOperationException("La lista está vacía");

				return this.cola.Valor;
			}
		}

		/// <summary>
		/// Devuelve el último valor de la <see cref="ListaLigada{T}"/> o el valor por defecto de <typeparamref name="T"/>
		/// </summary>
		public T ÚltimoValorOPorDefecto {
			get {
				if(this.Vacía)
					return default;

				return this.cola.Valor;
			}
		}

		/// <summary>
		/// Accede un elemento de la <see cref="ListaLigada{T}"/>
		/// </summary>
		/// <param name="idx">Índice del elemento en la <see cref="ListaLigada{T}"/></param>
		/// <returns>Elemento en la posición especificada</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T this[int idx] {
			get {
				return this.BuscarNodoPorÍndice(idx).Valor;
			}
			set {
				this.BuscarNodoPorÍndice(idx).Valor = value;
			}
		}

		/// <summary>
		/// Revisa la <see cref="ListaLigada{T}"/> en busca del valor especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool Contiene(T valor) {
			if(Genérico.EsNulo(valor))
				return false;

			return this.BuscarNodoPorValor(valor, out _) is object;
		}

		/// <summary>
		/// Agrega un valor a la cabeza o el principio de la <see cref="ListaLigada{T}"/>
		/// </summary>
		/// <param name="valor">Valor a insertar</param>
		/// <returns>La posición en la que se insertó el nuevo elemento, ó -1 si no se insertó nada</returns>
		public virtual int AgregarPrimero(T valor) {
			if(Genérico.EsNulo(valor))
				return -1;

			NodoListaLigada<T> nuevo = new NodoListaLigada<T>(valor, this.cabeza);

			if(this.Vacía)
				this.cola = nuevo;

			this.cabeza = nuevo;

			return this.Cantidad++;
		}

		/// <summary>
		/// Agrega un valor a la cola o final de la <see cref="ListaLigada{T}"/>
		/// </summary>
		/// <param name="valor">Valor a insertar</param>
		/// <returns>La posición en la que se insertó el nuevo elemento, ó -1 si no se insertó nada</returns>
		public virtual int Agregar(T valor) {
			if(Genérico.EsNulo(valor))
				return -1;

			NodoListaLigada<T> nuevo = new NodoListaLigada<T>(valor);

			if(this.Vacía)
				this.cabeza = nuevo;
			else if(this.cabeza.Siguiente is null)
				this.cabeza.Siguiente = nuevo;
			else
				this.cola.Siguiente = nuevo;

			this.cola = nuevo;

			return this.Cantidad++;
		}

		/// <summary>
		/// Inserta un valor en la posición indicada
		/// </summary>
		/// <param name="índice">Posición de inserción</param>
		/// <param name="valor">Valor a insertar</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public virtual void Insertar(int índice, T valor) {
			if(Genérico.EsNulo(valor))
				return;

			if(índice == this.Cantidad) {
				this.Agregar(valor);
				return;
			}

			NodoListaLigada<T> anterior;
			NodoListaLigada<T> siguiente;

			if(índice == 0) {
				anterior = null;
				siguiente = this.BuscarNodoPorÍndice(índice);
			} else {
				anterior = this.BuscarNodoPorÍndice(índice - 1);
				siguiente = anterior.Siguiente;
			}

			NodoListaLigada<T> nuevo = new NodoListaLigada<T>(valor, siguiente);

			if(anterior is object) {
				anterior.Siguiente = nuevo;
			} else
				this.cabeza = nuevo;

			this.Cantidad++;
		}

		/// <summary>
		/// Quita el primer elemento de la <see cref="ListaLigada{T}"/> y lo devuelve
		/// </summary>
		/// <returns>El valor quitado, o el valor por defecto de <typeparamref name="T"/> si la <see cref="ListaLigada{T}"/> está vacía</returns>
		public virtual T QuitarPrimero() {
			if(this.Vacía)
				return default;

			T quitado = this.cabeza.Valor;
			this.cabeza = this.cabeza.Siguiente;

			if(this.Vacía)
				this.cola = null;

			this.Cantidad--;

			return quitado;
		}

		/// <summary>
		/// Quita el último elemento de la <see cref="ListaLigada{T}"/> y lo devuelve
		/// </summary>
		/// <returns>El valor quitado, o el valor por defecto de <typeparamref name="T"/> si la <see cref="ListaLigada{T}"/> está vacía</returns>
		public virtual T QuitarÚltimo() {
			if(this.Vacía)
				return default;

			T quitado = this.cola.Valor;

			if(this.Cantidad == 1) {
				this.cabeza = this.cola = null;
			} else {
				NodoListaLigada<T> anterior = this.BuscarNodoPorÍndice(this.Cantidad - 2);
				anterior.Siguiente = null;
			}

			this.Cantidad--;

			return quitado;
		}

		/// <summary>
		/// Quita la primer instancia del valor especificado y devuelve su índice, si se encuentra
		/// </summary>
		/// <param name="valor">Valor a quitar</param>
		/// <returns>El índice del valor quitado de la <see cref="ListaLigada{T}"/>, ó -1 si no se quitó nada</returns>
		public int Quitar(T valor) {
			if(this.Vacía)
				return -1;

			int idx;
			NodoListaLigada<T> aQuitar = this.BuscarNodoPorValor(valor, out idx);
			this.QuitarNodoYRemediar(aQuitar);
			return idx;
		}

		/// <summary>
		/// Quita el elemento en el índice especificado
		/// </summary>
		/// <param name="índice">Índice en el cual remover un elemento</param>
		/// <returns>El valor quitado de la <see cref="ListaLigada{T}"/></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T QuitarEn(int índice) {
			NodoListaLigada<T> aQuitar = this.BuscarNodoPorÍndice(índice);
			this.QuitarNodoYRemediar(aQuitar);
			return aQuitar.Valor;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="ListaLigada{T}"/>
		/// </summary>
		public void Limpiar() {
			this.cabeza = null;
			this.cola = null;
			this.Cantidad = 0;
		}

		/// <summary>
		/// Busca un elemento por índice en la <see cref="ListaLigada{T}"/> y devuelve su valor
		/// </summary>
		/// <param name="índice">Índice deseado</param>
		/// <returns>El valor del elemento en la posición del índice especificado</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T ValorEn(int índice) {
			return this.BuscarNodoPorÍndice(índice).Valor;
		}

		/// <summary>
		/// Busca un elemento por valor en la <see cref="ListaLigada{T}"/> y devuelve el índice de la primer aparición
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns>El índice de la primera instancia encontrada, ó -1 si no se encuentra una</returns>
		public int ÍndiceDe(T valor) {
			if(Genérico.EsNulo(valor))
				return -1;

			int idx;
			this.BuscarNodoPorValor(valor, out idx);
			return idx;
		}

		/// <summary>
		/// Copia los elementos del rango especificado de la <see cref="ListaLigada{T}"/> en un nuevo vector
		/// </summary>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar, ó -1 para copiar hasta el final</param>
		/// <returns>Un nuevo vector con los elementos indicados de esta <see cref="ListaLigada{T}"/></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T[] AVector(int índiceInicio, int cantidad = -1) {
			if(this.Vacía)
				return new T[0];

			if(cantidad == -1)
				cantidad = this.Cantidad - índiceInicio;

			if(0 > índiceInicio || índiceInicio >= this.Cantidad)
				throw new ArgumentOutOfRangeException("El índice de inicio debe estar entre 0 y la cantidad de elementos de la Lista Ligada");

			cantidad -= cantidad + índiceInicio - this.Cantidad;
			int índiceFin = índiceInicio + cantidad;
			T[] vector = new T[cantidad];
			NodoListaLigada<T> actual = this.cabeza;
			int idx = 0;

			while(actual is object && idx < índiceFin) {
				if(índiceInicio <= idx)
					vector[idx - índiceInicio] = actual.Valor;

				actual = actual.Siguiente;
				idx++;
			}

			return vector;
		}

		/// <summary>
		/// Copia los elementos de la <see cref="ListaLigada"/> en un nuevo vector
		/// </summary>
		/// <returns>Un nuevo vector con los elementos de esta <see cref="ListaLigada{T}"/></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T[] AVector() {
			return this.AVector(0);
		}

		/// <summary>
		/// Copia los elementos de la <see cref="ListaLigada{T}"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <param name="destino">El vector al cual copiar los elementos de la <see cref="ListaLigada{T}"/></param>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(T[] destino, int índiceInicio = 0, int cantidad = -1) {
			if(this.Vacía)
				return;

			if(0 > índiceInicio || índiceInicio >= this.Cantidad)
				throw new ArgumentOutOfRangeException("El índice de inicio debe estar entre 0 y la cantidad de elementos de la Lista Ligada");

			int maxCantidad = this.Cantidad - índiceInicio;
			if(cantidad == -1 || cantidad > maxCantidad)
				cantidad = maxCantidad;

			if(destino.Length < cantidad)
				throw new ArgumentException("La cantidad indicada no cabe en el vector destino indicado");

			int índiceFin = índiceInicio + cantidad;
			NodoListaLigada<T> actual = this.cabeza;
			int idx = 0;

			while(actual is object && idx < índiceFin) {
				if(índiceInicio <= idx)
					destino[idx - índiceInicio] = actual.Valor;

				actual = actual.Siguiente;
				idx++;
			}
		}

		/// <summary>
		/// Realiza una búsqueda secuencial por los elementos de la <see cref="ListaLigada{T}"/> hasta encontrar un <see cref="NodoListaLigada{T}"/> con el valor indicado
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <param name="índice">Índice donde se encontró el valor por primera vez</param>
		/// <returns>El primer <see cref="NodoListaLigada{T}"/> coincidente, o <see langword="null"/> si no se encuentra ninguno</returns>
		protected NodoListaLigada<T> BuscarNodoPorValor(T valor, out int índice) {
			índice = -1;

			if(this.Vacía)
				return null;

			NodoListaLigada<T> encontrado = null;
			NodoListaLigada<T> actual = this.cabeza;
			int idx = 0;

			while(encontrado is null && actual is object) {
				if(actual.Valor.Equals(valor))
					encontrado = actual;
				else {
					actual = actual.Siguiente;
					idx++;
				}
			}

			if(encontrado is object)
				índice = idx;

			return encontrado;
		}

		/// <summary>
		/// Busca un <see cref="NodoListaLigada{T}"/> por índice en la <see cref="ListaLigada{T}"/> y lo devuelve
		/// </summary>
		/// <param name="índice">Índice deseado</param>
		/// <param name="valor">Valor que se encontró en el índice especificado</param>
		/// <returns>El <see cref="NodoListaLigada{T}"/> bajo el índice indicado</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		protected NodoListaLigada<T> BuscarNodoPorÍndice(int índice) {
			if(this.Vacía || índice < 0 || índice >= this.Cantidad)
				throw new ArgumentOutOfRangeException("El índice debe ser un entero positivo menor que la cantidad de elementos de la Lista");

			NodoListaLigada<T> nodo = this.cabeza;

			while(índice > 0 && nodo is object) {
				nodo = nodo.Siguiente;
				índice--;
			}

			return nodo;
		}

		/// <summary>
		/// Desreferencia un <see cref="NodoListaLigada"/> y enlaza sus <see cref="NodoListaLigada{T}"/> adyacentes adecuadamente
		/// </summary>
		/// <param name="aQuitar"><see cref="NodoListaLigada{T}"/> a quitar de la <see cref="ListaLigada{T}"/></param>
		protected virtual void QuitarNodoYRemediar(NodoListaLigada<T> aQuitar) {
			if(this.Vacía) return;

			if(aQuitar is null) return;

			if(aQuitar == this.cabeza) {
				this.cabeza = aQuitar.Siguiente;
			} else {
				NodoListaLigada<T> actual = this.cabeza;
				while(actual.Siguiente is object && actual.Siguiente != aQuitar) {
					actual = actual.Siguiente;
				}

				if(actual.Siguiente is object)
					actual.Siguiente = aQuitar.Siguiente;
			}

			this.Cantidad--;
		}
	}
}
