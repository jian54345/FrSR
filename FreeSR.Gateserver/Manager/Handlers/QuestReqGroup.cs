namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    internal static class QuestReqGroup
    {
        [Handler(CmdType.GetQuestDataCsReq)]
        public static void OnGetQuestDataCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetQuestDataCsReq;

            session.Send(CmdType.GetQuestDataScRsp, new GetQuestDataScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                QuestList = new()
                {

                },
                TotalAchievementExp = 0,
            });
        }

        [Handler(CmdType.GetQuestRecordCsReq)]
        public static void OnGetQuestRecordCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetQuestRecordCsReq;

            session.Send(CmdType.GetQuestRecordScRsp, new GetQuestRecordScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                JLPENKAONDC = new List<PHGLLNBOIMC>()
                {

                }
            });
        }

    }
}
