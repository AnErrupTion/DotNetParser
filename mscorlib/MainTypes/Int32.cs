﻿namespace System
{
    public struct Int32
    {
        public override string ToString()
        {
            return Internal.NumberFormatUtils.Int32ToString(this);
        }
    }
}
