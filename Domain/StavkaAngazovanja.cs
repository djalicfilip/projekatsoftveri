using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{

    [Serializable]
    public class StavkaAngazovanja : IEntity
    {
     

        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public Angazovanje Angazovanje { get; set; }
        public Dekoracija Dekoracija { get; set; }
        public int Kolicina { get; set; }
        public double CenaSaPDV { get; set; }
        public double UkupnaCena { get; set; }

        [Browsable(false)]
        public string TableName { get; set; } = "StavkaAngazovanja";
        [Browsable(false)]
        public string TableNameJoin { get; set; } = "StavkaAngazovanja s join Dekoracija d on s.IdDekoracije=d.IdDekoracije";
        [Browsable(false)]
        public string InsertedValues => $"{Angazovanje?.ID},{Kolicina},{CenaSaPDV.ToString("0.00", CultureInfo.InvariantCulture)},{UkupnaCena},{Dekoracija.ID}";
        [Browsable(false)]
        public string InsertedColumns => "(IdAngazovanja, Kolicina,CenaSaPDV,UkupnaCena,IdDekoracije)";

        [Browsable(false)]
        string IEntity.IdColumn { get; set; } = "Rb";
        [Browsable(false)]
        public string ReturnedColumns => "*";

        public List<IEntity> GetList(SqlDataReader reader)
            {
                List<IEntity> Result = new List<IEntity>();
                while (reader.Read())
                {
                    StavkaAngazovanja sa = new StavkaAngazovanja();
                    sa.ID = reader.GetInt32(0);
                sa.Kolicina = reader.GetInt32(2);
                sa.CenaSaPDV = reader.GetDouble(3);
                sa.UkupnaCena = reader.GetDouble(4);
                    Angazovanje a = new Angazovanje();
                    a.ID = reader.GetInt32(1);
                    sa.Angazovanje = a;
                Dekoracija d = new Dekoracija();
                    d.ID = reader.GetInt32(6);
                d.Naziv = reader.GetString(8);
                sa.Dekoracija = d;
                    Result.Add(sa);

                }
                return Result;
            }

            List<IEntity> IEntity.GetList2(SqlDataReader reader)
            {
                //throw new NotImplementedException();
                return null;
            }
        }
    }



