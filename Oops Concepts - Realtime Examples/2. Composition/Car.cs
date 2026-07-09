using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.cs
{
    internal class Car
    {

        private Engine engine = new Engine();

        private Wheels wheels = new Wheels();   

        private Chassis chassis = new Chassis();

        private Seats seats = new Seats();

        public event Action OnCarStart;

        public Car()
        {
            OnCarStart +=engine.StartEngine;
            OnCarStart += wheels.Rotate;
            OnCarStart += chassis.Support;
            OnCarStart += seats.Sit;
        }

        Predicate<int> isEven = delegate (int number)
        {
            return number % 2 == 0;
        };

        Func<int,int> square = x => x * x;

        public delegate int SquareDelegate(int x);

        SquareDelegate _square = x => x * x;

        public delegate int AddDelegate(int x, int y);

        AddDelegate _add = (x, y) => x + y;

        public void StartCar()
        {
            OnCarStart?.Invoke();
            Console.WriteLine("Car has started.");

            Console.WriteLine("Is 4 even? " + isEven(5));

            Console.WriteLine("Square of 5 is: " + square(5));
            
            Console.WriteLine("Square of 6 using delegate: " + _square(6));

            Console.WriteLine("Addition of 3 and 4 using delegate: " + _add(3, 4));


        }
    }
}
