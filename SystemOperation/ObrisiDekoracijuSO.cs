using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class ObrisiDekoracijuSO:BaseSO
    {
        private Dekoracija dekoracija;

        public ObrisiDekoracijuSO(Dekoracija requestObj)
        {
            dekoracija = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Delete(dekoracija);
        }
    }
}
