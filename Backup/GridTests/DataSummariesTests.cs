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
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
using Microsoft.VisualStudio.TestTools.UITest.Extension; 
using DevExpress.Win.FunctionalTests.UIMaps.UIMapClasses;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.Win.FunctionalTests.GridTests;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class DataSummariesTests {
		public DataSummariesTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeSummaryTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.SummaryComputation, GridDemoModules.Modules.DataSummariesAndAggregates);
				this.UIMap.ShowFooterSummary();
				this.UIMap.ChangeSummaryViaContextMenu();
				this.UIMap.CheckChangedSummary();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddNewSummaryTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.SummaryComputation, GridDemoModules.Modules.DataSummariesAndAggregates);
				this.UIMap.ShowFooterSummary();
				this.UIMap.AddNewSummaryViaContextMenu();
				this.UIMap.CheckAddedSummary();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DeleteSummaryTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.SummaryComputation, GridDemoModules.Modules.DataSummariesAndAggregates);
				this.UIMap.ShowFooterSummary();
				this.UIMap.DeleteSummaryViaContextMenu();
				this.UIMap.CheckDeletedSummary();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearSummaryTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.SummaryComputation, GridDemoModules.Modules.DataSummariesAndAggregates);
				this.UIMap.ShowFooterSummary();
				this.UIMap.AddNewSummaryViaContextMenu();
				this.UIMap.ClearSummaryItemViaContextMenu();
				this.UIMap.CheckClearedSummaryItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DisplaySummaryTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.SummaryComputation, GridDemoModules.Modules.DataSummariesAndAggregates);
				this.UIMap.ShowFooterSummary();
				this.UIMap.SwitchToGroupFooterSummaryOption();
				this.UIMap.DisableAlignInGroupRow();
				this.UIMap.CheckSummaryAfterSwitchingOnDisplaySummaryOption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void RecalculateSummariesTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.SummaryComputation, GridDemoModules.Modules.DataSummariesAndAggregates);
				this.UIMap.ShowFooterSummary();
				this.UIMap.ChangeCellValueToRecalculateSummaries();
				this.UIMap.CheckRecalculatedSummariesValue();
			}
		}
		#region Additional test attributes
		#endregion
		public TestContext TestContext {
			get {
				return testContextInstance;
			}
			set {
				testContextInstance = value;
			}
		}
		private TestContext testContextInstance;
		public UIMap UIMap {
			get {
				if((this.map == null)) {
					this.map = new UIMap();
				}
				return this.map;
			}
		}
		private UIMap map;
	}
}
