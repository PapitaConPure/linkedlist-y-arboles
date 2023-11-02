using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa un elemento de una <see cref="ListaDoblementeLigada"/> con un valor propio y una referencia al siguiente y anterior elemento
	/// </summary>
	[Serializable]
	public class NodoListaDoblementeLigada<T>: NodoListaLigada<T> {
		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> con el valor indicado, así como también el anterior y siguiente <see cref="NodoListaLigada"/> especificados
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaDoblementeLigada"/></param>
		/// <param name="anterior">Anterior <see cref="NodoListaLigada"/> de la <see cref="ListaDoblementeLigada"/></param>
		/// <param name="siguiente">Siguiente <see cref="NodoListaLigada"/> de la <see cref="ListaLigada"/></param>
		public NodoListaDoblementeLigada(T valor, NodoListaLigada<T> anterior, NodoListaLigada<T> siguiente): base(valor, siguiente) {
			this.Anterior = anterior;
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> con el valor y el siguiente <see cref="NodoListaLigada"/> especificados
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaDoblementeLigada"/></param>
		/// <param name="siguiente">Siguiente <see cref="NodoListaLigada"/> de la <see cref="ListaLigada"/></param>
		public NodoListaDoblementeLigada(T valor, NodoListaLigada<T> siguiente): this(valor, null, siguiente) {}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaDoblementeLigada"/> con el valor indicado, sin siguiente ni anterior elemento
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaDoblementeLigada"/></param>
		public NodoListaDoblementeLigada(T valor): this(valor, null) {}

		/// <summary>
		/// Indica el <see cref="NodoListaDoblementeLigada"/> anterior a este
		/// </summary>
		public NodoListaLigada<T> Anterior { get; set; }

		/// <summary>
		/// Indica si este <see cref="NodoListaDoblementeLigada"/> es el primero de la <see cref="ListaDoblementeLigada"/>
		/// </summary>
		/// <remarks>No comprueba la integridad de la <see cref="ListaDoblementeLigada"/>, solo revisa si no tiene un anterior elemento</remarks>
		public bool EsPrimero {
			get { return this.Anterior is null; }
		}
	}
}
