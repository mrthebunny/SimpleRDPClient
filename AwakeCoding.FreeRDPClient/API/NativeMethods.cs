// Warning: <unknown> 27: Could not locate include file winpr/windows.h
// Warning: <unknown> 30: Could not locate include file freerdp/api.h
// Warning: <unknown> 32: Could not locate include file freerdp/freerdp.h
// Warning: <unknown> 34: Could not locate include file freerdp/gdi/gdi.h
// Warning: <unknown> 36: Could not locate include file freerdp/gdi/dc.h
// Warning: <unknown> 38: Could not locate include file freerdp/gdi/region.h
// Warning: <unknown> 40: Could not locate include file freerdp/cache/cache.h
// Warning: <unknown> 42: Could not locate include file freerdp/codec/color.h
// Warning: <unknown> 44: Could not locate include file freerdp/utils/debug.h
// Warning: <unknown> 46: Could not locate include file freerdp/channels/channels.h
// Warning: <unknown> 48: Could not locate include file freerdp/codec/rfx.h
// Warning: <unknown> 50: Could not locate include file freerdp/codec/nsc.h
// Warning: <unknown> 52: Could not locate include file wf_event.h
// Error: Failed to resolve name 'rdpBitmap'
// Error: Failed to resolve name 'rdpPointer'
// Error: Failed to resolve name 'rdpContext'
// Error: Failed to resolve name 'HGDI_DC'
// Error: Failed to resolve name 'HCLRCONV'
// Error: Failed to resolve name 'freerdp'
// Error: Failed to resolve name 'RFX_CONTEXT'
// Error: Failed to resolve name 'NSC_CONTEXT'

using System;
using System.Runtime.InteropServices;
using System.Text;
public partial class NativeConstants
{

    /// __WF_INTERFACE_H -> 
    /// Error generating expression: La valeur ne peut pas être null.
    ///Nom du paramètre : node
    public const string @__WF_INTERFACE_H = "";
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct Point
{

    /// LONG->int
    public int x;

    /// LONG->int
    public int y;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct tagRECT
{

    /// LONG->int
    public int left;

    /// LONG->int
    public int top;

    /// LONG->int
    public int right;

    /// LONG->int
    public int bottom;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct HDC__
{

    /// int
    public int unused;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct HBITMAP__
{

    /// int
    public int unused;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct HICON__
{

    /// int
    public int unused;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct HWND__
{

    /// int
    public int unused;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct HINSTANCE__
{

    /// int
    public int unused;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct HBRUSH__
{

    /// int
    public int unused;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct tagWNDCLASSEXW
{

    /// UINT->unsigned int
    public uint cbSize;

    /// UINT->unsigned int
    public uint style;

    /// WNDPROC
    public WNDPROC lpfnWndProc;

    /// int
    public int cbClsExtra;

    /// int
    public int cbWndExtra;

    /// HINSTANCE->HINSTANCE__*
    public System.IntPtr hInstance;

    /// HICON->HICON__*
    public System.IntPtr hIcon;

    /// HCURSOR->HICON->HICON__*
    public System.IntPtr hCursor;

    /// HBRUSH->HBRUSH__*
    public System.IntPtr hbrBackground;

    /// LPCWSTR->WCHAR*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
    public string lpszMenuName;

    /// LPCWSTR->WCHAR*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
    public string lpszClassName;

    /// HICON->HICON__*
    public System.IntPtr hIconSm;
}

/// Return Type: LRESULT->LONG_PTR->int
///param0: HWND->HWND__*
///param1: UINT->unsigned int
///param2: WPARAM->UINT_PTR->unsigned int
///param3: LPARAM->LONG_PTR->int
[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
public delegate int WNDPROC(System.IntPtr param0, uint param1, System.IntPtr param2, System.IntPtr param3);

public partial class NativeMethods
{
    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "wf_global_init")]
    public static extern int wf_global_init();


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "wf_global_uninit")]
    public static extern int wf_global_uninit();

    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "wf_start")]
    public static extern int wf_start(IntPtr wfi);

    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "wf_stop")]
    public static extern int wf_stop(IntPtr wfi);

    /// Return Type: IntPtr
    [System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "wf_new")]
    public static extern IntPtr wf_new(IntPtr hInstance, IntPtr hWndParent, int argc, [In, Out] string[] argv);

    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("<Unknown>", EntryPoint = "wf_free")]
    public static extern int wf_free(IntPtr wfi);


//    FREERDP_API int wf_start(wfInfo* wfi);
//FREERDP_API int wf_stop(wfInfo* wfi);

//FREERDP_API wfInfo* wf_new(HINSTANCE hInstance, HWND hWndParent, int argc, char** argv);
//FREERDP_API int wf_free(wfInfo* wfi);

}
