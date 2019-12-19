The sample app contains 100 classes with a 100 methods each, the methods doesn't do anything.

Running all methods on all classes five times in a row takes:
```
477,4158 ms
8,1653 ms
0,1722 ms
0,1733 ms
0,1619 ms
```

Running them with pre jiting takes:
```
8,0562 ms
0,1879 ms
0,1701 ms
0,1458 ms
0,211 mss
```