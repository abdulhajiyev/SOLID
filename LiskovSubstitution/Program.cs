using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // Bad Example

    public abstract class BasePrint
    {
        public abstract void Print();
        public abstract void Scan();
    }

    public class HpPrinter : BasePrint
    {
        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Scan()
        {
            throw new NotImplementedException();
        }
    }

    public class CanonPrinter : BasePrint
    {
        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
