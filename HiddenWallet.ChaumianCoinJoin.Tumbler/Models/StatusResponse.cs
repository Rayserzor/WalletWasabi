﻿using HiddenWallet.SharedApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenWallet.ChaumianCoinJoin.Tumbler.Models
{
	public class StatusResponse : BaseResponse
	{
		public StatusResponse() => Success = true;
		public string PubKey { get; set; }
		public string Phase { get; set; }
		public string Denomination { get; set; }
		public int AnonymitySet { get; set; }
		public string TimeSpentInInputRegistrationLastTime { get; set; }
	}
}
