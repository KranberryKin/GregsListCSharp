using System;
using System.Collections.Generic;

namespace GregsListCSharp.Models
{
    public class Account : Profile
    {
        public string Id { get; set; }
        public string Email { get; set; }
    }
}