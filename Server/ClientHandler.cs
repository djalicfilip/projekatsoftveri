using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientHandler
    {
        private Socket klijentskiSoket;
        NetworkStream tok;
        BinaryFormatter formatter;

        public ClientHandler(Socket klijentskiSoket)
        {
            this.klijentskiSoket = klijentskiSoket;
            tok = new NetworkStream(this.klijentskiSoket);
            formatter = new BinaryFormatter();
        }



        internal void Close()
        {
         klijentskiSoket.Close();
        }

        internal void Communication()
        {
            try
            {
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(tok);
                    Response response = new Response();
                    try
                    {
                        //ovde dobijam response
                        response = HandleRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response.Message = ex.Message;
                        Console.WriteLine("greska je kod response handle req" + ex.Message);
                    }
                   
                    formatter.Serialize(tok, response);
                }
            }
            catch (IOException IOex)
            {
                Debug.WriteLine("Klijent je napustio komunikaciju.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private Response HandleRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Prijava:
                        response.ResponseObj = Controller.Instance.Prijava((Korisnik)request.RequestObj);
                        break;
                    case Operation.DodajRadnika:
                        Controller.Instance.KreirajRadnika((Radnik)request.RequestObj);
                        break;
                    case Operation.UcitajSveGradove:
                        response.ResponseObj = Controller.Instance.UcitajSveGradove();
                        break;
                    case Operation.UcitajSveRadnike:
                        response.ResponseObj = Controller.Instance.UcitajSveRadnike();
                        break;
                    case Operation.PretraziRadnike:
                        Radnik r = (Radnik)request.RequestObj;
                        string criteria = $"Ime= '{r.Ime}'";
                        response.ResponseObj = Controller.Instance.PretraziRadnike(r, criteria);
                        break;
                    case Operation.ObrisiRadnika:
                        Controller.Instance.ObrisiRadnika((Radnik)request.RequestObj);
                        break;
                    case Operation.IzmeniRadnika:
                        Controller.Instance.IzmenaRadnika((Radnik)request.RequestObj);
                        break;
                    case Operation.KreirajDekoraciju:
                        Controller.Instance.KreirajDekoraciju((Dekoracija)request.RequestObj);
                        break;
                    case Operation.UcitajSveDekoracije:
                        response.ResponseObj = Controller.Instance.UcitajSveDekoracije();
                        break;
                    case Operation.IzmeniDekoraciju:
                       Controller.Instance.IzmenaDekoracije((Dekoracija)request.RequestObj);
                        break;
                    case Operation.PretraziDekoracije:
                        Dekoracija d = (Dekoracija)request.RequestObj;
                        string parametri = $"Kategorija= {(int)d.Kategorija}";
                        response.ResponseObj = Controller.Instance.PretraziDekoracije(d, parametri);
                        break;
                    case Operation.ObrisiDekoraciju:
                        Controller.Instance.ObrisiDekoraciju((Dekoracija)request.RequestObj);
                        break;
                    case Operation.UcitajSveStavkeCenovnika:
                        response.ResponseObj = Controller.Instance.UcitajSveStavkeCenovnika();
                        break;
                    case Operation.UcitajSveLokale:
                        response.ResponseObj = Controller.Instance.UcitajSveLokale();
                        break;
                    case Operation.SacuvajAngazovanje:
                        Controller.Instance.KreirajAngazovanje((Angazovanje)request.RequestObj);
                        break;
                    case Operation.UcitajSvaAngazovanja:
                        response.ResponseObj = Controller.Instance.UcitajSvaAngazovanja();
                        break;
                    case Operation.PretraziAngazovanja:
                        response.ResponseObj = Controller.Instance.PretraziAngazovanja((Radnik)request.RequestObj);
                        break;
                    case Operation.UcitajSveStavkeAngazovanja:
                        response.ResponseObj = Controller.Instance.UcitajSveStavkeAngazovanja((Angazovanje)request.RequestObj);
                        break;
                    case Operation.IzmeniAngazovanje:
                        Controller.Instance.IzmeniAngazovanje((Angazovanje)request.RequestObj);
                        break;

                    default:break;

                }
              
            }
           
            catch (Exception ex)
            {

                Console.WriteLine("greska je u handle req"+ex.Message+ex.StackTrace);
            }
            return response;
        }
    }
}
