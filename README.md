# **Tarea Programada 3 - Sistema de Juegos de Azar 🎲**

## **Universidad Fidélitas**  
**Curso:** SC-601 - Programación Avanzada 

**Profesor:** Rojas Matey, Luis Andrés 
**Estudiante FH23014559:** Flores Carmona, Jimena 

**Laboratorio:** M (6PM - 9PM) 
**Grupo:** No. 9 
**Cuatrimestre:** II - 2025  

**Fecha de Entrega:** Miércoles 25 de junio 2025, 6pm

---

## 🎯 Introducción

Este proyecto forma parte de la **Tarea Programada 3** del curso **Programación Avanzada (SC-601)**. Se ha implementado una aplicación de **consola interactiva** en `C#` utilizando **Entity Framework 6** con enfoque _Code First_, para registrar productos de juegos de azar y generar números aleatorios entre 0 y 99, según condiciones definidas por el usuario.

---

## ⚙️ Especificaciones Funcionales Implementadas

El programa en consola permite:

* **Ingreso interactivo de productos de juegos de azar:**
  - Nombre del producto.
  - Cantidad de números aleatorios a generar.
  - Si los números pueden repetirse (cuando la cantidad es menor o igual a 100).
  - Confirmación para agregar otro producto.

* **Generación controlada de números aleatorios:**  
  Se utilizan estructuras de control y aleatoriedad (`Random`) para generar los valores según los parámetros definidos o las condiciones ingresadas por el usuario (con/sin repetición), registrando además el orden de aparición.

* **Almacenamiento y recuperación en la Base de Datos:**  
  Se utiliza **EF6 (Entity Framework)** para almacenar automáticamente los productos y sus números que se guardan en una base de datos local llamada `TP3`.

* **Visualización al finalizar:**  
  Cuando el usuario opta por no ingresar más productos, se despliega en la consola una lista resumida de todos los productos con:
  - ID del producto
  - Nombre
  - Fecha y hora de creación
  - ID, orden y valor de cada número generado

---

## ⚙️ Especificaciones Técnicas

* **Lenguaje:** C#  
* **Framework:** .NET Framework 4.8.1  
* **ORM:** Entity Framework 6.0  
* **IDE:** Visual Studio Community 2022  
* **Modelo de Datos (Code First):**
  - `Producto` con `ProductoId`, `Nombre`, `FechaHora`, `ICollection<Numero>`
  - `Numero` con `NumeroId`, `Orden`, `Num`, `ProductoId`  
* **Base de datos:** LocalDB `TP3` generada automáticamente **sin uso de Migrations**.
* - **Estructura del proyecto:** Solución `.sln` con un proyecto individual. Se excluyen carpetas `bin/` y `obj/` en la entrega.  

---

## 💻 Instrucciones para Ejecutar el Proyecto

1. Abrir el archivo `.sln` en Visual Studio 2022.  
2. Compilar la solución (`Ctrl+Shift+B`) y verificar que no haya errores.  
3. Ejecutar (`F5`) el proyecto en modo consola.  
4. Ingresar los datos solicitados según el flujo interactivo.  
5. Al finalizar, se mostrarán los productos y sus números registrados.

---

## 📚 Recursos de Apoyo y Referencias

### Repositorio del Proyecto  
**Jimena Flores Carmona - FH23014559**  
* Link: https://github.com/JimeFlow/SC-601_JimenaFloresCarmona_TareaProgramada3.git
* [Enlace al repositorio GitHub](https://github.com/JimeFlow/SC-601_JimenaFloresCarmona_TareaProgramada3.git)

### Documentación Consultada  
1. Guías introductorias y tutoriales de Entity Framework 6 - Code First en consola
2. [EF6 Documentation - Code First Basics](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database)
   - Documentación oficial que explica cómo comenzar con el enfoque Code First en Entity Framework 6 para crear una nueva base de datos desde cero. Incluye ejemplos paso a paso sobre cómo definir clases de entidad, configurar el contexto (`DbContext`), establecer la cadena de conexión y ejecutar operaciones básicas para que EF6 genere automáticamente la estructura de la base de datos.
3. [Code First en una base de datos existente: EF6 | Microsoft Learn](https://learn.microsoft.com/es-es/ef/ef6/modeling/code-first/workflows/existing-database)  
    - Guía oficial de Microsoft sobre cómo trabajar con el enfoque Code First con Entity Framework 6 para modelar clases y generar automáticamente la base de datos desde código, además de trabajar en bases de datos existentes.
    - Incluye ejemplos detallados y configuración de clases, contexto y conexión, así como buenas prácticas para mantener consistencia entre el modelo y la base de datos.
4. [Documentación de System.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random)

---
### 🤖 Prompt del ChatBot de IA utilizada para la Solución: _Copilot_

Durante el desarrollo de la **Tarea Programada 3**, conté con el acompañamiento de **Copilot** para construir una aplicación en `C#` de consola utilizando **Entity Framework 6** con enfoque *Code First*. El objetivo era registrar productos y números de juegos de azar en una base de datos, con interacción dinámica con el usuario.

**Consultas realizadas:**  
- Solicité guía paso a paso sobre cómo estructurar el proyecto en Visual Studio 2022, utilizando .NET Framework 4.8.1 y EF6 sin Migrations.
- Pedí ayuda detallada para definir las entidades Producto y Numero basadas en un diagrama de clases.
- Aprendí a construir el DbContext llamado TP3Context, incluyendo cómo configurar correctamente la conexión en el archivo App.config.
- Consulté sobre el significado de íconos en Visual Studio (como la estrellita verde).
- Solicité implementación del flujo completo en Program.cs, incluyendo:
- Captura de datos del usuario con preguntas interactivas.
- Generación de números aleatorios, con y sin repetición.
- Almacenamiento de datos en base de datos.
- Visualización de todos los productos y sus números ordenados por fecha.
- Se probó el entorno de EF6 ejecutando una inserción de prueba para verificar la creación automática de la base de datos.

**Resultado:**  
Gracias al proceso guiado con Copilot, logré cumplir los requisitos técnicos y funcionales del proyecto, reforzando mis conocimientos en EF6, diseño de entidades y manejo interactivo en C#.

---
