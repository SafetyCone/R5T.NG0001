using System;


namespace R5T.NG0001.Q000
{
	public class ResultOperations : IResultOperations
	{
		#region Infrastructure

	    public static ResultOperations Instance { get; } = new();

	    private ResultOperations()
	    {
        }

	    #endregion
	}
}