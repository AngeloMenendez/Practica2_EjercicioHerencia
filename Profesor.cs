class Profesor:Persona
{
public string Departamento{get;set;}
public Profesor(string NombreApellido, double NumeroCedula, string EstadoCivil, string Departamento):
base(NombreApellido,NumeroCedula,EstadoCivil)
{
    this.Departamento=Departamento;
}
public void CambioDeDepartamento()
{
    string NuevoDepartamento;
    Console.WriteLine("Ingrese el nuevo departamento");
    NuevoDepartamento=Console.ReadLine();
    Console.WriteLine("El nuevo departamento de: " +NombreApellido+ "es" +NuevoDepartamento);
    Departamento=NuevoDepartamento;
    Console.WriteLine("");
}
    public override void MostrarDatos()
    {
        Console.WriteLine("Datos del profesor");
        CambioDeEstado();
        CambioDeDepartamento();
        Console.WriteLine("Nombre: " +NombreApellido);
        Console.WriteLine("Número de cédula: " +NumeroCedula);
        Console.WriteLine("Estado civil: " +EstadoCivil);
        Console.WriteLine("Departamento del profesor: " +Departamento);
        Console.WriteLine("");
        Console.ReadKey();
    }
}