// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	/// <summary>
	/// Structure containing details about a new message that must be dispatched to the game server.
	/// </summary>
	public class OnMessageToServerCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Caller-specified context data
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The message data that must be sent to the server
		/// </summary>
		public byte[] MessageData { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnMessageToServerCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				MessageData = other.Value.MessageData;
			}
		}

		public void Set(object other)
		{
			Set(other as OnMessageToServerCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct OnMessageToServerCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_MessageData;
		private uint m_MessageDataSizeBytes;

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public byte[] MessageData
		{
			get
			{
				byte[] value;
				Helper.TryMarshalGet(m_MessageData, out value, m_MessageDataSizeBytes);
				return value;
			}
		}
	}
}