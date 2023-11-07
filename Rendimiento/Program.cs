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
		private static Random random = new Random(0);
		private static Stopwatch stopwatch = new Stopwatch();
		private static string[] nombres;

		private static ListaLigada<string> listaLigada = new ListaLigada<string>();
		private static ListaDoblementeLigada<string> listaDoblementeLigada = new ListaDoblementeLigada<string>();
		private static Pila<string> pila = new Pila<string>();
		private static Cola<string> cola = new Cola<string>();
		private static ÁrbolBinario<string> árbol = new ÁrbolBinario<string>();
		private static TablaHash<string, double> tabla = new TablaHash<string, double>(256, 0.92, 1.75);
		private static Diccionario<string, double> diccionario = new Diccionario<string, double>(131_072);

		static void Main(string[] args) {
			if(!Inicializar()) {
				ConsoFacil.FinalizarPrograma();
				return;
			}

			Console.Clear();

			ConsoFacil.MostrarPlacaSimple("Lista Ligada", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarLista(listaLigada, 1_000);
			ProbarLista(listaLigada, 5_000);
			ProbarLista(listaLigada, 10_000);
			ProbarLista(listaLigada, 50_000);
			ProbarLista(listaLigada, 100_000);
			ProbarLista(listaLigada, 500_000);
			ProbarLista(listaLigada, 1_000_000);
			ProbarLista(listaLigada, 5_000_000);
			ProbarLista(listaLigada, 10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(32, 0);
			ConsoFacil.MostrarPlacaSimple("Lista Doblemente Ligada", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarLista(listaDoblementeLigada, 1_000);
			ProbarLista(listaDoblementeLigada, 5_000);
			ProbarLista(listaDoblementeLigada, 10_000);
			ProbarLista(listaDoblementeLigada, 50_000);
			ProbarLista(listaDoblementeLigada, 100_000);
			ProbarLista(listaDoblementeLigada, 500_000);
			ProbarLista(listaDoblementeLigada, 1_000_000);
			ProbarLista(listaDoblementeLigada, 5_000_000);
			ProbarLista(listaDoblementeLigada, 10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(0, 20);
			ConsoFacil.MostrarPlacaSimple("Pila", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarPila(1_000);
			ProbarPila(5_000);
			ProbarPila(10_000);
			ProbarPila(50_000);
			ProbarPila(100_000);
			ProbarPila(500_000);
			ProbarPila(1_000_000);
			ProbarPila(5_000_000);
			ProbarPila(10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(32, 20);
			ConsoFacil.MostrarPlacaSimple("Cola", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarCola(1_000);
			ProbarCola(5_000);
			ProbarCola(10_000);
			ProbarCola(50_000);
			ProbarCola(100_000);
			ProbarCola(500_000);
			ProbarCola(1_000_000);
			ProbarCola(5_000_000);
			ProbarPila(10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(0, 40);
			ConsoFacil.MostrarPlacaSimple("Árbol Binario", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarÁrbolBinario(1_000);
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

			ConsoFacil.IrA(32, 40);
			ConsoFacil.MostrarPlacaSimple("Tabla Hash", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarDiccionario(tabla, 1_000);
			ProbarDiccionario(tabla, 5_000);
			ProbarDiccionario(tabla, 10_000);
			ProbarDiccionario(tabla, 50_000);
			ProbarDiccionario(tabla, 100_000);
			ProbarDiccionario(tabla, 500_000);
			ProbarDiccionario(tabla, 1_000_000);
			ProbarDiccionario(tabla, 5_000_000);
			ProbarDiccionario(tabla, 10_000_000);
			GC.Collect();
			GC.WaitForPendingFinalizers();

			ConsoFacil.IrA(64, 40);
			ConsoFacil.MostrarPlacaSimple("Diccionario", ConsoleColor.White, ConsoleColor.DarkRed);
			ProbarDiccionario(diccionario, 1_000);
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

			ConsoFacil.FinalizarPrograma();
		}

		static void ProbarLista(ILista<string> lista, int cantidad) {
			string[] seleccionado = new string[cantidad];
			for(int i = 0; i < cantidad; i++)
				seleccionado[i] = nombres[random.Next() % nombres.Length];

			stopwatch.Restart();
			for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
				lista.Agregar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
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
			for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
				pila.Apilar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
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
			for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
				cola.Encolar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
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
			for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
				árbol.Agregar(seleccionado[i]);
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
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
			for(int i = 0; i < cantidad && stopwatch.ElapsedMilliseconds < 99_999; i++)
				diccionario.Insertar(seleccionado[i], random.NextDouble());
			stopwatch.Stop();

			if(ReportarAñade(cantidad)) {
				stopwatch.Restart();
				for(int i = 0; i < cantidad /*&& stopwatch.ElapsedMilliseconds < 99_999*/; i++)
					diccionario.Quitar(seleccionado[i]);
				stopwatch.Stop();
			} else
				diccionario.Limpiar();

			ReportarQuita(cantidad);
		}

		private static bool ReportarAñade(int cantidad) {
			if(stopwatch.ElapsedMilliseconds < 99_999) {
				ConsoFacil.MostrarPlacaDoble($"Añade {cantidad,-10:###,###,###}", $"{stopwatch.ElapsedMilliseconds,5}ms", ConsoleColor.DarkCyan);
				return true;
			} else {
				ConsoFacil.MostrarPlacaDoble($"Añade {cantidad,-10:###,###,###}", "    Xms", ConsoleColor.Red);
				return false;
			}
		}

		private static void ReportarQuita(int cantidad) {
			if(stopwatch.ElapsedMilliseconds < 99_999)
				ConsoFacil.MostrarPlacaDoble($"Quita {cantidad,-10:###,###,###}", $"{stopwatch.ElapsedMilliseconds,5}ms", ConsoleColor.Magenta);
			else
				ConsoFacil.MostrarPlacaDoble($"Quita {cantidad,-10:###,###,###}", "    Xms", ConsoleColor.Red);
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
	}
}
