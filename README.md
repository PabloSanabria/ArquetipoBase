# ProyectoBase

![.NET Build & Test](https://github.com/PabloSanabria/ArquetipoBase/actions/workflows/dotnet.yml/badge.svg)
[![codecov](https://codecov.io/gh/PabloSanabria/ArquetipoBase/branch/main/graph/badge.svg)](https://codecov.io/gh/PabloSanabria/ArquetipoBase)

Este proyecto utiliza GitHub Actions para la integración continua y Codecov para el análisis de cobertura de código. Las herramientas empleadas para la generación de reportes de cobertura son:

- `coverlet.collector`: Para la recopilación de datos de cobertura durante la ejecución de pruebas.
- `ReportGenerator`: Para la generación de reportes en formato HTML a partir de los datos recopilados.

## ?? Ejecución Manual de Pruebas con Cobertura

Para ejecutar las pruebas y generar un reporte de cobertura localmente, puedes utilizar los siguientes comandos:

```bash
dotnet test src/ProyectoBase/ProyectoBase.sln --collect:"XPlat Code Coverage"
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coveragereport -reporttypes:Html
```

---
## 馃摝 Estructura de Carpetas

El proyecto est谩 organizado siguiendo una arquitectura por capas, que promueve la separaci贸n de responsabilidades y facilita la escalabilidad:

- **Application**: Contiene la l贸gica de aplicaci贸n, servicios y DTOs.
- **Domain**: Incluye las entidades del dominio, interfaces y l贸gica de negocio pura.
- **Infrastructure**: Implementaci贸n de servicios externos, como acceso a base de datos, servicios de terceros, etc.
- **Presentation/WebApi**: Proyecto ASP.NET Core que expone la API.
- **ProyectoBase.Tests**: Proyecto de pruebas unitarias utilizando xUnit.
- **docs** _(opcional)_: Espacio sugerido para documentar decisiones de arquitectura, procesos de despliegue, etc.

```
src/
│
├── Application/
│   └── Lógica de aplicación y casos de uso.
│
├── Domain/
│   └── Entidades, interfaces y lógica de dominio.
│
├── Infrastructure/
│   └── Implementaciones de persistencia, servicios externos.
│
├── Presentation (WebApi)/
│   └── Controladores y configuración de la API.
│
└── ProyectoBase.sln
```

## 鈿欙笍 Requisitos

- .NET 8 SDK
- GitHub Actions (para CI/CD)

## 馃殌 Primeros pasos

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tuusuario/ArquetipoBase.git
   ```

2. Restaurar paquetes:
   ```bash
   dotnet restore src/ProyectoBase/ProyectoBase.sln
   ```

3. Compilar soluci贸n:
   ```bash
   dotnet build src/ProyectoBase/ProyectoBase.sln
   ```

4. Ejecutar pruebas:
   ```bash
   dotnet test src/ProyectoBase/ProyectoBase.sln
   ```

## 馃И Tests

Las pruebas se encuentran bajo el proyecto `ProyectoBase.Tests`. Se utiliza xUnit como framework principal.

## 馃 CI/CD

El proyecto utiliza GitHub Actions para:
- Restaurar dependencias
- Compilar la soluci贸n
- Ejecutar pruebas autom谩ticamente en cada push o pull request

El archivo `.github/workflows/dotnet.yml` define el pipeline.

## 馃搧 Buenas pr谩cticas

- Todos los proyectos se encuentran bajo la carpeta `src/`, lo cual evita conflictos y mantiene un orden claro.
- `ProyectoBase.sln` referencia a los proyectos principales y de test.
- Las rutas relativas se mantienen coherentes para compatibilidad con CI/CD.
## ?? GitHub Projects

Se utiliza un tablero de tipo Kanban para organizar tareas y funcionalidades.

---

Desarrollado con ?? por [Pablo Sanabria](https://github.com/PabloSanabria)
