using Contracts;

namespace GraphQlApi.GraphQls;

public class Mutation
{
    private readonly IGraphService _service;
    private readonly IConfiguration _configuration;
    private readonly string _authLearn;

    public Mutation(IGraphService service, IConfiguration configuration)
    {
        _service = service;
        _configuration = configuration;
        _authLearn = _configuration.GetConnectionString("AuthLearn")!;
    }


    public async Task<string> Login(UserAuthRequest request)
        => await _service.Post($"{_authLearn}/registration/login", request);

    public async Task<string> Register(UserAuthRequest request)
    => await _service.Post($"{_authLearn}/registration/register", request);


}
