using System;

using FluentResults;

using R5T.T0132;


namespace R5T.NG0001.Q000
{
	[DraftFunctionalityMarker]
	public partial interface IResultOperations : IDraftFunctionalityMarker
	{
		public TValue GetValueOrDefault<TValue>(Result<TValue> result)
        {
			var output = result.ValueOrDefault;
			return output;
        }

        public TValue GetValueOrDefault<TValue>(Result<TValue> result, TValue defaultValue)
        {
			var output = this.HasValue(result)
				? result.Value
				: defaultValue
				;

            return output;
        }

        public bool HasValue<TValue>(Result<TValue> result)
        {
			// A critique of FluentResults is that it asserts failed results have no value.
			// It also implies that all successful results have a value.
			var output = !result.IsFailed;
			return output;
        }

		/// <summary>
		/// Example outputs:
		/// <br/>
		/// Result: IsSuccess='True', Reasons='Success with Message='Addition operation succeeded.'', Value='43'
		/// <br/>
		/// - or -
		/// <br/>
		/// 0: Result: IsSuccess='False', Reasons='ExceptionalError with Message='Addition operation failed due to overflow.', Exception='System.OverflowException: Arithmetic operation resulted in an overflow.
		///		at R5T.NG0001.Q000.IOperations.Add_Checked(Int32 a, Int32 b) in C:\Code\DEV\Git\GitHub\SafetyCone\R5T.NG0001\source\R5T.NG0001.Q000\Code\Functionality\IOperations.cs:line 17'', Value='0'
		/// </summary>
		public string ToString<TValue>(Result<TValue> result)
        {
			var representation = result.ToString();
			return representation;
        }
	}
}