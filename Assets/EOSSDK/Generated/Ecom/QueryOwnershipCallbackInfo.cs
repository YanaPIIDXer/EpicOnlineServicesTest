// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Output parameters for the <see cref="EcomInterface.QueryOwnership" /> Function.
	/// </summary>
	public class QueryOwnershipCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="EcomInterface.QueryOwnership" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Epic Online Services Account ID of the local user whose ownership was queried
		/// </summary>
		public EpicAccountId LocalUserId { get; private set; }

		/// <summary>
		/// List of catalog items and their ownership status
		/// </summary>
		public ItemOwnership[] ItemOwnership { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(QueryOwnershipCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				ItemOwnership = other.Value.ItemOwnership;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryOwnershipCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryOwnershipCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_ItemOwnership;
		private uint m_ItemOwnershipCount;

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

		public ItemOwnership[] ItemOwnership
		{
			get
			{
				ItemOwnership[] value;
				Helper.TryMarshalGet<ItemOwnershipInternal, ItemOwnership>(m_ItemOwnership, out value, m_ItemOwnershipCount);
				return value;
			}
		}
	}
}