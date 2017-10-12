using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jolt.Models
{
    public class QuoteFormModel
    {
        public string Email { get; set; }

        public string Material { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public string Description { get; set; }
    }
}