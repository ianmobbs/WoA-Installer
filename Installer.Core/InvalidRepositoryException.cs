﻿using System;

namespace Installer.Core
{
    internal class InvalidRepositoryException : Exception
    {
        public InvalidRepositoryException(string str) : base(str)
        {            
        }
    }
}