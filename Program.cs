public class Program 
{
    static void Main()
    {
        Empleado emp1 = new Empleado(
            "juan",
            "11110001",
            "juan@mail.com",
            22,
            1000.0,
            "jefe de personal"
        );

        Console.WriteLine(emp1.Cargo); 

        emp1.MostrarInfo();
        Console.WriteLine("======================");

        Cliente cli1 = new Cliente(
            "Andres Agudelo",
            "1000567023",
            "agudelo.edwin023@pascualbravo.edu.co",
            24,
            "premium",
            "20/05/2027"
        );
        
        cli1.MostrarInfo();
        Console.WriteLine(cli1.Activo);

        cli1.Activo = false;
        Console.WriteLine();

        cli1.MostrarInfo();
        Console.WriteLine("=======================");
        
    }

    
}