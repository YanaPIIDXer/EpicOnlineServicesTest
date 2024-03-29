// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Mods
{
	/// <summary>
	/// Input parameters for the <see cref="ModsInterface.EnumerateMods" /> Function.
	/// </summary>
	public class EnumerateModsOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the user for which the mod should be enumerated
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// Type of the mods to enumerate
		/// </summary>
		public ModEnumerationType Type { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct EnumerateModsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private ModEnumerationType m_Type;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public ModEnumerationType Type
		{
			set
			{
				m_Type = value;
			}
		}

		public void Set(EnumerateModsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ModsInterface.EnumeratemodsApiLatest;
				LocalUserId = other.LocalUserId;
				Type = other.Type;
			}
		}

		public void Set(object other)
		{
			Set(other as EnumerateModsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}