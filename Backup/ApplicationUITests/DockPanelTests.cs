#region Copyright (c) 2000-2015 Developer Express Inc.
/*
{*******************************************************************}
{                                                                   }
{       Developer Express .NET Component Library                    }
{       WinForms Controls                                           }
{                                                                   }
{       Copyright (c) 2000-2015 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
#endregion Copyright (c) 2000-2015 Developer Express Inc.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using DevExpress.Win.FunctionalTests.UIMaps.UIMapClasses;
using DevExpress.Win.FunctionalTests.UIMaps.DockingPanelsUIMapClasses;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
namespace DevExpress.Win.FunctionalTests {
	public partial class ApplicationUITests {
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormLeftEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToLeftEdgeOfForm();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToLeftEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormRightEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToRightEdgeOfForm();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToRightEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormTopEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToTopEdgeOfForm();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToTopEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormBottomEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToBottomEdgeOfForm();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToBottomEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("T143772"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToLeftEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				MessageBox.Show("!");
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToLeftEdge();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToLeftEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToRightEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToRightEdge();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToRightEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToTopEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToTopEdge();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToTopEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToBottomEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.DockSimplePanelToBottomEdge();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToBottomEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CreateTabContainerTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateTabContainerViaDockPanelToAnotherPanel();
				this.UIDockingMap.CheckSimplePanelDockStyleDockedToAnotherPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CreateTabContainerFromTwoUntitledPanelsTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.CheckTabContainerFromTwoUntitledPanels();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CreateSplitContainerFromTwoUntitledPanelsTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateSplitContainerFromTwoUntitledPanels();
				this.UIDockingMap.CheckSplitContainerFromTwoUntitledPanels();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockTabContainerFromTwoUntitledPanelsTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.DockTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.CheckDockingTabContainerFromTwoUntitledPanels();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CreateSplitContainerFromTabContainerAndUntitledPanelTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateSplitContainerFromTabContainerAndUntitledPanel();
				this.UIDockingMap.CheckSplitContainerFromTabContainerAndUntitledPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CreateContainerFromTwoTabContainersTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateSecondTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.CreateSplitContainerFromTwoTabContainers();
				this.UIDockingMap.CheckSplitContainerFromTwoTabContainers();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CreateTabContainerFromTwoTabContainersTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(DockingUIGroupName, DockPanelsModuleName);
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.AddTwoSimpleDockPanels();
				this.UIDockingMap.CreateSecondTabContainerFromTwoUntitledPanels();
				this.UIDockingMap.CreateTabContainerFromTwoTabContainers();
				this.UIDockingMap.CheckTabContainerFromTwoTabContainers();
			}
		}
	}
}
