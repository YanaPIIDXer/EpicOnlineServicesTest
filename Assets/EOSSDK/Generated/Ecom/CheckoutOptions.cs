// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.Checkout" /> function.
	/// </summary>
	public class CheckoutOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local user who is making the purchase
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The catalog namespace will be the current Sandbox ID (in <see cref="Platform.Options" />) unless overridden by this field
		/// </summary>
		public string OverrideCatalogNamespace { get; set; }

		/// <summary>
		/// An array of <see cref="CheckoutEntry" /> elements, each containing the details of a single offer
		/// </summary>
		public CheckoutEntry[] Entries { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CheckoutOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_OverrideCatalogNamespace;
		private uint m_EntryCount;
		private System.IntPtr m_Entries;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string OverrideCatalogNamespace
		{
			set
			{
				Helper.TryMarshalSet(ref m_OverrideCatalogNamespace, value);
			}
		}

		public CheckoutEntry[] Entries
		{
			set
			{
				Helper.TryMarshalSet<CheckoutEntryInternal, CheckoutEntry>(ref m_Entries, value, out m_EntryCount);
			}
		}

		public void Set(CheckoutOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.CheckoutApiLatest;
				LocalUserId = other.LocalUserId;
				OverrideCatalogNamespace = other.OverrideCatalogNamespace;
				Entries = other.Entries;
			}
		}

		public void Set(object other)
		{
			Set(other as CheckoutOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_OverrideCatalogNamespace);
			Helper.TryMarshalDispose(ref m_Entries);
		}
	}
}