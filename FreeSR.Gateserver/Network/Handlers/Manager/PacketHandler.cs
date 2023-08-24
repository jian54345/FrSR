namespace FreeSR.Gateserver.Network.Handlers.Manager
{
    using DotNetty.Transport.Channels;
    using FreeSR.Gateserver.Manager;
    using FreeSR.Gateserver.Network.Packet;
    using FreeSR.Proto;
    using NLog;
    using ProtoBuf;

    internal class PacketHandler : ChannelHandlerAdapter
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();
        private readonly NetSession _session;

        public PacketHandler(NetSession session)
        {
            _session = session;
        }

        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            NetPacket packet = message as NetPacket;
            var cmdId = (CmdType)packet.CmdId;
            if (packet.Data == null)
            {
                if (!SendDummyResponse(packet.CmdId))

                    s_log.Warn($"CmdID {cmdId} is undefined.");

                return;
            }

            Protobuf2File(packet.CmdId, packet.Data);

            s_log.Info($"Received {cmdId}!");
            NotifyManager.Notify(_session, packet.CmdId, packet.Data);
        }

        private bool SendDummyResponse(int id)
        {
            if (s_dummyTable.TryGetValue((CmdType)id, out CmdType rspId))
            {
                _session.Send(rspId, new DummyPacket());
                return true;
            }

            return false;
        }

        private static Dictionary<CmdType, CmdType> s_dummyTable = new Dictionary<CmdType, CmdType>
        {
            {CmdType.GetRogueScoreRewardInfoCsReq, CmdType.GetRogueScoreRewardInfoScRsp},
            {CmdType.QueryProductInfoCsReq, CmdType.QueryProductInfoScRsp},
            {CmdType.GetRogueHandbookDataCsReq, CmdType.GetRogueHandbookDataScRsp},
            {CmdType.GetDailyActiveInfoCsReq, CmdType.GetDailyActiveInfoScRsp},
            {CmdType.GetFightActivityDataCsReq, CmdType.GetFightActivityDataScRsp},
            {CmdType.GetMultipleDropInfoCsReq, CmdType.GetMultipleDropInfoScRsp},
            {CmdType.GetShareDataCsReq, CmdType.GetShareDataScRsp},
            {CmdType.GetTreasureDungeonActivityDataCsReq, CmdType.GetTreasureDungeonActivityDataScRsp},
            {CmdType.GetActivityScheduleConfigCsReq, CmdType.GetActivityScheduleConfigScRsp},
            {CmdType.GetRogueInfoCsReq, CmdType.GetRogueInfoScRsp},
            {CmdType.GetExpeditionDataCsReq, CmdType.GetExpeditionDataScRsp},
            {CmdType.GetRogueDialogueEventDataCsReq, CmdType.GetRogueDialogueEventDataScRsp},
            {CmdType.GetJukeboxDataCsReq, CmdType.GetJukeboxDataScRsp},
            {CmdType.DailyFirstMeetPamCsReq, CmdType.DailyFirstMeetPamScRsp},
            {CmdType.GetMuseumInfoCsReq, CmdType.GetMuseumInfoScRsp},
            {CmdType.GetRaidInfoCsReq, CmdType.GetRaidInfoScRsp},
            {CmdType.GetTrialActivityDataCsReq, CmdType.GetTrialActivityDataScRsp},
            {CmdType.GetBoxingClubInfoCsReq, CmdType.GetBoxingClubInfoScRsp},
            {CmdType.TextJoinQueryCsReq, CmdType.TextJoinQueryScRsp},
            {CmdType.GetSpringRecoverDataCsReq, CmdType.GetSpringRecoverDataScRsp},
        };

        [ProtoContract]
        private class DummyPacket { }


        public void Protobuf2File(int cmdId, object data)
        {
            CmdType cmd = (CmdType)cmdId;

            string filepath = $"C:\\protobuf\\{cmd}.bin";

            using (var file = File.Create(filepath))
            {
                Serializer.Serialize(file, data);
            }
        }
    }
}
