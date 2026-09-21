Console.WriteLine("EJERCICIO_2");                                    //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Nombre del ejercicio
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine()); //Declarar variable 

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine()); //Declarar variable

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine()); //Declarar variable

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; //Lo que esta en parentesis se hace primero

Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); //Hacer una concatenacion con el signo de peso 

Console.WriteLine();
if(promedio >=70)
{
    Console.WriteLine("¡Felicidades! Has aprobado el curso.");
}
else
{
    Console.WriteLine("Lo siento, no has aprobado el curso. ¡Sigue intentándolo!");
}
