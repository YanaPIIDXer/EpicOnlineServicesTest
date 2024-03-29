// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Output parameters for the <see cref="AuthInterface.Login" /> Function.
	/// </summary>
	public class LoginCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="AuthInterface.Login" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Epic Online Services Account ID of the local user who has logged in
		/// </summary>
		public EpicAccountId LocalUserId { get; private set; }

		/// <summary>
		/// Optional data returned in the middle of a <see cref="LoginCredentialType.DeviceCode" /> request
		/// </summary>
		public PinGrantInfo PinGrantInfo { get; private set; }

		/// <summary>
		/// If the user was not found with external auth credentials passed into <see cref="AuthInterface.Login" />, this continuance token can be passed to <see cref="AuthInterface.LinkAccount" /> to continue the flow.
		/// </summary>
		public ContinuanceToken ContinuanceToken { get; private set; }

		/// <summary>
		/// If the user trying to login is restricted from doing so, the ResultCode of this structure will be <see cref="Result.AuthAccountFeatureRestricted" />, and AccountFeatureRestrictedInfo will be populated with the data needed to get past the restriction
		/// </summary>
		public AccountFeatureRestrictedInfo AccountFeatureRestrictedInfo { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(LoginCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				PinGrantInfo = other.Value.PinGrantInfo;
				ContinuanceToken = other.Value.ContinuanceToken;
				AccountFeatureRestrictedInfo = other.Value.AccountFeatureRestrictedInfo;
			}
		}

		public void Set(object other)
		{
			Set(other as LoginCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LoginCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_PinGrantInfo;
		private System.IntPtr m_ContinuanceToken;
		private System.IntPtr m_AccountFeatureRestrictedInfo;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

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

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public PinGrantInfo PinGrantInfo
		{
			get
			{
				PinGrantInfo value;
				Helper.TryMarshalGet<PinGrantInfoInternal, PinGrantInfo>(m_PinGrantInfo, out value);
				return value;
			}
		}

		public ContinuanceToken ContinuanceToken
		{
			get
			{
				ContinuanceToken value;
				Helper.TryMarshalGet(m_ContinuanceToken, out value);
				return value;
			}
		}

		public AccountFeatureRestrictedInfo AccountFeatureRestrictedInfo
		{
			get
			{
				AccountFeatureRestrictedInfo value;
				Helper.TryMarshalGet<AccountFeatureRestrictedInfoInternal, AccountFeatureRestrictedInfo>(m_AccountFeatureRestrictedInfo, out value);
				return value;
			}
		}
	}
}