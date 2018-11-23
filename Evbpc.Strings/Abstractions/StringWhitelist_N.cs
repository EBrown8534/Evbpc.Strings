﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Evbpc.Strings
{
    public abstract class StringWhitelist_N
        : StringWhitelist
    {
        protected abstract int MaxLength { get; }
        protected override string RegexValidation => $"^[{CreateWhitelist(Whitelist)}]{{0,{MaxLength}}}$";
        protected override string ErrorRequirement => $"be no more than {MaxLength} characters and {base.ErrorRequirement}";

        protected StringWhitelist_N() { }
        public StringWhitelist_N(string str) : base(str) { }
    }
}
