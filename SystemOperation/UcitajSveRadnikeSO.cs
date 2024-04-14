using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveRadnikeSO : BaseSO
    {
        public List<Radnik> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Radnik()).OfType<Radnik>().ToList();
        }
    }
}
