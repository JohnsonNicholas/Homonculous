using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Utility;

namespace SB118_CrewHistoryApp
{
    public class Stardate : PropertyChangedBase, IComparable<Stardate>
    {
        /// <summary>
        /// This is the conversion.
        /// </summary>
        protected const int convFactor = 377;

        private int _baseYear;
        public int baseYear
        {
            get { return GetField(ref _baseYear); }
            set { SetField(ref _baseYear, value); }
            
            //RaisePropertyChanged(StardateColor, new System.ComponentModel.PropertyChangedEventArgs("StardateColor")); }
        }

        private int _baseMnth;
        public int baseMnth
        {
            get { return GetField(ref _baseMnth); }
            set { SetField(ref _baseMnth, value); }
            
            // RaisePropertyChanged(StardateColor, new System.ComponentModel.PropertyChangedEventArgs("StardateColor")); }
        }

        private int _baseDay;
        public int baseDay
        {
            get { return GetField(ref _baseDay); }
            set { SetField(ref _baseDay, value); }
            // RaisePropertyChanged(StardateColor, new System.ComponentModel.PropertyChangedEventArgs("StardateColor")); }
        }

        public string stardateAsString
        {
            get
            {
                return (baseYear + convFactor).ToString() + baseMnth.ToString("00") + "." + baseDay.ToString("00");
            }
            set
            {
                double test;
                if (!double.TryParse(value, out test))
                {
                    Console.WriteLine("STARDATE ERROR: " + value + " isn't numeric.");
                    return;
                }
                if (value.Length < 6)
                {
                    Console.WriteLine("STARDATE ERROR: " + value + " is too short to be a real stormtrooper.");
                    return;
                }
                if (value.Length > 6 && value[6] != '.')
                {
                    Console.WriteLine("STARDATE ERROR: " + value + " doesn't have a decimal point in the right spot.");
                    return;
                }
                int thisYear, thisMonth, thisDay;
                if (!int.TryParse(value.Substring(0, 4), out thisYear))
                {
                    Console.WriteLine("STARDATE ERROR: Couldn't find a goodyear blimp.");
                    return;
                }
                if (!int.TryParse(value.Substring(4, 2), out thisMonth) || thisMonth < 1 || thisMonth > 12)
                {
                    Console.WriteLine("STARDATE ERROR: The month didn't work out.");
                    return;
                }
                if (value.Length <= 6 || !int.TryParse(value.Substring(7, value.Length - 7), out thisDay) || thisDay < 1 || thisDay > 31)
                {
                    thisDay = 1;
                }

                baseYear = thisYear;
                baseMnth = thisMonth;
                baseDay = thisDay;
            }
        }
         


        public Stardate() //default constructor
        {

        }

        public Stardate(int year, int mnth, int day)
        {
            baseDay = day;
            baseMnth = mnth;
            baseYear = year;
        }

        public Stardate(DateTime d)
        {
            baseDay = d.Day;
            baseMnth = d.Month;
            baseYear = d.Year;
        }
      
        public Stardate(Stardate c)
        {
            if (c != null)
            {
                this.baseDay = c.baseDay;
                this.baseMnth = c.baseMnth;
                this.baseYear = c.baseYear;
            }
            else
            {
                this.baseDay = 0;
                this.baseMnth = 0;
                this.baseYear = 0;
            }
        }


        public string frmtStardate()
        {
            return (baseYear + convFactor).ToString() + baseMnth.ToString("00") + "." + baseDay.ToString("00");
        }

        public override string ToString()
        {
            return frmtStardate();
        }

        public bool IsEmpty()
        {
            if (this.baseDay == 0 && this.baseMnth == 0 && this.baseYear == 0)
                return true;
            else
                return false;
        }

        public static Stardate ConvertString(string rawInput)
        {
            //pattern is XXXXYY.ZZ
            Stardate c = new Stardate();
            try {
                c.baseYear = Convert.ToInt32(rawInput.Substring(0, 4)) - convFactor; 
                    //we already have this in, so let's subtract it here
                c.baseMnth = Convert.ToInt32(rawInput.Substring(4, 2));
                c.baseDay = Convert.ToInt32(rawInput.Substring(7, 2));
                return c;
            }
            catch
            {
                throw new Exception("The passed stardate is invalid");
            }
        }

        public static Stardate Today()
        {
            return new Stardate(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        }


        //interface implementation
        public int CompareTo(Stardate other)
        {
            if (other == null)
                return 1;

            if (this.baseYear > other.baseYear)
                return 1;
            else if (this.baseYear == other.baseYear)
            {
                if (this.baseMnth > other.baseMnth)
                    return 1;
                else if (this.baseMnth < other.baseMnth)
                    return -1;
                else if (this.baseMnth == other.baseMnth)
                {
                    if (this.baseDay > other.baseDay)
                        return 1;
                    else if (this.baseDay == other.baseDay)
                        return 0;
                    else if (this.baseDay < other.baseDay)
                        return -1;
                }
            }

            else if (this.baseYear < other.baseYear)
                return -1;

            return 0;
        }

        public static bool operator <(Stardate s1, Stardate s2)
        {
            return s1.CompareTo(s2) < 0;
        }
        public static bool operator >(Stardate s1, Stardate s2)
        {
            return s1.CompareTo(s2) > 0;
        }

        //DateTime conversions!
        public int CompareTo(DateTime other)
        {
            if (other == null)
                return 1;

            if (this.baseYear > other.Year)
                return 1;
            else if (this.baseYear == other.Year)
            {
                if (this.baseMnth > other.Month)
                    return 1;
                else if (this.baseMnth < other.Month)
                    return -1;
                else if (this.baseMnth == other.Month)
                {
                    if (this.baseDay > other.Day)
                        return 1;
                    else if (this.baseDay == other.Day)
                        return 0;
                    else if (this.baseDay < other.Day)
                        return -1;
                }
            }

            if (this.baseYear < other.Year)
                return -1;

            return 0;
        }

        public static bool operator <(Stardate s1, DateTime s2)
        {
            return s1.CompareTo(s2) < 0;
        }
        public static bool operator >(Stardate s1, DateTime s2)
        {
            return s1.CompareTo(s2) > 0;
        }
    }
}
