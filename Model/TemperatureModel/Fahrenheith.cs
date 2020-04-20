// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Farhenheith.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.TemperatureModel
{
    /// <summary>
    /// Farhenheith class
    /// </summary>
    public class Fahrenheith
    {
        /// <summary>
        /// The fahrenheith
        /// </summary>
        public double fahrenheith;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fahrenheith"/> class.
        /// </summary>
        /// <param name="fahrenheith">The fahrenheith.</param>
        public Fahrenheith(double fahrenheith)
        {
            this.fahrenheith = fahrenheith;
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
        /// Converteds the fahrenheith value.
        /// </summary>
        /// <param name="fahrenheith">The fahrenheith.</param>
        /// <returns></returns>
        public bool ConvertedFahrenheithValue(Fahrenheith fahrenheith)
        {
            if (this.fahrenheith.Equals(fahrenheith.fahrenheith))
                return true;
            return false;
        }
    }
}
