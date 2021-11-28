﻿using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterPasswordConfirm { get; set; }
        public bool WriterAgreement { get; set; }
        public bool WriterStatus { get; set; }
    }
}
