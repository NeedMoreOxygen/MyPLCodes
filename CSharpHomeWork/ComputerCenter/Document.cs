using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenter
{
	class Document
	{
		int lB = 0;
		int rB = 0;
		int uB = 0;
		int dB = 0;
		public Document(int lB, int rB, int uB, int dB)
		{
			this.lB = lB;
			this.rB = rB;
			this.uB = uB;
			this.dB = dB;
		}
		public Document()
		{
			lB = 3;
			rB = 1;
			uB = 1;
			dB = 1;
		}
	}
}
