namespace LiveCoding_Pan
{
    public class PredraPapelTesouraLagartoSpockSimplificado
    {
        public enum Jogada
        {
            Pedra = 0,
            Papel = 1,
            Tesoura = 2,
            Lagarto = 3,
            Spock = 4
        }

        /// <summary>
        /// <param name="jogador1"></param>
        /// <param name="jogador2"></param>
        /// <returns></returns>
        public string Jogar(int jogador1, int jogador2)
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
