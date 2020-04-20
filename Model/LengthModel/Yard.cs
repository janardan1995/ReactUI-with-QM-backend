// --------------------------------------------------------------------------------------------------------------------
// <copyright file="yard.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.Length
{
    /// <summary>
    /// yard class
    /// </summary>
    public class Yard
    {
        /// <summary>
        /// The yard
        /// </summary>
        public double yard;

        /// <summary>
        /// Initializes a new instance of the <see cref="Yard"/> class.
        /// </summary>
        /// <param name="yard">The yard.</param>
        public Yard(double yard)
        {
            this.yard = yard;
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
            if((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        /// <summary>
        /// Converteds the yard value.
        /// </summary>
        /// <param name="yard">The yard.</param>
        /// <returns>bool</returns>
        public bool ConvertedYardValue(Yard yard)
        {
            if (this.yard.Equals(yard.yard))
                return true;
            return false;
        }
    }
}
