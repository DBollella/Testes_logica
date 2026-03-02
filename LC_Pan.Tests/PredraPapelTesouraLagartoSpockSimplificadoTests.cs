using System;
using Xunit;
using LiveCoding_Pan;

namespace LiveCoding_Pan.Tests
{
    public class PredraPapelTesouraLagartoSpockSimplificadoTests
    {

        [Theory]
        [InlineData(1, 3)] // Pedra vence Tesoura
        [InlineData(1, 4)] // Pedra vence Lagarto
        [InlineData(2, 1)] // Papel vence Pedra
        [InlineData(2, 5)] // Papel vence Spock
        [InlineData(3, 2)] // Tesoura vence Papel
        [InlineData(3, 4)] // Tesoura vence Lagarto
        [InlineData(4, 5)] // Lagarto vence Spock
        [InlineData(4, 2)] // Lagarto vence Papel
        [InlineData(5, 3)] // Spock vence Tesoura
        [InlineData(5, 1)] // Spock vence Pedra
        public void Jogador1_Deve_Vencer_Quando_Regra_Valida(int jogador1, int jogador2)
        {
            var resultado = PredraPapelTesouraLagartoSpockSimplificado.Jogar(jogador1, jogador2);
            Assert.Equal("Jogador 1 venceu!", resultado);
        }

        [Theory]
        [InlineData(3, 1)]
        [InlineData(4, 1)]
        [InlineData(1, 2)]
        [InlineData(5, 2)]
        [InlineData(2, 3)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        [InlineData(2, 4)]
        [InlineData(3, 5)]
        [InlineData(1, 5)]
        public void Jogador2_Deve_Vencer_Quando_Regra_Valida(int jogador1, int jogador2)
        {
            var resultado = PredraPapelTesouraLagartoSpockSimplificado.Jogar(jogador1, jogador2);
            Assert.Equal("Jogador 2 venceu!", resultado);
        }

        [Theory]

        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]

        public void Deve_Retornar_Empate(int jogador1, int jogador2)
        {
            var resultado = PredraPapelTesouraLagartoSpockSimplificado.Jogar(jogador1, jogador2);
            Assert.Equal("Empate!", resultado);
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 5)]
        public void Deve_Retornar_Erro_Para_Jogada_Invalida(int jogador1, int jogador2)
        {
            var resultado = PredraPapelTesouraLagartoSpockSimplificado.Jogar(jogador1, jogador2);
            Assert.Equal("Jogada inválida", resultado);
        }
    }
}
