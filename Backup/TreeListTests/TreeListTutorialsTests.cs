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
	public class TreeListTutorialsTests {
		public TreeListTutorialsTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseTreeListNodeViaClickExpandButtonTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandTreeListNodeViaClickExpandButtonTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandTreeListNodeViaClickExpandButton();
				this.UIVerticalGridTreeListMap.CheckNodeExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseTreeListNodeViaDoubleClickTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandTreeListNodeViaDoubleClickTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandTreeListNodeViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckNodeExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseTreeListNodeViaCtrlAndLeftArrowKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaCtrlAndLeftArrowKeys();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandTreeListNodeViaCtrlAndRightArrowKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaCtrlAndLeftArrowKeys();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandTreeListNodeViaCtrlAndRightArrowKeys();
				this.UIVerticalGridTreeListMap.CheckNodeExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseTreeListNodeViaMinusKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandTreeListNodeViaPlusKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaMinusKey();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandTreeListNodeViaPlusKey();
				this.UIVerticalGridTreeListMap.CheckNodeExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CollapseTreeListNodeViaDoubleClickRowIndicatorTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaDoubleClickRowIndicator();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ExpandTreeListNodeViaDoubleClickRowIndicatorTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnAlignmentDemoModule();
				this.UIVerticalGridTreeListMap.CollapseTreeListNodeViaDoubleClickRowIndicator();
				this.UIVerticalGridTreeListMap.CheckNodeCollapsedState();
				this.UIVerticalGridTreeListMap.ExpandTreeListNodeViaDoubleClickRowIndicator();
				this.UIVerticalGridTreeListMap.CheckNodeExpandedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ReorderColumnsViaDraggingTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.ReorderColumnsViaDragging();
				this.UIVerticalGridTreeListMap.CheckColumnsPositionsAfterReordering();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DeleteColumnsViaDraggingTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DeleteColumnsViaDragging();
				this.UIVerticalGridTreeListMap.CheckDeletedColumnViaDragging();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragColumnFromCustomizationFormTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnCustomizationDemoModule();
				this.UIVerticalGridTreeListMap.DeleteColumnsViaDragging();
				this.UIVerticalGridTreeListMap.CheckDeletedColumnViaDragging();
				this.UIVerticalGridTreeListMap.DragColumnFromCustomizationForm();
				this.UIVerticalGridTreeListMap.CheckColumnsPositionsAfterDraggingFromCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragNodesToDragAndDropAreaTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.DragNodesToDragAndDropArea();
				this.UIVerticalGridTreeListMap.CheckDragAndDropListBoxItems();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DisableDragNodesOptionAndDragNodesTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.DisableDragNodesOption();
				this.UIVerticalGridTreeListMap.DragNodesToDragAndDropAreaWithDisabledDragAndDropOption();
				this.UIVerticalGridTreeListMap.CheckEmptyDragAndDropListBox();
				DXListBox uIListBox1List = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIDragDropCustom.UIListBox1List;
				Assert.IsTrue(uIListBox1List.ItemsText.Length == 0);
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragNodeWithMoveChildDragActionTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.DragNodeWithMoveChildDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingNodeWithMoveChildDragAction();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragNodeWithInsertBeforeDragActionTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.DragNodeWithInsertBeforeDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingNodeWithInsertBeforeDragAction();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragNodeWithInsertAfterDragActionTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDragAndDropDemoModule();
				this.UIVerticalGridTreeListMap.DragNodeWithInsertAfterDragAction();
				this.UIVerticalGridTreeListMap.CheckDraggingNodeWithInsertAfterDragAction();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellCurrencyFormatValueTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnFormatDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellCurrencyFormatValue();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellCurrencyFormatValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellLongDateFormatValueTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnFormatDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellLongDateFormatValue();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellLongDateFormatValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellPurchaseDateFormatValueTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToColumnFormatDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellPurchaseDateFormatValue();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellPurchaseDateFormatValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CreateNodesHierarchyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToCustomTreeListNodeDemoModule();
				this.UIVerticalGridTreeListMap.CreateNodesHierarchy();
				this.UIVerticalGridTreeListMap.CheckCreatedNodesHierarchy();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaCheckBoxEditorTest() { 
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDataModeDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaCheckBoxEditor(); 
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaCheckBoxEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaTextBoxEditorTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListDataModeDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaTextBoxEditor();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaTextBoxEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaComboBoxEditorTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToDataStoreDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaComboBoxEditor();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaComboBoxEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaClickAndHoldingDownCtrlKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				this.UIVerticalGridTreeListMap.SelectNodesViaClickAndHoldingDownCtrlKey();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaClickAndHoldingDownCtrlKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaClickAndHoldingDownShiftKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				this.UIVerticalGridTreeListMap.SelectNodesViaClickAndHoldingDownShiftKey();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaClickAndHoldingDownShiftKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void MoveCellFocusViaCtrlAndArrowKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				DXTreeList treeList = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList;
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				this.UIVerticalGridTreeListMap.SelectNodesViaClickAndHoldingDownShiftKey();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaClickAndHoldingDownShiftKey();
				DXTreeListCell oldFocusedCell = treeList.FocusedCell;
				this.UIVerticalGridTreeListMap.MoveCellFocusViaCtrlAndArrowKey();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaClickAndHoldingDownShiftKey();
				DXTreeListCell newFocusedCell = treeList.FocusedCell;
				Assert.IsTrue(oldFocusedCell != newFocusedCell && newFocusedCell.Text == "Marketing");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaShiftAndUpKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				DXTreeList uITreeList = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList;
				DevExpress.CodedUIExtension.DXTestControls.v15_2.DXTreeList.TreeListSelection selection = uITreeList.Selection;
				DXTreeListNode uINode0TreeListNode = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList.UINode0TreeListNode.UINode0TreeListNode1.UINode0TreeListNode;
				DXTreeListNode uINode1TreeListNode = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList.UINode0TreeListNode.UINode0TreeListNode1.UINode1TreeListNode;
				DXTreeListNode uINode1TreeListNode1 = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList.UINode0TreeListNode.UINode1TreeListNode;
				DXTreeListNode uINode1TreeListNode2 = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList.UINode0TreeListNode.UINode2TreeListNode.UINode1TreeListNode;
				DXTreeListNode uINode0TreeListNode1 = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList.UINode0TreeListNode.UINode2TreeListNode.UINode0TreeListNode;
				DXTreeListNode uINode2TreeListNode = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList.UINode0TreeListNode.UINode2TreeListNode;
				DXTreeListNode[] nodes = {
				uINode1TreeListNode2,
				uINode0TreeListNode1,
				uINode2TreeListNode,
				uINode1TreeListNode1,
				uINode1TreeListNode,
				uINode0TreeListNode };
				selection.Set(nodes);
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaShiftAndUpKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaShiftAndDownKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				DXTreeList uITreeList = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UIMultiSelectCustom.UITreeList1TreeList;
				DevExpress.CodedUIExtension.DXTestControls.v15_2.DXTreeList.TreeListSelection selection = uITreeList.Selection;
				DXTreeListNode node0 = new DXTreeListNode(uITreeList, 0);
				DXTreeListNode node02 = new DXTreeListNode(node0, 2);
				DXTreeListNode node020 = new DXTreeListNode(node02, 0);
				DXTreeListNode node021 = new DXTreeListNode(node02, 1);
				DXTreeListNode[] nodes = {node02, node020, node021};
				selection.Set(nodes);
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaShiftAndDownKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaClickAndHoldingDownCtrlAndShiftKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				this.UIVerticalGridTreeListMap.SelectNodesViaClickAndHoldingDownCtrlAndShiftKey();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaClickAndHoldingDownCtrlAndShiftKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaShiftCtrlAndUpKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				this.UIVerticalGridTreeListMap.SelectNodesViaShiftCtrlAndUpKeys();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaShiftCtrlAndUpKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void SelectNodesViaShiftCtrlAndDownKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToMultiSelectDemoModule();
				this.UIVerticalGridTreeListMap.SelectNodesViaShiftCtrlAndDownKeys();
				this.UIVerticalGridTreeListMap.CheckSelectedNodesViaShiftCtrlAndDownKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CheckNodesTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodeCheckingDemoModule();
				this.UIVerticalGridTreeListMap.CheckNodes();
				this.UIVerticalGridTreeListMap.CheckNodesCheckedStates();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DisableRecursiveNodesCheckingOptionAndCheckNodesViaKeyboardTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodeCheckingDemoModule();
				this.UIVerticalGridTreeListMap.DisableRecursiveNodesCheckingOption();
				this.UIVerticalGridTreeListMap.CheckNodesViaKeyboard();
				this.UIVerticalGridTreeListMap.CheckChangedNodesCheckedStatesViaKeyboard();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void EnableIndeterminateCheckStateOptionAndCheckNodesTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodeCheckingDemoModule();
				this.UIVerticalGridTreeListMap.DisableRecursiveNodesCheckingOption();
				this.UIVerticalGridTreeListMap.EnableIndeterminateCheckStateOption();
				this.UIVerticalGridTreeListMap.CheckNodesAfterEnablingIndeterminateCheckStateOption();
				this.UIVerticalGridTreeListMap.CheckChangedNodesCheckedStateAfterEnablingIndeterminateCheckStateOption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AscendingSortDataViaMouseTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.AscendingSortDataViaMouse();
				DXTreeListCell uIItem15TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode0TreeListNode.UIItem15TreeListCell;
				DXTreeListCell uIItem91TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode15TreeListNode.UIItem91TreeListCell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem15TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem91TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell < valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AscendingSortDataViaContextMenuTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.AscendingSortDataViaContextMenu();
				DXTreeListCell uIItem15TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode0TreeListNode.UIItem15TreeListCell;
				DXTreeListCell uIItem91TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode15TreeListNode.UIItem91TreeListCell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem15TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem91TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell < valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DescendingSortDataViaMouseTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.DescendingSortDataViaMouse();
				DXTreeListCell uIItem15TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode0TreeListNode.UIItem15TreeListCell;
				DXTreeListCell uIItem91TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode15TreeListNode.UIItem91TreeListCell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem15TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem91TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell > valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DescendingSortDataViaContextMenuTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.DescendingSortDataViaContextMenu();
				DXTreeListCell uIItem15TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode0TreeListNode.UIItem15TreeListCell;
				DXTreeListCell uIItem91TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode15TreeListNode.UIItem91TreeListCell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem15TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem91TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell > valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AscendingSortTreeListColumnDataAndRemovePreviousAnotherColumnDataSortingTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.DescendingSortDataViaContextMenu();
				this.UIVerticalGridTreeListMap.AscendingSortTreeListColumnDataAndRemovePreviousAnotherColumnDataSorting();
				DXTreeListCell uICroakerTreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode4TreeListNode.UICroakerTreeListCell;
				DXTreeListCell uISpadefishTreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode17TreeListNode.UISpadefishTreeListCell;
				string valueUpCellAsString = (String)uICroakerTreeListCell.GetProperty("ValueAsString");
				string valueDownCellAsString = (String)uISpadefishTreeListCell.GetProperty("ValueAsString");
				Assert.IsTrue(valueUpCellAsString.Substring(0, 1).ToCharArray()[0] < valueDownCellAsString.Substring(0, 1).ToCharArray()[0]);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AscendingSortTreeListColumnDataAndPreservePreviousAnotherColumnDataSortingTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.DescendingSortDataViaMouse();
				this.UIVerticalGridTreeListMap.AscendingSortTreeListColumnDataAndPreservePreviousAnotherColumnDataSorting();
				DXTreeListCell uIItem15TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode0TreeListNode.UIItem15TreeListCell;
				DXTreeListCell uIItem91TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode15TreeListNode.UIItem91TreeListCell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem15TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem91TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell > valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void RemoveSortTreeListColumnDataAndPreservePreviousAnotherColumnDataSortingTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.DescendingSortDataViaMouse();
				this.UIVerticalGridTreeListMap.AscendingSortTreeListColumnDataAndPreservePreviousAnotherColumnDataSorting();
				DXTreeListCell uIItem15TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode0TreeListNode.UIItem15TreeListCell;
				DXTreeListCell uIItem91TreeListCell = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UINode15TreeListNode.UIItem91TreeListCell;
				double valueUpCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem15TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				double valueDownCell = (Double)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItem91TreeListCell.GetProperty("ValueAsString"), typeof(Double).FullName);
				Assert.IsTrue(valueUpCell > valueDownCell);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListFocusedCellEditorValueViaClickCellAndEnterKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListFocusedCellEditorValueViaClickCellAndEnterKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListFocusedCellEditorValueViaClickIndicatorNodeAndEnterKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListFocusedCellEditorValueViaClickIndicatorNodeAndEnterKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListFocusedCellEditorValueViaF2KeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListFocusedCellEditorValueViaF2Key();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListFocusedCellEditorValueViaCharacterKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListFocusedCellEditorValueViaCharacterKeys();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListFocusedCellEditorValueViaEscKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListFocusedCellEditorValueViaEscKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaEscKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaDownAndRightKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaDownAndRightKeys();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaArrowKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ChangeTreeListCellValueViaUpAndLeftKeysTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaUpAndLeftKeys();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaUpAndLeftKeys();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaHomeKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaHomeKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaHomeKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaEndKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaEndKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaEndKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaPageUpKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaPageUpKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaPageUpKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellValueViaPageDownKeyTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellValueViaPageDownKey();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellValueViaPageDownKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListFirstCellValueViaCtrlHomeShortcutTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListFirstCellValueViaCtrlHomeShortcut();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListFirstCellValueViaCtrlHomeShortcut();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListLastCellValueViaCtrlEndShortcutTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListLastCellValueViaCtrlEndShortcut();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListLastCellValueViaCtrlEndShortcut();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void ResizeColumnHeaderViaDraggingRightEdgeTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				this.UIVerticalGridTreeListMap.ResizeColumnHeaderViaDraggingRightEdge();
				this.UIVerticalGridTreeListMap.CheckColumnHeaderWidthAfterDraggingRightEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ResizeColumnHeaderViaDoubleClickColumnHeaderRightEdgeTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesNavigationDemoModule();
				DXTreeListColumnHeader uICommonNameTreeListColumnHeader = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodesNavigationCustom.UITreeList1TreeList.UICommonNameTreeListColumnHeader;
				int oldHeaderWidth = (Int32)uICommonNameTreeListColumnHeader.GetProperty("Width");
				this.UIVerticalGridTreeListMap.ResizeColumnHeaderViaDoubleClickColumnHeaderRightEdge();
				int newHeaderWidth = (Int32)uICommonNameTreeListColumnHeader.GetProperty("Width");
				Assert.IsTrue(newHeaderWidth < oldHeaderWidth);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ResizeColumnHeaderViaBestFitContextMenuOptionTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodeCheckingDemoModule();
				DXTreeListColumnHeader uIDepartmentTreeListColumnHeader = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodeCheckingCustom.UITreeList1TreeList.UIDepartmentTreeListColumnHeader;
				int oldHeaderWidth = (Int32)uIDepartmentTreeListColumnHeader.GetProperty("Width");
				this.UIVerticalGridTreeListMap.ResizeColumnHeaderViaBestFitContextMenuOption();
				int newHeaderWidth = (Int32)uIDepartmentTreeListColumnHeader.GetProperty("Width");
				Assert.IsTrue(newHeaderWidth < oldHeaderWidth);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ResizeColumnHeadersViaBestFitAllColunsContextMenuOptionTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToNodeCheckingDemoModule();
				DXTreeListColumnHeader uIDepartmentTreeListColumnHeader = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodeCheckingCustom.UITreeList1TreeList.UIDepartmentTreeListColumnHeader;
				DXTreeListColumnHeader uIBudgetTreeListColumnHeader = UIVerticalGridTreeListMap.UITutorialsCcodeWindow.UIPcMainClient.UIGcContainerClient.UINodeCheckingCustom.UITreeList1TreeList.UIBudgetTreeListColumnHeader;
				int oldHeaderDepartmentWidth = (Int32)uIDepartmentTreeListColumnHeader.GetProperty("Width");
				int oldHeaderBudgetWidth = (Int32)uIBudgetTreeListColumnHeader.GetProperty("Width");
				this.UIVerticalGridTreeListMap.ResizeColumnHeadersViaBestFitAllColumnsContextMenuOption();
				int newHeaderDepartmentWidth = (Int32)uIDepartmentTreeListColumnHeader.GetProperty("Width");
				int newHeaderBudgetWidth = (Int32)uIBudgetTreeListColumnHeader.GetProperty("Width");
				Assert.IsTrue(oldHeaderDepartmentWidth < newHeaderDepartmentWidth && oldHeaderBudgetWidth < newHeaderBudgetWidth);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AddNewSummariesMinFooterCellTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.AddNewSummariesMinFooterCell();
				this.UIVerticalGridTreeListMap.CheckAddedSummariesMinFooterCell();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AddNewSummariesMaxFooterCellTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.AddNewSummariesMaxFooterCell();
				this.UIVerticalGridTreeListMap.CheckAddedSummariesMaxFooterCell();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AddNewSummariesCountGroupFooterCellTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.AddNewSummariesCountGroupFooterCell();
				this.UIVerticalGridTreeListMap.CheckAddedSummariesCountGroupFooterCell();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void RemoveSummariesFooterCellTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.RemoveSummariesFooterCell();
				this.UIVerticalGridTreeListMap.CheckRemovedSummariesFooterCell();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void RemoveSummariesGroupFooterCellTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.RemoveSummariesGroupFooterCell();
				this.UIVerticalGridTreeListMap.CheckRemovedSummariesGroupFooterCell();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DicableSummariesFooterCellsAllNodesContextOptionTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.DisableSummariesFooterCellsAllNodesContextOption();
				this.UIVerticalGridTreeListMap.CheckSummariesFooterCell();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ModifySummariesFooterCellsTypeTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.ModifySummariesFooterCellsType();
				this.UIVerticalGridTreeListMap.CheckModifiedSummariesFooterCells();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ModifySummariesGroupFooterCellsTypeTest() {
			using(new TreeListTestInitializer("treeListTutorials")) {
				this.UIVerticalGridTreeListMap.SwitchToSummariesDemoModule();
				this.UIVerticalGridTreeListMap.ModifySummariesGroupFooterCellsType();
				this.UIVerticalGridTreeListMap.CheckModifiedSummariesGroupFooterCellsType();
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
