namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    internal class ArchiveReqGroup
    {
        [Handler(CmdType.GetArchiveDataCsReq)]
        public static void OnGetArchiveDataCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetArchiveDataScRsp, new GetArchiveDataScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,             
            });
        }

        [Handler(CmdType.GetUpdatedArchiveDataCsReq)]
        public static void OnGetUpdatedArchiveDataCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetUpdatedArchiveDataScRsp, new GetUpdatedArchiveDataScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }
    }
}
