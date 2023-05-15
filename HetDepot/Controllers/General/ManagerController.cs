﻿using HetDepot.Controllers.Manager;
using HetDepot.Tours.Model;
using HetDepot.Views;
using HetDepot.Views.Interface;
using HetDepot.Views.Parts;

namespace HetDepot.Controllers.General;

public class ManagerController : Controller
{
    public override void Execute()
    {
        string personnelCode = (new InputView(
            Program.SettingService.GetConsoleText("consoleEnterPersonnelCode"),
            Program.SettingService.GetConsoleText("consoleGuidePersonnelNumber"))
        ).ShowAndGetResult();

        if (Program.PeopleService.GetManager().Equals(new People.Model.Manager(personnelCode)))
        {
            NextController = new ManagerPeriodQuestion();
        }
        else
        {
            (new AlertView(Program.SettingService.GetConsoleText("consoleGuideLogonCodeInvalid"),
                AlertView.Error)).Show();
        }
    }
}
