internal class Program
{
    private static void Main(string[] args)
    {
        List<Persona> lista=new List<Persona>();
        lista.Add(new Estudiante("Kevin Rodrigo Tumbaco Rivera",13145333538,"Soltero", "Calculo de una Variable" ));
        lista.Add(new Profesor("Henry Javier Macias Lopez", 1415533496, "Casado" , "Matemáticas"));
        lista.Add(new Empleado("Tómmas Andrés Méndez Vera", 1309073342, "Casado", 2015 , 10 , "Sección Secretaria" ));
    }
}