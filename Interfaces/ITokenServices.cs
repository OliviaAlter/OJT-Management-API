using ojt_management_api.Entities;

namespace ojt_management_api.Interfaces;

public interface ITokenServices
{
    string CreateToken(Users user);
}