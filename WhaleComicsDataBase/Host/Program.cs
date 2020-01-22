using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhaleComics;

namespace Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost service = new ServiceHost(typeof(Methods));
            service.Open();
            Console.ReadLine();
        }
    }
}
