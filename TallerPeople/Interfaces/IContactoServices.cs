
using TallerPeople.Models;

namespace TallerPeople.Interfaces
{
    internal interface IContactoServices
    {
        public void Init ();
        public Task<List<Contacto>> DevuelveContactos();
        public Task<bool> GuardarContacto(Contacto contacto);
        public Task<bool> EliminarContacto(int Id);
    }
}
