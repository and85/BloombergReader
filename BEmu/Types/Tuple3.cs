﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEmu.Types
{
    internal class Tuple3<T1, T2, T3>
    {
        public Tuple3(T1 item1, T2 item2, T3 item3)
        {
            this._item1 = item1;
            this._item2 = item2;
            this._item3 = item3;
        }

        private readonly T1 _item1;
        public T1 Item1 { get { return this._item1; } }

        private readonly T2 _item2;
        public T2 Item2 { get { return this._item2; } }

        private readonly T3 _item3;
        public T3 Item3 { get { return this._item3; } }
    }
}
