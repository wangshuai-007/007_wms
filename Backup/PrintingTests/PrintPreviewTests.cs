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
using System.Globalization;
using System.ComponentModel;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class PrintPreviewTests {
		public PrintPreviewTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SearchInPrintPreviewViaSearchBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.SearchInPrintPreviewViaSearchBar();
				this.UIMap.ClickFoundBrick();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SearchInPrintPreviewViaCtrlFShortcutTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.SearchBrickViaCtrlFShortcut();
				this.UIMap.ClickFoundBrick();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ScrollPrintPreviewViaVScrollBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ScrollPrintPreviewViaVScrollBar();
				this.UIMap.CheckVerticalScrollingViaBrickClick();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ScrollPrintPreviewViaHScrollBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeToWiderTableForPopulatingDataGrid();
				this.UIMap.ClickPrintPreviewZoomInBarCommand();
				this.UIMap.ScrollPrintPreviewViaHScrollBar();
				this.UIMap.CheckHorizontalScrollingViaBrickClick();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ScrollPrintPreviewViaHandToolTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ScrollPrintPreviewViaHandTool();
				this.UIMap.CheckVerticalScrollingViaBrickClick();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void HeaderBricksTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.MakeHeaderBrickSettings();
				this.UIMap.CheckHeaderBrickSettings();
				this.UIMap.ClickHeaderAndFooterFormOkButton();
				this.UIMap.CheckAddedHeaderBricksText();
				this.UIMap.ClickAddedHeaderBricks();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void FooterBricksTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.MakeFooterBrickSettings();
				this.UIMap.CheckFooterBrickSettings();
				this.UIMap.MakeFooterBrickFontSettings();
				DXMenuEditItem uIBarEditItemLink0BarEditItem = UIMap.UIHeaderandFooterWindow.UIBarDockControlCustom.UICustom1MenuBar.UIBarEditItemLink0BarEditItem;
				Assert.IsTrue((String)uIBarEditItemLink0BarEditItem.GetProperty("ValueAsString") == "Tahoma; 8,25pt" || (String)uIBarEditItemLink0BarEditItem.GetProperty("ValueAsString") == "Tahoma, 8.25pt");
				this.UIMap.ClickHeaderAndFooterFormOkButton();
				this.UIMap.CheckAddedFooterBricksText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewScaleBySpecifyingPercentageBoxTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangePrintPreviewScaleBySpecifyingPercentageBox();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width > oldSizeBrick.Width && newSizeBrick.Height > oldSizeBrick.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewScaleViaFitToPagesBoxTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangePrintPreviewScaleViaFitToPagesBox();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width > oldSizeBrick.Width && newSizeBrick.Height > oldSizeBrick.Height);
				this.UIMap.ChangeRightMarginValue();
				this.UIMap.CheckConservationOfQuantityPages();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeTableToPopulateDataGridTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTableToPopulateDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.CheckChangedTableBrickText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeDataGridColumnsWidthTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices01PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices01PrintControlBrick;
				DXPrintingBrick uIPage0BrickIndices03PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices03PrintControlBrick;
				Size oldSizePage0BrickIndices01 = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices01PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Size oldSizePage0BrickIndices03 = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices03PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangeDataGridColumnsWidth();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				Size newSizePage0BrickIndices01 = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices01PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Size newSizePage0BrickIndices03 = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices03PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizePage0BrickIndices01.Width < oldSizePage0BrickIndices01.Width && newSizePage0BrickIndices03.Width > oldSizePage0BrickIndices03.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void PrintPreviewNextPageBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTableToPopulateDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.ClickNextPageBar();
				this.UIMap.CheckSwitchToNextPageViaBrickClick();
				this.UIMap.CheckSwitchToNextPageViaStatusBarInfo();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void PrintPreviewLastPageBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTableToPopulateDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.ClickLastPageBar();
				this.UIMap.CheckSwitchToLastPageViaBrickClick();
				this.UIMap.CheckSwitchToLastPageViaStatusBarInfo();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void PrintPreviewFirstPageBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTableToPopulateDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.ClickNextPageBar();
				this.UIMap.ClickFirstPageBar();
				this.UIMap.CheckSwitchToFirstPageViaBrickClick();
				this.UIMap.CheckSwitchToFirstPageViaStatusBarInfo();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void PrintPreviewPreviousPageBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTableToPopulateDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.ClickNextPageBar();
				this.UIMap.ClickPreviousPageBar();
				this.UIMap.CheckSwitchToFirstPageViaBrickClick();
				this.UIMap.CheckSwitchToFirstPageViaStatusBarInfo();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewZoomViaZoomInBarCommandTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ClickPrintPreviewZoomInBarCommand();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width > oldSizeBrick.Width && newSizeBrick.Height > oldSizeBrick.Height);
				this.UIMap.CheckZoomValueAfterZoomIn();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewZoomViaTypingInZoomBoxTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangePrintPreviewZoomBarValueViaTyping();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width > oldSizeBrick.Width && newSizeBrick.Height > oldSizeBrick.Height);
				this.UIMap.CheckZoomValueAfterZoomIn();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewZoomViaZoomDropDownListTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangePrintPreviewZoomViaZoomDropDownList();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width > oldSizeBrick.Width && newSizeBrick.Height > oldSizeBrick.Height);
				this.UIMap.CheckZoomValueAfterZoomIn();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewZoomViaPageWidthDropDownListTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				int requiredWindowWidth = 800;
				int currentWindowWidth = this.UIMap.UIXtraPrintingFeaturesWindow12.BoundingRectangle.Width;
				DXTestControl sizeGrip = this.UIMap.UIXtraPrintingFeaturesWindow12.UIRibbonStatusBarMenuBar.UISizeGripCustom;
				Mouse.StartDragging(sizeGrip);
				Mouse.StopDragging(requiredWindowWidth - currentWindowWidth, 0);
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				DXMenuItem uIZoomBarEditItem = UIMap.UIXtraPrintingFeaturesWindow12.UIRibbonStatusBarMenuBar.UIItem150BarItem;
				string oldValueAsStringZoomBarEditItem = (string)uIZoomBarEditItem.GetProperty("Text");
				int oldValueZoomBarEditItem = Int32.Parse(oldValueAsStringZoomBarEditItem.Substring(0, oldValueAsStringZoomBarEditItem.Length - 1));
				this.UIMap.ChangePrintPreviewZoomViaPageWidthDropDownList();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				string newValueAsStringZoomBarEditItem = (string)uIZoomBarEditItem.GetProperty("Text");
				int newValueZoomBarEditItem = Int32.Parse(newValueAsStringZoomBarEditItem.Substring(0, newValueAsStringZoomBarEditItem.Length - 1));
				Assert.IsTrue(newSizeBrick.Width < oldSizeBrick.Width && newSizeBrick.Height < oldSizeBrick.Height);
				Assert.IsTrue(newValueZoomBarEditItem < oldValueZoomBarEditItem);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewZoomViaZoomOutBarCommandTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangePrintPreviewZoomViaZoomOutBarCommand();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width < oldSizeBrick.Width && newSizeBrick.Height < oldSizeBrick.Height);
				this.UIMap.CheckZoomBarValueAfterZoomOut();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeZoomInStatusBarViaMouseTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangeZoomInStatusBarViaMouse();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width < oldSizeBrick.Width && newSizeBrick.Height < oldSizeBrick.Height);
				this.UIMap.CheckStatusBarZoomBarValueAfterChangingViaMouse();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeZoomInStatusBarViaPlusButtonTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXPrintingBrick uIPage0BrickIndices06PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow1.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangeZoomInStatusBarViaPlusButton();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices06PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Width > oldSizeBrick.Width && newSizeBrick.Height > oldSizeBrick.Height);
				this.UIMap.CheckStatusBarZoomBarValueAfterChangingViaPlusButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void PrintPreviewMagnifierToolFitWholePageTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXMenuItem zoomBar = UIMap.UIXtraPrintingFeaturesWindow12.UIRibbonStatusBarMenuBar.UIItem150BarItem;
				string oldZoomTextValue = (string)zoomBar.GetProperty("Text");
				int oldZoomValue = Int32.Parse(oldZoomTextValue.Substring(0, oldZoomTextValue.Length - 1));
				this.UIMap.ClickMagnifierBarCommandToFitWholePage();
				string newZoomTextValue = (string)zoomBar.GetProperty("Text");
				int newZoomValue = Int32.Parse(newZoomTextValue.Substring(0, newZoomTextValue.Length - 1));
				Assert.IsTrue(newZoomValue < oldZoomValue);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void PrintPreviewMagnifierToolTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				DXMenuItem zoomBar = UIMap.UIXtraPrintingFeaturesWindow12.UIRibbonStatusBarMenuBar.UIItem150BarItem;
				string oldZoomTextValue = (string)zoomBar.GetProperty("Text");
				int oldZoomValue = Int32.Parse(oldZoomTextValue.Substring(0, oldZoomTextValue.Length - 1));
				this.UIMap.ClickMagnifierBarCommandToFitWholePage();
				this.UIMap.ClickMagnifierBarCommandToNormalSizeView();
				string newZoomTextValue = (string)zoomBar.GetProperty("Text");
				int newZoomValue = Int32.Parse(newZoomTextValue.Substring(0, newZoomTextValue.Length - 1));
				Assert.IsTrue(newZoomValue == oldZoomValue);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeMultiplePagesBarItemValueTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTableToPopulateDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.ChangeMultiplePagesBarItemValue();
				this.UIMap.CheckChangedMultiplePagesBarItemValueViaBrickClick();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeStatusBarInfoTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeToWiderTableForPopulatingDataGrid();
				this.UIMap.ClickRefreshPreviewButtonInDataGridDemoModule();
				this.UIMap.CheckStatusBarInfoBeforeChangingMargin();
				this.UIMap.ChangeStatusBarInfoViaChangingLeftMarginValue();
				this.UIMap.CheckStatusBarInfoAfterChangingMargin();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeLeftMarginTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeLeftMarginValue();
				this.UIMap.CheckChangedLeftMarginValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeRightMarginTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeRightMarginValue();
				this.UIMap.CheckChangedRightMarginValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeTopMarginTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeTopMarginValue();
				this.UIMap.CheckChangedTopMarginValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeBottomMarginTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ChangeBottomMarginValue();
				this.UIMap.CheckChangedBottomMarginValue();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CreateWatermarkAndCustomizeOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickWaterMarkBarItem();
				this.UIMap.CreateWaterMarkAndCustomizeOptions();
				this.UIMap.CheckCustomizedWatermarkOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CustomizePDFSpecificExportOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickExportDocumentBar();
				this.UIMap.CustomizePDFSpecificExportOptions();
				this.UIMap.CustomizePDFPasswordSecurityOptions();
				this.UIMap.CheckCustomizedPasswordSecurityOptions();
				this.UIMap.ClickCancelButtonInPasswordSecurityForm();
				this.UIMap.CheckCustomizedPDFSpecificExportOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CustomizeHTMLSpecificExportOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickExportDocumentHTMLItem();
				this.UIMap.CustomizeHTMLSpecificExportOptions();
				this.UIMap.CheckCustomizedHTMLSpecificExportOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CustomizeRTFSpecificExportOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickExportDocumentRTFItem();
				this.UIMap.CustomizeRTFSpecificExportOptions();
				this.UIMap.CheckCustomizedRTFSpecificExportOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CustomizeXLSSpecificExportOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickExportDocumentXLSItem();
				this.UIMap.CustomizeXLSSpecificExportOptions();
				this.UIMap.CheckCustomizedXLSSpecificExportOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CustomizeCSVSpecificExportOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickExportDocumentCSVItem();
				this.UIMap.CustomizeCSVSpecificExportOptions();
				this.UIMap.CheckCustomizedCSVSpecificExportOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CustomizeImageSpecificExportOptionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.ClickExportDocumentImageItem();
				this.UIMap.CustomizeImageSpecificExportOptions();
				this.UIMap.CheckCustomizedImageSpecificExportOptions();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectLargeIconListViewTypeTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToListViewDemoModule();
				this.UIMap.SelectLargeIconViewTypeInListViewDemoModule();
				this.UIMap.CheckChangedListViewTypeViaCheckingBrickText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectSmallIconListViewTypeTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToListViewDemoModule();
				this.UIMap.SelectSmallIconViewTypeInListViewDemoModule();
				this.UIMap.CheckChangedListViewTypeViaCheckingBrickText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectListViewTypeTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToListViewDemoModule();
				this.UIMap.SelectListViewTypeInListViewDemoModule();
				this.UIMap.CheckChangedListViewTypeViaCheckingBrickText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeRichTextBoxValueTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToRichTextBoxDemoModule();
				this.UIMap.ChangeRichTextBoxValueForChangingPrintPreview();
				this.UIMap.ClickRefreshPreviewButtonInRichTextBoxDemoModule();
				this.UIMap.CheckChangedRichTextBoxValueViaCheckingBrickText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeDataViaNavigationBarNextButtonTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				this.UIMap.OpenNavigationBarPanel();
				this.UIMap.FindDataForChangingPrintPreviewViaNextButton();
				this.UIMap.ChangeDataForChangingPrintPreviewAfterUseNextButton();
				this.UIMap.UnpinNavigationBarPanel();
				this.UIMap.ClickRefreshPreviewButtonInLabelsDemoModule();
				this.UIMap.CheckBricksAfterChangingDataViaNextButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeDataViaNavigationBarPreviousButtonTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				this.UIMap.OpenNavigationBarPanel();
				this.UIMap.FindDataForChangingPrintPreviewViaNextButton();
				this.UIMap.FindDataForChangingPrintPreviewViaPreviousButton();
				this.UIMap.ChangeDataForChangingPrintPreviewAfterUsePreviousButton();
				this.UIMap.ClickRefreshPreviewButtonInLabelsDemoModule();
				this.UIMap.UnpinNavigationBarPanel();
				this.UIMap.CheckBricksAfterChangingDataViaPreviousButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeDataViaNavigationBarLastButtonTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				this.UIMap.OpenNavigationBarPanel();
				this.UIMap.FindDataForChangingPrintPreviewViaNextButton();
				this.UIMap.FindDataForChangingPrintPreviewViaLastButton();
				this.UIMap.ChangeDataForChangingPrintPreviewAfterUseLastButton();
				this.UIMap.ClickRefreshPreviewButtonInLabelsDemoModule();
				this.UIMap.UnpinNavigationBarPanel();
				this.UIMap.CheckBricksAfterChangingDataViaLastButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeDataViaNavigationBarFirstButtonTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				this.UIMap.OpenNavigationBarPanel();
				this.UIMap.FindDataForChangingPrintPreviewViaNextButton();
				this.UIMap.FindDataForChangingPrintPreviewViaFirstButton();
				this.UIMap.ChangeDataForChangingPrintPreviewAfterUsePreviousButton();
				this.UIMap.ClickRefreshPreviewButtonInLabelsDemoModule();
				this.UIMap.UnpinNavigationBarPanel();
				this.UIMap.CheckBricksAfterChangingDataViaPreviousButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeLabelsViewModeTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				this.UIMap.OpenNavigationBarPanel();
				this.UIMap.ClearPrintPreviewAllRecordsCheckBox();
				this.UIMap.ClickRefreshPreviewButtonInLabelsDemoModule();
				this.UIMap.CheckStatusBarInfoForAssertionSwitchingOffAllRecordsViewMode();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeTableDemoModuleDataViaNavigationBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToTableDemoModule();
				this.UIMap.OpenNavigationBarPanelInTableDemoModule();
				this.UIMap.ChangeTableDemoModuleDataForChangingPrintPreview();
				this.UIMap.ClickRefreshPreviewButtonInTableDemoModule();
				this.UIMap.CheckBricksAfterChangingTableDemoModuleData();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeGroupsDemoModuleDataViaNavigationBarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToGroupsDemoModule();
				this.UIMap.OpenNavigationBarPanelInGroupsDemoModule();
				this.UIMap.ChangeGroupsDemoModuleDataForChangingPrintPreview();
				this.UIMap.ClickRefreshPreviewButtonInGroupsDemoModule();
				this.UIMap.CheckBricksAfterChangingGroupsDemoModuleData();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ShowDetailReportInMasterDetailDemoModuleViaBookIconClickTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToMasterDetailDemoModule();
				this.UIMap.ClickBookIconToShowDetailReportInMasterDetailDemoModule();
				this.UIMap.CheckShowedDetailReportInMasterDetailDemoModuleViaCheckingBrickText();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void CreatePrintPreviewMonthCalendarTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToCalendarDemoModule();
				this.UIMap.SwitchCalendarPreviewModeToMonthPreview();
				DXPrintingBrick firstBrick = UIMap.UIXtraPrintingFeaturesWindow13.UIPanelControl1Client.UIGcContainerClient.UICalendarModuleCustom.UIDocumentViewerPrintViewControl.UIPage0BrickIndices000PrintControlBrick;
				string monthPattern = @"[januaty, february, march, april, may, june, july, august, semptember, october, november, december]";
				string brickText = firstBrick.Text;
				Assert.IsTrue(Regex.IsMatch(brickText.ToLower(), monthPattern));
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewOrientationInCalendarDemoModuleTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToCalendarDemoModule();
				this.UIMap.ChangePrintPreviewOrientationInCalendarDemoModule();
				this.UIMap.CheckSwitchToLandscapePrintPreviewOrientation();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangePrintPreviewMonthCalendarDimensionsTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToCalendarDemoModule();
				this.UIMap.SwitchCalendarPreviewModeToMonthPreview();
				DXPrintingBrick uIPage0BrickIndices000PrintControlBrick = UIMap.UIXtraPrintingFeaturesWindow9.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices000PrintControlBrick;
				Size oldSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices000PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ChangePrintPreviewMonthCalendarDimensions();
				Size newSizeBrick = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPage0BrickIndices000PrintControlBrick.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeBrick.Height < oldSizeBrick.Height && newSizeBrick.Width < oldSizeBrick.Width);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectionInDataGridModuleViaMouseAndCopyViaCtrlCShortcutTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToDataGridDemoModule();
				this.UIMap.BricksSelectionViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.CheckBricksSelectedState();
				DXPrintingBrick brick1 = UIMap.UIXtraPrintingFeaturesWindow12.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices06PrintControlBrick;
				DXPrintingBrick brick2 = UIMap.UIXtraPrintingFeaturesWindow12.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices07PrintControlBrick;
				DXPrintingBrick brick3 = UIMap.UIXtraPrintingFeaturesWindow12.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices010PrintControlBrick;
				DXPrintingBrick brick4 = UIMap.UIXtraPrintingFeaturesWindow12.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl.UIPage0BrickIndices011PrintControlBrick;
				IDataObject iData = Clipboard.GetDataObject();
				string clipboadString = (String)iData.GetData(DataFormats.Text);
				Assert.IsTrue(clipboadString.Contains(brick1.Text));
				Assert.IsTrue(clipboadString.Contains(brick2.Text));
				Assert.IsTrue(clipboadString.Contains(brick3.Text));
				Assert.IsTrue(clipboadString.Contains(brick4.Text));
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectSomeTextBricksInLabelsModuleViaMouseAndCopyViaCtrlCShortcutTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				this.UIMap.TextBricksSelectionViaMouseAndCopyViaCtrlCShortcut();
				DXPrinting printControl = UIMap.UIXtraPrintingFeaturesWindow15.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl;
				DXPrintingBrick brick1 = printControl.GetBricksOnPage(0)[0].GetBricks()[10];
				Assert.IsTrue(brick1.Selected);
				IDataObject iData = Clipboard.GetDataObject();
				string clipboadString = (String)iData.GetData(DataFormats.Text);
				Assert.IsTrue(clipboadString.Contains(brick1.Text));
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectCheckBrickInLabelsModuleViaMouseAndCopyViaCtrlCShortcutTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				DXPrinting printControl = UIMap.UIXtraPrintingFeaturesWindow15.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl;
				this.UIMap.CheckedBrickSelectionViaMouse();
				DXPrintingBrick brick1 = printControl.GetBrick(0, 0).GetBrick(14);
				Assert.IsTrue(brick1.Selected);
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectPageInfoInLabelsModuleViaMouseAndCopyViaCtrlCShortcutTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToLabelsDemoModule();
				DXPrinting printControl = UIMap.UIXtraPrintingFeaturesWindow15.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIPanelControl1Client.UIDocumentViewerPrintViewControl;
				this.UIMap.PageInfoBrickSelectionViaMouseAndCopyViaCtrlCShortcut();
				DXPrintingBrick brick1 = printControl.GetBrickByPath(new int[3] { 0, 2, 0 });
				Assert.IsTrue(brick1.Selected);
				IDataObject iData = Clipboard.GetDataObject();
				string clipboadString = (String)iData.GetData(DataFormats.Text);
				Assert.IsTrue(clipboadString.Contains(brick1.Text));
			}
		}
		[Timeout(TestInitializer.timeOutForHandCodedTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void SelectionInMasterDetailModuleViaMouseAndCopyViaCtrlCShortcutTest() {
			using(new PrintPreviewTestInitializer()) {
				this.UIMap.SwitchToMasterDetailDemoModule();
				this.UIMap.SelectionDifferentTypeBricksViaMouseAndCopyViaCtrlCShortcut();
				DXPrinting printControl = UIMap.UIXtraPrintingFeaturesWindow14.UIPanelControl1Client.UIGcContainerClient.UIPreviewControlCustom.UIMasterDetailControlCustom.UIPSTabTabList.UITabPage1Client.UIDocumentViewerPrintViewControl;
				DXPrintingBrick brick1 = printControl.GetBrickByPath(new int[4] { 0, 2, 0, 0 });
				DXPrintingBrick brick2 = printControl.GetBrickByPath(new int[4] { 0, 2, 0, 1 });
				DXPrintingBrick brick3 = printControl.GetBricksOnPage(0)[0].GetBricks()[0];
				DXPrintingBrick brick4 = printControl.GetBricksOnPage(0)[0].GetBricks()[1];
				DXPrintingBrick brick5 = printControl.GetBrick(0, 0).GetBricks()[6];
				DXPrintingBrick brick6 = printControl.GetBrick(0, 0).GetBrick(7);
				DXPrintingBrick brick7 = printControl.GetBrick(0, 0).GetBrick(8);
				Assert.IsTrue(brick1.Selected);
				Assert.IsTrue(brick2.Selected);
				Assert.IsTrue(brick3.Selected);
				Assert.IsTrue(brick4.Selected);
				Assert.IsTrue(brick5.Selected);
				Assert.IsTrue(brick6.Selected);
				Assert.IsTrue(brick7.Selected);
				IDataObject iData = Clipboard.GetDataObject();
				string clipboadString = (String)iData.GetData(DataFormats.Text);
				Assert.IsTrue(clipboadString.Contains(brick2.Text));
				Assert.IsTrue(clipboadString.Contains(brick3.Text));
				Assert.IsTrue(clipboadString.Contains(brick4.Text));
				Assert.IsTrue(clipboadString.Contains(brick6.Text));
				Assert.IsTrue(clipboadString.Contains(brick7.Text));
			}
		}
		#region Additional  attributes
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
