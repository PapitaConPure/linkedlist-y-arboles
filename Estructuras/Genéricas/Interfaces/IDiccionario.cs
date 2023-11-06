using System;
using System.Collections.Generic;

namespace Estructuras.Genéricas {
	public interface IDiccionario<TClave, TValor>: IColección<ParOrdenado<TClave, TValor>> {
		/// <summary>
		/// Devuelve una vector de todas las claves del diccionario
		/// </summary>
		TClave[] Claves { get; }

		/// <summary>
		/// Devuelve una vector de todos los valores del diccionario
		/// </summary>
		TValor[] Valores { get; }

		/// <summary>
		/// Obtiene un valor del diccionario por clave
		/// </summary>
		/// <param name="clave">La clave del elemento deseado</param>
		/// <returns>El valor en la posición especificada del diccionario</returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="KeyNotFoundException"></exception>
		TValor this[TClave clave] { get; set; }

		/// <summary>
		/// Inserta un <paramref name="valor"/> en el diccionario bajo la <paramref name="clave"/> especificada
		/// </summary>
		/// <param name="clave">Clave del valor</param>
		/// <param name="valor">Valor a insertar</param>
		/// <returns><see langword="true"/> si se agregó una nueva entrada, <see langword="false"/> de lo contrario</returns>
		/// <exception cref="ArgumentNullException"></exception>
		bool Insertar(TClave clave, TValor valor);

		/// <summary>
		/// Busca un valor por clave para devolverlo. 
		/// </summary>
		/// <remarks>Si no se encuentra un valor, <paramref name="encontrado"/> toma el valor por defecto de <typeparamref name="TValor"/></remarks>
		/// <param name="clave">Clave a buscar</param>
		/// <param name="encontrado">Resultado de la búsqueda</param>
		/// <returns><see langword="true"/> si se encuentra un valor, <see langword="false"/> de lo contrario</returns>
		/// <exception cref="ArgumentNullException"></exception>
		bool Buscar(TClave clave, out TValor encontrado);

		/// <summary>
		/// Busca el valor bajo la <paramref name="clave"/> especificada y lo devuelve.
		/// </summary>
		/// <remarks>Deberías usar <see cref="ContieneClave(TClave)"/> antes de llamar este método</remarks>
		/// <param name="clave">Clave a buscar</param>
		/// <returns>El valor bajo la clave especificada</returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="KeyNotFoundException"></exception>
		TValor Encontrar(TClave clave);

		/// <summary>
		/// Quita la entrada asociada a la <paramref name="clave"/> especificada del diccionario
		/// </summary>
		/// <param name="clave">Clave de la entrada a quitar</param>
		/// <returns>Si la entrada se pudo quitar (<see langword="true"/>) o no (<see langword="false"/>)</returns>
		/// <exception cref="ArgumentNullException"></exception>
		bool Quitar(TClave clave);

		/// <summary>
		/// Revisa el diccionario en busca de la <paramref name="clave"/> especificada e indica si se encontró o no
		/// </summary>
		/// <param name="clave">Clave a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		bool ContieneClave(TClave clave);
	}
}