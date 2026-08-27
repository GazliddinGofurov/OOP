2-masala: Talabalar reytingi (ValueTuple va Deconstruction)
Sinfda oʻquvchilarning ismlari va ballari berilgan.

Topshiriq: Metod yarating, u kirishga talabalar roʻyxatini (List<(string Name, int Score)>) olsin.

Natija: Eng yuqori ball olgan va eng past ball olgan talabalarni bitta ValueTuple koʻrinishida qaytarsin: (ValueTuple<string, int> Best, ValueTuple<string, int> Worst).

Shart: Metod natijasini chaqirib olayotganda Deconstruction (var (best, worst) = ...) xususiyatidan foydalanib ekranga chiqaring.


3-masala: Massiv statistikasi (Pattern Matching va Named Tuples)
Butun sonlar massivini tahlil qiluvchi metod yozing.

Topshiriq: Metod massivni qabul qilib, bir vaqtning oʻzida quyidagi 4 ta qiymatni nomlangan ValueTuple ((int Min, int Max, double Avg, int Sum)) koʻrinishida qaytarsin.

Shart: Agar massiv boʻsh boʻlsa, (0, 0, 0, 0) qaytarsin. Natijani switch yoki if orqali pattern matching yordamida tekshiring.

4-masala: Tuple vs ValueTuple xotira va taqqoslash (Nazariy/Amaliy)
Farqini amalda sinash uchun quyidagi amallarni bajaring:

Topshiriq:

Tuple<int, string> va ValueTuple<int, string> yaratib, 
ikkala turdagi ob'ektlarni == operatori va .Equals() metodi orqali 
taqqoslab koʻring. Qaysi biri == operatorini qoʻllab-quvvatlaydi?

Bitta Tuple yaratib, uning elementini oʻzgartirishga urinib koʻring (masalan, tuple.Item1 = 5;). Keyin xuddi shu ishni ValueTuple bilan qiling. Farqini izohlang.

5-masala
Lugʻat (Dictionary) kaliti sifatida Tuple
Koordinata tekisligida nuqtalar oʻrtasidagi masofani keshlaydigan (keshlash tizimi) dastur tuzing.

Topshiriq: Dictionary<(int X, int Y), string> lugʻatidan foydalaning.

Shart: Kalit sifatida (int X, int Y) ValueTuple ishlatilsin va unga mos ravishda shu nuqtadagi joy nomi (masalan, (3, 4) -> "Park") saqlansin.
Lugʻatdan koordinata boʻyicha ma'lumotni qidirib topuvchi va ekranga chiqaruvchi funksiya yozing.




5-masala: Matn tahlilchisi (Slovar va Harflar hisobi)
Satr (string) qabul qiluvchi metod yozing.

Topshiriq: Metod matndagi unli va undosh harflar sonini, hamda matn uzunligini bitta tupleda qaytarsin: (int Vowels, int Consonants, int TotalLength).

Kiritish: "Csharp dasturlash tili"

Chiqish: (7, 12, 21)