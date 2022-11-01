Console.WriteLine("Qual foi sua média? (0-10)");
int media = int.Parse(Console.ReadLine());

if(media >= 6)
    Console.WriteLine("Aprovado");
else if(media >= 4)
    Console.WriteLine("Recuperação");
else
    Console.WriteLine("Reprovado");