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
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class BarSimplePadTests {
		public BarSimplePadTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeCustomizationFormViaClickBarTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.InvokeCustomizationFormViaClickBar();
				this.UIMap.CheckInvokedCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeCustomizationFormViaClickEmptySpaceTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.InvokeCustomizationFormViaClickEmptySpace();
				this.UIMap.CheckInvokedCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeCustomizationFormViaClickDropdownButtonTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.InvokeCustomizationFormViaClickDropdownButton();
				this.UIMap.CheckInvokedCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeCustomizationFormViaDoubleClickEmptySpaceTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.InvokeCustomizationFormViaDoubleClickEmptySpace();
				this.UIMap.CheckInvokedCustomizationForm();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void HideToolbarViaRightClickBarTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideToolbarViaRightClickBar();
				this.UIMap.InvokeCustomizationFormViaDoubleClickEmptySpace();
				this.UIMap.CheckHiddenToolbar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void HideToolbarViaRightClickEmptySpaceTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideToolbarViaRightClickEmptySpace();
				this.UIMap.InvokeCustomizationFormViaDoubleClickEmptySpace();
				this.UIMap.CheckHiddenToolbar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void HideToolbarViaCustomizationFormTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.InvokeCustomizationFormViaClickBar();
				this.UIMap.HideToolbarViaCustomizationForm();
				this.UIMap.CheckHiddenToolbar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayToolbarViaRightClickBarTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideToolbarViaRightClickBar();
				this.UIMap.DisplayToolbarViaRightClickBar();
				this.UIMap.ClickDisplayedBar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayToolbarViaRightClickEmptySpaceTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideToolbarViaRightClickBar();
				this.UIMap.DisplayToolbarViaRightClickEmptySpace();
				this.UIMap.ClickDisplayedBar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayToolbarViaCustomizationFormTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideToolbarViaRightClickBar();
				this.UIMap.InvokeCustomizationFormViaClickBar();
				this.UIMap.DisplayToolbarViaCustomizationForm();
				this.UIMap.ClickDisplayedBar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void HideBarCommandViaClickDropdownButtonTest() {
			using(new SimplePadTestInitializer()) {
				DXMenu uIFormatMenuBar = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar;
				Size oldSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.HideBarCommandViaClickDropdownButton();
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSize.Width < oldSize.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void HideBarCommandViaCustomizationFormTest() {
			using(new SimplePadTestInitializer()) {
				DXMenu uIFormatMenuBar = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar;
				Size oldSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.InvokeCustomizationFormViaClickBar();
				this.UIMap.HideBarCommandViaCustomizationForm();
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSize.Width < oldSize.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayBarCommandViaClickDropdownButtonTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideBarCommandViaClickDropdownButton();
				this.UIMap.DisplayBarCommandViaClickDropdownButton();
				this.UIMap.ClickDisplayedBar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayBarCommandViaCustomizationFormTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.HideBarCommandViaClickDropdownButton();
				this.UIMap.InvokeCustomizationFormViaDoubleClickEmptySpace();
				this.UIMap.DisplayBarCommandViaCustomizationForm();
				this.UIMap.ClickDisplayedBar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveDockedBarToNewPositionTest() {
			using(new SimplePadTestInitializer()) {
				DXMenu uIPaintStyleMenuBar = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIPaintStyleMenuBar;
				Size oldLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPaintStyleMenuBar.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.MoveDockedBarToNewPosition();
				Size newLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPaintStyleMenuBar.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocation.Height > oldLocation.Height && newLocation.Width < oldLocation.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveDockedBarToFormBottomTest() {
			using(new SimplePadTestInitializer()) {
				DXMenu uIPaintStyleMenuBar1 = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIPaintStyleMenuBar;
				Size oldLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPaintStyleMenuBar1.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.MoveDockedBarToFormBottom();
				DXMenu uIPaintStyleMenuBar = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom1.UIPaintStyleMenuBar;
				Size newLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIPaintStyleMenuBar.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocation.Width > oldLocation.Width && newLocation.Height < oldLocation.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void OpenCustomizationFormAndRearrangeBarItemsTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.InvokeCustomizationFormViaDoubleClickEmptySpace();
				DXMenuItem uIItalicBarItem = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar.UIItalicBarItem;
				DXMenuItem uIBoldBarItem = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar.UIBoldBarItem;
				Size oldItalicBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItalicBarItem.GetProperty("Location"), typeof(Size).FullName);
				Size oldBoldBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIBoldBarItem.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.OpenCustomizationFormAndRearrangeBarItems();
				Size newItalicBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItalicBarItem.GetProperty("Location"), typeof(Size).FullName);
				Size newBoldBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIBoldBarItem.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newBoldBarItemLocation.Width > oldBoldBarItemLocation.Width && newItalicBarItemLocation.Width < oldItalicBarItemLocation.Width && newBoldBarItemLocation.Width > newItalicBarItemLocation.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RearrangeBarCommandWithAltKeyTest() {
			using(new SimplePadTestInitializer()) {
				DXMenuItem uIItalicBarItem = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar.UIItalicBarItem;
				DXMenuItem uIBoldBarItem = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar.UIBoldBarItem;
				Size oldItalicBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItalicBarItem.GetProperty("Location"), typeof(Size).FullName);
				Size oldBoldBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIBoldBarItem.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.RearrangeBarCommandWithAltKey();
				Size newItalicBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIItalicBarItem.GetProperty("Location"), typeof(Size).FullName);
				Size newBoldBarItemLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIBoldBarItem.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newBoldBarItemLocation.Width > oldBoldBarItemLocation.Width && newItalicBarItemLocation.Width < oldItalicBarItemLocation.Width && newBoldBarItemLocation.Width > newItalicBarItemLocation.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RestoreDefaultLayoutViaQuickCustomizationTest() {
			using(new SimplePadTestInitializer()) {
				DXMenu uIFormatMenuBar = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar;
				Size originalSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.HideBarCommandsViaHoldDownALT();
				Size reducedSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.RestoreDefaultToolbarLayoutViaQuickCustomization();
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(reducedSize.Width < newSize.Width);
				Assert.AreEqual(newSize.Width, originalSize.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RestoreDefaultLayoutViaCustomizationFormTest() {
			using(new SimplePadTestInitializer()) {
				DXMenu uIFormatMenuBar = UIMap.UISimplePadCDemoWindow.UIBarDockControlCustom.UIFormatMenuBar;
				Size originalSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.HideBarCommandsViaHoldDownALT();
				Size reducedSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.InvokeCustomizationFormViaClickDropdownButton();
				this.UIMap.RestoreDefaultToolbarLayoutViaCustomizationForm();
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIFormatMenuBar.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(reducedSize.Width < newSize.Width);
				Assert.AreEqual(newSize.Width, originalSize.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void FocusMainMenuViaAltAndEnterKeysTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.SwitchFocusToMainMenu();
				this.UIMap.ClickEnterKeyForExpandMainMenuDropdownList();
				this.UIMap.CheckSwitchFocusToMainMenuViaClickToolbarItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void FocusMainMenuViaUnderscoredLetterTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.PressUnderscoredLetterForExpandMainMenuDropdownList();
				this.UIMap.CheckSwitchFocusToMainMenuViaClickToolbarItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void FocusToMainMenuViaAltAndDownArrowKeysTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.SwitchFocusToMainMenu();
				this.UIMap.ClickDownArrowKeyForExpandMainMenuDropdownList();
				this.UIMap.CheckSwitchFocusToMainMenuViaClickToolbarItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToAnotherBarViaCtrlTabShortcutTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.TypeInSimplePadDemo();
				this.UIMap.MoveFocusToAnotherBarViaCtrlTabShortcut();
				this.UIMap.MoveFocusToAnotherBarItemViaArrowKeys();
				CheckEditorTextIsEmpty();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToNextMainMenuItemViaTabKeyTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.MoveFocusToNextMainMenuItemViaTabKey();
				this.UIMap.ClickEnterKeyForExpandMainMenuDropdownList();
				this.UIMap.CheckSwitchFocusToNextMainMenuItemViaTabKeyViaClickToolbarItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToPreviousMainMenuItemViaShiftTabShortcutTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.MoveFocusToNextMainMenuItemViaTabKey();
				this.UIMap.ClickEnterKeyForExpandMainMenuDropdownList();
				this.UIMap.CheckSwitchFocusToNextMainMenuItemViaTabKeyViaClickToolbarItem();
				this.UIMap.ClickEscKeyForCollapseMainMenuDropdownList();
				this.UIMap.MoveFocusToPreviousMainMenuItemViaShiftTabShortcut();
				this.UIMap.CheckSwitchFocusToMainMenuViaClickToolbarItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToAnotherMainMenuItemViaArrowKeysTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.MoveFocusToAnotherMainMenuItemViaArrowKeys();
				this.UIMap.ClickEnterKeyForExpandMainMenuDropdownList();
				this.UIMap.CheckSwitchFocusToNextMainMenuItemViaTabKeyViaClickToolbarItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToSubmenuItemViaRightArrowKeyTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.ClickMainMenuItem();
				this.UIMap.ClickMainMenuDropdownListExpandButton();
				this.UIMap.ChoiceMenuItemWithSubmenu();
				this.UIMap.MoveFocusToSubmenuViaRightArrowKey();
				this.UIMap.CheckMovedFocusViaClickSubmenuItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToPreviousCommandViaShiftTabShortcutTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.TypeInSimplePadDemo();
				this.UIMap.MoveFocusToPreviousCommandViaShiftTabShortcut();
				CheckEditorTextIsEmpty();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveFocusToCommandViaUnderscoredLetterTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.TypeInSimplePadDemo();
				this.UIMap.MoveFocusToBarCommandViaUnderscoredLetter();
				this.UIMap.CheckMovedFocusToNextCommandViaClickCancelButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeFindDialogueViaCtrlFShortcutTest() {
			using(new SimplePadTestInitializer()) {
				this.UIMap.PressSimplePadMenuShortcut();
				this.UIMap.CheckSimplePadMenuShortcutViaClickCancelButton();
			}
		}
		void CheckEditorTextIsEmpty()
		{
			WinEdit uIRichTextBox1Edit = UIMap.UISimplePadCDemoWindow.UISimplePadCDemoClient.UIRtPadWindow.UIRtPadEdit;
			Assert.IsTrue(Regex.Matches(uIRichTextBox1Edit.Text, "[a-zA-Z]").Count == 0);
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
