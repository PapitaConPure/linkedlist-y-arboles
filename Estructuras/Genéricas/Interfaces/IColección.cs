using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Define métodos para manipular colecciones de elementos genéricas
	/// </summary>
	/// <typeparam name="T">El tipo de elemento contenido por la colección</typeparam>
	public interface IColección<T> {
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

		/// <summary>
		/// Copia los elementos de la colección en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <param name="destino">El vector al cual copiar los elementos de la colección</param>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento de la colección a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar de la colección</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		void CopiarEn(T[] destino, int índiceInicio = -1, int cantidad = -1);
	}
}