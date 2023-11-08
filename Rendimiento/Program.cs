using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papita.ConsoFacil;
using Estructuras.Genéricas;
using System.IO;

namespace Rendimiento {
	class Program {
		private static readonly Random random = new Random(0);
		private static readonly Stopwatch stopwatch = new Stopwatch();

		private static readonly ListaLigada<string> listaLigada = new ListaLigada<string>();
		private static readonly ListaDoblementeLigada<string> listaDoblementeLigada = new ListaDoblementeLigada<string>();
		private static readonly Pila<string> pila = new Pila<string>();
		private static readonly Cola<string> cola = new Cola<string>();
		private static readonly ÁrbolBinario<string> árbol = new ÁrbolBinario<string>();
		private static readonly TablaHash<string, double> tabla = new TablaHash<string, double>(256, 0.92, 1.75);
		private static readonly Diccionario<string, double> diccionario = new Diccionario<string, double>(131_072);
		private static string[] arreglo;

		private static string[] nombres;

		static void Main(string[] _) {
			if(!Inicializar()) {
				ConsoFacil.FinalizarPrograma();
				return;
			}

			Console.Clear();

			ConsoFacil.MostrarPlacaSimple("Lista Ligada", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarLista(listaLigada, 5_000);
			ProbarLista(listaLigada, 10_000);
			ProbarLista(listaLigada, 50_000);
			ProbarLista(listaLigada, 100_000);
			ProbarLista(listaLigada, 500_000);
			ProbarLista(listaLigada, 1_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 1, 28 * 0);
			ConsoFacil.MostrarPlacaSimple("Lista Doblemente Ligada", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarLista(listaDoblementeLigada, 5_000);
			ProbarLista(listaDoblementeLigada, 10_000);
			ProbarLista(listaDoblementeLigada, 50_000);
			ProbarLista(listaDoblementeLigada, 100_000);
			ProbarLista(listaDoblementeLigada, 500_000);
			ProbarLista(listaDoblementeLigada, 1_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 2, 28 * 0);
			ConsoFacil.MostrarPlacaSimple("Pila", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarPila(5_000);
			ProbarPila(10_000);
			ProbarPila(50_000);
			ProbarPila(100_000);
			ProbarPila(500_000);
			ProbarPila(1_000_000);
			ProbarPila(5_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 3, 28 * 0);
			ConsoFacil.MostrarPlacaSimple("Cola", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarCola(5_000);
			ProbarCola(10_000);
			ProbarCola(50_000);
			ProbarCola(100_000);
			ProbarCola(500_000);
			ProbarCola(1_000_000);
			ProbarCola(5_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 0, 28 * 1);
			ConsoFacil.MostrarPlacaSimple("Árbol Binario", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarÁrbolBinario(5_000);
			ProbarÁrbolBinario(10_000);
			ProbarÁrbolBinario(50_000);
			ProbarÁrbolBinario(100_000);
			ProbarÁrbolBinario(500_000);
			ProbarÁrbolBinario(1_000_000);
			ProbarÁrbolBinario(5_000_000);
			ProbarÁrbolBinario(10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 1, 28 * 1);
			ConsoFacil.MostrarPlacaSimple("Tabla Hash", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarDiccionario(tabla, 5_000);
			ProbarDiccionario(tabla, 10_000);
			ProbarDiccionario(tabla, 50_000);
			ProbarDiccionario(tabla, 100_000);
			ProbarDiccionario(tabla, 500_000);
			ProbarDiccionario(tabla, 1_000_000);
			ProbarDiccionario(tabla, 5_000_000);
			ProbarDiccionario(tabla, 10_000_000);
			ProbarDiccionario(tabla, 50_000_000);
			ProbarDiccionario(tabla, 100_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 2, 28 * 1);
			ConsoFacil.MostrarPlacaSimple("Diccionario", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarDiccionario(diccionario, 5_000);
			ProbarDiccionario(diccionario, 10_000);
			ProbarDiccionario(diccionario, 50_000);
			ProbarDiccionario(diccionario, 100_000);
			ProbarDiccionario(diccionario, 500_000);
			ProbarDiccionario(diccionario, 1_000_000);
			ProbarDiccionario(diccionario, 5_000_000);
			ProbarDiccionario(diccionario, 10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(28 * 3, 28 * 1);
			ConsoFacil.MostrarPlacaSimple("Arreglo tradicional", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarArreglo(5_000);
			ProbarArreglo(10_000);
			ProbarArreglo(50_000);
			ProbarArreglo(100_000);
			ProbarArreglo(500_000);
			ProbarArreglo(1_000_000);
			ProbarArreglo(5_000_000);
			ProbarArreglo(10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.FinalizarPrograma();
		}

		static void ProbarLista(ILista<string> lista, int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			stopwatch.Restart();
			for(int i = 0; i < cantidad; i++)
				lista.Agregar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					lista.Contiene(seleccionado[i]);
				stopwatch.Stop();

				ReportarBusca(cantidad);

				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					lista.Quitar(seleccionado[i]);
				stopwatch.Stop();
			} else
				lista.Limpiar();

			ReportarQuita(cantidad);
		}

		private static void ProbarPila(int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			stopwatch.Restart();
			for(int i = 0; i < cantidad; i++)
				pila.Apilar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					pila.Contiene(seleccionado[i]);
				stopwatch.Stop();

				ReportarBusca(cantidad);

				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					pila.Desapilar();
				stopwatch.Stop();
			} else
				pila.Limpiar();

			ReportarQuita(cantidad);
		}

		private static void ProbarCola(int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			stopwatch.Restart();
			for(int i = 0; i < cantidad; i++)
				cola.Encolar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					cola.Contiene(seleccionado[i]);
				stopwatch.Stop();

				ReportarBusca(cantidad);

				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					cola.Desencolar();
				stopwatch.Stop();
			} else
				cola.Limpiar();

			ReportarQuita(cantidad);
		}

		private static void ProbarÁrbolBinario(int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			stopwatch.Restart();
			for(int i = 0; i < cantidad; i++)
				árbol.Agregar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					árbol.Contiene(seleccionado[i]);
				stopwatch.Stop();

				ReportarBusca(cantidad);

				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					árbol.Quitar(seleccionado[i]);
				stopwatch.Stop();
			} else
				diccionario.Limpiar();

			ReportarQuita(cantidad);
		}

		private static void ProbarDiccionario(IDiccionario<string, double> diccionario, int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			stopwatch.Restart();
			for(int i = 0; i < cantidad; i++)
				diccionario.Insertar(seleccionado[i], random.NextDouble());
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					diccionario.ContieneClave(seleccionado[i]);
				stopwatch.Stop();

				ReportarBusca(cantidad);

				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					diccionario.Quitar(seleccionado[i]);
				stopwatch.Stop();
			} else
				diccionario.Limpiar();

			ReportarQuita(cantidad);
		}

		private static void ProbarArreglo(int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			arreglo = new string[cantidad];
			int cnt = 0;

			stopwatch.Restart();
			for(int i = 0; i < cantidad; i++)
				arreglo[cnt++] = seleccionado[i];
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++)
					BinarySearch(arreglo, seleccionado[i]);
				stopwatch.Stop();

				ReportarBusca(cantidad);

				stopwatch.Restart();
				for(int i = 0; i < cantidad; i++) {
					arreglo[i] = arreglo[--cnt];
				}
				stopwatch.Stop();
			} else
				diccionario.Limpiar();

			ReportarQuita(cantidad);
		}

		private static bool ReportarAñade(int cantidad) {
			if(stopwatch.ElapsedMilliseconds < 99_999) {
				ConsoFacil.MostrarPlacaDoble($"Añade {cantidad,-10:###,###,###}", $"{Tiempo(stopwatch.ElapsedMilliseconds),6}", ConsoleColor.DarkCyan);
				return true;
			} else {
				ConsoFacil.MostrarPlacaDoble($"Añade {cantidad,-10:###,###,###}", "XXXXXX", ConsoleColor.Red);
				return false;
			}
		}

		private static void ReportarBusca(int cantidad) {
			if(stopwatch.ElapsedMilliseconds < 99_999)
				ConsoFacil.MostrarPlacaDoble($"Busca {cantidad,-10:###,###,###}", $"{Tiempo(stopwatch.ElapsedMilliseconds),6}", ConsoleColor.DarkGreen);
			else
				ConsoFacil.MostrarPlacaDoble($"Busca {cantidad,-10:###,###,###}", "XXXXXX", ConsoleColor.Red);
		}

		private static void ReportarQuita(int cantidad) {
			if(stopwatch.ElapsedMilliseconds < 99_999)
				ConsoFacil.MostrarPlacaDoble($"Quita {cantidad,-10:###,###,###}", $"{Tiempo(stopwatch.ElapsedMilliseconds),6}", ConsoleColor.Magenta);
			else
				ConsoFacil.MostrarPlacaDoble($"Quita {cantidad,-10:###,###,###}", "XXXXXX", ConsoleColor.Red);
		}

		private static string Tiempo(long ms) {
			if(ms < 1_000)
				return $"{ms}ms";
			else
				return $"{ms / 1_000d:F2}s";
		}

		private static bool Inicializar() {
			string rutaArchivo = Path.Combine(Environment.CurrentDirectory, "sample.txt");
			bool éxito = false;

			FileStream fs = null;
			StreamReader sr = null;
			try {
				ConsoFacil.MostrarPlacaDoble("Ruta de nombres", rutaArchivo, ConsoleColor.DarkGreen);
				fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read);
				sr = new StreamReader(fs);
				ListaLigada<string> temp = new ListaLigada<string>();

				while(!sr.EndOfStream)
					temp.Agregar(sr.ReadLine());

				nombres = temp.AVector();
				éxito = true;
			} catch {
				ConsoFacil.MostrarColoreado("Ocurrió un error al cargar los nombres de prueba", ConsoleColor.Red);
			} finally {
				if(fs is object) {
					if(sr is object)
						sr.Close();

					fs.Close();
				}
			}

			return éxito;
		}

		private static int BinarySearch(string[] vec, string valor) {
			int l = vec.Length;
			int izq = 0;
			int der = l - 1;
			int med = l / 2;
			int cmp;
			bool encontrado = false;

			while(izq <= der && !encontrado) {
				cmp = vec[med].CompareTo(valor);

				if(cmp == 0) {
					encontrado = true;
				} else {
					if(cmp < 0)
						izq = med + 1;
					else
						der = med - 1;

					med = (izq + der) / 2;
				}
			}

			if(encontrado)
				return med;
			else
				return -1;
		}
	}
}
