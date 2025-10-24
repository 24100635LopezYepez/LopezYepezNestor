# CONCEPTOS de Estructura de datos fundamentales
"[24100635] Lopez Yepez Nestor Daniel (Octubre / 2025)"  
Las estructuras de datos son formas específicas de organizar y almacenar información para que pueda ser utilizada de manera eficiente. Son esenciales para el diseño de algoritmos eficaces. A continuación, se presentan las siguiente estructuras de datos mas *comunes*:
 - Arreglos  
 - Pilas  
 - Cola  
 - Listas  
     - Simples (Un punto al siguiente)  
     - Dobles (Un punto al anterior y siguiente)  
     - Circulares (El final es el inicio y viceversa)  
  
## Arreglos 
Un arreglo es la estructura de datos más básica y común. Se define como una colección de elementos del mismo tipo de datos (por ejemplo, solo enteros o solo cadenas), almacenados en ubicaciones de memoria contiguas (adyacentes).  
***Características Clave***  
- Contigüidad: La característica definitoria de un arreglo es que sus elementos se guardan uno al lado del otro en la memoria. Esto permite un acceso muy rápido.  
- Tamaño Fijo: En muchos lenguajes de programación (como C o Java al ser declarados), el tamaño de un arreglo debe definirse al crearlo y no puede modificarse dinámicamente. Los lenguajes más modernos a menudo ofrecen "arreglos dinámicos" (como ArrayList en Java o List en C#), que son estructuras que gestionan internamente arreglos estáticos, recreándolos y copiando los datos cuando se necesita expandir su capacidad.  
- Acceso Directo (Acceso Aleatorio): Se puede acceder a cualquier elemento de un arreglo directamente utilizando su índice (posición), sin tener que recorrer los elementos previos. La complejidad del acceso es O(1) (tiempo constante), ya que la dirección de memoria de cualquier elemento se calcula fácilmente a partir de la dirección base y el tamaño del tipo de dato.  
  
|   Operaciones    |            Descripción            | Complejidad |                 Razón                 | 
|------------------|-----------------------------------|-------------|---------------------------------------| 
| Acceso ó Lectura | Obtener el valor en el indice (i) |    $0(1)$   | La dirección se calcula directamente. | 
| Agregar/Eliminar | Añadir/remover elemento en medio. |    $0(n)$   | Se desplazan todo elemento posterior. |  
  
## Pilas 🔋
Una pila es una estructura de datos lineal y abstracta que sigue el principio LIFO (Last-In, First-Out), que significa que el último elemento añadido es el primero en ser eliminado. Es análoga a una pila de platos: solo se puede acceder al plato superior.  
  
***Características Clave***  
- LIFO: El elemento más reciente es el único accesible para la eliminación.  
- Abstracción: Una pila puede implementarse utilizando un arreglo (con un índice Tope o Top) o una lista enlazada (generalmente más eficiente para inserción/eliminación).  
- Aplicaciones: Gestión de llamadas a funciones (la pila de llamadas), verificación de sintaxis (como el balanceo de paréntesis o etiquetas XML), y algoritmos de recorrido (como la Búsqueda en Profundidad - DFS).  
  
***Operaciones Clave (Métodos)***
- Push (Apilar): Añade un elemento a la cima de la pila.  
- Pop (Desapilar): Elimina el elemento de la cima de la pila y lo devuelve.  
- Peek (Cima): Devuelve el elemento de la cima sin eliminarlo.  
- IsEmpty: Verifica si la pila no contiene elementos.    
  
| Operaciones  | Complejidad |  
|--------------|------|  
| Push/Agregar | $0(1)$ |  
| Pop/Eliminar | $0(1)$ |  
  
## Cola / Fila
Una cola es una estructura de datos lineal y abstracta que sigue el principio FIFO (First-In, First-Out), que significa que el primer elemento añadido es el primero en ser eliminado. Es análoga a una fila de personas esperando: la primera en llegar es la primera en ser atendida.  
  
***Características Clave***  
- FIFO: El elemento más antiguo es el único accesible para la eliminación.  
- Puntos de Operación: La inserción (enfilamiento) ocurre en la parte trasera (o Tail/Rear) y la eliminación (desenfilamiento) ocurre en la parte delantera (o Head/Front).  
- Abstracción: Las colas a menudo se implementan utilizando una lista enlazada (más eficiente) o un arreglo circular.  
- Aplicaciones: Gestión de tareas en sistemas operativos (cola de procesos), gestión de impresiones, procesamiento de datos en streaming y Búsqueda en Amplitud (BFS).  
  
***Operaciones Clave (Métodos)***
- Enqueue (Encolar): Añade un elemento al final de la cola (Rear/Tail).
- Dequeue (Desencolar): Elimina el elemento del frente de la cola (Head/Front) y lo devuelve.
- Peek/Front: Devuelve el elemento del frente sin eliminarlo.
  
|    Operaciones    | Complejidad |  
|-------------------|-------------|  
| Encolar / Agregar |   $0(1)$    |  
| Desencolar/Quitar |   $0(1)$    |   

## Listas (Enlazadas)
Una lista enlazada es una colección lineal de elementos de datos (llamados nodos) donde el orden no está dado por su ubicación física en la memoria (como en un arreglo), sino por punteros o referencias. Cada nodo contiene el dato y un puntero al siguiente nodo. La principal ventaja de las listas enlazadas es la inserción y eliminación eficientes ($O(1)$ una vez que se localiza el nodo), ya que solo requiere cambiar la referencia del puntero, sin necesidad de desplazar grandes bloques de memoria.  
  
### Tipos de Listas  
- **Lista Simplemente Enlazada (Singly Linked List)**  
  - Estructura: Cada nodo apunta solamente al siguiente nodo en la secuencia.  
  - Navegación: Solo permite el recorrido en una dirección (hacia adelante).  
  - Nodo: Contiene Dato y Siguiente (puntero al nodo sucesor). El último nodo apunta a NULO.  
  - Ventaja: Es la más fácil de implementar y requiere el menor espacio de almacenamiento adicional por nodo (solo un puntero).  
  - Aplicaciones: Implementación de otras estructuras de datos como Pilas y Colas. Listas de reproducción de música simples. Manejo de historial (solo se necesita avanzar).  
  
- **Lista Doblemente Enlazada (Doubly Linked List)**  
  - Estructura: Cada nodo apunta tanto al siguiente como al anterior nodo en la secuencia.  
  - Navegación: Permite el recorrido en ambas direcciones (hacia adelante y hacia atrás).  
  - Nodo: Contiene el Dato, los punteros Siguiente (nodo sucesor) y Anterior (nodo predecesor). El puntero Anterior del $1°$ nodo y el puntero Siguiente del último nodo apuntan a NULO.
  - Ventaja: Facilita la eliminación de un nodo, ya que se puede acceder fácilmente al nodo previo.
  - Aplicaciones: Implementación de cachés LRU (Least Recently Used). Sistemas de navegación y edición (botones Deshacer/Rehacer). Estructuras que requieren iteración bidireccional.  
  
- **Lista Enlazada Circular (Circular Linked List)**  
  - Estructura: Similar a las listas simples o dobles, pero el último nodo apunta al primer nodo (cabeza) de la lista, creando un ciclo. No hay punteros NULO en la secuencia.  
  - Navegación: Puede recorrerse indefinidamente.  
  - Nodo: Es típicamente similar a una lista simple o doble, pero la diferencia clave es que el puntero Siguiente del último nodo apunta al primer nodo de la lista (Cabeza).  
  - Ventaja: Permite recorrer la lista hacia adelante y hacia atrás. Siempre se tiene acceso al nodo anterior y al siguiente.  
  - Aplicaciones: Algoritmos de asignación de tiempo de CPU (Round Robin), loops en estructuras de datos, y simulación de ciclos.

|    Operaciones    | Complejidad |  
|-------------------|-------------|  
| Insertar/Eliminar |    $0(1)$   |  
| Busqueda o Acceso |    $0(n)$   |  
