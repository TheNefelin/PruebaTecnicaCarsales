# Frontend – Angular 21

## Versión de Angular y uso de features modernas

El proyecto fue inicializado utilizando **Angular CLI 21**, ya que es la versión recomendada actualmente por la documentación oficial (`@latest`).

Sin embargo, para cumplir con la consigna de la prueba técnica, **se utilizan explícitamente funcionalidades introducidas en versiones anteriores**:

### Features de Angular 17 utilizadas

* **Standalone Components**
  La aplicación no utiliza `NgModules`.
  Todos los componentes están definidos como `standalone: true`.

* **Nuevo Control Flow**
  Uso de las nuevas directivas:

  * `@for` en lugar de `*ngFor`
  * `@if` en lugar de `*ngIf`

### Features de Angular 18 utilizadas

* **Signals**
  Manejo de estado reactivo utilizando `signal()` y `computed()`, en lugar de `RxJS` para estado local.

* **Directivas mejoradas**
  Uso del nuevo control flow con sintaxis declarativa y más predecible.

### Angular 19

Las funcionalidades principales de Angular 19 están orientadas a:

* Hidratación incremental
* Mejoras de SSR

Dado que este proyecto es una SPA sin SSR, estas features no eran aplicables al alcance de la prueba.

### Conclusión

Aunque el proyecto utiliza Angular 21, **las funcionalidades exigidas por la consigna están implementadas de forma explícita**, cumpliendo completamente los requisitos técnicos solicitados.

---
---
---

# Frontend

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 21.1.0.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

Angular CLI includes powerful code scaffolding tools. To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Vitest](https://vitest.dev/) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
