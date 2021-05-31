// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.IsUserInSession" /> function.
	/// </summary>
	public class IsUserInSessionOptions
	{
		/// <summary>
		/// Active session name to search within
		/// </summary>
		public string SessionName { get; set; }

		/// <summary>
		/// Product User ID to search for in the session
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct IsUserInSessionOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_SessionName;
		private System.IntPtr m_TargetUserId;

		public string SessionName
		{
			set
			{
				Helper.TryMarshalSet(ref m_SessionName, value);
			}
		}

		public ProductUserId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public void Set(IsUserInSessionOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionsInterface.IsuserinsessionApiLatest;
				SessionName = other.SessionName;
				TargetUserId = other.TargetUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as IsUserInSessionOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_SessionName);
			Helper.TryMarshalDispose(ref m_TargetUserId);
		}
	}
}