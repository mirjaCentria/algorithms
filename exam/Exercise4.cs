namespace exam
{
    using System;
    using System.Collections.Generic;
 
    public class Flight
    {
        public string start, dest;
        public int price, previous ;
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
        private int infinitely; // = int.MaxValue;


        private int count, result, previous;
        List<Flight> flights = new List<Flight>();
        List<Flight> route= new List<Flight>();
        List<Flight> prev = new List<Flight>();

        public string departure,  destination;

        public Flights()
        {
            this.count = 0;
            this.infinitely = 99999999;
        }


        public void AddConnection(string departure, string destination, int price)
        {
            this.flights.Add(new Flight(departure, destination, price));
            this.count++;
         //   this.flights.Add(new Flight(destination, departure, price));
        }

        public int  Search(string start, int ii)
        {               
            Console.WriteLine("Search " + start + " " + ii);
            if(flights[ii].dest == destination) 
            {
                if(route.Count < prev.Count) prev = route;
                Console.WriteLine("routedd " + flights[ii] + route.Count);
                return route.Count;
            }
            for(int i = ii; i < count; i++)
            {
                if(flights[i].start == start)
                {
                    result = Search(flights[i].dest, i);         
                    
                }
            }
            return result;
        }

        public int RoutePrice(string departure, string destination)        {

            prev = flights;
            for(int i = 0; i < count; i++)
            {   
                    Console.WriteLine("Route " + i );                              

                if(flights[i].start == departure)
                {
                    if(flights[i].dest == destination) 
                    {
                        if(route.Count < prev.Count) prev = route;
                        Console.WriteLine("routecount prevcont " + route.Count + " " + prev.Count);
                        break;
                    }
                    route.Add(flights[i]);
                    Console.WriteLine("routea " + flights[i]  + " " + route.Count);
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