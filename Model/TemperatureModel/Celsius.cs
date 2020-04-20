// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetToYardUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.TemperatureModel
{
    /// <summary>
    /// Celsiusclass
    /// </summary>
    public class Celsius
    {
        /// <summary>
        /// The celsius
        /// </summary>
        public double celsius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Celsius"/> class.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        public Celsius(double celsius)
        {
            this.celsius = celsius;
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
        /// Converteds the celsius value.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        /// <returns></returns>
        public bool ConvertedCelsiusValue(Celsius celsius)
        {
            if (this.celsius.Equals(celsius.celsius))
                return true;
            return false;
        }
    }
}
