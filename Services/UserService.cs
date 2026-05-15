using ECommerceAPI.Models;
using ECommerceAPI.Repositories;
using BCrypt.Net;

namespace ECommerceAPI.Services;

public class UserService:IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }
    
    public User RegisterUser(User user)
    {
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        var userrepo = _repository.Register(user);
        return userrepo;
    }
}