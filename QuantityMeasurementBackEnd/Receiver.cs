// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Receiver.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurementBackEnd
{
    using System;
    using System.Collections.Generic;
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

            MessageQueue Msmq = new MessageQueue(@".\Private$\Msmq");
            List<string> msmqReceive = new List<string>();
            try
            {
                Message[] Messages = Msmq.GetAllMessages();
               
                if (Messages.Length > 0)
                {
                    foreach (Message msg in Messages)
                    {
                         msg.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });                      
                         string Result = msg.Body.ToString();
                         Msmq.Receive();
                         msmqReceive.Add(Result);
                         Msmq.Refresh();
                    }                    
                }
                else
                {
                    Console.WriteLine("No New Messages in Message Queue");
                }               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {                
                TextWriter tw = new StreamWriter(@"C:\Users\Neelabh\source\repos\QuantityMeasurementBackEnd\QuantityMeasurementBackEnd\MessageQueue.txt");

                foreach (String s in msmqReceive)
                tw.WriteLine(s);

                tw.Close();
                Msmq.Close();
            }

        }
    }
}
