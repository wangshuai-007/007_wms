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
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class NavBarTests {
		public NavBarTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddNavBarGroupTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToAddGroupsDemoModule();
				this.UIMap.AddNewNavBarGroup();
				this.UIMap.CheckAddedNavBarGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DeleteNavBarGroupTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToAddGroupsDemoModule();
				this.UIMap.AddNewNavBarGroup();
				this.UIMap.CheckAddedNavBarGroup();
				this.UIMap.DeleteNavBarGroup();
				this.UIMap.CheckDeletedNavBarGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddNavBarItemLinkTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToAddItemLinksDemoModule();
				this.UIMap.AddNewNavBarItemLink();
				this.UIMap.CheckAddedNavBarItemLink();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DeleteNavBarItemLinkTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToAddItemLinksDemoModule();
				this.UIMap.AddNewNavBarItemLink();
				this.UIMap.CheckAddedNavBarItemLink();
				this.UIMap.DeleteNavBarItemLink();
				this.UIMap.CheckDeletedNavBarItemLink();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ObtainNavBarHitInfoTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarHitInfoDemoModule();
				this.UIMap.ObtainNavBarHitInfo();
				this.UIMap.CheckObtainedNavBarHitInfo();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeNavBarItemCaptionTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarPropertiesDemoModule();
				this.UIMap.ChangeNavBarItemCaption();
				this.UIMap.CheckChangedNavBarItemCaption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeNavBarLinkItemAndItemCaptionTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarPropertiesDemoModule();
				this.UIMap.ChangeNavBarLinkItemAndItemCaption();
				this.UIMap.CheckChangedNavBarLinkItemAndItemCaption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DeleteNavBarLinkViaContextMenuTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarPropertiesDemoModule();
				this.UIMap.DeleteNavBarLinkViaContextMenu();
				this.UIMap.CheckDeletedViaContextMenuNavBarLink();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddNavBarLinkViaContextMenuTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarPropertiesDemoModule();
				this.UIMap.DeleteNavBarLinkViaContextMenu();
				this.UIMap.CheckDeletedViaContextMenuNavBarLink();
				this.UIMap.AddNavBarLinkViaContextMenu();
				this.UIMap.CheckAddedViaContextMenuNavBarLink();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddNavBarGroupViaContextMenuTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarPropertiesDemoModule();
				this.UIMap.AddNavBarGroupViaContextMenu();
				this.UIMap.CheckAddedViaContextMenuNavBarGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void RemoveNavBarGroupViaContextMenuTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavBarPropertiesDemoModule();
				this.UIMap.RemoveNavBarGroupViaContextMenu();
				this.UIMap.CheckRemovedNavBarGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestMethod]
		public void DragNavBarLinkToItemListTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToDragAndDropDemoModule();
				this.UIMap.DragNavBarLinkToItemList();
				this.UIMap.CheckDraggedNavBarLinkToItemList();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DragItemToNavBarTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToDragAndDropDemoModule();
				this.UIMap.DragItemToNavBar();
				this.UIMap.CheckDraggedItemToNavBar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void DragNavBarLinkToRecycleBinTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToDragAndDropDemoModule();
				this.UIMap.DragNavBarLinkToRecycleBin();
				this.UIMap.CheckDraggedNavBarLinkToRecycleBin();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void CollapseAndExpandCustomizedNavBarGroupTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToCustomizableDistancesDemoModule();
				this.UIMap.ChangeNavBarIntervals();
				this.UIMap.CollapseNavBarGroup();
				this.UIMap.CheckCollapsedNavBarGroup();
				this.UIMap.ExpandNavBarGroup();
				this.UIMap.CheckExpandedNavBarGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickNavBarExpandButtonTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				DXNavBar uINavBarControl1NavBar = UIMap.UITheXtraNavBarSuiteDeWindow8.UIPanelControl1Client.UIGcContainerClient.UIFrmNavBarNavigationPCustom.UIPanelControlClient.UIPanelControl3Client.UISplitContainerControSplitContainerControl.UISplitGroupPanelClient.UINavBarControl1NavBar;
				Size navBarSizeBeforeCollapse = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((String)uINavBarControl1NavBar.GetProperty("Size"));
				this.UIMap.ClickNavBarCollapseButton();
				Size navBerSizeAfterCollapse = DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString<Size>((String)uINavBarControl1NavBar.GetProperty("Size"));
				Assert.IsTrue(navBerSizeAfterCollapse.Width < navBarSizeBeforeCollapse.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickShowMoreButtonsTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				this.UIMap.CheckFolderListButtonInvisible();
				this.UIMap.ClickShowMoreButtons();
				this.UIMap.CheckFolderListButtonVisible();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickShowFewerButtonsTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				this.UIMap.CheckNotesButtonVisible();
				this.UIMap.ClickShowFewerButtons();
				this.UIMap.CheckNotesButtonInvisible();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void RemoveGroupViaOverflowPanelButtonClickTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				this.UIMap.RemoveCalendarButtonViaAddOrRemoveButtonMenuItem();
				this.UIMap.CheckCalendarButtonRemoved();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void AddGroupViaOverflowPanelButtonClickTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				this.UIMap.RemoveCalendarButtonViaAddOrRemoveButtonMenuItem();
				this.UIMap.CheckCalendarButtonRemoved();
				this.UIMap.AddCalendarButtonViaAddOrRemoveButtonMenuItem();
				this.UIMap.CheckCalendarButtonAdded();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void MoveOverflowPanelSplitterUpTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				this.UIMap.CheckFolderListButtonInvisible();
				this.UIMap.MoveNavBarOverflowPanelSplitterUp();
				this.UIMap.CheckFolderListButtonVisible();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void MoveOverflowPanelSplitterDownTest() {
			using(new NavBarsTestInitializer()) {
				this.UIMap.SwitchToNavigationPaneDemoModule();
				this.UIMap.CheckNotesButtonVisible();
				this.UIMap.MoveNavBarOverflowPanelSplitterDown();
				this.UIMap.CheckNotesButtonInvisible();
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
