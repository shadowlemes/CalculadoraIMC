namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(Ealtura.Text) / 100;
                double peso = Convert.ToDouble(Epeso.Text);
                int idade = Convert.ToInt32(Eidade.Text);

                string textoMenorIdade = "Como você é menor de idade, é importante consultar um pediatra para uma avaliação mais precisa.";
                string textoIdoso = "Como você é idoso, é importante considerar a composição corporal e consultar um geriatra.";

                var formula = peso / (altura * altura);

                if (formula > 40)
                {
                    DisplayAlert("Resultado", $"Você está com Obesidade grau III, {formula:F2}", "OK");
                }
                else if (formula >= 35 && formula <= 39.9)
                {
                    DisplayAlert("Resultado", $"Você está com Obesidade grau II {formula:F2}", "OK");
                }
                else if (formula >= 30 && formula <= 34.9)
                {
                    DisplayAlert("Resultado", $"Você está com Obesidade grau I {formula:F2}", "OK");
                }
                else if (formula >= 25 && formula <= 29.9)
                {
                    DisplayAlert("Resultado", $"Você está sobrepeso {formula:F2}", "OK");
                }
                else if (formula >= 18.5 && formula <= 24.9)
                {
                    DisplayAlert("Resultado", $"Você está no seu peso ideal {formula:F2}", "OK");
                }
                else 
                {
                    DisplayAlert("Resultado", $"Você está abaixo do peso {formula:F2}", "OK");
                }
                if (idade <18)
                {
                    DisplayAlert("Resultado", $"{textoMenorIdade}", "OK");
                }
                else if (idade >= 65)
                {
                    DisplayAlert("Resultado", $"{textoIdoso}", "OK");
                }

            }
            catch (Exception)
            {
                DisplayAlert("Carácter Inválido", "Insira um valor válido", "OK");

                Eidade.ClearValue(Entry.TextProperty);
                Ealtura.ClearValue(Entry.TextProperty);
                Epeso.ClearValue(Entry.TextProperty);
            }

        }
    }

}
