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
    public class Lokal : IEntity
    {
        private string naziv;
        int kapacitet;
        string adresa;
        Grad grad;

        public override string ToString()
        {
            return $"{Naziv}";
        }

        [Browsable(false)]
        public int ID { get; set; }
        [Browsable(false)]
        public string TableName { get; set; } = "Lokal";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Lokal l join Grad g on l.IdGrada=g.IdGrada";
        [Browsable(false)]
        string IEntity.InsertedValues => throw new NotImplementedException();
        [Browsable(false)]
        string IEntity.InsertedColumns => throw new NotImplementedException();
        [Browsable(false)]
        public string IdColumn { get; set; } = "IdLokala";
      
    

        public string Naziv { get => naziv; set => naziv = value; }
        public int Kapacitet { get => kapacitet; set => kapacitet = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public Grad Grad { get => grad; set => grad = value; }

        [Browsable(false)]
        public string ReturnedColumns { get; set; } = "*";

        public List<IEntity> GetList(SqlDataReader reader)
        {

            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
               Lokal l=new Lokal();
               l.ID = reader.GetInt32(0);
                l.naziv = reader.GetString(1);
                l.kapacitet = reader.GetInt32(2);
                l.adresa = reader.GetString(3);
                if (!reader.IsDBNull(4))
                {
                    Grad g = new Grad();
                    g.ID = reader.GetInt32(5);
                    g.Naziv = reader.GetString(6);
                    g.Ptt = reader.GetString(7);
                    l.Grad = g;
                }
                else
                {
                    l.Grad = null;
                }
                result.Add(l);
         
            }
            return result;
        }

        public List<IEntity> GetList2(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
