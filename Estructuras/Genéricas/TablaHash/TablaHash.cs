using System;
using System.Collections.Generic;

namespace Estructuras.Genéricas {
	[Serializable]
	public class TablaHash<TClave, TValor>: IDiccionario<TClave, TValor> {
		private NodoTablaHash<TClave, TValor>[] tabla;
		private readonly double coberturaMáxima;
		private readonly double factorCrecimiento;

		public int Cantidad { get; private set; }

		public int Capacidad {
			get { return this.tabla.Length; }
		}

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

		public TablaHash(int capacidad, double coberturaMáxima, double factorCrecimiento) {
			if(capacidad < 2)
				throw new ArgumentOutOfRangeException("La capacidad debe ser al menos 2");

			if(coberturaMáxima < 0.4 || coberturaMáxima >= 1)
				throw new ArgumentOutOfRangeException("La cobertura máxima debe ser un valor entre 0.5 inclusive y 1.0 exclusive");

			if(factorCrecimiento < 1.2 || factorCrecimiento > 4)
				throw new ArgumentOutOfRangeException("El factor de crecimiento debe ser un valor entre 1.2 y 4.0 inclusive");

			this.tabla = new NodoTablaHash<TClave, TValor>[capacidad];
			this.Cantidad = 0;
			this.coberturaMáxima = coberturaMáxima;
			this.factorCrecimiento = factorCrecimiento;
		}

		public TablaHash(int capacidad, double coberturaMáxima): this(capacidad, coberturaMáxima, 1.5) {}
		
		public TablaHash(int capacidad): this(capacidad, 0.8) {}

		public TablaHash(): this(12) {}

		public bool Insertar(TClave clave, TValor valor) {
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			if(Genérico.EsNulo(valor))
				throw new ArgumentNullException("El valor fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null) {
				this.tabla[idx] = new NodoTablaHash<TClave, TValor>(clave, valor);
				this.Cantidad++;
				this.ReescalarArriba();
				return true;
			}

			while(!nodo.Clave.Equals(clave) && nodo.Siguiente is object)
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
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> anterior = null;
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				return false;

			NodoTablaHash<TClave, TValor> aQuitar = null;
			while(aQuitar is null && nodo is object) {
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
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];
			encontrado = default;

			if(nodo is null)
				return false;

			bool encontró = false;
			while(!encontró && nodo is object) {
				if(nodo.Clave.Equals(clave)) {
					encontró = true;
					encontrado = nodo.Valor;
				} else
					nodo = nodo.Siguiente;
			}

			return encontró;
		}

		public TValor Encontrar(TClave clave) {
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				throw new KeyNotFoundException("La clave solicitada no existe");

			NodoTablaHash<TClave, TValor> encontrado = null;
			while(encontrado is null && nodo is object) {
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

			while(!encontrado && nodo.Siguiente is object) {
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

			while(!encontrado && nodo.Siguiente is object) {
				if(nodo.Clave.Equals(clave))
					encontrado = true;
				else
					nodo = nodo.Siguiente;
			}

			return encontrado;
		}

		public bool ContieneValor(TValor valor) {
			bool encontrado = false;

			NodoTablaHash<TClave, TValor> nodo;
			for(int i = 0; !encontrado && i < this.Capacidad; i++) {
				nodo = this.tabla[i];

				while(!encontrado && nodo is object) {
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

		public ParOrdenado<TClave, TValor>[] AVector(int índiceInicio, int cantidad = -1) {
			ParOrdenado<TClave, TValor>[] pares = new ParOrdenado<TClave, TValor>[this.Cantidad];

			NodoTablaHash<TClave, TValor> nodo;
			int c = índiceInicio;

			if(cantidad < 0)
				cantidad = this.Cantidad;

			for(int i = 0; c < cantidad && i < this.Capacidad; i++) {
				nodo = this.tabla[i];

				while(c < cantidad && nodo is object) {
					pares[c++] = nodo.AParOrdenado();
					nodo = nodo.Siguiente;
				}
			}

			return pares;
		}

		public ParOrdenado<TClave, TValor>[] AVector() {
			return this.AVector(0);
		}

		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino, int índiceInicio, int cantidad = -1) {
			NodoTablaHash<TClave, TValor> nodo;
			int c = índiceInicio;

			if(cantidad < 0)
				cantidad = this.Cantidad;

			for(int i = 0; c < cantidad && i < this.Capacidad; i++) {
				nodo = this.tabla[i];

				while(c < cantidad && nodo is object) {
					destino[c++] = nodo.AParOrdenado();
					nodo = nodo.Siguiente;
				}
			}
		}

		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino) {
			this.CopiarEn(destino, 0);
		}

		public void MinimizarCapacidad() {
			int nuevaCapacidad = (int)Math.Ceiling(this.Capacidad * this.Cobertura / this.coberturaMáxima);

			if(nuevaCapacidad < 2)
				return;

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

		private void ReescalarArriba() {
			if(this.Cobertura <= this.coberturaMáxima)
				return;

			int nuevaCapacidad = (int)Math.Ceiling(this.Capacidad * this.factorCrecimiento);

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

		private int Hashear(TClave clave) {
			int código = clave.GetHashCode();
			int idx = Math.Abs(código % this.Capacidad);
			return idx;
		}
	}
}
