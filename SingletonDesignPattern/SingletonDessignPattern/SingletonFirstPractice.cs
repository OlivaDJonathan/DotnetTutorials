using System;
namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        //private static Singleton Instance = null;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        //private static readonly object Instancelock = new object();

        /*public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                lock (Instancelock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                } 
            }
            return Instance;
        }
        
        private static readonly Singleton singleInstance = new Singleton();

        public static Singleton GetInstance()
        {
            return singleInstance;
        }*/

        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public static Singleton GetInstance()
        {
            return instance.Value;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}