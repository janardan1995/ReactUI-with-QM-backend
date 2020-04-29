// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sender.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurementBackEnd
{
    using System;    
    using Experimental.System.Messaging;

    /// <summary>
    /// Sender class
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Sends the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Send(double value)
        {
            try
            {
                MessageQueue Msmq = null;
                if (MessageQueue.Exists(@".\Private$\Msmq"))
                {
                    Msmq = new MessageQueue(@".\Private$\Msmq");
                }
                else
                {
                    Msmq = MessageQueue.Create(@".\Private$\Msmq");
                }
                Msmq.Send(value.ToString(), "Message send");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
