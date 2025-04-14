
# ProyectoBase

![Build Status](https://github.com/PabloSanabria/ArquetipoBase/actions/workflows/dotnet.yml/badge.svg)

![Coverage](https://codecov.io/gh/PabloSanabria/ArquetipoBase/branch/main/graph/badge.svg)


## 📦 Estructura de Carpetas

El proyecto está organizado siguiendo una arquitectura por capas, que promueve la separación de responsabilidades y facilita la escalabilidad:

- **Application**: Contiene la lógica de aplicación, servicios y DTOs.
- **Domain**: Incluye las entidades del dominio, interfaces y lógica de negocio pura.
- **Infrastructure**: Implementación de servicios externos, como acceso a base de datos, servicios de terceros, etc.
- **Presentation/WebApi**: Proyecto ASP.NET Core que expone la API.
- **ProyectoBase.Tests**: Proyecto de pruebas unitarias utilizando xUnit.
- **docs** _(opcional)_: Espacio sugerido para documentar decisiones de arquitectura, procesos de despliegue, etc.

## ⚙️ Requisitos

- .NET 8 SDK
- GitHub Actions (para CI/CD)

## 🚀 Primeros pasos

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

## 🧪 Tests

Las pruebas se encuentran bajo el proyecto `ProyectoBase.Tests`. Se utiliza xUnit como framework principal.

## 🤖 CI/CD

El proyecto utiliza GitHub Actions para:
- Restaurar dependencias
- Compilar la solución
- Ejecutar pruebas automáticamente en cada push o pull request

El archivo `.github/workflows/dotnet.yml` define el pipeline.

## 📁 Buenas prácticas

- Todos los proyectos se encuentran bajo la carpeta `src/`, lo cual evita conflictos y mantiene un orden claro.
- `ProyectoBase.sln` referencia a los proyectos principales y de test.
- Las rutas relativas se mantienen coherentes para compatibilidad con CI/CD.
