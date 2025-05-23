
namespace Biblioteca.Controllers
{
    public class SeuDbContext
    {
        public object Reservas { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}