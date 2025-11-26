#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.CommunicationDriver;
using FTOptix.S7TiaProfinet;
using FTOptix.Alarm;
using FTOptix.EventLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.DataLogger;
using FTOptix.Recipe;
using FTOptix.Report;
using FTOptix.OPCUAServer;
using FTOptix.MQTTClient;
using FTOptix.SerialPort;
using FTOptix.System;
#endregion

public class CreaWidget : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        for (int i = 0; i < 50; i++)
        { 
            var mioWidget = InformationModel.Make<WidgetMotore>("Motore_" + i);
            mioWidget.SetAlias("AliasMotore",Project.Current.Get("CommDrivers/CODESYSDriver1/CODESYSStation1/Tags/Application/PLC_PRG/arrayMotori/" +i));
            Owner.Add(mioWidget);
        }
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
