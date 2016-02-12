using Owen.WebStore.Domain.Entities;
using Owen.WebStore.Infraestructure.Persistence;
using Owen.WebStore.Domain.Commands.UserCommands;
using Owen.WebStore.Domain.Repositories;
using Owen.WebStore.Domain.Services;
using System.Collections.Generic;

namespace Owen.WebStore.ApplicationService
{
    public class UserApplicationService : ApplicationService, IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUserRepository repository, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this._repository = repository;
        }

        public User Register(RegisterUserCommand command)
        {
            var user = new User(command.Email, command.Password, command.IsAdmin);
            user.Register();
            _repository.Register(user);

            if (Commit())
                return user;

            return null;
        }

        public User Authenticate(string username, string password)
        {
            return _repository.Authenticate(username, password);
        }

        public List<User> List()
        {
            return _repository.List();
        }
    }
}
