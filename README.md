# Estructuras de Datos
> Práctica de Clases Autorreferenciadas y Estructuras de Datos

Se creó una ventana administradora para la demostración de cada estructura.

## Estructuras No Genéricas
### Interfaces
Se sostienen las interfaces [`IColección`](/Estructuras/No%20Genéricas/Interfaces/IColección.cs) e [`ILista`](/Estructuras/No%20Genéricas/Interfaces/IColección.cs) para definir métodos varios de las Estructuras No Genéricas:
* `IColección`
  * `Cantidad: get int`
  * `Contiene(object valor): bool`
  * `Limpiar()`
  * `AVector(): object[]`
  * `CopiarEn(object[] destino, int índiceInicio = -1, int cantidad = -1)`
* `ILista`
  * `this[idx: int]: object`
  * `Agregar(object valor): int`
  * `Insertar(int idx, object valor)`
  * `Quitar(object valor): int`
  * `QuitarEn(int idx): object`
  * `ValorEn(int idx): object`
  * `ÍndiceDe(object valor): int`

### Lista Ligada
Es una lista que consiste de objetos nodos que tienen cada uno la referencia al siguiente nodo de la lista (están "ligados"). Solo se puede recorrer de forma secuencial hacia delante.

Además de la clase nodo, se tiene una clase administradora que representa la lista en sí, conteniendo esta una referencia al Nodo del principio (la "cabeza") y del final (la "cola") de la lista y actuando como la interfaz de manipulación de los nodos.

Para esta implementación, los nodos son la clase [`NodoListaLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/NodoListaLigada.cs),
y la clase administradora es [`ListaLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/ListaLigada.cs).

### Lista Doblemente Ligada
A raíz del concepto de listas ligadas, en las listas doblemente ligadas cada nodo guarda, además de su referencia al siguiente nodo, una referencia al anterior.

De esta forma, se vuelve posible recorrer secuencialmente en reversa, optimizar la agregación y eliminación de nodos, y simplificar la lógica en varias operaciones.

Para esta implementación, se crearon las clases [`ListaDoblementeLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/ListaDoblementeLigada/ListaDoblementeLigada.cs) y [`NodoListaDoblementeLigada`](/Estructuras/No%20Genéricas/Lista%20Ligada/ListaDoblementeLigada/NodoListaDoblementeLigada.cs).

### Pila y Cola
Las pilas y colas son estructuras de datos que exhiben los comportamientos de _"Último en Entrar, Primero en Salir"_ y _"Primero en entrar, Primero en Salir"_ respectivamente.

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

Esta implementación usa las clases [`ÁrbolBinario`](/Estructuras/No%20Genéricas/Árbol%20Binario/ÁrbolBinario.cs) y [`NodoÁrbolBinario`](/Estructuras/No%20Genéricas/Árbol%20Binario/NodoÁrbolBinario.cs) para lo comentado.

## Estructuras Genéricas
Todas las anteriores estructuras (y más) se implementaron también de forma genérica para evitar perder rendimiento y cometer errores de tipado y casteo.

### Interfaces
Las mismas del capítulo no genérico pero con implementación genérica
* `IColección<T>`
  * `Cantidad: get int`
  * `Contiene(T valor): bool`
  * `Limpiar()`
  * `AVector(): T[]`
  * `CopiarEn(T[] destino, int índiceInicio = -1, int cantidad = -1)`
* `ILista<T>`
  * `this[idx: int]: T`
  * `Agregar(T valor): int`
  * `Insertar(int idx, T valor)`
  * `Quitar(T valor): int`
  * `QuitarEn(int idx): T`
  * `ValorEn(int idx): T`
  * `ÍndiceDe(T valor): int`

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
> En camino...
