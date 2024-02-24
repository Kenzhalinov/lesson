int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0){
    Console.WriteLine("I");
}else if (x < 0 && y > 0){
    Console.WriteLine("II");
}else if ( x < 0 && y < 0){
    Console.WriteLine("III");
}else{
    Console.WriteLine("IV");
};