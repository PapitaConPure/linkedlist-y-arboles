namespace Estructuras.Genéricas {
	public class ParOrdenado<TClave, TValor> {
		public TClave Clave { get; }

		public TValor Valor { get; }

		public ParOrdenado(TClave clave, TValor valor) {
			this.Clave = clave;
			this.Valor = valor;
		}
	}
}
