using System;
using System.Collections.Generic;
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
		public List<Cat> NoCollectionInitializer()
		{
			List<Cat> cats = new List<Cat>();
			cats.Add(new Cat { Name = "Sylvester", Age = 8 });
			cats.Add(new Cat { Name = "Whiskers", Age = 2 });
			cats.Add(new Cat { Name = "Sasha", Age = 14 });

			return cats;
		}

		[Benchmark]
		public List<Cat> CollectionInitializer()
		{
			List<Cat> cats = new List<Cat>
			{
				new Cat{ Name = "Sylvester", Age=8 },
				new Cat{ Name = "Whiskers", Age=2 },
				new Cat{ Name = "Sasha", Age=14 }
			};

			return cats;
		}

		[Benchmark]
		public Cat NoObjectInitializer()
		{
			Cat cat = new Cat();
			cat.Age = 10;
			cat.Name = "Fluffy";

			return cat;
		}

		[Benchmark]
		public Cat ObjectInitializer()
		{
			Cat cat = new Cat
			{
				Age = 10,
				Name = "Fluffy"
			};

			return cat;
		}
	}

	public class Cat
	{
		// Auto-implemented properties.
		public int Age { get; set; }
		public string Name { get; set; }

		public Cat()
		{
		}

		public Cat(string name)
		{
			this.Name = name;
		}
	}
}