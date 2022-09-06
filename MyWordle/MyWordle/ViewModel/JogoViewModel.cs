using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyWordle.Model;

namespace MyWordle.ViewModel
{
    public partial class JogoViewModel : ObservableObject
    {
        int linhaIndex;
        int colunaIndex;
        char[] respostaCorreta;

        public char[] TecladoLinha1 { get; set; }
        public char[] TecladoLinha2 { get; set; }
        public char[] TecladoLinha3 { get; set; }

        [ObservableProperty]
        private LinhaDaPalavra[] linhas;

        public JogoViewModel()
        {
            linhas = new LinhaDaPalavra[6]
            {
                new LinhaDaPalavra(),
                new LinhaDaPalavra(),
                new LinhaDaPalavra(),
                new LinhaDaPalavra(),
                new LinhaDaPalavra(),
                new LinhaDaPalavra()
            };

            respostaCorreta = "codes".ToCharArray();
            TecladoLinha1 = "QWERTYUIOP".ToCharArray();
            TecladoLinha2 = "ASDFGHJKL".ToCharArray();
            TecladoLinha3 = "<ZXCVBNM>".ToCharArray();
        }

        [RelayCommand]
        public void Entrar()
        {
            if (colunaIndex != 5)
                return;

            var ehValido = true;

            if (ehValido)
            {
                if (linhaIndex == 5)
                {
                    //TERMINAR JOGO
                }
                else
                {
                    linhaIndex++;
                    colunaIndex = 0;
                }
            }
            linhaIndex = 0;
            colunaIndex = 0;
        }

        [RelayCommand]
        public void EntrarLetra(char letra)
        {
            if (letra == '>')
            {
                Entrar();
            }

            if (letra == '<')
            {
                return;
            }

            if (colunaIndex == 5)
                return;

            linhas[linhaIndex].Letras[colunaIndex].Input = letra;
            colunaIndex++;
        }
    }
}
