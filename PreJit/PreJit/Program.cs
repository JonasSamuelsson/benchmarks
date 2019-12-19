using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PreJit
{
   class Program
   {
      static void Main(string[] args)
      {
         //GenerateCode();
         PreJit();
         One();
         Two();
         Three();
         Four();
         Five();
      }

      private static void One() => Execute();
      private static void Two() => Execute();
      private static void Three() => Execute();
      private static void Four() => Execute();
      private static void Five() => Execute();

      private static void Execute()
      {
         var stopwatch = Stopwatch.StartNew();
         Runner.Execute();
         Console.WriteLine($"{stopwatch.Elapsed.TotalMilliseconds} ms");
      }

      private static void PreJit()
      {
         foreach (var type in typeof(Program).Assembly.GetTypes())
         {
            type.GetConstructors().ToList().ForEach(PreJit);
            type.GetMethods().ToList().ForEach(PreJit);
         }
      }

      private static void PreJit(MethodBase method)
      {
         System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(method.MethodHandle);
      }

      private static void GenerateCode()
      {
         var ints = Enumerable.Range(1, 100).ToList();

         var declarationsBuilder = new StringBuilder();
         foreach (var i in ints)
         {
            declarationsBuilder.AppendLine($"public class Worker{i}");
            declarationsBuilder.AppendLine("{");
            foreach (var j in ints)
            {
               declarationsBuilder.AppendLine($"   public void DoWork{j}() {{ }}");
            }
            declarationsBuilder.AppendLine("}");
         }
         var declarations = declarationsBuilder.ToString();

         var invokationsBuilder = new StringBuilder();
         foreach (var i in ints)
         {
            invokationsBuilder.AppendLine($"var worker{i} = new Worker{i}();");
            foreach (var j in ints)
            {
               invokationsBuilder.AppendLine($"worker{i}.DoWork{j}();");
            }
         }
         var invokations = invokationsBuilder.ToString();
      }
   }
}
