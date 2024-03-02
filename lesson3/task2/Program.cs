int num = int.Parse(Console.ReadLine()!);

void Qrt(int a){
 
    for (int i = 1; i<a ;i++){
        Console.Write($"{i*i} ");
    };
};
Qrt(num);