
# TFG3 · Panel de administración de empleados

Aplicación de escritorio en C# (Windows Forms) para gestionar la plantilla de una empresa: empleados, fichajes, vacaciones, tareas y comunicación interna, con un asistente de IA integrado.

> Proyecto realizado durante el Grado Superior en Desarrollo de Aplicaciones Multiplataforma (IES Alonso de Avellaneda, 2026).

## Qué hace

- **Login** por número de empleado, con autenticación mediante Supabase Auth.
- **Dashboard** con indicadores en tiempo real: total de empleados, fichajes de hoy, tareas pendientes y solicitudes de vacaciones pendientes, además de gráficos de empleados por departamento.
- **Gestión de empleados y departamentos**: alta de nuevos empleados, ficha de cada trabajador y vista de la plantilla.
- **Fichajes**: registro de entradas y salidas, con informe de fichajes.
- **Vacaciones**: solicitud y gestión de las peticiones, con vista de detalle.
- **Tareas**: creación y seguimiento de tareas asignadas a los empleados.
- **Mensajes y notificaciones** internos entre usuarios.
- **Asistente de IA** (Groq, modelo Llama 3.1) que responde preguntas con el contexto de la aplicación.

## Tecnologías

- C# · .NET 8 · Windows Forms
- Supabase (PostgreSQL + Auth + API REST)
- Groq API (modelo `llama-3.1-8b-instant`)
- iText (generación de informes), LiveCharts y Guna.Charts (gráficos), Guna.UI2, ReaLTaiizor y FontAwesome.Sharp (interfaz)
- Arquitectura por capas: `modelo`, `controllers`, `views` y `services`

## Estructura

```
TFG3/
├── controllers/   Lógica de cada módulo (login, fichajes, vacaciones, tareas...)
├── modelo/        Clases de datos (Trabajador, Fichaje, Vacaciones, Tarea...)
├── services/      Conexión con Supabase
└── views/         Formularios de la aplicación
```

## Cómo ejecutarlo

Requisitos: Windows, Visual Studio 2022 con la carga de trabajo de escritorio .NET y el SDK de .NET 8.

1. Clona el repositorio:
   ```bash
   git clone https://github.com/kvdl94/TFG3.git
   ```
2. Abre `TFG3.slnx` con Visual Studio.
3. Crea tu propio proyecto en [Supabase](https://supabase.com) con las tablas de los modelos (`Trabajador`, `Departamento`, `Fichaje`, `Vacaciones`, `Tarea`, `Mensajes`, `Notificacion`).
4. Configura tus claves: la URL y las claves de Supabase en `services/SupabaseConexion.cs`, y tu clave de Groq en un archivo `Secrets.cs` (incluido en `.gitignore`, no se sube al repositorio).
5. Ejecuta el proyecto con F5.

## Qué aprendí

- Arquitectura por capas en una aplicación de escritorio.
- Autenticación y acceso a datos con Supabase desde C#.
- Consumo de APIs externas (Groq) con `HttpClient`.
- Gestión de secretos y claves fuera del código.

## Autor

Kevin Velasco de Lucas · Madrid · kevinvdl77@gmail.com
