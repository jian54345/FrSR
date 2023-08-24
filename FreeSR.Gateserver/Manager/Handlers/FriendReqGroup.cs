namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Proto;
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    internal class FriendReqGroup
    {

        [Handler(CmdType.GetChatFriendHistoryCsReq)]
        public static void OnGetChatFriendHistoryCsReq(NetSession session, int cmdId, object _)
        {

            session.Send(CmdType.GetChatFriendHistoryScRsp, new GetChatFriendHistoryScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                FriendHistoryList = new()
                {

                },         
            });
        }

        [Handler(CmdType.GetFriendListInfoCsReq)]
        public static void OnGetFriendListInfoCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetFriendListInfoScRsp, new GetFriendListInfoScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                SimpleInfo = new()
                {
                    
                },
                FriendList = new()
                {

                }

            });
        }

        [Handler(CmdType.GetFriendApplyListInfoCsReq)]
        public static void OnGetFriendApplyListInfoCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetFriendApplyListInfoScRsp, new GetFriendApplyListInfoScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                BEJHCJOOKNL = new List<int> 
                {

                },
                CDGBAGFMDOB = new List<HDFHLILEAMH> 
                { 

                },
            });
        }

    }
}
