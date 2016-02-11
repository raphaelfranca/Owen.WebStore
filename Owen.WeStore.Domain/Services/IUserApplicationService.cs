using Owen.WebStore.Domain.Entities;
using Owen.WeStore.Domain.Commands.UserCommands;
using System.Collections.Generic;

namespace Owen.WeStore.Domain.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
        User Authenticate(string email, string password);
        List<User> List();
    }
}
