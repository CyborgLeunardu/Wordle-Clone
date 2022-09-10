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

            respostaCorreta = "CODES".ToCharArray();
            TecladoLinha1 = "QWERTYUIOP".ToCharArray();
            TecladoLinha2 = "ASDFGHJKL".ToCharArray();
            TecladoLinha3 = "<ZXCVBNM>".ToCharArray();
        }

        [RelayCommand]
        public void Entrar()
        {
            if (colunaIndex != 5)
                return;

            var ehValido = Linhas[linhaIndex].Validar(respostaCorreta);

            if (ehValido)
            {
                Application.Current.MainPage.DisplayAlert("Você venceu!", "Você é muito inteligente!!", "Ok");
            }
            if (linhaIndex == 5)
            {
                Application.Current.MainPage.DisplayAlert("Você perdeu!", "Acabaram suas tentativas!!", "Ok");
            }
            else
            {
                linhaIndex++;
                colunaIndex = 0;
            }
        }

        [RelayCommand]
        public void EntrarLetra(char letra)
        {
            if (letra == '>')
            {
                Entrar();
                return;
            }

            if (letra == '<')
            {
                if (colunaIndex == 0)
                    return;
                colunaIndex--;
                linhas[linhaIndex].Letras[colunaIndex].Input = ' ';
                return;
            }

            if (colunaIndex == 5)
                return;

            linhas[linhaIndex].Letras[colunaIndex].Input = letra;
            colunaIndex++;
        }
    }
}
