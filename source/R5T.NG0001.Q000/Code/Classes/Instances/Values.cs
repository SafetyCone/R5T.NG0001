using System;


namespace R5T.NG0001.Q000
{
	public class Values : IValues
	{
		#region Infrastructure

	    public static Values Instance { get; } = new();

	    private Values()
	    {
        }

	    #endregion
	}
}