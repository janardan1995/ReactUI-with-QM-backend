// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFeetVsInchesVsYard.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.LengthRepository
{
    /// <summary>
    /// interface of length repository
    /// </summary>
    public interface IFeetVsInchesVsYard
    {
        /// <summary>
        /// Converteds the feet to yard.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        double Converted_FeetToYard(double F_Value);

        /// <summary>
        /// Converteds the yard to feet.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        double Converted_YardToFeet(double Y_Value);

        /// <summary>
        /// Converteds the yard to inches.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        double Converted_YardToInches(double Y_Value);

        /// <summary>
        /// Converteds the inches to yard.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        double Converted_InchesToYard(double I_Value);

        /// <summary>
        /// Converteds the feet to inches.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        double Converted_FeetToInches(double F_Value);

        /// <summary>
        /// Converteds the inches to feet.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        double Converted_InchesToFeet(double I_Value);
    }
}
