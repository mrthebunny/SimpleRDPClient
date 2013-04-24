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
	public class FreeRDPSecuredSettings : ISecuredSettings
	{
		private FreeRDPSettings settings;

		public event SettingsChangedEventHandler SettingsChanged;

		public FreeRDPSecuredSettings(FreeRDPSettings settings)
		{
			this.settings = settings;
		}

		public int AudioRedirectionMode
		{
			get
			{
				if (settings.AudioPlayback)
					return (int) RDPConstants.AUDIO_MODE_REDIRECT;

				if (settings.RemoteConsoleAudio)
					return (int) RDPConstants.AUDIO_MODE_PLAY_ON_SERVER;

				return (int) RDPConstants.AUDIO_MODE_NONE;
			}
			set
			{
				bool audioPlayback = false;
				bool remoteConsoleAudio = false;

				if (value == RDPConstants.AUDIO_MODE_REDIRECT)
				{
					audioPlayback = true;
				}
				else if (value == RDPConstants.AUDIO_MODE_PLAY_ON_SERVER)
				{
					remoteConsoleAudio = true;
				}

				settings.AudioPlayback = audioPlayback;
				settings.RemoteConsoleAudio = remoteConsoleAudio;
			}
		}

		public int FullScreen
		{
			get
			{
				return settings.Fullscreen ? 1 : 0;
			}
			set
			{
				settings.Fullscreen = (value == 0 ? false : true);
			}
		}

		public int KeyboardHookMode
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public string StartProgram
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public string WorkDir
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}
	}
}
