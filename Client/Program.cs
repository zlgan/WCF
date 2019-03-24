using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.wcf1;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFServiceClient svc = new WCFServiceClient();
            Console.WriteLine(svc.GetData(666));

            Console.ReadKey();


        }
    }
}
