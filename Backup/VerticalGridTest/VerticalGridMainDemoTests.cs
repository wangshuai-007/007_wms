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
	public class VerticalGridMainDemoTests {
		public VerticalGridMainDemoTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellsValuesForCheckUnboundRowsChangesTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToUnboundExpressionsDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellsValuesForCheckUnboundRowsChanges();
				this.UIVerticalGridTreeListMap.CheckUnboundRowsChanges();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void CreateExpressionsViaExpressionsEditorTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToUnboundExpressionsDemoModule();
				this.UIVerticalGridTreeListMap.CreateExpressionsViaExpressionsEditor();
				DXButton uIPlusItemButtonButton = UIVerticalGridTreeListMap.UIExpressioneditorWindow.UIPlusItemButtonButton;
				DXListBoxItem uIDiscountListItem = UIVerticalGridTreeListMap.UIExpressioneditorWindow.UIListOfInputParameterList.UIDiscountListItem;
				DXListBoxItem uIQuantityListItem = UIVerticalGridTreeListMap.UIExpressioneditorWindow.UIListOfInputParameterList.UIQuantityListItem;
				DXListBoxItem uIUnitPriceListItem = UIVerticalGridTreeListMap.UIExpressioneditorWindow.UIListOfInputParameterList.UIUnitPriceListItem;
				Mouse.DoubleClick(uIDiscountListItem);
				Mouse.Click(uIPlusItemButtonButton, new Point(1, 1));
				Mouse.DoubleClick(uIQuantityListItem);
				Mouse.Click(uIPlusItemButtonButton, new Point(1, 1));
				Mouse.DoubleClick(uIUnitPriceListItem);
				this.UIVerticalGridTreeListMap.ClickExpressionEditorOkButton();
				this.UIVerticalGridTreeListMap.CheckAddedUnboundRow();
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellsValuesInSimpleModeTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToLayoutDemoModule();
				this.UIVerticalGridTreeListMap.SwitchToVerticalGridSimpleMode();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellsValuesInSimpleMode();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellsValuesInSimpleMode();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridCellsValuesInDataBindingModeTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToLayoutDemoModule();
				this.UIVerticalGridTreeListMap.SwitchToVerticalGridDataBindingMode();
				this.UIVerticalGridTreeListMap.SwitchButtonModeToShowForFocusedRecord();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridCellsValuesInDataBindingMode();
				this.UIVerticalGridTreeListMap.CheckChangedVerticalGridCellsValuesInDataBindingMode();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeVerticalGridFirstNameCellValueForCheckFullNameChangesTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToUnboundDataRowsDemoModule();
				this.UIVerticalGridTreeListMap.ChangeVerticalGridFirstNameCellValueForCheckFullNameChanges();
				this.UIVerticalGridTreeListMap.CheckFullNameValueAfterChangingFirstNameCellValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("VerticalGridTreeListPivotGrid"), TestCategory("VS11"), TestMethod]
		public void ChangeFullNameFormatTest() {
			using(new VerticalGridTestInitializer("verticalGridFeaturesDemo")) {
				this.UIVerticalGridTreeListMap.SwitchToUnboundDataRowsDemoModule();
				this.UIVerticalGridTreeListMap.ChangeFullNameFormat();
				this.UIVerticalGridTreeListMap.CheckFullNameValue();
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
