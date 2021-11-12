# Composite
Es un patr�n estructural. [Link descripci�n](https://www.tutorialspoint.com/design_pattern/composite_pattern.htm)

Este patr�n se basado en una estructura de Arbol se utiliza para componer funcionalidad entre los nodos y hojas siendo transparente para el cliente el conocer la estructura interna del arbol.

## Diagrama de clases
![UML](composite.jpg)

## SOLID

* Single responsibility

El composite tiene la responsabilidad de realizar una acci�n compuesta del propio componente y sus hijos.

* Open/Closed principle

Siempre se pueden implementar nuevas clases que hereden del compisite abstracto por lo que nueva funcionalidad podr�a ser agregada simplemente heredando.

* Liskov substitution

Por naturaleza los composite pueden ser intercambiados y siempre deber�an comportarse como el padre de la jerarquia.

* Interface segregation

Composite tiende a romper este principio ya que el manejo de composici�n entre nodos y hojas hace que la funcionalidad de agregar o listar dependencias este declarada en la superinterfaz, por lo que se rompe con este principio

* Dependency inversion

No hay raz�n para que los composite dependan de implementaciones concretas, siempre pueden referenciar a la interfaz abstracta padre.

