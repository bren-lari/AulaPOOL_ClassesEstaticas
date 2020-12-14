namespace Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.10f;

        public static float CoverterDolarParaReal (float valorEmRS){
            return valorEmRS / CotacaoDolar;
        }

        public static float DolarParaReais (float valorEmUS){
            return CotacaoDolar * valorEmUS;
        }
    }
}