using System;
using System.Runtime.Serialization;

namespace CommandDotNet.TestTools
{
    [Serializable]
    public class AssertFailedException : Exception
    {
        public AssertFailedException(string message)
            : base(message)
        {
        }

        protected AssertFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}