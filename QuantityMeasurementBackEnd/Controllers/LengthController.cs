// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LengthController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------


namespace QuantityMeasurementBackEnd.Controllers
{
    using System;
    using Manager.LengthManager;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    ///  Length Controller class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly ILengthManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public LengthController(ILengthManager manager)
        {
            this.manager = manager;
        }

        readonly Sender Msmq = new Sender();

        /// <summary>
        /// Converteds the feet to yard.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        [Route("api/Converted_FeetToYard")]
        [HttpGet]
        public ActionResult<double> Converted_FeetToYard(double F_Value)
        {
            
            var result= manager.Converted_FeetToYard(F_Value);
            Msmq.Send(result);
            return result;
        }

        /// <summary>
        /// Converteds the yard to feet.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        [Route("api/Converted_YardToFeet")]
        [HttpGet]
        public ActionResult<double> Converted_YardToFeet(double Y_Value)
        {
            var result= manager.Converted_YardToFeet(Y_Value);
            Msmq.Send(result);
            return result;
        }

        /// <summary>
        /// Converteds the yard to inches.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        [Route("api/Converted_YardToInches")]
        [HttpGet]
        public ActionResult<double> Converted_YardToInches(double Y_Value)
        {
            var result = manager.Converted_YardToInches(Y_Value);
            Msmq.Send(result);
            return result ;
        }

       
        /// <summary>
        /// Converteds the inches to yard.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        [Route("api/Converted_InchesToYard")]
        [HttpGet]
        public ActionResult<double> Converted_InchesToYard(double I_Value)
        {
            var result= manager.Converted_InchesToYard(I_Value);
            Msmq.Send(result);
            return result;
        }

        /// <summary>
        /// Converteds the feet to inches.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        [Route("api/Converted_FeetToInches")]
        [HttpGet]
        public ActionResult<double> Converted_FeetToInches(double F_Value)
        {
            var result= manager.Converted_FeetToInches(F_Value);
            Msmq.Send(result);
            return result;
        }

        /// <summary>
        /// Converteds the inches to feet.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        [Route("api/Converted_InchesToFeet")]
        [HttpGet]
        public ActionResult<double> Converted_InchesToFeet(double I_Value)
        {
            var result= manager.Converted_InchesToFeet(I_Value);
            Msmq.Send(result);
            return result;
        }

    }
}