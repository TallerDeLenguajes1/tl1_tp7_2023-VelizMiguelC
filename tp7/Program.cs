// See https://aka.ms/new-console-template for more information
using Empleados;
string nombre, apellido;
char genero, estadoCivil;
double sueldoBasico;
DateTime fechaNacimiento, fechaIngreso;
Cargos cargo;
nombre = "Miguel";
apellido = "Veliz";
genero = 'M';
estadoCivil = 'C';
sueldoBasico = 2500123123123210;
fechaNacimiento = new DateTime(1955, 1, 9);
fechaIngreso = new DateTime(2010, 12, 19);
cargo = Cargos.Especialista;

Empleado empleado1 = new Empleado(nombre,apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

nombre = "Jose";
apellido = "Boggio";
genero = 'F';
estadoCivil = 'S';
sueldoBasico = 500000;
fechaNacimiento = new DateTime(1965, 1, 29);
fechaIngreso = new DateTime(2010, 3, 2);
cargo = Cargos.Ingeniero;
Empleado empleado2 = new Empleado(nombre,apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

nombre = "Florencia";
apellido = "Veliz";
genero = 'F';
estadoCivil = 'C';
sueldoBasico = 1000000;
fechaNacimiento = new DateTime(1956, 1, 23);
fechaIngreso = new DateTime(1991, 1, 2);
cargo = Cargos.Investigador;

Empleado empleado3 = new Empleado(nombre,apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

double montoTotal = empleado1.CalcularSalario() + empleado2.CalcularSalario() + empleado3.CalcularSalario();

Console.WriteLine("Nombre: "+empleado3.Nombre);
Console.WriteLine("Apellido: "+empleado3.Apellido);
Console.WriteLine("Fecha de Nacimiento: "+empleado3.FechaNacimiento);
Console.WriteLine("Genero: "+empleado3.Genero);
Console.WriteLine("Estado Civil: : "+empleado3.EstadoCivil);
Console.WriteLine("Fecha de Ingreso: "+empleado3.FechaIngreso);
Console.WriteLine("Sueldo basico: "+empleado3.SueldoBasico);
Console.WriteLine("Cargo: "+empleado3.Cargo);
Console.WriteLine("Salario: "+empleado3.CalcularSalario());