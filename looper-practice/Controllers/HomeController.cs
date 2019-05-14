using looper_practice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace looper_practice.Controllers
{
    public class HomeController : Controller
    {
        Person person = new Person();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Person()
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "https://swapi.co/api/people/4/");
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            Console.WriteLine(responseFromServer);
            person = JsonConvert.DeserializeObject<Person>(responseFromServer);
            //There are four arrays in "Person," check to make sure calling their values does
            //not result in "IndexOutOfRangeException"
            person = arrayCheck(person);
            // Clean up the streams and the response.  
            reader.Close();
            response.Close();
            return View(person);
        }
        
        public Person arrayCheck(Person person)
        {
            if (person.films.Length == 0)
            {
                person.films = new string[1];
                person.films[0] = "N/A";
            }
            if (person.species.Length == 0)
            {
                person.species = new string[1];
                person.species[0] = "N/A";
            }
            if (person.starships.Length == 0)
            {
                person.starships = new string[1];
                person.starships[0] = "N/A";
            }
            if (person.vehicles.Length == 0)
            {
                person.vehicles = new string[1];
                person.vehicles[0] = "N/A";
            }
            return person;
        }
    }
}