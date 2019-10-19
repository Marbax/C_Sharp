# C_Sharp
 .Net C# lessons

---
<details><summary>  1. .Net </summary><p>

### .Net framework(платформа):
 - FCL (framework class librarys)
    - BCL
    - WinForms - win app
    - WPF
    - WCF(устарела ,удалена)
    - ADO.NET - bd
    - ASP.NET - web
 - CLR (command language runtime) - замена JVM , содержит код в промежуточном языке IL , компилирует его под текущую платформу на лету(JIT)

IL(MSIL) - промежуточный язык , для компиляции в .NET

В C# есть понятие сборки (Asembly) - в сборку может входить несколько проектов , в проект несколько сборок , после компиляции получается либо .exe либо .dll(динамически линкуемые библиотеки, не имеет мейна ,вспомогательный , экзешник можно использовать как .dll), сборка может состоять из нескольких модулей  

---
### Модуль состоит :
- manifest - основная инфа , как запускать , что запускать 
- metadata - данные описывающие классы в сборке , есть метаклассы (описывают другие классы)
- MSIL(IL) code - промежуточный код
- Resources(не обязательна)

>Доп инфа об устройстве CLR в книге Джеффри Рихтер **"CLR via C#"** (актульно при трудоустройстве)

Rider от jetBrains - только для консольных приложений

>Все библиотеки в шарпе в неймспейсах.  
Ненужно ничего инклюдить  
.Peek(dotPeek) - разворачивает экзешники .Net

Апфускатор - запутывает код ,чтобы его не котрыли , используется перед релизом 

---
### Типы данных C#
>Все наследуется от Object 

- Object
    - ValueType (обьекты структуры) - размещаются в стеке (можно разместить в куче если это поле класса )
        - short(псевдоним) - Int16
        - int - Int32
        - long - Int64
        - float - Single
        - double - Double
        - char - Char(2 byte любая кодировка)
        - bool - Boolean
        - byte(один байт любой инфы (например для работы с потоками )) - Byte
        - decimal(точнее чем double) - Decimal
    - Reference (обьекты класса)  - размещаются **исключительно** в куче
        - Array 
        - string(не изменяемый , read only) - String
    

>Работать лучше с псевдонимами  
Неявное преобразование работает только к сужжающему(если не нужно больше памяти)
`var` как `auto` в C++
результат тернарного оператора куда то нужно записывать  
`switch` обязательны брейки и дефолт  
`if` должны быть закончены  
циклы те же , есть еще `for each`(`foreach (var item in str)`) синаксистакой же   
`decimal d = 12.3m;`  
`float f = 12.3f;`  
`string str = null;` - ссылка это как указатель в плюсах  , а `null` вместо `nullptr`  
`Nullable<int> a = null;` - разрешает хранить ноль (устаревший)  
`int? a = null` - синтаксический сахар , то же что и выше  
`int b = a??0;` - проверка ,тернаярный оператор , проверяет что записать  

---
### HW
задачи(нужно 5 , чтобы считало быстро (меньше 15 сек)) проверять на https://www.projecteuler.net/ (нужно регаться? задачи на переменные иф элс циклы ,без сложных конструкций)  

</p></details>


<details><summary>  2. Array.String.Enum </summary><p>

Массив обьект ссылочного типа ,нельзя присвоить не запросив памяти в куче.
Массив может быть только динамическим , в стеке только ссылка на него.

Массив создается `int[] arr = new int [10];`(на 10 эллементов, не забивается мусором) то же что и в плюсах - `int *int = new int[10];`
Двумерный массив `int[,] arr = new int[4,5];` 4 ряда , 5 столбцев `arr.Length` вернет ряд*столб , для получения первого измерения нужно -`arr.GetLength(0);`

`Console.WriteLine(arr[i/arr.GetLength(1),i%arr.GetLength(1)] + " " );` - можно перебрать одним циклом двумерный массив


<details><summary>  Рваный массив  </summary><p>

```C#

            int[][] arr = new int[row][]; // массив ссылок на интовые массивы

            for (var i = 0; i < arr.Length; i++) // 12 массивов , каждый
            {
                arr[i] = new int[rnd.Next(3, 15)]; // рваный массив от 3-14 размера

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(20, 25);
                }
            }

            foreach (var line in arr)
            {
                foreach (var j in line)
                {
                    Console.Write(j + " " );
                }
            }

```
</p></details>

<details><summary>  Сортировка рваного массива по размеру строк  </summary><p>

```C#

    Array.Sort(arr, compareArray);

        public static int compareArray(int []a , int []b)
        {
            return a.Length - b.Length;
        }



```

</p></details>

`Console.WriteLine("\n\n\n" + arr[0].Average() + " " + arr[0].Sum());` - полезные методы из библиотеки using System.Linq;

`(a,b,c)=(c,b,a);` - меняет значения местами , такой себе своп

---
## Строковые методы и тд

`string str` - не такой как в плюсах , это ссылка на чаровский массив. Строки в шарпе не изменяемы (константы). Любой метод работы со строкой - возвращает новую строку.

```C#

string str = new string(new char[] {'h','e','l','l'});
string str1 = "Hell";

```

`Console.WriteLine("HEllo".Insert(2," not "));` - вставка строки в строку , со второго эллемента

`Console.WriteLine("hello".Remove(0,1));` - удаляет из строки с нулевого эллемента один эллемент ,если не указывать второй параметр - удалит все 

`Console.WriteLine("hello".Replace("el","il"));` - заменяет все совпадения на что то (el на il)


### Дэфолтный сплит по пробелу
```C#

string[] arr = "hello my friend".Split();
foreach(var item in arr)
Console.WriteLine(item);
        

```

### Кастомный сплит по массиву разделителей и игнором (не добавляет пустые строки)

```C#

string[] arr = "hello my,friend: and bye".Split(",. :/".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
foreach(var item in arr)
Console.WriteLine(item);

```

`Console.WriteLine("   . .    trimmer    / /   ".Trim('.',',',' ','/'));` - отрезает с ЛЕВА или с КОНЦА совпадения из перечисления тримера 

`Console.WriteLine("hello".CompareTo("Hello"));` - сравнение строк (больше ,меньше ,равно)

`Console.WriteLine("hello".EndsWith("ol"));` - пролверяет заканчивается ли строка на подстроку ( тру/фолс)

`Console.WriteLine("hello".IndexOf("ll"));` - возвращает индекс начала подстроки в строке(есть аналог с конца искать)

`Console.WriteLine("hello".PadLeft(6,'_'));` - добавляет слева символы ,количество которых равно передаваемому числу - размер строки 

`Console.WriteLine("today {0} {1} {2}", 19, "october", 2019);` - старый метод
`Console.WriteLine($"today {19} {"October"} {2019}");` - интерполированые строки


Округляет и откидывает символы после точки
```C#

double a = 2.55;
Console.WriteLine($"{a:.0}");
Console.WriteLine($"{a:0}"); // до целого
```

Превращение строки в сырую строку(эскейп последовательности игнорятся и тд)
```C#
Console.WriteLine(@"C:\program\
appdata");
```

Доп класс , больше похожий на строку из плюсов, но методов меньше , изменяет текущую строку ,а не делает новую (дольше работает и лишняя память используется), нужен для активного редактирования строк , чтобы не создавать кучу копий , можно конвертировать в стрингобычный и назад.
```C#

StringBuilder sb = new StringBuilder("Hello");
sb[0] = 'h';

```

Создавст кучу мусора (15 раз создает копию)
```C#

            string id = "";
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                if (i < 5 || i > 10)
                    id += rnd.Next(5);
                else
                    id += (char)rnd.Next(65, 93);
            }

```

Будет быстрее и не так много мусора
```C#

            StringBuilder sb = new StringBuilder("");

            string id = "";
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                if (i < 5 || i > 10)
                    sb.Append(rnd.Next(5));
                else
                    sb.Append(rnd.Next((char)rnd.Next(65, 93)));
            }
            id = sb.ToString();
            Console.WriteLine(id);

```

---

## Enum

```C#

enum Gender:long
        {
            Male,
            Female,
            Unknown
        }

```


Enum выводится как строка 
```C#

            Gender gender = Gender.Male;
            Console.WriteLine(gender);

```

Выводит виндовые кнпоки (System.Win.Forms)
```C#

foreach (int key in Enum.GetValues(typeof(Keys)))
    Console.WriteLine($"{key}->{Enum.GetName(typeof(Keys),key)}");

```

>HW  
СТРОКИ  
Оставить только 1 экземпляр ,там где повторы  
первый 3 задания просто стрингами  
4-5 лучше стрингБилдером
удалять символы которые > 1 раза    
МАССИВЫ  
1 размер оставлять таким же ?
3 двумерные массивы [,] не [][] можно свопом (a,b)=(b,a)


</p></details>


