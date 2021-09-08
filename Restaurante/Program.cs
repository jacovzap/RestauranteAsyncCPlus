using System;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Restaurant ElBarato = new Restaurant();
            ElBarato.start();
        }
    }
}
