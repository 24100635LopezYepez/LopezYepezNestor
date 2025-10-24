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
  
|   Operaciones   |            Descripción            | Complejidad |              Razón              | 
|------------------|-----------------------------------|------|---------------------------------------| 
| Acceso ó Lectura | Obtener el valor en el indice (i) | 0(1) | La dirección se calcula directamente. | 
| Agregar/Eliminar | Añadir/remover elemento en medio. | 0(n) | Se desplazan todo elemento posterior. |  
  
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
| Push/Agregar | 0(1) |  
| Pop/Eliminar | 0(1) |  
  
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
|-------------------|------|  
| Encolar / Agregar | 0(1) |  
| Desencolar/Quitar | 0(1) |  

### Accion Turbo Max
