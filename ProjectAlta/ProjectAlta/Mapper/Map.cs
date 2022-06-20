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
            this.CreateMap<DocumentDTO, Document>();    
            this.CreateMap<Document, DocumentDTO>();
            this.CreateMap<AdminAccountDTO, AdminAccount>();
            this.CreateMap<AdminAccount, AdminAccountDTO>();
            this.CreateMap<ClassDTO, Class>();
            this.CreateMap<Class, ClassDTO>();
            this.CreateMap<GradeDTO, Grade>();
            this.CreateMap<Grade, GradeDTO>();
            this.CreateMap<Class_CourseDTO, Class_Course>();
            this.CreateMap<Class_Course, Class_CourseDTO>();
            this.CreateMap<PositionDTO, Position>();
            this.CreateMap<Position, PositionDTO>();
        }
            
    }
}
