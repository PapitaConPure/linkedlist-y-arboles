using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos cuyo comportamiento es aquel de "Primero en Entrar, Primero en Salir"
	/// </summary>
	[Serializable]
	public class Cola<T>: IColección<T> {
		private readonly ListaLigada<T> lista;

		/// <summary>
		/// Crea una nueva instancia de <see cref="Cola"/> vacía
		/// </summary>
		public Cola() {
			this.lista = new ListaLigada<T>();
		}

		public int Cantidad {
			get { return this.lista.Cantidad; }
		}

		/// <summary>
		/// Indica si la <see cref="Cola"/> contiene el valor especificado
		/// </summary>
		/// <param name="valor">Valor a buscar en la <see cref="Cola"/></param>
		/// <returns><see langword="true"/> si se encuentra el valor, <see langword="false"/> de lo contrario </returns>
		public bool Contiene(T valor) {
			return this.lista.Contiene(valor);
		}

		/// <summary>
		/// Agrega un elemento al final de la <see cref="Cola"/>
		/// </summary>
		/// <param name="valor">Valor a encolar</param>
		/// <returns>El nuevo largo de la <see cref="Cola"/></returns>
		public int Encolar(T valor) {
			this.lista.AgregarÚltimo(valor);
			return this.lista.Cantidad;
		}

		/// <summary>
		/// Quita y devuelve el elemento al principio de la <see cref="Cola"/>
		/// </summary>
		/// <returns>El elemento quitado, o <see langword="null"/> si la <see cref="Cola"/> está vacía</returns>
		public T Desencolar() {
			return this.lista.QuitarPrimero();
		}

		/// <summary>
		/// Devuelve el elemento al principio de la <see cref="Cola"/> y no lo quita
		/// </summary>
		/// <returns>El elemento al principio de la <see cref="Cola"/>, o <see langword="null"/> si está vacía</returns>
		public T Revisar() {
			return this.lista.PrimerValor;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="Cola"/>
		/// </summary>
		public void Limpiar() {
			this.lista.Limpiar();
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Cola"/> en un nuevo vector
		/// </summary>
		/// <remarks>El primer elemento del vector creado es el que más tiende a salir</remarks>
		/// <returns>Un nuevo vector con los elementos de esta <see cref="Cola"/></returns>
		public T[] AVector() {
			return this.lista.AVector();
		}
	}
}
