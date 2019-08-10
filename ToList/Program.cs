using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Linq;

namespace ToList
{
   public class Program
   {
      public static void Main() => BenchmarkRunner.Run<ToList>();
   }

   [MemoryDiagnoser]
   public class ToList
   {
      private static readonly object O = new object();
      private static readonly IEnumerable<object> Array = Enumerable.Repeat(O, 10).ToArray();
      private static readonly IEnumerable<object> List = Enumerable.Repeat(O, 10).ToList();

      [Benchmark]
      public List<object> NaiveFromArray() => Array.ToList();

      [Benchmark]
      public List<object> NaiveFromList() => List.ToList();

      [Benchmark]
      public List<object> OptimizedFromArray() => Array as List<object> ?? Array.ToList();

      [Benchmark]
      public List<object> OptimizedFromList() => List as List<object> ?? List.ToList();
   }
}
