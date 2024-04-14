using Common;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class KreirajAngazovanjeSO : BaseSO
    {
        Angazovanje a;
        public KreirajAngazovanjeSO(Angazovanje a)
        {
            this.a = a;
        }

        protected override void ExecuteOperation()
        {
 
           
            var stavkeIEntity = new List<IEntity>(a.StavkaAngazovanja.Cast<IEntity>().ToList());
            repository.AddWithItems(a, stavkeIEntity);
        }
    }
}
