﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class ResponseLogin
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Telp { get; set; }
        public string Alamat { get; set; }
        public string Departemen { get; set; }
        public string Role { get; set; }
    }
}
