using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

namespace _0505AulaAzure
{
    public class Fila
    {
        public void CreateQueueClient(string queueName)
        {
            string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

            QueueClient queueClient = new QueueClient(connectionString, queueName);
        }

        public bool CreateQueue(string queueName)
        {
            string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            queueClient.CreateIfNotExists();

            if (queueClient.Exists())
            {
                Console.WriteLine("Fila Criada:" + queueName);
            }

            return true;
        }

        public void InsertMessage(string queueName, string message)
        {
            string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            queueClient.CreateIfNotExists();

            if (queueClient.Exists())
                queueClient.SendMessage(message);

            Console.WriteLine("Mensagem Inserida: " + message);
        }

        public void DequeueMessage(string queueName)
        {
            string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            if (queueClient.Exists())
            {
                QueueMessage[] retrievedMessage = queueClient.ReceiveMessages();

                Console.WriteLine("Retirado da Fila:" + retrievedMessage[0].Body);

                queueClient.DeleteMessage(retrievedMessage[0].MessageId, retrievedMessage[0].PopReceipt);

            }
        }

        public void UpdateMessage(string queueName)
        {
            string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            if (queueClient.Exists())
            {
                QueueMessage[] message = queueClient.ReceiveMessages();

                queueClient.UpdateMessage(message[0].MessageId, message[0].PopReceipt, "Atualizando2", TimeSpan.FromSeconds(5.0));
            }
        }

    }
}
