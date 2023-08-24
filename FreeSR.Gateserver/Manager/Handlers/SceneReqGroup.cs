namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    internal static class SceneReqGroup
    {
        [Handler(CmdType.GetCurSceneInfoCsReq)]
        public static void OnGetCurSceneInfoCsReq(NetSession session, int cmdId, object data)
        {
            SceneInfo scene = new SceneInfo
            {
                GPJKFDCDOLD = 1,
                LDNOPOBIGOB = 1,
                CJBDBIDKNOG = 1,
                EntryId = 1000101,
                PlaneId = 10001,
                FloorId = 10001001,
                EntityList = new List<SceneEntityInfo>(),
                EnvBuffList = new List<BuffInfo>(),
                LightenSectionList = new List<int>()
            };

            scene.EntityList.Add(new SceneEntityInfo
            {
                EntityId = 0,
                GroupId = 0,
                InstId = 0,
                Motion = new MotionInfo()
                {
                    Pos = new Vector(),
                    Rot = new Vector()
                }
            });

            session.Send(CmdType.GetCurSceneInfoScRsp, new GetCurSceneInfoScRsp
            {
                Scene = scene,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }

        [Handler(CmdType.SceneEntityMoveCsReq)]
        public static void OnSceneEntityMoveCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as SceneEntityMoveCsReq;

            session.Send(CmdType.SceneEntityMoveScRsp, new SceneEntityMoveScRsp
            {
                DownloadData = new ClientDownloadData(),
                EntityMotionList = request.EntityMotionList,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }

        [Handler(CmdType.GetSceneMapInfoCsReq)]
        public static void OnGetSceneMapInfoCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetSceneMapInfoCsReq;

            session.Send(CmdType.GetSceneMapInfoScRsp, new GetSceneMapInfoScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                LightenSectionList = new List<int>(),
                EntryId = request.EntryId,
                CurMapEntryId = request.EntryId,
                JIBJCPPHKFI = request.JIBJCPPHKFI,
                MazeGroupList = new()
                {                  
                },
                EMGKEPONFBH = new() 
                { 
                },
                KKFJFLAIBPP = new() 
                {
                },
                MazePropList = new() 
                { 
                },
                UnlockTeleportList = new() 
                { 
                },
                
            });
        }

        //[Handler(CmdType.SceneUpdatePositionVersionNotify)]
        public static void OnSceneUpdatePositionVersionNotify(NetSession session, int cmdId, object data)
        {

        }

        [Handler(CmdType.EnterSectionCsReq)]
        public static void OnEnterSectionCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as EnterSectionCsReq;

            session.Send(CmdType.EnterSectionScRsp, new EnterSectionCsRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,    
            });
        }

        [Handler(CmdType.EntityBindPropCsReq)]
        public static void OnEntityBindPropCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as EnterSectionCsReq;

            session.Send(CmdType.EntityBindPropScRsp, new EntityBindPropScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,         
            });
        }

    }
}
