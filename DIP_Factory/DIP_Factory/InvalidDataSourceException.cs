using System;

namespace DIP_Factory
{
    public class InvalidDataSourceException:Exception
    {
        public InvalidDataSourceException(string message): base(message) { }
    }
}
