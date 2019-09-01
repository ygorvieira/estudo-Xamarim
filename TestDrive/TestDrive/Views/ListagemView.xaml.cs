using System.Collections.Generic;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
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

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}
