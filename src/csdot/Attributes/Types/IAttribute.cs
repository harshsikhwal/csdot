﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csdot.Attributes
{
	interface IAttribute
	{
		public bool Set { get; set; }
		public string TranslateToString();
	}
}
