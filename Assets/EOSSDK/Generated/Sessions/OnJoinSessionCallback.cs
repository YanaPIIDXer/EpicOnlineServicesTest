// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="SessionsInterface.JoinSession" />
	/// </summary>
	/// <param name="data">A <see cref="JoinSessionCallbackInfo" /> containing the output information and result</param>
	public delegate void OnJoinSessionCallback(JoinSessionCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnJoinSessionCallbackInternal(System.IntPtr data);
}