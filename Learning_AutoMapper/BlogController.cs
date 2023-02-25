using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Learning_AutoMapper
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly BlogCollection _blogCollection;

        public BlogController(IMapper mapper, BlogCollection blogCollection)
        {
            _mapper = mapper;
            _blogCollection = blogCollection;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var blog = await _blogCollection.GetAsync(id);

            if (blog == null) return NotFound();

            return Ok(_mapper.Map<BlogApiModel>(blog));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var blogs = await _blogCollection.GetAllAsync();

            return Ok(_mapper.Map<BlogApiModel[]>(blogs));
        }
    }
}
