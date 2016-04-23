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
namespace DevExpress.Win.FunctionalTests
{
	[CodedUITest]
	public class RibbonSimplePadTests
	{
		public RibbonSimplePadTests()
		{
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddRibbonItemToRibbonQuickAccessToolbarTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddRibbonItemToQuickAccessToolbar();
				this.UIMap.CheckRibbonItemAddedToQuickAccessToolbar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddRibbonGroupToRibbonQuickAccessToolbarTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.AddRibbonGroupToQuickAccessToolbar();
				this.UIMap.ClickAddedToQuickAccessToolbarRibbonGroup();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RemoveRibbonItemFromRibbonQuickAccessToolbarTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.RemoveRibbonItemFromRibbonQuickAccessToolbar();
				this.UIMap.CheckRibbonItemLocationForAssertionRemovingFromQuickAccessToolbar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RemoveRibbonGroupFromRibbonQuickAccessToolbarTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddRibbonGroupToQuickAccessToolbar();
				this.UIMap.RemoveRibbonGroupFromRibbonQuickAccessToolbar();
				this.UIMap.CheckRibbonGroupLocationForAssertionRemovingFromQuickAccessToolbar();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ShowRibbonQuickAccessToolbarBelowRibbonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonQuickAccessToolRibbonBar = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon.UIRibbonQuickAccessTooRibbonBar;
				Size oldLocationRibbonQuickAccessToolBar = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonQuickAccessToolRibbonBar.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.ShowRibbonQuickAccessToolbarBelowRibbon();
				Size newLocationRibbonQuickAccessToolBar = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonQuickAccessToolRibbonBar.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocationRibbonQuickAccessToolBar.Height > oldLocationRibbonQuickAccessToolBar.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ShowRibbonQuickAccessToolbarAboveRibbonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.ShowRibbonQuickAccessToolbarBelowRibbon();
				DXTestControl uIRibbonQuickAccessToolRibbonBar = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon.UIRibbonQuickAccessTooRibbonBar;
				Size oldLocationRibbonQuickAccessToolBar = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonQuickAccessToolRibbonBar.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.ShowRibbonQuickAccessToolbarAboveRibbon();
				Size newLocationRibbonQuickAccessToolBar = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonQuickAccessToolRibbonBar.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocationRibbonQuickAccessToolBar.Height < oldLocationRibbonQuickAccessToolBar.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MinimizeRibbonViaExpandCollapseButtonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SwitchToOffice2010RibbonStyle();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.MinimizeRibbonViaExpandCollapseButton();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height < oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MinimizeRibbonViaMinimizeTheRibbonOptionTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.MinimizeRibbonViaMinimizeTheRibbonOption();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height < oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MinimizeRibbonViaDoubleClickTabPageHeaderTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.MinimizeRibbonViaDoubleClickTabPageHeader();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height < oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MinimizeRibbonTestViaCtrlF1ShortcutTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.MinimizeRibbonViaCtrlF1Shortcut();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height < oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ExpandRibbonViaExpandCollapseButtonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SwitchToOffice2010RibbonStyle();
				this.UIMap.MinimizeRibbonViaExpandCollapseButton();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ExpandRibbonViaExpandCollapseButton();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height > oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ExpandRibbonViaUncheckingMinimizeTheRibbonOptionTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.MinimizeRibbonViaMinimizeTheRibbonOption();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ExpandRibbonViaUncheckMinimizeTheRibbonOption();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height > oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ExpandRibbonViaDoubleClickTabPageHeaderTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.MinimizeRibbonViaDoubleClickTabPageHeader();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ExpandRibbonViaDoubleClickTabPageHeader();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height > oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ExpandRibbonViaCtrlF1ShortcutTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.MinimizeRibbonViaCtrlF1Shortcut();
				DXTestControl uIRibbonControl1Ribbon = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon;
				Size oldSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ExpandRibbonViaCtrlF1Shortcut();
				Size newSizeRibbonControl = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonControl1Ribbon.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSizeRibbonControl.Height > oldSizeRibbonControl.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeRibbonCommandViaMouseClickTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouse();
				this.UIMap.ClickCopyRibbonItemViaMouse();
				this.UIMap.ClickPasteRibbonItems();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeRibbonCommandViaShortcutTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.InvokeRibbonPasteCommandViaShortcut();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VS11"), TestMethod]
		public void InvokeRibbonCopyPasteCommandViaAltKeyAndKeyTipsTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouse();
				this.UIMap.InvokeRibbonCopyCommandViaUsingAltKeyAndKeyTips();
				this.UIMap.InvokeRibbonPasteCommandViaUsingAltKeyAndKeyTips();
				this.UIMap.CheckRibbonRichEditTextForAssertionInvokingRibbonCommands();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VS11"), TestMethod]
		public void InvokeRibbonCopyPasteCommandViaF10KeyAndKeyTipsTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouse();
				this.UIMap.InvokeRibbonCopyCommandViaUsingF10KeyAndKeyTips();
				this.UIMap.InvokeRibbonPasteCommandViaUsingF10KeyAndKeyTips();
				this.UIMap.CheckRibbonRichEditTextForAssertionInvokingRibbonCommands();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VS11"), TestMethod]
		public void InvokeRibbonCopyPasteCommandViaAltEscKeysAndKeyTipsTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouse();
				this.UIMap.InvokeRibbonCopyCommandViaUsingAltAndEscKeysAndKeyTips();
				this.UIMap.InvokeRibbonPasteCommandViaUsingAltAndEscKeysAndKeyTips();
				this.UIMap.CheckRibbonRichEditTextForAssertionInvokingRibbonCommands();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ReplaceRichEditTextViaClickRibbonReplaceItemTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.ReplaceInRibbonRichEditViaClickRibbonItem();
				CheckRichTextBoxText("Ribbon");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("TODO"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ReplaceRichEditTextViaCtrlHShortcutTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.ReplaceInRibbonRichEditViaCtrlHShortcut();
				CheckRichTextBoxText("Ribbon");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void SwitchBetweenRibbonTabsViaMouseTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.SwitchingBetweenRibbonTabsViaMouse();
				this.UIMap.ClickRibbonItemForAssertionSwitchingBetweenTabs();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChooseRibbonGalleryItemViaClickRibbonGalleryDropDownButtonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.SwitchToGalleryPageTab();
				this.UIMap.ChangeRibbonGallerySelectedItemViaClickDropDownButton();
				this.UIMap.CheckChangedRibbonGallerySelectedItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChooseRibbonGalleryItemViaScrollingGalleryDownAndClickingItemTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.SwitchToGalleryPageTab();
				this.UIMap.ChangeRibbonGallerySelectedItemViaClickDownButton();
				this.UIMap.CheckChangedRibbonGallerySelectedItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChooseRibbonGalleryItemViaScrollingGalleryUpAndClickingItemTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.SwitchToGalleryPageTab();
				this.UIMap.ChangeRibbonGallerySelectedItemViaClickUpButton();
				this.UIMap.CheckChangedRibbonGallerySelectedItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChooseRibbonGalleryItemViaClickRibbonGalleryItemTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.SwitchToGalleryPageTab();
				this.UIMap.ChangeRibbonGallerySelectedItemViaClickRibbonGalleryItem();
				this.UIMap.CheckChangedRibbonGallerySelectedItemViaClickRibbonGalleryItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeBackstageViewControlCloseCommandTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.ClickButtonNoForAssertionApplicationCloseCommand();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeBackstageViewControlNewDocumentCommandTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.ClickButtonNoForAssertionApplicationCloseCommand();
				this.UIMap.CreateNewDocumentViaClickRibbonItemNew();
				this.UIMap.TypeInNewRibbonRichTextBox();
				CheckRichTextBoxText("Ribbon");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void OpenRecentDocumentViaBackstageViewControlTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.OpenRecentDocumentViaBackstageViewControl();
				this.UIMap.TypeInRecentDocumentRichTextBox();
				CheckRichTextBoxText("test");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void OpenRecentDocumentViaBackstageViewControlCommandAreaTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.CheckQuicklyAccessToRecentDocuments();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.ClickApplicationButtonAndSwitchToRecentDocumentViaQuicklyAccess();
				this.UIMap.TypeInRecentDocumentRichTextBox();
				CheckRichTextBoxText("test");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeNumberOfRecentDocumentsInBackstageViewControlTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.ChangeNumberOfRecentDocumentsViaBackstageViewControl();
				this.UIMap.SwitchToRecentDocumentViaQuicklyAccess();
				this.UIMap.TypeInRecentDocumentRichTextBox();
				CheckRichTextBoxText("test");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CustomizePrintSettingsViaBackstageViewControlTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.InvokePrintSettingsDialogViaBackstageViewControl();
				this.UIMap.CustomizePrintSettingsViaRibbonApplicationPrintItem(); 
				this.UIMap.CheckCustomizedRibbonPrintSettings();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VS11"), TestMethod]
		public void InvokeBackstageViewControlExportCommandTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.InvokeExportCommandViaBackstageViewControl();
				this.UIMap.CloseExportFormForAssertionRibbonExportCommand();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeCollapsedRibbonCommandViaMouseTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.MinimizeRibbonViaDoubleClickTabPageHeader();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.InvokeCollapsedRibbonCommandViaMouse();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickRibbonGroupCaptionButtonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouse();
				this.UIMap.UseRibbonGroupCaptionButtonForCopyPaste();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ResizeRibbonToCollapseRibbonGroupTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewSomeRibbonGroupViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.InvokeCollapsedRibbonCommandAfterResizingRibbon();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickRibbonRightScrollButtonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewSomeRibbonGroupViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ScrollingRibbonViaRightScrollButton();
				this.UIMap.ClickRibbonPageGroupForAssertScrolling();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickRibbonQuickAccessToolbarDoubleArrowButtonTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouseAndCopyViaCtrlCShortcut();
				this.UIMap.AddRibbonItemToQuickAccessToolbarForAssertionQuickAccessToolbarRightPointingDoubleArrowButton();
				int requiredWidth = 400;
				int windowWidth = UIMap.UINewDocument1RibbonSiWindow11.BoundingRectangle.Width;
				DXTestControl sizeGrip = UIMap.UINewDocument1RibbonSiWindow11.UIRibbonStatusBar1MenuBar.UISizeGripCustom;
				Mouse.StartDragging(sizeGrip, new Point(10, 10));
				Mouse.StopDragging(sizeGrip, requiredWidth - windowWidth, 0);
				this.UIMap.ClickQuickAccessToolbarItemViaRightPointingDoubleArrowButton();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewRibbonGroupViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonGroupViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickAddedRibbonPageGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewRibbonGroupAndItemViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonGroupViaCustomizationForm();
				this.UIMap.AddNewRibbonGroupItemViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.TypeInRibbonRichTextBox();
				CheckRichTextBoxTextIsEmpty();
				this.UIMap.CheckRibbonRichEditTextForAssertionMiniToolbarCutItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RenameRibbonGroupViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonGroupViaCustomizationForm();
				this.UIMap.RenameRibbonGroupViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickAddedRibbonPageGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewRibbonTabViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonTabViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickAddedRibbonTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewRibbonTabAndItemViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonTabViaCustomizationForm();
				this.UIMap.AddRibbonCommandToNewRibbonTabInCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectAndCutRibbonRichEditTextViaAddedRibbonTabItem();
				CheckRichTextBoxTextIsEmpty();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RenameRibbonTabViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonTabViaCustomizationForm();
				this.UIMap.RenameRibbonTabViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickAddedRibbonTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewRibbonCategoryViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonCategoryViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickAddedRibbonCategoryGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void RenameRibbonCategoryViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.AddNewRibbonCategoryViaCustomizationForm();
				this.UIMap.RenameRibbonCategoryViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickAddedRibbonCategoryGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void AddNewRibbonCategoryAndItemViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.AddNewRibbonCategoryViaCustomizationForm();
				this.UIMap.AddRibbonCommandToNewRibbonCategoryInCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.SelectAndCutRibbonRichEditTextViaAddedRibbonCategoryItem();
				CheckRichTextBoxTextIsEmpty();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayRibbonTabViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.DisplayRibbonTabViaCustomizationFormItem();
				this.UIMap.ClickCustomizationFormOkButton();
				this.UIMap.ClickDisplayedRibbonTab();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void HideRibbonTabViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonPage2RibbonPage = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon1.UIRibbonPage2RibbonPage;
				Size oldLocationRibbonPage = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonPage2RibbonPage.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.HideRibbonTabViaCustomizationForm();
				this.UIMap.ClickCustomizationFormOkButton();
				Size newLocationRibbonPage = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonPage2RibbonPage.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocationRibbonPage.Width < oldLocationRibbonPage.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveCategoryUpViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonPage3RibbonPage = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon1.UIRibbonPage3RibbonPage;
				Size oldLocationRibbonPage = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonPage3RibbonPage.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.ClickRibbonCustomizationFormUpButton();
				this.UIMap.ClickCustomizationFormOkButton();
				Size newLocationRibbonPage = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonPage3RibbonPage.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocationRibbonPage.Width < oldLocationRibbonPage.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void MoveCategoryDownViaCustomizationFormTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				DXTestControl uIRibbonPage2RibbonPage = UIMap.UINewDocument1RibbonSiWindow.UIRibbonControl1Ribbon1.UIRibbonPage2RibbonPage;
				Size oldLocationRibbonPage = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonPage2RibbonPage.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.ClickRibbonCustomizationFormDownButton();
				this.UIMap.ClickCustomizationFormOkButton();
				Size newLocationRibbonPage = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIRibbonPage2RibbonPage.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocationRibbonPage.Width > oldLocationRibbonPage.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CheckStatusBarInfoAfterClosingDocumentTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.CheckStatusBarInfoAfterClickApplicationCloseItem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CheckStatusBarInfoAfterCreatingDocumentTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.InvokeCloseCommandViaBackstageViewControl();
				this.UIMap.CheckStatusBarInfoAfterClickApplicationCloseItem();
				this.UIMap.CreateNewDocumentViaClickRibbonItemNew();
				this.UIMap.CheckStatusBarInfoAfterClickRibbonCommandNewDocument();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CheckStatusBarInfoAfterTypingTextTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.CheckStatusBarInfoBeforeTypingInRibbonRichTextBox();
				this.UIMap.TypeInRibbonRichTextBoxForAssertChangingStatusBarInfo();
				this.UIMap.CheckStatusBarInfoAfterTypingInRibbonRichTextBox();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void CheckStatusBarInfoAfterTypingTextAndChangingCursorPositionTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.CheckStatusBarInfoBeforeTypingInRibbonRichTextBox();
				this.UIMap.TypeInRibbonRichTextBoxForAssertChangingStatusBarInfo();
				this.UIMap.ChangeCursorPositionInRibbonRichTextBoxForAssertChangingStatusBarInfo();
				this.UIMap.CheckStatusBarInfoAfterTypingInRibbonRichTextBoxAndChangeCursorPosition();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VS11"), TestMethod]
		public void ShowDropDownGalleryViaKeyTipsAndClickGalleryItemTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.ChangeRibbonGalleryItemViaShortcutRibbonGalleryDropDownButton();
				this.UIMap.CheckRibbonGallerySelectedItemAfterUsingGalleryDropDownButtonKeyTips();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnDeveloperPC"), TestCategory("VS11"), TestMethod]
		public void InvokeGroupButtonFunctionalityViaKeyTipsTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.InvokeRibbonGalleryItemsViaShortcutRibbonGalleryDropButton();
				this.UIMap.CheckRibbonGallerySelectedItemAfterUsingGalleryDropButtonKeyTips();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeMiniToolbarCutCommandTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.ClickMiniToolbarCutItem();
				CheckRichTextBoxTextIsEmpty();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeEditMenuUndoCommandTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.ClickEditMenuUndoItem();
				CheckRichTextBoxTextIsEmpty();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeEditMenuCopyAndPasteCommandTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.ClickEditMenuCopyItem();
				this.UIMap.ClickEditMenuPasteItem();
				CheckRichTextBoxText("testtest");
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DisplayContextualTabTest()
		{
			using (new RibbonSimplePadTestInitializer())
			{
				this.UIMap.SetOffice2013ThemeForRibbonSimplePad();
				this.UIMap.TypeInRibbonRichTextBox();
				this.UIMap.SelectionRibbonRichEditTextViaMouse();
				this.UIMap.ClickRibbonItemOfContextualTab();
				CheckRichTextBoxTextIsEmpty();
			}
		}
		void CheckRichTextBoxTextIsEmpty()
		{
			WinEdit uIRichTextBox1Edit = UIMap.UINewDocument1RibbonSiWindow.UINewDocument1Window.UINewDocument1Client.UIRichTextBox1Window.UIRichTextBox1Edit;
			Assert.IsTrue(Regex.Matches(uIRichTextBox1Edit.Text, "[a-zA-Z]").Count == 0);
		}
		void CheckRichTextBoxText(string expectedText)
		{
			WinEdit uIRichTextBox1Edit = UIMap.UINewDocument1RibbonSiWindow.UINewDocument1Window.UINewDocument1Client.UIRichTextBox1Window.UIRichTextBox1Edit;
			MatchCollection matches = Regex.Matches(uIRichTextBox1Edit.Text, "[a-zA-Z]+");
			Assert.IsTrue(matches.Count == 1 && matches[0].Value == expectedText);
		}
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}
		private TestContext testContextInstance;
		public UIMap UIMap
		{
			get
			{
				if ((this.map == null))
				{
					this.map = new UIMap();
				}
				return this.map;
			}
		}
		private UIMap map;
	}
}
