//using CMDFrontend.ServiceFacade;
using System;
using System.Runtime.Serialization;

namespace CMDFrontend.Doctor.View
{
    [Serializable]
    internal class InvalidPasswordNotMatchException : Exception
    {
        public InvalidPasswordNotMatchException()
        {
        }

        public InvalidPasswordNotMatchException(string message) : base(message)
        {
        }

        public InvalidPasswordNotMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPasswordNotMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}