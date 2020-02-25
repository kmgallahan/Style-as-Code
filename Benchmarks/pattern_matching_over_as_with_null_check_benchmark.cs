using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NetCoreSandbox
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run(typeof(Program));
		}

		[Benchmark]
		public Exception NoIsExpression()
		{
			var nullException = new ArgumentNullException();

			Exception exception = nullException as Exception;

			if (exception != null)
				return exception;

			return new Exception();
		}

		[Benchmark]
		public Exception IsExpression()
		{
			var nullException = new ArgumentNullException();

			if (nullException is Exception exception)
				return exception;

			return new Exception();
		}
	}
}