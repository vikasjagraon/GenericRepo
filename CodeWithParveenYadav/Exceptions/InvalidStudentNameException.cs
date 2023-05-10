using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CodeWithParveenYadav.Exceptions
{
    class InvalidStudentNameException : Exception
    {
        internal InvalidStudentNameException() { }

        internal InvalidStudentNameException(string errorMessage) : base(errorMessage)   {  }

        internal InvalidStudentNameException(string errorMessage, Exception ex ) : base(errorMessage, ex) { }

        internal InvalidStudentNameException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
