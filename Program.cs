
// declaracion de variables iniciales
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

//Generacion Random y DateTime
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

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n\n////////////////////////////////////////////////////////////////////////////////////////////////////////////");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("\n\nPresiona ENTER para empezar. . .\n\n");

Console.ForegroundColor = ConsoleColor.Blue;

Console.Write("////////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.ResetColor();
Console.ReadLine();

// Solicitud de datos inicial
Console.WriteLine("\n¡Hola!\n");
Console.WriteLine("¿Cual es tu nombre?");
name = Console.ReadLine();

Console.WriteLine($"\nPerfecto! {name}");
Console.WriteLine("¿Cual es tu DNI?");
dni = Console.ReadLine();

Console.WriteLine("\nMuy bien!");
Console.WriteLine("¿Cuantos años tienes?");
age = int.Parse(Console.ReadLine());

Console.WriteLine($"Okey, {name}");
Console.WriteLine("¿A que ciudad viajas?");
dest = Console.ReadLine();
Console.WriteLine("\nMe gusta {dest}, buena elección!");

Console.WriteLine("Te consulto ¿Vuelas en clase económica: 1, ejecutiva: 2 o Primera Clase: 3?");
Console.WriteLine("Responde solo con números");
flightClass = int.Parse(Console.ReadLine());

//Datos de Equipaje
Console.WriteLine("Bien!");
Console.WriteLine("\n Otra consulta ¿Llevas equipaje de mano? [Si: 1, No: 0]: ");
baggage = int.Parse(Console.ReadLine());
if (baggage == 1)
{
    Console.WriteLine("¿Cuanto equipaje de mano llevas?");
    quantityCarryOnBagagge = int.Parse(Console.ReadLine());
    if (quantityCarryOnBagagge > 3)
    {
        quantityCarryOnBagaggeOverweight = quantityCarryOnBagagge;
    }

}

Console.WriteLine("\nY . . . Tu equipaje en bodega ya esta facturado? [Si: 1, No: 0]: ");
Console.WriteLine("Recuerda responder con números!")
handLug = int.Parse(Console.ReadLine());
                
if (handLug==0)
{    
    Console.WriteLine("¿Cuanto pesa de tu equipaje?");
    switch (flightClass){
        case 1:             
            weightHandLug = int.Parse(Console.ReadLine());
            if (weightHandLug > 5){
                handLugOverweight = weightHandLug;
            }
            break;

        case 2:
            weightHandLug = int.Parse(Console.ReadLine());
            if (weightHandLug > 10){
                handLugOverweight = weightHandLug;
            }
            break;

        case 3:
            weightHandLug = int.Parse(Console.ReadLine());
            if (weightHandLug > 20){
                handLugOverweight = weightHandLug;
            }
            break;         
        
        default: 
            break;
        }
}

Console.WriteLine("\nViajas con un perro de servicio? [Si: 1, No: 0]");
dog = int.Parse(Console.ReadLine());


//validacion de edad
if (age < 18)
{
    if (age >= 2 && age < 5)
    {
        Console.WriteLine("La persona debera viajar obligatoriamente acompañado por sus padres o tutor en la misma cabina y en asiento contiguos");
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
    }else if (age >= 5 && age <= 11)
    {
    int servicioMenorNoAcompañado = 0;

    Console.WriteLine("La persona podra viajar solo al momento del inicio del viaje, solicitando el Servicio de Menor No Acompañado");
    Console.WriteLine("¿Deseas solicitar el servicio de menor no acompañado?");
    Console.WriteLine("Responde con números! Si:1, No:2");
    servicioMenorNoAcompañado = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Muy bien!");
    
    if (servicioMenorNoAcompañado < 2)
    {
        Console.WriteLine("Por favor ingresa el DNI de tu acompañante mayor de edad");
        dniAcompañante = Console.ReadLine();
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

Console.WriteLine($"\nEquipaje de mano: {quantityCarryOnBagagge} maletas | Peso de equipaje en bodega: {weightHandLug}kg | Excedente a pagar por equipaje en bodega: ${(weightHandLug * 10)}");

if (permittedDog == 1)
{
    Console.WriteLine($"\nPerro de acompañamiento: Si, perro permitido para abordar con el pasajero.");
}
else if (dog == 0)
{
    Console.WriteLine("\nSin perro de acompañamiento");
}
else
{
    Console.WriteLine($"\nDisculpe! pero el perro debe contar con su chaleco o distintivo de servicio y la correa para asegurarlo al cinturon de seguridad para poder abordar con el pasajero, {name}");
}


Console.WriteLine($"\n||||| Numero de tarjeta de embarque: {letra1}{letra2}{num1}{num2}{num3}{num4}{num5} |||||");
Console.WriteLine($"Fecha y hora de emision: {dateTime}");
Console.WriteLine("\n================================================================");
Console.WriteLine($"\nFeliz viaje a {dest}, Vuelve pronto {name}!!!");
Console.WriteLine("\n================================================================");

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine("\n////////////////////////////////////////////////////////////////");



