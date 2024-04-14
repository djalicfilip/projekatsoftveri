using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Radnik : IEntity
    {
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private string brojTelefona;
        private string adresa;
        private Grad grad;

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public Grad Grad { get => grad; set => grad = value; }

        [Browsable(false)]
        public int ID { get ; set ; }
        [Browsable(false)]
        public string TableName { get; set; } = "Radnik";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Radnik r join Grad g on r.IdGrada=g.IdGrada";

        [Browsable(false)]
        public string InsertedValues => $" '{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyy-MM-dd")}', '{BrojTelefona}','{Adresa}', {Grad.ID} ";

        [Browsable(false)]
        public string InsertedColumns => "(Ime, Prezime, DatumRodjenja, BrojTelefona, Adresa, IdGrada)";

        [Browsable(false)]
        public string IdColumn { get ; set; } = "IdRadnika";
        [Browsable(false)]
        public string ReturnedColumns { get; set; } = "*";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> rezultat = new List<IEntity>();
            while (reader.Read())
            {
                Radnik r = new Radnik();
                r.ID = reader.GetInt32(0);
                r.Ime = reader.GetString(1);
                r.Prezime = reader.GetString(2);
                r.DatumRodjenja = reader.GetDateTime(3);
                r.BrojTelefona = reader.GetString(4);
                r.Adresa = reader.GetString(5);
                if (!reader.IsDBNull(6))
                {
                    Grad g = new Grad();
                    g.ID = reader.GetInt32(7);
                    g.Naziv = reader.GetString(8);
                    g.Ptt = reader.GetString(9);
                    r.Grad = g;
                }
                else
                {
                    r.Grad = null;
                }
                rezultat.Add(r);
            }
            return rezultat;
        }

        public List<IEntity> GetList2(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
