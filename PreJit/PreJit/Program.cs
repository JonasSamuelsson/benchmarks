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
         Execute("jit", Jit);
         One();
         Two();
         Three();
         Four();
         Five();
      }

      private static void One() => Execute("execute", Runner.Execute);
      private static void Two() => Execute("execute", Runner.Execute);
      private static void Three() => Execute("execute", Runner.Execute);
      private static void Four() => Execute("execute", Runner.Execute);
      private static void Five() => Execute("execute", Runner.Execute);

      private static void Execute(string info, Action action)
      {
         var stopwatch = Stopwatch.StartNew();
         action.Invoke();
         Console.WriteLine($"{info} : {stopwatch.Elapsed.TotalMilliseconds} ms");
      }

      private static void Jit()
      {
         foreach (var type in typeof(Program).Assembly.GetTypes())
         {
            type.GetConstructors().ToList().ForEach(Jit);
            type.GetMethods().ToList().ForEach(Jit);
         }
      }

      private static void Jit(MethodBase method)
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
