﻿//------------------------------------------------------------------------------
// <copyright project="BEmu" file="IntradayBarRequest/RequestIntradayBarElementInt.cs" company="Jordan Robinson">
//     Copyright (c) 2013 Jordan Robinson. All rights reserved.
//
//     The use of this software is governed by the Microsoft Public License
//     which is included with this distribution.
// </copyright>
//------------------------------------------------------------------------------

namespace BEmu.IntradayBarRequest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class RequestIntradayBarElementInt : RequestIntradayBarElementString
    {
        private readonly int _value;

        internal RequestIntradayBarElementInt(string elementName, int value)
            : base(elementName, value.ToString())
        {
            this._value = value;
        }

        //I can't override GetElementAsInt32 here because the Bloomberg Request object stores ints as strings, not ints.  You can't convert the string to an int
        internal int GetInt { get { return this._value; } }
        public override Schema.Datatype Datatype { get { return Schema.Datatype.INT32; } }
    }
}
