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

using DevExpress.Win.FunctionalTests.GridTests;
using DevExpress.Win.FunctionalTests.UIMaps.UIMapClasses;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class ColumnCustomizationTests {
		public ColumnCustomizationTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void HideBandViaDraggingBandHeaderTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.UICustomization, GridDemoModules.Modules.ColumnCustomization);
				this.UIMap.HideBandViaDraggingBandHeader();
				this.UIMap.CheckVisibleIndexOfHiddenBand();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void HideBandViaDraggingBandHeaderToCustomizationFormTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.UICustomization, GridDemoModules.Modules.ColumnCustomization);
				this.UIMap.HideBandViaDraggingBandHeaderToCustomizationForm();
				this.UIMap.CheckVisibleIndexOfHiddenBand();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DisplayHiddenBandViaDraggingBandHeaderFromCustomizationFormTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.UICustomization, GridDemoModules.Modules.ColumnCustomization);
				this.UIMap.DisplayHiddenBandViaDraggingBandHeaderFromCustomizationForm();
				this.UIMap.CheckVisibleIndexOfBandAfterDisplayHiddenBand();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DisplayHiddenBandViaDoubleClickBandHeaderInCustomizationFormTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.UICustomization, GridDemoModules.Modules.ColumnCustomization);
				this.UIMap.DisplayHiddenBandViaDoubleClickBandHeaderInCustomizationForm();
				this.UIMap.CheckVisibleIndexOfBandAfterDisplayHiddenBand();
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
