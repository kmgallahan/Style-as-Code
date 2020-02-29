---
grand_parent: Best Practices
parent: Language Features
title: Object and Collection Initializers
---

[Microsoft Docs / Object Initializers](https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)

## Recommendation

Both object and collection initializers should be used, regardless of how many elements are being set.

Use:

```cs
Cat cat = new Cat
{
    Age = 10,
    Name = "Fluffy"
};

List<Cat> cats = new List<Cat>
{
    new Cat{ Name = "Sylvester", Age=8 },
    new Cat{ Name = "Whiskers", Age=2 },
    new Cat{ Name = "Sasha", Age=14 }
};
```

Not

```cs
Cat cat = new Cat();
cat.Age = 10;
cat.Name = "Fluffy";

List<Cat> cats = new List<Cat>();
cats.Add(new Cat{ Name = "Sylvester", Age=8 });
cats.Add(new Cat{ Name = "Whiskers", Age=2 };
cats.Add(new Cat{ Name = "Sasha", Age=14 };
```

## Justification

Both the Roslyn and .Net Core runtime teams agree that object and collection initializers should be used.

### Arguments

✔ Prevents objects and collections from being accessed before all necessary elements are setup.

✔ Ensures assignments aren't misplaced during refactoring.

❌ 2 Braces-only lines must always be added, even for individual properties.

❌ Code blocks must be indented.

### Performance

Identical IL is generated when using either object or collection initializers.

|                  Method |      Mean |     Error |    StdDev |
|------------------------ |----------:|----------:|----------:|
| NoCollectionInitializer | 45.280 ns | 0.2104 ns | 0.1865 ns |
|   CollectionInitializer | 46.333 ns | 0.9622 ns | 0.9881 ns |
|     NoObjectInitializer |  6.052 ns | 0.1802 ns | 0.1686 ns |
|       ObjectInitializer |  5.554 ns | 0.1475 ns | 0.1380 ns |

[Benchmark code](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/object_and_collection_initializers_benchmark.cs)

[Benchmark IL](https://github.com/kmgallahan/Style-as-Code/blob/master/Benchmarks/object_and_collection_initializers_benchmark_IL)

## Exceptions

## Analyzers

| ID | Name | Value
|:-|:-|:-|
| IDE0017 | dotnet_style_object_initializer | true:suggestion |
| IDE0028 | dotnet_style_collection_initializer | true:suggestion |

## Discussion

[GitHub Discussion](https://github.com/kmgallahan/Style-as-Code/issues/9){: .btn .btn-purple }
