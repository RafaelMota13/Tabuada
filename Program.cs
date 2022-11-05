Console.Write("\nTábuada do número: ");
int  n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int m = 0;
int resul;

while (m<=10)
{
    resul = n*m;
    Console.WriteLine($"{n} x {m} = {resul}");
     m = m+1;
}
Console.WriteLine();
