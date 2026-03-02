using static LC.PedraPapelTesouraLagartoSpockSimplificado;

namespace LC
{
    public class PedraPapelTesouraLagartoSpockOtimizado
    {
        private enum Jogada
        {
            Pedra = 1,
            Papel = 2,
            Tesoura = 3,
            Lagarto = 4,
            Spock = 5
        }

        public static string Jogar(int jogador1, int jogador2)
        {
            var resultado = CalcularJogada(jogador1, jogador2);

            return Resultado(jogador1, jogador2, resultado);
        }

        public static int CalcularJogada(int jogada1, int jogada2)
        {
            var regras = ObterRegras();

            if (jogada1 == jogada2)
                return 0;

            for (int i = 0; i < regras.GetLength(1); i++)
                if (regras[jogada1 - 1, i] == jogada2)
                    return jogada1;

            return jogada2;
        }

        private static int[,] ObterRegras()
        {
            return new int[,] 
            {
                { (int)Jogada.Tesoura,(int)Jogada.Lagarto },
                { (int)Jogada.Pedra, (int)Jogada.Spock },
                { (int)Jogada.Papel, (int)Jogada.Lagarto },
                { (int)Jogada.Spock, (int)Jogada.Papel },
                { (int)Jogada.Tesoura, (int)Jogada.Pedra } 
            };
        }

        private static string Resultado(int jogada1, int jogada2, int resultado)
        {
            if (resultado == jogada1)
                return "Jogador 1 ganhou!";

            else if (resultado == jogada2)
                return "Jogador 2 ganhou!";

            else
                return "Empate";
        }
    }
}
