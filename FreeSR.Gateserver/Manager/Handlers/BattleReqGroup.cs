namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Proto;
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    internal class BattleReqGroup
    {
        [Handler(CmdType.QuitBattleCsReq)]
        public static void OnQuitBattleCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as QuitBattleCsReq;

            session.Send(CmdType.QuitBattleScRsp, new QuitBattleScRsp() 
            {
                Retcode = Retcode.RETCODE_RET_SUCC 
            });
        }


        [Handler(CmdType.GetCurBattleInfoCsReq)]
        public static void OnGetCurBattleInfoCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetCurBattleInfoCsReq;

            session.Send(CmdType.GetCurBattleInfoScRsp, new GetCurBattleInfoScRsp() 
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

    }
}
