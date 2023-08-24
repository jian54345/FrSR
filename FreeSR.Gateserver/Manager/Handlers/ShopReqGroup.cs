namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    internal class ShopReqGroup
    {
        [Handler(CmdType.GetShopListCsReq)]
        public static void OnGetShopListCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetShopListCsReq;

            session.Send(CmdType.GetShopListScRsp, new GetShopListScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                ShopList = new() { },
                ShopType = 0,          
                //SignType = 0, 
                //AuthAppid = request.AuthAppid,
                //AuthkeyVer = request.AuthkeyVer,
                //Authkey 
            });
        }
    }
}
