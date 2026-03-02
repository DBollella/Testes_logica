namespace LC
{
    /// <summary>
    /// Versão com lógica simplificada do jogo Pedra, Papel, Tesoura, Lagarto, Spock.
    /// </summary>
    public class PedraPapelTesouraLagartoSpockSimplificado
    {
        public enum Jogada
        {
            Pedra = 1,
            Papel = 2,
            Tesoura = 3,
            Lagarto = 4,
            Spock = 5
        }

        /// <summary>
        /// <param name="jogador1"></param>
        /// <param name="jogador2"></param>
        /// <returns></returns>
        public static string Jogar(int jogador1, int jogador2)
        {
            // Valida entrada
            if (jogador1 < (int)Jogada.Pedra || jogador1 > (int)Jogada.Spock ||
                jogador2 < (int)Jogada.Pedra || jogador2 > (int)Jogada.Spock)
            {
                return "Jogada inválida";
            }

            if (jogador1 == jogador2)
            {
                return "Empate!";
            }

            if ((jogador1 == (int)Jogada.Pedra && (jogador2 == (int)Jogada.Tesoura || jogador2 == (int)Jogada.Lagarto)) ||
                (jogador1 == (int)Jogada.Papel && (jogador2 == (int)Jogada.Pedra || jogador2 == (int)Jogada.Spock)) ||
                (jogador1 == (int)Jogada.Tesoura && (jogador2 == (int)Jogada.Papel || jogador2 == (int)Jogada.Lagarto)) ||
                (jogador1 == (int)Jogada.Lagarto && (jogador2 == (int)Jogada.Papel || jogador2 == (int)Jogada.Spock)) ||
                (jogador1 == (int)Jogada.Spock && (jogador2 == (int)Jogada.Pedra || jogador2 == (int)Jogada.Tesoura)))
            {
                return "Jogador 1 venceu!";
            }

            return "Jogador 2 venceu!";
        }
    }
}
