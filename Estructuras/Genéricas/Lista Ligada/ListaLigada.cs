using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos secuencial de carácter de lista en la cual cada elemento hace referencia al siguiente
	/// </summary>
	[Serializable]
	public class ListaLigada {
		protected NodoListaLigada cabeza;
		protected NodoListaLigada cola;

		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaLigada"/> cuyos valores iniciales son dados por el vector facilitado
		/// </summary>
		/// <remarks>Los valores se ingresan en el orden que fueron recibidos, siendo el primero la cabeza o principio y el último la cola o final</remarks>
		public ListaLigada(object[] valores) {
			this.cabeza = null;
			foreach(object valor in valores)
				this.AgregarÚltimo(valor);
		}

		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaLigada"/> vacía
		/// </summary>
		public ListaLigada() {
			this.cabeza = null;
			this.cola = null;
		}

		/// <summary>
		/// Determina si la <see cref="ListaLigada"/> está vacía (<see langword="true"/>) o no (<see langword="false"/>)
		/// </summary>
		public bool Vacía {
			get { return this.cabeza is null; }
		}

		/// <summary>
		/// Indica la cantidad de elementos involucrados en la <see cref="ListaLigada"/>
		/// </summary>
		public int Cantidad { get; protected set; } = 0;

		/// <summary>
		/// Devuelve el primer valor de la <see cref="ListaLigada"/>
		/// </summary>
		public object PrimerValor {
			get {
				if(this.Vacía)
					return null;

				return this.cabeza.Valor;
			}
		}

		/// <summary>
		/// Devuelve el último valor de la <see cref="ListaLigada"/>
		/// </summary>
		public object ÚltimoValor {
			get {
				if(this.Vacía)
					return null;

				return this.cola.Valor;
			}
		}

		/// <summary>
		/// Accede un elemento de la <see cref="ListaLigada"/>
		/// </summary>
		/// <param name="idx">Índice del elemento en la <see cref="ListaLigada"/></param>
		/// <returns>Elemento en la posición especificada</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object this[int idx] {
			get {
				return this.BuscarNodoPorÍndice(idx);
			}
			set {
				this.BuscarNodoPorÍndice(idx).Valor = value;
			}
		}

		/// <summary>
		/// Revisa la Lista Ligada en busca del valor especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool Contiene(object valor) {
			if(valor is null) return false;

			return this.BuscarNodoPorValor(valor, out _) is NodoListaLigada;
		}

		/// <summary>
		/// Agrega un valor a la cabeza o el principio de la <see cref="ListaLigada"/>
		/// </summary>
		/// <param name="valor">Valor a insertar</param>
		/// <returns>La posición en la que se insertó el nuevo elemento, ó -1 si no se insertó nada</returns>
		public virtual int AgregarPrimero(object valor) {
			if(valor is null) return -1;

			NodoListaLigada nuevo = new NodoListaLigada(valor, this.cabeza);

			if(this.Vacía)
				this.cola = nuevo;

			this.cabeza = nuevo;

			return this.Cantidad++;
		}

		/// <summary>
		/// Agrega un valor a la cola o final de la <see cref="ListaLigada"/>
		/// </summary>
		/// <param name="valor">Valor a insertar</param>
		/// <returns>La posición en la que se insertó el nuevo elemento, ó -1 si no se insertó nada</returns>
		public virtual int AgregarÚltimo(object valor) {
			if(valor is null) return -1;

			NodoListaLigada nuevo = new NodoListaLigada(valor);

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
		public virtual void Insertar(int índice, object valor) {
			if(valor is null) return;

			if(índice == this.Cantidad) {
				this.AgregarÚltimo(valor);
				return;
			}

			NodoListaLigada anterior;
			NodoListaLigada siguiente;

			if(índice == 0) {
				anterior = null;
				siguiente = this.BuscarNodoPorÍndice(índice);
			} else {
				anterior = this.BuscarNodoPorÍndice(índice - 1);
				siguiente = anterior.Siguiente;
			}

			NodoListaLigada nuevo = new NodoListaLigada(valor, siguiente);

			if(anterior is NodoListaLigada) {
				anterior.Siguiente = nuevo;
			} else
				this.cabeza = nuevo;

			this.Cantidad++;
		}

		/// <summary>
		/// Quita el primer elemento de la <see cref="ListaLigada"/> y lo devuelve
		/// </summary>
		/// <returns>El valor quitado, o <see langword="null"/> si la <see cref="ListaLigada"/> está vacía</returns>
		public virtual object QuitarPrimero() {
			if(this.Vacía)
				return null;

			object quitado = this.cabeza.Valor;
			this.cabeza = this.cabeza.Siguiente;

			if(this.Vacía)
				this.cola = null;

			this.Cantidad--;

			return quitado;
		}


		/// <summary>
		/// Quita el último elemento de la <see cref="ListaLigada"/> y lo devuelve
		/// </summary>
		/// <returns>El valor quitado, o <see langword="null"/> si la <see cref="ListaLigada"/> está vacía</returns>
		public virtual object QuitarÚltimo() {
			if(this.Vacía)
				return null;

			object quitado = this.cola.Valor;

			if(this.Cantidad == 1) {
				this.cabeza = this.cola = null;
			} else {
				NodoListaLigada anterior = this.BuscarNodoPorÍndice(this.Cantidad - 2);
				anterior.Siguiente = null;
			}

			this.Cantidad--;

			return quitado;
		}

		/// <summary>
		/// Quita la primer instancia del valor especificado y devuelve su índice, si se encuentra
		/// </summary>
		/// <param name="valor">Valor a quitar</param>
		/// <returns>El índice del valor quitado de la <see cref="ListaLigada"/>, ó -1 si no se quitó nada</returns>
		public int Quitar(object valor) {
			if(this.Vacía)
				return -1;

			int idx;
			NodoListaLigada aQuitar = this.BuscarNodoPorValor(valor, out idx);
			this.QuitarNodoYRemediar(aQuitar);
			return idx;
		}

		/// <summary>
		/// Quita el elemento en el índice especificado
		/// </summary>
		/// <param name="índice">Índice en el cual remover un elemento</param>
		/// <returns>El valor quitado de la <see cref="ListaLigada"/></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object QuitarEn(int índice) {
			NodoListaLigada aQuitar = this.BuscarNodoPorÍndice(índice);
			this.QuitarNodoYRemediar(aQuitar);
			return aQuitar.Valor;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="ListaLigada"/>
		/// </summary>
		public void Limpiar() {
			this.cabeza = null;
			this.cola = null;
			this.Cantidad = 0;
		}

		/// <summary>
		/// Busca un elemento por índice en la <see cref="ListaLigada"/> y devuelve su valor
		/// </summary>
		/// <param name="índice">Índice deseado</param>
		/// <returns>El valor del elemento en la posición del índice especificado</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object ValorEn(int índice) {
			return this.BuscarNodoPorÍndice(índice).Valor;
		}

		/// <summary>
		/// Busca un elemento por valor en la <see cref="ListaLigada"/> y devuelve el índice de la primer aparición
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns>El índice de la primera instancia encontrada, o -1 si no se encuentra una</returns>
		public int ÍndiceDe(object valor) {
			if(valor is null) return -1;

			int idx;
			this.BuscarNodoPorValor(valor, out idx);
			return idx;
		}

		/// <summary>
		/// Copia los elementos de la <see cref="ListaLigada"/> en un nuevo vector
		/// </summary>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar</param>
		/// <returns>Un nuevo vector con los elementos de esta <see cref="ListaLigada"/></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public object[] AVector(int índiceInicio = 0, int cantidad = -1) {
			if(this.Vacía)
				return new object[0];

			if(cantidad == -1)
				cantidad = this.Cantidad - índiceInicio;

			if(0 > índiceInicio || índiceInicio >= this.Cantidad)
				throw new ArgumentOutOfRangeException("El índice de inicio debe estar entre 0 y la cantidad de elementos de la Lista Ligada");

			cantidad -= cantidad + índiceInicio - this.Cantidad;
			int índiceFin = índiceInicio + cantidad;
			object[] vector = new object[cantidad];
			NodoListaLigada actual = this.cabeza;
			int idx = 0;

			while(actual is NodoListaLigada && idx < índiceFin) {
				if(índiceInicio <= idx)
					vector[idx - índiceInicio] = actual.Valor;

				actual = actual.Siguiente;
				idx++;
			}

			return vector;
		}

		/// <summary>
		/// Copia los elementos de la <see cref="ListaLigada"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <param name="destino">El vector al cual copiar los elementos de la <see cref="ListaLigada"/></param>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(object[] destino, int índiceInicio = 0, int cantidad = -1) {
			if(this.Vacía)
				return;

			if(cantidad == -1)
				cantidad = this.Cantidad - índiceInicio;

			if(0 > índiceInicio || índiceInicio >= this.Cantidad)
				throw new ArgumentOutOfRangeException("El índice de inicio debe estar entre 0 y la cantidad de elementos de la Lista Ligada");

			cantidad -= cantidad + índiceInicio - this.Cantidad;

			if(destino.Length < cantidad)
				throw new ArgumentException("La cantidad indicada no cabe en el vector destino indicado");

			int índiceFin = índiceInicio + cantidad;
			NodoListaLigada actual = this.cabeza;
			int idx = 0;

			while(actual is NodoListaLigada && idx < índiceFin) {
				if(índiceInicio <= idx)
					destino[idx - índiceInicio] = actual.Valor;

				actual = actual.Siguiente;
				idx++;
			}
		}

		/// <summary>
		/// Realiza una búsqueda secuencial por los elementos de la <see cref="ListaLigada"/> hasta encontrar un <see cref="NodoListaLigada"/> con el valor indicado
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <param name="índice">Índice donde se encontró el valor por primera vez</param>
		/// <returns>El primer <see cref="NodoListaLigada"/> coincidente, o <see langword="null"/> si no se encuentra ninguno</returns>
		protected NodoListaLigada BuscarNodoPorValor(object valor, out int índice) {
			índice = -1;

			if(this.Vacía) return null;

			NodoListaLigada encontrado = null;
			NodoListaLigada actual = this.cabeza;
			int idx = 0;

			while(encontrado is null && actual is NodoListaLigada) {
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
		/// Busca un <see cref="NodoListaLigada"/> por índice en la <see cref="ListaLigada"/> y lo devuelve
		/// </summary>
		/// <param name="índice">Índice deseado</param>
		/// <param name="valor">Valor que se encontró en el índice especificado</param>
		/// <returns>El <see cref="NodoListaLigada"/> bajo el índice indicado</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		protected NodoListaLigada BuscarNodoPorÍndice(int índice) {
			if(this.Vacía || índice < 0 || índice >= this.Cantidad)
				throw new ArgumentOutOfRangeException("El índice debe ser un entero positivo menor que la cantidad de elementos de la Lista");

			NodoListaLigada nodo = this.cabeza;

			while(índice > 0 && nodo is NodoListaLigada) {
				nodo = nodo.Siguiente;
				índice--;
			}

			return nodo;
		}

		/// <summary>
		/// Desreferencia un <see cref="NodoListaLigada"/> y enlaza sus <see cref="NodoListaLigada"/> adyacentes adecuadamente
		/// </summary>
		/// <param name="aQuitar"><see cref="NodoListaLigada"/> a quitar de la <see cref="ListaLigada"/></param>
		protected virtual void QuitarNodoYRemediar(NodoListaLigada aQuitar) {
			if(this.Vacía) return;

			if(aQuitar is null) return;

			if(aQuitar == this.cabeza) {
				this.cabeza = aQuitar.Siguiente;
			} else {
				NodoListaLigada actual = this.cabeza;
				while(actual.Siguiente is NodoListaLigada && actual.Siguiente != aQuitar) {
					actual = actual.Siguiente;
				}

				if(actual.Siguiente is NodoListaLigada)
					actual.Siguiente = aQuitar.Siguiente;
			}

			this.Cantidad--;
		}
	}
}
