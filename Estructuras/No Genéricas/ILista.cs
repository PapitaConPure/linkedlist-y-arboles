using System;

namespace Estructuras {
	/// <summary>
	/// Define métodos para manipulas listas no genéricas
	/// </summary>
	interface ILista {
		/// <summary>
		/// Obtiene un valor de la lista por índice
		/// </summary>
		/// <param name="idx">El índice basado en 0 del elemento deseado</param>
		/// <returns>El valor en la posición especificada de la lista</returns>
		object this[int idx] { get; }

		/// <summary>
		/// Agrega un valor al final de la lista
		/// </summary>
		/// <param name="valor">Valor a insertar</param>
		/// <returns>La posición en la que se insertó el nuevo elemento, ó -1 si no se insertó nada</returns>
		int Agregar(object valor);

		/// <summary>
		/// Inserta un valor en la posición indicada
		/// </summary>
		/// <param name="índice">Posición de inserción</param>
		/// <param name="valor">Valor a insertar</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		void Insertar(int índice, object valor);

		/// <summary>
		/// Quita la primer ocurrencia del valor especificado y devuelve su índice, si se encuentra
		/// </summary>
		/// <param name="valor">Valor a quitar</param>
		/// <returns>El índice del valor quitado de la lista, ó -1 si no se quitó nada</returns>
		int Quitar(object valor);

		/// <summary>
		/// Quita el elemento en la posición especificada de la lista
		/// </summary>
		/// <param name="índice">Índice en el cual remover un elemento</param>
		/// <returns>El valor quitado de la lista</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		object QuitarEn(int índice);

		/// <summary>
		/// Busca un elemento por índice en la lista y devuelve su valor
		/// </summary>
		/// <param name="índice">Índice deseado</param>
		/// <returns>El valor del elemento en la posición del <paramref name="índice"/> especificado</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		object ValorEn(int índice);

		/// <summary>
		/// Busca un elemento con el <paramref name="valor"/> indicado en la lista y devuelve el índice de la primer aparición
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns>El índice de la primer ocurrencia encontrada, ó -1 si no se encuentra una</returns>
		int ÍndiceDe(object valor);
	}
}
