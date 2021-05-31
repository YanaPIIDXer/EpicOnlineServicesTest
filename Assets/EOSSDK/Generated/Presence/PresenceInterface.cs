// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	public sealed partial class PresenceInterface : Handle
	{
		public PresenceInterface()
		{
		}

		public PresenceInterface(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="AddNotifyJoinGameAccepted" /> API.
		/// </summary>
		public const int AddnotifyjoingameacceptedApiLatest = 2;

		public const int AddnotifyonpresencechangedApiLatest = 1;

		public const int CopypresenceApiLatest = 2;

		public const int CreatepresencemodificationApiLatest = 1;

		/// <summary>
		/// The maximum allowed length a data's key may be. This value is subject to change and data structures should be designed to allow for greater numbers than this.
		/// </summary>
		public const int DataMaxKeyLength = 64;

		/// <summary>
		/// The maximum of allowed individual pieces of data a user may have. This value is subject to change and data structures should be designed to allow for greater
		/// numbers than this.
		/// </summary>
		public const int DataMaxKeys = 32;

		/// <summary>
		/// The maximum allowed length a data's value may be. This value is subject to change and data structures should be designed to allow for greater numbers than this.
		/// </summary>
		public const int DataMaxValueLength = 255;

		public const int DatarecordApiLatest = 1;

		/// <summary>
		/// DEPRECATED! Use <see cref="PresenceModification.PresencemodificationDeletedataApiLatest" /> instead.
		/// </summary>
		public const int DeletedataApiLatest = PresenceModification.PresencemodificationDeletedataApiLatest;

		public const int GetjoininfoApiLatest = 1;

		public const int HaspresenceApiLatest = 1;

		public const int InfoApiLatest = 2;

		public const int QuerypresenceApiLatest = 1;

		/// <summary>
		/// The maximum allowed length a user's rich text string may be. This value is subject to change and data structures should be designed to allow for greater numbers
		/// than this.
		/// </summary>
		public const int RichTextMaxValueLength = 255;

		/// <summary>
		/// DEPRECATED! Use <see cref="PresenceModification.PresencemodificationSetdataApiLatest" /> instead.
		/// </summary>
		public const int SetdataApiLatest = PresenceModification.PresencemodificationSetdataApiLatest;

		public const int SetpresenceApiLatest = 1;

		/// <summary>
		/// DEPRECATED! Use <see cref="PresenceModification.PresencemodificationSetrawrichtextApiLatest" /> instead.
		/// </summary>
		public const int SetrawrichtextApiLatest = PresenceModification.PresencemodificationSetrawrichtextApiLatest;

		/// <summary>
		/// DEPRECATED! Use <see cref="PresenceModification.PresencemodificationSetstatusApiLatest" /> instead.
		/// </summary>
		public const int SetstatusApiLatest = PresenceModification.PresencemodificationSetstatusApiLatest;

		/// <summary>
		/// Register to receive notifications when a user accepts a join game option via the social overlay.
		/// @note must call RemoveNotifyJoinGameAccepted to remove the notification
		/// </summary>
		/// <param name="options">Structure containing information about the request.</param>
		/// <param name="clientData">Arbitrary data that is passed back to you in the CompletionDelegate.</param>
		/// <param name="notificationFn">A callback that is fired when a a notification is received.</param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyJoinGameAccepted(AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddNotifyJoinGameAcceptedOptionsInternal, AddNotifyJoinGameAcceptedOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var notificationFnInternal = new OnJoinGameAcceptedCallbackInternal(OnJoinGameAcceptedCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, notificationFn, notificationFnInternal);

			var funcResult = Bindings.EOS_Presence_AddNotifyJoinGameAccepted(InnerHandle, optionsAddress, clientDataAddress, notificationFnInternal);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Register to receive notifications when presence changes. If the returned NotificationId is valid, you must call RemoveNotifyOnPresenceChanged when you no longer wish to
		/// have your NotificationHandler called
		/// <seealso cref="Common.InvalidNotificationid" />
		/// <seealso cref="RemoveNotifyOnPresenceChanged" />
		/// </summary>
		/// <param name="clientData">Data the is returned to when NotificationHandler is invoked</param>
		/// <param name="notificationHandler">The callback to be fired when a presence change occurs</param>
		/// <returns>
		/// Notification ID representing the registered callback if successful, an invalid NotificationId if not
		/// </returns>
		public ulong AddNotifyOnPresenceChanged(AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddNotifyOnPresenceChangedOptionsInternal, AddNotifyOnPresenceChangedOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var notificationHandlerInternal = new OnPresenceChangedCallbackInternal(OnPresenceChangedCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, notificationHandler, notificationHandlerInternal);

			var funcResult = Bindings.EOS_Presence_AddNotifyOnPresenceChanged(InnerHandle, optionsAddress, clientDataAddress, notificationHandlerInternal);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Get a user's cached presence object. If successful, this data must be released by calling <see cref="Release" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Object containing properties related to who is requesting presence and for what user</param>
		/// <param name="outPresence">A pointer to a pointer of Presence Info. If the returned result is success, this will be set to data that must be later released, otherwise this will be set to NULL</param>
		/// <returns>
		/// Success if we have cached data, or an error result if the request was invalid or we do not have cached data.
		/// </returns>
		public Result CopyPresence(CopyPresenceOptions options, out Info outPresence)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<CopyPresenceOptionsInternal, CopyPresenceOptions>(ref optionsAddress, options);

			var outPresenceAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_Presence_CopyPresence(InnerHandle, optionsAddress, ref outPresenceAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			if (Helper.TryMarshalGet<InfoInternal, Info>(outPresenceAddress, out outPresence))
			{
				Bindings.EOS_Presence_Info_Release(outPresenceAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// Creates a presence modification handle. This handle can used to add multiple changes to your presence that can be applied with <see cref="SetPresence" />.
		/// The resulting handle must be released by calling <see cref="PresenceModification.Release" /> once it has been passed to <see cref="SetPresence" />.
		/// <seealso cref="PresenceModification.Release" />
		/// <seealso cref="SetPresence" />
		/// <seealso cref="PresenceModification.SetStatus" />
		/// <seealso cref="PresenceModification.SetRawRichText" />
		/// <seealso cref="PresenceModification.SetData" />
		/// <seealso cref="PresenceModification.DeleteData" />
		/// </summary>
		/// <param name="options">Object containing properties related to the user modifying their presence</param>
		/// <param name="outPresenceModificationHandle">Pointer to a Presence Modification Handle to be set if successful</param>
		/// <returns>
		/// Success if we successfully created the Presence Modification Handle pointed at in OutPresenceModificationHandle, or an error result if the input data was invalid
		/// </returns>
		public Result CreatePresenceModification(CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<CreatePresenceModificationOptionsInternal, CreatePresenceModificationOptions>(ref optionsAddress, options);

			var outPresenceModificationHandleAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_Presence_CreatePresenceModification(InnerHandle, optionsAddress, ref outPresenceModificationHandleAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryMarshalGet(outPresenceModificationHandleAddress, out outPresenceModificationHandle);

			return funcResult;
		}

		/// <summary>
		/// Gets a join info custom game-data string for a specific user. This is a helper function for reading the presence data related to how a user can be joined.
		/// Its meaning is entirely application dependent.
		/// 
		/// This value will be valid only after a QueryPresence call has successfully completed.
		/// <seealso cref="PresenceModification.PresencemodificationJoininfoMaxLength" />
		/// </summary>
		/// <param name="options">Object containing an associated user</param>
		/// <param name="outBuffer">The buffer into which the character data should be written. The buffer must be long enough to hold a string of <see cref="PresenceModification.PresencemodificationJoininfoMaxLength" />.</param>
		/// <param name="inOutBufferLength">
		/// Used as an input to define the OutBuffer length.
		/// The input buffer should include enough space to be null-terminated.
		/// When the function returns, this parameter will be filled with the length of the string copied into OutBuffer.
		/// </param>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the location string was copied into the OutBuffer.
		/// <see cref="Result.Success" /> if the information is available and passed out in OutBuffer
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.NotFound" /> if there is user or the location string was not found.
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the location string. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public Result GetJoinInfo(GetJoinInfoOptions options, out string outBuffer)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<GetJoinInfoOptionsInternal, GetJoinInfoOptions>(ref optionsAddress, options);

			System.IntPtr outBufferAddress = System.IntPtr.Zero;
			int inOutBufferLength = PresenceModification.PresencemodificationJoininfoMaxLength + 1;
			Helper.TryMarshalAllocate(ref outBufferAddress, inOutBufferLength, out _);

			var funcResult = Bindings.EOS_Presence_GetJoinInfo(InnerHandle, optionsAddress, outBufferAddress, ref inOutBufferLength);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryMarshalGet(outBufferAddress, out outBuffer);
			Helper.TryMarshalDispose(ref outBufferAddress);

			return funcResult;
		}

		/// <summary>
		/// Check if we already have presence for a user
		/// </summary>
		/// <param name="options">Object containing properties related to who is requesting presence and for what user</param>
		/// <returns>
		/// true if we have presence for the requested user, or false if the request was invalid or we do not have cached data
		/// </returns>
		public bool HasPresence(HasPresenceOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<HasPresenceOptionsInternal, HasPresenceOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_Presence_HasPresence(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			bool funcResultReturn;
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Query a user's presence. This must complete successfully before CopyPresence will have valid results. If HasPresence returns true for a remote
		/// user, this does not need to be called.
		/// </summary>
		/// <param name="options">Object containing properties related to who is querying presence and for what user</param>
		/// <param name="clientData">Optional pointer to help track this request, that is returned in the completion callback</param>
		/// <param name="completionDelegate">Pointer to a function that handles receiving the completion information</param>
		public void QueryPresence(QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<QueryPresenceOptionsInternal, QueryPresenceOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var completionDelegateInternal = new OnQueryPresenceCompleteCallbackInternal(OnQueryPresenceCompleteCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			Bindings.EOS_Presence_QueryPresence(InnerHandle, optionsAddress, clientDataAddress, completionDelegateInternal);

			Helper.TryMarshalDispose(ref optionsAddress);
		}

		/// <summary>
		/// Unregister from receiving notifications when a user accepts a join game option via the social overlay.
		/// </summary>
		/// <param name="inId">Handle representing the registered callback</param>
		public void RemoveNotifyJoinGameAccepted(ulong inId)
		{
			Helper.TryRemoveCallbackByNotificationId(inId);

			Bindings.EOS_Presence_RemoveNotifyJoinGameAccepted(InnerHandle, inId);
		}

		/// <summary>
		/// Unregister a previously bound notification handler from receiving presence update notifications
		/// </summary>
		/// <param name="notificationId">The Notification ID representing the registered callback</param>
		public void RemoveNotifyOnPresenceChanged(ulong notificationId)
		{
			Helper.TryRemoveCallbackByNotificationId(notificationId);

			Bindings.EOS_Presence_RemoveNotifyOnPresenceChanged(InnerHandle, notificationId);
		}

		/// <summary>
		/// Sets your new presence with the data applied to a PresenceModificationHandle. The PresenceModificationHandle can be released safely after calling this function.
		/// <seealso cref="CreatePresenceModification" />
		/// <seealso cref="PresenceModification.Release" />
		/// </summary>
		/// <param name="options">Object containing a PresenceModificationHandle and associated user data</param>
		/// <param name="clientData">Optional pointer to help track this request, that is returned in the completion callback</param>
		/// <param name="completionDelegate">Pointer to a function that handles receiving the completion information</param>
		public void SetPresence(SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<SetPresenceOptionsInternal, SetPresenceOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var completionDelegateInternal = new SetPresenceCompleteCallbackInternal(SetPresenceCompleteCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			Bindings.EOS_Presence_SetPresence(InnerHandle, optionsAddress, clientDataAddress, completionDelegateInternal);

			Helper.TryMarshalDispose(ref optionsAddress);
		}

		[MonoPInvokeCallback(typeof(OnJoinGameAcceptedCallbackInternal))]
		internal static void OnJoinGameAcceptedCallbackInternalImplementation(System.IntPtr data)
		{
			OnJoinGameAcceptedCallback callback;
			JoinGameAcceptedCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnJoinGameAcceptedCallback, JoinGameAcceptedCallbackInfoInternal, JoinGameAcceptedCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnPresenceChangedCallbackInternal))]
		internal static void OnPresenceChangedCallbackInternalImplementation(System.IntPtr data)
		{
			OnPresenceChangedCallback callback;
			PresenceChangedCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnPresenceChangedCallback, PresenceChangedCallbackInfoInternal, PresenceChangedCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryPresenceCompleteCallbackInternal))]
		internal static void OnQueryPresenceCompleteCallbackInternalImplementation(System.IntPtr data)
		{
			OnQueryPresenceCompleteCallback callback;
			QueryPresenceCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnQueryPresenceCompleteCallback, QueryPresenceCallbackInfoInternal, QueryPresenceCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(SetPresenceCompleteCallbackInternal))]
		internal static void SetPresenceCompleteCallbackInternalImplementation(System.IntPtr data)
		{
			SetPresenceCompleteCallback callback;
			SetPresenceCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<SetPresenceCompleteCallback, SetPresenceCallbackInfoInternal, SetPresenceCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}
	}
}