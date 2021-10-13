using Models;

namespace DNP_assignment_1.Data
{
    public interface IUserService {
        User ValidateUser(string userName, string password);
    }
}