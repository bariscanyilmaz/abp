using System;
using Mongo2Go;

namespace Volo.Abp.IdentityServer;

public class MongoDbFixture : IDisposable
{
    private static readonly MongoDbRunner MongoDbRunner;
    public static readonly string ConnectionString;

    static MongoDbFixture()
    {
        MongoDbRunner = MongoDbRunner.Start(singleNodeReplSet: true, singleNodeReplSetWaitTimeout: 20);
        ConnectionString = MongoDbRunner.ConnectionString;
    }

    public void Dispose()
    {
        MongoDbRunner?.Dispose();
    }
}
