# StrategyPatternDuckSim
*Diseño de un sistema de personajes de un juego de patos utilizando el patrón Strategy en C#*

**Se busca poder despejar el codigo y tener una estructura que permita agregar futuras funcionalidades sin comprometer el funcionamiento del programa**


NOTAS
  1. Si se quiere agregar un nuevo tipo de *pato* ; basta con crear la clase que implemente la superclase **pato** y que pueda definir sus propios valores
  2. En caso de que se quiera agregar una nueva forma de realizar cierto comportamiento de los patos, se puede hacer agregando una nueva clase del tipo de comportamiento ya creado para solo implementar la interfaz y establecer su característica.
  3. En caso de ser un nuevo comportamiento; solo debe crear una nueva interface o plantilla para las nuevas funcionalidades que vayan adoptar este nuevo comportamiento

**SOLO ES UN MODELO**
