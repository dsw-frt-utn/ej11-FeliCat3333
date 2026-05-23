using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private static List<Alumno> Alumnos { get; } = new List<Alumno>();

    public static void Add(Alumno alu)
    {
        if (alu is not null) Alumnos.Add(alu);
    }
    public static List<Alumno> GetAlumnos() => Alumnos;

    public static Alumno? FindAlumno(string name) => Alumnos.Find(alu => alu.Nombre.Equals(name));
    public static void RemoveAlumno(Alumno alu) => Alumnos.Remove(alu);
    public static void RemoveAlumnoAt(int pos) => Alumnos.RemoveAt(pos);
}
