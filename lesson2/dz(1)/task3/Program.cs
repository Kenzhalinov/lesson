int inputNum = int.Parse(Console.ReadLine()!);

if (inputNum >= 10 && inputNum <= 99){
    int first = inputNum / 10;
    int second = inputNum % 10;
    if (first > second){
        Console.WriteLine(first);
    }else{
        Console.WriteLine(second);
    };
}else{
    Console.WriteLine("Неверные парамметры ввода");
};