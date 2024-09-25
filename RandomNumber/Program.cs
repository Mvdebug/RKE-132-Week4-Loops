Random rnd = new Random();

int myRandomNum;


//int myRandomNum = rnd.Next(0, 11); // 0 - 10
//Console.WriteLine($"My random number: {myRandomNum}");

int myRandomSum = 0;
for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); // 0 - 10
    myRandomSum = myRandomSum + myRandomNum;
    Console.WriteLine($"My random number: {myRandomNum}");
}

Console.WriteLine($"random sum total: {myRandomSum}");
