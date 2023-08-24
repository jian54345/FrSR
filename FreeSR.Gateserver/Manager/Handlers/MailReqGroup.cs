using FreeSR.Gateserver.Manager.Handlers.Core;
using FreeSR.Gateserver.Network;
using FreeSR.Proto;

namespace FreeSR.Gateserver.Manager.Handlers
{
    internal static class MailReqGroup
    {
        [Handler(CmdType.GetMailCsReq)]
        public static void OnGetMailCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetMailCsReq;

            session.Send(CmdType.GetMailCsReq, new GetMailScRsp
            {
                Start = 0,
                IsEnd = false,
                MailList = new() { },
                NoticeMailList = new() { },
                Retcode = Retcode.RETCODE_RET_SUCC,
                TotalNum = 0,
            });
        }
    }
}
