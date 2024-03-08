// See https://aka.ms/new-console-template for more information

//metodo principal
using Vehiculos;

int cant, cantgas, cantGaso, cant250;
Console.WriteLine("------------Vehiculo---------------");
Console.WriteLine("ingresar datos de vehiculos: ");
Console.WriteLine("Ingrese la cantidad que ingresa al dia: ");
cant = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de vehiculos a gas: ");
cantgas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de vehiculos a gasolina: ");
cantGaso = int.Parse(Console.ReadLine());

Vehiculo obj1 = new Vehiculo ("TIPO VEHICULO", 5, cant, cantgas, cantGaso);


Console.WriteLine("------------MOTO-------------------");

Console.WriteLine("Ingresar datos de moto");
Console.WriteLine("Ingrese la cantidad que ingresa al dia");
cant = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de motos con cilindraje mayor a 250: ");
cant250 = int.Parse(Console.ReadLine());


Moto obj2 =  new Moto("TIPO MOTO", 2, cant, cant250);

obj1.mostrarVehiculo();
obj2.mostrarMoto();
int cantP = obj1.calcularPersonas()+obj2.calcularPersonas();
Console.WriteLine("cantidad maxima de personas: " + cantP);