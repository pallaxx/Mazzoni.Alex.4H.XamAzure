using Mazzoni.Alex._4H.XamAzure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mazzoni.Alex._4H.XamAzureAPI.Controllers
{   //Decoratore
    [ApiController]
    [Route("[controller]")]
    public class StudentiController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Studente> Get()
        {
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente { Nome = "Maurizio", Cognome = "Conti", Immagine = "mconti.png", Dettagli="Custode dei luoghi e delle chiavi di Hogwards" });
            studenti.Add(new Studente { Nome = "Fabio", Cognome = "Corbelli", Immagine = "fcorbelli.jpg", Dettagli="Grande vecchio" });
            studenti.Add(new Studente { Nome="Alex", Cognome="Mazzoni", Immagine="alex.mazzoni.Jpeg"});
            studenti.Add(new Studente { Nome="Mattia", Cognome="Bertozzi", Immagine="mattia.bertozzi.Jpeg"});

            return studenti;
        }
    }
}
