using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCoding_Pan
{
    public class PredraPapelTesouraLagartoSpockOtimizado
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
            return new int[,] { { 3, 4 }, { 1, 5 }, { 2, 4 }, { 5, 2 }, { 3, 1 } };
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
