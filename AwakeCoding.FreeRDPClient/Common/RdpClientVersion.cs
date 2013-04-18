﻿/**
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.Common
{
	public enum RDPClientVersion
	{
		Unknown = 0,
		Stub,
		FreeRDP,
#if !__MONO
		MsRDPClient,
		MsRDPClient80,
		MsRDPClient70,
		MsRDPClient60,
		MsRDPClient61,
		MsRDPClient50,
#endif
		UnusedLast
	};
}