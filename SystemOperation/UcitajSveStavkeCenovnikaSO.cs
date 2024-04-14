using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveStavkeCenovnikaSO:BaseSO
    {
        public List<StavkaCenovnika> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new StavkaCenovnika()).OfType<StavkaCenovnika>().ToList();
        }
    }
}
