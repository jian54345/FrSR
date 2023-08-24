namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    internal static class ChallengeReqGroup
    {
        [Handler(CmdType.GetChallengeCsReq)]
        public static void OnGetChallengeCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetChallengeCsReq;

            session.Send(CmdType.GetChallengeScRsp, new GetChallengeScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

        [Handler(CmdType.GetCurChallengeCsReq)]
        public static void OnGetCurChallengeCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetCurChallengeCsReq;

            session.Send(CmdType.GetCurChallengeScRsp, new GetCurChallengeScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

    }
}
