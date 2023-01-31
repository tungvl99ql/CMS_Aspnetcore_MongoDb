using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace SkynetScan.Models
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }

        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Role { get; set; } // - 0 - tk thuong, 100- admin

        public string Avatar { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; } // 0 - nu, 1 - nam

    }

   

}
