Console.Write("\nTábuada do número: ");
int  n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int m = 0;


while (m<=10)
{
   int resul = n * m;
    Console.WriteLine($"{n} x {m} = {resul}");
     m = m + 1;
}
Console.WriteLine();
