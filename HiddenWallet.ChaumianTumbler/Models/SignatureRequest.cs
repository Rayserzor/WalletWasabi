﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenWallet.ChaumianTumbler.Models
{
    public class SignatureRequest
	{
		public string UniqueId { get; set; }
		public string Signature { get; set; }
	}
}