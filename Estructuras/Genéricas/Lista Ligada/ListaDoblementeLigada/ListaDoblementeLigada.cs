using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos secuencial de carácter de lista en la cual cada elemento hace referencia al siguiente y anterior
	/// </summary>
	[Serializable]
	public class ListaDoblementeLigada<T>: ListaLigada<T> {
		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaDoblementeLigada{T}"/> cuyos valores iniciales son dados por el vector facilitado
		/// </summary>
		/// <param name="valores">Valores con los cuales inicializar la <see cref="ListaDoblementeLigada{T}"/></param>
		/// <remarks>Los valores se ingresan en el orden que fueron recibidos, siendo el primero la cabeza o principio y el último la cola o final</remarks>
		public ListaDoblementeLigada(T[] valores): base(valores) {}

		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaDoblementeLigada{T}"/> vacía
		/// </summary>
		public ListaDoblementeLigada(): base() {}

		public override int AgregarPrimero(T valor) {
			if(Genérico.EsNulo(valor))
				return -1;

			NodoListaLigada<T> nuevo = new NodoListaDoblementeLigada<T>(valor, this.cabeza);

			if(this.Vacía)
				this.cola = nuevo;
			else
				(this.cabeza as NodoListaDoblementeLigada<T>).Anterior = nuevo;

			this.cabeza = nuevo;

			return this.Cantidad++;
		}

		/// <inheritdoc cref="ListaLigada{T}.Agregar(object)"/>
		public override int Agregar(T valor) {
			if(Genérico.EsNulo(valor))
				return -1;

			NodoListaDoblementeLigada<T> nuevo = new NodoListaDoblementeLigada<T>(valor, this.cola, null);

			if(this.Vacía)
				this.cabeza = nuevo;
			else if(this.cabeza.Siguiente is null)
				this.cabeza.Siguiente = nuevo;
			else
				this.cola.Siguiente = nuevo;

			this.cola = nuevo;

			return this.Cantidad++;
		}

		/// <inheritdoc cref="ListaLigada{T}.Insertar(int, T)"/>
		public override void Insertar(int índice, T valor) {
			if(Genérico.EsNulo(valor))
				return;

			if(índice == this.Cantidad) {
				this.Agregar(valor);
				return;
			}

			NodoListaDoblementeLigada<T> siguiente = this.BuscarNodoPorÍndice(índice) as NodoListaDoblementeLigada<T>;
			NodoListaLigada<T> anterior = siguiente.Anterior;
			NodoListaLigada<T> nuevo = new NodoListaDoblementeLigada<T>(valor, anterior, siguiente);
			siguiente.Anterior = nuevo;

			if(anterior is object)
				anterior.Siguiente = nuevo;
			else
				this.cabeza = nuevo;

			this.Cantidad++;
		}

		/// <inheritdoc cref="ListaLigada{T}.QuitarPrimero()"/>
		public override T QuitarPrimero() {
			if(this.Vacía)
				return default;

			T quitado = this.cabeza.Valor;
			NodoListaDoblementeLigada<T> siguiente = this.cabeza.Siguiente as NodoListaDoblementeLigada<T>;

			if(siguiente is NodoListaLigada<T>)
				siguiente.Anterior = null;

			this.cabeza = siguiente;

			if(this.Vacía)
				this.cola = null;

			this.Cantidad--;

			return quitado;
		}

		/// <inheritdoc cref="ListaLigada{T}.QuitarÚltimo()"/>
		public override T QuitarÚltimo() {
			if(this.Vacía)
				return default;

			T quitado = this.cola.Valor;

			if(this.Cantidad == 1) {
				this.cabeza = this.cola = null;
			} else {
				NodoListaLigada<T> anterior = (this.cola as NodoListaDoblementeLigada<T>).Anterior;
				anterior.Siguiente = null;
				this.cola = anterior;
			}

			this.Cantidad--;

			return quitado;
		}

		/// <inheritdoc cref="ListaLigada{T}.QuitarNodoYRemediar(NodoListaLigada)"/>
		protected override void QuitarNodoYRemediar(NodoListaLigada<T> aQuitar) {
			if(this.Vacía) return;

			if(aQuitar is null)
				return;

			if(aQuitar == this.cabeza) {
				if(this.cabeza.Siguiente is object)
					(this.cabeza.Siguiente as NodoListaDoblementeLigada<T>).Anterior = null;

				this.cabeza = this.cabeza.Siguiente;

				if(this.Vacía)
					this.cola = null;
			} else {
				NodoListaLigada<T> actual = this.cabeza;

				while(actual.Siguiente is object && actual != aQuitar)
					actual = actual.Siguiente;

				if(actual is object) {
					NodoListaDoblementeLigada<T> encontrado = actual as NodoListaDoblementeLigada<T>;

					if(encontrado.Anterior is object)
						encontrado.Anterior.Siguiente = encontrado.Siguiente;

					if(encontrado.Siguiente is object)
						(encontrado.Siguiente as NodoListaDoblementeLigada<T>).Anterior = encontrado.Anterior;
					else
						this.cola = encontrado.Anterior;
				}
			}

			this.Cantidad--;
		}
	}
}
