using Builder.After;
using Builder.Before;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before

            ////The problem: If Car has many properties(20 +), the constructor becomes hard to use and read.
            //var car = new Car("V8",4,"Red");// hard to remember parameter order!
            #endregion

            #region After
            //var car = new CarBuilder().SetEngine("V8").SetWheels(4).SetColor("Red").Build();
            //Console.WriteLine(car);
            #endregion
        }
    }
}
