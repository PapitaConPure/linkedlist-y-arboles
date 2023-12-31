﻿using System;

namespace Estructuras {
	/// <summary>
	/// Representa una estructura de datos cuyo comportamiento es aquel de "Último en Entrar, Primero en Salir"
	/// </summary>
	[Serializable]
	public class Pila: IColección {
		private readonly ListaLigada lista;

		/// <summary>
		/// Crea una nueva instancia de <see cref="Pila"/> vacía
		/// </summary>
		public Pila() {
			this.lista = new ListaLigada();
		}

		public int Cantidad {
			get { return this.lista.Cantidad; }
		}

		/// <summary>
		/// Indica si la <see cref="Pila"/> contiene el valor especificado
		/// </summary>
		/// <param name="valor">Valor a buscar en la <see cref="Pila"/></param>
		/// <returns><see langword="true"/> si se encuentra el valor, <see langword="false"/> de lo contrario </returns>
		public bool Contiene(object valor) {
			return this.lista.Contiene(valor);
		}

		/// <summary>
		/// Agrega un elemento a la cima de la <see cref="Pila"/>
		/// </summary>
		/// <param name="valor">Valor a apilar</param>
		/// <returns>El nuevo largo de la <see cref="Pila"/></returns>
		public int Apilar(object valor) {
			this.lista.AgregarPrimero(valor);
			return this.lista.Cantidad;
		}

		/// <summary>
		/// Quita y devuelve el elemento en la cima de la <see cref="Pila"/>
		/// </summary>
		/// <returns>El elemento quitado, o <see langword="null"/> si la <see cref="Pila"/> está vacía</returns>
		public object Desapilar() {
			return this.lista.QuitarPrimero();
		}

		/// <summary>
		/// Devuelve el elemento en la cima de la <see cref="Pila"/> y no lo quita
		/// </summary>
		/// <returns>El elemento en la cima de la <see cref="Pila"/>, o <see langword="null"/> si está vacía</returns>
		public object Revisar() {
			return this.lista.PrimerValor;
		}

		/// <summary>
		/// Quita todos los elementos de la <see cref="Pila"/>
		/// </summary>
		public void Limpiar() {
			this.lista.Limpiar();
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Pila"/> en un nuevo vector
		/// </summary>
		/// <remarks>El primer elemento del vector creado es el que más tiende a salir</remarks>
		/// <returns>Un nuevo vector con los elementos de esta <see cref="Pila"/></returns>
		public object[] AVector() {
			return this.lista.AVector();
		}

		/// <summary>
		/// Copia los elementos de la <see cref="Pila"/> en el vector <paramref name="destino"/> indicado
		/// </summary>
		/// <param name="destino">El vector al cual copiar los elementos de la <see cref="Pila"/></param>
		/// <param name="índiceInicio">La posición basada en 0 del primer elemento de la <see cref="Pila"/> a copiar</param>
		/// <param name="cantidad">Cantidad de elementos a copiar de la <see cref="Pila"/></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void CopiarEn(object[] destino, int índiceInicio = -1, int cantidad = -1) {
			this.lista.CopiarEn(destino, índiceInicio, cantidad);
		}
	}
}
