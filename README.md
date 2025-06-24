# **Tarea Programada 3 - Juegos de Azar**

## **Universidad Fidélitas**  
**Curso:** SC-601 - Programación Avanzada 

**Profesor:** Rojas Matey, Luis Andrés 
**Estudiante FH23014559:** Flores Carmona, Jimena 

**Laboratorio:** M (6PM - 9PM) 
**Grupo:** No. 9 
**Cuatrimestre:** II - 2025  

**Fecha de Entrega:** Miércoles 25 de junio 2025, 6pm

---

## Introducción

Este proyecto forma parte de la **Tarea Programada 3** del curso **Programación Avanzada (SC-601)**. Se ha implementado una aplicación de **consola interactiva** en `C#` utilizando **Entity Framework 6** con enfoque _Code First_, para registrar productos de juegos de azar y generar números aleatorios entre 0 y 99, según condiciones definidas por el usuario.

---

## Especificaciones Funcionales Implementadas

El programa en consola permite:

* **Ingreso interactivo de productos de juegos de azar:**
  - Nombre del producto.
  - Cantidad de números aleatorios a generar.
  - Si los números pueden repetirse (cuando la cantidad es menor o igual a 100).
  - Confirmación para agregar otro producto.

* **Generación controlada de números aleatorios:**  
  Se utilizan estructuras de control y aleatoriedad (`Random`) para generar los valores según los parámetros definidos por el usuario, registrando además el orden de aparición.

* **Almacenamiento y recuperación de datos:**  
  Los productos y sus números se guardan en una base de datos local llamada `TP3` generada automáticamente por EF6.

* **Visualización al finalizar:**  
  Al negarse a registrar otro producto, se despliega una lista de todos los productos con:
  - ID del producto
  - Nombre
  - Fecha y hora de creación
  - ID, orden y valor de cada número generado

---

## Especificaciones Técnicas

* **Lenguaje:** C#  
* **Framework:** .NET Framework 4.8.1  
* **ORM:** Entity Framework 6.0  
* **IDE:** Visual Studio Community 2022  
* **Modelo de Datos (Code First):**
  - `Producto` con `ProductoId`, `Nombre`, `FechaHora`, `ICollection<Numero>`
  - `Numero` con `NumeroId`, `Orden`, `Num`, `ProductoId`  
* **Base de datos:** Se genera automáticamente como `TP3` mediante LocalDB.  
* **Sin uso de Migrations.**

---

## 📚 Recursos de Apoyo y Referencias

### Repositorio del Proyecto  
**Jimena Flores Carmona - FH23014559**  
* [Enlace al repositorio GitHub] *(si aplica)*

### Documentación Consultada  
1. Tutoriales de Entity Framework 6 - Code First en consola  


---

## 🧠 Prompt utilizado para guiar la solución

Durante el desarrollo se consultaron recursos complementarios para implementar correctamente:
- El modelo de entidades usando Code First.
- El contexto y la cadena de conexión.
- La lógica para el flujo interactivo en consola y control de entrada.
- Estrategias para probar y validar el funcionamiento progresivo del sistema.

