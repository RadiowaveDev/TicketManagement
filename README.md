# 🎫 Sistema de Gestión de Tickets - Aplicación de Consola en C#

Este proyecto es una aplicación de consola escrita en C#, diseñada para gestionar tickets y desarrolladores mediante una arquitectura por capas bien definida. Es ideal como base para sistemas de soporte técnico, gestión de tareas o incidentes.

---

## 🛠️ Arquitectura del Proyecto

El proyecto está dividido en tres capas principales:

SistemaTickets/
│
├── Modelo/
│ ├── Persona.cs (abstract class)
│ ├── Developer.cs
│ ├── Ticket.cs
│ ├── Comment.cs
│ └── Enums/
│ ├── Genero.cs
│ ├── Priority.cs
│ ├── Role.cs
│ ├── TicketCategory.cs
│ └── TicketStatus.cs
│
├── Service/
│ ├── Interfaces/
│ │ ├── IComentarioServicio.cs
│ │ ├── IDeveloperServicio.cs
│ │ └── ITicketServicio.cs
│ └── Implementaciones/
│ ├── ComentarioServicio.cs
│ ├── DeveloperServicio.cs
│ └── TicketServicio.cs
│
├── Utility/
│ ├── SistemaTickets.cs
│ └── Program.cs
---

## 🧠 Principales Características

### 📌 Gestión de Tickets

- `AgregarTicket`: Crea un nuevo ticket con detalles como título, descripción, prioridad, etc.
- `ListarTicket`: Muestra todos los tickets registrados.
- `ObtenerTicketPorId`: Recupera un ticket específico por su ID.
- `EliminarTicket`: Elimina un ticket existente por ID.

### 👨‍💻 Gestión de Desarrolladores

- `AgregarDeveloper`: Agrega un nuevo desarrollador al sistema.
- `ListarDeveloper`: Muestra todos los desarrolladores registrados.
- `ObtenerDeveloperPorId`: Obtiene los detalles de un desarrollador específico.
- `BuscarDeveloper`: Permite buscar desarrolladores por nombre u otro criterio.
- `EliminarDeveloper`: Elimina un desarrollador por ID.

> Todas estas funcionalidades están contenidas y gestionadas por la clase `SistemaTickets.cs`.

---

## 🧩 Uso de Programación Orientada a Objetos

Este proyecto hace uso intensivo de los principios SOLID y buenas prácticas OOP:

### 🧱 Clases y Abstracción

- `Persona` es una clase abstracta base para `Developer`.
- `Developer`, `Ticket` y `Comment` heredan y representan entidades del dominio.

### 🔗 Interfaces

- Interfaces como `IDeveloperServicio`, `ITicketServicio` y `IComentarioServicio` definen contratos para sus servicios.
- Las clases `*Servicio` implementan estas interfaces.

### ⚙️ Enumeraciones

Se definen varios `enum` para mejorar la legibilidad y mantener valores controlados:

- `Genero`: Masculino, Femenino, Otro
- `Priority`: Baja, Media, Alta, Crítica
- `Role`: Frontend, Backend, Fullstack, QA, etc.
- `TicketCategory`: Bug, Feature, Mejora, Otro
- `TicketStatus`: Abierto, En Proceso, Resuelto, Cerrado

---

## ▶️ Ejecución del Proyecto

### Requisitos

- .NET 8.0 o superior
- IDE recomendado: Visual Studio 2022+ o VS Code con extensión de C#

### Ejecutar desde terminal

```bash
dotnet run --project Utility

