namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleEventProperty
	{
		[ProtoMember(1)] public int Sp;
	}
	
}
