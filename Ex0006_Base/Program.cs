﻿int a = 4;
int b = 3;
int c = 8;
int d = 7;
int e = 1;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);