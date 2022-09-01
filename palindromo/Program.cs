int escolha;
do
{
    Console.WriteLine("Vamos inverter a palavra digitada");
    string palavra = Console.ReadLine();
    string PalavraInvertida = " ";

    for(int i = palavra.Length - 1; i >= 0; i --)
    {
        PalavraInvertida += palavra[i];
    }

    Console.WriteLine("E a palavra invertida é:");
    Console.WriteLine(PalavraInvertida);

    Console.WriteLine("Digite 0 para parar o programa ou 1 para continuar");
    escolha = int.Parse(Console.ReadLine());
} while (escolha != 0);