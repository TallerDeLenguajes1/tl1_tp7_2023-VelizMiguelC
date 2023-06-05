namespace Empleados {
    public enum Cargos {
        Auxiliar,
        Administrativo,
        Ingeniero, 
        Especialista,
        Investigador
    }

    public class Empleado {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public char Genero { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo) {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }
        public int CalcularAntiguedad(){
            TimeSpan duracion=DateTime.Today - FechaIngreso;
            int antiguedad = (int)duracion.Days/365;
            return antiguedad;
        }
        public int CalcularEdad(){
            TimeSpan edad1=DateTime.Today - FechaNacimiento;
            int edad = (int)edad1.Days/365;
            return edad;
        }
        public int cantidadanios(){
            int edadjubilacion;
            if (Genero == 'M')
            {
                edadjubilacion=65;
            }else{
                edadjubilacion=60;
            }
            int edad=CalcularEdad();
            int falta=edadjubilacion-edad;
            if (falta < 0)
            {
                return 0;
            }else{
                return falta;
            }
            
        }
        public double CalcularSalario(){
                double adicional,salario;
                int porcentaje = CalcularAntiguedad();
                if (porcentaje >= 20)
                {
                    porcentaje=25;
                }
                adicional=(SueldoBasico*porcentaje)/100;
                if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                {   
                    porcentaje=50;
                    adicional=adicional+(adicional*porcentaje)/100;
                }
                if (EstadoCivil == 'C')
                {
                    adicional+=15000;                    
                }
                salario=adicional+SueldoBasico;
                return salario;
            }
    }
    
}