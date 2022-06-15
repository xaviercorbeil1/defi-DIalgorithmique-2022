// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var sol1 = String.Join(',', solution.FindMissingRanges(new[] { 0, 1, 3, 50, 75 }, 0, 99));
var sol2 = String.Join(',', solution.FindMissingRanges(new[] { -1 }, -1, -1));

Console.WriteLine(sol1);
Console.WriteLine(sol2);

