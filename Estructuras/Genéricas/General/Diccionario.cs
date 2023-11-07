using System;
using System.Collections.Generic;

namespace Estructuras.Genéricas {
	[Serializable]
	public class Diccionario<TClave, TValor>: IDiccionario<TClave, TValor> {
		private readonly int capacidadInicial;
		private ParOrdenado<TClave, TValor>[] entradas;

		public bool Vacío {
			get { return this.Cantidad == 0; }
		}

		public int Cantidad { get; private set; }

		public int Capacidad {
			get { return this.entradas.Length; }
		}

		public TClave[] Claves {
			get {
				int cnt = this.Cantidad;
				TClave[] claves = new TClave[cnt];

				for(int i = 0; i < cnt; i++)
					claves[i] = this.entradas[i].Clave;

				return claves;
			}
		}

		public TValor[] Valores {
			get {
				int cnt = this.Cantidad;
				TValor[] valores = new TValor[cnt];

				for(int i = 0; i < cnt; i++)
					valores[i] = this.entradas[i].Valor;

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
			this.entradas = new ParOrdenado<TClave, TValor>[capacidad];
			this.capacidadInicial = capacidad;
		}

		public Diccionario(): this(2) {}

		public bool Insertar(TClave clave, TValor valor) {
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			if(Genérico.EsNulo(valor))
				throw new ArgumentNullException("El valor fue null");

			int idx = this.BuscarEntrada(clave, out _);

			if(idx >= 0) {
				this.entradas[idx] = new ParOrdenado<TClave, TValor>(clave, valor);
				return false;
			}

			this.RedimensionarArriba();
			this.entradas[this.Cantidad++] = new ParOrdenado<TClave, TValor>(clave, valor);
			return true;
		}

		public bool Buscar(TClave clave, out TValor encontrado) {
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			ParOrdenado<TClave, TValor> existente;
			int idx = this.BuscarEntrada(clave, out existente);

			if(idx < 0) {
				encontrado = default;
				return false;
			}

			encontrado = existente.Valor;
			return true;
		}

		public TValor Encontrar(TClave clave) {
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			ParOrdenado<TClave, TValor> existente;
			this.BuscarEntrada(clave, out existente);

			if(existente is null)
				throw new KeyNotFoundException("La clave solicitada no existe");

			return existente.Valor;
		}

		public bool Quitar(TClave clave) {
			if(Genérico.EsNulo(clave))
				throw new ArgumentNullException("La clave fue null");

			int idx = this.BuscarEntrada(clave, out _);

			if(idx < 0)
				return false;

			this.entradas[idx] = this.entradas[--this.Cantidad];
			this.entradas[this.Cantidad] = null;
			this.RedimensionarAbajo();
			return true;
		}

		public bool ContieneClave(TClave clave) {
			return this.BuscarEntrada(clave, out _) >= 0;
		}

		/// <summary>
		/// Revisa el <see cref="Diccionario{TClave, TValor}"/> en busca del <paramref name="valor"/> especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		public bool ContieneValor(TValor valor) {
			bool contiene = false;
			int idx = 0;
			int cnt = this.Cantidad;

			while(!contiene && idx < cnt) {
				contiene = this.entradas[idx].Valor.Equals(valor);
				idx++;
			}

			return contiene;
		}

		public bool Contiene(ParOrdenado<TClave, TValor> entrada) {
			bool contiene = false;
			int idx = 0;
			int cnt = this.Cantidad;

			while(!contiene && idx < cnt) {
				contiene = this.entradas[idx].Clave.Equals(entrada.Clave)
					    && this.entradas[idx].Valor.Equals(entrada.Valor);

				idx++;
			}

			return contiene;
		}

		public void Limpiar() {
			this.entradas = new ParOrdenado<TClave, TValor>[this.capacidadInicial];
			this.Cantidad = 0;
		}

		/// <inheritdoc cref="IColección{T}.AVector()"/>AVector
		/// <remarks>Los pares clave-valor no tienen un orden de utilidad</remarks>
		public ParOrdenado<TClave, TValor>[] AVector() {
			int cnt = this.Cantidad;
			ParOrdenado<TClave, TValor>[] entradas = new ParOrdenado<TClave, TValor>[cnt];

			for(int i = 0; i < cnt; i++)
				entradas[i] = this.entradas[i];

			return entradas;
		}

		/// <inheritdoc cref="IColección{T}.CopiarEn(T[])"/>
		/// <remarks>Los pares clave-valor no tienen un orden de utilidad</remarks>
		public void CopiarEn(ParOrdenado<TClave, TValor>[] destino) {
			int cnt = this.Cantidad;
			for(int i = 0; i < cnt; i++)
				destino[i] = this.entradas[i];
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
			ParOrdenado<TClave, TValor>[] nuevoVec = new ParOrdenado<TClave, TValor>[nuevaCapacidad];

			for(int i = 0; i < this.Cantidad; i++)
				nuevoVec[i] = this.entradas[i];

			this.entradas = nuevoVec;
		}

		private int BuscarEntrada(TClave clave, out ParOrdenado<TClave, TValor> encontrado) {
			encontrado = null;

			int idx = 0;
			int cnt = this.Cantidad;

			while(encontrado is null && idx < cnt) {
				if(this.entradas[idx].Clave.Equals(clave))
					encontrado = this.entradas[idx];
				else
					idx++;
			}

			if(encontrado is null)
				return -1;

			return idx;
		}
	}
}
