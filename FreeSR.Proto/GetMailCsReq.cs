namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMailCsReq
	{
		[ProtoMember(15)] public int Start;
		[ProtoMember(12)] public int Stop;
	}
	
}
