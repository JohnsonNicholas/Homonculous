using System;

namespace SB118_CrewHistoryApp.Enums
{
    public enum Starbase118Positions
    {
        [SB118Division("Civilian")]
        [StringValue("None")]
        None,
        //commanding positions

        [SB118Division("Command")]
        [StringValue("Admiral In Charge")]
        AdmiralInCharge,

        [StringValue("Adminstrative Officer")]
        [SB118Division("Command")]
        AdminstrativeOfficer,

        [StringValue("Commanding Officer")]
        [SB118Division("Command")]
        CommandingOfficer,

        [StringValue("First Officer")]
        [SB118Division("Command")]
        FirstOfficer,

        [StringValue("Executive Officer")]
        [SB118Division("Command")]
        ExecutiveOfficer,

        [StringValue("Second Officer")]
        [SB118Division("Command")]
        SecondOfficer,

        [StringValue("Strategic Operations Officer")]
        [SB118Division("Command")]
        StrategicOperationsOfficer,

        //chief positions

        [StringValue("Chief Science Officer")]
        [SB118Division("Science")]
        ChiefScienceOfficer,

        [StringValue("Chief Security Officer")]
        [SB118Division("Operations")]
        ChiefSecurityOfficer,

        [StringValue("Chief of Security")]
        [SB118Division("Operations")]
        ChiefOfSecurity,

        [StringValue("Chief Security & Tactical Officer")]
        [SB118Division("Operations")]
        ChiefSecurityTactical,

        [StringValue("Chief Tactical Officer")]
        [SB118Division("Operations")]
        ChiefTacticalOfficer,

        [StringValue("Chief Engineering Officer")]
        [SB118Division("Engineering")]
        ChiefEngineeringOfficer,

        [StringValue("Chief Operations Officer")]
        [SB118Division("Operations")]
        ChiefOperationsOfficer,

        [StringValue("Chief Medical Officer")]
        [SB118Division("Medical")]
        ChiefMedicalOfficer,

        [StringValue("Chief Helm Officer")]
        [SB118Division("Command")]
        ChiefHelmOfficer,

        [StringValue("Chief Comm Officer")]
        [SB118Division("Operations")]
        ChiefCommOfficer,

        [StringValue("Chief Counsellor")]
        [SB118Division("Medical")]
        ChiefCounsellor,

        [StringValue("Chief HCO Officer")]
        [SB118Division("Command")]
        ChiefHCOOfficer,

        [StringValue("Chief Diplomatic Officer")]
        [SB118Division("Diplomatic Corps")]
        ChiefDiplomaticOfficer,

        [StringValue("Head of Intelligence")]
        [SB118Division("Intelligence")]
        HeadOfIntelligence,

        [StringValue("Director of Intelligence")]
        [SB118Division("Intelligence")]
        DirectorOfIntelligence,

        [StringValue("Chief Research Analyst")]
        [SB118Division("Science")]
        ChiefResearchAnalyst,

        [StringValue("Research Analyst")]
        [SB118Division("Science")]
        ResearchAnalyst,

        [StringValue("Chief of Operations and Communications")]
        [SB118Division("Operations")]
        ChiefofOperationsAndCommunications,

        [StringValue("Chief of Intelligence")]
        [SB118Division("Intelligence")]
        ChiefOfIntelligence,

        [StringValue("Chief Intelligence Officer")]
        [SB118Division("Intelligence")]
        ChiefIntelligenceOfficer,

        //assistant positions
        [SB118Division("Medical")]
        [StringValue("Assistant Chief Medical Officer")]
        AssistantChiefMedicalOfficer,

        [SB118Division("Operations")]
        [StringValue("Assistant Chief Tactical Officer")]
        AssistantChiefTacticalOfficer,

        [SB118Division("Operations")]
        [StringValue("Assistant Chief Medical Officer")]
        AssistantChiefSecurityOfficer,

        [SB118Division("Engineering")]
        [StringValue("Assistant Chief Engineering Officer")]
        AssistantChiefEngineeringOfficer,

        [SB118Division("Science")]
        [StringValue("Assistant Chief Science Officer")]
        AssistantChiefScienceOfficer,

        //command division
        [SB118Division("Command")]
        [StringValue("Mission Specalist")]
        MissionSpecalist,

        [SB118Division("Command")]
        [StringValue("Flight Control Officer")]
        FlightControlOfficer,

        [SB118Division("Command")]
        [StringValue("Deck Officer")]
        DeckOfficer,

        //diplomatic division
        [SB118Division("Diplomatic Corps")]
        [StringValue("Ambassador")]
        Ambassador,

        [SB118Division("Diplomatic Corps")]
        [StringValue("Diplomatic Vice Consul")]
        DiplomaticViceConsul,

        [SB118Division("Diplomatic Corps")]
        [StringValue("Diplomatic Attache")]
        DiplomaticAttache,

        [SB118Division("Diplomatic Corps")]
        [StringValue("General Envoy")]
        GeneralEnvoy,

        [SB118Division("Diplomatic Corps")]
        [StringValue("Diplomatic Officer")]
        DiplomaticOfficer,

        //intelligence division
        [SB118Division("Intelligence")]
        [StringValue("Intelligence Officer")]
        IntelligenceOfficer,

        [SB118Division("Intelligence")]
        [StringValue("Covert Specialist")]
        CovertSpecialist,

        //operations
        [SB118Division("Operations")]
        [StringValue("Engineering Officer")]
        EngineeringOfficer,

        [SB118Division("Command")]
        [StringValue("HCO Officer")]
        HCOOfficer,

        [SB118Division("Operations")]
        [StringValue("Tactical Officer")]
        TacticalOfficer,

        [SB118Division("Operations")]
        [StringValue("Comm Officer")]
        CommOfficer,

        [SB118Division("Command")]
        [StringValue("Helm Officer")]
        HelmOfficer,

        [SB118Division("Operations")]
        [StringValue("Helm/Ops Officer")]
        HelmOpsOfficer,

        [SB118Division("Operations")]
        [StringValue("Operations and Communications Officer")]
        OpsCommOfficer,

        [SB118Division("Operations")]
        [StringValue("Operations Officer")]
        OperationsOfficer,

        [SB118Division("Operations")]
        [StringValue("Security Officer")]
        SecurityOfficer,

        [SB118Division("Operations")]
        [StringValue("Lead of Research and Development")]
        LeadResearchDevelopment,

        [SB118Division("Operations")]
        [StringValue("Research and Development")]
        ResearchDevelopment,

        //science division
        [SB118Division("Science")]
        [StringValue("Science Officer")]
        ScienceOfficer,

        [SB118Division("Science")]
        [StringValue("History & Archaeology Officer")]
        HistoryArchaeologyOfficer,

        [SB118Division("Science")]
        [StringValue("Chief of History & Anthropology")]
        ChiefOfHistoryAnthropology,

        [SB118Division("Science")]
        [StringValue("Xenobiologist")]
        Xenobiologist,

        [SB118Division("Science")]
        [StringValue("Archaeologist")]
        Archaeologist,

        [SB118Division("Science")]
        [StringValue("Stellar Cartographer")]
        StellarCartographer,

        //medical division
        [SB118Division("Medical")]
        [StringValue("Medical Officer")]
        MedicalOfficer,

        [SB118Division("Medical")]
        [StringValue("Medical Research Specalist")]
        MedicalResearchSpecalist,

        [SB118Division("Medical")]
        [StringValue("Medical Researcher")]
        MedicalResearcher,

        [SB118Division("Medical")]
        [StringValue("Head Nurse")]
        HeadNurse,

        [SB118Division("Medical")]
        [StringValue("Nurse")]
        Nurse,

        [SB118Division("Medical")]
        [StringValue("Counsellors")]
        Counsellors,
     
        //marine

        [SB118Division("Marine")]
        [StringValue("Marine Commanding Officer")]
        MarineCommandingOfficer,

        [SB118Division("Marine")]
        [StringValue("Marine Fighter Pilot")]
        MarineFighterPilot,

        [SB118Division("Marine")]
        [StringValue("Commander Air Group")]
        CommanderAirGroup,

        [SB118Division("Marine")]
        [StringValue("Marine Officer")]
        MarineOfficer,

        [SB118Division("Marine")]
        [StringValue("CSAR Operations")]
        CSAROperations,

        //civilian
        [SB118Division("Civilian")]
        [StringValue("Civilian")]
        Civilian
    }
}
