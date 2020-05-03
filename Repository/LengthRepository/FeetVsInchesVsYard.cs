// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetVsInchesVsYard.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.LengthRepository
{
    /// <summary>
    /// Length Repository
    /// </summary>
    /// <seealso cref="Repository.LengthRepository.IFeetVsInchesVsYard" />
    public class FeetVsInchesVsYard : IFeetVsInchesVsYard
    {
         RedisCache RedisCache = new RedisCache();
        /// <summary>
        /// Converteds the feet to inches.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        public double Converted_FeetToInches(double F_Value)
        {
            double result = F_Value * 12;
            RedisCache.RedisConnection($"Feet" , "Inches "+result.ToString());
            return result;
        }

        /// <summary>
        /// Converteds the inches to feet.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        public double Converted_InchesToFeet(double I_Value)
        {
            return I_Value / 12;
        }

        /// <summary>
        /// Converteds the feet to yard.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        public double Converted_FeetToYard(double F_Value)
        {
            return F_Value / 3;
        }

        /// <summary>
        /// Converteds the yard to feet.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        public double Converted_YardToFeet(double Y_Value)
        {
            return Y_Value * 3;
        }

        /// <summary>
        /// Converteds the inches to yard.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        public double Converted_InchesToYard(double I_Value)
        {
            return I_Value / 36;
        }

        /// <summary>
        /// Converteds the yard to inches.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        public double Converted_YardToInches(double Y_Value)
        {
            return Y_Value * 36;
        }

    }
}
