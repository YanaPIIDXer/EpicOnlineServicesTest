// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// Input parameters for the <see cref="FriendsInterface.GetFriendsCount" /> function.
	/// </summary>
	public class GetFriendsCountOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the user whose friends should be counted
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetFriendsCountOptionsInternal : ISettable, System.IDisposable
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

		public void Set(GetFriendsCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = FriendsInterface.GetfriendscountApiLatest;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as GetFriendsCountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}