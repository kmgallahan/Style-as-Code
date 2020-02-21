using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NetCoreSandbox
{
	public class Program
	{
		public static Dictionary<int, string> dictionary = new Dictionary<int, string>();
		public static Dictionary<int, string> dictionaryWithEntry = new Dictionary<int, string>() { {1, "test"} };

		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run(typeof(Program));
		}

		[Benchmark]
		public string NoOutVariableNonEmptyDictionary()
		{
			string entry;

			dictionaryWithEntry.TryGetValue(1, out entry);

			return entry;
		}

		[Benchmark]
		public string NoOutVariableEmptyDictionary()
		{
			string entry;

			dictionary.TryGetValue(1, out entry);

			return entry;
		}

		[Benchmark]
		public string OutVariableNonEmptyDictionary()
		{
			dictionaryWithEntry.TryGetValue(1, out string entry);

			return entry;
		}

		[Benchmark]
		public string OutVariableEmptyDictionary()
		{
			dictionary.TryGetValue(1, out string entry);

			return entry;
		}
	}
}