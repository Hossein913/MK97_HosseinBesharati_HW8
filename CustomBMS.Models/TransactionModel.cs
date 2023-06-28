using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBMS.Models
{
    public class TransactionModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal credit { get; set; }
        public decimal debit { get; set; }
        public decimal balance { get; set; }
        public string Discription { get; set; }

    }
}
