//check whether or not the number can be represented as the sum of its factors
int number = 6;
int sum=0;
for(int i=1; i<number; i++)
{
    if(number % i==0){
        sum=sum+i;
    Console.WriteLine("Factors "+ i);

    }
}
    Console.WriteLine(" sum of factors is "+ sum);


if(sum==number){
    Console.WriteLine(number+" is a perfect number");
}
else
    Console.WriteLine(number+" is not a perfect number");
