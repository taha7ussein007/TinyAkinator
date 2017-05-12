using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TinyAkinator
{
    public enum MYCIN_TERM_FACTOR
    {
        DEFINITELY_NOT = -100,
        ALMOST_CERTAINLY_NOT = -80,
        PROBABLY_NOT = -60,
        MAYBE_NOT = -40,
        UNKNOWN = 0,
        MAYBE_YES = 40,
        PROBABLY_YES = 60,
        ALMOST_CERTAINLY_YES = 80,
        DEFINITELY_YES = 100
    }
    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText(Environment.NewLine + value);
        }
    }
    public static class EnumerableExtension
    {
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}