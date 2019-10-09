using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HashAlgorithms
{
	[MemoryDiagnoser]
	public class Program
	{
		public static void Main()
		{
			BenchmarkRunner.Run<Program>();
		}

		private static readonly byte[] Bytes = Encoding.UTF32.GetBytes(string.Join(",", Enumerable.Range(0, 10).Select(_ => Guid.NewGuid().ToString())));

		[Benchmark]
		public void Md5()
		{
			Algorithms.Md5.ComputeHash(Bytes);
		}

		[Benchmark]
		public void Sha1()
		{
			Algorithms.Sha1.ComputeHash(Bytes);
		}

		[Benchmark]
		public void Sha256()
		{
			Algorithms.Sha256.ComputeHash(Bytes);
		}

		[Benchmark]
		public void Sha384()
		{
			Algorithms.Sha384.ComputeHash(Bytes);
		}

		[Benchmark]
		public void Sha512()
		{
			Algorithms.Sha512.ComputeHash(Bytes);
		}

		private static class Algorithms
		{
			public static HashAlgorithm Md5 { get; } = MD5.Create();
			public static HashAlgorithm Sha1 { get; } = SHA1.Create();
			public static HashAlgorithm Sha256 { get; } = SHA256.Create();
			public static HashAlgorithm Sha384 { get; } = SHA384.Create();
			public static HashAlgorithm Sha512 { get; } = SHA512.Create();
		}
	}
}
