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
 - Grafos  
 - Arboles  
 - Conjuntos  
 - Diccionarios
  
   
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

## Grafos (Graphs)  
Un Grafo ($G$) es una estructura de datos no lineal que se utiliza para modelar relaciones por pares entre objetos. Se define formalmente como un par de conjuntos: $G = (V, E)$, donde $V$ es el conjunto de vértices (o nodos) y $E$ es el conjunto de aristas (o lados) que conectan estos vértices.  
  
**Características Clave**  
- Vértices (V): Representan los objetos o entidades (ej., ciudades en un mapa, personas en una red social).  
- Aristas (E): Representan la conexión o relación entre dos vértices.  
  
**Tipos Comunes de Grafos**  
- Grafos No Dirigidos: Las aristas no tienen una dirección específica. Si la arista $(u, v)$ existe, significa que la conexión es bidireccional (de $u$ a $v$ y de $v$ a $u$).  
- Grafos Dirigidos (Digraphs): Las aristas tienen una dirección definida, usualmente indicada con una flecha. Si la arista va de $u$ a $v$, no implica automáticamente una conexión de $v$ a $u$.  
- Grafos Ponderados: Cada arista tiene asociado un valor numérico, llamado peso o costo (ej., la distancia entre ciudades o el tiempo de un proceso).  
  
**Implementación y Aplicaciones**  
- Implementación: Se suelen representar mediante una Matriz de Adyacencia (donde $A[i][j]$ indica si hay una arista entre el nodo $i$ y el nodo $j$) o una Lista de Adyacencia (donde cada nodo tiene una lista de los nodos a los que está conectado).  
- Aplicaciones: Redes de transporte, sistemas GPS (algoritmos de ruta más corta como Dijkstra), redes sociales, y modelado de dependencias en compiladores.  
  
## Árboles (Trees)
Un Árbol es un tipo especial de grafo dirigido, acíclico (sin ciclos) y conectado, donde hay un nodo designado llamado raíz, y cada nodo tiene un único camino desde la raíz. Los árboles se utilizan para representar estructuras jerárquicas.  
**Terminología Clave**  
- Raíz: El nodo superior del árbol; no tiene nodos padres.Hijos: Nodos directamente conectados y debajo de un nodo padre.  
- Hoja: Un nodo que no tiene hijos.  
- Altura: La longitud del camino más largo desde la raíz hasta una hoja.
   
**Tipos Comunes de Árboles**
- Árbol Binario (Binary Tree): Cada nodo tiene como máximo dos hijos (izquierdo y derecho). Es la forma más básica.  
- Árbol Binario de Búsqueda (Binary Search Tree - BST): Un árbol binario con una propiedad de orden: para cualquier nodo, todos los valores en su subárbol izquierdo son menores que el valor del nodo, y todos los valores en su subárbol derecho son mayores. Esto permite operaciones de búsqueda, inserción y eliminación eficientes.  
- Árboles Balanceados (AVL, Rojo-Negro): Variantes del BST que implementan reglas de "auto-balanceo" después de cada operación de inserción o eliminación. Esto garantiza que la altura del árbol permanezca logarítmica ($O(\log n)$), previniendo el peor caso (árbol degenerado) que podría degradar la complejidad a $O(n)$.AplicacionesSistemas de archivos (jerarquía de directorios), bases de datos (índices), y representación de expresiones matemáticas (árboles de expresión).
  
## Conjuntos (Sets)  
Un Conjunto es una colección no ordenada de elementos únicos. El concepto se basa directamente en la teoría matemática de conjuntos.
**Características Clave**
- Elementos Únicos: Un conjunto no puede contener duplicados. La inserción de un elemento que ya existe no tiene efecto.
- No Ordenado: A diferencia de un arreglo o una lista, los elementos de un conjunto no tienen una posición o índice definido.
- Membresía Rápida: La principal fortaleza de los conjuntos es su capacidad para verificar la existencia de un elemento de forma extremadamente rápida, a menudo en tiempo promedio $O(1)$. Esto generalmente se logra implementándolos internamente utilizando tablas hash (hashing).
-   
**Operaciones Clave:**  
- Agregar (Add): Añadir un elemento al conjunto.
- Eliminar (Remove): Eliminar un elemento del conjunto.
- Contiene (Contains): Verificar si un elemento es miembro del conjunto.
- Operaciones de Conjuntos:  
   - Unión: Crea un nuevo conjunto que contiene todos los elementos de ambos conjuntos.
   - Intersección: Crea un nuevo conjunto que contiene solo los elementos comunes a ambos conjuntos.
   - Diferencia: Crea un nuevo conjunto con los elementos del primer conjunto que no están en el segundo.
   -   
**Aplicaciones:** Filtrado de duplicados, prueba de membresía eficiente, modelado de relaciones únicas, entre otras mas.

##4. Diccionarios (Dictionaries / Maps)
Un Diccionario (también conocido como Mapa, Tabla Hash o Arreglo Asociativo) es una estructura de datos que almacena datos en forma de pares de clave-valor (key-value).  
  
Características Clave  
- Clave-Valor: Cada valor está asociado y se accede a través de una clave única.  
- Clave Única: Las claves deben ser únicas (al igual que los elementos en un conjunto). Si se intenta insertar una clave existente, generalmente se sobrescribe el valor anterior.  
- Acceso por Clave: El acceso a los datos no se realiza por un índice numérico, sino por el valor de la clave.Eficiencia: Los diccionarios se implementan casi siempre utilizando tablas hash. Esto permite que las operaciones fundamentales de inserción, eliminación y búsqueda tengan una complejidad de tiempo promedio de $O(1)$ (tiempo constante), lo que las hace excepcionalmente rápidas para grandes volúmenes de datos.  
  
Estructura y Funcionamiento 
- Función Hash (Hashing): Cuando se inserta un par (Clave, Valor), la clave se pasa a través de una función hash. Esta función calcula un índice (dirección) dentro de un arreglo interno.  
- Almacenamiento: El valor se almacena en el índice calculado.Colisiones: Si dos claves diferentes producen el mismo índice (una colisión), se utilizan técnicas como encadenamiento (almacenar los elementos conflictivos en una lista enlazada en esa dirección) o sondeo lineal (buscar la siguiente posición vacía) para resolver el conflicto.
**Aplicaciones:** Contadores de frecuencia, almacenamiento de configuraciones de usuario, implementación de bases de datos indexadas y almacenamiento de propiedades de objetos en muchos lenguajes de programación.
