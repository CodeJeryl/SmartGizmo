﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartGizmoWebApi.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}