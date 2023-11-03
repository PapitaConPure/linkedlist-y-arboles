using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Clase para tratar con valores de tipo genérico
	/// </summary>
	internal static class Genérico {
		/// <summary>
		/// Verifica si un valor genérico es referencia y equivale a <see langword="null"/>
		/// </summary>
		/// <typeparam name="T">Tipo del valor a comprobar</typeparam>
		/// <param name="valor">Valor a comprobar</param>
		/// <returns>Si el valor indicado es <see langword="null"/> (<see langword="true"/>) o no (<see langword="false"/>)</returns>
		public static bool EsNulo<T>(T valor) {
			Type tipo = typeof(T);

			if(tipo.IsValueType)
				return false;

			return (valor as object) == null;
		}
	}
}