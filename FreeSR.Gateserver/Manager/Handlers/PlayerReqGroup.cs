﻿namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    using NLog;

    internal static class PlayerReqGroup
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        [Handler(CmdType.PlayerHeartBeatCsReq)]
        public static void OnPlayerHeartBeatCsReq(NetSession session, int cmdId, object data)
        {
            var heartbeatReq = data as PlayerHeartBeatCsReq;

            session.Send(CmdType.PlayerHeartBeatScRsp, new PlayerHeartBeatScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,

                DownloadData = new ClientDownloadData(),
                CurrentTime = heartbeatReq.CurrentTime,
                ServerTime = DateTimeOffset.Now.ToUnixTimeMilliseconds()
            });
        }

        [Handler(CmdType.GetHeroBasicTypeInfoCsReq)]
        public static void OnGetHeroBasicTypeInfoCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetHeroBasicTypeInfoScRsp, new GetHeroBasicTypeInfoScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                Gender = Gender.GenderMan,
                BasicTypeInfoList = new List<HeroBasicTypeInfo>
                {
                    new HeroBasicTypeInfo
                    {
                        BasicType = HeroBasicType.BoyWarrior,
                        Rank = 1,
                        SkillTreeList = new List<AvatarSkillTree>()
                    }
                },
                CurBasicType = HeroBasicType.BoyWarrior,
                IsPlayerInfoModified = false,
                IsGenderModified = false
            });
        }

        [Handler(CmdType.GetBasicInfoCsReq)]
        public static void OnGetBasicInfoCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetBasicInfoScRsp, new GetBasicInfoScRsp
            {
                CurDay = 1,
                ExchangeTimes = 0,
                Retcode = 0,
                NextRecoverTime = 2281337,
                WeekCocoonFinishedCount = 0                
            });
        }

        [Handler(CmdType.PlayerLoginCsReq)]
        public static void OnPlayerLoginCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as PlayerLoginCsReq;

            session.Send(CmdType.PlayerLoginScRsp, new PlayerLoginScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                IsNewPlayer = false,
                LoginRandom = request.LoginRandom,
                Stamina = 100,
                ServerTimestampMs = DateTimeOffset.Now.ToUnixTimeSeconds() * 1000,
                BasicInfo = new PlayerBasicInfo
                {
                    Nickname = "xeondev",
                    Level = 30,
                    Exp = 0,
                    Stamina = 100,
                    MCoin = 0,
                    HCoin = 0,
                    SCoin = 0,
                    WorldLevel = 0
                }
            });
        }

        [Handler(CmdType.PlayerGetTokenCsReq)]
        public static void OnPlayerGetTokenCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as PlayerGetTokenCsReq;

            session.Send(CmdType.PlayerGetTokenScRsp, new PlayerGetTokenScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                Uid = int.Parse(request.AccountUid),
                BlackInfo = null,
                Msg = null,
                SecretKeySeed = 0
            });

            session.Send(CmdType.BattlePassInfoNotify, new BattlePassInfoNotify
            {
                APAKIFHJGIM = FJOOCNKDGEG.BP_TIER_TYPE_PREMIUM_2,
                HMFDMCECAHO = 4294967294,
                LLMDFFBAPKC = 2440,
                OGKOMHAPOGL = 3,
                Exp = 1000,
                Level = 50
            });
        }

        [Handler(CmdType.PlayerLogoutCsReq)]
        public static void OnPlayerLogoutCsReq(NetSession session, int cmdId, object _)
        {
            // Sends nothing and expects nothing? idk

            session.Send(CmdType.PlayerLogoutScRsp, new PlayerLogoutCsReq() { });
        }

        [Handler(CmdType.GetPhoneDataCsReq)]
        public static void OnGetPhoneDataCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetPhoneDataScRsp, new GetPhoneDataScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                DDAKBIDPPIC = 0,
                MICAEKDOFLH = new List<int>(),
            });
        }

        [Handler(CmdType.PlayerLoginFinishCsReq)]
        public static void OnPlayerLoginFinishCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.PlayerLoginFinishScRsp, new PlayerLoginFinishScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
             
            });
        }

        [Handler(CmdType.GetLoginActivityCsReq)]
        public static void OnGetLoginActivityCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetLoginActivityScRsp, new GetLoginActivityScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                LoginActivityList = new List<LoginActivityData> 
                { 

                },
            });
        }

        [Handler(CmdType.GetPlayerReturnMultiDropInfoCsReq)]
        public static void OnGetPlayerReturnMultiDropInfoCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetPlayerReturnMultiDropInfoScRsp, new GetPlayerReturnMultiDropInfoScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                JKEHCHDHCHP = new()
                {

                },
            });
        }

        [Handler(CmdType.PlayerReturnInfoQueryCsReq)]
        public static void OnPlayerReturnInfoQueryCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.PlayerReturnInfoQueryScRsp, new PlayerReturnInfoQueryScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                EBEOFGAPPGB = new()
                {

                },
                KEFAOCBMJOO = new()
                {

                },
            });
        }

        [Handler(CmdType.GetPlayerBoardDataCsReq)]
        public static void OnGetPlayerBoardDataCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetPlayerBoardDataScRsp, new GetPlayerBoardDataScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                Signature = "",
                CurrentHeadIconId = 0,
                DisplayAvatarVec = new()
                {

                },
                GHEJADAMLJN = 0,
                UnlockedHeadIconList = new()
                {

                }
            });
        }

        [Handler(CmdType.GetLevelRewardTakenListCsReq)]
        public static void OnGetLevelRewardTakenListCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetLevelRewardTakenListScRsp, new GetLevelRewardTakenListScRsp()
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
            });
        }

    }
}
