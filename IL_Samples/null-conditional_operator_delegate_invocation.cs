using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NetCoreSandbox
{
	public class Program
	{
		public event LoadStateEventHandler LoadState;

		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run(typeof(Program));
		}

		[Benchmark]
		public void NoNullConditionalOperator()
		{
			if (this.LoadState != null)
			{
				this.LoadState();
			}
		}

		[Benchmark]
		public void NullConditionalOperator()
		{
			this.LoadState?.Invoke();
		}

		public delegate void LoadStateEventHandler();
	}
}