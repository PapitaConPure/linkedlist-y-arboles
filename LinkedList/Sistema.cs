﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public Sistema() {
			this.ListaLigada = new ListaLigada<string>();
			this.ListaDoblementeLigada = new ListaDoblementeLigada<string>();
			this.Pila = new Pila<string>();
			this.Cola = new Cola<string>();
			this.ÁrbolBinario = new ÁrbolBinario<string>();
			this.TablaHash = new TablaHash<string, double>();
		}

		internal void Actualizar() {
			if(this.ÁrbolBinario is null)
				this.ÁrbolBinario = new ÁrbolBinario<string>();

			if(this.TablaHash is null)
				this.TablaHash = new TablaHash<string, double>();
		}
	}
}
