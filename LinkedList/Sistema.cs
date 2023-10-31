using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructuras;

namespace LinkedList {
	[Serializable]
	class Sistema {
		public ListaLigada ListaLigada;
		public ListaDoblementeLigada ListaDoblementeLigada;
		public Pila Pila;
		public Cola Cola;

		public Sistema() {
			this.ListaLigada = new ListaLigada();
			this.ListaDoblementeLigada = new ListaDoblementeLigada();
			this.Pila = new Pila();
			this.Cola = new Cola();
		}
	}
}
