namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;

    internal class KeyReqGroup
    {
        [Handler(CmdType.GetVideoVersionKeyCsReq)]
        public static void OnGetVideoVersionKeyCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetVideoVersionKeyScRsp, new GetVideoVersionKeyScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                MHLJEPHEIBJ = new List<BDOEJFGGBMH> { },
            });
        }

        [Handler(CmdType.GetSecretKeyInfoCsReq)]
        public static void OnGetSecretKeyInfoCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetSecretKeyInfoCsReq;

            session.Send(CmdType.GetSecretKeyInfoScRsp, new GetSecretKeyInfoScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                HGGIOMLDANA = Array.Empty<byte>(),
                Type = new()
                {

                },
            });
        }

        [Handler(CmdType.GetAuthkeyCsReq)]
        public static void OnGetAuthkeyCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetAuthkeyCsReq;

            session.Send(CmdType.GetAuthkeyScRsp, new GetAuthkeyScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                //SignType = 0, 
                //AuthAppid = request.AuthAppid,
                //AuthkeyVer = request.AuthkeyVer,
                //Authkey 
            });
        }
    }
}
