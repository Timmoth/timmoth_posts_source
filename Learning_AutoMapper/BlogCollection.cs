namespace Learning_AutoMapper;

public class BlogCollection
{
    private static readonly List<BlogModel> BlogModels = new()
    {
        new(){ Id = "1", Author = "Tim", Title = "My first post"},
        new(){ Id = "2", Author = "Tim", Title = "My second post"}
    };
    public Task<BlogModel?> GetAsync(string id)
    {
        return Task.FromResult(BlogModels.SingleOrDefault(p => p.Id == id));
    }

    public Task<List<BlogModel>> GetAllAsync()
    {
        return Task.FromResult(BlogModels);
    }
}