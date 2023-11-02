using System;

namespace Estructuras.Genéricas {
	interface IColección<T> {
		/// <summary>
		/// Indica la cantidad de elementos de la colección
		/// </summary>
		int Cantidad { get; }

		/// <summary>
		/// Revisa la coleccíón en busca del valor especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		bool Contiene(T valor);

		/// <summary>
		/// Quita todos los elementos de la colección
		/// </summary>
		void Limpiar();

		/// <summary>
		/// Copia todos los elementos de la colección en un nuevo vector
		/// </summary>
		/// <returns>Un nuevo vector con los elementos de esta colección</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		T[] AVector();
	}
}