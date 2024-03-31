

var numberstring = string.Empty;
do
{
    Console.WriteLine("digite numero es i gual a s sale");
     numberstring = Console.ReadLine();
    if (numberstring == "s")
    {
        continue;

    }

    var number =0;

 
    if (int.TryParse(numberstring, out number)) { 
    if (number % 2 == 0)
    {
        Console.WriteLine("el numero es par");

    }
    else
    {
        Console.WriteLine("el numero no es apr");
    }
}
    else
    {
        Console.WriteLine($"lo que ingresaste {number} no es un  numero entero");
    }
}while(numberstring!="s");
