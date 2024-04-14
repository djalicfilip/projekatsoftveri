using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class PretraziDekoracijeSO:BaseSO
    {

        private string text;
        Dekoracija d;

        public PretraziDekoracijeSO(Dekoracija d, string criteria)
        {
            this.d = d;
            text = criteria;
        }

        public List<Domain.Dekoracija> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.Pretrazi(d, text).OfType<Dekoracija>().ToList();

        }
    }
}
