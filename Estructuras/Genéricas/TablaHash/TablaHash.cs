using System;
using System.Collections.Generic;

namespace Estructuras.Genéricas {
	[Serializable]
	public class TablaHash<TClave, TValor>: IDiccionario<TClave, TValor> where TClave: IEquatable<TClave> {
		private NodoTablaHash<TClave, TValor>[] tabla;
		private readonly double coberturaMáxima;
		private readonly double factorCrecimiento;
		private readonly int capacidadInicial;

		public bool Vacía {
			get { return this.Cantidad == 0; }
		}

		public int Cantidad { get; private set; }

		/// <summary>
		/// Indica el límite de índices que puede contener la <see cref="TablaHash{TClave, TValor}"/>
		/// </summary>
		/// <remarks>Esto no representa la cantidad de elementos de la colección. Usa <see cref="Cantidad"/> para obtener eso</remarks>
		public int Capacidad {
			get { return this.tabla.Length; }
		}

		/// <summary>
		/// Indica el porcentaje de cobertura de los índices de la <see cref="TablaHash{TClave, TValor}"/>
		/// </summary>
		public double Cobertura {
			get {
				int cnt = 0;

				for(int i = 0; i < this.Capacidad; i++) {
					if(this.tabla[i] is object)
						cnt++;
				}

				return 1d * cnt / this.Capacidad;
			}
		}

		public TClave[] Claves {
			get {
				TClave[] claves = new TClave[this.Cantidad];

				NodoTablaHash<TClave, TValor> nodo;
				int c = 0;
				for(int i = 0; i < this.Capacidad; i++) {
					nodo = this.tabla[i];

					while(nodo is object) {
						claves[c++] = nodo.Clave;
						nodo = nodo.Siguiente;
					}
				}

				return claves;
			}
		}

		public TValor[] Valores {
			get {
				TValor[] valores = new TValor[this.Cantidad];

				NodoTablaHash<TClave, TValor> nodo;
				int c = 0;
				for(int i = 0; i < this.Capacidad; i++) {
					nodo = this.tabla[i];

					while(nodo is object) {
						valores[c++] = nodo.Valor;
						nodo = nodo.Siguiente;
					}
				}

				return valores;
			}
		}

		public TValor this[TClave clave] {
			get {
				return this.Encontrar(clave);
			}
			set {
				this.Insertar(clave, value);
			}
		}

		/// <summary>
		/// Crea una nueva instancia de <see cref="TablaHash{TClave, TValor}"/> vacía,
		/// con la <paramref name="capacidad"/> especificada y el manejo indicado de la misma
		/// </summary>
		/// <param name="capacidad">Cantidad de índices que alberga la <see cref="TablaHash{TClave, TValor}"/> inicialmente</param>
		/// <param name="coberturaMáxima">Porcentaje de cobertura de los índices en el cual se realizará una redimensión de capacidad</param>
		/// <param name="factorCrecimiento">El factor de crecimiento de la capacidad al realizar una redimensión</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public TablaHash(int capacidad, double coberturaMáxima, double factorCrecimiento) {
			if(capacidad < 2)
				throw new ArgumentOutOfRangeException("La capacidad debe ser al menos 2");

			if(coberturaMáxima < 0.4 || coberturaMáxima >= 1)
				throw new ArgumentOutOfRangeException("La cobertura máxima debe ser un valor entre 0.5 inclusive y 1.0 exclusive");

			if(factorCrecimiento < 1.2 || factorCrecimiento > 4)
				throw new ArgumentOutOfRangeException("El factor de crecimiento debe ser un valor entre 1.2 y 4.0 inclusive");

			if(capacidad % 2 != 0)
				capacidad++;

			this.tabla = new NodoTablaHash<TClave, TValor>[capacidad];
			this.capacidadInicial = this.Capacidad;
			this.Cantidad = 0;
			this.coberturaMáxima = coberturaMáxima;
			this.factorCrecimiento = factorCrecimiento;
		}

		/// <summary>
		/// Crea una nueva instancia de <see cref="TablaHash{TClave, TValor}"/> vacía,
		/// con la <paramref name="capacidad"/> y porcentaje de <paramref name="coberturaMáxima"/> especificados.
		/// </summary>
		/// <remarks>Las redimensiones de la tabla se harán con un factor de crecimiento de 1.5</remarks>
		/// <param name="capacidad">Cantidad de índices que alberga la <see cref="TablaHash{TClave, TValor}"/> inicialmente</param>
		/// <param name="coberturaMáxima">Porcentaje de cobertura de los índices en el cual se realizará una redimensión de capacidad</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public TablaHash(int capacidad, double coberturaMáxima): this(capacidad, coberturaMáxima, 1.5) {}

		/// <summary>
		/// Crea una nueva instancia de <see cref="TablaHash{TClave, TValor}"/> vacía, con la <paramref name="capacidad"/> especificada
		/// </summary>
		/// <remarks>Las redimensiones de la tabla se harán al superar una cobertura de 0.8, con crecimiento de x1.5</remarks>
		/// <param name="capacidad">Cantidad de índices que alberga la <see cref="TablaHash{TClave, TValor}"/> inicialmente</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public TablaHash(int capacidad): this(capacidad, 0.8) {}

		/// <summary>
		/// Crea una nueva instancia de <see cref="TablaHash{TClave, TValor}"/> vacía, con una capacidad inicial de 12 índices
		/// </summary>
		/// <remarks>Las redimensiones de la tabla se harán al superar una cobertura de 0.8, con crecimiento de x1.5</remarks>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public TablaHash(): this(12) {}

		public bool Insertar(TClave clave, TValor valor) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			if(valor == null)
				throw new ArgumentNullException("El valor fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null) {
				this.tabla[idx] = new NodoTablaHash<TClave, TValor>(clave, valor);
				this.Cantidad++;
				this.RedimensionarArriba();
				return true;
			}

			while(!(nodo.Siguiente is null || nodo.Clave.Equals(clave)))
				nodo = nodo.Siguiente;

			if(nodo.Clave.Equals(clave)) {
				nodo.Valor = valor;
				return false;
			}

			nodo.Siguiente = new NodoTablaHash<TClave, TValor>(clave, valor);
			this.Cantidad++;
			return true;
		}

		public bool Quitar(TClave clave) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				return false;

			NodoTablaHash<TClave, TValor> anterior = null;
			NodoTablaHash<TClave, TValor> aQuitar = null;
			while(aQuitar is null && !(nodo is null)) {
				if(nodo.Clave.Equals(clave))
					aQuitar = nodo;
				else {
					anterior = nodo;
					nodo = nodo.Siguiente;
				}
			}

			if(aQuitar is null)
				return false;

			if(anterior is null)
				this.tabla[idx] = nodo.Siguiente;
			else
				anterior.Siguiente = aQuitar.Siguiente;

			this.Cantidad--;
			return true;
		}

		public bool Buscar(TClave clave, out TValor encontrado) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];
			encontrado = default;

			if(nodo is null)
				return false;

			bool encontró = false;
			while(!(encontró || nodo is null)) {
				if(nodo.Clave.Equals(clave)) {
					encontró = true;
					encontrado = nodo.Valor;
				} else
					nodo = nodo.Siguiente;
			}

			return encontró;
		}

		public TValor Encontrar(TClave clave) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				throw new KeyNotFoundException("La clave solicitada no existe");

			NodoTablaHash<TClave, TValor> encontrado = null;
			while(encontrado is null && !(nodo is null)) {
				if(nodo.Clave.Equals(clave))
					encontrado = nodo;
				else
					nodo = nodo.Siguiente;
			}

			if(encontrado is null)
				throw new KeyNotFoundException("La clave solicitada no existe");

			return encontrado.Valor;
		}

		public bool Contiene(ParOrdenado<TClave, TValor> parOrdenado) {
			int idx = this.Hashear(parOrdenado.Clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				return false;

			bool encontrado = false;

			while(!(encontrado || nodo is null)) {
				if(nodo.Clave.Equals(parOrdenado.Clave) && nodo.Valor.Equals(parOrdenado.Valor))
					encontrado = true;
				else
					nodo = nodo.Siguiente;
			}

			return encontrado;
		}

		public bool ContieneClave(TClave clave) {
			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				return false;

			bool encontrado = false;

			while(!(encontrado || nodo is null)) {
				if(nodo.Clave.Equals(clave))
					encontrado = true;
				else
					nodo = nodo.Siguiente;
			}

			return encontrado;
		}

		/// <summary>
		/// Revisa la <see cref="TablaHash{TClave, TValor}"/> en busca del <paramref name="valor"/> especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool ContieneValor(TValor valor) {
			bool encontrado = false;

			NodoTablaHash<TClave, TValor> nodo;
			for(int i = 0; !encontrado && i < this.Capacidad; i++) {
				nodo = this.tabla[i];

				while(!(encontrado || nodo is null)) {
					if(nodo.Valor.Equals(valor))
						encontrado = true;
					else
						nodo = nodo.Siguiente;
				}
			}

			return encontrado;
		}

		public void Limpiar() {
			for(int i = 0; i < this.Capacidad; i++)
				this.tabla[i] = null;

			this.Cantidad = 0;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="TablaHash{TClave, TValor}"/> y restaura su capacidad inicial
		/// </summary>
		public void Reestablecer() {
			this.tabla = new NodoTablaHash<TClave, TValor>[this.capacidadInicial];
			this.Cantidad = 0;
		}

		/// <inheritdoc cref="IColección{T}.AVector()"/>
		/// <remarks>Los pares clave-valor no tienen un orden de utilidad</remarks>
		public ParOrdenado<TClave, TValor>[] AVector() {
			ParOrdenado<TClave, TValor>[] pares = new ParOrdenado<TClave, TValor>[this.Cantidad];
			this.CopiarEn(pares);
			return pares;
		}

		/// <inheritdoc cref="IColección{T}.CopiarEn(T[])"/>
		/// <remarks>Los pares clave-valor no tienen un orden de utilidad</remarks>
		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino) {
			NodoTablaHash<TClave, TValor> nodo;

			int c = 0;
			for(int i = 0; i < this.Capacidad; i++) {
				nodo = this.tabla[i];

				while(nodo is object) {
					destino[c++] = nodo.AParOrdenado();
					nodo = nodo.Siguiente;
				}
			}
		}

		/// <summary>
		/// Recalcula la capacidad de la <see cref="TablaHash{TClave, TValor}"/> a un mínimo estable predecido
		/// </summary>
		/// <remarks>Requiere realocar todas las entradas y el tamaño resultante puede ser mayor al actual</remarks>
		public void MinimizarCapacidad() {
			int nuevaCapacidad = (int)Math.Ceiling(this.Capacidad * this.Cobertura / this.coberturaMáxima);

			if(nuevaCapacidad < 2)
				return;

			if(nuevaCapacidad % 2 != 0)
				nuevaCapacidad++;

			//Reconstruir tabla con nuevo tamaño
			NodoTablaHash<TClave, TValor>[] aux = this.tabla;
			this.tabla = new NodoTablaHash<TClave, TValor>[nuevaCapacidad];
			this.Cantidad = 0;
			foreach(NodoTablaHash<TClave, TValor> nodo in aux) {
				NodoTablaHash<TClave, TValor> n = nodo;
				while(n is object) {
					this.Insertar(n.Clave, n.Valor);
					n = n.Siguiente;
				}
			}
		}

		/// <summary>
		/// Verifica si hay que redimensionar la <see cref="TablaHash{TClave, TValor}"/>.
		/// Si es el caso, la capacidad incrementa en función del factor de crecimiento
		/// </summary>
		/// <remarks>Redimensionar la tabla involucra reingresar todas las entradas, por lo que debe regularse cuidadosamente</remarks>
		private void RedimensionarArriba() {
			if(this.Cobertura <= this.coberturaMáxima)
				return;

			int nuevaCapacidad = (int)Math.Ceiling(this.Capacidad * this.factorCrecimiento);

			if(nuevaCapacidad % 2 != 0)
				nuevaCapacidad++;

			//Reconstruir tabla con nuevo tamaño
			NodoTablaHash<TClave, TValor>[] aux = this.tabla;
			this.tabla = new NodoTablaHash<TClave, TValor>[nuevaCapacidad];
			this.Cantidad = 0;

			foreach(NodoTablaHash<TClave, TValor> nodo in aux) {
				NodoTablaHash<TClave, TValor> n = nodo;
				while(!(n is null)) {
					this.Insertar(n.Clave, n.Valor);
					n = n.Siguiente;
				}
			}
		}

		/// <summary>
		/// Llama <see cref="object.GetHashCode()"/> para la <paramref name="clave"/> especificada
		/// y restringe el resultado a la capacidad de la <see cref="TablaHash{TClave, TValor}"/>, actuando como un índice
		/// </summary>
		/// <remarks>El índice de tabla obtenido siempre va a ser válido</remarks>
		/// <param name="clave">Clave usada para el cálculo de Hash</param>
		/// <returns>El índice de tabla calculado para la clave ingresada</returns>
		private int Hashear(TClave clave) {
			int código = clave.GetHashCode();
			int idx = código % this.Capacidad;
			return (idx + (idx >> 31)) ^ (idx >> 31); //Cosa horrible con bits para valor absoluto
		}
	}
}
