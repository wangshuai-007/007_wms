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
using DevExpress.Win.FunctionalTests.GridTests;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class TableLayoutTests {
		public TableLayoutTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ReorderColumnsTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.ReorderColumnsViaDragging();
				this.UIMap.CheckReorderedColumns();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ResizeColumnViaDraggingRightEdgeTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				DXColumnHeader uIGridColumn2ColumnHeader = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIGridColumn2ColumnHeader;
				Size oldSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGridColumn2ColumnHeader.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ResizeColumnViaDraggingRightEdge();
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGridColumn2ColumnHeader.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSize.Width > oldSize.Width);
			}
		}
		 [Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ResizeColumnViaBestFitOptionTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				DXColumnHeader uIGridColumn3ColumnHeader = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIGridColumn3ColumnHeader;
				Size oldSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGridColumn3ColumnHeader.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ResizeColumnViaBestFitOption();
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIGridColumn3ColumnHeader.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSize.Width < oldSize.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		 public void GroupDataViaDraggingColumnHeaderTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.GroupDataViaDraggingColumnHeader();
				this.UIMap.CheckGroupIndexAfterGroupedData();
				this.UIMap.CheckGroupedData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void GroupDataViaGroupByThisColumnOptionTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.GroupDataViaGroupByThisColumnOption();
				this.UIMap.CheckGroupIndexAfterGroupedData();
				this.UIMap.CheckGroupedData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGroupOrderTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.GroupDataAndChangeGroupOrder();
				this.UIMap.CheckGroupIndexAfterGroupedData();
				this.UIMap.CheckGroupedData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void UngroupDataViaDraggingColumnHeaderTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.GroupDataViaDraggingColumnHeader();
				this.UIMap.UngroupDataViaDraggingColumnHeader();
				this.UIMap.CheckGroupIndexAfterUngroupedData();
				this.UIMap.CheckUngroupedData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void UngroupDataViaUnGroupOptionTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.GroupDataViaDraggingColumnHeader();
				this.UIMap.UngroupDataViaUnGroupOption();
				this.UIMap.CheckGroupIndexAfterUngroupedData();
				this.UIMap.CheckUngroupedData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void UngroupDataViaClearGroupingOptionTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.GroupDataViaDraggingColumnHeader();
				this.UIMap.UngroupDataViaClearGroupingOption();
				this.UIMap.CheckGroupIndexAfterUngroupedData();
				this.UIMap.CheckUngroupedData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AscendingSortDataViaMouseTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.SortAscendingDataViaMouse();
				DXCell uIItem200Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem200Cell;
				DXCell uIItem250Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem250Cell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem200Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem250Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell < valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AscendingSortDataViaContextMenuTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.SortAscendingDataViaContextMenu();
				DXCell uIItem200Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem200Cell;
				DXCell uIItem250Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem250Cell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem200Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem250Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell < valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DescendingSortDataViaMouseTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.SortDescendingDataViaMouse();
				DXCell uIItem200Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem200Cell;
				DXCell uIItem250Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem250Cell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem200Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem250Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell > valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DescendingSortDataViaContextMenuTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.SortDescendingDataViaContextMenu();
				DXCell uIItem200Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem200Cell;
				DXCell uIItem250Cell = UIMap.UIXtraGridFeaturesDemoWindow1.UIPanelControl1Client1.UIGcContainerClient.UITableViewCustom.UIGridControl1Table.UIItem250Cell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem200Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem250Cell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell > valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("S173236"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void RemoveSortingTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.SortAscendingDataViaMouse();
				this.UIMap.RemoveSortingViaMouseAndHoldingDownCTRL();
				this.UIMap.CheckRemovedSorting();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateSimpleFilterTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateSimpleFilterViaClickColumnHeader();
				this.UIMap.CheckSimpleFilteredData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateComplexFilterTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateComplexFilterViaCustomAutoFilter();
				this.UIMap.CheckComplexFilteredData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateFilterViaFilterEditorOkButtonTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateFilterViaFilterEditor();
				this.UIMap.ClickFilterEditorOkButton();
				this.UIMap.CheckFilteredData();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateFilterViaFilterEditorApplyButtonTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateFilterViaFilterEditor();
				this.UIMap.ClickFilterEditorApplyButton();
				this.UIMap.CheckFilteredData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearFilterViaCloseFilterButtonTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateSimpleFilterViaClickColumnHeader();
				this.UIMap.CheckSimpleFilteredData();
				this.UIMap.ClearFilterViaCloseFilterButton();
				this.UIMap.CheckClearedFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearFilterViaClickColumnHeaderTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateSimpleFilterViaClickColumnHeader();
				this.UIMap.CheckSimpleFilteredData();
				this.UIMap.ClearFilterViaClickColumnHeader();
				this.UIMap.CheckClearedFilter();
			}
		}
		  [Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearFilterViaClearFilterOptionTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateSimpleFilterViaClickColumnHeader();
				this.UIMap.CheckSimpleFilteredData();
				this.UIMap.ClearFilterViaClearFilterOption();
				this.UIMap.CheckClearedFilter();
			}
		}
		 [Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DisableFilterTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.CreateComplexFilterViaCustomAutoFilter();
				this.UIMap.CheckComplexFilteredData();
				this.UIMap.DisableFilterViaEnableFilterButton();
				this.UIMap.CheckClearedFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddNewRowTest() {
			using(new GridsTestInitializer()) {
				GridDemoModules.SwitchToDemoModule(this.UIMap.UIXtraGridFeaturesDemoWindow.UIGcNavigationsClient.UINavBarControl1NavBar, GridDemoModules.ModuleGroups.GridViews, GridDemoModules.Modules.TableView);
				this.UIMap.AdditionNewRow();
				this.UIMap.CheckAddedRow();
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
