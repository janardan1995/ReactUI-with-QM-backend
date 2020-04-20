// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inch.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.Length
{
    /// <summary>
    /// Inch class
    /// </summary>
    public class Inch
    {
        /// <summary>
        /// The inch
        /// </summary>
        public double inch;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inch"/> class.
        /// </summary>
        /// <param name="inch">The inch.</param>
        public Inch(double inch)
        {
            this.inch = inch;
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
        /// Converteds the inch value.
        /// </summary>
        /// <param name="inch">The inch.</param>
        /// <returns></returns>
        public bool ConvertedInchValue(Inch inch)
        {
            if (this.inch.Equals(inch.inch))
                return true;
            return false;
        }
    }
}

