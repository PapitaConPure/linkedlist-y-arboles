using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos genérica cuyo comportamiento es aquel de "Último en Entrar, Primero en Salir"
	/// </summary>
	[Serializable]
	public class Pila<T>: IColección<T> {
		private readonly ListaLigada<T> lista;

		/// <summary>
		/// Crea una nueva instancia de <see cref="Pila{T}"/> vacía
		/// </summary>
		public Pila() {
			this.lista = new ListaLigada<T>();
		}

		public int Cantidad {
			get { return this.lista.Cantidad; }
		}

		/// <summary>
		/// Indica si la <see cref="Pila{T}"/> contiene el valor especificado
		/// </summary>
		/// <param name="valor">Valor a buscar en la <see cref="Pila{T}"/></param>
		/// <returns><see langword="true"/> si se encuentra el valor, <see langword="false"/> de lo contrario </returns>
		public bool Contiene(T valor) {
			return this.lista.Contiene(valor);
		}

		/// <summary>
		/// Agrega un elemento a la cima de la <see cref="Pila{T}"/>
		/// </summary>
		/// <param name="valor">Valor a apilar</param>
		/// <returns>El nuevo largo de la <see cref="Pila{T}"/></returns>
		public int Apilar(T valor) {
			this.lista.AgregarPrimero(valor);
			return this.lista.Cantidad;
		}

		/// <summary>
		/// Quita y devuelve el elemento en la cima de la <see cref="Pila{T}"/>
		/// </summary>
		/// <returns>El elemento quitado, o <see langword="null"/> si la <see cref="Pila{T}"/> está vacía</returns>
		public T Desapilar() {
			return this.lista.QuitarPrimero();
		}

		/// <summary>
		/// Devuelve el elemento en la cima de la <see cref="Pila{T}"/> y no lo quita
		/// </summary>
		/// <returns>El elemento en la cima de la <see cref="Pila{T}"/>, o <see langword="null"/> si está vacía</returns>
		public T Revisar() {
			return this.lista.PrimerValor;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="Pila{T}"/>
		/// </summary>
		public void Limpiar() {
			this.lista.Limpiar();
		}

		/// <inheritdoc cref="AVector()"/>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento de la <see cref="Pila{T}"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar de la <see cref="Pila{T}"/>, -1 copia todo</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T[] AVector(int índiceInicio, int cantidad = -1) {
			return this.lista.AVector(índiceInicio, cantidad);
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Pila{T}"/> en un nuevo vector
		/// </summary>
		/// <remarks>El primer elemento del vector creado es el que más tiende a salir</remarks>
		/// <returns>Un nuevo vector con los elementos de esta <see cref="Pila{T}"/></returns>
		public T[] AVector() {
			return this.lista.AVector();
		}

		/// <inheritdoc cref="CopiarEn(T[])"/>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento de la <see cref="Pila{T}"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar de la <see cref="Pila{T}"/>, -1 copia todo</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public void CopiarEn(T[] destino, int índiceInicio, int cantidad = -1) {
			this.lista.CopiarEn(destino, índiceInicio, cantidad);
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Pila{T}"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <remarks>El primer elemento del vector creado es el que más tiende a salir</remarks>
		/// <param name="destino">El vector al cual copiar los elementos de la <see cref="Pila{T}"/></param>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(T[] destino) {
			this.CopiarEn(destino, 0);
		}
	}
}
