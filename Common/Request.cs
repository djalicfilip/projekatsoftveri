using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public enum Operation
    {
        Prijava,
        DodajRadnika,
        UcitajSveGradove,
        UcitajSveRadnike,
        PretraziRadnike,
        ObrisiRadnika,
        IzmeniRadnika,
        KreirajDekoraciju,
        UcitajSveDekoracije,
        PretraziDekoracije,
        ObrisiDekoraciju,
        IzmeniDekoraciju,
        UcitajSveStavkeCenovnika,
        UcitajSveLokale,
        SacuvajAngazovanje,
        UcitajSvaAngazovanja,
        PretraziAngazovanja,
        UcitajSveStavkeAngazovanja,
        IzmeniAngazovanje
    }
    [Serializable]
    public class Request
    {
        public object RequestObj { get; set; }
        public Operation Operation { get; set; }

    }
}
