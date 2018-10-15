using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castinet_AutomatesSmoke.TestCases.ReadJson
{
    public class JsonData
    {
        public LoginData Login { get; set; }
        public UrlData Url { get; set; }
        public WelcomeData Welcome { get; set; }
        public SearchClientData ClientSearch { get; set; }
        public LastNameData LastName { get; set; }
        public HouseHoldOverviewData HeadingHo { get; set; }
        public IndividualOverviewData HeadingIo { get; set; }
        public ProgramsServicesData ProgramServices { get; set; }
        public HouseholdHistoryData History { get; set; }
        public FamilyGoalPlanData FamilyGoalPlan { get; set; }
        public CaseNoteData CaseNote { get; set; }
        public IncomeData Income { get; set; }
        public FundinSourceData FundingSource { get; set; }
        public OrganizationData Organization { get; set; }
        public PartnerData Partners { get; set; }
        public ProgramData Programs { get; set; }
        public UsersData Users { get; set; }
        public TransmittalData Finance { get; set; }
    }
}
