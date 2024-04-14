using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveDekoracijeSO : BaseSO
    {
        public List<Dekoracija> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Dekoracija()).OfType<Dekoracija>().ToList();
        }
    }
}
