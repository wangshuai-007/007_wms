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

namespace DevExpress.Win.FunctionalTests.UIMaps.PivotGridUIMapClasses
{
	using System;
	using System.CodeDom.Compiler;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Text.RegularExpressions;
	using System.Windows.Input;
	using DevExpress.CodedUIExtension.DXTestControls.v15_2;
	using Microsoft.VisualStudio.TestTools.UITest.Extension;
	using Microsoft.VisualStudio.TestTools.UITesting;
	using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
	using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
	using MouseButtons = System.Windows.Forms.MouseButtons;
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public partial class PivotGridUIMap
	{
		public void SwitchToMultipleTotalsDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIMultipleTotalsAccordionControlItem = this.UIXtraPivotGridFeatureWindow.UIGcNavigationsClient.UIAccordionControl1NavBar.UISummaryAccordionControlGroup.UIMultipleTotalsAccordionControlItem;
			#endregion
			Mouse.Click(uIMultipleTotalsAccordionControlItem, new Point(0, 0));
		}
		public void CheckGrandTotalCellsValues()
		{
			#region Variable Declarations
			DXPivotGridCell uIItem59092630PivotGridCell = this.UIXtraPivotGridFeatureWindow.UIPanelControl1Client.UIGcContainerClient.UIMultipleTotalsCustom.UIPivotGridControl1PivotGrid.UIItem59092630PivotGridCell;
			DXPivotGridCell uIItem25007PivotGridCell = this.UIXtraPivotGridFeatureWindow.UIPanelControl1Client.UIGcContainerClient.UIMultipleTotalsCustom.UIPivotGridControl1PivotGrid.UIItem25007PivotGridCell;
			#endregion
			Assert.AreEqual(this.CheckGrandTotalCellsValuesExpectedValues.UIItem59092630PivotGridCellValueAsString, uIItem59092630PivotGridCell.ValueAsString);
			Assert.AreEqual(this.CheckGrandTotalCellsValuesExpectedValues.UIItem25007PivotGridCellValueAsString, uIItem25007PivotGridCell.ValueAsString);
		}
		public void ExcludeConfectionsCategoryViaFieldHeaderFiltering()
		{
			#region Variable Declarations
			DXTestControl uICategoryNameCustom = this.UIXtraPivotGridFeatureWindow.UIPanelControl1Client.UIGcContainerClient.UIMultipleTotalsCustom.UIPivotGridControl1PivotGrid.UICategoryNamePivotGridFieldHeader.UICategoryNameCustom;
			DXCheckedListBox uIFilterCheckedListBoxCheckedListBox = this.UIItemWindow.UIPivotFilterPopupContCustom.UIFilterCheckedListBoxCheckedListBox;
			DXButton uISimpleButtonButton = this.UIItemWindow.UIPivotFilterPopupContCustom1.UISimpleButtonButton;
			#endregion
			Mouse.Click(uICategoryNameCustom, new Point(5, 4));
			uIFilterCheckedListBoxCheckedListBox.CheckedIndicesAsString = this.ExcludeConfectionsCategoryViaFieldHeaderFilteringParams.UIFilterCheckedListBoxCheckedListBoxCheckedIndicesAsString;
			Mouse.Click(uISimpleButtonButton, new Point(1, 1));
		}
		public void CheckGrandTotalCellsValuesAfterExcludingConfectionsCategory()
		{
			#region Variable Declarations
			DXPivotGridCell uIItem51117409PivotGridCell = this.UIXtraPivotGridFeatureWindow.UIPanelControl1Client.UIGcContainerClient.UIMultipleTotalsCustom.UIPivotGridControl1PivotGrid.UIItem51117409PivotGridCell;
			DXPivotGridCell uIItem21101PivotGridCell = this.UIXtraPivotGridFeatureWindow.UIPanelControl1Client.UIGcContainerClient.UIMultipleTotalsCustom.UIPivotGridControl1PivotGrid.UIItem21101PivotGridCell;
			#endregion
			Assert.AreEqual(this.CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues.UIItem51117409PivotGridCellValueAsString, uIItem51117409PivotGridCell.ValueAsString);
			Assert.AreEqual(this.CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues.UIItem21101PivotGridCellValueAsString, uIItem21101PivotGridCell.ValueAsString);
		}
		public void SwitchToSingleTotalDemoModule()
		{
			#region Variable Declarations
			DXTestControl uISingleTotalAccordionControlItem = this.UIXtraPivotGridFeatureWindow.UIGcNavigationsClient.UIAccordionControl1NavBar.UISummaryAccordionControlGroup.UISingleTotalAccordionControlItem;
			#endregion
			Mouse.Click(uISingleTotalAccordionControlItem, new Point(0, 0));
		}
		public void CheckAllFieldHeadersPositionInSingleTotalModule()
		{
			#region Variable Declarations
			DXPivotGridFieldHeader uIYearPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIYearPivotGridFieldHeader;
			DXPivotGridFieldHeader uIQuarterPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIQuarterPivotGridFieldHeader;
			DXPivotGridFieldHeader uIDataPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIDataPivotGridFieldHeader;
			DXPivotGridFieldHeader uICategoryNamePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UICategoryNamePivotGridFieldHeader;
			DXPivotGridFieldHeader uIProductNamePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIProductNamePivotGridFieldHeader;
			DXPivotGridFieldHeader uIUnitPriceMaxPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIUnitPriceMaxPivotGridFieldHeader;
			DXPivotGridFieldHeader uIQuantitySumPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIQuantitySumPivotGridFieldHeader;
			DXPivotGridFieldHeader uIDiscountAveragePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIDiscountAveragePivotGridFieldHeader;
			#endregion
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIYearPivotGridFieldHeaderArea, uIYearPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIYearPivotGridFieldHeaderIndex, uIYearPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuarterPivotGridFieldHeaderArea, uIQuarterPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuarterPivotGridFieldHeaderIndex, uIQuarterPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDataPivotGridFieldHeaderArea, uIDataPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDataPivotGridFieldHeaderIndex, uIDataPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UICategoryNamePivotGridFieldHeaderArea, uICategoryNamePivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UICategoryNamePivotGridFieldHeaderIndex, uICategoryNamePivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIProductNamePivotGridFieldHeaderArea, uIProductNamePivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIProductNamePivotGridFieldHeaderIndex, uIProductNamePivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIUnitPriceMaxPivotGridFieldHeaderArea, uIUnitPriceMaxPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIUnitPriceMaxPivotGridFieldHeaderIndex, uIUnitPriceMaxPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuantitySumPivotGridFieldHeaderArea, uIQuantitySumPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuantitySumPivotGridFieldHeaderIndex, uIQuantitySumPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDiscountAveragePivotGridFieldHeaderArea, uIDiscountAveragePivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDiscountAveragePivotGridFieldHeaderIndex, uIDiscountAveragePivotGridFieldHeader.Index);
		}
		public void ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModule()
		{
			#region Variable Declarations
			DXPivotGridFieldHeader uIQuarterPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIQuarterPivotGridFieldHeader;
			DXPivotGridFieldHeader uIYearPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIYearPivotGridFieldHeader;
			DXPivotGridFieldHeader uICategoryNamePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UICategoryNamePivotGridFieldHeader;
			DXPivotGridFieldHeader uIProductNamePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIProductNamePivotGridFieldHeader;
			DXPivotGridFieldHeader uIDataPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIDataPivotGridFieldHeader;
			DXPivotGridFieldHeader uIDiscountAveragePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIDiscountAveragePivotGridFieldHeader;
			#endregion
			uIQuarterPivotGridFieldHeader.FieldPositionAsString = this.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams.UIQuarterPivotGridFieldHeaderFieldPositionAsString;
			uIYearPivotGridFieldHeader.FieldPositionAsString = this.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams.UIYearPivotGridFieldHeaderFieldPositionAsString;
			uICategoryNamePivotGridFieldHeader.FieldPositionAsString = this.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams.UICategoryNamePivotGridFieldHeaderFieldPositionAsString;
			uIProductNamePivotGridFieldHeader.FieldPositionAsString = this.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams.UIProductNamePivotGridFieldHeaderFieldPositionAsString;
			uIDataPivotGridFieldHeader.FieldPositionAsString = this.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams.UIDataPivotGridFieldHeaderFieldPositionAsString;
			uIDiscountAveragePivotGridFieldHeader.FieldPositionAsString = this.ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams.UIDiscountAveragePivotGridFieldHeaderFieldPositionAsString;
		}
		public void CheckNewFieldHeadersPositionInSingleTotalModule()
		{
			#region Variable Declarations
			DXPivotGridFieldHeader uICategoryNamePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UICategoryNamePivotGridFieldHeader;
			DXPivotGridFieldHeader uIProductNamePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIProductNamePivotGridFieldHeader;
			DXPivotGridFieldHeader uIYearPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIYearPivotGridFieldHeader;
			DXPivotGridFieldHeader uIQuarterPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIQuarterPivotGridFieldHeader;
			DXPivotGridFieldHeader uIDataPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIDataPivotGridFieldHeader;
			DXPivotGridFieldHeader uIDiscountAveragePivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIDiscountAveragePivotGridFieldHeader;
			DXPivotGridFieldHeader uIUnitPriceMaxPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIUnitPriceMaxPivotGridFieldHeader;
			DXPivotGridFieldHeader uIQuantitySumPivotGridFieldHeader = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIQuantitySumPivotGridFieldHeader;
			#endregion
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UICategoryNamePivotGridFieldHeaderArea, uICategoryNamePivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UICategoryNamePivotGridFieldHeaderIndex, uICategoryNamePivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIProductNamePivotGridFieldHeaderArea, uIProductNamePivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIProductNamePivotGridFieldHeaderIndex, uIProductNamePivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIYearPivotGridFieldHeaderArea, uIYearPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIYearPivotGridFieldHeaderIndex, uIYearPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuarterPivotGridFieldHeaderArea, uIQuarterPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuarterPivotGridFieldHeaderIndex, uIQuarterPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDataPivotGridFieldHeaderArea, uIDataPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDataPivotGridFieldHeaderIndex, uIDataPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDiscountAveragePivotGridFieldHeaderArea, uIDiscountAveragePivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIDiscountAveragePivotGridFieldHeaderIndex, uIDiscountAveragePivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIUnitPriceMaxPivotGridFieldHeaderArea, uIUnitPriceMaxPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIUnitPriceMaxPivotGridFieldHeaderIndex, uIUnitPriceMaxPivotGridFieldHeader.Index);
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuantitySumPivotGridFieldHeaderArea, uIQuantitySumPivotGridFieldHeader.Area.ToString());
			Assert.AreEqual(this.CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues.UIQuantitySumPivotGridFieldHeaderIndex, uIQuantitySumPivotGridFieldHeader.Index);
		}
		public void CheckCellsValuesAfterFieldHeadersPositionChanged()
		{
			#region Variable Declarations
			DXPivotGridCell uIItem15PivotGridCell = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIItem15PivotGridCell;
			DXPivotGridCell uIItem1000PivotGridCell = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIItem1000PivotGridCell;
			DXPivotGridCell uIItem26350PivotGridCell = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid.UIItem26350PivotGridCell;
			#endregion
			Assert.AreEqual(this.CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues.UIItem15PivotGridCellValueAsString, uIItem15PivotGridCell.ValueAsString);
			Assert.AreEqual(this.CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues.UIItem1000PivotGridCellValueAsString, uIItem1000PivotGridCell.ValueAsString);
			Assert.AreEqual(this.CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues.UIItem26350PivotGridCellValueAsString, uIItem26350PivotGridCell.ValueAsString);
		}
		public void CheckRowAndColumnCountAfterFieldHeadersPositionChanged()
		{
			#region Variable Declarations
			DXPivotGrid uIPivotGridControl1PivotGrid = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid;
			#endregion
			Assert.AreEqual(this.CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues.UIPivotGridControl1PivotGridRowCount, uIPivotGridControl1PivotGrid.RowCount);
			Assert.AreEqual(this.CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues.UIPivotGridControl1PivotGridColumnCount, uIPivotGridControl1PivotGrid.ColumnCount);
		}
		public void CheckRowAndColumnCountInSingleTotalDemoModule()
		{
			#region Variable Declarations
			DXPivotGrid uIPivotGridControl1PivotGrid = this.UIXtraPivotGridFeatureWindow1.UIPanelControl1Client.UIGcContainerClient.UISingleTotalCustom.UIPivotGridControl1PivotGrid;
			#endregion
			Assert.AreEqual(this.CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues.UIPivotGridControl1PivotGridRowCount, uIPivotGridControl1PivotGrid.RowCount);
			Assert.AreEqual(this.CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues.UIPivotGridControl1PivotGridColumnCount, uIPivotGridControl1PivotGrid.ColumnCount);
		}
		public void SwitchToInPlaceEditorsDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIInplaceEditorsAccordionControlItem = this.UIXtraPivotGridFeatureWindow.UIGcNavigationsClient.UIAccordionControl1NavBar.UIEditingAccordionControlGroup.UIInplaceEditorsAccordionControlItem;
			#endregion
			Mouse.Click(uIInplaceEditorsAccordionControlItem, new Point(0, 0));
		}
		#region Properties
		public virtual CheckGrandTotalCellsValuesExpectedValues CheckGrandTotalCellsValuesExpectedValues
		{
			get
			{
				if ((this.mCheckGrandTotalCellsValuesExpectedValues == null))
				{
					this.mCheckGrandTotalCellsValuesExpectedValues = new CheckGrandTotalCellsValuesExpectedValues();
				}
				return this.mCheckGrandTotalCellsValuesExpectedValues;
			}
		}
		public virtual ExcludeConfectionsCategoryViaFieldHeaderFilteringParams ExcludeConfectionsCategoryViaFieldHeaderFilteringParams
		{
			get
			{
				if ((this.mExcludeConfectionsCategoryViaFieldHeaderFilteringParams == null))
				{
					this.mExcludeConfectionsCategoryViaFieldHeaderFilteringParams = new ExcludeConfectionsCategoryViaFieldHeaderFilteringParams();
				}
				return this.mExcludeConfectionsCategoryViaFieldHeaderFilteringParams;
			}
		}
		public virtual CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues
		{
			get
			{
				if ((this.mCheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues == null))
				{
					this.mCheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues = new CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues();
				}
				return this.mCheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues;
			}
		}
		public virtual CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues
		{
			get
			{
				if ((this.mCheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues == null))
				{
					this.mCheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues = new CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues();
				}
				return this.mCheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues;
			}
		}
		public virtual ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams
		{
			get
			{
				if ((this.mChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams == null))
				{
					this.mChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams = new ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams();
				}
				return this.mChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams;
			}
		}
		public virtual CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues
		{
			get
			{
				if ((this.mCheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues == null))
				{
					this.mCheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues = new CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues();
				}
				return this.mCheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues;
			}
		}
		public virtual CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues
		{
			get
			{
				if ((this.mCheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues == null))
				{
					this.mCheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues = new CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues();
				}
				return this.mCheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues;
			}
		}
		public virtual CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues
		{
			get
			{
				if ((this.mCheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues == null))
				{
					this.mCheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues = new CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues();
				}
				return this.mCheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues;
			}
		}
		public virtual CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues
		{
			get
			{
				if ((this.mCheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues == null))
				{
					this.mCheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues = new CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues();
				}
				return this.mCheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues;
			}
		}
		public UIXtraPivotGridFeatureWindow UIXtraPivotGridFeatureWindow
		{
			get
			{
				if ((this.mUIXtraPivotGridFeatureWindow == null))
				{
					this.mUIXtraPivotGridFeatureWindow = new UIXtraPivotGridFeatureWindow();
				}
				return this.mUIXtraPivotGridFeatureWindow;
			}
		}
		public UIItemWindow UIItemWindow
		{
			get
			{
				if ((this.mUIItemWindow == null))
				{
					this.mUIItemWindow = new UIItemWindow();
				}
				return this.mUIItemWindow;
			}
		}
		public UIXtraPivotGridFeatureWindow1 UIXtraPivotGridFeatureWindow1
		{
			get
			{
				if ((this.mUIXtraPivotGridFeatureWindow1 == null))
				{
					this.mUIXtraPivotGridFeatureWindow1 = new UIXtraPivotGridFeatureWindow1();
				}
				return this.mUIXtraPivotGridFeatureWindow1;
			}
		}
		public UIXtraPivotGridFeatureWindow2 UIXtraPivotGridFeatureWindow2
		{
			get
			{
				if ((this.mUIXtraPivotGridFeatureWindow2 == null))
				{
					this.mUIXtraPivotGridFeatureWindow2 = new UIXtraPivotGridFeatureWindow2();
				}
				return this.mUIXtraPivotGridFeatureWindow2;
			}
		}
		#endregion
		#region Fields
		private CheckGrandTotalCellsValuesExpectedValues mCheckGrandTotalCellsValuesExpectedValues;
		private ExcludeConfectionsCategoryViaFieldHeaderFilteringParams mExcludeConfectionsCategoryViaFieldHeaderFilteringParams;
		private CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues mCheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues;
		private CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues mCheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues;
		private ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams mChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams;
		private CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues mCheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues;
		private CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues mCheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues;
		private CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues mCheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues;
		private CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues mCheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues;
		private UIXtraPivotGridFeatureWindow mUIXtraPivotGridFeatureWindow;
		private UIItemWindow mUIItemWindow;
		private UIXtraPivotGridFeatureWindow1 mUIXtraPivotGridFeatureWindow1;
		private UIXtraPivotGridFeatureWindow2 mUIXtraPivotGridFeatureWindow2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckGrandTotalCellsValuesExpectedValues
	{
		#region Fields
		public string UIItem59092630PivotGridCellValueAsString = "590926.30";
		public string UIItem25007PivotGridCellValueAsString = "25007";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ExcludeConfectionsCategoryViaFieldHeaderFilteringParams
	{
		#region Fields
		public string UIFilterCheckedListBoxCheckedListBoxCheckedIndicesAsString = "1 2 4 5 6 7 8";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckGrandTotalCellsValuesAfterExcludingConfectionsCategoryExpectedValues
	{
		#region Fields
		public string UIItem51117409PivotGridCellValueAsString = "511174.09";
		public string UIItem21101PivotGridCellValueAsString = "21101";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckAllFieldHeadersPositionInSingleTotalModuleExpectedValues
	{
		#region Fields
		public string UIYearPivotGridFieldHeaderArea = "ColumnArea";
		public int UIYearPivotGridFieldHeaderIndex = 0;
		public string UIQuarterPivotGridFieldHeaderArea = "ColumnArea";
		public int UIQuarterPivotGridFieldHeaderIndex = 1;
		public string UIDataPivotGridFieldHeaderArea = "ColumnArea";
		public int UIDataPivotGridFieldHeaderIndex = 2;
		public string UICategoryNamePivotGridFieldHeaderArea = "RowArea";
		public int UICategoryNamePivotGridFieldHeaderIndex = 0;
		public string UIProductNamePivotGridFieldHeaderArea = "RowArea";
		public int UIProductNamePivotGridFieldHeaderIndex = 1;
		public string UIUnitPriceMaxPivotGridFieldHeaderArea = "DataArea";
		public int UIUnitPriceMaxPivotGridFieldHeaderIndex = 0;
		public string UIQuantitySumPivotGridFieldHeaderArea = "DataArea";
		public int UIQuantitySumPivotGridFieldHeaderIndex = 1;
		public string UIDiscountAveragePivotGridFieldHeaderArea = "DataArea";
		public int UIDiscountAveragePivotGridFieldHeaderIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeFieldHeadersPositionViaDraggingInSingleTotalDemoModuleParams
	{
		#region Fields
		public string UIQuarterPivotGridFieldHeaderFieldPositionAsString = "[Area]RowArea[Index]1";
		public string UIYearPivotGridFieldHeaderFieldPositionAsString = "[Area]RowArea[Index]0";
		public string UICategoryNamePivotGridFieldHeaderFieldPositionAsString = "[Area]ColumnArea[Index]0";
		public string UIProductNamePivotGridFieldHeaderFieldPositionAsString = "[Area]ColumnArea[Index]1";
		public string UIDataPivotGridFieldHeaderFieldPositionAsString = "[Area]RowArea[Index]2";
		public string UIDiscountAveragePivotGridFieldHeaderFieldPositionAsString = "[Area]DataArea[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckNewFieldHeadersPositionInSingleTotalModuleExpectedValues
	{
		#region Fields
		public string UICategoryNamePivotGridFieldHeaderArea = "ColumnArea";
		public int UICategoryNamePivotGridFieldHeaderIndex = 0;
		public string UIProductNamePivotGridFieldHeaderArea = "ColumnArea";
		public int UIProductNamePivotGridFieldHeaderIndex = 1;
		public string UIYearPivotGridFieldHeaderArea = "RowArea";
		public int UIYearPivotGridFieldHeaderIndex = 0;
		public string UIQuarterPivotGridFieldHeaderArea = "RowArea";
		public int UIQuarterPivotGridFieldHeaderIndex = 1;
		public string UIDataPivotGridFieldHeaderArea = "RowArea";
		public int UIDataPivotGridFieldHeaderIndex = 2;
		public string UIDiscountAveragePivotGridFieldHeaderArea = "DataArea";
		public int UIDiscountAveragePivotGridFieldHeaderIndex = 0;
		public string UIUnitPriceMaxPivotGridFieldHeaderArea = "DataArea";
		public int UIUnitPriceMaxPivotGridFieldHeaderIndex = 1;
		public string UIQuantitySumPivotGridFieldHeaderArea = "DataArea";
		public int UIQuantitySumPivotGridFieldHeaderIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckCellsValuesAfterFieldHeadersPositionChangedExpectedValues
	{
		#region Fields
		public string UIItem15PivotGridCellValueAsString = "15";
		public string UIItem1000PivotGridCellValueAsString = "0.1";
		public string UIItem26350PivotGridCellValueAsString = "263.5";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckRowAndColumnCountAfterFieldHeadersPositionChangedExpectedValues
	{
		#region Fields
		public int UIPivotGridControl1PivotGridRowCount = 15;
		public int UIPivotGridControl1PivotGridColumnCount = 26;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckRowAndColumnCountInSingleTotalDemoModuleExpectedValues
	{
		#region Fields
		public int UIPivotGridControl1PivotGridRowCount = 27;
		public int UIPivotGridControl1PivotGridColumnCount = 15;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraPivotGridFeatureWindow : DXWindow
	{
		public UIXtraPivotGridFeatureWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "XtraPivotGrid Features Demo (CS code)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
			#endregion
		}
		#region Properties
		public UIGcNavigationsClient UIGcNavigationsClient
		{
			get
			{
				if ((this.mUIGcNavigationsClient == null))
				{
					this.mUIGcNavigationsClient = new UIGcNavigationsClient(this);
				}
				return this.mUIGcNavigationsClient;
			}
		}
		public UIPanelControl1Client UIPanelControl1Client
		{
			get
			{
				if ((this.mUIPanelControl1Client == null))
				{
					this.mUIPanelControl1Client = new UIPanelControl1Client(this);
				}
				return this.mUIPanelControl1Client;
			}
		}
		#endregion
		#region Fields
		private UIGcNavigationsClient mUIGcNavigationsClient;
		private UIPanelControl1Client mUIPanelControl1Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIGcNavigationsClient : DXTestControl
	{
		public UIGcNavigationsClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcNavigations";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
			#endregion
		}
		#region Properties
		public UIAccordionControl1NavBar UIAccordionControl1NavBar
		{
			get
			{
				if ((this.mUIAccordionControl1NavBar == null))
				{
					this.mUIAccordionControl1NavBar = new UIAccordionControl1NavBar(this);
				}
				return this.mUIAccordionControl1NavBar;
			}
		}
		#endregion
		#region Fields
		private UIAccordionControl1NavBar mUIAccordionControl1NavBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIAccordionControl1NavBar : DXTestControl
	{
		public UIAccordionControl1NavBar(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "accordionControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
			#endregion
		}
		#region Properties
		public UISummaryAccordionControlGroup UISummaryAccordionControlGroup
		{
			get
			{
				if ((this.mUISummaryAccordionControlGroup == null))
				{
					this.mUISummaryAccordionControlGroup = new UISummaryAccordionControlGroup(this);
				}
				return this.mUISummaryAccordionControlGroup;
			}
		}
		public UIEditingAccordionControlGroup UIEditingAccordionControlGroup
		{
			get
			{
				if ((this.mUIEditingAccordionControlGroup == null))
				{
					this.mUIEditingAccordionControlGroup = new UIEditingAccordionControlGroup(this);
				}
				return this.mUIEditingAccordionControlGroup;
			}
		}
		#endregion
		#region Fields
		private UISummaryAccordionControlGroup mUISummaryAccordionControlGroup;
		private UIEditingAccordionControlGroup mUIEditingAccordionControlGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UISummaryAccordionControlGroup : DXTestControl
	{
		public UISummaryAccordionControlGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Summary";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIMultipleTotalsAccordionControlItem
		{
			get
			{
				if ((this.mUIMultipleTotalsAccordionControlItem == null))
				{
					this.mUIMultipleTotalsAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUIMultipleTotalsAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Multiple Totals";
					this.mUIMultipleTotalsAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUIMultipleTotalsAccordionControlItem.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
					#endregion
				}
				return this.mUIMultipleTotalsAccordionControlItem;
			}
		}
		public DXTestControl UISingleTotalAccordionControlItem
		{
			get
			{
				if ((this.mUISingleTotalAccordionControlItem == null))
				{
					this.mUISingleTotalAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUISingleTotalAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Single Total";
					this.mUISingleTotalAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUISingleTotalAccordionControlItem.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
					#endregion
				}
				return this.mUISingleTotalAccordionControlItem;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIMultipleTotalsAccordionControlItem;
		private DXTestControl mUISingleTotalAccordionControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIEditingAccordionControlGroup : DXTestControl
	{
		public UIEditingAccordionControlGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Editing";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIInplaceEditorsAccordionControlItem
		{
			get
			{
				if ((this.mUIInplaceEditorsAccordionControlItem == null))
				{
					this.mUIInplaceEditorsAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUIInplaceEditorsAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "In-place Editors";
					this.mUIInplaceEditorsAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUIInplaceEditorsAccordionControlItem.WindowTitles.Add("XtraPivotGrid Features Demo (CS code)");
					#endregion
				}
				return this.mUIInplaceEditorsAccordionControlItem;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIInplaceEditorsAccordionControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControl1Client : DXTestControl
	{
		public UIPanelControl1Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
			#endregion
		}
		#region Properties
		public UIGcContainerClient UIGcContainerClient
		{
			get
			{
				if ((this.mUIGcContainerClient == null))
				{
					this.mUIGcContainerClient = new UIGcContainerClient(this);
				}
				return this.mUIGcContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIGcContainerClient mUIGcContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIGcContainerClient : DXTestControl
	{
		public UIGcContainerClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
			#endregion
		}
		#region Properties
		public UIMultipleTotalsCustom UIMultipleTotalsCustom
		{
			get
			{
				if ((this.mUIMultipleTotalsCustom == null))
				{
					this.mUIMultipleTotalsCustom = new UIMultipleTotalsCustom(this);
				}
				return this.mUIMultipleTotalsCustom;
			}
		}
		#endregion
		#region Fields
		private UIMultipleTotalsCustom mUIMultipleTotalsCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMultipleTotalsCustom : DXTestControl
	{
		public UIMultipleTotalsCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MultipleTotals";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MultipleTotals";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
			#endregion
		}
		#region Properties
		public UIPivotGridControl1PivotGrid UIPivotGridControl1PivotGrid
		{
			get
			{
				if ((this.mUIPivotGridControl1PivotGrid == null))
				{
					this.mUIPivotGridControl1PivotGrid = new UIPivotGridControl1PivotGrid(this);
				}
				return this.mUIPivotGridControl1PivotGrid;
			}
		}
		#endregion
		#region Fields
		private UIPivotGridControl1PivotGrid mUIPivotGridControl1PivotGrid;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPivotGridControl1PivotGrid : DXPivotGrid
	{
		public UIPivotGridControl1PivotGrid(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pivotGridControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
			#endregion
		}
		#region Properties
		public DXPivotGridCell UIItem59092630PivotGridCell
		{
			get
			{
				if ((this.mUIItem59092630PivotGridCell == null))
				{
					this.mUIItem59092630PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem59092630PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]9[Row]117";
					this.mUIItem59092630PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem59092630PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
					#endregion
				}
				return this.mUIItem59092630PivotGridCell;
			}
		}
		public DXPivotGridCell UIItem25007PivotGridCell
		{
			get
			{
				if ((this.mUIItem25007PivotGridCell == null))
				{
					this.mUIItem25007PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem25007PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]8[Row]117";
					this.mUIItem25007PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem25007PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
					#endregion
				}
				return this.mUIItem25007PivotGridCell;
			}
		}
		public UICategoryNamePivotGridFieldHeader UICategoryNamePivotGridFieldHeader
		{
			get
			{
				if ((this.mUICategoryNamePivotGridFieldHeader == null))
				{
					this.mUICategoryNamePivotGridFieldHeader = new UICategoryNamePivotGridFieldHeader(this);
				}
				return this.mUICategoryNamePivotGridFieldHeader;
			}
		}
		public DXPivotGridCell UIItem51117409PivotGridCell
		{
			get
			{
				if ((this.mUIItem51117409PivotGridCell == null))
				{
					this.mUIItem51117409PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem51117409PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]9[Row]99";
					this.mUIItem51117409PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem51117409PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
					#endregion
				}
				return this.mUIItem51117409PivotGridCell;
			}
		}
		public DXPivotGridCell UIItem21101PivotGridCell
		{
			get
			{
				if ((this.mUIItem21101PivotGridCell == null))
				{
					this.mUIItem21101PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem21101PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]8[Row]99";
					this.mUIItem21101PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem21101PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
					#endregion
				}
				return this.mUIItem21101PivotGridCell;
			}
		}
		#endregion
		#region Fields
		private DXPivotGridCell mUIItem59092630PivotGridCell;
		private DXPivotGridCell mUIItem25007PivotGridCell;
		private UICategoryNamePivotGridFieldHeader mUICategoryNamePivotGridFieldHeader;
		private DXPivotGridCell mUIItem51117409PivotGridCell;
		private DXPivotGridCell mUIItem21101PivotGridCell;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UICategoryNamePivotGridFieldHeader : DXPivotGridFieldHeader
	{
		public UICategoryNamePivotGridFieldHeader(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "CategoryName";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
			#endregion
		}
		#region Properties
		public DXTestControl UICategoryNameCustom
		{
			get
			{
				if ((this.mUICategoryNameCustom == null))
				{
					this.mUICategoryNameCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUICategoryNameCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "CategoryName";
					this.mUICategoryNameCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeaderFilterButton";
					this.mUICategoryNameCustom.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Multiple Totals");
					#endregion
				}
				return this.mUICategoryNameCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUICategoryNameCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow : WinWindow
	{
		public UIItemWindow()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Desktop";
			this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
			#endregion
		}
		#region Properties
		public UIPivotFilterPopupContCustom UIPivotFilterPopupContCustom
		{
			get
			{
				if ((this.mUIPivotFilterPopupContCustom == null))
				{
					this.mUIPivotFilterPopupContCustom = new UIPivotFilterPopupContCustom(this);
				}
				return this.mUIPivotFilterPopupContCustom;
			}
		}
		public UIPivotFilterPopupContCustom1 UIPivotFilterPopupContCustom1
		{
			get
			{
				if ((this.mUIPivotFilterPopupContCustom1 == null))
				{
					this.mUIPivotFilterPopupContCustom1 = new UIPivotFilterPopupContCustom1(this);
				}
				return this.mUIPivotFilterPopupContCustom1;
			}
		}
		#endregion
		#region Fields
		private UIPivotFilterPopupContCustom mUIPivotFilterPopupContCustom;
		private UIPivotFilterPopupContCustom1 mUIPivotFilterPopupContCustom1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPivotFilterPopupContCustom : DXTestControl
	{
		public UIPivotFilterPopupContCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownPivotFilterPopupContainerForm";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotFilterPopupContainerForm";
			#endregion
		}
		#region Properties
		public DXCheckedListBox UIFilterCheckedListBoxCheckedListBox
		{
			get
			{
				if ((this.mUIFilterCheckedListBoxCheckedListBox == null))
				{
					this.mUIFilterCheckedListBoxCheckedListBox = new DXCheckedListBox(this);
					#region Search Criteria
					this.mUIFilterCheckedListBoxCheckedListBox.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownPivotFilterPopupContainerFormFilterCheckedListBoxControl[0]";
					this.mUIFilterCheckedListBoxCheckedListBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FilterCheckedListBoxControl";
					#endregion
				}
				return this.mUIFilterCheckedListBoxCheckedListBox;
			}
		}
		#endregion
		#region Fields
		private DXCheckedListBox mUIFilterCheckedListBoxCheckedListBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPivotFilterPopupContCustom1 : DXTestControl
	{
		public UIPivotFilterPopupContCustom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownPivotFilterPopupContainerForm";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotFilterPopupContainerForm";
			#endregion
		}
		#region Properties
		public DXButton UISimpleButtonButton
		{
			get
			{
				if ((this.mUISimpleButtonButton == null))
				{
					this.mUISimpleButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownPivotFilterPopupContainerFormSimpleButton[0]";
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					#endregion
				}
				return this.mUISimpleButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISimpleButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraPivotGridFeatureWindow1 : DXWindow
	{
		public UIXtraPivotGridFeatureWindow1()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "XtraPivotGrid Features Demo (CS code) - Single Total";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
			#endregion
		}
		#region Properties
		public UIPanelControl1Client1 UIPanelControl1Client
		{
			get
			{
				if ((this.mUIPanelControl1Client == null))
				{
					this.mUIPanelControl1Client = new UIPanelControl1Client1(this);
				}
				return this.mUIPanelControl1Client;
			}
		}
		#endregion
		#region Fields
		private UIPanelControl1Client1 mUIPanelControl1Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControl1Client1 : DXTestControl
	{
		public UIPanelControl1Client1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
			#endregion
		}
		#region Properties
		public UIGcContainerClient1 UIGcContainerClient
		{
			get
			{
				if ((this.mUIGcContainerClient == null))
				{
					this.mUIGcContainerClient = new UIGcContainerClient1(this);
				}
				return this.mUIGcContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIGcContainerClient1 mUIGcContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIGcContainerClient1 : DXTestControl
	{
		public UIGcContainerClient1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
			#endregion
		}
		#region Properties
		public UISingleTotalCustom UISingleTotalCustom
		{
			get
			{
				if ((this.mUISingleTotalCustom == null))
				{
					this.mUISingleTotalCustom = new UISingleTotalCustom(this);
				}
				return this.mUISingleTotalCustom;
			}
		}
		#endregion
		#region Fields
		private UISingleTotalCustom mUISingleTotalCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UISingleTotalCustom : DXTestControl
	{
		public UISingleTotalCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SingleTotal";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SingleTotal";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
			#endregion
		}
		#region Properties
		public UIPivotGridControl1PivotGrid1 UIPivotGridControl1PivotGrid
		{
			get
			{
				if ((this.mUIPivotGridControl1PivotGrid == null))
				{
					this.mUIPivotGridControl1PivotGrid = new UIPivotGridControl1PivotGrid1(this);
				}
				return this.mUIPivotGridControl1PivotGrid;
			}
		}
		#endregion
		#region Fields
		private UIPivotGridControl1PivotGrid1 mUIPivotGridControl1PivotGrid;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPivotGridControl1PivotGrid1 : DXPivotGrid
	{
		public UIPivotGridControl1PivotGrid1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pivotGridControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
			#endregion
		}
		#region Properties
		public DXPivotGridFieldHeader UIYearPivotGridFieldHeader
		{
			get
			{
				if ((this.mUIYearPivotGridFieldHeader == null))
				{
					this.mUIYearPivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIYearPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "fieldYear";
					this.mUIYearPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIYearPivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIYearPivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UIQuarterPivotGridFieldHeader
		{
			get
			{
				if ((this.mUIQuarterPivotGridFieldHeader == null))
				{
					this.mUIQuarterPivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIQuarterPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "fieldQuarter";
					this.mUIQuarterPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIQuarterPivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIQuarterPivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UIDataPivotGridFieldHeader
		{
			get
			{
				if ((this.mUIDataPivotGridFieldHeader == null))
				{
					this.mUIDataPivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIDataPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "pivot$dataField$";
					this.mUIDataPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIDataPivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIDataPivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UICategoryNamePivotGridFieldHeader
		{
			get
			{
				if ((this.mUICategoryNamePivotGridFieldHeader == null))
				{
					this.mUICategoryNamePivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUICategoryNamePivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "CategoryName";
					this.mUICategoryNamePivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUICategoryNamePivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUICategoryNamePivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UIProductNamePivotGridFieldHeader
		{
			get
			{
				if ((this.mUIProductNamePivotGridFieldHeader == null))
				{
					this.mUIProductNamePivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIProductNamePivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "ProductName";
					this.mUIProductNamePivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIProductNamePivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIProductNamePivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UIUnitPriceMaxPivotGridFieldHeader
		{
			get
			{
				if ((this.mUIUnitPriceMaxPivotGridFieldHeader == null))
				{
					this.mUIUnitPriceMaxPivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIUnitPriceMaxPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "UnitPrice";
					this.mUIUnitPriceMaxPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIUnitPriceMaxPivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIUnitPriceMaxPivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UIQuantitySumPivotGridFieldHeader
		{
			get
			{
				if ((this.mUIQuantitySumPivotGridFieldHeader == null))
				{
					this.mUIQuantitySumPivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIQuantitySumPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "Quantity";
					this.mUIQuantitySumPivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIQuantitySumPivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIQuantitySumPivotGridFieldHeader;
			}
		}
		public DXPivotGridFieldHeader UIDiscountAveragePivotGridFieldHeader
		{
			get
			{
				if ((this.mUIDiscountAveragePivotGridFieldHeader == null))
				{
					this.mUIDiscountAveragePivotGridFieldHeader = new DXPivotGridFieldHeader(this);
					#region Search Criteria
					this.mUIDiscountAveragePivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "Discount";
					this.mUIDiscountAveragePivotGridFieldHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridFieldHeader";
					this.mUIDiscountAveragePivotGridFieldHeader.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIDiscountAveragePivotGridFieldHeader;
			}
		}
		public DXPivotGridCell UIItem15PivotGridCell
		{
			get
			{
				if ((this.mUIItem15PivotGridCell == null))
				{
					this.mUIItem15PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem15PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]3[Row]8";
					this.mUIItem15PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem15PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIItem15PivotGridCell;
			}
		}
		public DXPivotGridCell UIItem1000PivotGridCell
		{
			get
			{
				if ((this.mUIItem1000PivotGridCell == null))
				{
					this.mUIItem1000PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem1000PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]3[Row]9";
					this.mUIItem1000PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem1000PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIItem1000PivotGridCell;
			}
		}
		public DXPivotGridCell UIItem26350PivotGridCell
		{
			get
			{
				if ((this.mUIItem26350PivotGridCell == null))
				{
					this.mUIItem26350PivotGridCell = new DXPivotGridCell(this);
					#region Search Criteria
					this.mUIItem26350PivotGridCell.SearchProperties[DXTestControl.PropertyNames.Name] = "[Column]3[Row]7";
					this.mUIItem26350PivotGridCell.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridCell";
					this.mUIItem26350PivotGridCell.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - Single Total");
					#endregion
				}
				return this.mUIItem26350PivotGridCell;
			}
		}
		#endregion
		#region Fields
		private DXPivotGridFieldHeader mUIYearPivotGridFieldHeader;
		private DXPivotGridFieldHeader mUIQuarterPivotGridFieldHeader;
		private DXPivotGridFieldHeader mUIDataPivotGridFieldHeader;
		private DXPivotGridFieldHeader mUICategoryNamePivotGridFieldHeader;
		private DXPivotGridFieldHeader mUIProductNamePivotGridFieldHeader;
		private DXPivotGridFieldHeader mUIUnitPriceMaxPivotGridFieldHeader;
		private DXPivotGridFieldHeader mUIQuantitySumPivotGridFieldHeader;
		private DXPivotGridFieldHeader mUIDiscountAveragePivotGridFieldHeader;
		private DXPivotGridCell mUIItem15PivotGridCell;
		private DXPivotGridCell mUIItem1000PivotGridCell;
		private DXPivotGridCell mUIItem26350PivotGridCell;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraPivotGridFeatureWindow2 : DXWindow
	{
		public UIXtraPivotGridFeatureWindow2()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "XtraPivotGrid Features Demo (CS code) - In-place Editors";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - In-place Editors");
			#endregion
		}
		#region Properties
		public UIPanelControl1Client2 UIPanelControl1Client
		{
			get
			{
				if ((this.mUIPanelControl1Client == null))
				{
					this.mUIPanelControl1Client = new UIPanelControl1Client2(this);
				}
				return this.mUIPanelControl1Client;
			}
		}
		#endregion
		#region Fields
		private UIPanelControl1Client2 mUIPanelControl1Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControl1Client2 : DXTestControl
	{
		public UIPanelControl1Client2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - In-place Editors");
			#endregion
		}
		#region Properties
		public UIGcContainerClient2 UIGcContainerClient
		{
			get
			{
				if ((this.mUIGcContainerClient == null))
				{
					this.mUIGcContainerClient = new UIGcContainerClient2(this);
				}
				return this.mUIGcContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIGcContainerClient2 mUIGcContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIGcContainerClient2 : DXTestControl
	{
		public UIGcContainerClient2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - In-place Editors");
			#endregion
		}
		#region Properties
		public UIInplaceEditorsCustom UIInplaceEditorsCustom
		{
			get
			{
				if ((this.mUIInplaceEditorsCustom == null))
				{
					this.mUIInplaceEditorsCustom = new UIInplaceEditorsCustom(this);
				}
				return this.mUIInplaceEditorsCustom;
			}
		}
		#endregion
		#region Fields
		private UIInplaceEditorsCustom mUIInplaceEditorsCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIInplaceEditorsCustom : DXTestControl
	{
		public UIInplaceEditorsCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "InplaceEditors";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "InplaceEditors";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - In-place Editors");
			#endregion
		}
		#region Properties
		public UIMainPanelClient UIMainPanelClient
		{
			get
			{
				if ((this.mUIMainPanelClient == null))
				{
					this.mUIMainPanelClient = new UIMainPanelClient(this);
				}
				return this.mUIMainPanelClient;
			}
		}
		#endregion
		#region Fields
		private UIMainPanelClient mUIMainPanelClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMainPanelClient : DXTestControl
	{
		public UIMainPanelClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "mainPanel";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - In-place Editors");
			#endregion
		}
		#region Properties
		public DXPivotGrid UIPivotGridControlPivotGrid
		{
			get
			{
				if ((this.mUIPivotGridControlPivotGrid == null))
				{
					this.mUIPivotGridControlPivotGrid = new DXPivotGrid(this);
					#region Search Criteria
					this.mUIPivotGridControlPivotGrid.SearchProperties[DXTestControl.PropertyNames.Name] = "pivotGridControl";
					this.mUIPivotGridControlPivotGrid.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PivotGridControl";
					this.mUIPivotGridControlPivotGrid.WindowTitles.Add("XtraPivotGrid Features Demo (CS code) - In-place Editors");
					#endregion
				}
				return this.mUIPivotGridControlPivotGrid;
			}
		}
		#endregion
		#region Fields
		private DXPivotGrid mUIPivotGridControlPivotGrid;
		#endregion
	}
}
