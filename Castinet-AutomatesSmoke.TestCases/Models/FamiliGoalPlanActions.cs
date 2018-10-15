using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castinet_AutomatesSmoke.TestCases.Utilities;
using Castinet_AutomatesSmoke.TestCases.PageObjects;

namespace Castinet_AutomatesSmoke.TestCases.Models
{
    public class FamiliGoalPlanActions
    {
        public static void FamilyGoalPlan()
        {
            HouseHoldOverviewAction.HouseHoldOverview();
            WebDriverUtils.ClickAction(FamilyGoalPlanPageObjects.FamilyGoalPlanLink());
        }

        public static void FamilyGoalPlanCreate()
        {
            HouseHoldOverviewAction.HouseHoldOverview();
            WebDriverUtils.ClickAction(FamilyGoalPlanPageObjects.FamilyGoalPlanLink());
            WebDriverUtils.ClickAction(FamilyGoalPlanPageObjects.FamilyGoalCreatePlanLink());
        }
    }
}
