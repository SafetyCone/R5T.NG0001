using System;

using R5T.T0131;


namespace R5T.NG0001.Q000
{
	[ValuesMarker]
	public partial interface IValues : IValuesMarker
	{
		public int NegativeOne => -1;
		public int Zero => 0;
		public int One => 1;
		public int FriendlyValue => 42;
		public int MaximumValue => Int32.MaxValue;
		public int MinimumValue => Int32.MinValue;
	}
}