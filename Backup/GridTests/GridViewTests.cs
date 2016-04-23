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
	public class GridViewTests {
		public GridViewTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void HideColumnViaDraggingColumnHeaderTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.SwitchToGridView();
				this.UIMap.HideColumnViaDraggingColumnHeader();
				this.UIMap.CheckColumnHeaderAfterHidingColumn();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void HideColumnViaDraggingColumnHeaderToCustomizationFormTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.SwitchToGridView();
				this.UIMap.HideColumnViaDraggingColumnHeaderOnCustomizationForm();
				this.UIMap.CheckColumnHeaderAfterHidingColumn();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void HideColumnViaColumnHeaderContextMenuOptionTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.SwitchToGridView();
				this.UIMap.HideColumnViaColumnHeaderContextMenu();
				this.UIMap.CheckColumnHeaderAfterHidingColumn();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DisplayHiddenColumnViaDraggingColumnHeaderFromCustomizationFormTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.SwitchToGridView();
				this.UIMap.DisplayColumnChooserWindow();
				this.UIMap.DisplayHiddenColumnViaDraggingColumnHeaderFromCustomizationForm();
				this.UIMap.CheckColumnHeaderAfterDisplayHiddenColumnViaDraggingColumnHeaderFromCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DisplayHiddenColumnViaCustomizationFormContextMenuOptionTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.SwitchToGridView();
				this.UIMap.DisplayColumnChooserWindow();
				this.UIMap.DisplayHiddenColumnViaCustomizationFormContextMenu();
				this.UIMap.CheckColumnHeaderAfterDisplayHiddenColumnViaCustomizationFormContextMenu();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ReorderBandsInBandedGridViewModuleTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.SwitchToBandedGridView();
				this.UIMap.ReorderBandsViaDraggingOnBandedGridView();
				this.UIMap.CheckReorderedBandsOnBandedGridView();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ReorderBandsInAdvancedBandedGridViewModuleTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				this.UIMap.ReorderBandsViaDraggingOnAdvancedBandedGridView();
				this.UIMap.CheckReorderedBandsOnAdvancedBandedGridView();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ResizeBandViaDraggingRightEdgeInAdvancedBandedGridViewModuleTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToAlternateViewsDemoModule();
				DXGridBand uIGbMainGridBand = UIMap.UITheXtraGridSuitebyDeWindow.UIPanelControl1Client.UIGcContainerClient.UIViewStylesCustom.UIGridControl1Table.UIGbMainGridBand;
				DXGridBand uIGbPerfomanceGridBand = UIMap.UITheXtraGridSuitebyDeWindow.UIPanelControl1Client.UIGcContainerClient.UIViewStylesCustom.UIGridControl1Table.UIGbPerfomanceGridBand;
				Size oldSizeGridBandMain = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGbMainGridBand.GetProperty("Size"), typeof(Size).FullName);
				Size oldSizeGridBandPerformance = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGbPerfomanceGridBand.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ResizeBandViaDraggingRightEdgeOnAdvancedBandedGridView();
				Size newSizeGridBandMain = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGbMainGridBand.GetProperty("Size"), typeof(Size).FullName);
				Size newSizeGridBandPerformance = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGbPerfomanceGridBand.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeGridBandMain.Width < oldSizeGridBandMain.Width && newSizeGridBandPerformance.Width == oldSizeGridBandPerformance.Width);
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
