// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

using Repository.TemperatureRepository;

namespace Manager.TemperatureManager
{
    /// <summary>
    /// manager of temperature class
    /// </summary>
    /// <seealso cref="Manager.TemperatureManager.ITemperatureManager" />
    public class TemperatureManager : ITemperatureManager
    {
        /// <summary>
        /// The repo
        /// </summary>
        public readonly ICelsiusVsFahrenheith repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureManager"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public TemperatureManager(ICelsiusVsFahrenheith repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Converteds the celsius to fahrenheith.
        /// </summary>
        /// <param name="C_value">The c value.</param>
        /// <returns></returns>
        public double Converted_CelsiusToFahrenheith(double C_value)
        {
            return repo.Converted_CelsiusToFahrenheith(C_value);
        }

        /// <summary>
        /// Converteds the farhenheith to celsius.
        /// </summary>
        /// <param name="F_value">The f value.</param>
        /// <returns></returns>
        public double Converted_FarhenheithToCelsius(double F_value)
        {
            return this.repo.Converted_FarhenheithToCelsius(F_value);
        }
    }
}
