namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptedPamMissionExpireCsReq
	{
		[ProtoMember(1)] public int MainMissionId;
	}
	
}
