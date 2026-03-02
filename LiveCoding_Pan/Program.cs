using LiveCoding_Pan;

public partial class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a escolha do Jogador 1 (1=Pedra, 2=Papel, 3=Tesoura, 4=Lagarto, 5=Spock):");
        var input1 = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Digite a escolha do Jogador 2 (1=Pedra, 2=Papel, 3=Tesoura, 4=Lagarto , 5=Spock):");
        var input2 = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input1, out int jogador1) || !int.TryParse(input2, out int jogador2))
        {
            Console.WriteLine("Jogada inválida");
            JogarNovamente();
            return;
        }

        //string resultado = PredraPapelTesouraLagartoSpockSimplificado.Jogar(jogador1, jogador2);

        string resultado = PredraPapelTesouraLagartoSpockOtimizado.Jogar(jogador1, jogador2);

        Console.WriteLine(resultado);
        
        JogarNovamente();
    }

    public static void JogarNovamente()
    {
        Console.WriteLine("Jogar novamente: (s/n): ");
        string resposta = Console.ReadLine() ?? string.Empty;
        if (resposta.Equals("s", StringComparison.OrdinalIgnoreCase))
        {
            Main();
        }
    }
}