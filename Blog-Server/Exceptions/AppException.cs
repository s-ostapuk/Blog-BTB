﻿namespace Blog_Server.Exceptions
{
    public class AppException : Exception
    {
        public AppException(string message) : base(message)
        {
        }

        public AppException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
