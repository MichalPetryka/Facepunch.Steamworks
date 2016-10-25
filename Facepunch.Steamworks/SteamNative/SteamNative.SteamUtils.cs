using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	public unsafe class SteamUtils
	{
		internal IntPtr _ptr;
		
		public SteamUtils( IntPtr pointer )
		{
			_ptr = pointer;
		}
		
		
		// bool
		public bool BOverlayNeedsPresent()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.BOverlayNeedsPresent( _ptr );
			else return Platform.Win64.ISteamUtils.BOverlayNeedsPresent( _ptr );
		}
		
		// SteamAPICall_t
		public SteamAPICall_t CheckFileSignature( string szFileName /*const char **/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.CheckFileSignature( _ptr, szFileName );
			else return Platform.Win64.ISteamUtils.CheckFileSignature( _ptr, szFileName );
		}
		
		// SteamAPICallFailure
		public SteamAPICallFailure GetAPICallFailureReason( SteamAPICall_t hSteamAPICall /*SteamAPICall_t*/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetAPICallFailureReason( _ptr, hSteamAPICall );
			else return Platform.Win64.ISteamUtils.GetAPICallFailureReason( _ptr, hSteamAPICall );
		}
		
		// bool
		public bool GetAPICallResult( SteamAPICall_t hSteamAPICall /*SteamAPICall_t*/, IntPtr pCallback /*void **/, int cubCallback /*int*/, int iCallbackExpected /*int*/, out bool pbFailed /*bool **/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetAPICallResult( _ptr, hSteamAPICall, (IntPtr) pCallback, cubCallback, iCallbackExpected, out pbFailed );
			else return Platform.Win64.ISteamUtils.GetAPICallResult( _ptr, hSteamAPICall, (IntPtr) pCallback, cubCallback, iCallbackExpected, out pbFailed );
		}
		
		// uint
		public uint GetAppID()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetAppID( _ptr );
			else return Platform.Win64.ISteamUtils.GetAppID( _ptr );
		}
		
		// Universe
		public Universe GetConnectedUniverse()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetConnectedUniverse( _ptr );
			else return Platform.Win64.ISteamUtils.GetConnectedUniverse( _ptr );
		}
		
		// bool
		public bool GetCSERIPPort( out uint unIP /*uint32 **/, out ushort usPort /*uint16 **/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetCSERIPPort( _ptr, out unIP, out usPort );
			else return Platform.Win64.ISteamUtils.GetCSERIPPort( _ptr, out unIP, out usPort );
		}
		
		// byte
		public byte GetCurrentBatteryPower()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetCurrentBatteryPower( _ptr );
			else return Platform.Win64.ISteamUtils.GetCurrentBatteryPower( _ptr );
		}
		
		// bool
		// with: Detect_StringFetch True
		public string GetEnteredGamepadTextInput()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			bool bSuccess = default( bool );
			System.Text.StringBuilder pchText_sb = new System.Text.StringBuilder( 4096 );
			uint cchText = 4096;
			if ( Platform.IsWindows32 ) bSuccess = Platform.Win32.ISteamUtils.GetEnteredGamepadTextInput( _ptr, pchText_sb, cchText );
			else bSuccess = Platform.Win64.ISteamUtils.GetEnteredGamepadTextInput( _ptr, pchText_sb, cchText );
			if ( !bSuccess ) return null;
			return pchText_sb.ToString();
		}
		
		// uint
		public uint GetEnteredGamepadTextLength()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetEnteredGamepadTextLength( _ptr );
			else return Platform.Win64.ISteamUtils.GetEnteredGamepadTextLength( _ptr );
		}
		
		// bool
		public bool GetImageRGBA( int iImage /*int*/, IntPtr pubDest /*uint8 **/, int nDestBufferSize /*int*/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetImageRGBA( _ptr, iImage, (IntPtr) pubDest, nDestBufferSize );
			else return Platform.Win64.ISteamUtils.GetImageRGBA( _ptr, iImage, (IntPtr) pubDest, nDestBufferSize );
		}
		
		// bool
		public bool GetImageSize( int iImage /*int*/, out uint pnWidth /*uint32 **/, out uint pnHeight /*uint32 **/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetImageSize( _ptr, iImage, out pnWidth, out pnHeight );
			else return Platform.Win64.ISteamUtils.GetImageSize( _ptr, iImage, out pnWidth, out pnHeight );
		}
		
		// uint
		public uint GetIPCCallCount()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetIPCCallCount( _ptr );
			else return Platform.Win64.ISteamUtils.GetIPCCallCount( _ptr );
		}
		
		// string
		// with: Detect_StringReturn
		public string GetIPCountry()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			IntPtr string_pointer;
			if ( Platform.IsWindows32 ) string_pointer = Platform.Win32.ISteamUtils.GetIPCountry( _ptr );
			else string_pointer = Platform.Win64.ISteamUtils.GetIPCountry( _ptr );
			return Marshal.PtrToStringAnsi( string_pointer );
		}
		
		// uint
		public uint GetSecondsSinceAppActive()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetSecondsSinceAppActive( _ptr );
			else return Platform.Win64.ISteamUtils.GetSecondsSinceAppActive( _ptr );
		}
		
		// uint
		public uint GetSecondsSinceComputerActive()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetSecondsSinceComputerActive( _ptr );
			else return Platform.Win64.ISteamUtils.GetSecondsSinceComputerActive( _ptr );
		}
		
		// uint
		public uint GetServerRealTime()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.GetServerRealTime( _ptr );
			else return Platform.Win64.ISteamUtils.GetServerRealTime( _ptr );
		}
		
		// string
		// with: Detect_StringReturn
		public string GetSteamUILanguage()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			IntPtr string_pointer;
			if ( Platform.IsWindows32 ) string_pointer = Platform.Win32.ISteamUtils.GetSteamUILanguage( _ptr );
			else string_pointer = Platform.Win64.ISteamUtils.GetSteamUILanguage( _ptr );
			return Marshal.PtrToStringAnsi( string_pointer );
		}
		
		// bool
		public bool IsAPICallCompleted( SteamAPICall_t hSteamAPICall /*SteamAPICall_t*/, out bool pbFailed /*bool **/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.IsAPICallCompleted( _ptr, hSteamAPICall, out pbFailed );
			else return Platform.Win64.ISteamUtils.IsAPICallCompleted( _ptr, hSteamAPICall, out pbFailed );
		}
		
		// bool
		public bool IsOverlayEnabled()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.IsOverlayEnabled( _ptr );
			else return Platform.Win64.ISteamUtils.IsOverlayEnabled( _ptr );
		}
		
		// bool
		public bool IsSteamInBigPictureMode()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.IsSteamInBigPictureMode( _ptr );
			else return Platform.Win64.ISteamUtils.IsSteamInBigPictureMode( _ptr );
		}
		
		// bool
		public bool IsSteamRunningInVR()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.IsSteamRunningInVR( _ptr );
			else return Platform.Win64.ISteamUtils.IsSteamRunningInVR( _ptr );
		}
		
		// void
		public void SetOverlayNotificationInset( int nHorizontalInset /*int*/, int nVerticalInset /*int*/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) Platform.Win32.ISteamUtils.SetOverlayNotificationInset( _ptr, nHorizontalInset, nVerticalInset );
			else Platform.Win64.ISteamUtils.SetOverlayNotificationInset( _ptr, nHorizontalInset, nVerticalInset );
		}
		
		// void
		public void SetOverlayNotificationPosition( NotificationPosition eNotificationPosition /*ENotificationPosition*/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) Platform.Win32.ISteamUtils.SetOverlayNotificationPosition( _ptr, eNotificationPosition );
			else Platform.Win64.ISteamUtils.SetOverlayNotificationPosition( _ptr, eNotificationPosition );
		}
		
		// void
		public void SetWarningMessageHook( IntPtr pFunction /*SteamAPIWarningMessageHook_t*/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) Platform.Win32.ISteamUtils.SetWarningMessageHook( _ptr, (IntPtr) pFunction );
			else Platform.Win64.ISteamUtils.SetWarningMessageHook( _ptr, (IntPtr) pFunction );
		}
		
		// bool
		public bool ShowGamepadTextInput( GamepadTextInputMode eInputMode /*EGamepadTextInputMode*/, GamepadTextInputLineMode eLineInputMode /*EGamepadTextInputLineMode*/, string pchDescription /*const char **/, uint unCharMax /*uint32*/, string pchExistingText /*const char **/ )
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) return Platform.Win32.ISteamUtils.ShowGamepadTextInput( _ptr, eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText );
			else return Platform.Win64.ISteamUtils.ShowGamepadTextInput( _ptr, eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText );
		}
		
		// void
		public void StartVRDashboard()
		{
			if ( _ptr == IntPtr.Zero ) throw new System.Exception( "Internal pointer is null"); // 
			
			if ( Platform.IsWindows32 ) Platform.Win32.ISteamUtils.StartVRDashboard( _ptr );
			else Platform.Win64.ISteamUtils.StartVRDashboard( _ptr );
		}
		
	}
}