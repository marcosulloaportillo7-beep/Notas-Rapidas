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



## Capturas

Notas

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/c4bc7f39-c8ca-4959-8a03-d78a90540ab1" />


Historial

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/e19e25ad-f37e-424a-87d0-d5673e1ce027" />


Al presionar "Nueva Nota" nos lleva a este apartado

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/84978773-2268-43c4-b80f-1f415e2682ed" />


Al seleccionar una nota se puede editar o eliminar

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/b126a00f-f271-4bcb-8ccd-76df9f85aad4" />


Si se le da "eliminar" saltara un aviso de que si estamos seguros de eliminar la nota

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/66cc5549-86fb-460c-8fc0-88f09ea991ca" />


Y el historial registra todas las acciones que hemos hecho

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/69764f7d-55ea-4ba2-9390-eaee2b05d81e" />


