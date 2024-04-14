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
    public enum PDVStopa
    {
        petnaest=1,
        dvadeset=2
    }

    public enum Kategorija
    {
        baloni=1,
        mašne,
        cveće,
        konfete,
        sveće,
        trake
    }
    [Serializable]
    public class Dekoracija : IEntity
    {

        private string sifra;
        private string naziv;
        private Kategorija kategorija;
        private PDVStopa pdv;

        public override string ToString()
        {
            return Naziv;
        }

        [Browsable(false)]
        public int ID { get; set; }
        [Browsable(false)]
        public string TableName { get; set; } = "Dekoracija";
        [Browsable(false)]
        public string TableNameJoin { get; set; } ="Dekoracija";

        [Browsable(false)]
        public string InsertedValues => $" '{Sifra}', '{Naziv}', {(int)Kategorija}, {(int)Pdv} ";

        [Browsable(false)]
        public string InsertedColumns => "(Sifra, Naziv, Kategorija, PDVStopa)";
        [Browsable(false)]
        public string IdColumn { get; set; } = "IdDekoracije";
        public string Sifra { get => sifra; set => sifra = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public Kategorija Kategorija { get => kategorija; set => kategorija = value; }
        public PDVStopa Pdv { get => pdv; set => pdv = value; }

        public string ReturnedColumns { get; set; } = "*";

        [Browsable(false)]


        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> rezultat = new List<IEntity>();
            while (reader.Read())
            {
                Dekoracija d = new Dekoracija();
                d.ID = reader.GetInt32(0);
                d.sifra = reader.GetString(1);
                d.naziv = reader.GetString(2);
                d.Kategorija = (Kategorija)reader.GetInt32(3);
                d.Pdv = (PDVStopa)reader.GetInt32(4);
                rezultat.Add(d);
            }
            return rezultat;
        }

        public List<IEntity> GetList2(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
