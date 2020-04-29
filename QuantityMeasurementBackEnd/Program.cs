using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;
using Google.Protobuf.Collections;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace QuantityMeasurementBackEnd
{
    [Serializable]
    public class Program
    {        

        public static void Main(string[] args)
        {
            Receive();
            BuildWebHost(args).Run();          
        

        }
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();


        /// <summary>
        /// Sends the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Send(double value)
        {
            
            MessageQueue New_Queue = null;
            try
            {
                if (MessageQueue.Exists(@".\Private$\msmq"))
                {
                    New_Queue = new MessageQueue(@".\Private$\msmq");
                }
                else
                {
                    New_Queue = MessageQueue.Create(@".\Private$\msmq");
                }

               // New_Queue.Label = "This is the test Queue";
                New_Queue.Send(value, "Message send");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        
        public static void Receive()
        {
            
            MessageQueue New_Queue = null;
            List<string> msmqReceive = new List<string>();
            try
            {
                New_Queue = new MessageQueue(@".\Private$\New_Queue");
                Message[] messages = New_Queue.GetAllMessages();
              
                // 
                if (messages.Length > 0)
                {
                    foreach (Message m in messages)
                    {
                        m.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                         string message = m.Body.ToString();
                        File.WriteAllText(@"C:\Users\Neelabh\source\repos\QuantityMeasurementBackEnd\QuantityMeasurementBackEnd\MessageQueue.txt", message);
                        
                        //Console.WriteLine(message);
                        // msmqReceive.Add(m.Body.ToString());

                        New_Queue.Receive();
                    }
                }
                else
                {
                    Console.WriteLine("No New Messages in Message Queue");
                }

                New_Queue.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //File.WriteAllLines(, msmqReceive);
                //TextWriter tw = new StreamWriter(@"C:\Users\Neelabh\source\repos\QuantityMeasurementBackEnd\QuantityMeasurementBackEnd\MessageQueue.txt");

                //foreach (String s in msmqReceive)
                //    tw.WriteLine(s);

                //tw.Close();
                New_Queue.Close();
            }

        }
    }

}
//}
