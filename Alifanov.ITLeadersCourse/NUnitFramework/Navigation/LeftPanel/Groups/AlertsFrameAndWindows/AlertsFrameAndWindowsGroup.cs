﻿namespace NUnitFramework.Navigation.LeftPanel.Groups.AlertsFrameAndWindows
{
    using NUnitFramework.Pages.AlertsFrameAndWindows;

    public class AlertsFrameAndWindowsGroup : BaseGroup
    {
        public AlertsPage Alerts() => NavigateTo<AlertsPage>("alerts");

        public ModalDialogsPage ModalDialogs() => NavigateTo<ModalDialogsPage>("modal-dialogs");
    }
}
