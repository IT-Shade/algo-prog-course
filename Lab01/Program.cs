
// БЛОК 1. КОМНАТА
// Размеры комнаты известны заранее и не меняются — const.
// Площадь и периметр — это результаты вычислений, это переменные.
Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;  // S = a * b
double roomLength = 4.2; // P = (a + b) * 2

double roomArea = roomWidth * roomLength; // ширина комнаты, м
double roomPerimeter = (roomWidth + roomLength) * 2; // P = (a + b) * 2

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");

// БЛОК 2. ПОКУПКА НОУТБУКА В РАССРОЧКУ
// Условия рассрочки заданы заранее — const.
// Итоговая сумма и платёж в месяц — вычисляемые переменные.
Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000; // цена ноутбука, руб.
int monthsCount = 12; // срок рассрочки, мес.
double interestRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");

// БЛОК 3. СТРОКИ
// Имя и фамилия — данные человека. В рамках примера они заданы
// заранее и не меняются, поэтому их тоже можно сделать const.
Console.WriteLine();
Console.WriteLine("Способы собрать строку");

string firstName = "Анна";
string lastName = "Смирнова";

// Способ 1: конкатенация через оператор +
string fullNameConcat = firstName + " " + lastName;

// Способ 2: интерполяция через $""
string fullNameInterp = $"{firstName} {lastName}";

string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

// БЛОК 4. КОНСТАНТЫ (СТАВКА НДС И НАЗВАНИЕ УЧЕБНОГО ЗАВЕДЕНИЯ)
// Задача блока — показать использование const
// Ключевое слово const защищает их от случайного переприсваивания

Console.WriteLine();
Console.WriteLine("Константы");

const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ"; // название заведения

double productPrice = 1000; // productPrice — НЕ const
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");