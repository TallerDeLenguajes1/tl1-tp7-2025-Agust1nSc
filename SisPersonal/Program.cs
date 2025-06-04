using System.Security.Authentication.ExtendedProtection;
using EspacioEmpleado;

Empleado[] emp = new Empleado[3];



emp[0] = new Empleado
{
    Nombre = "Agustin",
    Apellido = "Saccone",
    FechaNacimiento = new DateTime(2004, 9, 9),
    EstadoCivil = 'c',
    FechaIngreso = new DateTime(2015, 5, 12),
    SueldoBasico = 500.25,
    Cargo = Cargos.Ingeniero
};

emp[1] = new Empleado
{
    Nombre = "Martin",
    Apellido = "Diaz",
    FechaNacimiento = new DateTime(2006, 1, 3),
    EstadoCivil = 's',
    FechaIngreso = new DateTime(2017, 5, 12),
    SueldoBasico = 400.50,
    Cargo = Cargos.Especialista
};

emp[2] = new Empleado
{
    Nombre = "Sofia",
    Apellido = "Rodriguez",
    FechaNacimiento = new DateTime(2000, 7, 5),
    EstadoCivil = 'c',
    FechaIngreso = new DateTime(2011, 7, 10),
    SueldoBasico = 700.38,
    Cargo = Cargos.Administrativo
};

for (int i = 0; i < 3; i++)
{
    double salarios = emp[i].CalcularSalario();
    Console.WriteLine("Salario del empleado " + emp[i].Nombre + " " + emp[i].Apellido + ": $" + salarios);
}

int aux = 0;

for (int i = 0; i < 3; i++)
{
    if (emp[i].Jubilarse < emp[aux].Jubilarse)
    {
        aux = i;

    }
}

Console.WriteLine("Empleado mas pronto a jubilarse:");
Console.WriteLine(emp[aux].Nombre + emp[aux].Apellido);
Console.WriteLine("Antiguedad: " + emp[aux].antiguedad);
Console.WriteLine("Edad: " + emp[aux].edad);
Console.WriteLine("Anios para jubilarse: " + emp[aux].Jubilarse);
double salarioAux = emp[aux].CalcularSalario(); 
Console.WriteLine("Salario: " + salarioAux); 