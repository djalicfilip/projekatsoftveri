using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
 

    [Serializable]
    public class Cenovnik : IEntity
    {

        DateTime datumObjave;
        DateTime datumVazenja;
        List<StavkaCenovnika> stavkeCenovnika= new List<StavkaCenovnika>();
       
        public int ID { get; set; }


        [Browsable(false)]
        public string TableName { get; set; } = "Cenovnik";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Cenovnik";
        [Browsable(false)]
        public string InsertedValues => throw new NotImplementedException();
        [Browsable(false)]
        public string InsertedColumns => throw new NotImplementedException();

        string IEntity.IdColumn { get; set; } = "IdCenovnika";
        public DateTime DatumObjave { get => datumObjave; set => datumObjave = value; }
        public DateTime DatumVazenja { get => datumVazenja; set => datumVazenja = value; }
        internal List<StavkaCenovnika> StavkeCenovnika { get => stavkeCenovnika; set => stavkeCenovnika = value; }

        public string ReturnedColumns { get; set; } = "*";

        public override string ToString()
        {
            return ID.ToString();
        }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> rezultat = new List<IEntity>();
            while (reader.Read())
            {
                Cenovnik c= new Cenovnik();
                c.ID = reader.GetInt32(0);
                c.datumObjave = reader.GetDateTime(1);
                c.datumVazenja = reader.GetDateTime(2);
                rezultat.Add(c);
            }
            return rezultat;
        }
        List<IEntity> IEntity.GetList2(SqlDataReader reader)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
