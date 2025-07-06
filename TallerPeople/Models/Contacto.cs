using SQLite;


namespace TallerPeople.Models
{
    [Table("Contactos")]
    public class Contacto
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(12)]
        public string Telefono { get; set; }
        [MaxLength(300)]    
        public string Direccion { get; set; }
    }
}
