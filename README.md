# Prueba Técnica Carsales

Solución fullstack desarrollada como prueba técnica, compuesta por un backend en **.NET 8** y un frontend en **Angular 21**, consumiendo datos desde la API pública de Rick and Morty.

## Tecnologías

* Backend: .NET 8, ASP.NET Core Web API
* Frontend: Angular 18 (Standalone, Signals)
* Estilos: CSS puro (sin frameworks)
* API externa: Rick and Morty API

## Estructura del repositorio

* `WebApi`: API REST
* `ClassLibrary_Domain`: Entidades de dominio
* `ClassLibrary_Application`: Lógica de aplicación y contratos
* `ClassLibrary_Infrastructure`: Integración con APIs externas
* `Frontend`: Aplicación Angular

## Cómo ejecutar el proyecto

### Backend

1. Abrir la solución en Visual Studio
2. Ejecutar el proyecto `WebApi`
3. La API quedará disponible en:

```
https://localhost:7240
```
- Opcional por consola
```sh
cd backend
dotnet restore
dotnet run
```

### Frontend

```bash
cd frontend
npm install
ng serve
```

La aplicación estará disponible en:

```
http://localhost:4200
```

## Funcionalidades

* Listado paginado de episodios
* Consumo de API externa
* Manejo de errores
* Arquitectura desacoplada
* Uso de features modernas de Angular

---

Este proyecto fue desarrollado siguiendo principios SOLID y buenas prácticas.

## Documentación técnica

- [Frontend - Angular](frontend/README.md)
- [Backend - WebApi](backend/README.md)
