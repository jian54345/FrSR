namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GachaItem
	{
		[ProtoMember(10)] public bool IsNew;
		[ProtoMember(13)] public ItemList Transfer_Item_List;
		[ProtoMember(9)] public Item Item;
		[ProtoMember(2)] public ItemList Token_Item;
	}
	
}
