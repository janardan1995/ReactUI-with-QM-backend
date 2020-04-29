// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// -------------------------------------------------------------------------------------------------------------------- 
using Manager.TemperatureManager;
using Microsoft.AspNetCore.Mvc;

namespace QuantityMeasurementBackEnd.Controllers
{
    /// <summary>
    /// TEmperature controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly ITemperatureManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public TemperatureController(ITemperatureManager manager)
        {
            this.manager = manager;
        }

        Program New_Queue = new Program();

        /// <summary>
        /// Converteds the farhenheith to celsius.
        /// </summary>
        /// <param name="F_value">The f value.</param>
        /// <returns></returns>
        [Route("api/Converted_FarhenheithToCelsius")]
        [HttpGet]
        public ActionResult<double> Converted_FarhenheithToCelsius(double F_value)
        {
            var result= manager.Converted_FarhenheithToCelsius(F_value);
            New_Queue.Send(result);
            return result;
        }

        /// <summary>
        /// Converteds the celsius to fahrenheith.
        /// </summary>
        /// <param name="C_value">The c value.</param>
        /// <returns></returns>
        [Route("api/Converted_CelsiusToFahrenheith")]
        [HttpGet]
        public ActionResult<double> Converted_CelsiusToFahrenheith(double C_value)
        {
            var result= manager.Converted_CelsiusToFahrenheith(C_value);
            New_Queue.Send(result);
            return result;
        }


    }
}