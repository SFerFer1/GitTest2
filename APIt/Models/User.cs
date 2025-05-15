#nullable enable
using System;

namespace APIt.Models
{
    public class User
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public float[]? UserBiometric { get; set; } 

        public User(float[]? userBiometric)
        {
            UserBiometric = userBiometric;
        }
    }
}
