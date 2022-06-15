using AutoMapper;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Mapper
{
    public class Map : Profile
    {
        public Map() 
        {
            this.CreateMap<AdminDTO, Admin>();
            this.CreateMap<Admin, AdminDTO>();
            this.CreateMap<CourseDTO, Course>();
            this.CreateMap<Course, CourseDTO>();
        }
            
    }
}
