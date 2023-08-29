using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO_database
{
    public class FullTableModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string salary { get; set; }
        public string start_date { get; set; }
        public char Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Basic_pay { get; set; }
        public string Deductions { get; set; }
        public string Taxable_pay { get; set; }
        public string Income_tax { get; set;}
        public string Net_pay { get; set; }

    }
}
