using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos secuencial de carácter de lista en la cual cada elemento hace referencia al siguiente y anterior
	/// </summary>
	[Serializable]
	public class ListaDoblementeLigada: ListaLigada {
		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaDoblementeLigada"/> cuyos valores iniciales son dados por el vector facilitado
		/// </summary>
		/// <remarks>Los valores se ingresan en el orden que fueron recibidos, siendo el primero la cabeza o principio y el último la cola o final</remarks>
		public ListaDoblementeLigada(object[] valores): base(valores) {}


		/// <summary>
		/// Crea una nueva instancia de <see cref="ListaDoblementeLigada"/> vacía
		/// </summary>
		public ListaDoblementeLigada(): base() {}

		/// <inheritdoc cref="ListaLigada.AgregarÚltimo(object)"/>
		public override int AgregarÚltimo(object valor) {
			if(valor is null) return -1;

			NodoListaDoblementeLigada nuevo = new NodoListaDoblementeLigada(valor, this.cola, null);

			if(this.Vacía)
				this.cabeza = nuevo;
			else if(this.cabeza.Siguiente is null)
				this.cabeza.Siguiente = nuevo;
			else
				this.cola.Siguiente = nuevo;

			this.cola = nuevo;

			return this.Cantidad++;
		}

		/// <inheritdoc cref="ListaLigada.Insertar(int, object)"/>
		public override void Insertar(int índice, object valor) {
			if(valor is null) return;

			if(índice == this.Cantidad) {
				this.AgregarÚltimo(valor);
				return;
			}

			NodoListaLigada siguiente = this.BuscarNodoPorÍndice(índice);
			NodoListaLigada anterior = (siguiente as NodoListaDoblementeLigada).Anterior;
			NodoListaLigada nuevo = new NodoListaLigada(valor, siguiente);
			(siguiente as NodoListaDoblementeLigada).Anterior = nuevo;

			if(anterior is NodoListaLigada)
				anterior.Siguiente = nuevo;
			else
				this.cabeza = nuevo;

			this.Cantidad++;
		}

		/// <inheritdoc cref="ListaLigada.QuitarPrimero()"/>
		public override object QuitarPrimero() {
			if(this.Vacía)
				return null;

			object quitado = this.cabeza.Valor;
			NodoListaDoblementeLigada siguiente = this.cabeza.Siguiente as NodoListaDoblementeLigada;

			if(siguiente is NodoListaLigada)
				siguiente.Anterior = null;

			this.cabeza = siguiente;

			if(this.Vacía)
				this.cola = null;

			this.Cantidad--;

			return quitado;
		}

		/// <inheritdoc cref="ListaLigada.QuitarÚltimo()"/>
		public override object QuitarÚltimo() {
			if(this.Vacía)
				return null;

			object quitado = this.cola.Valor;

			if(this.Cantidad == 1) {
				this.cabeza = this.cola = null;
			} else {
				NodoListaLigada anterior = (this.cola as NodoListaDoblementeLigada).Anterior;
				anterior.Siguiente = null;
				this.cola = anterior;
			}

			this.Cantidad--;

			return quitado;
		}

		/// <inheritdoc cref="ListaLigada.QuitarNodoYRemediar(NodoListaLigada)"/>
		protected override void QuitarNodoYRemediar(NodoListaLigada aQuitar) {
			if(this.Vacía) return;

			if(aQuitar is null)
				return;

			if(aQuitar == this.cabeza) {
				if(this.cabeza.Siguiente is NodoListaLigada)
					(this.cabeza.Siguiente as NodoListaDoblementeLigada).Anterior = null;

				this.cabeza = this.cabeza.Siguiente;

				if(this.Vacía)
					this.cola = null;
			} else {
				NodoListaLigada actual = this.cabeza;

				while(actual.Siguiente is NodoListaLigada && actual != aQuitar)
					actual = actual.Siguiente;

				if(actual is NodoListaLigada) {
					NodoListaDoblementeLigada encontrado = actual as NodoListaDoblementeLigada;

					if(encontrado.Anterior is NodoListaLigada)
						encontrado.Anterior.Siguiente = encontrado.Siguiente;

					if(encontrado.Siguiente is NodoListaLigada)
						(encontrado.Siguiente as NodoListaDoblementeLigada).Anterior = encontrado.Anterior;
					else
						this.cola = encontrado.Anterior;
				}
			}

			this.Cantidad--;
		}
	}
}
