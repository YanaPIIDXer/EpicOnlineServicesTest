// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	public class LogPlayerTakeDamageOptions
	{
		/// <summary>
		/// Locally unique value used in RegisterClient/RegisterPeer
		/// </summary>
		public System.IntPtr VictimPlayerHandle { get; set; }

		/// <summary>
		/// Victim player's current world position as a 3D vector
		/// </summary>
		public Vec3f VictimPlayerPosition { get; set; }

		/// <summary>
		/// Victim player's view rotation as a quaternion
		/// </summary>
		public Quat VictimPlayerViewRotation { get; set; }

		/// <summary>
		/// Locally unique value used in RegisterClient/RegisterPeer
		/// </summary>
		public System.IntPtr AttackerPlayerHandle { get; set; }

		/// <summary>
		/// Attacker player's current world position as a 3D vector
		/// </summary>
		public Vec3f AttackerPlayerPosition { get; set; }

		/// <summary>
		/// Attacker player's view rotation as a quaternion
		/// </summary>
		public Quat AttackerPlayerViewRotation { get; set; }

		/// <summary>
		/// True if the damage was applied instantly at the time of attack from the game
		/// simulation's perspective, otherwise false (simulated ballistics, arrow, etc).
		/// </summary>
		public bool IsHitscanAttack { get; set; }

		/// <summary>
		/// True if there is a visible line of sight between the attacker and the victim at the time
		/// that damage is being applied, false if there is an obstacle like a wall or terrain in
		/// the way. For some situations like melee or hitscan weapons this is trivially
		/// true, for others like projectiles with simulated physics it may not be e.g. a player
		/// could fire a slow moving projectile and then move behind cover before it strikes.
		/// </summary>
		public bool HasLineOfSight { get; set; }

		/// <summary>
		/// True if this was a critical hit that causes extra damage (e.g. headshot)
		/// </summary>
		public bool IsCriticalHit { get; set; }

		/// <summary>
		/// Identifier of the victim bone hit in this damage event
		/// </summary>
		public uint HitBoneId { get; set; }

		/// <summary>
		/// Number of health points that the victim lost due to this damage event
		/// </summary>
		public float DamageTaken { get; set; }

		/// <summary>
		/// Number of health points that the victim has remaining after this damage event
		/// </summary>
		public float HealthRemaining { get; set; }

		/// <summary>
		/// Source of the damage event
		/// </summary>
		public AntiCheatCommonPlayerTakeDamageSource DamageSource { get; set; }

		/// <summary>
		/// Type of the damage being applied
		/// </summary>
		public AntiCheatCommonPlayerTakeDamageType DamageType { get; set; }

		/// <summary>
		/// Result of the damage for the victim, if any
		/// </summary>
		public AntiCheatCommonPlayerTakeDamageResult DamageResult { get; set; }

		/// <summary>
		/// PlayerUseWeaponData associated with this damage event if available, otherwise NULL
		/// </summary>
		public LogPlayerUseWeaponData PlayerUseWeaponData { get; set; }

		/// <summary>
		/// Time in milliseconds since the PlayerUseWeaponData event occurred if available, otherwise 0
		/// </summary>
		public uint TimeSincePlayerUseWeaponMs { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LogPlayerTakeDamageOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_VictimPlayerHandle;
		private System.IntPtr m_VictimPlayerPosition;
		private System.IntPtr m_VictimPlayerViewRotation;
		private System.IntPtr m_AttackerPlayerHandle;
		private System.IntPtr m_AttackerPlayerPosition;
		private System.IntPtr m_AttackerPlayerViewRotation;
		private int m_IsHitscanAttack;
		private int m_HasLineOfSight;
		private int m_IsCriticalHit;
		private uint m_HitBoneId;
		private float m_DamageTaken;
		private float m_HealthRemaining;
		private AntiCheatCommonPlayerTakeDamageSource m_DamageSource;
		private AntiCheatCommonPlayerTakeDamageType m_DamageType;
		private AntiCheatCommonPlayerTakeDamageResult m_DamageResult;
		private System.IntPtr m_PlayerUseWeaponData;
		private uint m_TimeSincePlayerUseWeaponMs;

		public System.IntPtr VictimPlayerHandle
		{
			set
			{
				m_VictimPlayerHandle = value;
			}
		}

		public Vec3f VictimPlayerPosition
		{
			set
			{
				Helper.TryMarshalSet<Vec3fInternal, Vec3f>(ref m_VictimPlayerPosition, value);
			}
		}

		public Quat VictimPlayerViewRotation
		{
			set
			{
				Helper.TryMarshalSet<QuatInternal, Quat>(ref m_VictimPlayerViewRotation, value);
			}
		}

		public System.IntPtr AttackerPlayerHandle
		{
			set
			{
				m_AttackerPlayerHandle = value;
			}
		}

		public Vec3f AttackerPlayerPosition
		{
			set
			{
				Helper.TryMarshalSet<Vec3fInternal, Vec3f>(ref m_AttackerPlayerPosition, value);
			}
		}

		public Quat AttackerPlayerViewRotation
		{
			set
			{
				Helper.TryMarshalSet<QuatInternal, Quat>(ref m_AttackerPlayerViewRotation, value);
			}
		}

		public bool IsHitscanAttack
		{
			set
			{
				Helper.TryMarshalSet(ref m_IsHitscanAttack, value);
			}
		}

		public bool HasLineOfSight
		{
			set
			{
				Helper.TryMarshalSet(ref m_HasLineOfSight, value);
			}
		}

		public bool IsCriticalHit
		{
			set
			{
				Helper.TryMarshalSet(ref m_IsCriticalHit, value);
			}
		}

		public uint HitBoneId
		{
			set
			{
				m_HitBoneId = value;
			}
		}

		public float DamageTaken
		{
			set
			{
				m_DamageTaken = value;
			}
		}

		public float HealthRemaining
		{
			set
			{
				m_HealthRemaining = value;
			}
		}

		public AntiCheatCommonPlayerTakeDamageSource DamageSource
		{
			set
			{
				m_DamageSource = value;
			}
		}

		public AntiCheatCommonPlayerTakeDamageType DamageType
		{
			set
			{
				m_DamageType = value;
			}
		}

		public AntiCheatCommonPlayerTakeDamageResult DamageResult
		{
			set
			{
				m_DamageResult = value;
			}
		}

		public LogPlayerUseWeaponData PlayerUseWeaponData
		{
			set
			{
				Helper.TryMarshalSet<LogPlayerUseWeaponDataInternal, LogPlayerUseWeaponData>(ref m_PlayerUseWeaponData, value);
			}
		}

		public uint TimeSincePlayerUseWeaponMs
		{
			set
			{
				m_TimeSincePlayerUseWeaponMs = value;
			}
		}

		public void Set(LogPlayerTakeDamageOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatCommonInterface.LogplayertakedamageApiLatest;
				VictimPlayerHandle = other.VictimPlayerHandle;
				VictimPlayerPosition = other.VictimPlayerPosition;
				VictimPlayerViewRotation = other.VictimPlayerViewRotation;
				AttackerPlayerHandle = other.AttackerPlayerHandle;
				AttackerPlayerPosition = other.AttackerPlayerPosition;
				AttackerPlayerViewRotation = other.AttackerPlayerViewRotation;
				IsHitscanAttack = other.IsHitscanAttack;
				HasLineOfSight = other.HasLineOfSight;
				IsCriticalHit = other.IsCriticalHit;
				HitBoneId = other.HitBoneId;
				DamageTaken = other.DamageTaken;
				HealthRemaining = other.HealthRemaining;
				DamageSource = other.DamageSource;
				DamageType = other.DamageType;
				DamageResult = other.DamageResult;
				PlayerUseWeaponData = other.PlayerUseWeaponData;
				TimeSincePlayerUseWeaponMs = other.TimeSincePlayerUseWeaponMs;
			}
		}

		public void Set(object other)
		{
			Set(other as LogPlayerTakeDamageOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_VictimPlayerHandle);
			Helper.TryMarshalDispose(ref m_VictimPlayerPosition);
			Helper.TryMarshalDispose(ref m_VictimPlayerViewRotation);
			Helper.TryMarshalDispose(ref m_AttackerPlayerHandle);
			Helper.TryMarshalDispose(ref m_AttackerPlayerPosition);
			Helper.TryMarshalDispose(ref m_AttackerPlayerViewRotation);
			Helper.TryMarshalDispose(ref m_PlayerUseWeaponData);
		}
	}
}