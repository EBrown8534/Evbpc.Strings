﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Evbpc.Strings
{
    public abstract class StringN_
        : RegexString
    {
        protected abstract int MinLength { get; }
        protected override string RegexValidation => $"^.{{{MinLength},}}$";
        protected override string ErrorRequirement => $"be no less than {MinLength} characters";
        protected override bool AllowNull => true;

        protected StringN_() { }
        public StringN_(string str) : base(str) { }
    }
}
