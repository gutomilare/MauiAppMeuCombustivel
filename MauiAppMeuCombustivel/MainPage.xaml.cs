namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                // Declarando variáveis e convertendo pra double, tudo que o usuário inputa é texto, as conversões são feitas depois

                // Etanol rende 70% da gasolina, então ele precisa ser 70% ou menos do preço da gasolina para valer a pena

                string marca = txt_marcaveiculo.Text;
                string modelo = txt_modeloveiculo.Text;

                // Declarando as variáveis de marca e modelo, ambas são texto então não preciso converter

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando mais para o seu " + marca + " " + modelo + "!";
                }
                else
                {
                    msg = "A gasolina está compensando mais para o seu " + marca + " " + modelo + "!";
                }

                DisplayAlert("Calculado", msg, "OK");


            }
            catch (Exception ex)
            {
                DisplayAlert("Oos", ex.Message, "Fechar");
            }

        } // Fecha método
    } // Fecha class
} // Fecha namespace
