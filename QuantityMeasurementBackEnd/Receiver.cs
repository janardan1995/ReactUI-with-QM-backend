// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Receiver.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurementBackEnd
{
    using System;    
    using System.IO;    
    using Experimental.System.Messaging;

    /// <summary>
    /// Receiver class
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Receives this instance.
        /// </summary>
        public void Receive()
        {            
            MessageQueue Msmq = null;           
            
            try
            {
                Msmq = new MessageQueue(@".\Private$\Msmq");
                Message[] messages = Msmq.GetAllMessages();
               
                if (messages.Length > 0)
                {
                    foreach (Message msg in messages)
                    {
                        msg.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                        string message = msg.Body.ToString();
                        Msmq.Receive();
                        File.WriteAllText(@"C:\Users\Neelabh\source\repos\QuantityMeasurementBackEnd\QuantityMeasurementBackEnd\MessageQueue.txt", message);
                    }
                }
                else
                {
                    Console.WriteLine("No New Messages in Message Queue");
                }

                Msmq.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
