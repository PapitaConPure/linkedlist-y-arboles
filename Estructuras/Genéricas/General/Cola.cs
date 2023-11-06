using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una estructura de datos genérica cuyo comportamiento es aquel de "Primero en Entrar, Primero en Salir"
	/// </summary>
	[Serializable]
	public class Cola<T>: IColección<T> {
		private readonly ListaLigada<T> lista;

		/// <summary>
		/// Crea una nueva instancia de <see cref="Cola{T}"/> vacía
		/// </summary>
		public Cola() {
			this.lista = new ListaLigada<T>();
		}

		public int Cantidad {
			get { return this.lista.Cantidad; }
		}

		/// <summary>
		/// Indica si la <see cref="Cola{T}"/> contiene el valor especificado
		/// </summary>
		/// <param name="valor">Valor a buscar en la <see cref="Cola{T}"/></param>
		/// <returns><see langword="true"/> si se encuentra el valor, <see langword="false"/> de lo contrario </returns>
		public bool Contiene(T valor) {
			return this.lista.Contiene(valor);
		}

		/// <summary>
		/// Agrega un elemento al final de la <see cref="Cola{T}"/>
		/// </summary>
		/// <param name="valor">Valor a encolar</param>
		/// <returns>El nuevo largo de la <see cref="Cola{T}"/></returns>
		public int Encolar(T valor) {
			this.lista.Agregar(valor);
			return this.lista.Cantidad;
		}

		/// <summary>
		/// Quita y devuelve el elemento al principio de la <see cref="Cola{T}"/>
		/// </summary>
		/// <returns>El elemento quitado, o <see langword="null"/> si la <see cref="Cola{T}"/> está vacía</returns>
		public T Desencolar() {
			return this.lista.QuitarPrimero();
		}

		/// <summary>
		/// Devuelve el elemento al principio de la <see cref="Cola{T}"/> y no lo quita
		/// </summary>
		/// <returns>El elemento al principio de la <see cref="Cola{T}"/>, o <see langword="null"/> si está vacía</returns>
		public T Revisar() {
			return this.lista.PrimerValor;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="Cola{T}"/>
		/// </summary>
		public void Limpiar() {
			this.lista.Limpiar();
		}

		/// <inheritdoc cref="AVector()"/>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento en la <see cref="Cola{T}"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar de la <see cref="Cola{T}"/>, -1 copia todo </param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public T[] AVector(int índiceInicio, int cantidad = -1) {
			return this.lista.AVector(índiceInicio, cantidad);
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Cola{T}"/> en un nuevo vector
		/// </summary>
		/// <remarks>El primer elemento del vector creado es el que más tiende a salir</remarks>
		/// <returns>Un nuevo vector con los elementos de esta <see cref="Cola"/></returns>
		public T[] AVector() {
			return this.lista.AVector();
		}

		/// <inheritdoc cref="CopiarEn(T[])"/>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento en la <see cref="Cola{T}"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar de la <see cref="Cola{T}"/>, -1 copia todo </param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public void CopiarEn(T[] destino, int índiceInicio, int cantidad = -1) {
			this.lista.CopiarEn(destino, índiceInicio, cantidad);
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Cola{T}"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <remarks>El primer elemento del vector creado es el que más tiende a salir</remarks>
		/// <param name="destino">El vector al cual copiar los elementos de la <see cref="Cola{T}"/></param>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(T[] destino) {
			this.CopiarEn(destino, 0);
		}
	}
}
