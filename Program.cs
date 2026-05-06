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
        
    }
}