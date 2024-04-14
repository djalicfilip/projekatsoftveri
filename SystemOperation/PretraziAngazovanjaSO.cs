using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SystemOperation
{
    public class PretraziAngazovanjaSO:BaseSO
    {
        private Radnik r;

        public PretraziAngazovanjaSO(Radnik r)
        {
            this.r = r;
        }


        public List<Domain.Angazovanje> Result { get; set; }
        protected override void ExecuteOperation()
        {

            string criteria = $"r.ime like '%{r.Ime}%'";
            Result = repository.Search(new Angazovanje(), criteria).OfType<Angazovanje>().ToList();

        }
    }
}
