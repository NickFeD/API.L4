using Contracts.Response;
using HotChocolate.Authorization;

namespace GraphQlApi.GraphQls;


public class Query
{
    private readonly IGraphService _service;
    private readonly IConfiguration _configuration;
    private readonly string _authLearn;

    public Query(IGraphService service,IConfiguration configuration)
    {
        _service = service;
        _configuration = configuration;
        _authLearn = _configuration.GetConnectionString("AuthLearn")!;
    }


    public async Task<ResultResponse?> SecretUser()
    => await _service.Get<ResultResponse>($"{_authLearn}/registration/secret-user") ;

    public async Task<ResultResponse?> SecretAdmin()
    => await _service.Get<ResultResponse>($"{_authLearn}/registration/secret-admin");
}
