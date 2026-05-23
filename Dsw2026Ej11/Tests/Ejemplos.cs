using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        void ListarAlumnos(List<Alumno> alumnos)
        {
            foreach (Alumno a in alumnos)
            {
                Console.WriteLine(a.ToString());
            }
        }
       
        var alu1 = new Alumno(123, "Juan carlos bodoque", 6.6);
        var alu2 = new Alumno(321, "Felipe Rodriguez", 7.5);
        var alu3 = new Alumno(445, "Sergio Juarez", 9.1);
        CasoList.Add(alu1);
        CasoList.Add(alu2);
        CasoList.Add(alu3);

        Console.WriteLine("///// LISTA ACTUAL DE ALUMNOS /////\n");
        ListarAlumnos(CasoList.GetAlumnos());
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("\nIniciando búsqueda de alumno: Juan carlos bodoque");
        var alumnoExistente = CasoList.FindAlumno("Juan carlos bodoque");
        Console.WriteLine($"Alumno encontrado: {alumnoExistente}\n");
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("\nIniciando búsqueda de alumno: Pedro Pascal");
        var alumnoNoExistente = CasoList.FindAlumno("Pedro Pascal");
        if (alumnoNoExistente is null)
            Console.WriteLine("No existe");
        else
            Console.WriteLine($"Alumno encontrado: {alumnoNoExistente}");
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine($"\nProcesando eliminación de alumno: {alu3}");
        CasoList.RemoveAlumno(alu3);
        Console.WriteLine("\n///// Alumno eliminado correctamente /////\n");
        Console.WriteLine("Mostrando lista actualizada: \n");
        ListarAlumnos(CasoList.GetAlumnos());
        Console.WriteLine("-----------------------------------------------");

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        var alumnoEliminado = CasoList.GetAlumnos()[0];
        Console.WriteLine($"\nEliminando alumno en posición 0: {alumnoEliminado}");
        CasoList.RemoveAlumnoAt(0);
        Console.WriteLine("\n///// Alumno eliminado correctamente /////\n");
        Console.WriteLine("Mostrando lista actualizada: \n");
        ListarAlumnos(CasoList.GetAlumnos());
        Console.WriteLine("-----------------------------------------------");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        void ListarAlumnos(Dictionary<int, Alumno> alumnos)
        {
            foreach (KeyValuePair<int, Alumno> alu in alumnos)
            {
                Console.WriteLine(alu.Value.ToString());
            }
        }
        //Agregar 3 alumnos al diccionario
        var alu1 = new Alumno(111, "Anakin Skywalker", 9.3);
        var alu2 = new Alumno(222, "Obi Wan Kenobi", 7.5);
        var alu3 = new Alumno(333, "Mace Windu", 6.3);
        CasoDictionary.Add(alu1);
        CasoDictionary.Add(alu2);
        CasoDictionary.Add(alu3);

        //Listar por consola los alumnos
        Console.WriteLine("---Alumnos en el Diccionario---\t");
        ListarAlumnos(CasoDictionary.GetAlumnos());
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("\nIniciando búsqueda de alumno con clave: 111");
        var alumnoEncontrado = CasoDictionary.FindAlumno(111);
        Console.WriteLine($"Alumno encontrado: {alumnoEncontrado}");
        Console.WriteLine("---------------------------------\n");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\nIniciando búsqueda de alumno con clave: 99");
        var alumnoNoEncontrado = CasoDictionary.FindAlumno(99);
        if (alumnoNoEncontrado is null)
            Console.WriteLine("El alumno no existe en el diccionario");
        else
            Console.WriteLine($"Alumno encontrado: {alumnoNoEncontrado}");
        Console.WriteLine("---------------------------------\n");

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\nProcesando eliminación de alumno con clave: 111");
        CasoDictionary.RemoveAlumno(111);
        Console.WriteLine("\n ///// Alumno eliminado correctamente /////");
        Console.WriteLine("\nMostrando lista actualizada de alumnos:\n");
        ListarAlumnos(CasoDictionary.GetAlumnos());
        Console.WriteLine("---------------------------------\n");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("1) Obtener el primer libro");
        var primerLibro = CasoLinq.GetPrimero();
        Console.WriteLine($"Primer Libro:\nID: {primerLibro?.Id} | Titulo: {primerLibro?.Titulo} | Precio: ${primerLibro?.Precio}\n");
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("2) Obtener el último libro");
        var ultimoLibro = CasoLinq.GetUltimo();
        Console.WriteLine($"Último Libro:\nID: {ultimoLibro?.Id} | Titulo: {ultimoLibro?.Titulo} | Precio: ${ultimoLibro?.Precio}\n");
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("3) Obtener la suma de los precios:");
        Console.WriteLine($"Suma de precios: {CasoLinq.GetTotalPrecios():n2}\n");
        Console.WriteLine("---------------------------------\n");


        Console.WriteLine("4) Obtener el promedio de precios:");
        Console.WriteLine($"Promedio de precios: {CasoLinq.GetPromedioPrecios():n2}\n");
        Console.WriteLine("---------------------------------\n");


        Console.WriteLine("5) Obtener la lista de libros con Id mayor a 15");
        Console.WriteLine("\n\tID\tTITULO\t\tPRECIO");
        Console.WriteLine("------------------------------------------");
        foreach (var libro in CasoLinq.GetListById())
        {
            Console.WriteLine($"\t{libro?.Id} | {libro?.Titulo} | ${libro?.Precio}\n");
        }
        Console.WriteLine("---------------------------------\n");


        Console.WriteLine("6) Obtener la lista de libros en el formato especificado");
        Console.WriteLine("\n\tTITULO\t\tPRECIO");
        Console.WriteLine("------------------------------------------");
        foreach (var libro in CasoLinq.GetLibros())
        {
            Console.WriteLine($"\t{libro}");
        }
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("7) Obtener el libro con el precio más alto");
        var precioAlto = CasoLinq.GetMayorPrecio();
        Console.WriteLine($"Libro:\nID: {precioAlto?.Id} | Titulo: {precioAlto?.Titulo} | Precio: ${precioAlto?.Precio}\n");
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("8) Obtener el libro con el precio más bajo");
        var precioBajo = CasoLinq.GetMenorPrecio();
        Console.WriteLine($"Libro:\nID: {precioBajo?.Id} | Titulo: {precioBajo?.Titulo} | Precio: ${precioBajo?.Precio}\n");
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("9) Obtener la lista de libros con un precio mayor al promedio");
        Console.WriteLine("\n\tID\tTITULO\t\tPRECIO");
        Console.WriteLine("------------------------------------------");
        foreach (var libro in CasoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"\t{libro?.Id} | {libro?.Titulo} | ${libro?.Precio}\n");
        }
        Console.WriteLine("---------------------------------\n");


        Console.WriteLine("10) Obtener la lista de libros ordenados de forma descendente");
        Console.WriteLine("\n\tID\tTITULO\t\tPRECIO");
        Console.WriteLine("------------------------------------------");
        foreach (var libro in CasoLinq.GetLibrosOrdenados())
        {
            Console.WriteLine($"\t{libro?.Id} | {libro?.Titulo} | ${libro?.Precio}\n");
        }
        Console.WriteLine("---------------------------------\n");

    }
}
