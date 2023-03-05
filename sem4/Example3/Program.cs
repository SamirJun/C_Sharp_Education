int Factorial(int n){
  int rst = 1;
  for (int i = 1; i <= n; i++){
    rst = rst * i;
  }
  return rst;
}
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(N));