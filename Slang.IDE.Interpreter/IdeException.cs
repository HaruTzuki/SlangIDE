using System.Runtime.Serialization;

namespace Slang.IDE.Interpreter
{
    [Serializable]
    internal class IdeException : Exception
    {
        public IdeException()
        {
        }

        public IdeException(string? message) : base(message)
        {
        }

        public IdeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IdeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}