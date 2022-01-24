using System;

namespace Gurgen_Khachatryan
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            foreach (Car item in vehicle)
            {
                Console.WriteLine("Model:"+item.Model+"           Color:"+item.Color+"         Price:"+item.Price);
            }
            vehicle.Reset();
            Console.WriteLine(new string('-',30));
            foreach (Car item in vehicle)
            {
                Console.WriteLine("Model:" + item.Model + "           Color:" + item.Color + "         Price:" + item.Price);
            }
        }
    }
}
