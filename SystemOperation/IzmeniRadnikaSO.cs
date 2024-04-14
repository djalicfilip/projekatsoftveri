using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class IzmeniRadnikaSO : BaseSO
    {
        private Radnik r;

        public IzmeniRadnikaSO(Radnik requestObj)
        {
            r = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Update(r, $"Ime='{r.Ime}',Prezime='{r.Prezime}',DatumRodjenja='{r.DatumRodjenja.ToString("yyyy-MM-dd")}',BrojTelefona='{r.BrojTelefona}',Adresa='{r.Adresa}',IdGrada={r.Grad.ID}");
        }
    }
}
