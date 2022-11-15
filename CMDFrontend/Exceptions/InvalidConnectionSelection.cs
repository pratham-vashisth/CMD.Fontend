using System;
using System.Runtime.Serialization;

namespace CMDFrontend.CustomException
{
    [Serializable]
    public class InvalidConnectionSelection : Exception
    {
        public InvalidConnectionSelection()
        {
        }

        public InvalidConnectionSelection(string message) : base(message)
        {
        }

        public InvalidConnectionSelection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidConnectionSelection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}