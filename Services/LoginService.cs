using BankAPI.Data;
using BankAPI.Data.BankModels;
using BankAPI.Data.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BankAPI.Services;

public class LoginService
{

    private readonly BankContext _context;
    public LoginService(BankContext context)
    {
        _context = context;
    }
   
    public async Task<Administrator?> GetAdmin(AdminDto adminDto)
    {
        return await _context.Administrators.
        SingleOrDefaultAsync(x => x.Email == adminDto.Email && x.Pwd == adminDto.Pwd);
    }
}