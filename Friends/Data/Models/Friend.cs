﻿namespace Friends.Data.Models
{
    public class Friend
    {
        public int ID { get; set; }

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public DateTime DateOfBirth { get; set; }

        public bool IsFavorited { get; set; } = false;


        // public List<string> Facts { get; set; } = new List<string>();
    }
}
