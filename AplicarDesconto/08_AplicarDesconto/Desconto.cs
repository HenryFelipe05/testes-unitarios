using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AplicarDesconto
{
    public class Desconto
    {
        // Verificar se uma compra pode receber desconto
        // Compras acima de R$ 350 recebem algum desconto
        public bool recebeDesconto(float valor)
        {
            return (valor >= 350);              
        }

        /* Retorna o percentual de desconto a ser aplicado:
         * Valores maiores ou iguais a R$ 5.000,00 ---> 3,0% de desconto
         * Valores maiores ou iguais a R$ 3.000,00 ---> 2,0% de desconto
         * Valores maiores ou iguais a R$ 1.000,00 ---> 1,0% de desconto
         * Valores maiores ou iguais a R$   350,00 ---> 0,5% de desconto */
        public float percentualDesconto(float valor)
        {
            if (valor > 5000) return 0.03f;
            if (valor > 3000) return 0.02f;
            if (valor > 1000) return 0.01f;
            if (valor > 350) return 0.005f;
            return 0f;
        }

        // Retorna o valor do desconto aplicado a uma compra
        public float valorDesconto(float valor)
        {
            return valor * percentualDesconto(valor);
        }

        // Retorna o valor total (final) já considerando desconto (se houver)
        public float totalCompra(float valor)
        {
            return valor - valorDesconto(valor);
        }
    }
}
