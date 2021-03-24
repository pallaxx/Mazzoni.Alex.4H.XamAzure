using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Mazzoni.Alex._4H.XamAzure.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Mazzoni.Alex._4H.XamAzure
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List<Studente> elenco = new List<Studente>();

            try
            {
                HttpClient client = new HttpClient();
                //string response = await client.GetStringAsync("https://flr.azurewebsites.net/studenti");
                string response = await client.GetStringAsync("https://mazzoni-alex-4h-xamazureapi.conveyor.cloud/Studenti");
                elenco = JsonConvert.DeserializeObject<List<Studente>>(response);
            }
            catch (Exception err)
            {
                await DisplayAlert("Ocio!!", err.Message, "Ok");
            }
            
            //elenco.Add(new Studente { Nome = "Maurizio", Cognome = "Conti" });
            //elenco.Add(new Studente { Nome = "Fabio", Cognome = "Corbelli" });
            //elenco.Add(new Studente { Nome = "Alex", Cognome = "Mazzoni" });

            lvStudenti.ItemsSource = elenco;
        }
    }
}