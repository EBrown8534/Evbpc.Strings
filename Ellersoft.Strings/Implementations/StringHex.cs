﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ellersoft.Strings
{
    public class StringHex
        : StringRegex
    {
        protected override string RegexValidation => "^[0-9a-fA-F]*$";
        protected override string ErrorRequirement => "The value must be a hexadecimal number";
        protected override bool AllowNull => true;

        protected StringHex() { }
        public StringHex(string str) : base(str) { }

        public static explicit operator StringHex(string str) => new StringHex(str);
    }
}
