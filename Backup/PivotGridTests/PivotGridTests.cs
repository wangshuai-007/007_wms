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
using DevExpress.Win.FunctionalTests.UIMaps.PivotGridUIMapClasses;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class PivotGridTests {
		public PivotGridTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void AddFieldFilteringViaFieldHeaderFilterButton() {
			using(new PivotGridTestInitializer()) {
				PivotUIMap.SwitchToMultipleTotalsDemoModule();
				PivotUIMap.CheckGrandTotalCellsValues();
				PivotUIMap.ExcludeConfectionsCategoryViaFieldHeaderFiltering();
				PivotUIMap.CheckGrandTotalCellsValuesAfterExcludingConfectionsCategory();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeFieldHeadersPositionViaDragging() {
			using(new PivotGridTestInitializer()) {
				PivotUIMap.SwitchToSingleTotalDemoModule();
				PivotUIMap.CheckRowAndColumnCountInSingleTotalDemoModule();
				PivotUIMap.CheckAllFieldHeadersPositionInSingleTotalModule();
				PivotUIMap.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModule();
				PivotUIMap.CheckNewFieldHeadersPositionInSingleTotalModule();
				PivotUIMap.CheckCellsValuesAfterFieldHeadersPositionChanged();
				PivotUIMap.CheckRowAndColumnCountAfterFieldHeadersPositionChanged();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeFieldHeadersPositionViaHandCoding() {
			using(new PivotGridTestInitializer()) {
				PivotUIMap.SwitchToSingleTotalDemoModule();
				DXPivotGrid pivot = PivotUIMap.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid;
				DXPivotGridFieldHeader productNameFieldHeader = pivot.GetFieldHeader("ProductName");
				DXPivotGridFieldHeader categoryNameFieldHeader = pivot.GetFieldHeader("CategoryName");
				Assert.AreEqual(PivotAreaType.RowArea, productNameFieldHeader.Area);
				Assert.AreEqual(1, productNameFieldHeader.AreaIndex);
				Assert.AreEqual(PivotAreaType.RowArea, categoryNameFieldHeader.Area);
				Assert.AreEqual(0, categoryNameFieldHeader.AreaIndex);
				productNameFieldHeader.AreaIndex = 0;
				Assert.AreEqual(PivotAreaType.RowArea, productNameFieldHeader.Area);
				Assert.AreEqual(0, productNameFieldHeader.AreaIndex);
				Assert.AreEqual(PivotAreaType.RowArea, categoryNameFieldHeader.Area);
				Assert.AreEqual(1, categoryNameFieldHeader.AreaIndex);
				categoryNameFieldHeader.Area = PivotAreaType.ColumnArea;
				Assert.AreEqual(PivotAreaType.ColumnArea, categoryNameFieldHeader.Area);
				categoryNameFieldHeader.AreaIndex = 0;
				Assert.AreEqual(0, categoryNameFieldHeader.AreaIndex);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeCellsValuesViaHandCoding() {
			using(new PivotGridTestInitializer()) {
				decimal firstCellNewValue = 2.87m;
				decimal secondCellNewValue = 3.62m;
				decimal thirdCellNewValue = 4.12m;
				PivotUIMap.SwitchToInPlaceEditorsDemoModule();
				DXPivotGrid pivot = PivotUIMap.UIXtraPivotGridFeatureWindow2.UIPanelControl1Client.UIGcContainerClient.UIInplaceEditorsCustom.UIMainPanelClient.UIPivotGridControlPivotGrid;
				Mouse.Click(pivot.FocusedCell);
				DXTestControl activeEditor = pivot.ActiveEditor;
				activeEditor.Value = firstCellNewValue;
				pivot.FocusedCell = pivot.GetCell(0, 1);
				Keyboard.SendKeys("{Enter}");
				activeEditor = pivot.ActiveEditor;
				activeEditor.Value = secondCellNewValue;
				activeEditor = pivot.GetCell(0, 2).ActiveEditor;
				activeEditor.Value = thirdCellNewValue;
				Mouse.Click(pivot.GetCell(0, 3));
				Assert.AreEqual(firstCellNewValue, Decimal.Round((decimal)pivot.GetCellValue(0, 0), 5));
				Assert.AreEqual(secondCellNewValue, Decimal.Round((decimal)pivot.GetCell(0, 1).Value, 5));
				Assert.AreEqual(thirdCellNewValue, Decimal.Round((decimal)pivot.GetCellValue(0, 2), 5));
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void TestOtherHandCodingCapabilities() {
			using(new PivotGridTestInitializer()) {
				PivotUIMap.SwitchToSingleTotalDemoModule();
				DXPivotGrid pivot = PivotUIMap.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid;
				DXPivotGridCell cell = pivot.GetCell(1, 1);
				DXPivotGridFieldValue columnFieldValueItem = cell.ColumnFieldValueItem;
				DXPivotGridFieldValue rowFieldValueItem = cell.RowFieldValueItem;
				DXPivotGridFieldValue dataFieldValueItem = cell.DataFieldValueItem;
				DXPivotGridFieldHeader columnFieldHeader = cell.ColumnFieldHeader;
				DXPivotGridFieldHeader rowFieldHeader = cell.RowFieldHeader;
				DXPivotGridFieldHeader dataFieldHeader = cell.DataFieldHeader;
				Assert.AreEqual("fieldQuarter", columnFieldValueItem.FieldName);
				Assert.AreEqual(1, columnFieldValueItem.Level);
				Assert.AreEqual(0, columnFieldValueItem.LastLevelIndex);
				Assert.AreEqual(PivotAreaType.ColumnArea, columnFieldValueItem.Area);
				Assert.AreEqual(1, columnFieldValueItem.Value);
				Assert.AreEqual("Quarter 1", columnFieldValueItem.Text);
				Assert.AreEqual("ProductName", rowFieldValueItem.FieldName);
				Assert.AreEqual(1, rowFieldValueItem.Level);
				Assert.AreEqual(1, rowFieldValueItem.LastLevelIndex);
				Assert.AreEqual(PivotAreaType.RowArea, rowFieldValueItem.Area);
				Assert.AreEqual("Chang", rowFieldValueItem.Value);
				Assert.AreEqual("Chang", rowFieldValueItem.Text);
				Assert.AreEqual("Quantity", dataFieldValueItem.FieldName);
				Assert.AreEqual(2, dataFieldValueItem.Level);
				Assert.AreEqual(1, dataFieldValueItem.LastLevelIndex);
				Assert.AreEqual(PivotAreaType.ColumnArea, dataFieldValueItem.Area);
				Assert.AreEqual(null, dataFieldValueItem.Value);
				Assert.AreEqual("Quantity (Sum)", dataFieldValueItem.Text);
				Assert.AreEqual("fieldQuarter", columnFieldHeader.FieldName);
				Assert.AreEqual(1, columnFieldHeader.AreaIndex);
				Assert.AreEqual(PivotAreaType.ColumnArea, columnFieldHeader.Area);
				Assert.AreEqual("Quarter", columnFieldHeader.Text);
				Assert.AreEqual("ProductName", rowFieldHeader.FieldName);
				Assert.AreEqual(1, rowFieldHeader.AreaIndex);
				Assert.AreEqual(PivotAreaType.RowArea, rowFieldHeader.Area);
				Assert.AreEqual("Product Name", rowFieldHeader.Text);
				Assert.AreEqual("Quantity", dataFieldHeader.FieldName);
				Assert.AreEqual(1, dataFieldHeader.AreaIndex);
				Assert.AreEqual(PivotAreaType.DataArea, dataFieldHeader.Area);
				Assert.AreEqual("Quantity (Sum)", dataFieldHeader.Text);
				dataFieldHeader.Area = PivotAreaType.ColumnArea;
				dataFieldHeader.AreaIndex = 2;
				Assert.AreEqual(PivotAreaType.ColumnArea, dataFieldHeader.Area);
				Assert.AreEqual(2, dataFieldHeader.AreaIndex);
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
		public PivotGridUIMap PivotUIMap {
			get {
				if((this.map == null)) {
					this.map = new PivotGridUIMap();
				}
				return this.map;
			}
		}
		private PivotGridUIMap map;
	}
}
