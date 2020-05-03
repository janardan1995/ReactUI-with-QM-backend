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
        /// The redis cache
        /// </summary>
        RedisCacheSevcice RedisCache = new RedisCacheSevcice();

        /// <summary>
        /// Converteds the gram to kilogram.
        /// </summary>
        /// <param name="G_value">The g value.</param>
        /// <returns></returns>
        public double Converted_GramToKilogram(double G_value)
        {
            double result= G_value / 1000;
            RedisCache.RedisConnectionSetKeyValue("GramToKilogram " + G_value.ToString(), "Kilogram " + result.ToString());
            return result;
        }

        /// <summary>
        /// Converteds the kilogram to gram.
        /// </summary>
        /// <param name="KG_value">The kg value.</param>
        /// <returns></returns>
        public double Converted_KilogramToGram(double KG_value)
        {
            double result= KG_value * 1000;
            RedisCache.RedisConnectionSetKeyValue("KilogramToGram " + KG_value.ToString(), "Gram " + result.ToString());
            return result;
        }
    }
}
