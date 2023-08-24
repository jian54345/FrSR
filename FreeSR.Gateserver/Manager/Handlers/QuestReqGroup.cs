using FreeSR.Gateserver.Manager.Handlers.Core;
using FreeSR.Gateserver.Network;
using FreeSR.Proto;

namespace FreeSR.Gateserver.Manager.Handlers
{
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
    }
}
