using System;

namespace _01_facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IApi
    {
        void SayHi(string s);
    }
    public class ImplA : IApi
    {
        public void SayHi(string s)
        {
            Console.WriteLine($"ImplA:{ s}");
        }
    }
    public class ImplB : IApi
    {
        public void SayHi(string s)
        {
            Console.WriteLine($"ImplB:{ s}");
        }
    }
    public class Facade
    {

    }
}
