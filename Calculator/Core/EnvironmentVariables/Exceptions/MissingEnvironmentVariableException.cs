﻿using System;

namespace Calculator.Core.EnvironmentVariables.Exceptions
{
    public class MissingEnvironmentVariableException : Exception
    {
        public MissingEnvironmentVariableException()
        { }

        public MissingEnvironmentVariableException(string message) : base(message)
        { }

        public MissingEnvironmentVariableException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
