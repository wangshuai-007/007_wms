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
using DevExpress.Utils.CodedUISupport;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class PopupEditorsTests {
		public PopupEditorsTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCalcEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCalcEditDemoModule();
				this.UIMap.ChangeCalcEditValueViaMouse();
				this.UIMap.CheckCalcEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCalcEditValueViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCalcEditDemoModule();
				this.UIMap.ChangeCalcEditValueViaKeyboard();
				this.UIMap.CheckCalcEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCalcEditValueViaKeyboardInOpenedDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCalcEditDemoModule();
				this.UIMap.ChangeCalcEditValueViaKeyboardInOpenedDropDownList();
				this.UIMap.CheckCalcEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCalcEditValueViaViaMouseWheelScrollTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCalcEditDemoModule();
				this.UIMap.ChangeCalcEditValueViaViaMouseWheelScroll();
				this.UIMap.CheckCalcEditValueChangedViaMouseWheelScroll();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInCustomTabViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInTabCustomViaMouse();
				this.UIMap.CheckColorEditValueInTabCustom();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInCustomTabViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInTabCustomViaKeyboard();
				this.UIMap.CheckColorEditValueInTabCustom();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInCustomTabViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInCustomTabViaF4KeyAndKeyboard();
				this.UIMap.CheckColorEditValueInTabCustom();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInWebTabViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInTabWebViaMouse();
				this.UIMap.CheckColorEditValueInTabWeb();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInWebTabViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInTabWebViaKeyboard();
				this.UIMap.CheckColorEditValueInTabWeb();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInSystemTabViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInTabSystemViaMouse();
				this.UIMap.CheckColorEditValueInTabSystem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeColorEditValueInSystemTabViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToColorEditDemoModule();
				this.UIMap.ChangeColorEditValueInTabSystemViaKeyboard();
				this.UIMap.CheckColorEditValueInTabSystem();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeComboBoxEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToComboBoxEditDemoModule();
				this.UIMap.ChangeComboBoxEditValueViaMouse();
				this.UIMap.CheckComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeComboBoxEditValueViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToComboBoxEditDemoModule();
				this.UIMap.ChangeComboBoxEditValueViaKeyboard();
				this.UIMap.CheckComboBoxEditValue();
				this.UIMap.CheckComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeComboBoxEditValueViaKeyboardInOpenedDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToComboBoxEditDemoModule();
				this.UIMap.ChangeComboBoxEditValueViaKeyboardInOpenedDropDownList();
				this.UIMap.CheckComboBoxEditValue();
				this.UIMap.CheckComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeComboBoxEditValueViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToComboBoxEditDemoModule();
				this.UIMap.ChangeComboBoxEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckComboBoxEditValue();
				this.UIMap.CheckComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeComboBoxEditValueViaMouseWheelScrollTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToComboBoxEditDemoModule();
				this.UIMap.ChangeComboBoxEditValueViaMouseWheelScroll();
				this.UIMap.CheckComboBoxEditValue();
				this.UIMap.CheckComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeDateEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDateEditDemoModule();
				this.UIMap.ChangeDateEditValueViaMouse();
				this.UIMap.CheckDateEditValueChangedViaMouse();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeDateEditValueViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDateEditDemoModule();
				this.UIMap.ChangeDateEditValueViaKeyboard();
				this.UIMap.CheckDateEditValueChangedViaKeyboard();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeDateEditValueViaKeyboardInOpenedDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDateEditDemoModule();
				this.UIMap.ChangeDateEditValueViaKeyboardInOpenedDropDownList();
				this.UIMap.CheckDateEditValueChangedViaKeyboard();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeDateEditValueViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDateEditDemoModule();
				this.UIMap.ChangeDateEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckDateEditValueChangedViaKeyboard();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClearDateEditValueTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDateEditDemoModule();
				this.UIMap.ClearDateEditValueViaButtonClear();
				this.UIMap.CheckClearedDateEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeDateEditValueInVistaTimeModeTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToDateEditDemoModule();
				this.UIMap.SwitchToEditTimeMode();
				this.UIMap.ChangeDateEditValueInVistaTimeMode();
				this.UIMap.CheckDateEditValueInVistaTimeMode();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeImageComboBoxEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToImageComboBoxEditDemoModule();
				this.UIMap.ChangeImageComboBoxEditValueViaMouse();
				this.UIMap.CheckImageComboBoxEditValue();
				this.UIMap.CheckImageComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeImageComboBoxEditValueViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToImageComboBoxEditDemoModule();
				this.UIMap.ChangeImageComboBoxEditValueViaKeyboard();
				this.UIMap.CheckImageComboBoxEditValue();
				this.UIMap.CheckImageComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeImageComboBoxEditValueViaMouseInOpenedDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToImageComboBoxEditDemoModule();
				this.UIMap.ChangeImageComboBoxEditValueViaMouseInOpenedDropDownList();
				this.UIMap.CheckImageComboBoxEditValue();
				this.UIMap.CheckImageComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeImageComboBoxEditValueViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToImageComboBoxEditDemoModule();
				this.UIMap.ChangeImageComboBoxEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckImageComboBoxEditValue();
				this.UIMap.CheckImageComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeImageComboBoxEditValueViaMouseWheelScrollTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToImageComboBoxEditDemoModule();
				this.UIMap.ChangeImageComboBoxEditValueViaMouseWheelScroll();
				this.UIMap.CheckImageComboBoxEditValue();
				this.UIMap.CheckImageComboBoxEditSelectedIndex();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeLookUpEditValueViaTypingTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToLookUpEditDemoModule();
				this.UIMap.ChangeLookUpEditValueViaTyping();
				this.UIMap.CheckLookUpEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeLookUpEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToLookUpEditDemoModule();
				this.UIMap.ChangeLookUpEditValueViaMouse();
				this.UIMap.CheckLookUpEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeLookUpEditValueViaMouseWheelScrollTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToLookUpEditDemoModule();
				this.UIMap.ChangeLookUpEditValueViaMouseWheelScroll();
				this.UIMap.CheckLookUpEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeLookUpEditValueViaKeyboardInOpenedDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToLookUpEditDemoModule();
				this.UIMap.ChangeLookUpEditValueViaKeyboard();
				this.UIMap.CheckLookUpEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeLookUpEditValueViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToLookUpEditDemoModule();
				this.UIMap.ChangeLookUpEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckLookUpEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeMemoExEditValueViaOkButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMemoExEditDemoModule();
				this.UIMap.ChangeMemoExEditValueViaOkButton();
				this.UIMap.CheckMemoExEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeMemoExEditValueViaCancelButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMemoExEditDemoModule();
				this.UIMap.ChangeMemoExEditValueViaOkButton();
				this.UIMap.ChangeMemoExEditValueViaCancelButton();
				this.UIMap.CheckMemoExEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeMemoExEditValueViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMemoExEditDemoModule();
				this.UIMap.ChangeMemoExEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckChangedViaF4KeyAndKeyboardMemoExEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeMemoExEditSizeTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMemoExEditDemoModule();
				this.UIMap.ChangeMemoExEditSize();
				DXWindow uIMemoExPopupFormWindow = UIMap.UITheXtraEditorsSuiteDWindow2.UIPanelControl1Client.UIGcContainerClient.UIModuleMemoExEditCustom.UIXtraTabControl1TabList.UIXtraTabPage1Client.UIPanelControl1Client.UIMemoExEditSamplePopupEdit.UIMemoExPopupFormWindow;
				Assert.AreEqual(UIMap.CheckMemoExEditSizeExpectedValues.UIMemoExPopupFormWindowSize, CodedUIUtils.ConvertToString(uIMemoExPopupFormWindow.Size));
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeMRUEditValueViaAddingToDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMRUEditDemoModule();
				this.UIMap.ChangeMRUEditValueViaAddingToDropDownList();
				this.UIMap.CheckMRUEditValueAfterAdding();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeMRUEditValueViaDeletingFromDropDownListTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMRUEditDemoModule();
				this.UIMap.ChangeMRUEditValueViaDeletingFromDropDownList();
				this.UIMap.CheckMRUEditValueAfterDeleting();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectFromMRUEditDropDownListViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMRUEditDemoModule();
				this.UIMap.SelectFromMRUEditDropDownListViaMouse();
				this.UIMap.CheckMRUEditValueAfterSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectFromMRUEditDropDownListViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMRUEditDemoModule();
				this.UIMap.SelectFromMRUEditDropDownListViaKeyboard();
				this.UIMap.CheckMRUEditValueAfterSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void SelectFromMRUEditDropDownListViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMRUEditDemoModule();
				this.UIMap.SelectFromMRUEditDropDownListViaF4KeyAndKeyboard();
				this.UIMap.CheckMRUEditValueAfterSelection();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void TypeInMRUEditTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToMRUEditDemoModule();
				this.UIMap.TypeInMRUEdit();
				this.UIMap.CheckMRUEditValueAfterTyping();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangePopupContainerEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToPopupContainerEditDemoModule();
				this.UIMap.ChangePopupContainerEditValueViaMouse();
				this.UIMap.CheckPopupContainerEditValue();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangePopupContainerEditSizeTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToPopupContainerEditDemoModule();
				this.UIMap.ChangePopupContainerEditSize();
				DXWindow uIPopupContainerFormWindow = UIMap.UIXtraEditorsTutorialsWindow.UIPcMainClient.UIGcContainerClient.UIModulePopupContainerCustom.UIXtraTabControl1TabList.UIXtraTabPage1Client.UIPanelControl1Client.UIPopupContainerEditSaEdit.UIPopupContainerFormWindow;
				Assert.AreEqual(UIMap.CheckPopupContainerEditSizeExpectedValues.UIPopupContainerFormWindowSize, CodedUIUtils.ConvertToString(uIPopupContainerFormWindow.Size));
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangePopupContainerEditValueAndClickCloseButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToPopupContainerEditDemoModule();
				this.UIMap.ChangePopupContainerEditValueAndClickCloseButton();
				this.UIMap.CheckPopupContainerEditValueWasNotChanged();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCheckedComboBoxEditValueViaMouseTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCheckedComboBoxEditDemoModule();
				this.UIMap.ChangeCheckedComboBoxEditValueViaMouse();
				this.UIMap.CheckCheckedComboBoxEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCheckedComboBoxEditValueViaKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCheckedComboBoxEditDemoModule();
				this.UIMap.ChangeCheckedComboBoxEditValueViaKeyboard();
				this.UIMap.CheckCheckedComboBoxEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCheckedComboBoxEditValueViaF4KeyAndKeyboardTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCheckedComboBoxEditDemoModule();
				this.UIMap.ChangeCheckedComboBoxEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckCheckedComboBoxEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeCheckedComboBoxEditValueViaF4KeyAndKeyboardAndClickEscapeButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCheckedComboBoxEditDemoModule();
				this.UIMap.ChangeCheckedComboBoxEditValueViaF4KeyAndKeyboard();
				this.UIMap.CheckCheckedComboBoxEditValue();
				this.UIMap.ChangeCheckedComboBoxEditValueViaF4KeyAndKeyboardAndClickEscapeButton();
				this.UIMap.CheckCheckedComboBoxEditValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ClickCheckedComboBoxEditSelectAllButtonTest() {
			using(new EditorsTestInitializer()) {
				this.UIMap.SwitchToCheckedComboBoxEditDemoModule();
				this.UIMap.ChangeCheckedComboBoxEditValueViaButtonSelectAll();
				this.UIMap.CheckSelectedCheckedComboBoxEditValues();
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
