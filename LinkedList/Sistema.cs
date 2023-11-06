using System;
using Estructuras.Genéricas;

namespace LinkedList {
	[Serializable]
	class Sistema {
		public ListaLigada<string> ListaLigada;
		public ListaDoblementeLigada<string> ListaDoblementeLigada;
		public Pila<string> Pila;
		public Cola<string> Cola;
		public ÁrbolBinario<string> ÁrbolBinario;
		public TablaHash<string, double> TablaHash;
		public Diccionario<string, double> Diccionario;

		public Sistema() {
			this.ListaLigada = new ListaLigada<string>();
			this.ListaDoblementeLigada = new ListaDoblementeLigada<string>();
			this.Pila = new Pila<string>();
			this.Cola = new Cola<string>();
			this.ÁrbolBinario = new ÁrbolBinario<string>();
			this.TablaHash = new TablaHash<string, double>();
			this.Diccionario = new Diccionario<string, double>();
		}

		/// <summary>
		/// Inicializar nuevas estructuras en caso de que se cargue serialización de una versión anterior
		/// </summary>
		internal void Actualizar() {
			if(this.ÁrbolBinario is null)
				this.ÁrbolBinario = new ÁrbolBinario<string>();

			if(this.TablaHash is null)
				this.TablaHash = new TablaHash<string, double>();
			
			if(this.Diccionario is null)
				this.Diccionario = new Diccionario<string, double>();
		}
	}
}
