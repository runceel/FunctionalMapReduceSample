namespace CSSample
{
    using System;
    using System.Reactive.Linq;
    using System.Linq;

    class Program
    {
        // Interactive Extensions
        static void Main(string[] args)
        {
            var ret = EnumerableEx
                // 無限リスト?
                .Generate(0, _ => true, i => i + 1, i => i)
                // Tuple化
                .Zip(new[] { 10, 20, 30, 40, 50 }, Tuple.Create)
                // Map
                .Select(t => t.Item1 * t.Item2)
                // Reduce(Sumを使ったほうがいいけど、任意の集計という意味合いも
                // こめてAggregate使ってみた
                .Aggregate((i, j) => i + j);
            // 表示
            Console.WriteLine(ret);
        }
    }
}
