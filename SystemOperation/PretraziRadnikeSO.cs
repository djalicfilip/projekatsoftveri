using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class PretraziRadnikeSO : BaseSO
    {
        private string text;
        Radnik r;

        public PretraziRadnikeSO(Radnik r, string criteria)
        {
            this.r = r;
            text = criteria;
        }

        public List<Domain.Radnik> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.Search(r, text).OfType<Radnik>().ToList();

        }
    }
}
