using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medica.Model.Models
{

    public class OrderEquipment
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int EquipmentId { get; set; }
        public int Quantity { get; set; }
        public int? ProviderId { get; set; }
        public string Status { get; set; } = string.Empty;
    }
    
}
