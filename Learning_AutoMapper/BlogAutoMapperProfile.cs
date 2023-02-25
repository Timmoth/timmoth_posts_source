using AutoMapper;

namespace Learning_AutoMapper;

public class BlogAutoMapperProfile : Profile
{
    public BlogAutoMapperProfile()
    {
        CreateMap<BlogModel, BlogApiModel>();
    }
}