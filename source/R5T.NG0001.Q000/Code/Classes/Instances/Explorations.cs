using System;


namespace R5T.NG0001.Q000
{
	public class Explorations : IExplorations
	{
		#region Infrastructure

	    public static Explorations Instance { get; } = new();

	    private Explorations()
	    {
        }

	    #endregion
	}
}