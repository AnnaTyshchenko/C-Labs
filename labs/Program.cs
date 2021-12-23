using System;

namespace pop
{
    class Program
    {

        static void Main(string[] args)
        {

            //Завдання 4 Використовуючи інтерфейси або спадкування реалізуйте еволюцію
           /* SmartPhone phones = new SmartPhone();
               {
                phones.Call();
                phones.Button();
                phones.BlackWhite();
                phones.Color();
                phones.Smart();
               }*/

            //Завдання 5 Створити інтерфейс супергерой, та реалізувати 5 своїх супергероїв створивши їм окремі класи.

            ISuperHero[] heroes = new ISuperHero[]
          {
                new SpiderMan(),
                new Batman(),
                new WonderWoman(),
                new Halk(),
                new IronMan()
          };
            for (int i = 0; i < heroes.Length; i++)
            {
                switch (heroes[i])
                {
                    case SpiderMan spiderMan:
                        spiderMan.ReleaseWeb();
                        break;
                    case WonderWoman woman:
                        woman.Block();
                        break;
                    case Halk halk:
                        halk.Smash();
                        break;
                    case IronMan ironMan:
                        ironMan.Fly();
                        break;
                    default:
                        heroes[i].Breath();
                        break;
                }
            }

        }
        //Завдання 4 Використовуючи інтерфейси або спадкування реалізуйте еволюцію
        class DiskPhone
        {
            public void Call()
            {
                Console.Write("Hello from disk phone!\n");
            }
        }
        class ButtonPhone : DiskPhone
        {
            public void Button()
            {
                Console.WriteLine("Hello from button phone");
            }
        }

        class BlackWhitePhone : ButtonPhone
        {
            public void BlackWhite()
            {
                Console.WriteLine("Hello from Black-White Phone");
            }
        }

        class ColorfullPhone : BlackWhitePhone
        {
            public void Color()
            {
                Console.WriteLine("Hello from Colorfull Phone");
            }
        }

        class SmartPhone : ColorfullPhone
        {
            public void Smart()
            {
                Console.WriteLine("Hello from SmartPhone");
            }
        }
        //Завдання 5 Створити інтерфейс супергерой, та реалізувати 5 своїх супергероїв створивши їм окремі класи.
        public interface ISuperHero
        {
            void Move();

            void Breath();

            void Hit();
        }
        public class SpiderMan : ISuperHero
        {
            public void Breath()
            {
                Console.WriteLine("SpiderMan is breathing!");
            }

            public void Hit()
            {
                Console.WriteLine("SpiderMan is hitting!");
            }

            public void Move()
            {
                Console.WriteLine("SpiderMan is moving!");
            }

            public void ReleaseWeb()
            {
                Console.WriteLine("Releasing web!");
            }

            public void WallWalk()
            {
                Console.WriteLine("Walking on the wall!");
            }
        }

        public class Batman : ISuperHero
        {
            public void Breath()
            {
                Console.WriteLine("Batman is breathing!");
            }

            public void Hit()
            {
                Console.WriteLine("Batman is hitting!");
            }

            public void Move()
            {
                Console.WriteLine("Batman is moving!");
            }
        }

        public class WonderWoman : ISuperHero
        {
            public void Breath()
            {
                Console.WriteLine("WonderWoman is breathing!");
            }

            public void Hit()
            {
                Console.WriteLine("WonderWoman is hitting!");
            }

            public void Move()
            {
                Console.WriteLine("WonderWoman is moving!");
            }

            public void Block()
            {
                Console.WriteLine("WonderWoman is blocking!");
            }
        }

        public class IronMan : ISuperHero
        {
            public void Breath()
            {
                Console.WriteLine("IronMan is breathing!");
            }

            public void Hit()
            {
                Console.WriteLine("IronMan is hitting!");
            }

            public void Move()
            {
                Console.WriteLine("IronMan is moving!");
            }

            public void Fly()
            {
                Console.WriteLine("IronMan is flying!");
            }
        }

        public class Halk : ISuperHero
        {
            public void Breath()
            {
                Console.WriteLine("Halk is breathing!");
            }

            public void Hit()
            {
                Console.WriteLine("Halk is hitting!");
            }

            public void Move()
            {
                Console.WriteLine("Halk is moving!");
            }

            public void Smash()
            {
                Console.WriteLine("Halk smash!");
            }
        }
    }
}