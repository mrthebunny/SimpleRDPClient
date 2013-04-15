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
 * See he License for the specific language governing permissions and
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
		public static extern IntPtr freerdp_client_new(int argc, string[] argv);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_free(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_window_size(IntPtr wfi, int width, int height);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_param(IntPtr wfi, int key, int value);

		[DllImport("libwfreerdp-client")]
		public static extern void freerdp_client_focus_in(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern void freerdp_client_focus_out(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern IntPtr freerdp_client_get_settings(IntPtr wfi);

		[DllImport("libwfreerdp-client")]
		public static extern bool freerdp_client_get_param_bool(IntPtr settings, int id);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_param_bool(IntPtr settings, int id, bool param);

		[DllImport("libwfreerdp-client")]
		public static extern uint freerdp_client_get_param_uint32(IntPtr settings, int id);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_param_uint32(IntPtr settings, int id, uint param);

		[DllImport("libwfreerdp-client")]
		public static extern ulong freerdp_client_get_param_uint64(IntPtr settings, int id);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_param_uint64(IntPtr settings, int id, ulong param);

		[DllImport("libwfreerdp-client")]
		public static extern string freerdp_client_get_param_string(IntPtr settings, int id);

		[DllImport("libwfreerdp-client")]
		public static extern int freerdp_client_set_param_string(IntPtr settings, int id, string param);
	}
}