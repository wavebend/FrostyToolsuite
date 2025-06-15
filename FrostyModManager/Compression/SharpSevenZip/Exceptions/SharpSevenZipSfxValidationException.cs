using System;
using System.Runtime.Serialization;

namespace SharpSevenZip.Exceptions
{
    /// <summary>
    /// Exception class for 7-zip sfx settings validation.
    /// </summary>
    [Serializable]
    public class SharpSevenZipSfxValidationException : SharpSevenZipException
    {
        /// <summary>
        /// Exception default message which is displayed if no extra information is specified
        /// </summary>
        public static readonly string DefaultMessage = "Sfx settings validation failed.";

        /// <summary>
        /// Initializes a new instance of the SharpSevenZipSfxValidationException class
        /// </summary>
        public SharpSevenZipSfxValidationException()
            : base(DefaultMessage) { }

        /// <summary>
        /// Initializes a new instance of the SharpSevenZipSfxValidationException class
        /// </summary>
        /// <param name="message">Additional detailed message</param>
        public SharpSevenZipSfxValidationException(string message)
            : base(DefaultMessage, message) { }

        /// <summary>
        /// Initializes a new instance of the SharpSevenZipSfxValidationException class
        /// </summary>
        /// <param name="message">Additional detailed message</param>
        /// <param name="inner">Inner exception occurred</param>
        public SharpSevenZipSfxValidationException(string message, Exception inner)
            : base(DefaultMessage, message, inner) { }

        /// <summary>
        /// Initializes a new instance of the SharpSevenZipSfxValidationException class
        /// </summary>
        /// <param name="info">All data needed for serialization or deserialization</param>
        /// <param name="context">Serialized stream descriptor</param>
        protected SharpSevenZipSfxValidationException(
            SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
