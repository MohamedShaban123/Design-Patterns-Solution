using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Task task1 = Task.Run(() =>
            {
                Counter obj1 = Counter.Instance;
                Console.WriteLine(obj1.getCount());
            });


            Task task2 = Task.Run(() =>
            {
                Counter obj2 = Counter.Instance;
                Console.WriteLine(obj2.getCount());
            });
           await Task.WhenAll(task1, task2);

        }
    }
}
