# benchmarks
* [Dictionaries](#Dictionaries)
* [DictionaryLookup](#DictionaryLookup)
* [HashAlgorithms](#HashAlgorithms)
* [Iterate](#Iterate)
* [ToList](#ToList)

## Dictionaries

This benchmark compares `Get`, `Set` & `TryGetValue` for different `IDictionary<TKey, TValue>` implmentations.  
The bechmark is not multi threaded.

|                          Method | key | itemCount | keyExists |         Mean |      Error |     StdDev |                 type |   operation | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---- |---------- |---------- |-------------:|-----------:|-----------:|--------------------- |------------ |------:|------:|------:|----------:|
| ConcurrentDictionaryTryGetValue |   0 |         0 |     False |    21.895 ns |  0.4538 ns |  0.4855 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |         5 |     False |    21.194 ns |  0.4373 ns |  0.4295 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   0 |         5 |      True |    29.900 ns |  0.5505 ns |  0.4880 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   0 |         5 |      True |    67.930 ns |  1.3995 ns |  1.4975 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |         5 |      True |    28.558 ns |  0.5894 ns |  0.5513 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |        10 |     False |    20.796 ns |  0.4537 ns |  0.5572 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   0 |        10 |      True |    30.507 ns |  0.5576 ns |  0.7633 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   0 |        10 |      True |    69.281 ns |  1.3695 ns |  1.3451 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |        10 |      True |    28.071 ns |  0.5274 ns |  0.4934 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |        20 |     False |    20.608 ns |  0.4325 ns |  0.4248 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   0 |        20 |      True |    30.945 ns |  0.7238 ns |  0.8045 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   0 |        20 |      True |    65.549 ns |  0.9800 ns |  0.8687 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |        20 |      True |    28.262 ns |  0.6017 ns |  0.6929 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |        50 |     False |    20.862 ns |  0.4595 ns |  0.4719 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   0 |        50 |      True |    29.599 ns |  0.6653 ns |  0.7662 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   0 |        50 |      True |    66.769 ns |  1.3338 ns |  1.5878 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |        50 |      True |    28.863 ns |  0.4733 ns |  0.4196 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |       100 |     False |    20.195 ns |  0.2925 ns |  0.2736 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   0 |       100 |      True |    28.549 ns |  0.5862 ns |  0.5483 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   0 |       100 |      True |    69.575 ns |  1.3875 ns |  1.2979 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   0 |       100 |      True |    29.988 ns |  0.6434 ns |  1.0206 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  19 |        20 |     False |    23.039 ns |  0.3287 ns |  0.3075 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |  19 |        20 |      True |    35.654 ns |  0.3242 ns |  0.3032 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |  19 |        20 |      True |    75.180 ns |  1.1031 ns |  0.9779 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  19 |        20 |      True |    35.893 ns |  0.5892 ns |  0.5511 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   2 |         5 |     False |    21.194 ns |  0.3314 ns |  0.3100 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   2 |         5 |      True |    29.914 ns |  0.5227 ns |  0.4890 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   2 |         5 |      True |    67.922 ns |  0.9573 ns |  0.8954 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   2 |         5 |      True |    29.376 ns |  0.3340 ns |  0.3124 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  24 |        50 |     False |    22.273 ns |  0.2859 ns |  0.2674 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |  24 |        50 |      True |    35.945 ns |  0.5235 ns |  0.4897 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |  24 |        50 |      True |    74.090 ns |  1.0004 ns |  0.8868 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  24 |        50 |      True |    36.910 ns |  0.7850 ns |  0.8062 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   4 |         5 |     False |    21.083 ns |  0.3817 ns |  0.3571 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   4 |         5 |      True |    30.323 ns |  0.6812 ns |  0.6690 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   4 |         5 |      True |    68.472 ns |  0.9008 ns |  0.7986 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   4 |         5 |      True |    29.881 ns |  0.3388 ns |  0.3003 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   4 |        10 |     False |    21.286 ns |  0.3420 ns |  0.3199 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   4 |        10 |      True |    30.233 ns |  0.4429 ns |  0.4143 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   4 |        10 |      True |    68.658 ns |  1.3215 ns |  1.2362 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   4 |        10 |      True |    29.308 ns |  0.5498 ns |  0.5143 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  49 |        50 |     False |    21.784 ns |  0.2897 ns |  0.2710 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |  49 |        50 |      True |    36.656 ns |  0.5579 ns |  0.5219 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |  49 |        50 |      True |    74.163 ns |  1.0755 ns |  1.0061 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  49 |        50 |      True |    36.654 ns |  0.7481 ns |  0.6998 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  49 |       100 |     False |    21.909 ns |  0.2532 ns |  0.2369 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |  49 |       100 |      True |    36.211 ns |  0.6972 ns |  0.6522 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |  49 |       100 |      True |    74.790 ns |  1.3836 ns |  1.2265 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  49 |       100 |      True |    36.087 ns |  0.7648 ns |  0.7154 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   9 |        10 |     False |    21.638 ns |  0.2727 ns |  0.2417 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   9 |        10 |      True |    29.521 ns |  0.3530 ns |  0.3302 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   9 |        10 |      True |    70.127 ns |  1.4508 ns |  2.7249 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   9 |        10 |      True |    28.347 ns |  0.5643 ns |  0.5279 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   9 |        20 |     False |    20.538 ns |  0.4562 ns |  0.4881 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |   9 |        20 |      True |    29.047 ns |  0.5282 ns |  0.4683 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |   9 |        20 |      True |    67.345 ns |  1.3698 ns |  1.2813 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |   9 |        20 |      True |    29.009 ns |  0.5097 ns |  0.4768 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  99 |       100 |     False |    22.004 ns |  0.4353 ns |  0.4072 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|         ConcurrentDictionaryGet |  99 |       100 |      True |    35.516 ns |  0.6546 ns |  0.6123 ns | ConcurrentDictionary |         Get |     - |     - |     - |         - |
|         ConcurrentDictionarySet |  99 |       100 |      True |    73.361 ns |  1.1935 ns |  1.1164 ns | ConcurrentDictionary |         Set |     - |     - |     - |         - |
| ConcurrentDictionaryTryGetValue |  99 |       100 |      True |    35.998 ns |  0.7570 ns |  1.0362 ns | ConcurrentDictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |         0 |     False |     5.470 ns |  0.1139 ns |  0.1009 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |         5 |     False |    22.882 ns |  0.4865 ns |  0.4996 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   0 |         5 |      True |    27.054 ns |  0.5292 ns |  0.4950 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   0 |         5 |      True |    34.018 ns |  0.5207 ns |  0.4870 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |         5 |      True |    30.745 ns |  0.5678 ns |  0.5312 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |        10 |     False |    16.767 ns |  0.3614 ns |  0.3550 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   0 |        10 |      True |    20.390 ns |  0.2856 ns |  0.2532 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   0 |        10 |      True |    23.143 ns |  0.5010 ns |  0.4920 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |        10 |      True |    23.096 ns |  0.4012 ns |  0.3753 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |        20 |     False |    16.450 ns |  0.3208 ns |  0.3001 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   0 |        20 |      True |    21.177 ns |  0.4381 ns |  0.4098 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   0 |        20 |      True |    23.273 ns |  0.4416 ns |  0.5585 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |        20 |      True |    23.302 ns |  0.4834 ns |  0.5373 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |        50 |     False |    17.773 ns |  0.3745 ns |  0.3845 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   0 |        50 |      True |    20.661 ns |  0.5189 ns |  0.4854 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   0 |        50 |      True |    22.298 ns |  0.4296 ns |  0.3808 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |        50 |      True |    23.811 ns |  0.3777 ns |  0.3533 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |       100 |     False |    16.732 ns |  0.3716 ns |  0.3650 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   0 |       100 |      True |    20.066 ns |  0.4945 ns |  0.4857 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   0 |       100 |      True |    23.247 ns |  0.2799 ns |  0.3111 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   0 |       100 |      True |    24.118 ns |  0.4641 ns |  0.4341 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |  19 |        20 |     False |    16.527 ns |  0.2934 ns |  0.2744 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |  19 |        20 |      True |    27.395 ns |  0.6511 ns |  0.9943 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |  19 |        20 |      True |    32.379 ns |  0.3650 ns |  0.3236 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |  19 |        20 |      True |    31.100 ns |  0.6693 ns |  1.1365 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   2 |         5 |     False |    22.689 ns |  0.4673 ns |  0.4142 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   2 |         5 |      True |    23.309 ns |  0.5531 ns |  0.5173 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   2 |         5 |      True |    29.591 ns |  0.6318 ns |  0.6488 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   2 |         5 |      True |    26.403 ns |  0.4657 ns |  0.4356 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |  24 |        50 |     False |    16.490 ns |  0.3563 ns |  0.3659 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |  24 |        50 |      True |    26.871 ns |  0.5406 ns |  0.4793 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |  24 |        50 |      True |    31.917 ns |  0.6583 ns |  0.8326 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |  24 |        50 |      True |    30.994 ns |  0.4607 ns |  0.4084 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   4 |         5 |     False |    22.428 ns |  0.4734 ns |  0.4650 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   4 |         5 |      True |    20.243 ns |  0.4757 ns |  0.4449 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   4 |         5 |      True |    22.793 ns |  0.3903 ns |  0.3460 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   4 |         5 |      True |    22.966 ns |  0.3107 ns |  0.2906 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   4 |        10 |     False |    17.533 ns |  0.2619 ns |  0.2322 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   4 |        10 |      True |    20.527 ns |  0.4096 ns |  0.3631 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   4 |        10 |      True |    22.659 ns |  0.4795 ns |  0.4710 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   4 |        10 |      True |    23.763 ns |  0.5105 ns |  0.7157 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |  49 |        50 |     False |    17.903 ns |  0.2371 ns |  0.2218 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |  49 |        50 |      True |    27.182 ns |  0.5123 ns |  0.4792 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |  49 |        50 |      True |    31.312 ns |  0.5979 ns |  0.5300 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |  49 |        50 |      True |    31.379 ns |  0.5922 ns |  0.5540 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |  49 |       100 |     False |    17.834 ns |  0.2285 ns |  0.2137 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |  49 |       100 |      True |    27.431 ns |  0.6526 ns |  0.7769 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |  49 |       100 |      True |    32.476 ns |  0.6905 ns |  0.9451 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |  49 |       100 |      True |    30.707 ns |  0.6214 ns |  0.6907 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   9 |        10 |     False |    16.461 ns |  0.3712 ns |  0.3290 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   9 |        10 |      True |    20.414 ns |  0.4976 ns |  0.6293 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   9 |        10 |      True |    23.209 ns |  0.5075 ns |  0.6946 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   9 |        10 |      True |    23.346 ns |  0.4882 ns |  0.4795 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |   9 |        20 |     False |    16.640 ns |  0.2802 ns |  0.2621 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |   9 |        20 |      True |    19.984 ns |  0.3871 ns |  0.3621 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |   9 |        20 |      True |    22.587 ns |  0.4859 ns |  0.5200 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |   9 |        20 |      True |    23.200 ns |  0.3154 ns |  0.2796 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|           DictionaryTryGetValue |  99 |       100 |     False |    20.140 ns |  0.4241 ns |  0.3967 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|                   DictionaryGet |  99 |       100 |      True |    26.831 ns |  0.6260 ns |  0.6148 ns |           Dictionary |         Get |     - |     - |     - |         - |
|                   DictionarySet |  99 |       100 |      True |    31.983 ns |  0.4271 ns |  0.3566 ns |           Dictionary |         Set |     - |     - |     - |         - |
|           DictionaryTryGetValue |  99 |       100 |      True |    30.315 ns |  0.6280 ns |  0.7232 ns |           Dictionary | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |         0 |     False |     9.046 ns |  0.2162 ns |  0.2022 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |         5 |     False |    45.418 ns |  0.6394 ns |  0.5340 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   0 |         5 |      True |    13.172 ns |  0.3510 ns |  0.3283 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   0 |         5 |      True |    35.668 ns |  0.5579 ns |  0.4658 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |         5 |      True |    13.681 ns |  0.3004 ns |  0.3085 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |        10 |     False |   100.642 ns |  2.0131 ns |  1.8830 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   0 |        10 |      True |    12.590 ns |  0.3161 ns |  0.2957 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   0 |        10 |      True |    35.978 ns |  0.6904 ns |  0.6458 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |        10 |      True |    14.747 ns |  0.2862 ns |  0.2677 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |        20 |     False |   165.560 ns |  2.9471 ns |  2.6125 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   0 |        20 |      True |    13.148 ns |  0.2886 ns |  0.2699 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   0 |        20 |      True |    36.707 ns |  0.7458 ns |  0.7980 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |        20 |      True |    14.731 ns |  0.3411 ns |  0.3350 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |        50 |     False |   348.615 ns |  5.6765 ns |  5.3098 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   0 |        50 |      True |    12.812 ns |  0.3486 ns |  0.4014 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   0 |        50 |      True |    37.482 ns |  0.7812 ns |  0.8996 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |        50 |      True |    14.475 ns |  0.2792 ns |  0.2475 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |       100 |     False |   624.619 ns | 11.6128 ns | 11.4053 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   0 |       100 |      True |    13.031 ns |  0.3542 ns |  0.3479 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   0 |       100 |      True |    36.148 ns |  0.7526 ns |  0.7391 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   0 |       100 |      True |    13.702 ns |  0.3182 ns |  0.3268 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  19 |        20 |     False |   180.054 ns |  3.3982 ns |  3.1786 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |  19 |        20 |      True |   187.483 ns |  3.7734 ns |  4.0375 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |  19 |        20 |      True |   229.445 ns |  4.5486 ns |  5.2381 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  19 |        20 |      True |   208.971 ns |  4.1302 ns |  4.0564 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   2 |         5 |     False |    46.431 ns |  0.9216 ns |  0.8620 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   2 |         5 |      True |    30.994 ns |  0.7089 ns |  0.6631 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   2 |         5 |      True |    49.321 ns |  1.0012 ns |  1.0281 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   2 |         5 |      True |    33.398 ns |  0.6368 ns |  0.5957 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  24 |        50 |     False |   467.483 ns |  8.3370 ns |  7.3906 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |  24 |        50 |      True |   227.741 ns |  4.5164 ns |  5.0199 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |  24 |        50 |      True |   271.498 ns |  5.4293 ns |  6.6677 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  24 |        50 |      True |   239.379 ns |  3.1897 ns |  2.9836 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   4 |         5 |     False |    42.991 ns |  0.8998 ns |  0.8837 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   4 |         5 |      True |    50.691 ns |  0.9643 ns |  0.9020 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   4 |         5 |      True |    69.833 ns |  1.0319 ns |  0.9652 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   4 |         5 |      True |    51.923 ns |  0.9435 ns |  0.8826 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   4 |        10 |     False |   102.509 ns |  1.9302 ns |  1.8055 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   4 |        10 |      True |    49.250 ns |  1.0272 ns |  1.1417 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   4 |        10 |      True |    69.956 ns |  1.3644 ns |  1.3401 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   4 |        10 |      True |    51.765 ns |  1.0084 ns |  0.9433 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  49 |        50 |     False |   449.021 ns |  8.8644 ns |  9.4848 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |  49 |        50 |      True |   457.885 ns |  7.4956 ns |  8.0202 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |  49 |        50 |      True |   556.925 ns | 10.4062 ns | 10.2203 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  49 |        50 |      True |   464.848 ns |  6.8804 ns |  6.0993 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  49 |       100 |     False |   943.999 ns | 18.2708 ns | 17.0905 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |  49 |       100 |      True |   471.064 ns |  6.6909 ns |  5.9314 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |  49 |       100 |      True |   563.175 ns | 10.8739 ns | 12.0863 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  49 |       100 |      True |   499.154 ns |  8.2352 ns |  7.7033 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   9 |        10 |     False |   101.670 ns |  1.8778 ns |  1.7565 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   9 |        10 |      True |   108.389 ns |  2.1175 ns |  1.9807 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   9 |        10 |      True |   133.436 ns |  2.4353 ns |  2.2780 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   9 |        10 |      True |   107.786 ns |  2.1035 ns |  1.9676 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   9 |        20 |     False |   166.860 ns |  2.5469 ns |  2.3823 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |   9 |        20 |      True |   104.688 ns |  1.6822 ns |  1.5736 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |   9 |        20 |      True |   132.311 ns |  2.3239 ns |  2.1738 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |   9 |        20 |      True |   102.958 ns |  1.7901 ns |  1.6745 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  99 |       100 |     False |   909.978 ns | 17.4946 ns | 17.1820 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |
|                ExpandoObjectGet |  99 |       100 |      True |   915.002 ns | 12.8453 ns | 12.0155 ns |        ExpandoObject |         Get |     - |     - |     - |         - |
|                ExpandoObjectSet |  99 |       100 |      True | 1,112.395 ns | 21.4921 ns | 27.1806 ns |        ExpandoObject |         Set |     - |     - |     - |         - |
|        ExpandoObjectTryGetValue |  99 |       100 |      True |   954.111 ns | 18.4251 ns | 17.2348 ns |        ExpandoObject | TryGetValue |     - |     - |     - |         - |

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

## HashAlgorithms

This benchmark compares the performance of different hash algorithm implementations.

| Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
|    Md5 | 3.805 us | 0.0378 us | 0.0335 us | 0.0191 |     - |     - |      80 B |
|   Sha1 | 3.521 us | 0.0507 us | 0.0449 us | 0.0229 |     - |     - |      96 B |
| Sha256 | 8.480 us | 0.0919 us | 0.0860 us | 0.0153 |     - |     - |     112 B |
| Sha384 | 5.025 us | 0.0469 us | 0.0439 us | 0.0305 |     - |     - |     144 B |
| Sha512 | 4.985 us | 0.0528 us | 0.0494 us | 0.0381 |     - |     - |     176 B |

## Iterate

This benchmark compares the performance of iterating over different types of collections.

|                    Method |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|                  ForArray |  2.226 ms | 0.0165 ms | 0.0154 ms |     - |     - |     - |         - |
|                  ForIList |  7.002 ms | 0.0480 ms | 0.0426 ms |     - |     - |     - |         - |
|                   ForList |  2.254 ms | 0.0121 ms | 0.0108 ms |     - |     - |     - |         - |
|              ForeachArray |  2.208 ms | 0.0191 ms | 0.0179 ms |     - |     - |     - |         - |
|        ForeachIEnumerable |  7.194 ms | 0.0659 ms | 0.0617 ms |     - |     - |     - |      40 B |
|              ForeachIList | 12.415 ms | 0.0757 ms | 0.0671 ms |     - |     - |     - |      40 B |
|               ForeachList |  5.032 ms | 0.0443 ms | 0.0414 ms |     - |     - |     - |         - |
| ForeachArrayAsIEnumerable |  7.268 ms | 0.0567 ms | 0.0530 ms |     - |     - |     - |      32 B |

## ToList

This benchmark compares different ways to convert a IEnumerable to list.  
Naive uses `source.ToList()`.  
Optimized uses `(source as List<T>) ?? source.ToList()`.

|             Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|     NaiveFromArray | 136.811 ns | 2.1415 ns | 1.8984 ns | 0.0913 |     - |     - |     144 B |
|      NaiveFromList | 106.203 ns | 1.4056 ns | 1.2460 ns | 0.0914 |     - |     - |     144 B |
| OptimizedFromArray | 143.095 ns | 1.6491 ns | 1.5426 ns | 0.0913 |     - |     - |     144 B |
|  OptimizedFromList |   3.389 ns | 0.0838 ns | 0.0784 ns |      - |     - |     - |         - |