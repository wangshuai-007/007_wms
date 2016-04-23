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
	public class FindPanelTests {
		public FindPanelTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateFilterTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.CheckFilteringResultAfterApplyingFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearFilterViaClearButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.ClearFilterViaButtonClear();
				this.UIMap.CheckFilteringResultAfterCleaningFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearFilterViaEscButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.ClearFilterViaButtonEsc();
				this.UIMap.CheckFilteringResultAfterCleaningFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void HideFilterPanelViaCloseButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.HideFilterPanelViaCloseButton();
				this.UIMap.CheckFilteringResultAfterCleaningFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateFilterViaCtrlFShortcutTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.HideFilterPanelViaCloseButton();
				this.UIMap.DisplayHiddenFindPanelViaCtrlFShortcut();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.CheckFilteringResultAfterApplyingFilter();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateFilterViaAssigningFilterColumnTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.AssignFindPanelFilterColumn();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.CheckFilteringResultAfterApplyingFilterViaAssigningFilterColumn();
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToFindClickModeAndCreateFilterTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToFindPanelDemoModule();
				this.UIMap.SwitchFindModeToFindClick();
				this.UIMap.CreateFilterViaFindPanel();
				this.UIMap.CheckFilteringResultAfterCleaningFilter();
				this.UIMap.ClickButtonFind();
				this.UIMap.CheckFilteringResultAfterApplyingFilter();
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
