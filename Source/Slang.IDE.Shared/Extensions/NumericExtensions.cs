﻿namespace Slang.IDE.Shared.Extensions
{
    public static class NumericExtensions
    {
        public static int AsInt(this object source)
        {
            try
            {
                var result = Convert.ToInt32(source);
                return result;
            }
            catch
            {
                return default;
            }
        }

        public static bool AsBool(this object source)
        {
            try
            {
                var result = Convert.ToBoolean(source);
                return result;
            }
            catch
            {
                return default;
            }
        }
    }
}
