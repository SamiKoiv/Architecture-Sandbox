using RentalService.UseCases.UserManagement.InputBoundaries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService.UseCases.UserManagement.Interactors
{
    internal class UserManagementInteractor : IGetUsers
    {
        public IEnumerable<UserDto> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
