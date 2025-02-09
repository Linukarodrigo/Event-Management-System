using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal class Booking
    {
        private int eventID;
        private string eventName;
        private int participantID;
        private string participantName;
        private string organizerName;
        private DateTime eventDate;
        private DateTime bookingDate;

        //Constructor
        public Booking(int eventID, string eventName, int participantID, string participantName, DateTime eventDate, DateTime bookingDate)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.participantID = participantID;
            this.participantName = participantName;
            this.eventDate = eventDate;
            this.bookingDate = bookingDate;

        }

        public Booking(int eventID, string eventName, string organizerName, int participantID, string participantName, DateTime eventDate, DateTime bookingDate)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.participantID = participantID;
            this.participantName = participantName;
            this.organizerName = organizerName;
            this.eventDate = eventDate;
            this.bookingDate = bookingDate;

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

        public int GetParticipantID()
        {
            return participantID;
        }

        public void SetParticipantID(int participantID)
        {
            this.participantID = participantID;
        }
        public string GetParticipantName()
        {
            return participantName;
        }

        public void SetParticipantName(string participantName)
        {
            this.participantName = participantName;
        }

        public string GetOrganizerName()
        {
            return organizerName;
        }

        public void SetOrganizerName(string organizerName)
        {
            this.organizerName = organizerName;
        }



        public DateTime GetEventDate()
        {
            return eventDate;
        }

        public void SetEventDate(DateTime eventDate)
        {
            this.eventDate = eventDate;
        }

        public DateTime GetBookingDate()
        {
            return bookingDate;
        }

        public void SetBookingDate(DateTime bookingDate)
        {
            this.bookingDate = bookingDate;
        }
    }
}
