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
using AwakeCoding.FreeRDPClient.FreeRDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.FreeRDPClient
{
	public class FreeRDPTransportSettings : ITransportSettings
	{
		private FreeRDPSettings settings;

		public event SettingsChangedEventHandler SettingsChanged;

		public FreeRDPTransportSettings(FreeRDPSettings settings)
		{
			this.settings = settings;
		}

		public uint GatewayCredsSource
		{
			get
			{
				// TODO: convert value
				return settings.GatewayCredentialsSource;
			}
			set
			{
				// TODO: convert value
				settings.GatewayCredentialsSource = value;
			}
		}

		public uint GatewayProfileUsageMethod
		{
			get
			{
				return settings.GatewayUsageMethod ?
					RDPConstants.TSC_PROXY_PROFILE_MODE_EXPLICIT : RDPConstants.TSC_PROXY_PROFILE_MODE_EXPLICIT;
			}
			set
			{
				settings.GatewayUsageMethod = (value == RDPConstants.TSC_PROXY_PROFILE_MODE_EXPLICIT) ? true : false;
			}
		}

		public string GatewayHostname
		{
			get
			{
				return settings.GatewayHostname;
			}
			set
			{
				settings.GatewayHostname = value;
			}
		}

		public string GatewayUsername
		{
			get
			{
				return settings.GatewayUsername;
			}
			set
			{
				settings.GatewayUsername = value;
				// TODO: set GatewayUsageMethod (in backend)
			}
		}

		public string GatewayDomain
		{
			get
			{
				return settings.GatewayDomain;
			}
			set
			{
				settings.GatewayDomain = value;
			}
		}

		public string GatewayPassword
		{
			get
			{
				return settings.GatewayPassword;
			}
			set 
			{
				settings.GatewayPassword = value;
			}
		}

		public uint GatewayUsageMethod
		{
			get
			{
				return settings.GatewayUsageMethod ? 
					RDPConstants.TSC_PROXY_MODE_DIRECT : RDPConstants.TSC_PROXY_PROFILE_MODE_DEFAULT;
			}
			set
			{
				// TODO: Validate if correct values
				switch (value)
				{
					case RDPConstants.TSC_PROXY_MODE_NONE_DIRECT:
					case RDPConstants.TSC_PROXY_MODE_DIRECT:
					case RDPConstants.TSC_PROXY_MODE_DEFAULT:
						settings.GatewayUsageMethod = false;
						break;
					case RDPConstants.TSC_PROXY_MODE_DETECT:
					case RDPConstants.TSC_PROXY_MODE_NONE_DETECT:
						settings.GatewayUsageMethod = true; 
						break;
				}
			}
		}

		public uint GatewayCredSharing
		{
			get
			{
				return settings.GatewayUseSameCredentials ? 1U : 0U;

			}
			set
			{
				settings.GatewayUseSameCredentials = (value == 1U ? true : false);
			}
		}

		public uint GatewayDefaultUsageMethod
		{
			get { return RDPConstants.TSC_PROXY_MODE_DETECT; }
		}

		public string GatewayEncryptedOtpCookie
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public uint GatewayEncryptedOtpCookieSize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int GatewayIsSupported
		{
			get { throw new NotImplementedException(); }
		}

		public uint GatewayPreAuthRequirement
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string GatewayPreAuthServerAddr
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string GatewaySupportUrl
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public uint GatewayUserSelectedCredsSource
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
