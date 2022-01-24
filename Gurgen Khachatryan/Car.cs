using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurgen_Khachatryan
{
    class Car
    {
        string model;
        string color;
        int price;

        public string Model { set { model = value; } get { return model; } }
        public string Color { set { color = value; } get { return color; } }
        public int Price { set { price = value; } get { return price; } }
        public Car()
        {

        }
        public Car(string model, string color, int price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }
    }
}
