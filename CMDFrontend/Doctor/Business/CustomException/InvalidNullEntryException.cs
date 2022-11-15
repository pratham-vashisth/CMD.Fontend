//using CMDFrontend.ServiceFacade;
using System;
using System.Runtime.Serialization;

namespace CMDFrontend.Doctor.View
{
    [Serializable]
    internal class InvalidNullEntryException : Exception
    {
        public InvalidNullEntryException()
        {
        }

        public InvalidNullEntryException(string message) : base(message)
        {
        }

        public InvalidNullEntryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidNullEntryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}