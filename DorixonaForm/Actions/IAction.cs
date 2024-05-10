using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorixonaForm.Actions
{
    public interface IAction
    {
        public bool CheckProbel(string str);
        public bool CheckNumber(string str);
    }
}
