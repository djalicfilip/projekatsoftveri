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
    public enum TipAngazovanja {
            Osamnaesti_rođendan=1,
            Venčanje,
            Krštenje,
            Matura,
            Diplomiranje
    }

    [Serializable]
    public class Angazovanje : IEntity
    {
        TipAngazovanja tipAngazovanja;
        DateTime datumObavljanja;
        TimeSpan vremeObavljanja;
        Lokal lokal;
        Radnik radnik;
        List<StavkaAngazovanja> stavkaAngazovanja=new List<StavkaAngazovanja>();
        public int ID { get; set; }
     
        [Browsable(false)]
        public string TableName { get; set; } = "Angazovanje";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "Angazovanje a join Radnik r on a.IdRadnika=r.IdRadnika join Lokal l on l.IdLokala=a.IdLokala";
        [Browsable(false)]
        public string InsertedValues => $" {(int)TipAngazovanja}, '{datumObavljanja.ToString("yyyy-MM-dd")}', '{VremeObavljanja}',{Lokal.ID},{Radnik.ID}";
        [Browsable(false)]
        public string InsertedColumns => " (TipAngazovanja, datumObavljanja, VremeObavljanja,IdLokala,IdRadnika)";
        [Browsable(false)]
        public string IdColumn { get; set; } = "IdAngazovanja";
        public TipAngazovanja TipAngazovanja { get => tipAngazovanja; set => tipAngazovanja = value; }
        public DateTime DatumObavljanja { get => datumObavljanja; set => datumObavljanja = value; }
        public TimeSpan VremeObavljanja { get => vremeObavljanja; set => vremeObavljanja = value; }
        public Lokal Lokal { get => lokal; set => lokal = value; }
        public Radnik Radnik { get => radnik; set => radnik = value; }
        public List<StavkaAngazovanja> StavkaAngazovanja { get => stavkaAngazovanja; set => stavkaAngazovanja = value; }

        [Browsable(false)]
        public string ReturnedColumns { get; set; } = "A.IdAngazovanja, A.vremeObavljanja, A.datumObavljanja, A.TipAngazovanja,A.IdRadnika, R.Ime AS ImeRadnika, R.Prezime AS PrezimeRadnika,L.IdLokala AS IdLokala, L.Naziv AS NazivLokala, L.Adresa AS AdresaLokala";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> angazovanja = new List<IEntity>();
            while (reader.Read())
            {
                int idAng = (int)reader["IdAngazovanja"];
                int radnikId = (int)reader["IdRadnika"];
                string imeRadnika = (string)reader["ImeRadnika"];
                string prezimeRadnika = (string)reader["PrezimeRadnika"];
                int lokalId = (int)reader["IdLokala"];
                string nazivLokala = (string)reader["NazivLokala"];
                string adresaLok = (string)reader["AdresaLokala"];

                Angazovanje angazovanje = new Angazovanje
                {
                    ID = idAng,
                    VremeObavljanja = (TimeSpan)reader["vremeObavljanja"],
                    datumObavljanja = (DateTime)reader["datumObavljanja"],
                    TipAngazovanja = (TipAngazovanja)reader["TipAngazovanja"],
                    Radnik = new Radnik { ID = radnikId, Ime = imeRadnika,Prezime=prezimeRadnika },
                    Lokal = new Lokal { ID = lokalId, Naziv = nazivLokala,Adresa=adresaLok },
                    StavkaAngazovanja = new List<StavkaAngazovanja>()
                };

                angazovanja.Add(angazovanje);
            }

            return angazovanja;
        }
        /* List<IEntity> rezultat = new List<IEntity>();
         while (reader.Read())
         {
             Angazovanje a= new Angazovanje();
             a.ID = reader.GetInt32(0);
             a.TipAngazovanja =(TipAngazovanja) reader.GetInt32(1);
             a.DatumObavljanja = reader.GetDateTime(2);
            a.VremeObavljanja = reader.GetTimeSpan(3);
             Radnik r = new Radnik();
             r.ID = reader.GetInt32(6);
             r.Ime = reader.GetString(7);
             r.Prezime = reader.GetString(8);
             a.Radnik = r;
             Lokal l = new Lokal();
             l.ID = reader.GetInt32(13);
             l.Naziv=reader.GetString(14);
             l.Adresa = reader.GetString(16);
             Grad g = new Grad();
             g.ID = reader.GetInt32(17);
             l.Grad = g;

             a.Lokal = l;
             rezultat.Add(a);
         }
         return rezultat;
     }*/
        List<IEntity> IEntity.GetList2(SqlDataReader reader)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
