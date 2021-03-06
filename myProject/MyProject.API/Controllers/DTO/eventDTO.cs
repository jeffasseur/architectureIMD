using System;
using MyProject.API.Domain;



namespace MyProject.API.Controllers
{
    public class CreateEvent
    {


        public string eventTitle { get; set; }

        public DateTime eventDate { get; set; }

        public string eventDescription { get; set; }

        public int eventAge { get; set; }

        public string[] eventParticpants { get; set; }



        public Event ToEvent() => new Event(Guid.NewGuid(), eventTitle, eventDate, eventDescription, eventAge, eventParticpants);



    }
}