using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class IzmeniAngazovanjeSO:BaseSO
    {
        private Angazovanje a;

        public IzmeniAngazovanjeSO(Angazovanje a)
        {
            this.a = a;
        }

        protected override void ExecuteOperation()
        {
            repository.Update(a, $"TipAngazovanja={(int)a.TipAngazovanja},DatumObavljanja='{a.DatumObavljanja.ToString("yyyy-MM-dd")}',VremeObavljanja='{a.VremeObavljanja}'");
            foreach (StavkaAngazovanja stavka in a.StavkaAngazovanja)
            {
                stavka.Angazovanje = a;
                repository.Delete(stavka);
            }

            foreach (StavkaAngazovanja stavka in a.StavkaAngazovanja)
            {
                stavka.Angazovanje = a;

                repository.Add(stavka);

            }

        }
    }
}
