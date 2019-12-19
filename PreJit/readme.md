The sample app contains 100 classes with a 100 methods each, the methods doesn't do anything.

Running all methods on all classes five times in a row takes:
```
execute : 468,6694 ms
execute : 7,0895 ms
execute : 0,146 ms
execute : 0,1382 ms
execute : 0,2264 ms
```

Running them with pre jiting takes:
```
jit : 500,019 ms
execute : 7,1979 ms
execute : 0,3027 ms
execute : 0,2369 ms
execute : 0,1578 ms
execute : 0,2223 ms
```