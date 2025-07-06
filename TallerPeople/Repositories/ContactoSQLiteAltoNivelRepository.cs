using SQLite;
using System.Threading.Tasks;
using TallerPeople.Interfaces;
using TallerPeople.Models;


namespace TallerPeople.Repositories
{
    internal class ContactoSQLiteAltoNivelRepository : IContactoServices
    {
        private SQLiteAsyncConnection _connSQLite;
        private string _dbPath = FileSystem.Current.AppDataDirectory + "/contactos.db3";

        public ContactoSQLiteAltoNivelRepository()
        {
            Init();
        }   
        public async void Init()
        {
            if (_connSQLite != null)
            {
                return;
            }
            _connSQLite = new SQLiteAsyncConnection(_dbPath);
            await _connSQLite.CreateTableAsync<Contacto>();



        }



        public async Task<List<Contacto>> DevuelveContactos()
        {
            try
            {
                List<Contacto> contacts = await _connSQLite.Table<Contacto>().ToListAsync();
                return contacts;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> EliminarContacto(int Id)
        {
            try
            {
                await _connSQLite.DeleteAsync(Id);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> GuardarContacto(Contacto contacto)
        {
            try
            {
                await _connSQLite.InsertAsync(contacto);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}