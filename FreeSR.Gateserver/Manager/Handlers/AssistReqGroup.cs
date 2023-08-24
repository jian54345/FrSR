using FreeSR.Gateserver.Manager.Handlers.Core;
using FreeSR.Gateserver.Network;
using FreeSR.Proto;
using NLog.LayoutRenderers.Wrappers;
using System;
using System.Collections.Generic;
namespace FreeSR.Gateserver.Manager.Handlers
{
    internal class AssistReqGroup
    {
        [Handler(CmdType.GetCurAssistCsReq)]
        public static void OnGetCurAssistCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetCurAssistScRsp, new GetCurAssistScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }
    }
}
