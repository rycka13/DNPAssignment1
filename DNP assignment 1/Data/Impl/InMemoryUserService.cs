using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DNP_assignment_1.Data.Impl
{
    public class InMemoryUserService : IUserService {
        private List<User> users;

        public InMemoryUserService() {
            users = new[] {
                new User {
                    Domain = "via.dk",
                    Password = "123",
                    Role = "Teacher",
                    BirthYear = 1998,
                    SecurityLevel = 5,
                    UserName = "Jakob"
                },
                new User {
                    Domain = "gmail.com",
                    Password = "123",
                    Role = "Student",
                    BirthYear = 2001,
                    SecurityLevel = 3,
                    UserName = "Rytis"
                },
                new User {
                    Domain = "gmail.com",
                    Password = "123",
                    Role = "Guest",
                    BirthYear = 2020,
                    SecurityLevel = 1,
                    UserName = "Newborn"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}