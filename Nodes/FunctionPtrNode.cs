﻿using System;
using System.Collections.Generic;

namespace ReClassNET.Nodes
{
	class FunctionPtrNode : BaseFunctionPtrNode
	{
		public override int Draw(ViewInfo view, int x, int y)
		{
			return Draw(view, x, y, "Function", Name);
		}
	}
}
