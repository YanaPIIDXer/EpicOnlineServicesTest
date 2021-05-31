// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyInterface.RejectInvite" /> function.
	/// </summary>
	public class RejectInviteOptions
	{
		/// <summary>
		/// The ID of the lobby associated with the invitation
		/// </summary>
		public string InviteId { get; set; }

		/// <summary>
		/// The Product User ID of the local user who is rejecting the invitation
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct RejectInviteOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_InviteId;
		private System.IntPtr m_LocalUserId;

		public string InviteId
		{
			set
			{
				Helper.TryMarshalSet(ref m_InviteId, value);
			}
		}

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(RejectInviteOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyInterface.RejectinviteApiLatest;
				InviteId = other.InviteId;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as RejectInviteOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_InviteId);
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}