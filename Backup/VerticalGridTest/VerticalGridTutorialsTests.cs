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
	public class VerticalGridTutorialsTests {
		public VerticalGridTutorialsTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseCategoryRowViaClickExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandCategoryRowViaClickExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandCategoryRowViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseCategoryRowViaClickTreeViewStyleExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.SwitchToTreeViewExpandButtonStyle();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaClickTreeViewStyleExpandButton();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandCategoryRowViaClickTreeViewStyleExpandButtonTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.SwitchToTreeViewExpandButtonStyle();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaClickTreeViewStyleExpandButton();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandCategoryRowViaClickTreeViewStyleExpandButton();
				this.UIVerticalGridTreeListMap.CheckCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void CollapseCategoryRowViaDoubleClickHeaderCellTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaDoubleClickHeaderCell();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ExpandCategoryRowViaDoubleClickHeaderCellImageTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandCategoryRowViaDoubleClickHeaderCellImage();
				this.UIVerticalGridTreeListMap.CheckCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseCategoryRowViaMinusKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandCategoryRowViaPlusKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCategoryRowButtonDemoModule();
				this.UIVerticalGridTreeListMap.CollapseCategoryRowViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckCategoryRowCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandCategoryRowViaPlusKey();
				this.UIVerticalGridTreeListMap.CheckCategoryRowExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragRowWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragRowWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragRowWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragRowWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragRowWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragRowWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragRowWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragRowWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragCategoryRowWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragCategoryRowWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragCategoryRowWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragCategoryRowWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragCategoryRowWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragCategoryRowWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragCategoryRowWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragCategoryRowWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragRowsToDragAndDropAreaTest() { 
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragRowsToDragAndDropArea();
				this.UIVerticalGridTreeListMap.CheckDraggingRowsToDragAndDropArea();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragCategoryRowsToDragAndDropAreaTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.CheckDragRowHeadersCheckBox();
				this.UIVerticalGridTreeListMap.DragCategoryRowsToDragAndDropArea();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowsToDragAndDropArea();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellValueViaSpinEditorTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToEditorsDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueViaSpinEditor();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaSpinEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellValueViaImageComboBoxEditorTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToEditorsDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueViaImageComboBoxEditor();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaImageComboBoxEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ChangeVerticalGridRecordWidthViaDraggingFirstRecordRightEdgeTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridRecordWidthViaDraggingFirstRecordRightEdge();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRecordWidth();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridRecordWidthViaRecordWidthSpinEditTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridRecordWidthViaRecordWidthSpinEdit();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRecordWidth();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ChangeVerticalGridRowHeaderWidthViaDraggingRowHeaderRightEdgeTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridRowHeaderWidthViaDraggingRowHeaderRightEdge();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRowHeaderWidth();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		 public void ChangeVerticalGridRowHeaderWidthViaRowHeaderWidthSpinEditTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridRowHeaderWidthViaRowHeaderWidthSpinEdit();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRowHeaderWidth();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCategoryRowHeaderHeightViaDraggingRowHeaderBottomEdgeTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCategoryRowHeaderHeightViaDraggingRowHeaderBottomEdge();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowHeaderHeight();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridRowHeightViaDraggingRowEdgeTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridRowHeightViaDraggingRowEdge();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRowHeight();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridRecordsIntervalViaRecordsIntervalSpinEditTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridRecordsIntervalViaRecordsIntervalSpinEdit();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRecordsInterval();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ChangeVerticalGridBandWidthViaDraggingBandEdgeTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToLayoutAndPaintStylesDemoModule();
				this.UIVerticalGridTreeListMap.SwitchToBandsViewLayoutStyle();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridBandWidthViaDraggingBandEdge();
				this.UIVerticalGridTreeListMap.CheckVerticalGridBandWidth();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCategoryRowHeaderHeightViaCTRLLeftKeysTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCategoryRowHeaderHeightViaCTRLLeftKeys();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRowHeaderWidthChangedViaCTRLLeftKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCategoryRowHeaderHeightViaCTRLRightKeysTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToResizingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCategoryRowHeaderHeightViaCTRLRightKeys();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRowHeaderWidthChangedViaCTRLRightKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiEditorsCellVerticalLineSeparatorsPositionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeMultiEditorsCellVerticalLineSeparatorsPosition();
				this.UIVerticalGridTreeListMap.CheckMultiEditorsRowsCellLengthsAfterChangeVerticalLineSeparatorPosition();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiEditorsCellStringSeparatorsPositionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeMultiEditorsCellStringSeparatorsPosition();
				this.UIVerticalGridTreeListMap.CheckMultiEditorsRowsCellLengthsAfterChangeStringSeparatorPosition();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiEditorsHeaderCellVerticalLineSeparatorsPositionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeMultiEditorsHeaderCellVerticalLineSeparatorsPosition();
				this.UIVerticalGridTreeListMap.CheckMultiEditorsRowsHeaderCellLengthsAfterChangeVerticalLineSeparatorPosition();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiEditorsHeaderCellStringSeparatorsPositionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeMultiEditorsHeaderCellStringSeparatorsPosition();
				this.UIVerticalGridTreeListMap.CheckMultiEditorsRowsHeaderCellLengthsAfterChangeStringSeparatorPosition();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiEditorsSeparatorStringTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeMultiEditorsSeparatorString();
				this.UIVerticalGridTreeListMap.CheckChangedMultiEditorsSeparatorString();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridRowToCustomizationFormTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridRowInCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridCategoryRowToCustomizationFormTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridRowFromCustomizationFormWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowFromCustomizationFormWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowFromCustomizationFormWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridRowFromCustomizationFormWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowFromCustomizationFormWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridRowFromCustomizationFormWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowFromCustomizationFormWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowFromCustomizationFormWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridRowFromCustomizationFormWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowFromCustomizationFormWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowFromCustomizationFormWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridCategoryRowFromCustomizationFormWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowFromCustomizationFormWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowFromCustomizationFormWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridCategoryRowFromCustomizationFormWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowFromCustomizationFormWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridCategoryRowFromCustomizationFormWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowFromCustomizationFormWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowFromCustomizationFormWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragVerticalGridCategoryRowFromCustomizationFormWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.SwitchToRowsTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingRowFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.SwitchToCategoriesTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowFromCustomizationFormWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingCategoryRowFromCustomizationFormWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void AddNewCategoryRowViaCustomizationFormTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.AddNewCategoryRowViaCustomizationFormOkButton();
				this.UIVerticalGridTreeListMap.CheckAddedCategoryRowInCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void DragAddedCategoryFromCustomizationFormWithMoveChildDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.AddNewCategoryRowViaEnterKey();
				this.UIVerticalGridTreeListMap.CheckAddedCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragAddedCategoryFromCustomizationFormWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingAddedCategoryRowFromCustomizationFormWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void DragAddedCategoryFromCustomizationFormWithMoveToEndDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.AddNewCategoryRowViaEnterKey();
				this.UIVerticalGridTreeListMap.CheckAddedCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragAddedCategoryFromCustomizationFormWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingAddedCategoryRowFromCustomizationFormWithMoveToEndDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void DragAddedCategoryFromCustomizationFormWithInsertBeforeDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.AddNewCategoryRowViaEnterKey();
				this.UIVerticalGridTreeListMap.CheckAddedCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragAddedCategoryFromCustomizationFormWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingAddedCategoryRowFromCustomizationFormWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void DragAddedCategoryFromCustomizationFormWithInsertAfterDragActionTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.AddNewCategoryRowViaEnterKey();
				this.UIVerticalGridTreeListMap.CheckAddedCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragVerticalGridRowWithMoveToEndDragAction();
				this.UIVerticalGridTreeListMap.SwitchToCategoriesTabInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragAddedCategoryFromCustomizationFormWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingAddedCategoryRowFromCustomizationFormWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void DeleteVerticalGridCategoryRowViaCustomizationFromTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DragVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DragAnotherVerticalGridCategoryRowToCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckAnotherVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.DeleteVerticalGridCategoryRowInCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckDeletedVerticalGridCategoryRowInCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridFocusedCellEditorValueViaEnterKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDataModeDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridFocusedCellEditorValueViaEnterKey();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridFocusedCellEditorValueViaF2KeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDataModeDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridFocusedCellEditorValueViaF2Key();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridFocusedCellEditorValueViaCharacterKeysTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDataModeDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridFocusedCellEditorValueViaCharacterKeys();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaCharacterKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridFocusedCellEditorValueViaEscKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDataModeDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridFocusedCellEditorValueViaEscKey();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaEscKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellDateFormatValueTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowFormatDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellDateFormatValue();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellDateFormatValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellDecimalFormatValueTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowFormatDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellDecimalFormatValue();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellDecimalFormatValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridFirstCellValueViaHomeKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridFirstCellValueViaHomeKey();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridFirstCellValueViaHomeKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridLastCellValueViaEndKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridLastCellValueViaEndKey();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridLastCellValueViaEndKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellValueViaPageDownKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueViaPageDownKey();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaPageDownKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellValueViaPageUpKeyTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueViaPageUpKey();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaPageUpKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellValueViaCtrlEndShortcutTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueViaCtrlEndShortcut();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaCtrlEndShortcut();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellValueViaCtrlHomeShortcutTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueViaCtrlHomeShortcut();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaCtrlHomeShortcut();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void EditingVerticalGridCellValueViaArrowKeysTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToRowsNavigationDemoModule();
				this.UIVerticalGridTreeListMap.EditingVerticalGridCellValueViaArrowKeys();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaArrowKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiRecorViewVerticalGridCellValueViaScrollingRecordsTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToScrollVisibilityDemoModule();
				this.UIVerticalGridTreeListMap.SwitchToHorizontalScrollVisibility();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueAfterScrollingRecords();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaScrollingRecords();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeBandViewVerticalGridCellValueViaScrollingRecordsTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToScrollVisibilityDemoModule();
				this.UIVerticalGridTreeListMap.SwitchVerticalGridLayoutStyleToBandsView();
				this.UIVerticalGridTreeListMap.SwitchToHorizontalScrollVisibility();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueAfterScrollingRecords();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaScrollingRecords();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeSingleRecordViewVerticalGridCellValueViaScrollingRecordsTest() {
			using(new VerticalGridTestInitializer("verticalgridDemoTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToScrollVisibilityDemoModule();
				this.UIVerticalGridTreeListMap.SwitchVerticalGridLayoutStyleToSingleRecordView();
				this.UIVerticalGridTreeListMap.SwitchToHorizontalScrollVisibility();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellValueAfterScrollingRecords();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellValueViaScrollingRecords();
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
