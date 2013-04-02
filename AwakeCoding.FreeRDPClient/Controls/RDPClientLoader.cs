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

using AwakeCoding.Common;
using AwakeCoding.FreeRDPClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AwakeCoding.FreeRDPClient
{
	class RDPClientLoader
	{
		public static IRDPClient NewRDPClient(RDPClientVersion clientType)
		{
			bool designMode = (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime);

			if (!designMode)
			{
				using (var process = Process.GetCurrentProcess())
				{
					designMode = process.ProcessName.ToLowerInvariant().Contains("devenv");
				}
			}

			if (designMode)
			{
				clientType = RDPClientVersion.Stub;
			}

#if __MONO
			else
			{
				clientType = RDPClientVersion.FreeRDP;
			}
#endif

			IRDPClient client;

			if (clientType == RDPClientVersion.Stub)
			{
				client = new RDPClientStub();
			}
			else if (clientType == RDPClientVersion.FreeRDP)
			{
				client = new FreeRDPClient();
			}
#if !__MONO
            else if (clientType == RDPClientVersion.MsRDPClient
                || clientType == RDPClientVersion.MsRDPClient80  
                || clientType == RDPClientVersion.MsRDPClient70
                || clientType == RDPClientVersion.MsRDPClient61
                || clientType == RDPClientVersion.MsRDPClient60
                || clientType == RDPClientVersion.MsRDPClient50
                )
            {
                    string libPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AwakeCoding.MsRdpClient.dll");
                    Assembly msRdpClientAssembly = Assembly.LoadFrom(libPath);
                    client = msRdpClientAssembly.CreateInstance("AwakeCoding.MsRdpClient.MsRdpClientAdapter") as IRDPClient;
            }
#endif
			else
			{
				throw new ArgumentException("Unsupported RDPClientVersion");
			}

			return client;
		}
	}
}
