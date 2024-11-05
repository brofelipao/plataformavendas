using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaVendas.Domain.Entities
{
    public class ProductDocument
    {
        public int ProductId { get; set; }
        public int FileId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Document? File { get; set; }
    }
}
