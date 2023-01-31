using BaseAspnetcore_mongodb.Interface;
using Microsoft.AspNetCore.Http;

namespace BaseAspnetcore_mongodb.Models
{
    public class SessionManager : ISessionManager
    {
        public string AccountName { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }
        public string Role { 
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

    }
}
