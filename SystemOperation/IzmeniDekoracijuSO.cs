using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class IzmeniDekoracijuSO:BaseSO
    {
        private Dekoracija d;

        public IzmeniDekoracijuSO(Dekoracija requestObj)
        {
            d = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Update(d, $"Naziv='{d.Naziv}',Sifra='{d.Sifra}',Kategorija={(int)d.Kategorija},PdvStopa={(int)d.Pdv}");
        }




    }
}
