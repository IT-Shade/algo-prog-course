Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLength = 4.2;

double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");

Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");

Console.WriteLine();
Console.WriteLine("Внимание: деление int");

int totalStudents = 25;
int groupsCount = 4;

int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

Console.WriteLine($"25 / 4 как int:    {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");