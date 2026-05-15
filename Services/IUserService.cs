using ECommerceAPI.Models;

namespace ECommerceAPI.Services;

public interface IUserService
{
    User RegisterUser(User user);
}