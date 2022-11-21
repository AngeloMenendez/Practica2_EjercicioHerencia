class Empleado:Persona
{
    public int AñoDeIngreso{get;set;}
    public int NumeroDeDespacho{get;set;}
    public string SeccionAsignada{get;set;}
    public Empleado(string NombreApellido,double NumeroCedula, string EstadoCivil,int AñoDeIngreso, 
    int NumeroDeDespacho, string SeccionAsignada): base (NombreApellido,NumeroCedula,EstadoCivil)
    {
        this.AñoDeIngreso=AñoDeIngreso;
        this.NumeroDeDespacho=NumeroDeDespacho;
        this.SeccionAsignada=SeccionAsignada;
    }
    public void ReasignacionDespacho()
    {
        int NuevoDespacho;
        Console.WriteLine("Ingrese el nuevo despacho del empleado");
        NuevoDespacho=int.Parse(Console.ReadLine());
        Console.WriteLine("El nuevo despacho de: " +NombreApellido+ "es" +NuevoDespacho);
        NumeroDeDespacho=NuevoDespacho;
        Console.WriteLine("");
    }
    public void CambioServicio()
    {
        string NuevaSeccion;
        Console.WriteLine("Ingrese el servicio al que va a cambiar");
        NuevaSeccion=Console.ReadLine();
        Console.WriteLine("El nuevo servicio de: " +NombreApellido+ "es" +NuevaSeccion);
        SeccionAsignada=NuevaSeccion;
        Console.WriteLine("");
    }
    public override void MostrarDatos()
    {
        Console.WriteLine("Datos del empleado");
        CambioDeEstado();
        ReasignacionDespacho();
        CambioDeEstado();
        Console.WriteLine("Nombre: " +NombreApellido);
        Console.WriteLine("Número de cédula: " +NumeroCedula);
        Console.WriteLine("Estado civil: " +EstadoCivil);
        Console.WriteLine("Año de Ingreso: " +AñoDeIngreso);
        Console.WriteLine("Número de Despacho: " +NumeroDeDespacho);
        Console.WriteLine("Servicio Asignado: " +SeccionAsignada);
        Console.WriteLine("");
        Console.ReadKey();
    }
}