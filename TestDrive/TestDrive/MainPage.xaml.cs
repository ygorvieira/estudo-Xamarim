using System.Collections.Generic;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive
{
    public partial class MainPage : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public MainPage()
        {

            InitializeComponent();

            Veiculos = new List<Veiculo>
            {
                new Veiculo {Nome = "Azera V6", Preco = 60000},
                new Veiculo {Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo {Nome = "HB20 S", Preco = 40000}
            };

            BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            DisplayAlert("Test Drive", string.Format("Você selecionou o modelo '{0}', que custa {1}", veiculo.Nome, veiculo.PrecoFormatado), "OK");
        }
    }
}
