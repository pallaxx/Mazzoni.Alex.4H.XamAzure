using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzoni.Alex._4H.XamAzure.Models
{
    public class Studente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string NomeCognome 
        {
            get
            {
                return $"{Nome} {Cognome}";
            }
        }

        public string Dettagli { get; set; }

        public string Immagine { get; set; }
        public string URLImmagine 
        { 
            get 
            {
            return @"https://mazzoni-alex-4h-xamazureapi.conveyor.cloud/Images/"+Immagine;
            } 
        }
    }
}
