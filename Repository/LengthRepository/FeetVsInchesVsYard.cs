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
            RedisCache.RedisConnection("FeetToInches "+F_Value.ToString() , "Inches "+result.ToString());
            return result;
        }

        /// <summary>
        /// Converteds the inches to feet.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        public double Converted_InchesToFeet(double I_Value)
        {
            double result = I_Value / 12;
            RedisCache.RedisConnection("InchesToFeet " + I_Value.ToString(), "Feet " + result.ToString());
            return result;
            
        }

        /// <summary>
        /// Converteds the feet to yard.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        public double Converted_FeetToYard(double F_Value)
        {
            double result = F_Value / 3;
            RedisCache.RedisConnection("FeetToYard " + F_Value.ToString(), "Yard " + result.ToString());
            return result;
            
        }

        /// <summary>
        /// Converteds the yard to feet.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        public double Converted_YardToFeet(double Y_Value)
        {
            double result = Y_Value * 3;
            RedisCache.RedisConnection("YardToFeet " + Y_Value.ToString(), "Feet " + result.ToString());
            return result;
            
        }

        /// <summary>
        /// Converteds the inches to yard.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        public double Converted_InchesToYard(double I_Value)
        {
            double result = I_Value / 36;
            RedisCache.RedisConnection("InchesToYard " + I_Value.ToString(), "Yard " + result.ToString());
            return result;
           
        }

        /// <summary>
        /// Converteds the yard to inches.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        public double Converted_YardToInches(double Y_Value)
        {
            double result =  Y_Value * 36;
            RedisCache.RedisConnection("YardToInches " + Y_Value.ToString(), "Inches " + result.ToString());
            return result;
           
        }

    }
}
