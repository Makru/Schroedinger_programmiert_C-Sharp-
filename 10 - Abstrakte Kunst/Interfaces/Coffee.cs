﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
	class Coffee : IHasCaffeine, IHotDrink {
		public int Degree { get; set; }
		public float Caffeine { get; set; }
	}
}
