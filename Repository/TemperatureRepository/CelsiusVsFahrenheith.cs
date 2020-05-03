// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CelsiusVsFahrenheith.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.TemperatureRepository
{
    /// <summary>
    /// CelsiusToFahrenheith class
    /// </summary>
    public class CelsiusVsFahrenheith: ICelsiusVsFahrenheith
    {

        RedisCache RedisCache = new RedisCache();
        /// <summary>
        /// Converteds the farhenheith to celsius.
        /// </summary>
        /// <param name="F_value">The f value.</param>
        /// <returns></returns>
        public double Converted_FarhenheithToCelsius(double F_value)
        {     
            
            double result= (F_value - 32) / 1.8000;
            RedisCache.RedisConnection("FarhenheithToCelsius " + F_value.ToString(), "Celsius " + result.ToString());
            return result;

        }

        /// <summary>
        /// Converteds the celsius to fahrenheith.
        /// </summary>
        /// <param name="C_value">The c value.</param>
        /// <returns></returns>
        public double Converted_CelsiusToFahrenheith(double C_value)
        {
            double result= C_value * 9 / 5 + 32 ;
            RedisCache.RedisConnection("CelsiusToFahrenheith " + C_value.ToString(), "Fahrenheith " + result.ToString());
            return result;

        }
    }
}
