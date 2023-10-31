using System;

namespace Estructuras {
	/// <summary>
	/// Representa un elemento de una <see cref="ListaLigada"/> con un valor propio y una referencia al siguiente elemento
	/// </summary>
	[Serializable]
	public class NodoListaLigada {
		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaLigada"/> con el valor y el siguiente <see cref="NodoListaLigada"/> especificados
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaLigada"/></param>
		/// <param name="siguiente">Siguiente <see cref="NodoListaLigada"/> de la <see cref="ListaLigada"/></param>
		public NodoListaLigada(object valor, NodoListaLigada siguiente) {
			this.Valor = valor;
			this.Siguiente = siguiente;
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaLigada"/> con el valor indicado y sin siguiente elemento
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaLigada"/></param>
		public NodoListaLigada(object valor): this(valor, null) {}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaLigada"/> sin valor propio ni siguiente elemento
		/// </summary>
		public NodoListaLigada(): this(null) {}

		/// <summary>
		/// Devuelve y establece el valor propio de este <see cref="NodoListaLigada"/>
		/// </summary>
		public object Valor { get; set; }

		/// <summary>
		/// Indica el <see cref="NodoListaLigada"/> posterior a este
		/// </summary>
		public NodoListaLigada Siguiente { get; set; }

		/// <summary>
		/// Indica si este <see cref="NodoListaLigada"/> es el último de la <see cref="ListaLigada"/>
		/// </summary>
		/// <remarks>No comprueba la integridad de la <see cref="ListaLigada"/>, solo revisa si no tiene un siguiente elemento</remarks>
		public bool EsÚltimo {
			get { return this.Siguiente is null; }
		}
	}
}
