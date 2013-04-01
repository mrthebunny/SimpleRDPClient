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