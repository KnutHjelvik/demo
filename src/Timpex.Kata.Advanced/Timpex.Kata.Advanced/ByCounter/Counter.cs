﻿using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByCounter
{
    public class Counter
    {

        public virtual void IncrementCount()
        {
            Count++;
        }

        public virtual int Count { get; private set; }
    }
}