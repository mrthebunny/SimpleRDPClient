/**
 * FreeRDP: A Remote Desktop Protocol Implementation
 *
 * Copyright 2013 Benoit LeBlanc <benoit.leblanc@awakecoding.com>
 * Copyright 2013 Awake Coding Consulting Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AwakeCoding.FreeRDPClient
{
	public partial class NativeMethods
	{
		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_global_init();

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_global_uninit();

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_start(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_stop(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern IntPtr freerdp_client_new(IntPtr hWndParent, int argc, string[] argv);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_free(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_window_size(IntPtr wfi, int width, int height);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_param(IntPtr wfi, int key, int value);

		[DllImport("libwfreerdp-client")]
		public static extern void freerdp_client_set_focus(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern void freerdp_client_kill_focus(IntPtr wfi);
	}
}