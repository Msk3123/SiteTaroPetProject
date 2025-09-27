using System;
using Entities.Models;
namespace Contracts.Interface;

public interface IUser
{
   // public User GetUser();
    public void AddUser(User user);
}