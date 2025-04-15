# ProyectoBase

![.NET Build & Test](https://github.com/PabloSanabria/ArquetipoBase/actions/workflows/dotnet.yml/badge.svg)
[![codecov](https://codecov.io/gh/PabloSanabria/ArquetipoBase/branch/main/graph/badge.svg)](https://codecov.io/gh/PabloSanabria/ArquetipoBase)

Este proyecto utiliza GitHub Actions para la integración continua y Codecov para el análisis de cobertura de código. Las herramientas empleadas para la generación de reportes de cobertura son:

- `coverlet.collector`: Para la recopilación de datos de cobertura durante la ejecución de pruebas.
- `ReportGenerator`: Para la generación de reportes en formato HTML a partir de los datos recopilados.

## Ejecución Manual de Pruebas con Cobertura

Para ejecutar las pruebas y generar un reporte de cobertura localmente, puedes utilizar los siguientes comandos:

```bash
dotnet test src/ProyectoBase/ProyectoBase.sln --collect:"XPlat Code Coverage"
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coveragereport -reporttypes:Html
```

---
## Estructura de Carpetas

El proyecto está organizado siguiendo una arquitectura por capas, que promueve la separación de responsabilidades y facilita la escalabilidad:

- **Application**: Contiene la lógica de aplicación, servicios y DTOs.
- **Domain**: Incluye las entidades del dominio, interfaces y lógica de negocio pura.
- **Infrastructure**: Implementación de servicios externos, como acceso a base de datos, servicios de terceros, etc.
- **Presentation/WebApi**: Proyecto ASP.NET Core que expone la API.
- **ProyectoBase.Tests**: Proyecto de pruebas unitarias utilizando xUnit.
- **docs** _(opcional)_: Espacio sugerido para documentar decisiones de arquitectura, procesos de despliegue, etc.

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

3. Compilar solución:
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
- Compilar la solución
- Ejecutar pruebas automáticamente en cada push o pull request

El archivo `.github/workflows/dotnet.yml` define el pipeline.

## Buenas prácticas

- Todos los proyectos se encuentran bajo la carpeta `src/`, lo cual evita conflictos y mantiene un orden claro.
- `ProyectoBase.sln` referencia a los proyectos principales y de test.
- Las rutas relativas se mantienen coherentes para compatibilidad con CI/CD.

## 🔧 Configuración post-fork
Después de forkar este repositorio, es recomendable realizar las siguientes configuraciones para asegurar el correcto funcionamiento del proyecto:

1. Configurar GitHub Secrets:
Algunos workflows requieren secrets específicos que no se transfieren automáticamente al hacer un fork.
Asegurate de agregar los siguientes secrets en la sección Settings > Secrets and variables > Actions de tu repositorio:

- CODECOV_TOKEN: Token de Codecov para reportar la cobertura de código.
- DEPLOY_API_KEY: (Opcional) Token para despliegue automático si se configura.

2. Crear un tablero Kanban con GitHub Projects
Para gestionar las tareas y el progreso del proyecto, podés crear un tablero Kanban:

Navegá a la pestaña Projects en tu repositorio.
Hacé clic en "New project" y seleccioná el tipo de vista que prefieras (por ejemplo, Board).
Configurá las columnas según tus necesidades (To do, In progress, Done).

Asociá issues y pull requests al tablero para un seguimiento eficiente.
---

Desarrollado por [Pablo Sanabria](https://github.com/PabloSanabria)
