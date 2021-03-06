using AppToDoList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppToDoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbrirTarefa : ContentPage
    {
        public AbrirTarefa()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Tarefa t = new Tarefa
            {
                Id = Convert.ToInt16(lbl_id.Text),
                Nome = txt_nome.Text,
                Preco = txt_preco.Text,
                Data_Criacao = dtpck_data_criacao.Date,
                
            };

            await App.Database.Update(t);

            await DisplayAlert("Sucesso", "Atualizado no SQLite", "OK");

            await Navigation.PushAsync(new Listagem());
        }
    }
}