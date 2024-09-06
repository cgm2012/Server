using Dotmim.Sync;

namespace SyncServer.Controllers
{
    internal interface ISyncProvider
    {
        Task SyncAsync(SyncContext context);
    }
}