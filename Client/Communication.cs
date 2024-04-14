using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal class Communication
    {
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        private Socket soket;
        Sender sender;
        Receiver receiver;


       public void Connect()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("localhost", 9000);
                sender = new Sender(soket);
                receiver = new Receiver(soket);
                System.Windows.Forms.MessageBox.Show("Klijent je povezan");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska kod klijenta"+ex.Message);
            }
        }

        public void ExceptionHandler(Response response)
        {
            if (response.Message != null)
            {
                System.Windows.Forms.MessageBox.Show("Sistem nije uspeo da izvrsi operaciju!"+response.Message);
            }
        }

        internal Korisnik Prijava(Korisnik k)
        {
            Request request = new Request();
            request.Operation = Operation.Prijava;
            request.RequestObj = k;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
            return (Korisnik)response.ResponseObj;
            

        }

        internal void DodajRadnika(Domain.Radnik radnik)
        {
            Request request = new Request();
            request.Operation = Operation.DodajRadnika;
            request.RequestObj = radnik;

            sender.Send(request);
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal List<Grad> VratiSveGradove()
        {
            Request req = new Request();
            req.Operation = Operation.UcitajSveGradove;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Grad>)res.ResponseObj;
        }

        internal object UcitajSveRadnike()
        {

            Request req = new Request();
            req.Operation = Operation.UcitajSveRadnike;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Radnik>)res.ResponseObj;
        }


        internal List<Domain.Radnik> Pretrazi(Domain.Radnik r)
        {

            Request req = new Request();
            req.Operation = Operation.PretraziRadnike;
            req.RequestObj = r;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Radnik>)res.ResponseObj;
        }

        internal void ObrisiRadnika(Domain.Radnik r)
        {
            Request req = new Request();
            req.Operation = Operation.ObrisiRadnika;
            req.RequestObj = r;

            sender.Send(req);
        
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal void IzmeniRadnika(Domain.Radnik zaIzmenu)
        {
            Request req = new Request();
            req.Operation = Operation.IzmeniRadnika;
            req.RequestObj = zaIzmenu;

            sender.Send(req);
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }
        internal void DodajDekoraciju(Domain.Dekoracija dekoracija)
        {
            Request request = new Request();
            request.Operation = Operation.KreirajDekoraciju;
            request.RequestObj = dekoracija;

            sender.Send(request);
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal List<Domain.Dekoracija> UcitajSveDekoracije()
        {
            Request req = new Request();
            req.Operation = Operation.UcitajSveDekoracije;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Dekoracija>)res.ResponseObj;
        }

        internal void ObrisiDekoraciju(Domain.Dekoracija d)
        {
            Request req = new Request();
            req.Operation = Operation.ObrisiDekoraciju;
            req.RequestObj = d;

            sender.Send(req);

            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal List<Domain.Dekoracija> PretraziDekoracije(Domain.Dekoracija d)
        {
            Request req = new Request();
            req.Operation = Operation.PretraziDekoracije;
            req.RequestObj = d;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Dekoracija>)res.ResponseObj;
        }

        internal void IzmeniDekoraciju(Domain.Dekoracija zaIzmenu)
        {
            Request req = new Request();
            req.Operation = Operation.IzmeniDekoraciju;
            req.RequestObj = zaIzmenu;

            sender.Send(req);
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal List<StavkaCenovnika> UcitajSveStavkeCenovnika()
        {
            Request req = new Request();
            req.Operation = Operation.UcitajSveStavkeCenovnika;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.StavkaCenovnika>)res.ResponseObj;
        }

        internal object UcitajSveLokale()
        {

            Request req = new Request();
            req.Operation = Operation.UcitajSveLokale;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Lokal>)res.ResponseObj;
        }

        internal void SacuvajAngazovanje(Angazovanje angazovanje)
        {
            Request request = new Request();
            request.Operation = Operation.SacuvajAngazovanje;
            request.RequestObj = angazovanje;
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal object UcitajSvaAngazovanja()
        {
            Request req = new Request();
            req.Operation = Operation.UcitajSvaAngazovanja;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Angazovanje>)res.ResponseObj;
        }

        internal List<Angazovanje> PretraziAngazovanja(string imeRadnika)
        {
            Request req = new Request();
            req.Operation = Operation.PretraziAngazovanja;
            req.RequestObj = new Domain.Radnik {Ime=imeRadnika};
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Angazovanje>)res.ResponseObj;
        }

        internal List<StavkaAngazovanja> UcitajSveStavkeAngazovanja(Angazovanje a)
        {
            Request req = new Request();
            req.Operation = Operation.UcitajSveStavkeAngazovanja;
            req.RequestObj = a;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.StavkaAngazovanja>)res.ResponseObj;
        }

        internal void IzmeniAngazovanje(Angazovanje novoAng)
        {
            Request req = new Request();
            req.Operation = Operation.IzmeniAngazovanje;
            req.RequestObj = novoAng;

            sender.Send(req);
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }
    }
}
