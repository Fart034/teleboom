// <auto-generated/>
using System;

namespace Telegram.Api.TL.Payments.Methods
{
	/// <summary>
	/// RCP method payments.sendPaymentForm.
	/// Returns <see cref="Telegram.Api.TL.TLPaymentsPaymentResult"/>
	/// </summary>
	public partial class TLPaymentsSendPaymentForm : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			RequestedInfoId = (1 << 0),
			ShippingOptionId = (1 << 1),
		}

		public bool HasRequestedInfoId { get { return Flags.HasFlag(Flag.RequestedInfoId); } set { Flags = value ? (Flags | Flag.RequestedInfoId) : (Flags & ~Flag.RequestedInfoId); } }
		public bool HasShippingOptionId { get { return Flags.HasFlag(Flag.ShippingOptionId); } set { Flags = value ? (Flags | Flag.ShippingOptionId) : (Flags & ~Flag.ShippingOptionId); } }

		public Flag Flags { get; set; }
		public Int32 MsgId { get; set; }
		public String RequestedInfoId { get; set; }
		public String ShippingOptionId { get; set; }
		public TLInputPaymentCredentialsBase Credentials { get; set; }

		public TLPaymentsSendPaymentForm() { }
		public TLPaymentsSendPaymentForm(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PaymentsSendPaymentForm; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			MsgId = from.ReadInt32();
			if (HasRequestedInfoId) RequestedInfoId = from.ReadString();
			if (HasShippingOptionId) ShippingOptionId = from.ReadString();
			Credentials = TLFactory.Read<TLInputPaymentCredentialsBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x2B8879B3);
			to.Write((Int32)Flags);
			to.Write(MsgId);
			if (HasRequestedInfoId) to.Write(RequestedInfoId);
			if (HasShippingOptionId) to.Write(ShippingOptionId);
			to.WriteObject(Credentials);
		}

		private void UpdateFlags()
		{
			HasRequestedInfoId = RequestedInfoId != null;
			HasShippingOptionId = ShippingOptionId != null;
		}
	}
}