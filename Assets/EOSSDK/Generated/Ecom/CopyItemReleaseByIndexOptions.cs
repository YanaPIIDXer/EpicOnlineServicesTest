// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyItemReleaseByIndex" /> function.
	/// </summary>
	public class CopyItemReleaseByIndexOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local user whose item release is being copied
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the item to get the releases for.
		/// </summary>
		public string ItemId { get; set; }

		/// <summary>
		/// The index of the release to get.
		/// </summary>
		public uint ReleaseIndex { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyItemReleaseByIndexOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_ItemId;
		private uint m_ReleaseIndex;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string ItemId
		{
			set
			{
				Helper.TryMarshalSet(ref m_ItemId, value);
			}
		}

		public uint ReleaseIndex
		{
			set
			{
				m_ReleaseIndex = value;
			}
		}

		public void Set(CopyItemReleaseByIndexOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.CopyitemreleasebyindexApiLatest;
				LocalUserId = other.LocalUserId;
				ItemId = other.ItemId;
				ReleaseIndex = other.ReleaseIndex;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyItemReleaseByIndexOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_ItemId);
		}
	}
}