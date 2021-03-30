using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairCenter.Entities
{
    public class Repair
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Defect { get; set; }
        public DateTime RegisteredDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
