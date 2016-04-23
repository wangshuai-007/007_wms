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
using DevExpress.Win.FunctionalTests.UIMaps.VerticalGridTreeListUIMapClasses;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class PropertyGridTests {
		public PropertyGridTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseCategoryRowViaClickExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridCategoryRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandCategoryRowViaClickExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridCategoryRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridCategoryRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseCategoryRowViaDoubleClickHeaderCellTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridCategoryRowViaDoubleClickHeaderCell();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandPropertyGridCategoryRowViaDoubleClickTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridCategoryRowViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridCategoryRowViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapsePropertyGridCategoryRowViaMinusKeyTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridCategoryRowViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandPropertyGridCategoryRowViaPlusKeyTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridCategoryRowViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridCategoryRowViaPlusKey();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandRowViaClickExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseRowViaClickExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowExpandedState();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandPropertyGridRowViaDoubleClickTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridRowViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseRowViaDoubleClickHeaderCellTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridRowViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowExpandedState();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridRowViaDoubleClickHeaderCell();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandPropertyGridRowViaPlusKeyTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridRowViaPlusKey();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapsePropertyGridRowViaMinusKeyTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ExpandPropertyGridRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowExpandedState();
				this.UIVerticalGridTreeListMap.CollapsePropertyGridRowViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridCellValueViaMouseTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridCellValueViaMouse();
				this.UIVerticalGridTreeListMap.CheckChangedPropertyGridCellValueViaMouse();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridCellValueViaArrowKeysAndEnterKeyTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridCellValueViaArrowKeysAndEnterKey();
				this.UIVerticalGridTreeListMap.CheckChangedPropertyGridCellValueViaArrowKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridCellValueViaEscKeyTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToDevExpressAppearance();
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridCellValueViaEscKey();
				this.UIVerticalGridTreeListMap.CheckChangedPropertyGridCellValueViaEscKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridRowHeaderWidthViaDraggingRowHeaderRightEdgeTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridRowHeaderWidthViaDraggingRowHeaderRightEdge();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowHeaderWidth();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridRowHeaderHeightViaCTRLLeftKeysTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridRowHeaderHeightViaCTRLLeftKeys();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowHeaderWidthChangedViaCTRLLeftKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridRowHeaderHeightViaCTRLRightKeysTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridRowHeaderHeightViaCTRLRightKeys();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowHeaderWidthChangedViaCTRLRightKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridRowHeightViaDraggingRowEdgeTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridRowHeightViaDraggingRowEdge();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowHeight();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridCategoryRowHeightViaDraggingRowEdgeTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridCategoryRowHeightViaDraggingRowEdge();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowHeight();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyGridFixedRowHeightViaDraggingRowEdgeTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyGridFixedRowHeightViaDraggingRowEdge();
				this.UIVerticalGridTreeListMap.CheckPropertyGridFixedRowHeight();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangePropertyDescriptionControlValueViaChangingFocusedRowTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToPropertyGridDemoModule();
				this.UIVerticalGridTreeListMap.ChangePropertyDescriptionControlValueViaChangingFocusedRow();
				this.UIVerticalGridTreeListMap.CheckPropertyDescriptionControlProperties();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ScrollPropertyGridViaMouseTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				DXVerticalGridHeaderCell uIImagePropertyGridHeaderCell = UIVerticalGridTreeListMap.UIXtraVerticalGridFeatWindow5.UIPanelControl1Client.UIGcContainerClient.UIFixedRowsCustom.UIPropertyGridControl1PropertyGrid.UIRowImagePropertyGridRow.UIImagePropertyGridHeaderCell;
				Size oldHeaderCellLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIImagePropertyGridHeaderCell.GetProperty("Location"), typeof(Size).FullName);
				this.UIVerticalGridTreeListMap.ScrollPropertyGridViaMouse();
				Size newHeaderCellLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIImagePropertyGridHeaderCell.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newHeaderCellLocation.Height == oldHeaderCellLocation.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void MakePropertyGridCategoryRowFixedTopTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.MakePropertyGridCategoryRowFixedTop();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowFixedTopState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void MakePropertyGridCategoryRowFixedBottomTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.MakePropertyGridCategoryRowFixedBottom();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowFixedBottomState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AllowFixingNestedRowsAndMakePropertyGridRowFixedTopTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.AllowFixingNestedRows();
				this.UIVerticalGridTreeListMap.MakePropertyGridRowFixedTop();
				this.UIVerticalGridTreeListMap.CheckPropertyGridNestedRowFixedTopState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AllowFixingNestedRowsAndMakePropertyGridRowFixedBottomTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.AllowFixingNestedRows();
				this.UIVerticalGridTreeListMap.MakePropertyGridRowFixedBottom();
				this.UIVerticalGridTreeListMap.CheckPropertyGridNestedRowFixedBottomState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void MakePropertyGridFixedTopRowFixedBottomTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.MakePropertyGridFixedTopRowFixedBottom();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowFixedBottomState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void MakePropertyGridFixedRowNotFixedTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.MakePropertyGridFixedRowNotFixed();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowNotFixedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ResetPropertyGridFixedRowsTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.ResetPropertyGridFixedRows();
				this.UIVerticalGridTreeListMap.CheckPropertyGridFixedRowsAfterReset();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowsWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowsWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyRowsWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowsWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridCategoryRowWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyCategoryRowWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridCategoryRowWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsToCustomizationFormTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridRowsInCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowsToCustomizationFormTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				DXListBox uILbCategoriesList = UIVerticalGridTreeListMap.UIXtraVerticalGridFeatWindow5.UIPanelControl1Client.UIGcContainerClient.UIFixedRowsCustom.UIPropertyGridControl1PropertyGrid.UIPropertyGridControl1Window.UITabControl1TabList.UITpCategoriesClient.UILbCategoriesList;
				Assert.IsTrue(uILbCategoriesList.ItemsText.Length == 3);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void DragPropertyGridRowsFromCustomizationFormWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInPropertyGridCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsFromCustomizationFormWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowFromCustomizationFormWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsFromCustomizationFormToCollapsedRowWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInPropertyGridCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsFromCustomizationFormToCollapsedRowWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.ExpandCollapsedRow();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowsFromCustomizationFormToCollapsedRowWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsFromCustomizationFormWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInPropertyGridCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowsFromCustomizationFormWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowsFromCustomizationFormWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInPropertyGridCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowsFromCustomizationFormWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowsFromCustomizationFormWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridRowFromCustomizationFormWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInPropertyGridCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridRowFromCustomizationFormWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridRowFromCustomizationFormWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowsFromCustomizationFormWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsFromCustomizationFormWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridCategoryRowsFromCustomizationFormWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowsFromCustomizationFormToCollapsedRowWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.CollapseExpandedCategoryRow();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsFromCustomizationFormToCollapsedRowWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.ExpandCollapsedRows();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridCategoryRowsFromCustomizationFormToCollapsedRowWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowsFromCustomizationFormWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragLastPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckLastPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingDragPropertyGridCategoryRowsFromCustomizationFormWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowsFromCustomizationFormWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsFromCustomizationFormWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridCategoryRowsFromCustomizationFormWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragPropertyGridCategoryRowFromCustomizationFormWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedRowsDemoModule();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowsToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckPropertyGridCategoryRowsInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragPropertyGridCategoryRowFromCustomizationFormWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingPropertyGridCategoryRowFromCustomizationFormWithInsertAfterDragAction();
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
		public VerticalGridTreeListUIMap UIVertGridMap {
			get {
				if((this.map == null)) {
					this.map = new VerticalGridTreeListUIMap();
				}
				return this.map;
			}
		}
		private VerticalGridTreeListUIMap map;
		public VerticalGridTreeListUIMap UIVerticalGridTreeListMap {
			get {
				if((this.map == null)) {
					this.map = new VerticalGridTreeListUIMap();
				}
				return this.map;
			}
		}
	}
}
