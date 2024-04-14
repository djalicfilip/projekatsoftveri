using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveLokaleSO : BaseSO
    {
        public List<Lokal> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Lokal()).OfType<Lokal>().ToList();
        }
    }
}
