using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NetCoreSandbox
{
	public class Program
	{
		public static string[] _args;
		public static string[] args = new string[] { "test" };

		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run(typeof(Program));
		}

		[Benchmark]
		public void NoThrowExpression()
		{
			if (args == null)
				throw new ArgumentNullException("args");

			_args = args;
		}

		[Benchmark]
		public void ThrowExpression()
		{
			_args = args ?? throw new ArgumentNullException("args");
		}
	}
}