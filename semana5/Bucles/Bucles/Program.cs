//// See https://aka.ms/new-console-template for more information

using Bucles.Entidades;
using Bucles.Negocio;

//#region Bucles
//// la primera parte del bucle for es para inicializar la iteracion
//// la segunda parte es para desirle asta donde llegara
//// tersera parte interactuar de cuanto en cuanto sera el cresimiento de nuestr variable

//for (int indice = 0; indice < 10; indice++)
//{
//    Console.WriteLine($"Hello, World!{indice}");
//    if (indice == 6)
//    {
//        Console.WriteLine($"hola mundo!{indice}");
//    }
//}
////lista, array, arreglos,

//int[] Numero = { 1, 32, 4, 9 };


//string[] Estudiantes = { "Brayan", "jhonson", "Elias" };

//for (int i = 0; i < Estudiantes.Length; i++)
//{
//    Console.WriteLine(Estudiantes[i]);
//}


//foreach (var mostrar in Estudiantes)
//{
//    Console.WriteLine(mostrar);
//}

//#endregion



#region Arreglos

Estudiante estudiante = new Estudiante();
ClsEstudiante clsEstudiante = new ClsEstudiante();

estudiante.Nombre = "Brayan";
estudiante.Apellido = "Alvarado";
estudiante.Edad = 20;

clsEstudiante.AgregarEstudiante(estudiante);

Estudiante estudiante2 = new Estudiante();
estudiante2.Nombre = "Jhonson";
estudiante2.Apellido = "Salinas";
estudiante2.Edad = 21;

clsEstudiante.AgregarEstudiante(estudiante2);

foreach (var mostrar in clsEstudiante.ListarEstudiante())
{
    Console.WriteLine(mostrar.Nombre);
    Console.WriteLine(mostrar.Apellido);
}
#endregion