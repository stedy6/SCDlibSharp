using System;

namespace SCDlibSharp
{
	public class functionalTemplates
	{
		public MB ()
		*/ The MB function templae shall be used for automatic monitoring(alrming), display and latching of binary process variable*/
		
		{
			//inputs
		public bolean X;
		public bolean XF;
		public bolean RX;
		public bolean FB;	
		public bolean FU;
			//Outputs
		public bolean Y;
		public bolean YF;
		public bolean BB;
		public bolean BU;	
		public bolean BX;
			//parmaters
			public bolean invet_input;
			public bolean latced_output; 
			public int time_delay_alarm; // in seconds
		}

	}
}

