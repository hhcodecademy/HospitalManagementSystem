using AutoMapper;
using HospitalManagementSystem.DAL.Dtos;
using HospitalManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BLL.Mapper
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<Hospital,HospitalDto>().ReverseMap();
        }
    }
}
