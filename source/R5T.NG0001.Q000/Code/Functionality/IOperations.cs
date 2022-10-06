using System;

using FluentResults;

using R5T.T0132;


namespace R5T.NG0001.Q000
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker
	{
		public Result<int> Add_Checked(int a, int b)
        {
			try
            {
				var sum = checked(a + b);

				var result = Result.Ok(sum).WithSuccess("Addition operation succeeded.");
				return result;
            }
			catch (OverflowException overflowException)
            {
				var result = Result.Fail(new ExceptionalError("Addition operation failed due to overflow.", overflowException));
				return result;
			}
		}

		public Result<int> Add(int a, int b)
        {
			// Note: integer operations are unchecked by default, so no overflow exception will result.
			var sum = a + b;

			var result = Result.Ok(sum).WithSuccess("Addition operation succeeded.");
			return result;
        }
	}
}