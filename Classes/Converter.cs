namespace Classes
{
    public class Converter
    {
        private static float CotacaoEuro = 6.21f;

        public static float ConversãoDoEuroParaReal (float valorEmRS){
            return valorEmRS / CotacaoEuro;
        }

        public static float EuroParaReal (float valorEmEUR){
            return CotacaoEuro * valorEmEUR;
        }
    }
}