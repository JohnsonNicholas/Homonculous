using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB118_CrewHistoryApp.Enums;

namespace SB118_CrewHistoryApp
{
    public class Starbase118Sorter
    {
        protected List<Starbase118HistoryEntry> unsortedList;

        protected Dictionary<Starbase118Positions, string> postTitle;
        protected Dictionary<Starbase118Positions, string> postDivision;
        protected Dictionary<Starbase118Ranks, string> rankTitle;
        protected Dictionary<Starbase118Ranks, string> rankPip;
        protected Dictionary<string, string> positionColor = new Dictionary<string, string>()
        {
            {"Command","Red" },
            {"Operations", "Gold" },
            {"Engineering", "Gold" },
            {"Medical", "Teal" },
            {"Science", "Blue" },
            {"Intelligence", "Black" },
            {"Diplomacy", "Purple" },
            {"Marine", "Green" },
            {"Civilian", "Silver" }
        };

        protected List<string> marineRanks = new List<string>
        {
            "StaffSergeant",
            "MarineSergeant",
            "Corporal",
            "LanceCorporal",
            "PrivateFirst",
            "Private",
            "GunnerySergeant",
            "MasterGunnerySergeant",
            "SergeantMajor",
            "Colonel",
            "Major",
            "Lieutenant1st",
            "Lieutenant2nd",
            "MarineCaptain",
            "LieutenantColonel",
            "Brigadier",
            "BrigadierGeneral",
            "MajorGeneral",
            "LieutenantGeneral",
            "General",
            "FieldMarshall"
        };

        //and now making my Comp Sci teacher weep.
        public Starbase118Sorter(List<Starbase118HistoryEntry> raw)
        {
            postTitle = new Dictionary<Starbase118Positions, string>();
            postDivision = new Dictionary<Starbase118Positions, string>();
            rankTitle = new Dictionary<Starbase118Ranks, string>();

            //iterate and create. Reflection is fine at startup, but stops it from being a problem at run-time
            foreach (Starbase118Positions foo in Enum.GetValues(typeof(Starbase118Positions)))
            {
                postDivision.Add(foo, EnumAttParser.GetDivisionValue(foo));
                postTitle.Add(foo, EnumAttParser.GetStringValue(foo));
            }

            foreach(Starbase118Ranks foo in Enum.GetValues(typeof(Starbase118Ranks)))
            {
                rankTitle.Add(foo, EnumAttParser.GetStringValue(foo));
            }

            unsortedList = raw.ToList(); //<_<
        }

        protected string getHeader(Starbase118Positions post)
        {
            string hdr = "{{Post|";
            hdr = hdr + positionColor[postDivision[post]] + "|";
            hdr = hdr + postTitle[post] + "}}" + Environment.NewLine;            

            return hdr;
        }

        public string PerformSort(string pipStyle)
        {
            string outStr = "";
            //first up, admiral in charge! We sort by the /dates/, then /rank/. 
            //The date left is considered the most important bit..

            //Command section
            outStr += DisplayPosts(Starbase118Positions.AdmiralInCharge, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.AdminstrativeOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.CommandingOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ExecutiveOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.FirstOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.SecondOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefHCOOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefHelmOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.StrategicOperationsOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.MissionSpecalist, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.DeckOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.FlightControlOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.HCOOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.HelmOfficer, pipStyle);

            //Operations Section
            outStr += "{{Label|Operations}}";
            outStr += DisplayPosts(Starbase118Positions.ChiefOperationsOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefofOperationsAndCommunications, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.OperationsOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefCommOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.CommOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.OpsCommOfficer, pipStyle);
            outStr += "{{Label|Security}}";
            outStr += DisplayPosts(Starbase118Positions.ChiefSecurityTactical, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefOfSecurity, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefSecurityOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.AssistantChiefSecurityOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.SecurityOfficer, pipStyle);
            outStr += "{{Label|Tactical}}";
            outStr += DisplayPosts(Starbase118Positions.ChiefTacticalOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.AssistantChiefTacticalOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.TacticalOfficer, pipStyle);
            outStr += "{{Label|Engineering}}";
            outStr += DisplayPosts(Starbase118Positions.ChiefEngineeringOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.AssistantChiefEngineeringOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.EngineeringOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.LeadResearchDevelopment, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ResearchDevelopment, pipStyle);

            //Medical Section
            outStr += "{{Label|Medical}}";
            outStr += DisplayPosts(Starbase118Positions.ChiefMedicalOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.AssistantChiefMedicalOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.MedicalOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.HeadNurse, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.Nurse, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.MedicalResearchSpecalist, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.MedicalResearcher, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefCounsellor, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.Counsellors, pipStyle);

            //Science Section
            outStr += "{{Label|Science}}";
            outStr += DisplayPosts(Starbase118Positions.ChiefResearchAnalyst, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ResearchAnalyst, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefScienceOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.AssistantChiefScienceOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ScienceOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.HistoryArchaeologyOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.Archaeologist, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.StellarCartographer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.Xenobiologist, pipStyle);


            //Marine Section
            outStr += "{{Label|Marine}}";
            outStr += DisplayPosts(Starbase118Positions.MarineCommandingOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.MarineOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.CommanderAirGroup, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.CSAROperations, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.MarineFighterPilot, pipStyle);

            //Diplomatic Corp Section
            outStr += "{{Label|Diplomacy}}";
            outStr += DisplayPosts(Starbase118Positions.DiplomaticAttache, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.DiplomaticViceConsul, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.Ambassador, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.DiplomaticOfficer, pipStyle);

            //Intelligence Section
            outStr += "{{Label|Intelligence}}";
            outStr += DisplayPosts(Starbase118Positions.HeadOfIntelligence, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.ChiefIntelligenceOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.IntelligenceOfficer, pipStyle);
            outStr += DisplayPosts(Starbase118Positions.CovertSpecialist, pipStyle);

            //Civilians
            outStr += "{{Label|Civilians}}";
            outStr += DisplayPosts(Starbase118Positions.Civilian, pipStyle);

            //LOA Section
            outStr += "{{Label|LoA}}";
            outStr += DisplayPosts(Starbase118Positions.None, pipStyle);

            /*
            //set any null leave date as today.
            (from ent in unsortedList
             where ent.charLeaveDate == null 
             select ent).ToList()
            .ForEach(x => x.charLeaveDate = new Stardate(DateTime.Today)); */

            return outStr;
        }

        protected string DisplayPosts(Starbase118Positions post, string pipStyle)
        {
            string outStr = "";

                if (unsortedList.Count(item => item.charPosition == post) > 0)
                {
                    //now to find any on ship and treat them as current, unless they have a listed end date
                    foreach (Starbase118HistoryEntry hist in unsortedList)
                    {
                    if (hist.charOnShip && hist.charLeaveDate != null)
                        hist.charLeaveDate = Stardate.Today();
                    }

                    var selection = unsortedList.Where(item => item.charPosition == post)
                                                .OrderByDescending(o => o.charLeaveDate);

                outStr += "{{Post|";
                outStr += positionColor[postDivision[post]] + "|";
                outStr += postTitle[post] + "}}" + Environment.NewLine;

                foreach (Starbase118HistoryEntry ent in selection)
                    {
                        if (!ent.hasNoLink)
                        {
                            if (ent.charOnShip) outStr += "{{New|";
                            else outStr += "{{Old|";
                        }

                        else
                        {
                            if (ent.charOnShip) outStr += "{{No Link New|";
                            else outStr += "{{No Link Old|";
                        }

                        outStr += rankTitle[ent.charRank] + "|";
                        outStr += ent.charFirstN + "|" + ent.charLastN + "|";

                        if (marineRanks.Contains(ent.charRank.ToString()))
                            outStr += positionColor["Marine"] + "|";
                        else
                            outStr += positionColor[postDivision[ent.charPosition]] + "|";

                        outStr += ent.charJoinDate.ToString() + " - ";

                         /*    if (ent.charOnShip == true)
                            outStr += "Present"; 
                        else */ if (ent.charLeaveDate == null)
                            outStr += "??????";
                        else
                            outStr += ent.charLeaveDate.ToString();

                        outStr += "|" + ent.charImgStr;
                        outStr += "|STYLE=" + pipStyle;

                        if (ent.charNotes != null)
                            outStr += "|NOTES=" + ent.charNotes;

                        outStr += "}}" + Environment.NewLine;
                    }
                }

            return outStr;
        }       
    }
}
