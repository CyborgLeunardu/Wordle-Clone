using CommunityToolkit.Mvvm.ComponentModel;

namespace MyWordle.Model
{
    public class LinhaDaPalavra
    {
        public Letra[] Letras { get; set; }

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

        public void Validar(char[] respostaCorreta)
        {

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
