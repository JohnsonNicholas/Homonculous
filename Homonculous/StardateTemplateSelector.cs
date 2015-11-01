using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SB118_CrewHistoryApp;

namespace Homonculous
{
    public class StardateTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BeforeFounding { get; set; }
        public DataTemplate EraOne { get; set; }
        public DataTemplate EraTwo { get; set; }
        public DataTemplate EraThree { get; set; }
        public DataTemplate EraFour { get; set; }
        public DataTemplate EraFive { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Stardate)
            {
                Stardate ItemAsStardate = item as Stardate;
                if (ItemAsStardate.baseYear > 2017)
                    return EraFive;

                if (ItemAsStardate.baseYear > 2011)
                    return EraFour;

                if (ItemAsStardate.baseYear > 2005)
                    return EraThree;

                if (ItemAsStardate.baseYear > 1999)
                    return EraTwo;

                if (ItemAsStardate.baseYear > 1994)
                    return EraOne;

                return BeforeFounding;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
