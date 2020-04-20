// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.Length
{
    /// <summary>
    /// Feet class
    /// </summary>
    public class Feet
    {
        /// <summary>
        /// The feet
        /// </summary>
        public double feet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Feet"/> class.
        /// </summary>
        /// <param name="feet">The feet.</param>
        public Feet(double feet)
        {
            this.feet = feet;
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
        /// Converteds the feet value.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <returns></returns>
        public bool ConvertedFeetValue(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            return false;
        }
    }
}

