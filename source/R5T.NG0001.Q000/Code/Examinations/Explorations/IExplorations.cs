using System;

using FluentResults;

using R5T.T0141;


namespace R5T.NG0001.Q000
{
    [ExplorationsMarker]
    public partial interface IExplorations : IExplorationsMarker
    {
        public void TryMultipleNestedOperations()
        {
            var a = Instances.Values.FriendlyValue;
            var b = Instances.Values.One;
            var c = Instances.Values.One;
            var d = Instances.Values.One;

            var result_a_b = Instances.Operations.Add_Checked(a, b);
            var result_c_d = Instances.Operations.Add_Checked(c, d);

            var result_a_b_c_d = Instances.Operations.Add_Checked(result_a_b.Value, result_c_d.Value)
                .WithError(new ExceptionalError("", new Exception("")))
                .WithReasons(result_a_b.Reasons)
                .WithReasons(result_c_d.Reasons);

            Console.WriteLine(result_a_b_c_d);
        }

        /// <summary>
        /// Successful results *always* have a value (even if its the default value for the value type).
        /// Results always start life with a value that is the default for the value type (0 for integers, null for strings).
        /// </summary>
        public void CanSuccessNotHaveAValue()
        {
            var result_Integer = new Result<int>();

            var value_Integer = result_Integer.Value;

            Console.WriteLine(value_Integer);

            var result_String = new Result<string>();

            var value_String = result_String.Value;

            Console.WriteLine(value_String);
        }

        public void TryAdd_Failure()
        {
            var result = Instances.Operations.Add_Checked(
                Instances.Values.MaximumValue,
                Instances.Values.One);

            /// <see cref="Result{TValue}.Value"/> will throw an <see cref="InvalidOperationException"/> if value is not set.
            /// So use <see cref="Result{TValue}.ValueOrDefault"/>.
            var sum = result.ValueOrDefault;

            Console.WriteLine($"{sum}: {Instances.ResultOperations.ToString(result)}");
        }

        public void TryAdd_Success()
        {
            var result = Instances.Operations.Add(
                Instances.Values.FriendlyValue,
                Instances.Values.One);

            var sum = result.Value;

            Console.WriteLine($"{sum}: {Instances.ResultOperations.ToString(result)}");
        }

        public void WhatDoesAnOkResultHave()
        {
            var ok = Result.Ok();

            // Result: IsSuccess='True'
            Console.WriteLine(ok);
        }
    }
}