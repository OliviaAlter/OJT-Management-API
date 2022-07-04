using API.Entities;
using ojt_management_api.Entities;

namespace API.Interfaces;

public interface ITokenServices
{
    string CreateToken(Users user);
}