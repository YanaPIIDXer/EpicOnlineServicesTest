// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.GetOfferImageInfoCount" /> function.
	/// </summary>
	public class GetOfferImageInfoCountOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local user whose offer image is being accessed.
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the offer to get the images for.
		/// </summary>
		public string OfferId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetOfferImageInfoCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_OfferId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string OfferId
		{
			set
			{
				Helper.TryMarshalSet(ref m_OfferId, value);
			}
		}

		public void Set(GetOfferImageInfoCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.GetofferimageinfocountApiLatest;
				LocalUserId = other.LocalUserId;
				OfferId = other.OfferId;
			}
		}

		public void Set(object other)
		{
			Set(other as GetOfferImageInfoCountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_OfferId);
		}
	}
}