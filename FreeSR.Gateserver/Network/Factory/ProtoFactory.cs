namespace FreeSR.Gateserver.Network.Factory
{
    using FreeSR.Proto;
    using ProtoBuf;
    using System.Collections.Immutable;

    internal static class ProtoFactory
    {
        private static readonly ImmutableDictionary<CmdType, Type> s_types;

        static ProtoFactory()
        {
            var builder = ImmutableDictionary.CreateBuilder<CmdType, Type>();
            builder.AddRange(new Dictionary<CmdType, Type>()
            {
                {CmdType.PlayerGetTokenCsReq, typeof(PlayerGetTokenCsReq)},
                {CmdType.PlayerLoginCsReq, typeof(PlayerLoginCsReq)},
                {CmdType.GetAvatarDataCsReq, typeof(GetAvatarDataCsReq)},

                {CmdType.GetAllLineupDataCsReq, typeof(GetAllLineupDataCsReq)},
                {CmdType.GetCurLineupDataCsReq, typeof(GetCurLineupDataCsReq)},
                {CmdType.ChangeLineupLeaderCsReq, typeof(ChangeLineupLeaderCsReq)},

                {CmdType.GetMissionStatusCsReq, typeof(GetMissionStatusCsReq)},
                {CmdType.GetQuestDataCsReq, typeof(GetQuestDataCsReq)},
                {CmdType.GetChallengeCsReq, typeof(GetChallengeCsReq)},
                {CmdType.GetCurSceneInfoCsReq, typeof(GetCurSceneInfoCsReq)},

                {CmdType.GetBasicInfoCsReq, typeof(GetBasicInfoCsReq)},
                {CmdType.GetHeroBasicTypeInfoCsReq, typeof(GetHeroBasicTypeInfoCsReq)},
                {CmdType.PlayerHeartBeatCsReq, typeof(PlayerHeartBeatCsReq)},

                {CmdType.GetGachaInfoCsReq, typeof(GetGachaInfoCsReq)},
                {CmdType.DoGachaCsReq, typeof(DoGachaCsReq)},

                {CmdType.GetNpcTakenRewardCsReq, typeof(GetNpcTakenRewardCsReq)},
                {CmdType.GetFirstTalkByPerformanceNpcCsReq, typeof(GetFirstTalkByPerformanceNpcCsReq)},

                {CmdType.GetBagCsReq, typeof(GetBagCsReq)},


                {CmdType.SceneEntityMoveCsReq, typeof(SceneEntityMoveCsReq)},
                {CmdType.PlayerLogoutCsReq, typeof(PlayerLogoutCsReq)},
                {CmdType.GetMailCsReq, typeof(GetMailCsReq)},
                {CmdType.SetClientPausedCsReq, typeof(SetClientPausedCsReq)},
                {CmdType.QuitBattleCsReq, typeof(QuitBattleCsReq)},
                {CmdType.GetMissionDataCsReq, typeof(GetMissionDataCsReq)},
                {CmdType.FinishTalkMissionCsReq, typeof(FinishTalkMissionCsReq)},
                {CmdType.GetMissionEventDataCsReq, typeof(GetMissionEventDataCsReq)},
                {CmdType.GetCurBattleInfoCsReq, typeof(GetCurBattleInfoCsReq)},
                {CmdType.GetShopListCsReq, typeof(GetShopListCsReq)},

                {CmdType.GetPhoneDataCsReq, typeof(GetPhoneDataCsReq)},
                {CmdType.GetSecretKeyInfoCsReq, typeof(GetSecretKeyInfoCsReq)},
                {CmdType.GetAuthkeyCsReq, typeof(GetAuthkeyCsReq)},
                {CmdType.PlayerLoginFinishCsReq, typeof(PlayerLoginFinishCsReq)},
                {CmdType.GetVideoVersionKeyCsReq, typeof(PlayerLoginFinishCsReq)},
                {CmdType.GetChatFriendHistoryCsReq, typeof(GetChatFriendHistoryCsReq)},
                {CmdType.GetLoginActivityCsReq, typeof(GetLoginActivityCsReq)},
                {CmdType.GetFriendApplyListInfoCsReq, typeof(GetFriendApplyListInfoCsReq)},
                {CmdType.GetFriendListInfoCsReq, typeof(GetFriendListInfoCsReq)},
                {CmdType.GetPlayerReturnMultiDropInfoCsReq, typeof(GetPlayerReturnMultiDropInfoCsReq)},
                {CmdType.PlayerReturnInfoQueryCsReq, typeof(PlayerReturnInfoQueryCsReq)},
                {CmdType.GetPlayerBoardDataCsReq, typeof(GetPlayerBoardDataCsReq)},
                {CmdType.GetNpcStatusCsReq, typeof(GetNpcStatusCsReq)},
                {CmdType.GetLevelRewardTakenListCsReq, typeof(GetLevelRewardTakenListCsReq)},
                {CmdType.SyncClientResVersionCsReq, typeof(SyncClientResVersionCsReq)},
                {CmdType.GetCurAssistCsReq, typeof(GetCurAssistCsReq)},
                {CmdType.GetQuestRecordCsReq, typeof(GetQuestRecordCsReq)},

                {CmdType.GetLineupAvatarDataCsReq, typeof(GetLineupAvatarDataCsReq)},
                {CmdType.ReplaceLineupCsReq, typeof(ReplaceLineupCsReq)},
                {CmdType.GetCurChallengeCsReq, typeof(GetCurChallengeCsReq)},
                {CmdType.GetArchiveDataCsReq, typeof(GetArchiveDataCsReq)},
                {CmdType.GetUpdatedArchiveDataCsReq, typeof(GetUpdatedArchiveDataCsReq)},

                {CmdType.GetTutorialCsReq, typeof(GetTutorialCsReq)},
                {CmdType.GetTutorialGuideCsReq, typeof(GetTutorialGuideCsReq)},
                {CmdType.GetAllSaveRaidCsReq, typeof(GetAllSaveRaidCsReq)},
                {CmdType.GetFirstTalkNpcCsReq, typeof(GetFirstTalkNpcCsReq)},
                {CmdType.EnterSectionCsReq, typeof(EnterSectionCsReq)},
                {CmdType.EntityBindPropCsReq, typeof(EntityBindPropCsReq)},
                {CmdType.FinishTutorialCsReq, typeof(FinishTutorialCsReq)},
                {CmdType.UnlockTutorialCsReq, typeof(UnlockTutorialCsReq)},
                {CmdType.UnlockTutorialGuideCsReq, typeof(UnlockTutorialGuideCsReq)},
                {CmdType.GetNpcMessageGroupCsReq, typeof(GetNpcMessageGroupCsReq)},

            });

            s_types = builder.ToImmutable();
        }

        public static object Deserialize(int id, byte[] rawData)
        {
            if (s_types.TryGetValue((CmdType)id, out var type))
                return Serializer.Deserialize(type, new MemoryStream(rawData));

            return null;
        }
    }
}
