using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveStavkeAngazovanjaSO : BaseSO
    {
        private Angazovanje a;
        public List<StavkaAngazovanja> Result { get; set; }
        public UcitajSveStavkeAngazovanjaSO(Angazovanje a)
        {
            this.a = a;
        }

        protected override void ExecuteOperation()
        {
            string criteria = $"IdAngazovanja = {a.ID}";
            Result = repository.Search(new StavkaAngazovanja(), criteria).OfType<StavkaAngazovanja>().ToList();
        }
    }
}
