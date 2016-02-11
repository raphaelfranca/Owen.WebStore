using Owen.WebStore.Domain.Entities;
using System.Collections.Generic;

namespace Owen.WeStore.Domain.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Authenticate(string email, string password);
        User GetByEmail(string email);
        List<User> List();
    }
}
