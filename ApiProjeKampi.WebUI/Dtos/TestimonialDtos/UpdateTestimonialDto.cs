﻿namespace ApiProjeKampi.WebUI.Dtos.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int testimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
