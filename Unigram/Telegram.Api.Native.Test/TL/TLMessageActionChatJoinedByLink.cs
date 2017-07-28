// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChatJoinedByLink : TLMessageActionBase 
	{
		public Int32 InviterId { get; set; }

		public TLMessageActionChatJoinedByLink() { }
		public TLMessageActionChatJoinedByLink(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChatJoinedByLink; } }

		public override void Read(TLBinaryReader from)
		{
			InviterId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(InviterId);
		}
	}
}