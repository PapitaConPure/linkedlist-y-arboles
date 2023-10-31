using System;

namespace Estructuras {
	/// <summary>
	/// Representa un elemento de una <see cref="ListaDoblementeLigada"/> con un valor propio y una referencia al siguiente y anterior elemento
	/// </summary>
	[Serializable]
	public class NodoListaDoblementeLigada: NodoListaLigada {
		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> con el valor indicado, así como también el anterior y siguiente <see cref="NodoListaLigada"/> especificados
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaDoblementeLigada"/></param>
		/// <param name="anterior">Anterior <see cref="NodoListaLigada"/> de la <see cref="ListaDoblementeLigada"/></param>
		/// <param name="siguiente">Siguiente <see cref="NodoListaLigada"/> de la <see cref="ListaLigada"/></param>
		public NodoListaDoblementeLigada(object valor, NodoListaLigada anterior, NodoListaLigada siguiente): base(valor, siguiente) {
			this.Anterior = anterior;
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> con el valor y el siguiente <see cref="NodoListaLigada"/> especificados
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaDoblementeLigada"/></param>
		/// <param name="siguiente">Siguiente <see cref="NodoListaLigada"/> de la <see cref="ListaLigada"/></param>
		public NodoListaDoblementeLigada(object valor, NodoListaLigada siguiente): this(valor, null, siguiente) {}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> con el valor indicado, sin siguiente ni anterior elemento
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaDoblementeLigada"/></param>
		public NodoListaDoblementeLigada(object valor): this(valor, null) {}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> sin valor propio ni siguiente o anterior elemento
		/// </summary>
		public NodoListaDoblementeLigada(): this(null) {}

		/// <summary>
		/// Indica el <see cref="NodoListaDoblementeLigada"/> anterior a este
		/// </summary>
		public NodoListaLigada Anterior { get; set; }

		/// <summary>
		/// Indica si este <see cref="NodoListaDoblementeLigada"/> es el primero de la <see cref="ListaDoblementeLigada"/>
		/// </summary>
		/// <remarks>No comprueba la integridad de la <see cref="ListaDoblementeLigada"/>, solo revisa si no tiene un anterior elemento</remarks>
		public bool EsPrimero {
			get { return this.Anterior is null; }
		}
	}
}
