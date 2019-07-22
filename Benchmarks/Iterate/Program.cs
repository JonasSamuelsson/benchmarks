using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Linq;

namespace Iterate
{
   [MemoryDiagnoser]
   public class Program
   {
      private const int Count = 1_000_000;

      public static void Main() => BenchmarkRunner.Run<Program>();

      public Item[] Array = Enumerable.Repeat(new Item(), Count).ToArray();
      public IEnumerable<Item> IEnumerable = Enumerable.Repeat(new Item(), Count);
      public List<Item> List = Enumerable.Repeat(new Item(), Count).ToList();
      public IList<Item> IList = Enumerable.Repeat(new Item(), Count).ToList();

      [Benchmark]
      public void ForArray()
      {
         for (var i = 0; i < Array.Length; i++)
            Array[i].Execute();
      }

      [Benchmark]
      public void ForIList()
      {
         for (var i = 0; i < IList.Count; i++)
            IList[i].Execute();
      }

      [Benchmark]
      public void ForList()
      {
         for (var i = 0; i < List.Count; i++)
            List[i].Execute();
      }

      [Benchmark]
      public void ForeachArray()
      {
         foreach (var item in Array)
            item.Execute();
      }

      [Benchmark]
      public void ForeachIEnumerable()
      {
         foreach (var item in IEnumerable)
            item.Execute();
      }

      [Benchmark]
      public void ForeachIList()
      {
         foreach (var item in IList)
            item.Execute();
      }

      [Benchmark]
      public void ForeachList()
      {
         foreach (var item in List)
            item.Execute();
      }

      [Benchmark]
      public void ForeachArrayAsIEnumerable()
      {
         void Iterate(IEnumerable<Item> items)
         {
            foreach (var item in items) item.Execute();
         }

         Iterate(Array);
      }

      public class Item
      {
         public int Counter;

         public void Execute() => Counter += 1;
      }
   }
}
