// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurementBackEnd
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Receiver receive = new Receiver();
            receive.Receive();
            BuildWebHost(args).Run();


        }

        /// <summary>
        /// Builds the web host.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}

        /// <summary>
        /// Sends the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        //public void Send(double value)
        //{
            
        //    MessageQueue New_Queue = null;
        //    try
        //    {
        //        if (MessageQueue.Exists(@".\Private$\New_Queue"))
        //        {
        //            New_Queue = new MessageQueue(@".\Private$\New_Queue");
        //        }
        //        else
        //        {
        //            New_Queue = MessageQueue.Create(@".\Private$\New_Queue");
        //        }

        //       // New_Queue.Label = "This is the test Queue";
        //        New_Queue.Send(value, "Message send");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
           
        //}
        
        //public static void Receive()
        //{
            
        //    MessageQueue New_Queue = null;
        //   // List<string> msmqReceive = new List<string>();
        //    try
        //    {
        //        New_Queue = new MessageQueue(@".\Private$\New_Queue");
        //        Message[] messages = New_Queue.GetAllMessages();
              
        //        // 
        //        if (messages.Length > 0)
        //        {
        //            foreach (Message m in messages)
        //            {
        //                m.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
        //                 string message = m.Body.ToString();
                        
                        
        //                //Console.WriteLine(message);
        //                // msmqReceive.Add(m.Body.ToString());

        //                New_Queue.Receive();
        //                File.WriteAllText(@"C:\Users\Neelabh\source\repos\QuantityMeasurementBackEnd\QuantityMeasurementBackEnd\MessageQueue.txt", message);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("No New Messages in Message Queue");
        //        }

        //        New_Queue.Refresh();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    //finally
        //    //{
        //        //File.WriteAllLines(, msmqReceive);
        //        //TextWriter tw = new StreamWriter(@"C:\Users\Neelabh\source\repos\QuantityMeasurementBackEnd\QuantityMeasurementBackEnd\MessageQueue.txt");

        //        //foreach (String s in msmqReceive)
        //        //    tw.WriteLine(s);

        //        //tw.Close();
        //       // New_Queue.Close();
        //    //}

    //    //}
    //}

//}
//}
