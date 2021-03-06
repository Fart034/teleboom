// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChannelPinnedMessage : TLUpdateBase 
	{
		public Int32 ChannelId { get; set; }
		public Int32 Id { get; set; }

		public TLUpdateChannelPinnedMessage() { }
		public TLUpdateChannelPinnedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelPinnedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			ChannelId = from.ReadInt32();
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x98592475);
			to.Write(ChannelId);
			to.Write(Id);
		}
	}
}