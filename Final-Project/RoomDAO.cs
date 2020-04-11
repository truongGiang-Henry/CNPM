using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class RoomDAO
    {
        private String id;
        private Decimal price;
        private int numberOfPeople;
        private String description;

        public RoomDAO()
        {

        }

        public RoomDAO(string id, Decimal price, int numberOfPeople, string description)
        {
            this.id = id;
            this.price = price;
            this.numberOfPeople = numberOfPeople;
            this.description = description;
        }

        // get set method
        public String Id { get; set; }
        public Decimal Price { get; set; }
        public int NumberOfPeople { get; set; }
        public String Description { get; set; }
        
    }
}
