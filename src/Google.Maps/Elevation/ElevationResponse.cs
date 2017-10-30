﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Google.Maps.Common;
using Newtonsoft.Json;

namespace Google.Maps.Elevation
{
	[JsonObject(MemberSerialization.OptIn)]
	public class ElevationResponse : IServiceResponse
	{
		/// <summary>
		/// Contains the ServiceResponseStatus.
		/// </summary>
		[JsonProperty("status")]
		public ServiceResponseStatus Status { get; set; }

		/// <summary>
		/// More detailed information about the reasons behind the given status code, if other than OK.
		/// </summary>
		[JsonProperty("error_message")]
		public string ErrorMessage { get; set; }

		[JsonProperty("results")]
		public ElevationResult[] Results { get; set; }
	}
}
