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
    public class Grad : IEntity
    {

        private string naziv;
        private string ptt;

        public override string ToString()
        {
            return $"{Naziv}";
        }

        public int ID { get; set; }
        public string Naziv { get => naziv; set => naziv = value; }

       
        public string Ptt { get => ptt; set => ptt = value; }

        [Browsable(false)]       
     

        public string TableName { get ; set ; } = "Grad";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Grad";
        [Browsable(false)]

        public string InsertedValues;
        [Browsable(false)]

        public string InsertedColumns;
        [Browsable(false)]

        public string IdColumn { get; set; } = "IdGrada";
        [Browsable(false)]

        string IEntity.InsertedValues => throw new NotImplementedException();
        [Browsable(false)]
        string IEntity.InsertedColumns => throw new NotImplementedException();
        [Browsable(false)]
        public string ReturnedColumns { get; set; } = "*";

        public List<IEntity> GetList(SqlDataReader reader)
        {

            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Grad g = new Grad();
                g.ID= reader.GetInt32(0);
                g.naziv= reader.GetString(1);
                g.ptt = reader.GetString(2);
                result.Add(g);

            }
            return result;
        }

        public List<IEntity> GetList2(SqlDataReader reader)
        {
            return null;
        }
    }
}
