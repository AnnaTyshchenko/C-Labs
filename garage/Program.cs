using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        class Garage
        {
            private List<Car> _cars = new List<Car>();

            public IReadOnlyList<Car> Cars => _cars;

            public void BuyCar(Car car)
            {
                _cars.Add(car);
            }

            public bool SellCar(Car car)
            {
                return _cars.Remove(car);
            }

            public List<Car> Search(CarSearchParams searchParams)
            {
                var cars = new List<Car>(_cars);

                if (searchParams.Color != Color.Empty)
                {
                    foreach (var car in _cars)
                    {
                        if (car.Color != searchParams.Color)
                        {
                            cars.Remove(car);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(searchParams.Name))
                {
                    foreach (var car in _cars)
                    {
                        if (car.Name != searchParams.Name)
                        {
                            cars.Remove(car);
                        }
                    }
                }

                if (searchParams.Publish != DateTime.MinValue)
                {
                    foreach (var car in _cars)
                    {
                        if (car.Publish != searchParams.Publish)
                        {
                            cars.Remove(car);
                        }
                    }
                }

                if (searchParams.Speed.HasValue)
                {
                    foreach (var car in _cars)
                    {
                        if (car.Speed != searchParams.Speed.Value)
                        {
                            cars.Remove(car);
                        }
                    }
                }

                return cars.ToList();
            }
        }

        class Car
        {
            public Color Color { get; }
            public string Name { get; }
            public double Speed { get; }
            public DateTime Publish { get; }

            public Car(Color color, string name, double speed, DateTime publish)
            {
                Color = color;
                Name = name;
                Speed = speed;
                Publish = publish;
            }

            public override string ToString()
            {
                return $"{Color} Car {Name} with speed {Speed}, that published {Publish.Date.Year}";
            }
        }

        class CarSearchParams
        {
            public Color Color { get; set; }
            public string Name { get; set; }
            public double? Speed { get; set; }
            public DateTime Publish { get; set; }
        }


        public static void Main()
        {
            var garage = new Garage();

            garage.BuyCar(new Car(Color.Red, "BMW", 200, DateTime.Now.AddYears(-10)));
            garage.BuyCar(new Car(Color.Blue, "Lamborgini", 300, DateTime.Now.AddYears(-5)));
            garage.BuyCar(new Car(Color.Magenta, "Audi", 200, DateTime.Now.AddYears(-1)));
            garage.BuyCar(new Car(Color.Red, "Audi", 300, DateTime.Now.AddYears(-1)));

            Console.WriteLine(new string('-', 80));
            foreach (var car in garage.Cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine(new string('-', 80));

            foreach (var car in garage.Search(new CarSearchParams() { Speed = 200, Name = "Audi" }))
            {
                Console.WriteLine(car);
            }
            Console.WriteLine(new string('-', 80));

            foreach (var car in garage.Search(new CarSearchParams() { Color = Color.Red }))
            {
                Console.WriteLine(car);
            }
            Console.WriteLine(new string('-', 80));

            Console.ReadKey();
        }
    }
}