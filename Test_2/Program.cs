namespace Example1
{

    class A
    {
        protected int x = 123;
    }

    class D : A { }

    class C : B { }

    class B : A
    {
        public int GetX() { return x; }

        public static void Uruchom()
        {
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();

            //jaki kod

        }

        public void Test()
        {
            //...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B.Uruchom();
            
        }
    }
}