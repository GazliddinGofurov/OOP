2-masala: Talabalar reytingi (ValueTuple va Deconstruction)
Sinfda oʻquvchilarning ismlari va ballari berilgan.

Topshiriq: Metod yarating, u kirishga talabalar roʻyxatini (List<(string Name, int Score)>) olsin.

Natija: Eng yuqori ball olgan va eng past ball olgan talabalarni bitta ValueTuple koʻrinishida qaytarsin: (ValueTuple<string, int> Best, ValueTuple<string, int> Worst).

Shart: Metod natijasini chaqirib olayotganda Deconstruction (var (best, worst) = ...) xususiyatidan foydalanib ekranga chiqaring.


3-masala: Massiv statistikasi (Pattern Matching va Named Tuples)
Butun sonlar massivini tahlil qiluvchi metod yozing.

Topshiriq: Metod massivni qabul qilib, bir vaqtning oʻzida quyidagi 4 ta qiymatni nomlangan ValueTuple ((int Min, int Max, double Avg, int Sum)) koʻrinishida qaytarsin.

Shart: Agar massiv boʻsh boʻlsa, (0, 0, 0, 0) qaytarsin. Natijani switch yoki if orqali pattern matching yordamida tekshiring.