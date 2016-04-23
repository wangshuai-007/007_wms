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
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.Win.FunctionalTests.UIMaps.DockingPanelsUIMapClasses;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class DockingTests {
		public DockingTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void UnpinPanelViaPinButtonTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.UnpinPanelViaClickPinButton();
				this.UIDockingMap.CheckHiddenUnpinnedPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void UnpinPanelViaContextMenuOptionTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.UnpinPanelViaContextMenuOption();
				this.UIDockingMap.CheckHiddenUnpinnedPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void PinPanelViaPinButtonTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.PinPanelViaClickPinButton();
				this.UIDockingMap.CheckDisplayedPinnedPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void PinPanelViaContextMenuOptionTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.PinPanelViaContextMenuOption();
				this.UIDockingMap.CheckDisplayedPinnedPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClosePanelViaCloseButtonTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.ClosePanelViaClickCloseButton();
				this.UIDockingMap.ClickPanelCaptionForCheckClosingPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClosePanelContainerViaContextMenuOptionTest() {
			using(new DockingDemoTestInitializer()) {
				DXTestControl uIMdiClientTabList = UIDockingMap.UIDockingDemoCDemoWindow9.UIMdiClientTabList;
				Size oldListSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIMdiClientTabList.GetProperty("Size"), typeof(Size).FullName);
				this.UIDockingMap.ClosePanelContainerViaContextMenuOption();
				Size newListSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIMdiClientTabList.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newListSize.Width > oldListSize.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RestoreClosedPanelTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.ClosePanelViaClickCloseButton();
				this.UIDockingMap.RestoreClosedPanelViaClickBar();
				this.UIDockingMap.ClickPanelTabButtonForCheckRestoringClosedPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MaximizePanelViaMaximizeButtonTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePanelFloatViaDoubleClickPanelCaption();
				DXTestControl uIPanelContainer2Client = UIDockingMap.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client;
				Size oldPanelSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPanelContainer2Client.GetProperty("Size"), typeof(Size).FullName);
				this.UIDockingMap.ClickPanelMaximizeButton();
				Size newPanelSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPanelContainer2Client.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newPanelSize.Width > oldPanelSize.Width && newPanelSize.Height > oldPanelSize.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentForm();
				this.UIDockingMap.CheckLeftPanelInHorizontalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormTest() {
			using(new DockingDemoTestInitializer()) {
				 this.UIDockingMap.MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentForm();
				 this.UIDockingMap.CheckRightPanelInHorizontalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveHorizontalSplitterTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentForm();
				DXTestControl uIDockPanel3Client = UIDockingMap.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UIDockPanel3Client;
				Size oldSizePanel = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIDockPanel3Client.GetProperty("Size"), typeof(Size).FullName);
				this.UIDockingMap.MoveHorizontalSplitter();
				Size newSizePanel = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIDockPanel3Client.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizePanel.Width < oldSizePanel.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentForm();
				this.UIDockingMap.CheckTopPanelInVerticalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentForm() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentForm();
				this.UIDockingMap.CheckBottomPanelInVerticalSplitContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveVerticalSplitterTest() {
			using(new DockingDemoTestInitializer()) {
				DXTestControl uIDockPanel3Client = UIDockingMap.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UIDockPanel3Client;
				Size oldSizePanel = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIDockPanel3Client.GetProperty("Size"), typeof(Size).FullName);
				this.UIDockingMap.MoveVerticalSplitterDown();
				Size newSizePanel = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIDockPanel3Client.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizePanel.Height < oldSizePanel.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormLeftEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToLeftEdgeOfForm();
				this.UIDockingMap.CheckPanelDockStyleDockedToLeftEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormRightEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToRightEdgeOfForm();
				this.UIDockingMap.CheckPanelDockStyleDockedToRightEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormTopEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToTopEdgeOfForm();
				this.UIDockingMap.CheckPanelDockStyleDockedToTopEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormBottomEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToBottomEdgeOfForm();
				this.UIDockingMap.CheckPanelDockStyleDockedToBottomEdgeOfForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormViaDraggingTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToFormViaDragging();
				this.UIDockingMap.CheckDockingPanelToForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockFloatPanelToFormViaDraggingTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePanelFloatViaDragging();
				this.UIDockingMap.DockFloatPanelToFormViaDragging();
				this.UIDockingMap.CheckDockingPanelToForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToFormViaContextMenuOptionTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToFormWithCreatingNewTabViaContextMenuOption();
				this.UIDockingMap.CheckDockingPanelToFormViaContextMenuOption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockFloatPanelToFormViaContextMenuTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePanelFloatViaDragging();
				this.UIDockingMap.DockFloatPanelToFormWithCreatingNewTabViaContextMenu();
				this.UIDockingMap.CheckDockingPanelToFormViaContextMenuOption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToLeftEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToLeftEdge();
				this.UIDockingMap.CheckPanelDockStyleDockedToLeftEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToRightEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToRightEdge();
				this.UIDockingMap.CheckPanelDockStyleDockedToRightEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToTopEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToTopEdge();
				this.UIDockingMap.CheckPanelDockStyleDockedToTopEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToBottomEdgeTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToBottomEdge();
				this.UIDockingMap.CheckPanelDockStyleDockedToBottomEdge();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToAnotherPanelTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToAnotherPanel();
				this.UIDockingMap.CheckDockingPanelToAnotherPanel();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DockPanelToAnotherPanelAsTabTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.DockPanelToAnotherPanelAsTab();
				this.UIDockingMap.CheckDockingPanelToAnotherPanelAsTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeTabPositionInPanelContainerTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.ChangeTabPositionInPanelContainer();
				this.UIDockingMap.CheckPanelContainerTabIndexes();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakePanelFloatViaDraggingTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePanelFloatViaDragging();
				this.UIDockingMap.CheckFloatPanelDockStyle();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakePanelFloatViaPanelCaptionDoubleClickTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePanelFloatViaDoubleClickPanelCaption();
				this.UIDockingMap.CheckFloatPanelDockStyle();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MakePanelFloatViaContextMenuOptionTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePinnedPanelFloatViaContextMenuOption();
				this.UIDockingMap.CheckUnpinnedPanelFloatDockStyle();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RestorePanelDockStyleViaContextMenuOptionTest() {
			using(new DockingDemoTestInitializer()) {
				this.UIDockingMap.MakePanelFloatViaDoubleClickPanelCaption();
				this.UIDockingMap.CheckFloatPanelDockStyle();
				this.UIDockingMap.RestorePanelDockStyleViaContextMenuOption();
				this.UIDockingMap.CheckPanelRestoredDockStyle();
			}
		}
		#region Additional test attributes
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
		public DockingPanelsUIMap UIDockingMap {
			get {
				if((this.map == null)) {
					this.map = new DockingPanelsUIMap();
				}
				return this.map;
			}
		}
		private DockingPanelsUIMap map;
	}
}
