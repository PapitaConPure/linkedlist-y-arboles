using System;

namespace Estructuras.Genéricas {
	internal static class Genérico {
		public static bool EsNulo<T>(T valor) {
			Type tipo = typeof(T);

			if(tipo.IsValueType)
				return false;

			return (valor as object) == null;
		}
	}
}