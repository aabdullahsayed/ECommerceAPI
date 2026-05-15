using ECommerceAPI.Data;
using ECommerceAPI.Models;

namespace ECommerceAPI.Repositories;

public class UserRepository:IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public User Register(User user)
    {
        var regi =  _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }
}