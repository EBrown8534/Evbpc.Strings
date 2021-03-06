﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ellersoft.Strings
{
    public abstract class StringWhitelistNN
        : StringWhitelist
    {
        protected abstract int MinLength { get; }
        protected abstract int MaxLength { get; }
        protected override string RegexValidation => $"^[{StringWhitelist.CreateWhitelist(Whitelist)}]{{{MinLength},{MaxLength}}}$";
        protected override string ErrorRequirement => $"The value must be between {MinLength} and {MaxLength} characters and {base.ErrorRequirement}";

        protected StringWhitelistNN() { }
        public StringWhitelistNN(string str) : base(str) { }
    }
}
