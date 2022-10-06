using System;


namespace R5T.NG0001.Q000
{
	public class Operations : IOperations
	{
		#region Infrastructure

	    public static Operations Instance { get; } = new();

	    private Operations()
	    {
        }

	    #endregion
	}
}