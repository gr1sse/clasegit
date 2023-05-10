namespace ConsoleApp1
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = Sum(2, 3);
            string nombrecompleto = Nombre("Sergio", "Dávalos");
        }

        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public string Nombre(string name, string lastname)
        {
            return name + lastname;
        }
    }
}