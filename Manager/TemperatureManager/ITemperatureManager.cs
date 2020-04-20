// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITemperatureManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager.TemperatureManager
{
    /// <summary>
    /// interface class
    /// </summary>
    public interface ITemperatureManager
    {
        /// <summary>
        /// Converteds the farhenheith to celsius.
        /// </summary>
        /// <param name="F_value">The f value.</param>
        /// <returns></returns>
        double Converted_FarhenheithToCelsius(double F_value);

        /// <summary>
        /// Converteds the celsius to fahrenheith.
        /// </summary>
        /// <param name="C_value">The c value.</param>
        /// <returns></returns>
        double Converted_CelsiusToFahrenheith(double C_value);

    }
}
