using System;

namespace Estructuras.Genéricas {
	public class TablaHash<TClave, TValor>: IDiccionario<TClave, TValor> {
		private NodoTablaHash<TClave, TValor>[] tabla;
		private readonly double coberturaMáxima;

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

		public TValor this[TClave clave] => throw new NotImplementedException();

		public TablaHash(int capacidad, double coberturaMáxima) {
			this.tabla = new NodoTablaHash<TClave, TValor>[capacidad];
			this.Cantidad = 0;
			this.coberturaMáxima = coberturaMáxima;
		}
		
		public TablaHash(int capacidad) : this(capacidad, 0.8) {}

		public TablaHash(): this(12) {}

		public bool Agregar(TClave clave, TValor valor) {
			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is object) {
				while(!nodo.Clave.Equals(clave) && nodo.Siguiente is object)
					nodo = nodo.Siguiente;

				if(nodo.Clave.Equals(clave))
					return false;

				nodo.Siguiente = new NodoTablaHash<TClave, TValor>(clave, valor);
				this.Cantidad++;
				return true;
			}

			this.tabla[idx] = new NodoTablaHash<TClave, TValor>(clave, valor);
			this.Cantidad++;
			this.ReescalarArriba();
			return true;
		}

		public bool Quitar(TClave clave) {
			int idx = this.Hashear(clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				return false;

			NodoTablaHash<TClave, TValor> aQuitar = null;
			while(aQuitar is null && nodo.Siguiente is object) {
				if(nodo.Siguiente.Clave.Equals(clave))
					aQuitar = nodo.Siguiente;
				else
					nodo = nodo.Siguiente;
			}

			if(aQuitar is null)
				return false;

			nodo.Siguiente = aQuitar.Siguiente;
			this.Cantidad--;
			return true;
		}

		public bool Contiene(ParOrdenado<TClave, TValor> parOrdenado) {
			int idx = this.Hashear(parOrdenado.Clave);
			NodoTablaHash<TClave, TValor> nodo = this.tabla[idx];

			if(nodo is null)
				return false;

			bool encontrado = false;

			while(!encontrado && nodo.Siguiente is object) {
				if(nodo.Siguiente.Clave.Equals(parOrdenado.Clave) && nodo.Siguiente.Valor.Equals(parOrdenado.Valor))
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
				if(nodo.Siguiente.Clave.Equals(clave))
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

			for(int i = 0; c < cantidad; i++) {
				nodo = this.tabla[i];

				while(c < cantidad && nodo is object) {
					pares[c++] = nodo.AParOrdenado();
					nodo = nodo.Siguiente;
				}
			}

			return pares;
		}

		public ParOrdenado<TClave, TValor>[] AVector() {
			return this.AVector(-1);
		}

		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino, int índiceInicio, int cantidad = -1) {
			NodoTablaHash<TClave, TValor> nodo;
			int c = índiceInicio;

			if(cantidad < 0)
				cantidad = this.Cantidad;

			for(int i = 0; c < cantidad; i++) {
				nodo = this.tabla[i];

				while(c < cantidad && nodo is object) {
					destino[c++] = nodo.AParOrdenado();
					nodo = nodo.Siguiente;
				}
			}
		}

		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino) {
			this.CopiarEn(destino, -1);
		}

		private int Hashear(TClave clave) {
			int código = clave.GetHashCode();
			int idx = código % this.Capacidad;
			return idx;
		}

		public void MinimizarTamaño() {
			int nuevaCapacidad = (int)Math.Ceiling(this.Capacidad * this.Cobertura);

			NodoTablaHash<TClave, TValor>[] aux = this.tabla;
			this.tabla = new NodoTablaHash<TClave, TValor>[nuevaCapacidad];
			this.Cantidad = 0;
			foreach(NodoTablaHash<TClave, TValor> nodo in aux) {
				if(nodo is object)
					this.Agregar(nodo.Clave, nodo.Valor);
			}
		}

		private void ReescalarArriba() {
			if(this.Cobertura <= this.coberturaMáxima)
				return;

			int nuevaCapacidad = this.Capacidad * 2;

			NodoTablaHash<TClave, TValor>[] aux = this.tabla;
			this.tabla = new NodoTablaHash<TClave, TValor>[nuevaCapacidad];
			this.Cantidad = 0;
			foreach(NodoTablaHash<TClave, TValor> nodo in aux) {
				if(nodo is object)
					this.Agregar(nodo.Clave, nodo.Valor);
			}
		}
	}
}
