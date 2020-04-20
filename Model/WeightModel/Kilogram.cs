// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Kilogram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.Weight
{
    /// <summary>
    /// Kilogram class
    /// </summary>
    public class Kilogram
    {
        /// <summary>
        /// The kilogram
        /// </summary>
        public double kilogram;

        /// <summary>
        /// Initializes a new instance of the <see cref="Kilogram"/> class.
        /// </summary>
        /// <param name="kilogram">The kilogram.</param>
        public Kilogram(double kilogram)
        {
            this.kilogram = kilogram;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        /// <summary>
        /// Converteds the kilogram value.
        /// </summary>
        /// <param name="kilogram">The kilogram.</param>
        /// <returns></returns>
        public bool ConvertedKilogramValue(Kilogram kilogram)
        {
            if (this.kilogram.Equals(kilogram.kilogram))
                return true;
            return false;
        }
    }
}
