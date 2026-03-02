using LiveCoding_Pan;

public partial class Program
{
    public static void Main()
    {
        var jogo = new PredraPapelTesouraLagartoSpockSimplificado();

        Console.WriteLine("Digite a escolha do Jogador 1 (0=Pedra, 1=Papel, 2=Tesoura, 3=Lagarto, 4=Spock):");
        var input1 = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Digite a escolha do Jogador 2 (0=Pedra, 1=Papel, 2=Tesoura, 3=Lagarto , 4=Spock):");
        var input2 = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input1, out int j1) || !int.TryParse(input2, out int j2))
        {
            Console.WriteLine("Jogada inválida");
            JogarNovamente();
            return;
        }

        string resultado = jogo.Jogar(j1, j2);
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