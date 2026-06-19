using System.Runtime.CompilerServices;

namespace DatosEmpleado;
class Empleado
{
    string nombre;
    string apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    DateTime fechaDeIngreso;
    double sueldoBasico;
    Cargos cargo;

    
    // Propiedades públicas para poder asignar y leer los datos desde Program.cs (Encapsulamiento)
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }
    public void Antiguedad(DateTime fechaDeIngreso)
    {
        double Antiguedad = DateTime.Today.Year - fechaDeIngreso.Year;
    }
    public void edad(DateTime fechaNacimiento)
    {
        int edad = DateTime.Today.Year - fechaNacimiento.Year;
    }
    public void jubilacion(int edad)
    {
        int jubilacion= 65-edad;
    }
}

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
    

