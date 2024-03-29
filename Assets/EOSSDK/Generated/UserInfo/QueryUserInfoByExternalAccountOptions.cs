// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Input parameters for the <see cref="UserInfoInterface.QueryUserInfoByExternalAccount" /> function.
	/// </summary>
	public class QueryUserInfoByExternalAccountOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local player requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// External account ID of the user whose information is being retrieved
		/// </summary>
		public string ExternalAccountId { get; set; }

		/// <summary>
		/// Account type of the external user info to query
		/// </summary>
		public ExternalAccountType AccountType { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryUserInfoByExternalAccountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_ExternalAccountId;
		private ExternalAccountType m_AccountType;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string ExternalAccountId
		{
			set
			{
				Helper.TryMarshalSet(ref m_ExternalAccountId, value);
			}
		}

		public ExternalAccountType AccountType
		{
			set
			{
				m_AccountType = value;
			}
		}

		public void Set(QueryUserInfoByExternalAccountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = UserInfoInterface.QueryuserinfobyexternalaccountApiLatest;
				LocalUserId = other.LocalUserId;
				ExternalAccountId = other.ExternalAccountId;
				AccountType = other.AccountType;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryUserInfoByExternalAccountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_ExternalAccountId);
		}
	}
}