


    public interface IInterface1
    {
        void Method1();
    }

    public interface IInterface2
    {
        void Method2();
    }

    public delegate void ComboDelegate();

    public class X : IInterface2, IInterface1
    {
        public event ComboDelegate Event;

        public X()
        {
            Event += new ComboDelegate(Method1);
            Event += new ComboDelegate(Method2);
        }

        void IInterface1.Method1()
        {
            Method1();
        }

        void IInterface2.Method2()
        {
            Method2();
        }

        private void Method1()
        {
            Console.WriteLine("... Method1");
        }


        private void Method2()
        {
            Console.WriteLine("Method2 activate");
        }

    public void ExeDelegate()
    {
        Event?.Invoke();
    }
}

class Program
{
    static void Main(string[] args)
    {
        X x = new X();
        x.ExeDelegate();
    }
}

