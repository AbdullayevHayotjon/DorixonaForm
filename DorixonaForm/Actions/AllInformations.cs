using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DorixonaForm.Actions
{
    public class AllInformations
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string ProcessType { get; set; }
        public string Information { get; set; }
        public string ProcessTime { get; set; }
    }
}
