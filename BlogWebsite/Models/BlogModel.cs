﻿namespace BlogWebsite.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

        public int UserId { get; set; }

        public RegisterModel User { get; set; }


    }
}
