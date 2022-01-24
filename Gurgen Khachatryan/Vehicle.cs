using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurgen_Khachatryan
{
    class Vehicle:IEnumerable,IEnumerator
    {
       Car[] cars = null;
        int index = -1;

        public Vehicle()
        {
            cars = new Car[5];
            Car car1 = new Car("Opel", "blue", 3500);
            Car car2 = new Car("Bmw", "White", 7500);
            Car car3 = new Car("Mercedes", "black", 6900);
            Car car4 = new Car("Toyota", "white", 12500);
            Car car5 = new Car("Nisan", "Orange", 5500);
            cars[0] = car1; cars[1] = car2; cars[2] = car3; cars[3] = car4; cars[4] = car5;
        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }
      

        public object Current
        {
            get
            {
                return cars[index];
            }
        }
        public bool MoveNext()
        {

            if (index < cars.Length - 1)
            {
                index++;
                return true;

            }
            else
            {
                // throw new InvalidOperationException();
                return false;
            }
        }

        public void Reset()
        {
            index = -1;
        }

    }
}
