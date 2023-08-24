using FreeSR.Gateserver.Manager.Handlers.Core;
using FreeSR.Gateserver.Network;
using FreeSR.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSR.Gateserver.Manager.Handlers
{
    internal class BattleReqGroup
    {
        [Handler(CmdType.QuitBattleCsReq)]
        public static void OnQuitBattleCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as QuitBattleCsReq;

            session.Send(CmdType.QuitBattleCsReq, new QuitBattleScRsp() { Retcode = Retcode.RETCODE_RET_SUCC });
        }
    }
}
