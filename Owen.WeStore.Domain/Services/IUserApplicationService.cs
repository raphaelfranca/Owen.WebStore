using Owen.WebStore.Domain.Entities;
using Owen.WebStore.Domain.Commands.UserCommands;
using System.Collections.Generic;

namespace Owen.WebStore.Domain.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
        User Authenticate(string email, string password);
        List<User> List();
    }
}
