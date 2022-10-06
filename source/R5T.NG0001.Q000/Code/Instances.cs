using System;


namespace R5T.NG0001.Q000
{
    public static class Instances
    {
        public static IExplorations Explorations { get; } = Q000.Explorations.Instance;
        public static IOperations Operations { get; } = Q000.Operations.Instance;
        public static IResultOperations ResultOperations { get; } = Q000.ResultOperations.Instance;
        public static IValues Values { get; } = Q000.Values.Instance;
    }
}