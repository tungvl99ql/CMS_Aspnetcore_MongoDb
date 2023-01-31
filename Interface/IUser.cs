using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SkynetScan.Models;

namespace SkynetScan.Interface
{
    public interface IUser
    {
        public IMongoCollection<UserModel> Usercollection { get; }
        bool CreateUser(UserModel user);
        bool BlockUser(string username);

        public UserModel CheckLogin(string username, string password);

    }
}
