namespace NDDDSample.Domain.Model.Cargos
{
    #region Usings

    using Shared;
    using TempHelper;

    #endregion

    /// <summary>
    /// Uniquely identifies a particular cargo. Automatically generated by the application.
    /// </summary>
    public class TrackingId : IValueObject<TrackingId>
    {
        private string id;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id"></param>
        public TrackingId(string id)
        {
            Validate.notNull(id);
            this.id = id;
        }

        #region Implementation of IValueObject<TrackingId>

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public bool sameValueAs(TrackingId other)
        {
            return other != null && this.id.Equals(other.id);
        }

        #endregion
    }
}