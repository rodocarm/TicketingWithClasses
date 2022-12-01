using System;
using System.Collections.Generic;
using System.Linq;

namespace TicketingSystemWithClasses {
    public class Ticket {
        public UInt64 ticketID { get; set; }
        public string summary {get; set;}
        public string status {get; set;}
        public string priority {get; set;}
        public string submitter {get; set;}
        public string assigned {get; set;}
        public List<string> peopleWatching {get; set;}

        public Ticket()
        {
            peopleWatching = new List<string>();
        }

        public string entry() {
            string peopleWatchingString = "";
            string lastPerson = peopleWatching.LastOrDefault();
            foreach (string person in peopleWatching) {
                if (person.Equals(lastPerson)) {
                    peopleWatchingString += person;
                }
                else {
                    peopleWatchingString += person + "|";
                }
            }
            return $"{ticketID},{summary},{status},{priority},{submitter},{assigned},{peopleWatchingString}";
        }
    }
}