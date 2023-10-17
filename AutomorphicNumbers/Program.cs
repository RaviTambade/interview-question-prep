// Automorphic number-  if its square ends in the same digits as the number itself.

// 5 =(5)2 = 25
// 6 = (6)2 = 36
// 25 = (25)2 = 625


int x = 76;
int y = x * x;

if (y % 10 == x % 10){
    Console.WriteLine("automorphic");
   Console.WriteLine(y % 10 );
    Console.WriteLine(x % 10 );
} 

else
    Console.WriteLine("not");