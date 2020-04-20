// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KilogramToGram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.WeightRepository
{
    /// <summary>
    /// KilogramToGram class
    /// </summary>
    public class KilogramVsGram: IKilogramVsGram
    {
        /// <summary>
        /// Converteds the gram to kilogram.
        /// </summary>
        /// <param name="G_value">The g value.</param>
        /// <returns></returns>
        public double Converted_GramToKilogram(double G_value)
        {
            return G_value / 1000;
        }

        /// <summary>
        /// Converteds the kilogram to gram.
        /// </summary>
        /// <param name="KG_value">The kg value.</param>
        /// <returns></returns>
        public double Converted_KilogramToGram(double KG_value)
        {
            return KG_value * 1000;
        }
    }
}
