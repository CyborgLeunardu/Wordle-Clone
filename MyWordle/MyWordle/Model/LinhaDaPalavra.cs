using CommunityToolkit.Mvvm.ComponentModel;

namespace MyWordle.Model
{
    public class LinhaDaPalavra
    {
        public LinhaDaPalavra()
        {
            Letras = new Letra[5]
            {
                new Letra(),
                new Letra(),
                new Letra(),
                new Letra(),
                new Letra()

            };
        }

        public Letra[] Letras { get; set; }
        public bool Validar(char[] respostaCorreta)
        {

            int count = 0;

            for (int i = 0; i < Letras.Length; i++)
            {
                var letra = Letras[i];
                if (letra.Input == respostaCorreta[i])
                {
                    letra.Cor = Colors.Green;
                    count++;
                }
                else if (respostaCorreta.Contains(letra.Input))
                {
                    letra.Cor = Colors.Yellow;
                }
                else
                {
                    letra.Cor = Colors.Gray;
                }
            }

            return count == 5;
        }
    }

    public partial class Letra : ObservableObject
    {
        [ObservableProperty]
        private Color cor;

        [ObservableProperty]
        private char input;

        public Letra()
        {
            Cor = Colors.Black;
        }
    }
}
