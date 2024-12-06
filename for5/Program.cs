Console.WriteLine("vvedite senu ");
decimal a = decimal.Parse(Console.ReadLine());
decimal b;
for (decimal i = 0.1M; i<1.0M; i+=0.1M)
{
    b = a * i;
    Console.WriteLine(i+" kg "  +" sena "+b);
    
}