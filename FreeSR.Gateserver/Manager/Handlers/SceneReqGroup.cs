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
                DownloadData = new() { },
                EntityMotionList = request.EntityMotionList,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }


        [Handler(CmdType.SetClientPausedCsReq)]
        public static void OnSetClientPausedCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as SetClientPausedCsReq;

            session.Send(CmdType.SetClientPausedCsReq, new SetClientPausedScRsp
            {
                Paused = request.Paused,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }

    }
}
