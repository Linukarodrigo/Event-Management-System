using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal class Event
    {
        private int eventID;
        private string eventName;
        private string eventDescription;
        private string eventVenue;
        private int organizerID;
        private string organizerName;
        private int maxParticipants;
        private DateTime eventDate;

        //Constructor
        public Event(int eventID, string eventName, string eventDescription, string eventVenue, int organizerID, string organizerName, int maxParticipants, DateTime eventDate)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.eventDescription = eventDescription;
            this.eventVenue = eventVenue;
            this.organizerID = organizerID;
            this.organizerName = organizerName;
            this.maxParticipants = maxParticipants;
            this.eventDate = eventDate;          
        }

        //Getters and setters
        public int GetEventID()
        {
            return eventID;
        }

        public void SetEventID(int eventID)
        {
            this.eventID = eventID;
        }

        public string GetEventName()
        {
            return eventName;
        }

        public void SetEventName(string eventName)
        {
            this.eventName = eventName;
        }
        public string GetEventDescription()
        {
            return eventDescription;
        }

        public void SetEventDescription(string eventDescription)
        {
            this.eventDescription = eventDescription;
        }

        public string GetEventVenue()
        {
            return eventVenue;
        }

        public void SetEventVenue(string eventVenue)
        {
            this.eventVenue= eventVenue;         
        }

        public int GetOrganizerID()
        {
            return organizerID;
        }

        public void SetOrganizerID(int organizerID)
        {
            this.organizerID = organizerID;
        }
        public string GetOrganizerName()
        {
            return organizerName;
        }

        public void SetOrganizerName(string organizerName)
        {
            this.organizerName = organizerName;
        }

        public int GetMaxParticipants()
        {
            return maxParticipants;
        }

        public void SetMaxParticipants(int maxParticipants)
        {
            this.maxParticipants = maxParticipants;
        }

        public DateTime GetEventDate()
        {
            return eventDate;
        }

        public void SetEventDate(DateTime eventDate)
        {
            this.eventDate = eventDate;
        }




    }


}
