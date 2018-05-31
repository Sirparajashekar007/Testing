using System;
using System.Runtime.Serialization;

namespace ConsoleApplication2
{
    [Serializable]
    internal class ExceptionClass : Exception
    {
        private Exception innerException;

        public ExceptionClass()
        {
        }

        public ExceptionClass(Exception innerException)
        {
            this.innerException = innerException;
        }

        public ExceptionClass(string message) : base(message)
        {
            Console.WriteLine("Message:-" + message);
            Console.ReadLine();
        }

        public ExceptionClass(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionClass(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}