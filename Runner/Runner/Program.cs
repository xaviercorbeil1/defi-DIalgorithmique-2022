// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var sol1 = solution.ValidPalindrome("abca");
var sol2 = solution.ValidPalindrome("aba");


Console.WriteLine(sol1);
Console.WriteLine(sol2);
Console.WriteLine(solution.ValidPalindrome("racecar"));
Console.WriteLine(solution.ValidPalindrome("aracecar"));
Console.WriteLine(solution.ValidPalindrome("raacecar"));
Console.WriteLine(solution.ValidPalindrome("racecar"));
Console.WriteLine(solution.ValidPalindrome("raceecar"));
Console.WriteLine(solution.ValidPalindrome("racecarr"));
Console.WriteLine(solution.ValidPalindrome("racecaru"));
Console.WriteLine(solution.ValidPalindrome("aracecare"));


