namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetClientPausedScRsp
	{
		[ProtoMember(1)] public bool Paused;
		[ProtoMember(8)] public int Retcode;
	}
	
}
