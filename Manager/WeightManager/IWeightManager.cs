// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IweightManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager.WeightManager
{
    /// <summary>
    /// intercae of weight manager
    /// </summary>
    public interface IWeightManager
    {
        /// <summary>
        /// Converteds the kilogram to gram.
        /// </summary>
        /// <param name="KG_value">The kg value.</param>
        /// <returns></returns>
        double Converted_KilogramToGram(double KG_value);

        /// <summary>
        /// Converteds the gram to kilogram.
        /// </summary>
        /// <param name="G_value">The g value.</param>
        /// <returns></returns>
        double Converted_GramToKilogram(double G_value);
    }
}
