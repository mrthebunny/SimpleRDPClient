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

namespace AwakeCoding.FreeRDPClient
{
    public partial class NativeMethods
    {
        /// Return Type: int
        [DllImport("libwfreerdp-client")]
        public static extern int wf_global_init();

        /// Return Type: int
        [DllImport("libwfreerdp-client")]
        public static extern int wf_global_uninit();

        /// Return Type: int
        [DllImport("libwfreerdp-client")]
        public static extern int wf_start(IntPtr wfi);

        /// Return Type: int
        [DllImport("libwfreerdp-client")]
        public static extern int wf_stop(IntPtr wfi);

        /// Return Type: IntPtr
        [DllImport("libwfreerdp-client")]
        public static extern IntPtr wf_new(IntPtr hInstance, IntPtr hWndParent, int argc, string[] argv);

        /// Return Type: int
        [DllImport("libwfreerdp-client")]
        public static extern int wf_free(IntPtr wfi);

        /// Return Type: int
        [DllImport("libwfreerdp-client")]
        public static extern int wf_set_size(IntPtr wfi, int width, int height);
    }
}