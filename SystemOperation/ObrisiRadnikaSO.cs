using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class ObrisiRadnikaSO:BaseSO
    {
        private Radnik requestObj;

        public ObrisiRadnikaSO(Radnik requestObj)
        {
            this.requestObj = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Delete(requestObj);
        }
    }
}
