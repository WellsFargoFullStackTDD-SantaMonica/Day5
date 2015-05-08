using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksDAL
{
    public interface IAdventureWorksContext : IDisposable
    {
        DbSet<Product> Products { get; set; }
        int SaveChanges();
        void MarkAsModified(Product item);
    }
}
