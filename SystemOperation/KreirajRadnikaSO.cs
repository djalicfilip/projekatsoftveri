using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class KreirajRadnikaSO:BaseSO
    {
        private Radnik r;

       

        public KreirajRadnikaSO(Radnik r)
        {
            this.r = r;
        }

        protected override void ExecuteOperation()
        {
            repository.Add(r);
        }
    }
}
