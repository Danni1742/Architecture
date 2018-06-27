using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;
using System.ServiceModel;
using WishListComponent;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MyWish)))
            {
                //Path of the Queue. Here we are creating a private queue with the name VishalQ 
                //where all our message would be stored, if server is unavialable.
                string myQueue = ".\\private$\\MobileTest";
                //Checking whether the queue exists or not.
                if (!MessageQueue.Exists(myQueue))
                {
                    //If the queue doesnot exists it will create a queue with the name VishalQ
                    //the second parameter false denotes that the queue would be a non transaction queue. If you want that your queue to be 
                    //transaction then make the second parameter to true.
                    MessageQueue.Create(myQueue, false);
                }
                //finally opening the host to server the clients.
                host.Open();
                Console.WriteLine("Server is up and running on port 32578");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}