string inputNum =Console.ReadLine()!;
string res = "";
int len = inputNum.Length;
for (int i =0; i<len;i++){
    res = res + inputNum[i];
    if (len-1 > i){
        res = res +",";
    }
}
Console.WriteLine(res);