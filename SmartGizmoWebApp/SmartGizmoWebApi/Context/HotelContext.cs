using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SmartGizmoWebApi.Models;

namespace SmartGizmoWebApi.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext() : base("DefaultConnection") { }  
   
        public DbSet<Request> Requests { get; set; }  
     
    }

}