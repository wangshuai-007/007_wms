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
using DevExpress.Win.FunctionalTests.UIMaps.UIMapForHandCodingTestsClasses;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
using DevExpress.Data;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class HandCodingTestSamples {
		public HandCodingTestSamples() {
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ReorderColumnsTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXColumnHeader columnHeader = grid.Views[0].Columns[3];
				columnHeader.VisibleIndex = 1;
				columnHeader.GroupIndex = -1;
				Assert.IsTrue(columnHeader.VisibleIndex == 1);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ResizeColumnTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXColumnHeader columnHeader = grid.Views[0].Columns[3];
				columnHeader.Width = 376;
				Assert.IsTrue(columnHeader.Width == 376);
			}		   
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void GroupDataTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXColumnHeader columnHeader2 = grid.Views[0].Columns[1];
				DXColumnHeader columnHeader5 = grid.Views[0].Columns[4];
				columnHeader2.VisibleIndex = 0;
				columnHeader2.GroupIndex = 1;
				columnHeader5.VisibleIndex = 3;
				columnHeader5.GroupIndex = 1;
				Assert.IsTrue(columnHeader2.GroupIndex == 0 && columnHeader5.GroupIndex == 1);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void EditGridCellTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXCell cell = grid.Views[0].Columns[0].GetCell(1);
				grid.Views[0].FocusedCell = cell;
				Mouse.Click(cell, new Point(1, 1));
				grid.Views[0].ActiveEditor.Value = "555";
				Assert.AreEqual(grid.Views[0].Columns[0].GetCell(1).Text, "555");
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CreateSimpleFilterTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXCell gridCell = grid.Views[0].Columns[4].GetCell(11);
				DXColumnHeader gridColumn = new DXColumnHeader(grid, "gridView1", "gridColumn5", false);
				gridColumn.FilterString = "[" + gridColumn.Text + "] = " + gridCell.Value.ToString();
				Assert.IsTrue(grid.Views[0].FilterString == "[Discount] = 0.05");
			}			
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearFilterTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXCell gridCell = grid.Views[0].Columns[4].GetCell(11);
				DXColumnHeader gridColumn = new DXColumnHeader(grid, "gridView1", "gridColumn5", false);
				gridColumn.FilterString = "[" + gridColumn.Text + "] = " + gridCell.Value.ToString();
				gridColumn.FilterString = String.Empty;
				Assert.IsTrue(grid.Views[0].FilterString == String.Empty);
			} 
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SortDataTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXColumnHeader columnHeader4 = grid.Views[0].Columns[3];
				Mouse.Click(columnHeader4, new Point(1, 1));
				DXCell firstGridCell = grid.Views[0].GetRow(1).VisibleCells[3];
				DXCell lastGridCell = grid.Views[0].GetRow(100).VisibleCells[3];
				Assert.IsTrue(Int32.Parse(lastGridCell.Text) > Int32.Parse(firstGridCell.Text));
				Assert.IsTrue(columnHeader4.SortIndex == 0 && columnHeader4.SortOrder.ToString() == "Ascending");
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void GroupDataAndCheckGroupRowTest() {
			using(new GridsTestInitializer()) {
				GridTests.GridDemoModules.SwitchToDemoModule(new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl, GridTests.GridDemoModules.ModuleGroups.GridViews, GridTests.GridDemoModules.Modules.TableView);
				DXGrid grid = UIMap.UIXtraGridFeaturesDemoWindow.UIPanelControl1Client.UIGcContainerClient.UITableViewCustom.UIGridControl1Table;
				DXColumnHeader columnHeader = grid.Views[0].Columns[1];
				columnHeader.VisibleIndex = 0;
				columnHeader.GroupIndex = 1;
				DXGroupRow gridGroupRow = new DXGroupRow(grid, grid.Views[0].Name, -3);
				Assert.AreEqual(gridGroupRow.ColumnName, "gridColumn2");
			}
		}
		public class UIgridDemoWindow : DXWindow {
			public UIgridDemoWindow() {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "The XtraGrid Suite by DevExpress (C# code)";
				this.SearchProperties.Add(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains);
				this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code)");
				this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Cell Selection");
				this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Banded Views");
			}
			UIgridPanelControl UIgridPanelControl;
			UIgridNavigationClient UIgridNavigationClient;
			public UIgridPanelControl UIGridPanelControl {
				get {
					return this.UIgridPanelControl = new UIgridPanelControl(this);
				}
			}
			public UIgridNavigationClient UIGridNavigationClient {
				get {
					return this.UIgridNavigationClient = new UIgridNavigationClient(this);
				}
			}
		}
		public class UIgridNavigationClient : DXTestControl {
			public UIgridNavigationClient(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcNavigations";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			}
			UIaccordionControl UIaccordionControl;
			public UIaccordionControl UIAccordionControl {
				get {
					return this.UIaccordionControl = new UIaccordionControl(this);
				}
			}
		}
		public class UIaccordionControl : DXTestControl {
			public UIaccordionControl(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "accordionControl1";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControl";
			}
			UIaccordionControlGroupLayoutFeatures UIaccordionControlGroupLayoutFeatures;
			UIaccordionControlGroupGridViews UIaccordionControlGroupHighlightedFeatures;
			public UIaccordionControlGroupLayoutFeatures UIAccordionControlGroupLayoutFeatures {
				get {
					return this.UIaccordionControlGroupLayoutFeatures = new UIaccordionControlGroupLayoutFeatures(this);
				}
			}
			public UIaccordionControlGroupGridViews UIAccordionControlGroupGridViews {
				get {
					return this.UIaccordionControlGroupHighlightedFeatures = new UIaccordionControlGroupGridViews(this);
				}
			}
		}
		public class UIaccordionControlGroupLayoutFeatures : DXTestControl {
			public UIaccordionControlGroupLayoutFeatures(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "UI Customization";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			}
			UIaccordionControlItemTableView UIaccordionControlItemTableView;
			UIaccordionControlItemCellSelectionView UIaccordionControlItemCellSelectionView;
			public UIaccordionControlItemTableView UIAccordionControlItemTableView {
				get {
					return this.UIaccordionControlItemTableView = new UIaccordionControlItemTableView(this);
				}
			}
			public UIaccordionControlItemCellSelectionView UIAccordionControlItemCellSelectionView {
				get {
					return this.UIaccordionControlItemCellSelectionView = new UIaccordionControlItemCellSelectionView(this);
				}
			}
		}
		public class UIaccordionControlGroupGridViews : DXTestControl {
			public UIaccordionControlGroupGridViews(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "Grid Views";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			}
			UIaccordionControlItemBandedViews UIaccordionControlItemAlternateView;
			public UIaccordionControlItemBandedViews UIAccordionControlItemBandedViews {
				get {
					return this.UIaccordionControlItemAlternateView = new UIaccordionControlItemBandedViews(this);
				}
			}
		}
		public class UIaccordionControlItemTableView : DXTestControl {
			public UIaccordionControlItemTableView(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "Table Layout";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
			}
		}
		public class UIaccordionControlItemBandedViews : DXTestControl {
			public UIaccordionControlItemBandedViews(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
					this.SearchProperties[DXTestControl.PropertyNames.Name] = "Banded Views";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
			}
		}
		public class UIaccordionControlItemCellSelectionView : DXTestControl {
			public UIaccordionControlItemCellSelectionView(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "Cell Selection";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
			}
		}
		public class UIgridPanelControl : DXTestControl {
			public UIgridPanelControl(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			}
			UIgridContainerClient UIgridContainerClient;
			UIcheckButton UIcheckButton;
			public UIgridContainerClient UIGridContainerClient {
				get {
					return this.UIgridContainerClient = new UIgridContainerClient(this);
				}
			}
			public UIcheckButton UICheckButton {
				get {
					return this.UIcheckButton = new UIcheckButton(this);
				}
			}
		}
		public class UIcheckButton : DXCheckButton {
			public UIcheckButton(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "chBanded";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "CheckButton";
			}
		}
		public class UIgridContainerClient : DXTestControl {
			public UIgridContainerClient(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			}
			UIgridCellSelectionCustom UIgridCellSelectionCustom;
			UIgridViewStyleCustom UIgridViewStyleCustom;
			public UIgridCellSelectionCustom UIGridCellSelectionCustom {
				get {
					return this.UIgridCellSelectionCustom = new UIgridCellSelectionCustom(this);
				}
			}
			public UIgridViewStyleCustom UIGridViewStyleCustom {
				get {
					return this.UIgridViewStyleCustom = new UIgridViewStyleCustom(this);
				}
			}
		}
		public class UIgridCellSelectionCustom : DXTestControl {
			public UIgridCellSelectionCustom(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "CellSelection";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "CellSelection";
				this.UIgrid = new UIgrid(this);
			}
			UIgrid UIgrid;
			public UIgrid UIGrid {
				get {
					return this.UIgrid = new UIgrid(this);
				}
			}
		}
		public class UIgridViewStyleCustom : DXTestControl {
			public UIgridViewStyleCustom(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "ViewStyles";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ViewStyles";
			}
			UIgrid UIgrid;
			public UIgrid UIGrid {
				get {
					return this.UIgrid = new UIgrid(this);
				}
			}
		}
		public class UIgrid : DXGrid {
			public UIgrid(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "gridControl1";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GridControl";
			}
			UIgridBand UIgridBand;
			public UIgridBand UIGridBand {
				get {
					return this.UIgridBand = new UIgridBand(this);
				}
			}
		}
		public class UIgridBand : DXGridBand {
			public UIgridBand(UITestControl searchLimitContainer)
				: base(searchLimitContainer) {
				this.SearchProperties[DXTestControl.PropertyNames.Name] = "gridControl1GridControlBand[View]bandedGridView1[BandName]gridBand1";
				this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GridControlBand";
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeFocusedCellTest() {
			using(new GridsTestInitializer()) {
				DXTestControl accordionControlItem = new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl.UIAccordionControlGroupLayoutFeatures.UIAccordionControlItemCellSelectionView;
				Mouse.Click(accordionControlItem, new Point(1, 1));
				DXGrid grid = new UIgridDemoWindow().UIGridPanelControl.UIGridContainerClient.UIGridCellSelectionCustom.UIGrid;
				grid.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Cell Selection");
				DXRow gridRow = grid.Views[0].GetRow(2);
				DXCell firstFocusedCell = gridRow.GetCell("colCity");
				grid.Views[0].FocusedCell = firstFocusedCell;
				Assert.AreEqual(firstFocusedCell.Text, grid.Views[0].FocusedCell.Text);
				DXCell secondFocusedCell = gridRow.VisibleCells[0];
				grid.Views[0].FocusedCell = secondFocusedCell;
				Assert.AreEqual(secondFocusedCell.Text, grid.Views[0].FocusedCell.Text);
				DXCell thirdFocusedCell = new DXCell(grid, gridRow.ViewName, "colAddress", gridRow.RowHandle);
				grid.Views[0].FocusedCell = thirdFocusedCell;
				Assert.AreEqual(thirdFocusedCell.Text, grid.Views[0].FocusedCell.Text);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridBandWidthTest() {
			using(new GridsTestInitializer()) {
				DXTestControl accordionControlItem = new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl.UIAccordionControlGroupGridViews.UIAccordionControlItemBandedViews;
				Mouse.Click(accordionControlItem, new Point(1, 1));
				DXCheckButton bandedViewCheckButton = new UIgridDemoWindow().UIGridPanelControl.UICheckButton;
				bandedViewCheckButton.Checked = true;
				DXGrid grid = new UIgridDemoWindow().UIGridPanelControl.UIGridContainerClient.UIGridViewStyleCustom.UIGrid;
				DXGridBand bandParent = new DXGridBand(grid, grid.Views[0].Name, "gridBand1");
				DXGridBand bandChild = new DXGridBand(grid, grid.Views[0].Name, "gridBand2");
				int oldWidthBandParent = bandParent.Width;
				int oldWidthBandChild = bandChild.Width;
				bandParent.Width = oldWidthBandParent + 100;
				bandChild.Width = oldWidthBandChild + 100;
				int newWidthBandParent = bandParent.Width;
				int newWidthBandChild = bandChild.Width;
				Assert.IsTrue(newWidthBandParent > oldWidthBandParent && newWidthBandChild > oldWidthBandChild);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CheckGridBandParentTest() {
			using(new GridsTestInitializer()) {
				DXTestControl accordionControlItem = new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl.UIAccordionControlGroupGridViews.UIAccordionControlItemBandedViews;
				Mouse.Click(accordionControlItem, new Point(1, 1));
				DXCheckButton bandedViewCheckButton = new UIgridDemoWindow().UIGridPanelControl.UICheckButton;
				bandedViewCheckButton.Checked = true;
				DXGrid grid = new UIgridDemoWindow().UIGridPanelControl.UIGridContainerClient.UIGridViewStyleCustom.UIGrid;
				DXGridBand bandParent = new DXGridBand(grid, grid.Views[0].Name, "gridBand1");
				DXGridBand bandChild = new DXGridBand(grid, grid.Views[0].Name, "gridBand2");
				Assert.IsTrue(bandChild.ParentBandName == bandParent.BandName);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridBandsOrderTest() {
			using(new GridsTestInitializer()) {
				DXTestControl accordionControlItem = new UIgridDemoWindow().UIGridNavigationClient.UIAccordionControl.UIAccordionControlGroupGridViews.UIAccordionControlItemBandedViews;
				Mouse.Click(accordionControlItem, new Point(1, 1));
				DXCheckButton bandedViewCheckButton = new UIgridDemoWindow().UIGridPanelControl.UICheckButton;
				bandedViewCheckButton.Checked = true;
				DXGrid grid = new UIgridDemoWindow().UIGridPanelControl.UIGridContainerClient.UIGridViewStyleCustom.UIGrid;
				DXGridBand bandParent = new DXGridBand(grid, grid.Views[0].Name, "gridBand1");
				DXGridBand bandChild1 = new DXGridBand(grid, grid.Views[0].Name, "gridBand2");
				DXGridBand bandChild2 = new DXGridBand(grid, grid.Views[0].Name, "gridBand3");
				int oldBandChild1Position = bandChild1.VisibleIndex;
				int oldBandChild2Position = bandChild2.VisibleIndex;
				bandChild1.SetBandPosition(bandParent.BandName, bandChild2.VisibleIndex);
				Assert.IsTrue(bandChild1.VisibleIndex == oldBandChild2Position && bandChild2.VisibleIndex == oldBandChild1Position);
				oldBandChild1Position = bandChild1.VisibleIndex;
				oldBandChild2Position = bandChild2.VisibleIndex;
				bandChild1.SetBandPosition(bandParent, bandChild2.VisibleIndex);
				Assert.IsTrue(bandChild1.VisibleIndex == oldBandChild2Position && bandChild2.VisibleIndex == oldBandChild1Position);
				oldBandChild1Position = bandChild1.VisibleIndex;
				oldBandChild2Position = bandChild2.VisibleIndex;
				bandChild1.SetBandPosition(bandChild2.VisibleIndex);
				Assert.IsTrue(bandChild1.VisibleIndex == oldBandChild2Position && bandChild2.VisibleIndex == oldBandChild1Position);
			}
		}
		public TestContext TestContext {
			get {
				return testContextInstance;
			}
			set {
				testContextInstance = value;
			}
		}
		private TestContext testContextInstance;
		public UIMapForHandCodingTests UIMap {
			get {
				if((this.map == null)) {
					this.map = new UIMapForHandCodingTests();
				}
				return this.map;
			}
		}
		private UIMapForHandCodingTests map;
	}
}
