﻿//------------------------------------------------------------------------------
// <copyright project="BEmu" file="IntradayTickRequest/ElementIntradayTickDouble.cs" company="Jordan Robinson">
//     Copyright (c) 2013 Jordan Robinson. All rights reserved.
//
//     The use of this software is governed by the Microsoft Public License
//     which is included with this distribution.
// </copyright>
//------------------------------------------------------------------------------

namespace BEmu.IntradayTickRequest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class ElementIntradayTickDouble : Element
    {
        private readonly double _value;
        private readonly string _name;

        internal ElementIntradayTickDouble(string name, double value)
        {
            this._name = name;
            this._value = value;
        }

        public override Name Name { get { return new Name(this._name); } }
        public override int NumValues { get { return 1; } }
        public override int NumElements { get { return 0; } }
        public override bool IsComplexType { get { return false; } }
        public override bool IsArray { get { return false; } }
        public override bool IsNull { get { return false; } }
        public override IEnumerable<Element> Elements { get { if (this.NumValues < -1) yield return null; } } //This is the only way I can think to have the compiler output "Enumeration yielded no results"
        public override bool HasElement(string name, bool excludeNullElements = false) { return false; }
        public override Schema.Datatype Datatype { get { return Schema.Datatype.FLOAT64; } }

        public override object this[int index]
        {
            get
            {
                if (index == 0)
                    return this._value;
                else
                    return base[index];
            }
        }

        internal override StringBuilder PrettyPrint(int tabIndent)
        {
            return base.PrettyPrintHelper(tabIndent, this._value.ToString());
        }

        public override object GetValue()
        {
            return this._value;
        }

        public override object GetValue(int index)
        {
            if (index == 0)
                return this.GetValue();
            else
                return base.GetValue(index);
        }

        public override double GetValueAsFloat64()
        {
            return this._value;
        }

        public override double GetValueAsFloat64(int index)
        {
            if (index == 0)
                return this.GetValueAsFloat64();
            else
                return base.GetValueAsFloat64(index);
        }

        public override int GetValueAsInt32()
        {
            return (int)this._value;
        }

        public override int GetValueAsInt32(int index)
        {
            if (index == 0)
                return this.GetValueAsInt32();
            else
                return base.GetValueAsInt32(index);
        }

        public override long GetValueAsInt64()
        {
            return (long)this._value;
        }

        public override long GetValueAsInt64(int index)
        {
            if (index == 0)
                return this.GetValueAsInt64();
            else
                return base.GetValueAsInt64(index);
        }

        public override string GetValueAsString()
        {
            return this._value.ToString();
        }

        public override string GetValueAsString(int i)
        {
            if (i == 0)
                return this.GetValueAsString();
            else
                return base.GetValueAsString(i);
        }
    }
}
