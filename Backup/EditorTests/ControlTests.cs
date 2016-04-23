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
using DevExpress.Win.FunctionalTests.EditorsTests;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class ControlTests {
		public ControlTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDropDownButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDropDownButtonDemoModule();
				this.UIMap.ClickDropDownButton();
				this.UIMap.CheckLogAfterClickDropDownButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void OpenDropDownButtonPopupMenuTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDropDownButtonDemoModule();
				this.UIMap.OpenDropDownButtonPopupControl();
				this.UIMap.CheckLogAfterOpeningDropDownButtonPopupMenu();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void OpenDropDownButtonPopupControlContainerTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDropDownButtonDemoModule();
				this.UIMap.SwitchDropDownControlToPopupControlContrainer();
				this.UIMap.OpenDropDownButtonPopupControl();
				this.UIMap.CheckLogAfterOpeningDropDownButtonPopupControlContainer();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorNextButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorNextButton();
				this.UIMap.CheckLogAfterClickDataNavigatorNextButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorNextPageButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorNextPageButton();
				this.UIMap.CheckLogAfterClickDataNavigatorNextPageButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorLastButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorLastButton();
				this.UIMap.CheckLogAfterClickDataNavigatorLastButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorAppendButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorAppendButton();
				this.UIMap.CheckLogAfterClickDataNavigatorAppendButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorRemoveButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorRemoveButton();
				this.UIMap.CheckLogAfterClickDataNavigatorRemoveButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorEndEditButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorEndEditButton();
				this.UIMap.CheckLogAfterClickDataNavigatorEndEditButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorCancelEditButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorCancelEditButton();
				this.UIMap.CheckLogAfterClickDataNavigatorCancelEditButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorSearchButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorSearchButton();
				this.UIMap.CheckLogAfterClickDataNavigatorSearchButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorLockButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorLockButton();
				this.UIMap.CheckLogAfterClickDataNavigatorLockButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorPreviousButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorLastButton();
				this.UIMap.ClickDataNavigatorPreviousButton();
				this.UIMap.CheckLogAfterClickDataNavigatorPreviousButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorPreviousPageButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorLastButton();
				this.UIMap.ClickDataNavigatorPreviousPageButton();
				this.UIMap.CheckLogAfterClickDataNavigatorPreviousPageButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickDataNavigatorFirstButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDataNavigatorDemoModule();
				this.UIMap.ClickDataNavigatorLastButton();
				this.UIMap.ClickDataNavigatorFirstButton();
				this.UIMap.CheckLogAfterClickDataNavigatorFirstButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeNumericMaskBoxEditValuesTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMaskBoxDemoModule();
				this.UIMap.ChangeNumericMaskBoxEditValues();
				this.UIMap.CheckChangedNumericMaskBoxEditValues();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeDateTimeMaskBoxEditValuesTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMaskBoxDemoModule();
				this.UIMap.SwitchToDateTimeTab();
				this.UIMap.ChangeFullDateTimeEditValue();
				this.UIMap.CheckFullDateTimeEditValue();
				this.UIMap.ChangeFullDateAndTimeEditValue();
				this.UIMap.CheckFullDateAndTimeEditValue();
				this.UIMap.ChangeRFCDateTimeEditValue();
				this.UIMap.CheckRFCDateTimeEditValue();
				this.UIMap.ChangeUniversalSortableDateTimeEditValue();
				this.UIMap.CheckUniversalSortableDateTimeEditValue();
				this.UIMap.ChangeMonthAndDayDateTimeEditValue();
				this.UIMap.CheckMonthAndDayDateTimeEditValue();
				this.UIMap.ChangeShortTimeDateTimeEditValue();
				this.UIMap.CheckShortTimeDateTimeEditValue();
				this.UIMap.ChangeDayTimeDateTimeEditValue();
				this.UIMap.CheckDayTimeDateTimeEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeRegExMaskBoxEditValuesTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMaskBoxDemoModule();
				this.UIMap.SwitchToRegExTab();
				this.UIMap.ChangeRegExMaskBoxEditValues();
				this.UIMap.CheckRegExMaskBoxEditValues();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeSimpleMaskBoxEditValuesTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMaskBoxDemoModule();
				this.UIMap.SwitchToSimpleTab();
				this.UIMap.ChangeSimpleMaskBoxEditValues();
				this.UIMap.CheckSimpleMaskBoxEditValues();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeRegularMaskBoxEditValuesTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMaskBoxDemoModule();
				this.UIMap.SwitchToRegularTab();
				this.UIMap.ChangeRegularMaskBoxEditValues();
				this.UIMap.CheckRegularMaskBoxEditValues();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectListBoxValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SelectListBoxValueViaMouse();
				this.UIMap.CheckSelectedListBoxValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectListBoxValueViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SelectListBoxValueViaKeyboard();
				this.UIMap.CheckSelectedListBoxValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiSimpleSelectionModeAndSelectListBoxValuesViaMouseTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiSimpleSelectionMode();
				this.UIMap.MultiSimpleSelectionInListBoxViaMouse();
				this.UIMap.CheckMultiSimpleSelectionInListBox();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiSimpleSelectionModeAndSelectListBoxValuesViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiSimpleSelectionMode();
				this.UIMap.MultiSimpleSelectionInListBoxViaKeyboard();
				this.UIMap.CheckMultiSimpleSelectionInListBox();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiSimpleSelectionModeAndUndoSelectionListBoxValuesViaMouseTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiSimpleSelectionMode();
				this.UIMap.MultiSimpleSelectionInListBoxViaKeyboard();
				this.UIMap.CheckMultiSimpleSelectionInListBox();
				this.UIMap.UndoSelectionListBoxValuesViaMouse();
				this.UIMap.CheckMultiSimpleSelectionInListBoxAfterUndoSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiSimpleSelectionModeAndUndoSelectionListBoxValuesViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiSimpleSelectionMode();
				this.UIMap.MultiSimpleSelectionInListBoxViaKeyboard();
				this.UIMap.CheckMultiSimpleSelectionInListBox();
				this.UIMap.UndoMultiSimpleSelectionListBoxValuesViaKeyboard();
				this.UIMap.CheckMultiSimpleSelectionInListBoxAfterUndoSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiExtendedSelectionModeAndSelectListBoxValuesViaMouseTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiExtendedSelectionMode();
				this.UIMap.MultiExtendedSelectionInListBoxViaMouse();
				this.UIMap.CheckMultiExtendedSelectionInListBox();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiExtendedSelectionModeAndSelectListBoxValuesViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiExtendedSelectionMode();
				this.UIMap.MultiExtendedSelectionInListBoxViaKeyboard();
				this.UIMap.CheckMultiExtendedSelectionInListBox();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiExtendedSelectionModeAndUndoSelectionListBoxValuesViaMouseTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiExtendedSelectionMode();
				this.UIMap.MultiExtendedSelectionInListBoxViaKeyboard();
				this.UIMap.CheckMultiExtendedSelectionInListBox();
				this.UIMap.UndoMultiExtendedSelectionListBoxValuesViaMouse();
				this.UIMap.CheckMultiExtendedSelectionInListBoxAfterUndoSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SwitchToMultiExtendedSelectionModeAndUndoSelectionListBoxValuesViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToMultiExtendedSelectionMode();
				this.UIMap.UndoMultiExtendedSelectionListBoxValuesViaKeyboard();
				this.UIMap.CheckMultiExtendedSelectionInListBoxAfterUndoSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectCheckedListBoxValuesViaMouseTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToCheckedListBoxTab();
				this.UIMap.SelectCheckedListBoxValuesViaMouse();
				this.UIMap.CheckSelectedCheckedListBoxValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectCheckedListBoxValuesViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToCheckedListBoxTab();
				this.UIMap.SelectCheckedListBoxValuesViaKeyboard();
				this.UIMap.CheckSelectedCheckedListBoxValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickInvertCheckedItemsButtonTest() {
			using(new EditorsTestInitializer()) {
				SwitchToListBoxDemoModule();
				this.UIMap.SwitchToCheckedListBoxTab();
				this.UIMap.ClickInvertCheckedItemsButton();
				this.UIMap.CheckInvertedSelectedCheckedListBoxValues();
			}
		}
		void SwitchToListBoxDemoModule() {
			EditorsDemoModules.SwitchToDemoModule(UIMap.UIXtraEditorsTutorialsWindow1.UIGcNavigationsClient.UINavBarControl1NavBar, EditorsDemoModules.GroupNames.MiltiPurpose, EditorsDemoModules.ModuleNames.ListBox); 
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
