using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaVendas.Domain.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public byte[] Bytes { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public string Format { get; set; }
        public IEnumerable<ProductDocument>? Products { get; set; }
    }
}
