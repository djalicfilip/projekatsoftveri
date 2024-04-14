using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation;

namespace Server
{
    internal class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private Controller()
        {
        }

        public object Prijava(Korisnik requestObj)
        {
            BaseSO so = new PrijavaSO(requestObj);
            so.Execute();
            return ((PrijavaSO)so).Result;
        }

      

    

        internal void KreirajRadnika(Radnik requestObj)
        {
           BaseSO so=new KreirajRadnikaSO(requestObj);
            so.Execute();

        }

        internal object UcitajSveGradove()
        {
            BaseSO so = new UcitajSveGradoveSO();
            so.Execute();
            return ((UcitajSveGradoveSO)so).Result;
        }

        internal object UcitajSveRadnike()
        {
            BaseSO so = new UcitajSveRadnikeSO();
            so.Execute();
            return ((UcitajSveRadnikeSO)so).Result;
        }

        internal object PretraziRadnike(Radnik requestObject, string criteria)
        {
            BaseSO so = new PretraziRadnikeSO(requestObject,criteria);
            so.Execute();
            return ((PretraziRadnikeSO)so).Result;
        }


        internal void ObrisiRadnika(Radnik requestObj)
        {
            BaseSO so = new ObrisiRadnikaSO(requestObj);
            so.Execute();
        }

        internal void IzmenaRadnika(Radnik requestObj)
        {
            BaseSO so = new IzmeniRadnikaSO(requestObj);
            so.Execute();
        }

        internal void KreirajDekoraciju(Dekoracija requestObj)
        {
            BaseSO so = new KreirajDekoracijuSO(requestObj);
            so.Execute();

        }

        internal object UcitajSveDekoracije()
        {
            BaseSO so = new UcitajSveDekoracijeSO();
            so.Execute();
            return ((UcitajSveDekoracijeSO)so).Result;
        }

        internal void ObrisiDekoraciju(Dekoracija requestObj)
        {
            BaseSO so = new ObrisiDekoracijuSO(requestObj);
            so.Execute();
        }

        internal void IzmenaDekoracije(Dekoracija requestObj)
        {
            BaseSO so = new IzmeniDekoracijuSO(requestObj);
            so.Execute();
        }


        internal object PretraziDekoracije(Dekoracija requestObj, string parametri)
        {
            BaseSO so = new PretraziDekoracijeSO(requestObj, parametri);
            so.Execute();
            return ((PretraziDekoracijeSO)so).Result;
        }

        internal object UcitajSveStavkeCenovnika()
        {
            BaseSO so = new UcitajSveStavkeCenovnikaSO();
            so.Execute();
            return ((UcitajSveStavkeCenovnikaSO)so).Result;
        }

        internal object UcitajSveLokale()
        {
            BaseSO so = new UcitajSveLokaleSO();
            so.Execute();
            return ((UcitajSveLokaleSO)so).Result;
        }

        internal void KreirajAngazovanje(Angazovanje requestObj)
        {
            BaseSO so = new KreirajAngazovanjeSO(requestObj);
            so.Execute();
        }

        internal object UcitajSvaAngazovanja()
        {
            BaseSO so = new UcitajSvaAngazovanjaSO();
            so.Execute();
            return ((UcitajSvaAngazovanjaSO)so).Result;
        }


        internal object PretraziAngazovanja(Radnik requestObj)
        {
            BaseSO so = new PretraziAngazovanjaSO(requestObj);
            so.Execute();
            return ((PretraziAngazovanjaSO)so).Result;
        }

        internal object UcitajSveStavkeAngazovanja(Angazovanje requestObj)
        {
            BaseSO so = new UcitajSveStavkeAngazovanjaSO(requestObj);
            so.Execute();
            return ((UcitajSveStavkeAngazovanjaSO)so).Result;
        }

        internal void IzmeniAngazovanje(Angazovanje requestObj)
        {
            BaseSO so = new IzmeniAngazovanjeSO(requestObj);
            so.Execute();
        }
    }
}
