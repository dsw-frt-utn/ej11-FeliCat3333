using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private static List<Libro> _libros = Libro.CrearLista();
    public static Libro? GetPrimero() => _libros.FirstOrDefault();
    public static Libro? GetUltimo() => _libros.LastOrDefault();
    public static Decimal GetTotalPrecios() => (from libro in _libros select libro.Precio).Sum();
    public static Decimal GetPromedioPrecios() => (from libro in _libros select libro.Precio).Average();
    public static List<Libro> GetListById() => (from libro in _libros where libro.Id > 15 select libro).ToList();
    public static List<string> GetLibros()
    {
        var librosEnumerados = from libro in _libros select (libro.Titulo, string.Format("{0:c}", libro.Precio));
        var libros = new List<string>();
        foreach (var libroEnum in librosEnumerados)
        {
            libros.Add(libroEnum.ToString());
        }
        return libros;

    }
    public static List<string> GetLibrosAcortado() => (from libro in _libros select (libro.Titulo, string.Format("{0:c}", libro.Precio)).ToString()).ToList();
    public static Libro? GetMayorPrecio() => (from libro in _libros orderby libro.Precio descending select libro).FirstOrDefault();
    public static Libro? GetMenorPrecio() => (from libro in _libros orderby libro.Precio select libro).FirstOrDefault();
    public static List<Libro>? GetMayorPromedio() => (from libro in _libros where libro.Precio > GetPromedioPrecios() select libro).ToList();
    public static List<Libro>? GetLibrosOrdenados() => (from libro in _libros orderby libro.Titulo descending select libro).ToList();
}
