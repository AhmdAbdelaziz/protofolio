﻿using Serenity.Services;

namespace AdminArea.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}