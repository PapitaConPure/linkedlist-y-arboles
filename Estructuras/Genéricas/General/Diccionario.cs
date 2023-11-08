using System;
using System.Collections.Generic;

namespace Estructuras.Genéricas {
	[Serializable]
	public class Diccionario<TClave, TValor>: IDiccionario<TClave, TValor> {
		private readonly int capacidadInicial;
		private TClave[] claves;
		private TValor[] valores;

		public bool Vacío {
			get { return this.Cantidad == 0; }
		}

		public int Cantidad { get; private set; }

		public int Capacidad {
			get { return this.claves.Length; }
		}

		public TClave[] Claves {
			get {
				int cnt = this.Cantidad;
				TClave[] claves = new TClave[cnt];

				for(int i = 0; i < cnt; i++)
					claves[i] = this.claves[i];

				return this.claves;
			}
		}

		public TValor[] Valores {
			get {
				int cnt = this.Cantidad;
				TValor[] valores = new TValor[cnt];

				for(int i = 0; i < cnt; i++)
					valores[i] = this.valores[i];

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

		public Diccionario(int capacidad) {
			this.claves = new TClave[capacidad];
			this.valores = new TValor[capacidad];
			this.capacidadInicial = capacidad;
		}

		public Diccionario(): this(2) {}

		public bool Insertar(TClave clave, TValor valor) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			if(valor == null)
				throw new ArgumentNullException("El valor fue null");

			int idx = this.BuscarEntrada(clave);

			if(idx >= 0) {
				this.valores[idx] = valor;
				return false;
			}

			this.RedimensionarArriba();
			this.claves[this.Cantidad] = clave;
			this.valores[this.Cantidad++] = valor;
			return true;
		}

		public bool Buscar(TClave clave, out TValor encontrado) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			int idx = this.BuscarEntrada(clave);

			if(idx < 0) {
				encontrado = default;
				return false;
			}

			encontrado = this.valores[idx];
			return true;
		}

		public TValor Encontrar(TClave clave) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			int idx = this.BuscarEntrada(clave);

			if(idx < 0)
				throw new KeyNotFoundException("La clave solicitada no existe");

			return this.valores[idx];
		}

		public bool Quitar(TClave clave) {
			if(clave == null)
				throw new ArgumentNullException("La clave fue null");

			int idx = this.BuscarEntrada(clave);

			if(idx < 0)
				return false;

			this.claves[idx] = this.claves[--this.Cantidad];
			this.valores[idx] = this.valores[this.Cantidad];
			this.RedimensionarAbajo();
			return true;
		}

		public bool ContieneClave(TClave clave) {
			return this.BuscarEntrada(clave) >= 0;
		}

		/// <summary>
		/// Revisa el <see cref="Diccionario{TClave, TValor}"/> en busca del <paramref name="valor"/> especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool ContieneValor(TValor valor) {
			if(valor == null)
				return false;

			bool contiene = false;
			int idx = 0;
			int cnt = this.Cantidad;

			while(!contiene && idx < cnt) {
				contiene = this.valores[idx].Equals(valor);
				idx++;
			}

			return contiene;
		}

		public bool Contiene(ParOrdenado<TClave, TValor> entrada) {
			bool contiene = false;
			int idx = 0;
			int cnt = this.Cantidad;

			while(!contiene && idx < cnt) {
				contiene = this.claves[idx].Equals(entrada.Clave)
					    && this.valores[idx].Equals(entrada.Valor);

				idx++;
			}

			return contiene;
		}

		public void Limpiar() {
			this.claves = new TClave[this.capacidadInicial];
			this.valores = new TValor[this.capacidadInicial];
			this.Cantidad = 0;
		}

		/// <inheritdoc cref="IColección{T}.AVector()"/>AVector
		/// <remarks>Los pares clave-valor no tienen un orden de utilidad</remarks>
		public ParOrdenado<TClave, TValor>[] AVector() {
			int cnt = this.Cantidad;
			ParOrdenado<TClave, TValor>[] entradas = new ParOrdenado<TClave, TValor>[cnt];

			for(int i = 0; i < cnt; i++)
				entradas[i] = new ParOrdenado<TClave, TValor>(this.claves[i], this.valores[i]);

			return entradas;
		}

		/// <inheritdoc cref="IColección{T}.CopiarEn(T[])"/>
		/// <remarks>Los pares clave-valor no tienen un orden de utilidad</remarks>
		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino) {
			int cnt = this.Cantidad;
			for(int i = 0; i < cnt; i++)
				destino[i] = new ParOrdenado<TClave, TValor>(this.claves[i], this.valores[i]);
		}

		public void MinimizarTamaño() {
			if(this.Cantidad == this.Capacidad)
				return;

			this.Redimensionar(this.Cantidad);
		}

		private void RedimensionarArriba() {
			if(this.Cantidad < this.Capacidad)
				return;

			this.Redimensionar(this.Capacidad * 2);
		}

		private void RedimensionarAbajo() {
			int mitad = this.Capacidad / 2;

			if(this.Cantidad > mitad || mitad < 1)
				return;

			this.Redimensionar(mitad);
		}

		private void Redimensionar(int nuevaCapacidad) {
			TClave[] dClaves = new TClave[nuevaCapacidad];
			TValor[] dValores = new TValor[nuevaCapacidad];

			for(int i = 0; i < this.Cantidad; i++) {
				dClaves[i] = this.claves[i];
				dValores[i] = this.valores[i];
			}

			this.claves = dClaves;
			this.valores = dValores;
		}

		private int BuscarEntrada(TClave clave) {
			int idx = 0;
			int cnt = this.Cantidad;

			while(idx < cnt) {
				if(this.claves[idx].Equals(clave))
					return idx;
				else
					idx++;
			}

			return -1;
		}
	}
}
