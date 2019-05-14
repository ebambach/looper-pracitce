using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace looper_practice.Models
{
    public class Film
    {
        public string title { get; set; } // The title of this film
        int episode_id { get; set; } // The episode number of this film.
        public string opening_crawl { get; set; } // The opening paragraphs at the beginning of this film.
        public string director { get; set; } // The name of the director of this film.
        public string producer { get; set; } // The name(s) of the producer(s) of this film.Comma separated.
        DateTime release_date { get; set; } // The ISO 8601 date format of film release at original creator country.
        public string[] species { get; set; } // An array of species resource URLs that are in this film.
        public string[] starships { get; set; } // An array of starship resource URLs that are in this film.
        public string[] vehicles { get; set; } // An array of vehicle resource URLs that are in this film.
        public string[] characters { get; set; } // An array of people resource URLs that are in this film.
        public string[] planets { get; set; } // An array of planet resource URLs that are in this film.
        public string url { get; set; } // the hypermedia URL of this resource.
        public string created { get; set; } // the ISO 8601 date format of the time that this resource was created.
        public string edited { get; set; } // the ISO 8601 date format of the time that this resource was edited.
    }
}