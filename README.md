# Notas Rápidas

Aplicación desarrollada con .NET MAUI que permite gestionar notas utilizando SQLite como base de datos local.


## Características

- Crear notas.
- Listar notas almacenadas.
- Editar notas existentes.
- Eliminar notas.
- Registro de historial de acciones.
- Persistencia de datos mediante SQLite.
- Navegación mediante Shell.


## Tecnologías utilizadas

- .NET MAUI
- C#
- SQLite
- Visual Studio 2022


## Estructura del proyecto

```
Models
├── Nota.cs
├── Historial.cs

Services
├── NotasDatabase.cs

Views
├── NotasPage.xaml
├── DetalleNotaPage.xaml
├── HistorialPage.xaml
```

## Funcionalidades implementadas

### Gestión de notas
- Crear nuevas notas.
- Visualizar notas guardadas.
- Editar el título de una nota.
- Eliminar notas existentes.

### Historial
El sistema registra automáticamente las siguientes acciones:

- Creación de notas.
- Edición de notas.
- Eliminación de notas.

### Base de datos
Se utiliza SQLite para almacenar de forma local:

- Notas.
- Historial de acciones.

## Requisitos

- Visual Studio 2022
- .NET MAUI
- sqlite-net-pcl
- SQLitePCLRaw.bundle_green

## Ejecución

1. Clonar el repositorio.
2. Abrir la solución en Visual Studio.
3. Restaurar paquetes NuGet.
4. Seleccionar un dispositivo Android o emulador.
5. Ejecutar la aplicación.
