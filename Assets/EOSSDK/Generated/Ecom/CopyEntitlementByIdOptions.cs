// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyEntitlementById" /> function.
	/// </summary>
	public class CopyEntitlementByIdOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local user whose entitlement is being copied
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// ID of the entitlement to retrieve from the cache
		/// </summary>
		public string EntitlementId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyEntitlementByIdOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_EntitlementId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string EntitlementId
		{
			set
			{
				Helper.TryMarshalSet(ref m_EntitlementId, value);
			}
		}

		public void Set(CopyEntitlementByIdOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.CopyentitlementbyidApiLatest;
				LocalUserId = other.LocalUserId;
				EntitlementId = other.EntitlementId;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyEntitlementByIdOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_EntitlementId);
		}
	}
}