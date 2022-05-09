using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Queues;
using System.Configuration;
using Azure.Storage.Queues.Models;

namespace _0505AulaAzure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila obj = new Fila();            

            obj.InsertMessage("fila2", "1111");
            obj.InsertMessage("fila2", "2222");
            obj.InsertMessage("fila2", "3333");
            obj.InsertMessage("fila2", "4444");
            obj.InsertMessage("fila2", "5555");

            obj.DequeueMessage("fila2");

            obj.UpdateMessage("fila2");

            Console.ReadKey();
        }

    }
}
