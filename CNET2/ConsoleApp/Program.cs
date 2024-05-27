﻿using ConsoleApp;
using System.Linq;


var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
// vypište čísla v poli numbers jako slova

var jako_slova = numbers.Select(num => strings[num]);
Console.WriteLine($"jako slova: {string.Join(", ", jako_slova)}");












//int[] numbers = { 11, 2, 13, -97542, 44, -5, 6, 127, -99, 0, 256, 0, 12, 11 };

//// 1.  kolik obsahuje pole kladných čísel
//// 2.  kolik obsahuje pole záporných čísel
//// 3.  sumu kladných hodnot
//// 4.  největší absolutní hodnotu
//// 5.  všechna kladná sudá čísla
//// 6.  seřaďte pole od nejmenších po největší hodnoty,
//// 7.  přeskočte první 3 prvky a sečtěte zbytek hodnot

//var pocet_kladnych = numbers.Where(x => x > 0).Count();
//Console.WriteLine($"pocet_kladnych: {pocet_kladnych}");

//var pocet_zapornych = numbers.Where(x => x < 0).Count();
//Console.WriteLine($"pocet_zapornych: {pocet_zapornych}");

//var suma_kladnych = numbers.Where(x => x > 0).Sum();
//Console.WriteLine($"suma_kladnych: {suma_kladnych}");

//var nejv_abs = numbers.Select(x => Math.Abs(x)).Max();
//Console.WriteLine($"nejv_abs: {nejv_abs}");

//var kladna_suda = numbers.Where(x => x > 0 && x % 2 == 0);
//Console.WriteLine($"kladna_suda: {string.Join(", ",kladna_suda)}");

//var ordered = numbers.OrderBy(x => x);
//Console.WriteLine($"ordered: {string.Join(", ", ordered)}");

//var skip3sum = numbers.Skip(3).Sum();
//Console.WriteLine($"skip3sum: {skip3sum}");


//// All, Any
//bool vsechna_kladna = numbers.All(x => x > 0);
//bool alespon_jedno_kladne = numbers.Any(x => x > 0);


//var fruits = new[] { "aPPLE", "BlUeBeRrY", "cHeRry", "RaspbeRry" };

//// zjistěte kolik obsahují všechna slova v poli "fruits" dohromady písmen
//var dohromady_pismen = fruits.Select(f => f.Length).Sum();
//Console.WriteLine($"dohromady pismen {dohromady_pismen}");

////lowercase
//var fruits_lower = fruits.Select(x => x.ToLower());
//Console.WriteLine($"fruits lower: {string.Join(", ",fruits_lower)}");

//// uppercase + lowercase combo
//var fruits_combo = fruits.Select(x => new
//{
//    Uppercase = x.ToUpper(),
//    Lowercse = x.ToLower()
//});
//Console.WriteLine($"fruits combo: {string.Join(", ", fruits_combo)}");
















//List<string> jmena_list = ["Lukáš", "Karel", "Tomáš",
//            "Martin", "Radim", "Jakub", "Sofián"];


//int[] numbers = [13, 32335, -18, 0, 23, 233, 0, -12, 1235, -16000, 128933484];

//// WHERE - filtr
//var kladna = numbers
//            .Where(number => number > 0)
//            .ToList();

//// ORDER BY
//var ordered_desc = numbers
//            .OrderByDescending(number => number);

//// TAKE, SKIP
//var first5 = numbers.Take(5);
//var skip5 = numbers.Skip(5);

//// MAX, MIN, SUM, AVG - agregační
//var sum = numbers.Sum(number => number);
//var max = numbers.Max(number => number);

//Console.WriteLine($"sum: {sum}");
//Console.WriteLine($"max: {max}");

//// SELECT - transformace
//var positive = numbers
//        .Select(number => Math.Abs(number))
//        .Where(number => number > 1000);


//foreach (int number in positive)
//{
//    Console.WriteLine(number);
//}