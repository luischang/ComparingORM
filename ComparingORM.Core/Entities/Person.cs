using System;
using System.Collections.Generic;

#nullable disable

namespace ComparingORM.Core.Entities
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
