using ECommerceAPI.Models;

namespace ECommerceAPI.Repositories;

public interface IUserRepository
{
    User Register(User user);
}