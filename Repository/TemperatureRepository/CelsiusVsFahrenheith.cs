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
        /// <summary>
        /// Converteds the farhenheith to celsius.
        /// </summary>
        /// <param name="F_value">The f value.</param>
        /// <returns></returns>
        public double Converted_FarhenheithToCelsius(double F_value)
        {            
            return (F_value - 32) / 1.8000;               
        }

        /// <summary>
        /// Converteds the celsius to fahrenheith.
        /// </summary>
        /// <param name="C_value">The c value.</param>
        /// <returns></returns>
        public double Converted_CelsiusToFahrenheith(double C_value)
        {
            return C_value * 9 / 5 + 32 ;
           
        }
    }
}
