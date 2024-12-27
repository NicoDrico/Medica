using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medica.Model.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public int? ProviderId { get; set; }
    }
}
