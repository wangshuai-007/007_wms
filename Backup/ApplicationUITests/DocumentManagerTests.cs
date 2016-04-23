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
using DevExpress.Win.FunctionalTests.UIMaps.DockingPanelsUIMapClasses;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
namespace DevExpress.Win.FunctionalTests {
	public partial class ApplicationUITests {
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ScrollTabViaTabButtonsClickTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				DXTestControl document0 = this.UIDockingMap.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
				DXTestControl document2 = this.UIDockingMap.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument2TabPage;
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				Assert.IsTrue(document2.Visible);
				Assert.IsFalse(document0.Visible);
				this.UIDockingMap.ClickDocumentManagerTabPreviousButton();
				this.UIDockingMap.ClickDocumentManagerTabPreviousButton();
				Assert.IsTrue(document0.Visible);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickDropDownButtonTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.ClickDocumentManagerDropDownButton();
				DXTestControl document2 = this.UIDockingMap.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument2TabPage;
				Assert.IsTrue(document2.Visible);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseDocumentFormViaCloseButtonClickTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.CloseDocumentFormViaClickCloseButton();
				DXTestControl document0 = this.UIDockingMap.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
				Assert.IsFalse(document0.Exists);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseFloatDocumentFormViaCloseButtonClickTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeDocumentFormFloatViaContextMenuOption();
				this.UIDockingMap.CloseFloatDocumentFormViaClickCloseButton();
				this.UIDockingMap.CheckFloatDocumentFormDoesNotExist();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MaximizeAndMinimizeFloatDocumentFormViaWindowTitleButtonTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeDocumentFormFloatViaContextMenuOption();
				DXWindow document0Window = UIDockingMap.UIItemWindow.UIDocument0Window;
				Size sizeBeforeMaximizing = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)document0Window.GetProperty("Size"));
				this.UIDockingMap.MaximizeFloatDocumentFormViaClickMaximizeButton();
				Size sizeAfterMaximizing = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)document0Window.GetProperty("Size"));
				Assert.IsTrue(sizeAfterMaximizing.Width > sizeBeforeMaximizing.Width && sizeAfterMaximizing.Height > sizeBeforeMaximizing.Height);
				this.UIDockingMap.MinimizeFloatDocumentFormViaClickRestoreButton();
				Size sizeAfterMinimizing = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)document0Window.GetProperty("Size"));
				Assert.IsTrue(sizeAfterMaximizing.Width > sizeAfterMinimizing.Width && sizeAfterMaximizing.Height > sizeAfterMinimizing.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeDocumentFormFloatViaDraggingTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeDocumentFormFloatViaDragging();
				this.UIDockingMap.CheckFloatingDocumentFormDockStyle();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeDocumentFormFloatViaCaptionDoubleClickTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeDocumentFormFloatViaDoubleClickCaption();
				this.UIDockingMap.CheckFloatingDocumentFormDockStyle();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeDocumentFormFloatViaContextMenuOptionTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeDocumentFormFloatViaContextMenuOption();
				this.UIDockingMap.CheckFloatingDocumentFormDockStyle();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaption();
				this.UIDockingMap.CheckDocumentManagerTabIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToLeftEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.DockDocumentFormToLeftEdge();
				this.UIDockingMap.CheckDockedFormToLeftEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToRightEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.DockDocumentFormToRightEdge();
				this.UIDockingMap.CheckDockedFormToRightEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToTopEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.DockDocumentFormToTopEdge();
				this.UIDockingMap.CheckDockedFormToTopEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToBottomEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.DockDocumentFormToBottomEdge();
				this.UIDockingMap.CheckDockedFormToBottomEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherForm();
				this.UIDockingMap.CheckDocumentManagerTabIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeHorizontalSplitContainerViaDockingPanelToFormLeftEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentForm();
				this.UIDockingMap.CheckLeftPanelInDocumentManagerHorizontalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeHorizontalSplitContainerViaDockingPanelToFormRightEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentForm();
				this.UIDockingMap.CheckRightPanelInDocumentManagerHorizontalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeVerticalSplitContainerViaDockingPanelToFormTopEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentForm();
				this.UIDockingMap.CheckTopPanelInDocumentManagerVerticalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeVerticalSplitContainerViaDockingPanelToFormBottomEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentForm();
				this.UIDockingMap.CheckBottomPanelInDocumentManagerVerticalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToDocumentFormTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.DockPanelToDocumentForm();
				this.UIDockingMap.CheckDockedPanelToDocumentForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToDocumentFormViaDraggingTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTab();
				this.UIDockingMap.CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseAllDocumentViaContextMenuOptionTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.CloseAllDocumentViaContextMenuOption();
				this.UIDockingMap.CheckCloseAllDocumentOption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseDocumentViaWindowsDialogTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.ShowDialogWindowsForm();
				this.UIDockingMap.CloseDocumentFormViaDialogWindowsForm();
				this.UIDockingMap.CheckClosedDocumentFormViaDialogWindowsForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseAllDocumentsViaWindowsDialogTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, DockingUIIntegrationModuleName);
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.ClickDocumentManagerTabNextButton();
				this.UIDockingMap.ShowDialogWindowsForm();
				this.UIDockingMap.CloseAllDocumentFormViaDialogWindowsForm();
				this.UIDockingMap.CheckCloseAllDocumentOption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MaximizeMinimizeDocumentFormTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, NativeDocumentsModuleName);
				DXTestControl document4Container = UIDockingMap.UIApplicationUILayoutCWindow1.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerNativCustom.UIDocumentsHostTabList.UIDocument4Custom;
				Size beforeMaximize = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)document4Container.GetProperty("Size"));
				this.UIDockingMap.ClickDocumentFormMaximizeButton();
				Size afterMaximize = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)document4Container.GetProperty("Size"));
				this.UIDockingMap.ClickDocumentFormMinimizeButton();
				Size afterMinimize = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)document4Container.GetProperty("Size"));
				Assert.IsTrue(beforeMaximize.Width < afterMaximize.Width && beforeMaximize.Height < afterMaximize.Height);
				Assert.IsTrue(afterMaximize.Width > afterMinimize.Width && afterMaximize.Height > afterMinimize.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewDocumentFormTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, NativeDocumentsModuleName);
				this.UIDockingMap.AddNewDocumentFormViaClickAddNewDocumentBar();
				this.UIDockingMap.CheckNewDocumentAdded();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewDocumentFormToHorizontalContainerLeftSideTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.AddNewDocumentFormToHorizontalContainerLeftSide();
				this.UIDockingMap.CheckNewTabAdded();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewDocumentFormToHorizontalContainerRightSideTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.AddNewDocumentFormToHorizontalContainerRightSide();
				this.UIDockingMap.CheckNewTabAddedToRightGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeDocumentFormContainerOrientationTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.ChangeDocumentFormContainerOrientation();
				this.UIDockingMap.CheckChangedOrientation();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToTabbedViewLeftEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.DockDocumentFormToTabbedViewLeftEdge();
				this.UIDockingMap.CheckDockedFormToTabbedViewLeftEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToTabbedViewRightEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.DockDocumentFormToTabbedViewRightEdge();
				this.UIDockingMap.CheckFirstDocumentDockedToRightEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockDocumentFormToLeftHorizontalContainerAsTabTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.DockDocumentFormToLeftHorizontalContainerAsTab();
				this.UIDockingMap.CheckDockedFormToLeftHorizontalContainerAsTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeVerticalContainerViaDockingDocumentFormToTabbedViewTopEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.CloseDocumentFormViaClickHeaderCloseButton();
				this.UIDockingMap.MakeVerticalContainerViaDockingDocumentFormToTopEdge();
				this.UIDockingMap.CheckVerticalContainerAfterDockingDocumentFormToTopEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.CloseDocumentFormViaClickHeaderCloseButton();
				this.UIDockingMap.MakeTabbedViewDocumentFormFloatViaDoubleClickCaption();
				this.UIDockingMap.MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdge();
				this.UIDockingMap.CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockFloatDocumentFormToTabbedViewLeftEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.MakeTabbedViewDocumentFormFloatViaDoubleClickCaption();
				this.UIDockingMap.DockFloatDocumentFormToTabbedViewLeftEdge();
				this.UIDockingMap.CheckDockedFormToTabbedViewLeftEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockFloatDocumentFormToTabbedViewRightEdgeTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.MakeTabbedViewDocumentFormFloatViaContextMenuOption();
				this.UIDockingMap.DockFloatDocumentFormToTabbedViewRightEdge();
				this.UIDockingMap.CheckDockedFormToTabbedViewRightEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockFloatDocumentFormToLeftHorizontalContainerAsTabTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.MakeTabbedViewDocumentFormFloatViaDragging();
				this.UIDockingMap.DockFloatDocumentFormToLeftHorizontalContainerAsTab();
				this.UIDockingMap.CheckDockedFormToLeftHorizontalContainerAsTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseTabbedViewFloatDocumentFormViaCloseButtonTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.MakeTabbedViewDocumentFormFloatViaDragging();
				this.UIDockingMap.CloseTabbedViewFloatDocumentFormViaCloseButton();
				this.UIDockingMap.CheckFloatDocumentFormClosed();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeTabbedViewHeaderLocationTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				DXTestControl uIDocument4TabPage = UIDockingMap.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument4TabPage;
				Point oldLocation = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Point>((string)uIDocument4TabPage.GetProperty("Location"));
				this.UIDockingMap.ChangeTabbedViewHeaderLocation();
				Point newLocation = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Point>((string)uIDocument4TabPage.GetProperty("Location"));
				Assert.IsTrue(newLocation.Y > oldLocation.Y);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeTabbedViewHeaderOrientationTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				DXTestControl uIDocument4TabPage = UIDockingMap.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument4TabPage;
				Size oldHeaderSize = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)uIDocument4TabPage.GetProperty("Size"));
				this.UIDockingMap.ChangeTabbedViewHeaderOrientation();
				Size newHeaderSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((string)uIDocument4TabPage.GetProperty("Size"));
				Assert.IsTrue(newHeaderSize.Width < oldHeaderSize.Width && newHeaderSize.Height > oldHeaderSize.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeShowCloseButtonModeAndClickTabControlHeaderCloseButtonTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MultipleDocumentsUIGroup, TabbedDocumentsModuleName);
				this.UIDockingMap.SetInTabControlHeaderOption();
				this.UIDockingMap.ClickTabControlHeaderCloseButton();
				this.UIDockingMap.CheckDocument0Closed();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeTabbedMDIDocumentFormFloatViaDraggingTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.MakeTabbedMDIDocumentFormFloatViaDragging();
				this.UIDockingMap.CheckFloatTabbedMDIDocumentForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeTabbedMDIDocumentFormFloatViaDoubleClickTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.MakeTabbedMDIDocumentFormFloatViaDoubleClick();
				this.UIDockingMap.CheckFloatTabbedMDIDocumentForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void UncheckFloatOnDragOptionTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.UncheckFloatOnDragOption();
				this.UIDockingMap.DragTabbedMDIDocumentForm();
				this.UIDockingMap.CheckConservationTabbedMDIDocumentFormIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void UncheckFloatOnDoubleClickOptionTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.UncheckFloatOnDoubleClickOption();
				this.UIDockingMap.MakeTabbedMDIDocumentFormFloatViaDoubleClick();
				this.UIDockingMap.CheckConservationTabbedMDIDocumentFormIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockFloatTabbedMDIDocumentFormAsTabTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.MakeTabbedMDIDocumentFormFloatViaDragging();
				this.UIDockingMap.DockFloatTabbedMDIDocumentFormAsTab();
				this.UIDockingMap.CheckDockedTabbedMDIDocumentFormAsTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeClosePageButtonAndClickHeaderCloseButtonTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.ChangeClosePageButtonInTabbedMDIDemoModule();
				this.UIDockingMap.ClickTabbedMDIDocumentFormHeaderCloseButton();
				this.UIDockingMap.CheckClosedTabbedMDIDocumentForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ReorderMDITabsTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.ReorderMDITabs();
				this.UIDockingMap.CheckMDITabIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeTabbedMDIHeaderLocationTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				DXTestControl uIForm2TabPage = UIDockingMap.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
				Size oldHeaderLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIForm2TabPage.GetProperty("Location"), typeof(Size).FullName);
				this.UIDockingMap.ChangeTabbedMDIHeaderLocation();
				Size newHeaderLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIForm2TabPage.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newHeaderLocation.Height > oldHeaderLocation.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeTabbedMDIHeaderOrientationTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				DXTestControl uIForm2TabPage = UIDockingMap.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
				Size oldHeaderSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIForm2TabPage.GetProperty("Size"), typeof(Size).FullName);
				this.UIDockingMap.ChangeTabbedMDIHeaderOrientation();
				Size newHeaderSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIForm2TabPage.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newHeaderSize.Width < oldHeaderSize.Width && newHeaderSize.Height > oldHeaderSize.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CloseMDITabViaTabCloseButtonTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				this.UIDockingMap.CloseMDITabViaTabCloseButton();
				this.UIDockingMap.CheckMDITabIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void SwitchOnHeaderAutoFillOptionTest() {
			using(new ApplicationUITestInitializer()) {
				this.SwitchToDemoModule(MDIGroupName, TabbedMDIModuleName);
				this.UIDockingMap.ClickLaunchSampleButtonInTabbedMDIDemoModule();
				DXTestControl uIForm2TabPage = UIDockingMap.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
				Size oldHeaderLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIForm2TabPage.GetProperty("Location"), typeof(Size).FullName);
				this.UIDockingMap.MakeHeaderAutoFillBarVisible();
				this.UIDockingMap.SwitchOnHeaderAutoFillOption();
				Size newHeaderLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIForm2TabPage.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newHeaderLocation.Width > oldHeaderLocation.Width);
			}
		}
		public DockingPanelsUIMap UIDockingMap {
			get {
				if((this.dockingMap == null)) {
					this.dockingMap = new DockingPanelsUIMap();
				}
				return this.dockingMap;
			}
		}
		private DockingPanelsUIMap dockingMap;
	}
}
