using System;

namespace _00_simple_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IApi api = new Impl();
            api.SayHi("hi");
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
    public class Factory
    {
        public void CreateApi()
        {

        }
    }
}
