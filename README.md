# ProyectoBase

![.NET Build & Test](https://github.com/PabloSanabria/ArquetipoBase/actions/workflows/dotnet.yml/badge.svg)
[![codecov](https://codecov.io/gh/PabloSanabria/ArquetipoBase/branch/main/graph/badge.svg)](https://codecov.io/gh/PabloSanabria/ArquetipoBase)

Este proyecto utiliza GitHub Actions para la integraci¨®n continua y Codecov para el an¨¢lisis de cobertura de c¨®digo. Las herramientas empleadas para la generaci¨®n de reportes de cobertura son:

- `coverlet.collector`: Para la recopilaci¨®n de datos de cobertura durante la ejecuci¨®n de pruebas.
- `ReportGenerator`: Para la generaci¨®n de reportes en formato HTML a partir de los datos recopilados.

## Ejecuci¨®n Manual de Pruebas con Cobertura

Para ejecutar las pruebas y generar un reporte de cobertura localmente, puedes utilizar los siguientes comandos:

```bash
dotnet test src/ProyectoBase/ProyectoBase.sln --collect:"XPlat Code Coverage"
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coveragereport -reporttypes:Html
```

---
## Estructura de Carpetas

El proyecto est¨¢ organizado siguiendo una arquitectura por capas, que promueve la separaci¨®n de responsabilidades y facilita la escalabilidad:

- **Application**: Contiene la l¨®gica de aplicaci¨®n, servicios y DTOs.
- **Domain**: Incluye las entidades del dominio, interfaces y l¨®gica de negocio pura.
- **Infrastructure**: Implementaci¨®n de servicios externos, como acceso a base de datos, servicios de terceros, etc.
- **Presentation/WebApi**: Proyecto ASP.NET Core que expone la API.
- **ProyectoBase.Tests**: Proyecto de pruebas unitarias utilizando xUnit.
- **docs** _(opcional)_: Espacio sugerido para documentar decisiones de arquitectura, procesos de despliegue, etc.

```
src/
©¦
©À©¤©¤ Application/
©¦   ©¸©¤©¤ L¨®gica de aplicaci¨®n y casos de uso.
©¦
©À©¤©¤ Domain/
©¦   ©¸©¤©¤ Entidades, interfaces y l¨®gica de dominio.
©¦
©À©¤©¤ Infrastructure/
©¦   ©¸©¤©¤ Implementaciones de persistencia, servicios externos.
©¦
©À©¤©¤ Presentation (WebApi)/
©¦   ©¸©¤©¤ Controladores y configuraci¨®n de la API.
©¦
©¸©¤©¤ ProyectoBase.sln
```

## Requisitos

- .NET 8 SDK
- GitHub Actions (para CI/CD)

## Primeros pasos

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tuusuario/ArquetipoBase.git
   ```

2. Restaurar paquetes:
   ```bash
   dotnet restore src/ProyectoBase/ProyectoBase.sln
   ```

3. Compilar soluci¨®n:
   ```bash
   dotnet build src/ProyectoBase/ProyectoBase.sln
   ```

4. Ejecutar pruebas:
   ```bash
   dotnet test src/ProyectoBase/ProyectoBase.sln
   ```

## Tests

Las pruebas se encuentran bajo el proyecto `ProyectoBase.Tests`. Se utiliza xUnit como framework principal.

## CI/CD

El proyecto utiliza GitHub Actions para:
- Restaurar dependencias
- Compilar la soluci¨®n
- Ejecutar pruebas autom¨¢ticamente en cada push o pull request

El archivo `.github/workflows/dotnet.yml` define el pipeline.

## Buenas pr¨¢cticas

- Todos los proyectos se encuentran bajo la carpeta `src/`, lo cual evita conflictos y mantiene un orden claro.
- `ProyectoBase.sln` referencia a los proyectos principales y de test.
- Las rutas relativas se mantienen coherentes para compatibilidad con CI/CD.
## GitHub Projects

Se utiliza un tablero de tipo Kanban para organizar tareas y funcionalidades.

---

Desarrollado por [Pablo Sanabria](https://github.com/PabloSanabria)
