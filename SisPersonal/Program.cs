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