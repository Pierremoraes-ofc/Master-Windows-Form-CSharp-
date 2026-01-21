namespace Master
{
    public static class biblioteca
    {
        public static FormMenu _formMenu;     //  usado para salvar as instâncias!
        public static FormMenu _formSystem;     //  usado para salvar as instâncias!

        //  Configuração das Notificações:
        public static bool      ToastTopMost = true;                //  Sobreposição
        public static float     ToastOpacity = 1.0f;                //  Opacidade
        public static string    ToastPosition = "BottomLeft";       //  Posição         BottomRight = canto inferior DIREITO / BottomLeft = canto inferior ESQUERDO / TopRight = canto superior direito / TopLeft = canto superior ESQUERDO
        public static int       ToastTimer = 60000;                 //  Tempo mostrando

        //  Configuração de Idioma
        public static string    InputLanguage = "English-USA";

        //  Configuração do Menu
        public static bool      MenuSistema = false;                //  false = grande / true = compacto

        //  Configuração do Projeto
        public static float     MasterOpacity = 0.5f;               //  Opacidade do fundo do Projeto
        public static int       MasterBorderSize = 1;               //  Largura da borda


        public enum ConvertType
        {
            IntToDouble,
            DoubleToInt,

            IntToFloat,
            FloatToInt,

            IntToDecimal,
            DecimalToInt,

            FloatToDouble,
            DoubleToFloat,

            FloatToDecimal,
            DecimalToFloat,

            DoubleToDecimal,
            DecimalToDouble
        }

        public static object Converter(ConvertType type, object value)
        {
            try
            {
                switch (type)
                {
                    case ConvertType.IntToDouble:
                        return Convert.ToDouble(value);

                    case ConvertType.DoubleToInt:
                        return Convert.ToInt32(Math.Round(Convert.ToDouble(value)));

                    case ConvertType.IntToFloat:
                        return Convert.ToSingle(value);

                    case ConvertType.FloatToInt:
                        return Convert.ToInt32(Math.Round(Convert.ToSingle(value)));

                    case ConvertType.IntToDecimal:
                        return Convert.ToDecimal(value);

                    case ConvertType.DecimalToInt:
                        return Convert.ToInt32(Math.Round(Convert.ToDecimal(value)));

                    case ConvertType.FloatToDouble:
                        return Convert.ToDouble(value);

                    case ConvertType.DoubleToFloat:
                        return Convert.ToSingle(value);

                    case ConvertType.FloatToDecimal:
                        return Convert.ToDecimal(value);

                    case ConvertType.DecimalToFloat:
                        return Convert.ToSingle(value);

                    case ConvertType.DoubleToDecimal:
                        return Convert.ToDecimal(value);

                    case ConvertType.DecimalToDouble:
                        return Convert.ToDouble(value);

                    default:
                        throw new NotSupportedException("Conversão não suportada.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Erro na conversão.", ex);
            }
        }




        public static void Notification(string type, string title, string msg)
        {
            Toast ntfy = new Toast();
            ntfy.Notify(type, title, msg);
        }
    }
}
