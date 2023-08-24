namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;

    internal static class NPCReqGroup
    {
        //maybe useless
        [Handler(CmdType.GetNpcTakenRewardCsReq)]
        public static void OnGetNpcTakenRewardCsReq(NetSession session, int cmdId, object data)
        {

            var npcRewardReq = data as GetNpcTakenRewardCsReq;

            session.Send(CmdType.GetNpcTakenRewardScRsp, new GetNpcTakenRewardScRsp
            {
                NpcId = npcRewardReq.NpcId,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }

        [Handler(CmdType.GetFirstTalkByPerformanceNpcCsReq)]
        public static void OnGetFirstTalkByPerformanceNpcCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetFirstTalkByPerformanceNpcScRsp, new GetFirstTalkByPerformanceNpcScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                NpcMeetStatusList = new List<PLGKGCOKJOH>
                {
                    new PLGKGCOKJOH
                    {
                        IsMeet = true,
                        KBGCLBANHMF = 1
                    },
                }
            });
        }

        [Handler(CmdType.GetNpcStatusCsReq)]
        public static void OnGetNpcStatusCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetNpcStatusScRsp, new GetNpcStatusScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

        [Handler(CmdType.GetNpcMessageGroupCsReq)]
        public static void OnGetNpcMessageGroupCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetNpcMessageGroupScRsp, new GetNpcMessageGroupScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

        [Handler(CmdType.GetFirstTalkNpcCsReq)]
        public static void OnGetFirstTalkNpcCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetFirstTalkNpcScRsp, new GetFirstTalkNpcScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

    }
}
