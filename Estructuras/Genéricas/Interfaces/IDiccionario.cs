namespace Estructuras.Genéricas {
	public interface IDiccionario<TClave, TValor>: IColección<ParOrdenado<TClave, TValor>> {
		TClave[] Claves { get; }

		TValor[] Valores { get; }

		/// <summary>
		/// Obtiene un valor del diccionario por clave
		/// </summary>
		/// <param name="clave">El índice basado en 0 del elemento deseado</param>
		/// <returns>El valor en la posición especificada de la lista</returns>
		TValor this[TClave clave] { get; }

		bool Agregar(TClave clave, TValor valor);

		bool Quitar(TClave clave);

		/// <summary>
		/// Revisa la coleccíón en busca del valor especificado e indica si se encontró o no
		/// </summary>
		/// <param name="valor">Valor a buscar</param>
		/// <returns><see langword="true"/> si se encontró, o <see langword="false"/> de lo contrario</returns>
		bool ContieneClave(TClave clave);
	}
}