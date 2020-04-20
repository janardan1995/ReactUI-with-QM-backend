// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Model.Weight
{
    /// <summary>
    /// GramClass
    /// </summary>
    public class Gram
    {
        /// <summary>
        /// The gram
        /// </summary>
        public double gram;

        /// <summary>
        /// Initializes a new instance of the <see cref="Gram"/> class.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        public Gram(double celsius)
        {
            this.gram = celsius;
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
        /// Converteds the gram value.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        /// <returns></returns>
        public bool ConvertedGramValue(Gram celsius)
        {
            if (this.gram.Equals(celsius.gram))
                return true;
            return false;
        }
    }
}
