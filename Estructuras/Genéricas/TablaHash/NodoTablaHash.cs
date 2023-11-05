using System;

namespace Estructuras.Genéricas {
	/// <summary>
	/// Representa una entrada enlazada de <see cref="TablaHash{TClave, TValor}"/>
	/// </summary>
	/// <typeparam name="TClave">Tipo de clave de la entrada</typeparam>
	/// <typeparam name="TValor">Tivo de valor de la entrada</typeparam>
	[Serializable]
	public class NodoTablaHash<TClave, TValor> {
		/// <summary>
		/// Devuelve la clave de este <see cref="NodoTablaHash{TClave, TValor}"/>
		/// </summary>
		public TClave Clave { get; }

		/// <summary>
		/// Devuelve y establece el valor de este <see cref="NodoTablaHash{TClave, TValor}"/>
		/// </summary>
		public TValor Valor { get; set; }

		/// <summary>
		/// Indica el <see cref="NodoTablaHash{TClave, TValor}"/> posterior a este
		/// </summary>
		public NodoTablaHash<TClave, TValor> Siguiente { get; set; }

		/// <summary>
		/// Indica si este <see cref="NodoTablaHash{TClave, TValor}"/> es el último de la lista
		/// </summary>
		/// <remarks>No comprueba la integridad de la <see cref="ListaLigada{T}"/>, solo revisa si no tiene un siguiente elemento</remarks>
		public bool EsÚltimo {
			get { return this.Siguiente is null; }
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoTablaHash{TClave, TValor}"/> con el valor y el siguiente <see cref="NodoListaLigada{T}"/> especificados
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoTablaHash{TClave, TValor}"/></param>
		/// <param name="siguiente">Siguiente <see cref="NodoTablaHash{TClave, TValor}"/></param>
		public NodoTablaHash(TClave clave, TValor valor, NodoTablaHash<TClave, TValor> siguiente) {
			this.Clave = clave;
			this.Valor = valor;
			this.Siguiente = siguiente;
		}

		/// <summary>
		/// Inicializa una nueva instancia de <see cref="NodoListaLigada{T}"/> con el valor indicado y sin siguiente elemento
		/// </summary>
		/// <param name="valor">Valor propio del <see cref="NodoListaLigada{T}"/></param>
		public NodoTablaHash(TClave clave, TValor valor): this(clave, valor, null) {}

		/// <summary>
		/// Crea un par ordenado con los valores de clave y valor del <see cref="NodoTablaHash{TClave, TValor}"/>
		/// </summary>
		/// <returns></returns>
		public ParOrdenado<TClave, TValor> AParOrdenado() {
			return new ParOrdenado<TClave, TValor>(this.Clave, this.Valor);
		}
	}
}
