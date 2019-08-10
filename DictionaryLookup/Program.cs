using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryLookup
{
   public class Program
   {
      public static void Main() => BenchmarkRunner.Run<Program>();

      [Benchmark, ArgumentsSource(nameof(GetDictionaryArgs))]
      public object DictionaryGet(Dictionary<int, object> dictionary, int items, int key)
      {
         return dictionary[key];
      }

      public static IEnumerable<object[]> GetDictionaryArgs()
      {
         var value = new object();
         return GetArgs(keys => keys.ToDictionary(x => x, _ => value));
      }

      [Benchmark, ArgumentsSource(nameof(GetConcurrentDictionaryArgs))]
      public object ConcurrentDictionaryGetOrAdd(ConcurrentDictionary<int, object> dictionary, int items, int key)
      {
         return dictionary.GetOrAdd(key, _ => throw new InvalidOperationException());
      }

      public static IEnumerable<object[]> GetConcurrentDictionaryArgs()
      {
         var value = new object();
         return GetArgs(keys => new ConcurrentDictionary<int, object>(keys.Select(x => new KeyValuePair<int, object>(x, value))));
      }

      private static IEnumerable<object[]> GetArgs<T>(Func<IEnumerable<int>, T> factory)
      {
         var itemCount = 1;

         while (itemCount <= 1_000_000)
         {
            var keys = Enumerable.Range(0, itemCount).Select(x => x).ToList();
            var dictionary = factory.Invoke(keys);

            foreach (var key in new[] { keys.Min(), (int)keys.Average(), keys.Max() })
               yield return new object[] { dictionary, keys.Count, key };

            itemCount *= 10;
         }
      }
   }
}
