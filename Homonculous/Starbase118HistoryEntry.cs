using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB118_CrewHistoryApp.Enums;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Utility;

namespace Utility
{
    public class PropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(sender, e);
        }

        protected string GetField(ref string target)
        {
            if (target == null)
                target = "";
            return target;
        }

        protected T GetField<T>(ref T target) where T : new()
        {
            if (target == null)
                target = new T();
            return target;
        }

        protected void SetField<T>(ref T target, T value, [CallerMemberName] string property = "")
        {
            target = value;
            RaisePropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}


namespace SB118_CrewHistoryApp
{
    public class Starbase118HistoryEntry : PropertyChangedBase
    {
        private string _charFirstN;
        public string charFirstN
        {
            get { return GetField(ref _charFirstN); }
            set { SetField(ref _charFirstN, value); }
        }

        private string _charLastN;
        public string charLastN
        {
            get { return GetField(ref _charLastN); }
            set { SetField(ref _charLastN, value); }
        }

        private Starbase118Positions _charPosition;
        public Starbase118Positions charPosition
        {
            get { return GetField(ref _charPosition); }
            set { SetField(ref _charPosition, value); }
        }

        private Starbase118Ranks _charRank;
        public Starbase118Ranks charRank
        {
            get { return GetField(ref _charRank); }
            set { SetField(ref _charRank, value); }
        }

        private Stardate _charJoinDate;
        public Stardate charJoinDate
        {
            get { return GetField(ref _charJoinDate); }
            set { SetField(ref _charJoinDate, value); }
        }

        private Stardate _charLeaveDate;
        public Stardate charLeaveDate
        {
            get { return GetField(ref _charLeaveDate); }
            set { SetField(ref _charLeaveDate, value); }
        }

        private string _charImgStr;
        public string charImgStr
        {
            get { return GetField(ref _charImgStr); }
            set { SetField(ref _charImgStr, value); }
        }


        private string _charNotes;
        public string charNotes
        {
            get { return GetField(ref _charNotes); }
            set { SetField(ref _charNotes, value); }
        }

        private bool _charOnShip;
        public bool charOnShip
        {
            get { return GetField(ref _charOnShip); }
            set { SetField(ref _charOnShip, value); }
        }

        private bool _hasNoLink;
        public bool hasNoLink
        {
            get { return GetField(ref _hasNoLink); }
            set { SetField(ref _hasNoLink, value); }
        }

        public Starbase118HistoryEntry()
        {

        }

        public Starbase118HistoryEntry(string first, string last, Starbase118Positions post, Starbase118Ranks rank,
               Stardate joinD, Stardate leaveD, string image, string notes, bool currMember, bool hasProfile)
        {
            charFirstN = first;
            charLastN = last;
            charPosition = post;
            charRank = rank;
            charJoinDate = joinD;
            charLeaveDate = leaveD;
            charImgStr = image;
            charNotes = notes;
            charOnShip = currMember;
            hasNoLink = hasProfile;
            
        }

       public Starbase118HistoryEntry(Starbase118HistoryEntry c)
        {
            charFirstN = c.charFirstN;
            charLastN = c.charLastN;
            charPosition = c.charPosition;
            charRank = c.charRank;
            charJoinDate = new Stardate(c.charJoinDate);
            charLeaveDate = new Stardate(c.charLeaveDate);
            charImgStr = c.charImgStr;
            charNotes = c.charNotes;
            charOnShip = c.charOnShip;
            hasNoLink = c.hasNoLink;
        }
    }
}
