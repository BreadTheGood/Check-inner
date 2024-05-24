
// declaracion de variables
string name;
string dni;
string dniAcompañante;
int flightClass = 0;
int age = 0;
string dest;

// variables de equipaje
int quantityCarryOnBagagge = 0;
int quantityCarryOnBagaggeOverweight = 0;
int weightHandLug = 0;
int handLugOverweight = 0;
int baggage = 0;
int handLug = 0;

// variables perro de servicio.
int dog = 0;
int permittedDog = 0;
int dogAllowed;
int dogSeatBelt;

Random rnd = new Random();
int num1 = rnd.Next(1, 9);
int num2 = rnd.Next(1, 9);
int num3 = rnd.Next(1, 9);
int num4 = rnd.Next(1, 9);
int num5 = rnd.Next(1, 9);

char letra1 = (char)rnd.Next('A', 'Z' + 1);
char letra2 = (char)rnd.Next('A', 'Z' + 1);


DateTime dateTime = DateTime.Now;



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
name = Console.ReadLine();


Console.WriteLine($"\nPerfecto! {name}");
Console.WriteLine("¿Cual es tu DNI?");
dni = Console.ReadLine();

Console.WriteLine("\nMuy bien!");
Console.WriteLine("¿Cuantos años tienes?");
age = int.Parse(Console.ReadLine());

Console.WriteLine("\nEstupendo!");
Console.WriteLine("¿Cual va a ser su destino?");
dest = Console.ReadLine();

Console.WriteLine("\nExcelente!");
Console.WriteLine("Ingrese la clase de vuelo en formato numerico, [Económica: 1, Ejecutiva: 2, Primera Clase: 3]");
flightClass = int.Parse(Console.ReadLine());

Console.WriteLine("\nPosee equipaje de mano? [Si: 1, No: 0]: ");
baggage = int.Parse(Console.ReadLine());

Console.WriteLine("\nPosee el equipaje en bodega facturado? [Si: 1, No: 0]: ");
handLug = int.Parse(Console.ReadLine());

Console.WriteLine("\nViaja con un perro de servicio? [Si: 1, No: 0]");
dog = int.Parse(Console.ReadLine());


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
else if (age >= 5 && age <= 11)
{
    int servicioMenorNoAcompañado = 0;

    Console.WriteLine("La persona podra viajar solo al momento del inicio del viaje, solocitando el Servicio de Menor No Acompañado");
    Console.WriteLine("¿Deseas solicitar el servicio de menor no acompañado?");
    Console.WriteLine("Ingresa 1:Si o 2:No");
    Console.WriteLine("Muy bien!");
    servicioMenorNoAcompañado = int.Parse(Console.ReadLine());
    if (servicioMenorNoAcompañado < 2)
    {
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
    }

}

//equipaje

// mensaje de equipaje va en el ticket final
if (baggage == 1)
{
    Console.Write("\n\n\nUsted posee equipaje de mano, ");
    Console.WriteLine("Ingrese cuanto equipaje de mano que va a llevar");
    quantityCarryOnBagagge = int.Parse(Console.ReadLine());
    if (quantityCarryOnBagagge > 3)
    {
        quantityCarryOnBagaggeOverweight = quantityCarryOnBagagge;
    }
    else
    {
        Console.WriteLine("Perfecto!\n usted no excede la cantidad de equipaje permitido.\n\n");
        Console.ReadLine();

    }
}

//equipaje facturado


if (handLug == 0)
{

    if (flightClass == 1)
    {

        Console.Write("\n\n\nNo posee equipaje facturado, ");
        Console.WriteLine("Ingrese el peso de su equipaje");
        weightHandLug = int.Parse(Console.ReadLine());

        if (weightHandLug > 5)
        {
            handLugOverweight = weightHandLug;
        }

    }
    else if (flightClass == 2)
    {

        Console.WriteLine("\n\n\nNo posee equipaje facturado");
        Console.WriteLine("Ingrese el peso de su equipaje");
        weightHandLug = int.Parse(Console.ReadLine());
        if (weightHandLug > 10)
        {
            handLugOverweight = weightHandLug;
        }

    }
    else
    {

        Console.WriteLine("\n\n\nNo posee equipaje facturado");
        Console.WriteLine("Ingrese el peso de su equipaje");
        weightHandLug = int.Parse(Console.ReadLine());
        if (weightHandLug > 20)
        {
            handLugOverweight = weightHandLug;
        }

    }

}

if (dog == 1)
{

    Console.WriteLine("\n\n\nEl perro con el que viaja esta debidamente identificado con su chaleco o distintivo de servicio? [Si: 1, No: 0]:");
    dogAllowed = int.Parse(Console.ReadLine());
    Console.WriteLine("\nEl perro cuenta con un accesorio o correa para asegurarlo al cinturón de seguridad? [Si: 1, No: 0]:");
    dogSeatBelt = int.Parse(Console.ReadLine());
    if (dogAllowed == 1 && dogSeatBelt == 1)
    {
        permittedDog = dogAllowed & dogSeatBelt;
    }
    else
    {
        permittedDog = dogAllowed & dogSeatBelt;
    }


}




Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine("\n////////////////////////////////////////////////////////////////");

Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine($"\nPasajero: {name} | DNI: {dni} | Edad: {age}");

if (flightClass == 1)
{
    Console.WriteLine($"\nDestino : {dest} | Clase: {flightClass} = [Económica]");
}
else if (flightClass == 2)
{
    Console.WriteLine($"\nDestino : {dest} | Clase: {flightClass} = [Ejecutiva]");
}
else
{
    Console.WriteLine($"\nDestino : {dest} | Clase: {flightClass} = [Primera Clase]");
}

Console.WriteLine($"\nEquipaje de mano: {quantityCarryOnBagagge} maletas | Equipaje en bodega: {weightHandLug}kg | Excedente a pagar por equipaje en bodega: ${(weightHandLug * 10)}");

if (permittedDog == 1)
{
    Console.WriteLine($"\nPerro de acompañamiento: {permittedDog}, perro permitido para abordar con el pasajero, {name}");
}
else
{
    Console.WriteLine($"\nDisculpe! pero el perro debe contar con su chaleco o distintivo de servicio y la correa para asegurarlo al cinturon de seguridad para poder abordar con el pasajero, {name}");
}

if (flightClass == 1 && weightHandLug > 5)
{
    Console.WriteLine($"\nExcedente en equipaje: {handLugOverweight}kg, su equipaje se excede por: {(weightHandLug - 5)}kg , el límite permitido es de 5kg en clase Económica.");
}
else if (flightClass == 1 && weightHandLug > 10)
{
    Console.WriteLine($"\nExcedente en equipaje: {handLugOverweight}kg, su equipaje se excede por: {(weightHandLug - 10)}kg , el límite permitido es de 10kg en clase Ejecutiva.");
}
else
{
    Console.WriteLine($"\nExcedente en equipaje: {handLugOverweight}kg, su equipaje se excede por: {(weightHandLug - 20)}kg , el límite permitido es de 20kg en Primera Clase.");
}

Console.WriteLine($"\n||||| Numero de tarjeta de embarque: {letra1}{letra2}{num1}{num2}{num3}{num4}{num5} |||||");
Console.WriteLine($"Fecha y hora de emision de la tarjeta de embarque: {dateTime}");
Console.WriteLine("\n================================================================");
Console.WriteLine($"Feliz viaje a {dest}, Vuelve pronto {name}!!!");
Console.WriteLine("================================================================");

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine("\n////////////////////////////////////////////////////////////////");




Console.ResetColor();




