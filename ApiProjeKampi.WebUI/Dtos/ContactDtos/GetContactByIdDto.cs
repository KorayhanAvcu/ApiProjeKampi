﻿namespace ApiProjeKampi.WebUI.Dtos.ContactDtos
{
    public class GetContactByIdDto
    {
        public int ContactId { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpenHours { get; set; }
    }
}
