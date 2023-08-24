using FreeSR.Gateserver.Manager.Handlers.Core;
using FreeSR.Gateserver.Network;
using FreeSR.Proto;
using System;
namespace FreeSR.Gateserver.Manager.Handlers
{
    internal class ClientReqGroup
    {
        [Handler(CmdType.SetClientPausedCsReq)]
        public static void OnSetClientPausedCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as SetClientPausedCsReq;

            session.Send(CmdType.SetClientPausedScRsp, new SetClientPausedScRsp
            {
                Paused = request.Paused,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }

        [Handler(CmdType.SyncClientResVersionCsReq)]
        public static void OnSyncClientResVersionCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as SyncClientResVersionCsReq;

            session.Send(CmdType.SyncClientResVersionScRsp, new SyncClientResVersionScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                ResVersion = request.ResVersion
            });
        }
    }
}
