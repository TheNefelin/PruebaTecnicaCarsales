# Backend WebApi .NET 8

API REST desarrollada en **ASP.NET Core (.NET 8)** que expone endpoints para consumir y transformar datos provenientes de una API externa.

## Endpoints principales

### Obtener episodios paginados

```
GET /api/episode?page={number}
```

Respuesta:

* Página actual
* Total de páginas
* Lista de episodios

## Manejo de errores

* Errores de conexión con la API externa
* Respuestas inválidas
* Páginas inexistentes

Los errores son propagados correctamente como respuestas HTTP.

## Configuración

La URL de la API externa se configura en:

```
appsettings.json
```

## CORS

CORS está habilitado para permitir el consumo desde el frontend Angular.

---