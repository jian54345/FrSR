using FreeSR.Gateserver.Manager.Handlers.Core;
using FreeSR.Gateserver.Network;
using FreeSR.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FreeSR.Gateserver.Manager.Handlers
{
    internal class RaidReqGroup
    {
        [Handler(CmdType.GetAllSaveRaidCsReq)]
        public static void OnGetAllSaveRaidCsReq(NetSession session, int cmdId, object _)
        {

            session.Send(CmdType.GetAllSaveRaidScRsp, new GetAllSaveRaidScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }
    }
}
