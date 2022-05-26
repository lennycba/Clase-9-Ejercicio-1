
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("por favor ingrese la cantidad de numeros que debe tener el listado");
Console.ForegroundColor = ConsoleColor.Green;
var dato = Console.ReadLine();
Console.Clear();
int longitud = int.Parse(dato);
int[] vector = new int[longitud];
int[] vectorInvert = new int[longitud];
Random aleatorizador = new Random();

Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" El listado de numeros random es:");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorizador.Next(101);
    
    Console.Write(" "+vector[i]+" ");    
}

Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" Y el listado de números en orden inverso es:");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;

for (int j = 0; j < vectorInvert.Length; j++)
{
    int k = (vector.Length -1) -j;
    vectorInvert[j] = vector[k];
    Console.Write(" "+ vectorInvert[j] + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.ResetColor();