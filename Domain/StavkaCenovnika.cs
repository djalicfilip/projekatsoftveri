using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum Valuta { RSD=1,EUR}
    public enum JM { kom=1,m,cm}
    [Serializable]
    public class StavkaCenovnika:IEntity
    {
        Cenovnik cenovnik;
        JM jm;
        Valuta valuta;
        Dekoracija dekoracija;
        double cenaBezPDV;
        double cenaSaPDV;

        [Browsable(false)]
        public int ID { get ; set; }
        [Browsable(false)]
        public string TableName { get; set; } = "StavkaCenovika";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "StavkaCenovnika s join Dekoracija d on s.IdDekoracije=d.IdDekoracije";
        [Browsable(false)]
        public string ReturnedColumns => "s.Rb as Rb,s.IdCenovnika as IdCenovnika,s.CenaBezPdv as CenaBezPDV, s.CenaSaPdv as CenaSaPDV, s.JM as JedinicaMere, s.Valuta as Valuta, d.IdDekoracije as IdDekoracije,d.naziv as Naziv";
        [Browsable(false)]
        public string InsertedValues => $" '{Cenovnik.ID},{(int)Jm},{(int)Valuta},{Dekoracija.ID},{cenaBezPDV},{cenaSaPDV} ";

        [Browsable(false)]
        public string InsertedColumns => "(IdCenovnika, Jm, Valuta, IdDekoracije, cenaBezPDV, cenaSaPDV)";

        [Browsable(false)]
        public string IdColumn { get; set; } = "Rb";
        [Browsable(false)]
        public Cenovnik Cenovnik { get => cenovnik; set => cenovnik = value; }

        public Dekoracija Dekoracija { get => dekoracija; set => dekoracija = value; }
        public JM Jm { get => jm; set => jm = value; }
       
        public double CenaBezPDV { get => cenaBezPDV; set => cenaBezPDV = value; }
        public double CenaSaPDV { get => cenaSaPDV; set => cenaSaPDV = value; }

        public Valuta Valuta { get => valuta; set => valuta = value; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> Result = new List<IEntity>();
            while (reader.Read())
            {
                StavkaCenovnika sc = new StavkaCenovnika();
                sc.ID = reader.GetInt32(0);
                Cenovnik c = new Cenovnik();
                c.ID=reader.GetInt32(1);
                sc.Cenovnik = c;
                sc.cenaBezPDV = reader.GetDouble(2);
                sc.cenaSaPDV = reader.GetDouble(3);
                sc.Jm = (JM)reader.GetInt32(4);
                sc.Valuta =(Valuta) reader.GetInt32(5);
                Dekoracija d = new Dekoracija();
                d.ID= reader.GetInt32(6);
                d.Naziv = reader.GetString(7);
                sc.Dekoracija = d;
              
                Result.Add(sc);

            }
            return Result;
        }

        public List<IEntity> GetList2(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
