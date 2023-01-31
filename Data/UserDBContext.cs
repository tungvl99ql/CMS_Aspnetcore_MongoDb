using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using SkynetScan.Interface;
using SkynetScan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkynetScan.Data
{
    public class UserDBContext : IUser
    {
        public readonly IMongoDatabase _db;

        public UserDBContext(IOptions<Setting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<UserModel> Usercollection => _db.GetCollection<UserModel>("user");

        public bool BlockUser(string username)
        {
            throw new NotImplementedException();
        }

        public bool CreateUser(UserModel user)
        {
            Usercollection.InsertOne(user);
            return true;
        }

        UserModel IUser.CheckLogin(string username, string password)
        {
            var _user = Usercollection.Find(x => x.UserName == username && x.PassWord == password).FirstOrDefault();
            return _user;
        }
    }
}
