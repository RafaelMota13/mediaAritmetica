Console.WriteLine("Média Aritmética de 3 números\n");


Console.Write("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite o terceiro número: ");
double numero3 = Convert.ToDouble(Console.ReadLine());

double media = (numero1 + numero2 + numero3) / 3;


Console.WriteLine($"\nMédia: {media:N1}");
