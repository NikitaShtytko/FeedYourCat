﻿namespace FeedYourCat.Models.Feeders
{
    public class FeederModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public int State { get; set; }
        public bool Status { get; set; }
        public bool Empty { get; set; }
        public string Schedule { get; set; }
    }
}