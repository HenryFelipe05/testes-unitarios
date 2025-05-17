namespace MarketShare
{
    public class Calculo
    {
        public float calculaMarketShare(float vendas, float total)
        {
            return (vendas / total) * 100;
        }
    }
}
