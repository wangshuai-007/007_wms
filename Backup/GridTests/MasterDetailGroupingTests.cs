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
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class MasterDetailGroupingTests {
		public MasterDetailGroupingTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void GroupDataTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.GroupMasterDetailData();
				this.UIMap.CheckGroupedMasterDetailData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void UngroupDataTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.UngroupMasterDetailData();
				this.UIMap.CheckUngroupedMasterDetailData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandGroupRowViaExpandButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.ExpandAndCollapseGroupRowViaClickExpandButton();
				this.UIMap.CheckExpandedGroupRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandGroupRowViaDoubleClickGroupRowTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.ExpandAndCollapseGroupRowViaDoubleClickGroupRow();
				this.UIMap.CheckExpandedGroupRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandGroupRowViaDoubleClickIndicatorCellTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.ExpandAndCollapseGroupRowViaDoubleClickIndicatorCell();
				this.UIMap.CheckExpandedGroupRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandGroupRowViaFullExpandOptionTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.CollapseSomeGroupRowAndFullExpand();
				this.UIMap.CheckFullExpandedGroupRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CollapseGroupRowViaFullCollapseOptionTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.CollapseGroupRowViaFullCollapseOption();
				this.UIMap.CheckFullCollapsedGroupRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandMasterRowViaExpandButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.ExpandMasterRowViaClickExpandButton();
				this.UIMap.CheckExpandedMasterRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandMasterRowViaDoubleClickIndicatorTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.ExpandMasterRowViaDoubleClickIndicatorMasterRow();
				this.UIMap.CheckExpandedMasterRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ExpandMasterRowViaCtrlPlusShortcutTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.ExpandMasterRowViaCtrlPlusShortcut();
				this.UIMap.CheckExpandedMasterRow();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void GroupViaJoinedGroupPanelTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToMasterDetailGroupingDemoModule();
				this.UIMap.SwitchToJoinedGroupPanel();
				this.UIMap.GroupMasterDetailDataOnJoinedGroupPanel();
				this.UIMap.CheckGroupedMasterDetailDataOnJoinedGroupPanel();
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
