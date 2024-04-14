using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveGradoveSO : BaseSO
    {

        public List<Grad> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Grad()).OfType<Grad>().ToList();
        }
    }
}
