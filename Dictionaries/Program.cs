using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Dictionaries
{
   //[DryJob]
   [MemoryDiagnoser]
   [Config(typeof(CustomColumnConfig))]
   public class Program
   {
      public static void Main() => BenchmarkRunner.Run<Program>();

      private static readonly object Value = new object();

      // -----------------------------------------------------------------------------------------------

      [Benchmark]
      [ArgumentsSource(nameof(GetConcurrentDictionaryGetArgs))]
      public object ConcurrentDictionaryGet(ConcurrentDictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         return dictionary[key];
      }

      public IEnumerable<object[]> GetConcurrentDictionaryGetArgs()
      {
         return GetArgs(typeof(ConcurrentDictionary<string, object>), KeyExists.Yes);
      }

      [Benchmark]
      [ArgumentsSource(nameof(GetConcurrentDictionarySetArgs))]
      public void ConcurrentDictionarySet(ConcurrentDictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         dictionary[key] = Value;
      }

      public IEnumerable<object[]> GetConcurrentDictionarySetArgs()
      {
         return GetArgs(typeof(ConcurrentDictionary<string, object>), KeyExists.Yes);
      }

      [Benchmark]
      [ArgumentsSource(nameof(GetConcurrentDictionaryTryGetValueArgs))]
      public bool ConcurrentDictionaryTryGetValue(ConcurrentDictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         return dictionary.TryGetValue(key, out _);
      }

      public IEnumerable<object[]> GetConcurrentDictionaryTryGetValueArgs()
      {
         return GetArgs(typeof(ConcurrentDictionary<string, object>), KeyExists.Both);
      }

      // -----------------------------------------------------------------------------------------------

      [Benchmark]
      [ArgumentsSource(nameof(GetDictionaryGetArgs))]
      public object DictionaryGet(Dictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         return dictionary[key];
      }

      public IEnumerable<object[]> GetDictionaryGetArgs()
      {
         return GetArgs(typeof(Dictionary<string, object>), KeyExists.Yes);
      }

      [Benchmark]
      [ArgumentsSource(nameof(GetDictionarySetArgs))]
      public void DictionarySet(Dictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         dictionary[key] = Value;
      }

      public IEnumerable<object[]> GetDictionarySetArgs()
      {
         return GetArgs(typeof(Dictionary<string, object>), KeyExists.Yes);
      }

      [Benchmark]
      [ArgumentsSource(nameof(GetDictionaryTryGetValueArgs))]
      public bool DictionaryTryGetValue(Dictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         return dictionary.TryGetValue(key, out _);
      }

      public IEnumerable<object[]> GetDictionaryTryGetValueArgs()
      {
         return GetArgs(typeof(Dictionary<string, object>), KeyExists.Both);
      }

      // -----------------------------------------------------------------------------------------------

      [Benchmark]
      [ArgumentsSource(nameof(GetExpandoObjectGetArgs))]
      public object ExpandoObjectGet(IDictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         return dictionary[key];
      }

      public IEnumerable<object[]> GetExpandoObjectGetArgs()
      {
         return GetArgs(typeof(ExpandoObject), KeyExists.Yes);
      }

      [Benchmark]
      [ArgumentsSource(nameof(GetExpandoObjectSetArgs))]
      public void ExpandoObjectSet(IDictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         dictionary[key] = Value;
      }

      public IEnumerable<object[]> GetExpandoObjectSetArgs()
      {
         return GetArgs(typeof(ExpandoObject), KeyExists.Yes);
      }

      [Benchmark]
      [ArgumentsSource(nameof(GetExpandoObjectTryGetValueArgs))]
      public bool ExpandoObjectTryGetValue(IDictionary<string, object> dictionary, string key, int itemCount, bool keyExists)
      {
         return dictionary.TryGetValue(key, out _);
      }

      public IEnumerable<object[]> GetExpandoObjectTryGetValueArgs()
      {
         return GetArgs(typeof(ExpandoObject), KeyExists.Both);
      }

      // -----------------------------------------------------------------------------------------------

      private static IEnumerable<object[]> GetArgs(Type dictionaryType, KeyExists keyExists)
      {
         var result = new List<object[]>();

         foreach (var itemCount in new[] { 0, 5, 10, 20, 50, 100 })
         {
            var min = 0;
            var max = Math.Max(0, itemCount - 1);
            var middle = max / 2;

            var keys = new[] { min, middle, max }.Distinct().Select(i => i.ToString());

            foreach (var key in keys)
            {
               if (keyExists.HasFlag(KeyExists.Yes))
               {
                  var dictionary = CreateDictionary(dictionaryType, itemCount, null);
                  if (dictionary.ContainsKey(key))
                  {
                     result.Add(new object[] { dictionary, key, itemCount, true });
                  }
               }

               if (keyExists.HasFlag(KeyExists.No))
               {
                  var dictionary = CreateDictionary(dictionaryType, itemCount, key);
                  result.Add(new object[] { dictionary, key, itemCount, false });
               }
            }
         }

         return result;
      }

      private static IDictionary<string, object> CreateDictionary(Type dictionaryType, int itemCount, string ignoreKey)
      {
         var dictionary = (IDictionary<string, object>)Activator.CreateInstance(dictionaryType);

         for (var i = 0; i < itemCount; i++)
         {
            var key = i.ToString();
            if (key == ignoreKey) continue;
            dictionary.Add(key, Value);
         }

         return dictionary;
      }

      [Flags]
      public enum KeyExists
      {
         No = 1,
         Yes = 2,
         Both = No | Yes
      }

      public class CustomColumnConfig : ManualConfig
      {
         private static string[] Types = { "ConcurrentDictionary", "Dictionary", "ExpandoObject", "LockedDictionary" };
         private static string[] Operations = { "Get", "Set", "TryGetValue" };

         public CustomColumnConfig()
         {
            AddColumn(new TagColumn("type", s => Types.FirstOrDefault(s.StartsWith) ?? string.Empty));
            AddColumn(new TagColumn("operation", s => Operations.FirstOrDefault(s.EndsWith) ?? string.Empty));
         }
      }
   }
}
