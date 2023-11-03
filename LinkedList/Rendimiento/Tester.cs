using System;
using System.Diagnostics;

namespace Tester {
	public static class StringTester {
		private static readonly Stopwatch STOPWATCH = new Stopwatch();
		private static readonly Random RANDOM = new Random();
		private static readonly char[] LETRAS = new char[] {
			'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
			' '
		};

		/// <summary>
		/// Comienza una nueva prueba, deteniendo la anterior si es que había una en ejecución
		/// </summary>
		public static void ComenzarPrueba() {
			STOPWATCH.Restart();
		}

		/// <summary>
		/// Finaliza la prueba actual y devuelve la duración de la misma
		/// </summary>
		/// <returns>Tiempo transcurrido desde que comenzó la prueba en milisegundos</returns>
		public static long FinalizarPrueba() {
			STOPWATCH.Stop();
			return STOPWATCH.ElapsedMilliseconds;
		}

		public static string[] GenerarTextosBasura(int cantidad, int largo) {
			string[] textos = new string[cantidad];

			for(int i = 0; i < cantidad; i++)
				textos[i] = GenerarTextoBasura(largo);

			return textos;
		}

		public static string GenerarTextoBasura(int largo) {
			int cntLetras = LETRAS.Length;
			char[] chars = new char[largo];

			for(int i = 0; i < largo; i++)
				chars[i] = LETRAS[RANDOM.Next(cntLetras)];

			return new string(chars);
		}
	}
}
