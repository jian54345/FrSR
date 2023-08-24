namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class QuitBattleScRsp
	{
		[ProtoMember(9)] public int Retcode;
	}
	
}
