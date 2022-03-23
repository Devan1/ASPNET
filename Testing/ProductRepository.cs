using System.Data;

namespace Testing
{
    public class ProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
    }
}
