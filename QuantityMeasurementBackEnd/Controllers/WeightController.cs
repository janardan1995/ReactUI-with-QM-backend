// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeightController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------


namespace QuantityMeasurementBackEnd.Controllers
{
    using Manager.WeightManager;    
    using Microsoft.AspNetCore.Mvc;
    using Repository;

    /// <summary>
    /// Weight Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly IWeightManager manager;
        readonly RedisCacheSevcice redis = new RedisCacheSevcice();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public WeightController(IWeightManager manager)
        {
            this.manager = manager;
        }

        readonly Sender Msmq = new Sender();
        /// <summary>
        /// Converteds the kilogram to gram.
        /// </summary>
        /// <param name="KG_value">The kg value.</param>
        /// <returns></returns>
        [Route("api/Converted_KilogramToGram")]
        [HttpGet]
        public ActionResult<double> Converted_KilogramToGram(double KG_value)
        {
            double result= manager.Converted_KilogramToGram(KG_value);
            Msmq.Send(result);
            return result;
        }

        /// <summary>
        /// Converteds the gram to kilogram.
        /// </summary>
        /// <param name="G_value">The g value.</param>
        /// <returns></returns>
        [Route("api/Converted_GramToKilogram")]
        [HttpGet]
        public ActionResult<double> Converted_GramToKilogram(double G_value)
        {
            double result= manager.Converted_GramToKilogram(G_value);
            Msmq.Send(result);
            return result;
        }

      //  
        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        /// 

        [Route("api/redis")]
        [HttpGet]
        public string get(string key)
        {
            return redis.RedisConnectionGetValue(key);
        }
    }
}