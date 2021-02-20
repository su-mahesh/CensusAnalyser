﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyserException : Exception
    {
        /// <summary>
        ///  Custom ExceptionTypes
        /// </summary>
        public enum ExceptionType 
        {
            FILE_NOT_FOUND
        }

        public ExceptionType exceptionType;
        /// <summary>
        /// Initializes a new instance of the <see cref="CensusAnalyserException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exceptionType">Type of the exception.</param>
        internal CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
