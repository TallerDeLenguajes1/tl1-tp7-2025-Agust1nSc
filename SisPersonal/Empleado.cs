namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4
    }


    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; } // Tomo c para casado y s para soltero
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }

        public int edad => DateTime.Now.Year - FechaNacimiento.Year;

        public int antiguedad => DateTime.Now.Year - FechaIngreso.Year;

        public int Jubilarse => 65 - edad;

        public double CalcularSalario()
        {
            double adicional = 0;

            if (antiguedad < 20)
            {
                adicional = SueldoBasico * 0.01 * antiguedad;
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional += SueldoBasico * 1.5;
            }

            if (EstadoCivil == 'c')
            {
                adicional += 150000;
            }
            double total = adicional + SueldoBasico;
            return total;
        }
    }
}