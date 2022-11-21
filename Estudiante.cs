class Estudiante:Persona
{
public string CursoMatriculado{get;set;}
public Estudiante(string NombreApellido, double NumeroCedula, string EstadoCivil, string CursoMatriculado):base
(NombreApellido,NumeroCedula,EstadoCivil)
{
this.CursoMatriculado=CursoMatriculado;
}
public void CambioDeCurso()
{
    string NuevoCurso;
    Console.WriteLine("Ingrese el nuevo curso al que va a ingresar");
    NuevoCurso=Console.ReadLine();
    Console.WriteLine("El nuevo curso de " +NombreApellido+ "es" + NuevoCurso):
    CursoMatriculado=NuevoCurso;
    Console.WriteLine("");
}
    public override void MostrarDatos()
    {
        Console.WriteLine("Datos del estudiante");
        CambioDeCurso();
        CambioDeEstado();
        Console.WriteLine("Nombre: " +NombreApellido);
        Console.WriteLine("Número de cédula: " +NumeroCedula);
        Console.WriteLine("Estado civil: " +EstadoCivil);
        Console.WriteLine("Curso Matriculado: " +CursoMatriculado);
        Console.WriteLine();
        Console.ReadKey();
    }
}