# Estructuras de Datos
> Práctica de Clases Autorreferenciadas y Estructuras de Datos

Se creó una ventana administradora para la demostración de cada estructura.

## Estructuras No Genéricas
### Interfaces
Se sostienen las interfaces [`IColección`](/Estructuras/No%20Genéricas/IColección.cs) e [`ILista`](/Estructuras/No%20Genéricas/IColección.cs) para definir métodos varios de las Estructuras No Genéricas:
* `IColección`
  * `Cantidad: get int`
  * `Contiene(object valor): bool`
  * `Limpiar()`
  * `AVector(): object[]`
  * `CopiarEn(destino: object[], [índiceInicio: int = -1], [cantidad: int = -1])`
* `ILista`
  * `this[idx: int]: object`
  * `Agregar(valor: object): int`
  * `Insertar(idx: int, valor: object)`
  * `Quitar(valor: object): int`
  * `QuitarEn(idx: int): object`
  * `ValorEn(idx: int): object`
  * `ÍndiceDe(valor: object): int`

### Lista Ligada
Es una lista que consiste de objetos nodos que tienen cada uno la referencia al siguiente nodo de la lista (están "ligados"). Solo se puede recorrer de forma secuencial hacia delante.

**Modo de uso**
```cs
ListaLigada lista = new ListaLigada();
lista.Agregar("hola");
lista.Agregar(42);
lista.Agregar(3.14159265);
lista.QuitarPrimero(); //"hola"
lista.QuitarÚltimo(); //3.14159265
lista.AgregarPrimero(true);

foreach(object elemento in lista.AVector())
	this.listBox1.Items.Add(elemento); // true, 42
```

Además de la clase nodo, se tiene una clase administradora que representa la lista en sí, conteniendo esta una referencia al Nodo del principio (la "cabeza") y del final (la "cola") de la lista y actuando como la interfaz de manipulación de los nodos.

Para esta implementación, los nodos son la clase [`NodoListaLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/NodoListaLigada.cs),
y la clase administradora es [`ListaLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/ListaLigada.cs).

### Lista Doblemente Ligada
A raíz del concepto de listas ligadas, en las listas doblemente ligadas cada nodo guarda, además de su referencia al siguiente nodo, una referencia al anterior.

De esta forma, se vuelve posible recorrer secuencialmente en reversa, optimizar la agregación y eliminación de nodos, y simplificar la lógica en varias operaciones.

Para esta implementación, se crearon las clases [`ListaDoblementeLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/ListaDoblementeLigada/ListaDoblementeLigada.cs) y [`NodoListaDoblementeLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/ListaDoblementeLigada/NodoListaDoblementeLigada.cs).

### Pila y Cola
Las pilas y colas son estructuras de datos que exhiben los comportamientos de _"Último en Entrar, Primero en Salir"_ y _"Primero en entrar, Primero en Salir"_ respectivamente.

**Modo de uso**
```cs
Pila pila = new Pila();
pila.Apilar(12);
pila.Apilar("Aa");
pila.Apilar(false);
pila.Desapilar(); //false
pila.Desapilar(); //"Aa"
pila.Desapilar(); //12

Cola cola = new Cola();
cola.Encolar(12);
cola.Encolar("Aa");
cola.Encolar(false);
cola.Desencolar(); //12
cola.Desencolar(); //"Aa"
cola.Desencolar(); //false
```

Si bien pueden ser implementadas de varias formas, se aprovechan las clases `ListaLigada` y `ListaDoblementeLigada` para demostrar más aplicaciones de Listas Ligadas en esta implementación.
* Se tienen las clases [`Pila`](/Estructuras/No%20Genéricas/General/Pila.cs) y [`Cola`](/Estructuras/No%20Genéricas/General/Pila.cs).
* Tanto las pilas como las colas están compuestas por una lista ligada.
* Su funcionalidad no se extiende a mucho más que agregar, quitar y revisar elementos para representar de forma intuitiva los comportamientos descritos previamente.
* Debido a que las listas ligadas hacen la mayor parte del trabajo, su implementación es realmente sencilla.
* En las pilas, las operaciones de agregar y quitar se realizan en **el mismo extremo** de la lista.
* En las colas, las operaciones de agregar y quitar se realizan en **extremos opuestos** de la lista.

### Árbol Binario de Búsqueda
Características:
* Son solo uno de los tipos de estructura de árbol existentes
* Si bien son otra estructura de datos más, no están realmente relacionadas con las discutidas previamente
* La estructura es de carácter jerárquico
* A diferencias de las estructuras anteriores, usan su propio tipo de nodo es un árbol en sí mismo que guarda una referencia a un subárbol izquierdo y un subárbol derecho.
* Aquellos nodos que no tienen subárbol izquierdo ni derecho son "hojas"
* Los elementos siempre se introducen de forma ordenada.
* Debido a que los elementos deben poder ordenarse, deben ser comparables.
* Inserción, eliminación y búsqueda bastante rápidos.
* No indizado. No es el tipo de estructura a usar si se busca trabajar principalmente con índices

**Modo de uso**
```cs
ÁrbolBinario árbol = new ÁrbolBinario();

//Ejemplo pendiente
```

Esta implementación usa las clases [`ÁrbolBinario`](/Estructuras/No%20Genéricas/Árbol%20Binario/ÁrbolBinario.cs) y [`NodoÁrbolBinario`](/Estructuras/No%20Genéricas/Árbol%20Binario/NodoÁrbolBinario.cs) para lo comentado.

## Estructuras Genéricas
Todas las anteriores estructuras (y más) se implementaron también de forma genérica para evitar perder rendimiento y cometer errores de tipado y casteo.

### Interfaces
Se incluyen las mismas del capítulo no genérico pero con implementación genérica
* `IColección<T>`
  * `Cantidad: get int`
  * `Contiene(valor: T): bool`
  * `Limpiar()`
  * `AVector(): T[]`
  * `CopiarEn(destino: T[])`
* `ILista<T>`
  * `this[idx: int]: T`
  * `Agregar(valor: T): int`
  * `Insertar(idx: int, valor: T)`
  * `Quitar(valor: T): int`
  * `QuitarEn(idx: int): T`
  * `ValorEn(idx: int): T`
  * `ÍndiceDe(valor: T): int`

Además, se incluye la interfaz de [`IDiccionario<TClave, TValor>`](/Estructuras/Genéricas/Interfaces/IDiccionario.cs), que en sí misma implementa la interfaz `IColección<ParOrdenado<TClave, TValor>>`
* [`IColección<T>`](/Estructuras/Genéricas/Interfaces/IColección.cs)
* [`ParOrdenado<TClave, TValor`](/Estructuras/Genéricas/ParOrdenado.cs)
* `IDiccionario<TClave, TValor>`
  * `Claves: get TClave[]`
  * `Valores: get TValor[]`
  * `this[clave: TClave]: TValor`
  * `Insertar(clave: TClave, valor: TValor): bool`
  * `Buscar(clave: TClave, resultado: out TValor): bool`
  * `Encontrar(clave: TClave): TValor`
  * `Quitar(clave: TClave): bool`
  * `ContieneClave(clave: TClave): bool`

### Implementaciones de Contrapartes No Genéricas
* Listas Ligadas
  * [`ListaLigada<T>`](/Estructuras/Genéricas/Lista%20Ligada/ListaLigada.cs)
  * [`NodoListaLigada<T>`](/Estructuras/Genéricas/Lista%20Ligada/NodoListaLigada.cs)
* Listas Doblemente Ligadas
  * [`ListaDoblementeLigada<T>`](/Estructuras/Genéricas/Lista%20Ligada/ListaDoblementeLigada/ListaDoblementeLigada.cs)
  * [`NodoListaDoblementeLigada<T>`](/Estructuras/Genéricas/Lista%20Ligada/ListaDoblementeLigada/NodoListaDoblementeLigada.cs)
* Pilas y Colas
  * [`Pila<T>`](/Estructuras/Genéricas/General/Pila.cs)
  * [`Cola<T>`](/Estructuras/Genéricas/General/Pila.cs)
* Árboles Binarios de Búsqueda
  * [`ÁrbolBinario<T>`](/Estructuras/Genéricas/Árbol%20Binario/ÁrbolBinario.cs)
  * [`NodoÁrbolBinario<T>`](/Estructuras/Genéricas/Árbol%20Binario/NodoÁrbolBinario.cs)

 ### Tabla de Hash
Originalmente, una tabla de hashes es una colección de pares clave-valor en la cual se sostiene un arreglo de X tamaño y a los pares que ingresan se les "hashea" la clave para convertirla en un entero que luego se mapea a un índice válido en el arreglo, en el cual se almacenará el valor.

**Modo de uso**
```cs
TablaHash<string, int> tabla = new TablaHash<string, int>(512);
tabla.Insertar("perro", 7);
tabla.Insertar("gato", 2);
tabla.Insertar("conejo", 5);

//...

int v1, v2, v3;
tabla.Buscar("perro", out v1);
MessageBox.Show($"Valor 1 = {v1}");

if(tabla.Buscar("gato", out v2)) {
	MessageBox.Show($"Valor 2 = {v2}");
}

if(tabla.Contiene("conejo")) {
	v3 = tabla.Encontrar("conejo"); //Arroja un error si la clave no existe
	MessageBox.Show($"Valor 3 = {v3}");
}

//Valor 1 = 7 | Valor 2 = 2 | Valor 3 = 5 | Elementos: 3
MessageBox.Show($"Valor 1 = {v1} | Valor 2 = {v2} | Valor 3 = {v3} | Elementos: {tabla.Cantidad}");
```

Esto surge sino con la necesidad de lidiar con "colisiones", que es cuando inevitablemente 2 ó más claves tengan el mismo resultado de hashing. La forma más común de tratar las colisiones es, en lugar de guardar los valores directamente en cada índice, guardar listas ligadas de pares clave-valor en cada índice. Esto introduce una peor complejidad de tiempo lineal, pero sigue teniendo una complejidad promedio constante.

En esta implementación se creó la clase [`TablaHash`](/Estructuras/Genéricas/General/TablaHash.cs) y, con el objetivo de balancear el indizado, se le da al vector interno de la clase la posibilidad de redimensionarse.

Para el redimensionado se tienen en cuenta 4 variables:
* **Capacidad:** no confundir con la Cantidad de elementos que contiene la colección - representa la cantidad de índices, libres o no, que hay a disposición.
* **Cobertura:** representa el porcentaje de índices ocupados en relación a la capacidad actual. Siempre es un valor entre 0 y 1
* **Cobertura máxima:** se define al construir un objeto de tabla e indica ael porcentaje de cobertura en el que se realizará una redimensión. Por ende, también es un valor hasta 1 (aunque el rango inferior es mayor)
* **Factor de redimensión:** se define al construir un objeto de tabla y define cuántas veces crecerá la capacidad al redimensionar el arreglo. Dada la naturaleza de la multiplicación, se decide un factor mínimo de 1.2

### Diccionario
> Documentación pendiente...
