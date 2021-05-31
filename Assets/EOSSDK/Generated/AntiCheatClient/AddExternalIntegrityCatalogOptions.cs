// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	public class AddExternalIntegrityCatalogOptions
	{
		/// <summary>
		/// UTF-8 path to the .bin catalog file to add
		/// </summary>
		public string PathToBinFile { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddExternalIntegrityCatalogOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_PathToBinFile;

		public string PathToBinFile
		{
			set
			{
				Helper.TryMarshalSet(ref m_PathToBinFile, value);
			}
		}

		public void Set(AddExternalIntegrityCatalogOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatClientInterface.AddexternalintegritycatalogApiLatest;
				PathToBinFile = other.PathToBinFile;
			}
		}

		public void Set(object other)
		{
			Set(other as AddExternalIntegrityCatalogOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_PathToBinFile);
		}
	}
}