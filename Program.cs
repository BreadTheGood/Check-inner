
// declaracion de variables
string name;
string dni;
string dniAcompañante;
int age = 0;
string dest;
int flightClass = 0;
int baggage = 0;
int handLug = 0;
int dog = 0;
// variables de equipaje
int quantityCarryOnBagagge = 0;
int weightHandLug = 0;

// variables perro de servicio.
string dogAllowed;
string dogSeatBelt;

Random rnd = new Random();
int num1 = rnd.Next(1, 9);
int num2 = rnd.Next(1, 9);
int num3 = rnd.Next(1, 9);
int num4 = rnd.Next(1, 9);
int num5 = rnd.Next(1, 9);

char letra1 = (char)rnd.Next('A','Z'+ 1);
char letra2 = (char)rnd.Next('A','Z'+ 1);





// Mensaje de bienvenida
Console.WriteLine("\r\n████████████████████████████████████████████████████████████\r\n█▄─▄─▀█▄─▄█▄─▄▄─█▄─▀█▄─▄█▄─█─▄█▄─▄▄─█▄─▀█▄─▄█▄─▄█▄─▄▄▀█─▄▄─█\r\n██─▄─▀██─███─▄█▀██─█▄▀─███▄▀▄███─▄█▀██─█▄▀─███─███─██─█─██─█\r\n▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀");
Console.WriteLine("\r\n███████\r\n██▀▄─██\r\n██─▀─██\r\n▀▄▄▀▄▄▀");
Console.WriteLine("\r\n████████████████████████████████████████████████████████████████████████\r\n█─▄▄▄─█─█─█▄─▄▄─█─▄▄▄─█▄─█─▄███▀▀▀▀▀████▄─▄█▄─▀█▄─▄█▄─▀█▄─▄█▄─▄▄─█▄─▄▄▀█\r\n█─███▀█─▄─██─▄█▀█─███▀██─▄▀██████████████─███─█▄▀─███─█▄▀─███─▄█▀██─▄─▄█\r\n▀▄▄▄▄▄▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▀▀▀▀▀▀▀▀▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀");
Console.WriteLine("");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("\n\nPresiona ENTER para empezar. . .\n\n");

Console.ForegroundColor = ConsoleColor.Blue;

Console.Write("////////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.ResetColor();
Console.ReadLine();

// Solicitud de datos inicial
Console.WriteLine("¡Hola!\n");
Console.WriteLine("¿Cual es tu nombre?");
name=Console.ReadLine();


Console.WriteLine($"\nPerfecto! {name}");
Console.WriteLine("¿Cual es tu DNI?");
dni= Console.ReadLine();

Console.WriteLine("\nMuy bien!");
Console.WriteLine("¿Cuantos años tienes?");
age=int.Parse(Console.ReadLine());

Console.WriteLine("\nEstupendo!");
Console.WriteLine("¿Cual va a ser su destino?");
dest = Console.ReadLine();

// agregar felicitacion como en la lineas de codigo anteriores, no se me ocurre que poner xd.
Console.WriteLine("\nIngrese la clase de vuelo en formato numerico, [Económica: 1, Ejecutiva: 2, Primera Clase: 3]");
flightClass = int.Parse(Console.ReadLine());

Console.WriteLine("\nPosee equipaje de mano? [Si: 1, No: 0]: ");
baggage = int.Parse(Console.ReadLine());

Console.WriteLine("\nPosee el equipaje en bodega facturado? [Si: 1, No: 0]: ");
handLug = int.Parse(Console.ReadLine());

Console.WriteLine("\nViaja con un perro de servicio? [Si: 1, No: 0]");
dog = int.Parse(Console.ReadLine());

Console.ReadLine();




//validacion de edad
if (age < 18)
{
    if (age >= 2 && age < 5)
    {
        Console.WriteLine("La persona debera viajar obligatoriamente acompañado por sus padres o tutor en la misma cabina y en asiento contiguos");
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
    }
}
else if (age >= 5 && age<=11)
{
    int servicioMenorNoAcompañado = 0;

    Console.WriteLine("La persona podra viajar solo al momento del inicio del viaje, solocitando el Servicio de Menor No Acompañado");
    Console.WriteLine("¿Deseas solicitar el servicio de menor no acompañado?");
    Console.WriteLine("Ingresa 1:Si o 2:No");
    Console.WriteLine("Muy bien!");
    servicioMenorNoAcompañado=int.Parse(Console.ReadLine());
    if (servicioMenorNoAcompañado<2)
    {
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
    }
    
}

//equipaje

// mensaje de equipaje va en el ticket final
if (baggage == 1)
{
    Console.WriteLine("\nIngrese cuanto equipaje de mano que va a llevar");
    quantityCarryOnBagagge = int.Parse(Console.ReadLine());
    if (quantityCarryOnBagagge > 3)
    {
        Console.WriteLine($"\nUsted excede de la cantidad permitida por pasajero. Su cantidad es igual a {quantityCarryOnBagagge}");
    }
    else
    {
        Console.WriteLine("Perfecto!\n usted no excede la cantidad de equipaje permitido.\n\n");
        Console.ReadLine();
    }
}



//equipaje facturado

// cambiar structura de switch a if, validando handLug y luego FightClass para pedir datos
if (handLug == 0)
{

}
if (flightClass == 1)
{
    Console.WriteLine("No posee equipaje facturado");
    Console.WriteLine("\nIngrese el peso de su equipaje");
    weightHandLug = int.Parse(Console.ReadLine());
    switch (handLug)
    {
        case 0:

            
            if (weightHandLug > 5)
            {
                Console.WriteLine($"\nEl peso de su equipaje excede el límite permitido, su equipaje se excede por: {(weightHandLug - 5)}kg , el límite permitido es de 5kg en clase economica.");
                Console.WriteLine($"\nExcedente a pagar: ${(weightHandLug * 10)}");
            }
            break;

        default:
            break;
    }
}
else if (flightClass == 2)
{
    switch (handLug)
    {
        case 0:
            Console.WriteLine("No posee equipaje facturado");
            Console.WriteLine("Ingrese el peso de su equipaje");
            weightHandLug = int.Parse(Console.ReadLine());
            if (weightHandLug > 10)
            {
                Console.WriteLine($"\nEl peso de su equipaje excede el límite permitido, su equpiaje se excede por: {(weightHandLug - 10)}kg , el límite permitido es de 10kg en clase ejecutiva.");
                Console.WriteLine($"\nExcedente a pagar: ${(weightHandLug * 10)}");
            }
            break;
        default:
            break;
    }
}
else
{
    switch (handLug)
    {
        case 0:
            Console.WriteLine("No posee equipaje facturado");
            Console.WriteLine("Ingrese el peso de su equipaje");
            weightHandLug = int.Parse(Console.ReadLine());
            if (weightHandLug > 20)
            {
                Console.WriteLine($"\nEl peso de su equipaje excede el límite permitido, su equpiaje se excede por: {(weightHandLug - 20)}kg , el límite permitido es de 10kg en primera clase.");
                Console.WriteLine($"\nExcedente a pagar: ${(weightHandLug * 10)}");
            }
            break;
        default:
            break;
    }
}

if (dog == 1) 
{

    Console.WriteLine("\nEl perro con el que viaja esta debidamente identificado con su chaleco o distintivo de servicio? [Responder con Si o No]");
    dogAllowed = Console.ReadLine();
    Console.WriteLine("\nEl perro cuenta con un accesorio o correa para asegurarlo al cinturón de seguridad? [Responder con Si o No]");
    dogSeatBelt = Console.ReadLine();
    if (dogAllowed == "Si" && dogSeatBelt == "Si")
    {
        Console.WriteLine("\nPerfecto!");
        Console.WriteLine($"El perro puede subir como acompañante! de {name}");    
    }
    else
    {
        Console.WriteLine("Disculpe! pero el perro debe contar con su chaleco o distintivo de servicio y la correa para asegurarlo al cinturon de seguridad.");
    }


}
Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine("////////////////////////////////////////////////////////////////");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\nPasajero: {name} | DNI: {dni} | Edad: {age}" );
Console.WriteLine($"\nDestino : {dest} | Clase: {flightClass}");
Console.WriteLine($"\nEquipaje de mano: {quantityCarryOnBagagge} | Equipaje en bodega: {weightHandLug} | Excedente a pagar: {(weightHandLug * 10)}");
/*Console.WriteLine($"\nPerro de acompañamiento: {Perro}");
Console.WriteLine($"\nExcedente en equipaje: {excedente}");*/

Console.WriteLine($"\n||||| Numero de tarjeta: {letra1}{letra2}{num1}{num2}{num3}{num4}{num5} |||||");
Console.WriteLine("\n================================================================");
Console.WriteLine($"Feliz viaje a {dest}, Vuelve pronto {name}!!!");
Console.WriteLine("================================================================");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\n////////////////////////////////////////////////////////////////");





Console.ResetColor();





