using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsApp
{
    [Serializable]
    class InvalidPersonalInfoException : Exception
    {
        public InvalidPersonalInfoException()
        {
            HelpLink = "http://www.mydomain.com/infoaboutexception";
        }

        public InvalidPersonalInfoException(string message)
            : base(message)
        {
            HelpLink = "http://www.mydomain.com/infoaboutexception";
        }

        public InvalidPersonalInfoException(string message,
                                         Exception innerException)
            : base(message, innerException)
        {
            HelpLink = "http://www.mydomain.com/infoaboutexception";
        }

        protected InvalidPersonalInfoException(SerializationInfo info, StreamingContext context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }
    }
}
