
// declaracion de variables
string name;
string dni;
string dniAcompañante;
int age;
string dest;
int flightClass = 0;
int baggage = 0;
int handLug = 0;
int dog = 0;
int quantityCarryOnBagagge = 0;
int weightEconomic = 0;
int weightExecutive = 0;
int weightFirstClass = 0;




// Mensaje de bienvenida
Console.WriteLine("\r\n████████████████████████████████████████████████████████████\r\n█▄─▄─▀█▄─▄█▄─▄▄─█▄─▀█▄─▄█▄─█─▄█▄─▄▄─█▄─▀█▄─▄█▄─▄█▄─▄▄▀█─▄▄─█\r\n██─▄─▀██─███─▄█▀██─█▄▀─███▄▀▄███─▄█▀██─█▄▀─███─███─██─█─██─█\r\n▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀");
Console.WriteLine("\r\n███████\r\n██▀▄─██\r\n██─▀─██\r\n▀▄▄▀▄▄▀");
Console.WriteLine("\r\n████████████████████████████████████████████████████████████████████████\r\n█─▄▄▄─█─█─█▄─▄▄─█─▄▄▄─█▄─█─▄███▀▀▀▀▀████▄─▄█▄─▀█▄─▄█▄─▀█▄─▄█▄─▄▄─█▄─▄▄▀█\r\n█─███▀█─▄─██─▄█▀█─███▀██─▄▀██████████████─███─█▄▀─███─█▄▀─███─▄█▀██─▄─▄█\r\n▀▄▄▄▄▄▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▀▀▀▀▀▀▀▀▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀");
Console.WriteLine("");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Presiona ENTER para empezar. . .");

Console.WriteLine("");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Blue;

Console.Write("////////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.ResetColor();
Console.ReadLine();

// Solicitud de datos inicial
Console.WriteLine("¡Hola!");
Console.WriteLine("");
Console.WriteLine("¿Cual es tu nombre?");
name=Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Perfecto!" + " name");
Console.WriteLine("¿Cual es tu DNI?");
dni= Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Muy bien!");
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
if (baggage == 1)
{
    Console.WriteLine("\nIngrese cuanto equipaje de mano que va a llevar");
    quantityCarryOnBagagge = int.Parse(Console.ReadLine());
    if (quantityCarryOnBagagge > 3)
    {
        Console.WriteLine($"\nUsted excede de la cantidad permitida por pasajero. Su cantidad es igual a {quantityCarryOnBagagge}");
    }
}
else
{
}


//equipaje facturado
if (flightClass == 1)
{
    switch (handLug)
    {
        case 0:

            Console.WriteLine("No posee equipaje facturado");
            Console.WriteLine("\nIngrese el peso de su equipaje");
            weightEconomic = int.Parse(Console.ReadLine());
            if (weightEconomic > 5)
            {
                Console.WriteLine($"\nEl peso de su equipaje excede el límite permitido, su equipaje se excede por: {(weightEconomic - 5)}kg , el límite permitido es de 5kg en clase economica.");
                Console.WriteLine($"\nExcedente a pagar: ${(weightEconomic * 10)}");
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
            Console.WriteLine("Ingrese el peso de su equipaje");
            weightExecutive = int.Parse(Console.ReadLine());
            if (weightExecutive > 10)
            {
                Console.WriteLine($"\nEl peso de su equipaje excede el límite permitido, su equpiaje se excede por:\t{(weightExecutive - 10)}, el límite permitido es de 10kg en clase ejecutiva.");
                Console.WriteLine($"\nExcedente a pagar:\t${(weightExecutive * 10)}");
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
            Console.WriteLine("Ingrese el peso de su equipaje");
            weightFirstClass = int.Parse(Console.ReadLine());
            if (weightFirstClass > 20)
            {
                Console.WriteLine($"\nEl peso de su equipaje excede el límite permitido, su equpiaje se excede por:\t{(weightFirstClass - 20)}, el límite permitido es de 10kg en clase ejecutiva.");
                Console.WriteLine($"\nExcedente a pagar:\t${(weightFirstClass * 10)}");
            }
            break;
        default:
            break;

    }
}


Console.ResetColor();





