public class Cliente : Persona
{
   public string Plan; 
   public string FechaIngreso;
   public bool Activo; 
  
   public Cliente
   (
        string nombre,
        string documento,
        string correo,
        int edad,
        string Plan,
        string FechaIngreso,
        bool Activo
    )
    :base(nombre, documento, correo, edad)
    {
        this.Plan = Plan;
        this.FechaIngreso = FechaIngreso;
        this.Activo = true;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine("Plan: " + Plan);
        Console.WriteLine("FechaIngreso: " + FechaIngreso);
        Console.WriteLine("Estado: " + (Activo ? "Activo" : "Inactivo"));
    }
    public bool TieneMembresia()
    {
        return Activo;
    }
} 
