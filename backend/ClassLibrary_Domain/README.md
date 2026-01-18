# Domain Layer

Este proyecto representa la **capa de dominio** de la solución y forma parte de la separación de responsabilidades siguiendo principios de **Clean Architecture**.

## Estado actual

Para el alcance de esta prueba técnica **no fue necesario implementar lógica de dominio**, debido a que:

* La aplicación actúa como consumidor de una API externa (Rick and Morty API)
* No existen reglas de negocio propias
* No se definen entidades con comportamiento ni invariantes
* No se requieren agregados, value objects ni servicios de dominio

El backend funciona principalmente como un **BFF (Backend for Frontend)**, realizando:

* Consumo de datos externos
* Transformación de modelos
* Manejo de errores
* Exposición de endpoints propios

## Motivo de su existencia

La capa Domain se mantiene en la solución para:

* Preservar una arquitectura escalable
* Facilitar la incorporación futura de reglas de negocio
* Mantener desacoplamiento entre capas

En un escenario real, esta capa sería el lugar correcto para implementar:

* Entidades de dominio
* Value Objects
* Reglas de negocio
* Interfaces de repositorio
