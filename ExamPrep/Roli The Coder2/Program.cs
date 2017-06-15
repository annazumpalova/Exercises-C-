using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var events = new Dictionary<int, Event>();
            const string eventPattern = @"(?<id>\d+)\s#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";
            while (line != "Time for Code")
            {
                var eventDetails = Regex.Match(line, eventPattern);

                if (eventDetails.Success)
                {
                    var id = int.Parse(eventDetails.Groups["id"].Value);
                    var eventName = eventDetails.Groups["eventName"].Value;

                    var participant = new string[0];
                    var eventHasParticipants = line.Contains("@");
                    if (eventHasParticipants)
                    {
                        participant = line.Substring(line.IndexOf('@')).Split();
                    }

                    if (!events.ContainsKey(id))
                    {

                        events[id] = new Event()
                        {
                            Name = eventName,
                            Participants = new List<string>(new string[0])
                        };
                    }
                    if (events[id].Name==eventName)
                    {
                        events[id].Participants.AddRange(participant);
                        events[id].Participants = events[id].Participants.Distinct().ToList();

                    }
                }
                
            line = Console.ReadLine();
        }
            var sortedEvents = events.OrderByDescending(a => a.Value.Participants.Count)
            .ThenBy(a => a.Value.Name).ToArray();

            foreach(var @event in sortedEvents)
            {
                var eventName = @event.Value.Name;
                var sortedparticipants = @event.Value.Participants.Count();
                Console.WriteLine($"{eventName} - {sortedparticipants}");
                var sortedParticipants = @event.Value.Participants.OrderBy(a => a);

                foreach(var item in sortedParticipants)
                {
                    Console.WriteLine(item);
                }
            }

            }
        }
    }

