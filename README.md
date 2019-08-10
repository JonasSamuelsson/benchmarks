# benchmarks

* [DictionaryLookup](#DictionaryLookup)

## DictionaryLookup

This benchmark compares the lookup time for Dictionary<TKey, TValue> vs ConcurrentDictionary<TKey, TValue>.  
The bechmark is measuring a single non parallel lookup.

|                       Method |   items |    key |      Mean |     Error |    StdDev |    Median |
|----------------------------- |-------- |------- |----------:|----------:|----------:|----------:|
| ConcurrentDictionaryGetOrAdd |       1 |      0 | 23.065 ns | 0.2962 ns | 0.2771 ns | 22.967 ns |
| ConcurrentDictionaryGetOrAdd |       1 |      0 | 23.081 ns | 0.2467 ns | 0.2187 ns | 23.114 ns |
| ConcurrentDictionaryGetOrAdd |       1 |      0 | 22.838 ns | 0.1512 ns | 0.1340 ns | 22.839 ns |
| ConcurrentDictionaryGetOrAdd |      10 |      0 | 23.136 ns | 0.2094 ns | 0.1856 ns | 23.119 ns |
| ConcurrentDictionaryGetOrAdd |      10 |      4 | 23.031 ns | 0.1429 ns | 0.1266 ns | 23.052 ns |
| ConcurrentDictionaryGetOrAdd |      10 |      9 | 23.181 ns | 0.2192 ns | 0.1830 ns | 23.177 ns |
| ConcurrentDictionaryGetOrAdd |     100 |      0 | 23.257 ns | 0.4297 ns | 0.3809 ns | 23.156 ns |
| ConcurrentDictionaryGetOrAdd |     100 |     49 | 23.197 ns | 0.1905 ns | 0.1591 ns | 23.269 ns |
| ConcurrentDictionaryGetOrAdd |     100 |     99 | 24.250 ns | 0.5749 ns | 0.7675 ns | 24.457 ns |
| ConcurrentDictionaryGetOrAdd |    1000 |      0 | 25.083 ns | 0.5916 ns | 0.4940 ns | 24.917 ns |
| ConcurrentDictionaryGetOrAdd |    1000 |    499 | 25.295 ns | 0.2937 ns | 0.2603 ns | 25.338 ns |
| ConcurrentDictionaryGetOrAdd |    1000 |    999 | 26.581 ns | 0.5859 ns | 0.4892 ns | 26.507 ns |
| ConcurrentDictionaryGetOrAdd |   10000 |      0 | 26.830 ns | 0.5551 ns | 0.5192 ns | 26.781 ns |
| ConcurrentDictionaryGetOrAdd |   10000 |   4999 | 28.191 ns | 0.6835 ns | 0.7019 ns | 27.986 ns |
| ConcurrentDictionaryGetOrAdd |   10000 |   9999 | 28.176 ns | 0.3369 ns | 0.2987 ns | 28.092 ns |
| ConcurrentDictionaryGetOrAdd |  100000 |      0 | 28.083 ns | 0.3659 ns | 0.3422 ns | 28.127 ns |
| ConcurrentDictionaryGetOrAdd |  100000 |  49999 | 28.259 ns | 0.6713 ns | 0.6593 ns | 28.202 ns |
| ConcurrentDictionaryGetOrAdd |  100000 |  99999 | 26.985 ns | 0.2794 ns | 0.2333 ns | 27.086 ns |
| ConcurrentDictionaryGetOrAdd | 1000000 |      0 | 26.903 ns | 0.3711 ns | 0.3099 ns | 27.008 ns |
| ConcurrentDictionaryGetOrAdd | 1000000 | 499999 | 26.168 ns | 0.5377 ns | 0.5030 ns | 25.971 ns |
| ConcurrentDictionaryGetOrAdd | 1000000 | 999999 | 31.256 ns | 2.8223 ns | 8.2328 ns | 27.425 ns |
|                DictionaryGet |       1 |      0 | 10.025 ns | 0.1623 ns | 0.1439 ns | 10.057 ns |
|                DictionaryGet |       1 |      0 |  9.907 ns | 0.1467 ns | 0.1300 ns |  9.942 ns |
|                DictionaryGet |       1 |      0 | 10.003 ns | 0.1092 ns | 0.1021 ns | 10.025 ns |
|                DictionaryGet |      10 |      0 | 10.032 ns | 0.1444 ns | 0.1280 ns | 10.049 ns |
|                DictionaryGet |      10 |      4 | 10.049 ns | 0.1154 ns | 0.1080 ns | 10.017 ns |
|                DictionaryGet |      10 |      9 | 10.069 ns | 0.2136 ns | 0.1998 ns | 10.035 ns |
|                DictionaryGet |     100 |      0 | 10.052 ns | 0.2667 ns | 0.2495 ns |  9.997 ns |
|                DictionaryGet |     100 |     49 | 10.088 ns | 0.3103 ns | 0.3048 ns | 10.163 ns |
|                DictionaryGet |     100 |     99 | 10.271 ns | 0.1848 ns | 0.1728 ns | 10.201 ns |
|                DictionaryGet |    1000 |      0 | 10.152 ns | 0.2025 ns | 0.1894 ns | 10.045 ns |
|                DictionaryGet |    1000 |    499 | 10.286 ns | 0.1599 ns | 0.1418 ns | 10.281 ns |
|                DictionaryGet |    1000 |    999 | 10.215 ns | 0.2018 ns | 0.1888 ns | 10.187 ns |
|                DictionaryGet |   10000 |      0 | 10.357 ns | 0.1731 ns | 0.1351 ns | 10.328 ns |
|                DictionaryGet |   10000 |   4999 | 10.291 ns | 0.1789 ns | 0.1586 ns | 10.333 ns |
|                DictionaryGet |   10000 |   9999 | 10.476 ns | 0.1298 ns | 0.1215 ns | 10.481 ns |
|                DictionaryGet |  100000 |      0 | 10.324 ns | 0.1961 ns | 0.1738 ns | 10.295 ns |
|                DictionaryGet |  100000 |  49999 | 10.438 ns | 0.2361 ns | 0.2209 ns | 10.381 ns |
|                DictionaryGet |  100000 |  99999 | 10.377 ns | 0.2189 ns | 0.1941 ns | 10.372 ns |
|                DictionaryGet | 1000000 |      0 | 10.309 ns | 0.1888 ns | 0.1766 ns | 10.358 ns |
|                DictionaryGet | 1000000 | 499999 | 10.274 ns | 0.1737 ns | 0.1451 ns | 10.252 ns |
|                DictionaryGet | 1000000 | 999999 | 10.380 ns | 0.1454 ns | 0.1360 ns | 10.393 ns |