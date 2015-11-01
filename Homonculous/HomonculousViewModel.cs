using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using Utility;
using System.Reflection;
using SB118_CrewHistoryApp;

namespace Utility
{
    public static partial class Utiity
    {
        public static List<string> GetEnumList<T>()
        {
            List<string> l = new List<string>();

            var t = typeof(T);
            if (!t.IsEnum)
                return l;

            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var member in members)
            {
                var attr = member.GetCustomAttribute(typeof(StringValueAttribute), false) as StringValueAttribute;
                if (attr == null)
                    l.Add(member.Name);
                else
                    l.Add(attr.Value);
            }
            return l;
        }
    }
}

namespace Homonculous
{
    public class HomonculousViewModel : PropertyChangedBase
    {
        public const string setVersion = "20151026A";

        private List<Starbase118HistoryEntry> _historyListing;
        public List<Starbase118HistoryEntry> historyListing
        {
            get { return GetField(ref _historyListing); }
            set { SetField(ref _historyListing, value); }
        }

        public HomonculousViewModel()
        {
            Console.WriteLine("View model bound");
            historyListing.Add(new Starbase118HistoryEntry("First", "Last", SB118_CrewHistoryApp.Enums.Starbase118Positions.Archaeologist, SB118_CrewHistoryApp.Enums.Starbase118Ranks.Cadet, new Stardate(DateTime.Today), new Stardate(DateTime.Today), null, null, true, true));
        }
    }
}