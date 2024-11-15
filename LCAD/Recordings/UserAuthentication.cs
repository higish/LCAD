﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace LCAD.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UserAuthentication recording.
    /// </summary>
    [TestModule("a234d946-8019-4630-b201-6611febf6856", ModuleType.Recording, 1)]
    public partial class UserAuthentication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::LCAD.LCADRepository repository.
        /// </summary>
        public static global::LCAD.LCADRepository repo = global::LCAD.LCADRepository.Instance;

        static UserAuthentication instance = new UserAuthentication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserAuthentication()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UserAuthentication Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LogistiCADLogin.EUserID' at 27;7.", repo.LogistiCADLogin.EUserIDInfo, new RecordItemIndex(0));
            repo.LogistiCADLogin.EUserID.Click("27;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'HamzaG' with focus on 'LogistiCADLogin.EUserID'.", repo.LogistiCADLogin.EUserIDInfo, new RecordItemIndex(1));
            repo.LogistiCADLogin.EUserID.PressKeys("HamzaG");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LogistiCADLogin.EPassword' at 25;13.", repo.LogistiCADLogin.EPasswordInfo, new RecordItemIndex(2));
            repo.LogistiCADLogin.EPassword.Click("25;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Welcometomodivcare1' with focus on 'LogistiCADLogin.EPassword'.", repo.LogistiCADLogin.EPasswordInfo, new RecordItemIndex(3));
            repo.LogistiCADLogin.EPassword.PressKeys("Welcometomodivcare1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LogistiCADLogin.ButtonOK' at 42;11.", repo.LogistiCADLogin.ButtonOKInfo, new RecordItemIndex(4));
            repo.LogistiCADLogin.ButtonOK.Click("42;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
