// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeightManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------
using Repository.WeightRepository;

namespace Manager.WeightManager
{
    /// <summary>
    /// Weight Manager class implementation
    /// </summary>
    /// <seealso cref="Manager.WeightManager.IWeightManager" />
    public class WeightManager: IWeightManager
    {
        /// <summary>
        /// The repo
        /// </summary>
        public readonly IKilogramVsGram repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightManager"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public WeightManager(IKilogramVsGram repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Converteds the gram to kilogram.
        /// </summary>
        /// <param name="G_value">The g value.</param>
        /// <returns></returns>
        public double Converted_GramToKilogram(double G_value)
        {
           return repo.Converted_GramToKilogram(G_value);
        }

        /// <summary>
        /// Converteds the kilogram to gram.
        /// </summary>
        /// <param name="KG_value">The kg value.</param>
        /// <returns></returns>
        public double Converted_KilogramToGram(double KG_value)
        {
            return repo.Converted_KilogramToGram(KG_value);
        }
    }
}
