using CommunityToolkit.Mvvm.ComponentModel;

namespace MyWordle.Model
{
    public class LinhaDaPalavra
    {
        public List<Letra> Letras { get; set; }

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
    }
}
