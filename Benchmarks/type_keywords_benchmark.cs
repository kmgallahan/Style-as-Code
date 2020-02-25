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
		public string NoTypeKeywords()
		{
			Int32 x = 10;
			String y = "test";
			Single z = 5.5f;

			return (x + y + z);
		}

		[Benchmark]
		public string TypeKeywords()
		{
			int x = 10;
			string y = "test";
			float z = 5.5f;

			return (x + y + z);
		}
	}
}