namespace exam
{
    using System;
    using System.Collections.Generic;

    public class Flight
    {
        public string start, dest;
        public int price, previous;
        public Flight(string start, string dest, int price)
        {
            this.start = start;
            this.dest = dest;
            this.price = price;
        }

        public override string ToString()
        {
            return this.start + " " + this.dest + " " + this.price;
        }
    }

    public class Flights
    {
        private int count, result;
        List<Flight> flights = new List<Flight>();
        List<Flight> route = new List<Flight>();
        List<Flight> prev = new List<Flight>();

        public string departure, destination;


        public Flights()
        {
            this.count = 0;
        }


        public void AddConnection(string departure, string destination, int price)
        {
            this.flights.Add(new Flight(departure, destination, price));
            this.count++;
        }

        public int Search(string start, int ii)
        {
            if (flights[ii].dest == destination)
            {
                if (route.Count < prev.Count) prev = route;
                return route.Count;
            }
            for (int i = ii; i < count; i++)
            {
                if (flights[i].start == start)
                {
                    result = Search(flights[i].dest, i);

                }
            }
            return result;
        }

        public int RoutePrice(string departure, string destination)
        {
            this.departure = departure;
            this.destination = destination;
            prev = flights;
            for (int i = 0; i < count; i++)
            {
                if (flights[i].start == departure)
                {
                    if (flights[i].dest == destination)
                    {
                        if (route.Count < prev.Count) prev = route;
                        break;
                    }
                    route.Add(flights[i]);
                    result = Search(flights[i].dest, i);
                }
            }
            return prev.Count;
        }


        public override string ToString()
        {
            string result = "";
            foreach (Flight item in flights)
            {
                result += item.ToString();
                result += "\n";
            }
            return result;
        }

    }
}
