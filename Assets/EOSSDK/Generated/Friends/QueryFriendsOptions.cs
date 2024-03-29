// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// Input parameters for the <see cref="FriendsInterface.QueryFriends" /> function.
	/// </summary>
	public class QueryFriendsOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local, logged-in user whose friends list you want to retrieve
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryFriendsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(QueryFriendsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = FriendsInterface.QueryfriendsApiLatest;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryFriendsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}