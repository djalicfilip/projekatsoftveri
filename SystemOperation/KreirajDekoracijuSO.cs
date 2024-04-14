using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class KreirajDekoracijuSO:BaseSO
    {
 
            private Dekoracija d;

            public KreirajDekoracijuSO(Dekoracija d)
            {
                this.d = d;
            }

            protected override void ExecuteOperation()
            {
                repository.Add(d);
            }
        }
}
