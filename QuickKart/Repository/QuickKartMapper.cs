using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using QuickKartDataAccessLayer.Models;
using QuickKartDataAccessLayer;


namespace QuickKart.Repository
{
    public class QuickKartMapper:Profile
    {
        public QuickKartMapper()
        {
            CreateMap<Products, Models.Products>();
            CreateMap<Models.Products, Products>();
        }

    }
}
