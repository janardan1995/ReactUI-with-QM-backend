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

        RedisCacheSevcice RedisCache = new RedisCacheSevcice();
        /// <summary>
        /// Converteds the farhenheith to celsius.
        /// </summary>
        /// <param name="F_value">The f value.</param>
        /// <returns></returns>
        public double Converted_FarhenheithToCelsius(double F_value)
        {     
            
            double result= (F_value - 32) / 1.8000;
            RedisCache.RedisConnectionSetKeyValue("FarhenheithToCelsius " + F_value.ToString(), "Celsius " + result.ToString());
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
            RedisCache.RedisConnectionSetKeyValue("CelsiusToFahrenheith " + C_value.ToString(), "Fahrenheith " + result.ToString());
            return result;

        }
    }
}
