// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LengthManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------
using Repository.LengthRepository;

namespace Manager.LengthManager
{
    /// <summary>
    /// LengthManager class
    /// </summary>
    /// <seealso cref="Manager.LengthManager.ILengthManager" />
    public class LengthManager : ILengthManager
    {
        /// <summary>
        /// The repo
        /// </summary>
        public readonly IFeetVsInchesVsYard repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="LengthManager"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public LengthManager(IFeetVsInchesVsYard repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Converteds the feet to inches.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        public double Converted_FeetToInches(double F_Value)
        {
            return repo.Converted_FeetToInches(F_Value);
        }

        /// <summary>
        /// Converteds the feet to yard.
        /// </summary>
        /// <param name="F_Value">The f value.</param>
        /// <returns></returns>
        public double Converted_FeetToYard(double F_Value)
        {
            return repo.Converted_FeetToInches(F_Value);
        }

        /// <summary>
        /// Converteds the inches to feet.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        public double Converted_InchesToFeet(double I_Value)
        {
            return repo.Converted_InchesToFeet(I_Value);
        }

        /// <summary>
        /// Converteds the inches to yard.
        /// </summary>
        /// <param name="I_Value">The i value.</param>
        /// <returns></returns>
        public double Converted_InchesToYard(double I_Value)
        {
            return repo.Converted_InchesToYard(I_Value);
        }

        /// <summary>
        /// Converteds the yard to feet.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        public double Converted_YardToFeet(double Y_Value)
        {
            return repo.Converted_YardToFeet(Y_Value);
        }

        /// <summary>
        /// Converteds the yard to inches.
        /// </summary>
        /// <param name="Y_Value">The y value.</param>
        /// <returns></returns>
        public double Converted_YardToInches(double Y_Value)
        {
            return repo.Converted_YardToInches(Y_Value);
        }
    }

}
