using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSvaAngazovanjaSO:BaseSO
    {
        public List<Angazovanje> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Angazovanje()).OfType<Angazovanje>().ToList();
        }
    }
}
