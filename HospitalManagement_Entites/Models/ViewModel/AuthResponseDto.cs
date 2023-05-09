using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Models.ViewModel
{
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
    }
}
