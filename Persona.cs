class Persona
{
    public string NombreApellido{get;set;}
    public double NumeroCedula{get;set;}
    public string EstadoCivil{get;set;}
    public Persona (string NombreApellido, double NumeroCedula, string EstadoCivil)
    {
        this.NombreApellido=NombreApellido;
        this.NumeroCedula=NumeroCedula;
        this.EstadoCivil=EstadoCivil;
    }
    public void CambioDeEstado()
    {
        string Activador="";
        Console.WriteLine("¿Desea cambiar su estado civil?");
        Activador=Console.ReadLine();
        if(Activador=="si" || Activador== "si")
        {
            string NuevoEstado;
            Console.WriteLine("Ingrese su nuevo estado civil");
            NuevoEstado=Console.ReadLine();
            Console.WriteLine("Su estado civil ha cambiado a: "+ NuevoEstado);
            EstadoCivil=NuevoEstado;
        }
        Console.WriteLine("");
        Console.ReadKey();
    }
    public virtual void MostrarDatos()
    {
        
    }
}