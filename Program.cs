int numeroUm, numeroDois, resultado;

Console.WriteLine("Cálculo da soma entre dois números.\n");

Console.Write("Digite o primeiro número: ");
numeroUm = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
numeroDois = Convert.ToInt32(Console.ReadLine());

resultado = numeroUm + numeroDois;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nSoma: {resultado}");
Console.ResetColor();

Console.WriteLine("");

Console.WriteLine("Presione uma tecla para sair...");
Console.ReadKey();