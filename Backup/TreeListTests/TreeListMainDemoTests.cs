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
	public class TreeListMainDemoTests {
		public TreeListMainDemoTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeFilterExpressionTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesFilteringDemoModule();
				this.UIVerticalGridTreeListMap.ChangeFilterExpression();
				this.UIVerticalGridTreeListMap.CheckFilteringAfterChangingFilterExpression();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeFilterModeTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesFilteringDemoModule();
				this.UIVerticalGridTreeListMap.ChangeFilterMode();
				this.UIVerticalGridTreeListMap.CheckFilteringAfterChangingFilterMode();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ModifyFilterExpressionViaFilterEditorTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesFilteringDemoModule();
				this.UIVerticalGridTreeListMap.ModifyFilterExpressionViaFilterEditor();
				this.UIVerticalGridTreeListMap.CheckModifiedFilterExpressionFilterResults();
				this.UIVerticalGridTreeListMap.CheckTreeListColumnsFilterStringProperties();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DeactivateFilterTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesFilteringDemoModule();
				this.UIVerticalGridTreeListMap.DeactivateFilter();
				this.UIVerticalGridTreeListMap.CheckDeactivatedFilter();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DeleteFilterViaClickCloseFilterPanelButtonTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesFilteringDemoModule();
				this.UIVerticalGridTreeListMap.DeleteFilterViaClickCloseFilterPanelButton();
				this.UIVerticalGridTreeListMap.CheckDeletedFilter();
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellsValueForControlPropertyGrindChangesTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToBusinessObjectBindingDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellsValueForControlPropertyGrindChanges();
				this.UIVerticalGridTreeListMap.CheckPropertyGrindChanges();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellsValueViaCalcEditorTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellsValueViaCalcEditor();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellsValueViaCalcEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellsValueViaSpinEditorTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellsValueViaSpinEditor();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellsValueViaSpinEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellsValueViaImageComboBoxEditorTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellsValueViaImageComboBoxEditor();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellsValueViaImageComboBoxEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellsValueViaTextEditorWithMaskTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellsValueViaTextEditorWithMask();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellsValueViaTextEditorWithMask();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeTreeListCellsValueViaProgressBarEditorTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListMultiEditorsRowDemoModule();
				this.UIVerticalGridTreeListMap.ChangeTreeListCellsValueViaProgressBarEditor();
				this.UIVerticalGridTreeListMap.CheckChangedTreeListCellsValueViaProgressBarEditor();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ResizeNodesViaDraggingIndicatorRowBottomEdgeTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToTreeListMultiEditorsRowDemoModule();
				DXTreeListCell uIProductNameTreeListCell = UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow2.UIPanelControl1Client.UIGcContainerClient.UITreeListMultiEditorsCustom.UITreeList1TreeList.UINode0TreeListNode.UIProductNameTreeListCell;
				Size oldCellSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIProductNameTreeListCell.GetProperty("Size"), typeof(Size).FullName);
				this.UIVerticalGridTreeListMap.ResizeNodesViaDraggingIndicatorRowBottomEdge();
				Size newCellSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIProductNameTreeListCell.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newCellSize.Height > oldCellSize.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestMethod]
		public void ModifyFixedColumnFixedStyleTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedColumnsDemoModule();
				this.UIVerticalGridTreeListMap.ModifyFixedColumnFixedStyle();
				DXTreeListColumnHeader uICommonNameTreeListColumnHeader = UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow3.UIPanelControl1Client.UIGcContainerClient.UIFixedColumnsCustom.UITreeList1TreeList.UICommonNameTreeListColumnHeader;
				Assert.IsTrue(uICommonNameTreeListColumnHeader.Fixed == FixedStyle.Right);
				Assert.IsTrue(IsTreeListColumnFixed(uICommonNameTreeListColumnHeader));
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestMethod]
		public void MakeFixedColumnNotFixedTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedColumnsDemoModule();
				this.UIVerticalGridTreeListMap.MakeFixedColumnNotFixed();
				DXTreeListColumnHeader commonNameTreeListColumnHeader = UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow3.UIPanelControl1Client.UIGcContainerClient.UIFixedColumnsCustom.UITreeList1TreeList.
					UICommonNameTreeListColumnHeader;
				Assert.IsTrue(commonNameTreeListColumnHeader.Fixed == FixedStyle.None);
				Assert.IsFalse(IsTreeListColumnFixed(commonNameTreeListColumnHeader));
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestMethod]
		public void MakeColumnFixedLeftTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedColumnsDemoModule();
				DXTreeListColumnHeader uICategoryTreeListColumnHeader = UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow3.UIPanelControl1Client.UIGcContainerClient.UIFixedColumnsCustom.UITreeList1TreeList.UICategoryTreeListColumnHeader;
				this.UIVerticalGridTreeListMap.MakeColumnFixedLeft();
				Assert.IsTrue(uICategoryTreeListColumnHeader.Fixed == FixedStyle.Left);
				Assert.IsTrue(IsTreeListColumnFixed(uICategoryTreeListColumnHeader));
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestMethod]
		public void MakeColumnFixedRightTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToFixedColumnsDemoModule();
				DXTreeListColumnHeader uICategoryTreeListColumnHeader = UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow3.UIPanelControl1Client.UIGcContainerClient.UIFixedColumnsCustom.UITreeList1TreeList.UICategoryTreeListColumnHeader;
				this.UIVerticalGridTreeListMap.MakeColumnFixedRight();
				Assert.IsTrue(uICategoryTreeListColumnHeader.Fixed == FixedStyle.Right);
				Assert.IsTrue(IsTreeListColumnFixed(uICategoryTreeListColumnHeader));
			}
		}
		public bool IsTreeListColumnFixed(DXTreeListColumnHeader column) {
			column.TreeList.LeftCoord = 0;
			column.MakeVisible();
			if(column.TreeList.LeftCoord != 0)
				return false;
			column.TreeList.LeftCoord = 100500;
			int oldLeftCoord = column.TreeList.LeftCoord;
			column.MakeVisible();
			return column.TreeList.LeftCoord == oldLeftCoord;
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void DragAndDropNewTreeListNodesTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				TreeListDemoModules.SwitchToDemoModule(UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow.UIGcNavigationsClient.UIAccordionControl1AccordionControl,
					TreeListDemoModules.ModuleGroups.Miscellaneous, TreeListDemoModules.Modules.DragAndDrop);
				this.UIVerticalGridTreeListMap.DragAndDropNewTreeListNodes();
				this.UIVerticalGridTreeListMap.CheckAddedTreeListNodes();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void CopyTreeListNodeViaDraggingAndHoldingDownCtrlKeyTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				TreeListDemoModules.SwitchToDemoModule(UIVerticalGridTreeListMap.UIXtraTreeListFeaturesWindow.UIGcNavigationsClient.UIAccordionControl1AccordionControl,
					TreeListDemoModules.ModuleGroups.Miscellaneous, TreeListDemoModules.Modules.DragAndDrop);
				this.UIVerticalGridTreeListMap.CopyTreeListNodeViaDraggingAndHoldingDownCtrlKey();
				this.UIVerticalGridTreeListMap.CheckCopedTreeListNodeViaDraggingAndHoldingDownCtrlKey();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("DemoModuleRemoved"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void HideNodesViaDoubleClickTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesVisibilityDemoModule();
				this.UIVerticalGridTreeListMap.HideNodesViaDoubleClick();
				this.UIVerticalGridTreeListMap.CheckHiddenNodesViaDoubleClick();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("DemoModuleRemoved"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod] 
		public void MakeNodeVisibleViaHiddenListItemDoubleClickTest() {
			using(new TreeListTestInitializer("treeListMainDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToNodesVisibilityDemoModule();
				this.UIVerticalGridTreeListMap.MakeNodeVisibleViaHiddenListItemDoubleClick();
				this.UIVerticalGridTreeListMap.CheckVisibleNode();
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
	public class TreeListDemoModules
	{
		public class ModuleGroups
		{
			public const string Miscellaneous = "Miscellaneous";
		}
		public class Modules
		{
			public const string DragAndDrop = "Drag And Drop";
		}
		static string[] ModuleNamePostfixes = { 
										   " (updated)" 
									   };
		public static void SwitchToDemoModule(DXTestControl accordionControl, string groupName, string moduleName)
		{
			DXTestControl accordionControlGroup = new DXTestControl(accordionControl);
			accordionControlGroup.SearchProperties[DXTestControl.PropertyNames.Name] = groupName;
			accordionControlGroup.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			DXTestControl accordionControlItem = new DXTestControl(accordionControlGroup);
			accordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = moduleName;
			accordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
			if (!accordionControlItem.Exists)
				foreach (string postfix in ModuleNamePostfixes)
				{
					accordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = moduleName + postfix;
					if (accordionControlItem.Exists)
						break;
				}
			Mouse.Click(accordionControlItem);
		}
	}
}
