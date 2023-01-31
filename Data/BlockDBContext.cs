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
    //public class BlockDBContext : IBlock
    //{
    //    public readonly IMongoDatabase _db;

    //    public BlockDBContext(IOptions<Setting> options)
    //    {
    //        var client = new MongoClient(options.Value.ConnectionString);
    //        _db = client.GetDatabase(options.Value.Database);
    //    }

    //    public IMongoCollection<BlockModel> Blockcollection => _db.GetCollection<BlockModel>("block");
        
    //    public BlockModel GetBlock(ulong Blocknumber)
    //    {
    //        return Blockcollection.Find(a => a.number == Blocknumber).FirstOrDefault();
    //    }

    //    public IEnumerable<BlockModel> GetLimitBlock()
    //    {
    //        //return Blockcollection.Find(a => true).Limit(10).ToList();
    //        return Blockcollection.AsQueryable().OrderByDescending(c => c._id).Take(10).ToList();
    //    }

    //    public IEnumerable<BlockModel> GetLimitBlockWithPage(int page)
    //    {
    //        int _elementInpage = 25;
    //        int skip = _elementInpage * page;
    //        return Blockcollection.AsQueryable().OrderByDescending(c => c._id).Skip(skip).Take(25).ToList();
    //    }

    //    public void CreateBlock(BlockModel block)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public void UpdateBlock(string _id, BlockModel block)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public long CountBlock()
    //    {
    //        return Blockcollection.CountDocuments(new BsonDocument());
    //    }
    //}
}
