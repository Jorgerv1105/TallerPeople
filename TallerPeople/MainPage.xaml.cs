using TallerPeople.Interfaces;
using TallerPeople.Models;
using TallerPeople.Repositories;

namespace TallerPeople
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        IContactoServices _repoSQLite;

        public MainPage()
        {
            InitializeComponent();
            _repoSQLite = new ContactoSQLiteAltoNivelRepository();
        }

        private async void GuardarInformacion_Clicked(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto
            {
                Nombre = Nombre.Text,
                Direccion = Direccion.Text,
                Telefono = Telefono.Text
            };
            await _repoSQLite.GuardarContacto(contacto);
            {

            }
        }

    }
}
