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
using DevExpress.Win.FunctionalTests.UIMaps.DockingPanelsUIMapClasses;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
namespace DevExpress.Win.FunctionalTests
{
	[CodedUITest]
	public partial class ApplicationUITests
	{
		public ApplicationUITests()
		{
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ShowAlertFormViaButtonClickTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.CheckShowedAlertFormCaption();
				this.UIMap.CloseAlertFormViaCloseButton();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeAlertControlPropertiesAndShowAlertFormTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ChangeAlertControlProperties();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.CheckCustomizedAlertFormCaption();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeFormMaxCountAndShowAlertFormTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ChangeFormMaxCount();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.CheckPostponedFormCount();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeAlertFormSizeAndShowAlertFormTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				DXTestControl uIAlertFormWindow = UIMap.UIItemWindow2.UIAlertFormWindow;
				Size oldSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIAlertFormWindow.GetProperty("Size"), typeof(Size).FullName);
				this.UIMap.ClickAlertControlCloseButton();
				this.UIMap.ChangeAlertFormSize();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				DXTestControl uIAlertFormWindowNew = UIMap.UIItemWindow2.UIAlertFormWindow;
				Size newSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIAlertFormWindowNew.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newSize.Width < oldSize.Width && newSize.Height < oldSize.Height);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void InvokeAlertControlPopupMenuTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				this.UIMap.ClickAlertControlPopupMenuButton();
				this.UIMap.ClickAlertControlPopupMenuItemForAssertion();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void DragAlertFormTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				DXTestControl uIAlertFormWindow = UIMap.UIItemWindow2.UIAlertFormWindow;
				Size oldLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIAlertFormWindow.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.DragAndDropAlertForm();
				Size newLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIAlertFormWindow.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocation.Height < oldLocation.Height && newLocation.Width < oldLocation.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ChangeAlertFormLocationTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(MultiPurposeComponentsGroupName, AlertControlModuleName);
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				DXTestControl uIAlertFormWindow = UIMap.UIItemWindow2.UIAlertFormWindow;
				Size oldLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIAlertFormWindow.GetProperty("Location"), typeof(Size).FullName);
				this.UIMap.ClickAlertControlCloseButton();
				this.UIMap.ChangeAlertFormLocation();
				this.UIMap.ClickShowAlertFormButton();
				this.UIMap.ClickAlertControlPinButton();
				Size newLocation = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)uIAlertFormWindow.GetProperty("Location"), typeof(Size).FullName);
				Assert.IsTrue(newLocation.Height < oldLocation.Height && newLocation.Width < oldLocation.Width);
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickSimpleHeaderButtonTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(DockingUIGroupName, CustomHeaderButtonsModuleName);
				this.UIMap.ClickSimpleHeaderButton();
				this.UIMap.CheckActionsMemoAfterClickSimpleHeaderButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickCheckHeaderButtonTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(DockingUIGroupName, CustomHeaderButtonsModuleName);
				this.UIMap.SwitchToCheckHeaderButtonType();
				this.UIMap.ClickCheckHeaderButton();
				this.UIMap.CheckActionsMemoForCheckHeaderButtonCheckedState();
				this.UIMap.ClickCheckHeaderButton();
				this.UIMap.CheckActionsMemoForCheckHeaderButtonUncheckedState();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickImageHeaderButtonTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(DockingUIGroupName, CustomHeaderButtonsModuleName);
				this.UIMap.SwitchToImageHeaderButtonType();
				this.UIMap.ClickImageHeaderButton();
				this.UIMap.CheckActionsMemoAfterClickImageHeaderButton();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("BarsRibbon"), TestCategory("VS11"), TestMethod]
		public void ClickGlyphsHeaderButtonTest()
		{
			using (new ApplicationUITestInitializer())
			{
				this.SwitchToDemoModule(DockingUIGroupName, CustomHeaderButtonsModuleName);
				this.UIMap.SwitchToGlyphsHeaderButtonType();
				this.UIMap.ClickGlyphsHeaderButton();
				this.UIMap.CheckActionsMemoForCheckGlyphsHeaderButtonCheckedState();
				this.UIMap.ClickGlyphsHeaderButton();
				this.UIMap.CheckActionsMemoForCheckGlyphsHeaderButtonUncheckedState();
			}
		}
		const string MultiPurposeComponentsGroupName = "Multi-Purpose Components";
		const string MDIGroupName = "MDI";
		const string DockingUIGroupName = "Docking UI";
		const string MultipleDocumentsUIGroup = "Multiple Documents UI";
		const string AlertControlModuleName = "Alert Control";
		const string CustomHeaderButtonsModuleName = "Custom Header Buttons";
		const string TabbedMDIModuleName = "Tabbed MDI Manager";
		const string DockPanelsModuleName = "Dock Panels";
		const string DockingUIIntegrationModuleName = "Docking UI Integration";
		const string NativeDocumentsModuleName = "Native Documents";
		const string TabbedDocumentsModuleName = "Tabbed Documents";
		static string[] ModuleNamePostfixes = { 
										   " (updated)" 
									   };
		void SwitchToDemoModule(string groupName, string moduleName)
		{
			DXTestControl accordionControl = this.UIMap.UIApplicationUIWindow1.UIGcNavigationsClient.UINavBarControl1NavBar;
			DXTestControl accordionControlGroup = new DXTestControl(accordionControl);
			accordionControlGroup.SearchProperties[DXTestControl.PropertyNames.Name] = groupName;
			accordionControlGroup.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			DXTestControl accordionControlItem = new DXTestControl(accordionControlGroup);
			accordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = moduleName;
			accordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
			if (!accordionControlItem.Exists)
				foreach (string postfix in ModuleNamePostfixes)
				{
					accordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = moduleName + postfix;
					if (accordionControlItem.Exists)
						break;
				}
			Mouse.Click(accordionControlItem);
			if (moduleName == TabbedDocumentsModuleName)
				SetRequiredWindowSizeForTabbedDocumentsDemoModule();
			else if (moduleName == DockingUIIntegrationModuleName)
				SetRequiredWindowSizeForDockingUIIntegrationDemoModule();
		}
		const int REQUIRED_TABBED_DOCUMENTS_MODULE_WINDOW_WIDTH = 1024;
		const int REQUIRED_DOCKING_UI_INTEGRATION_MODULE_WINDOW_WIDTH = 900;
		void SetRequiredWindowSizeForTabbedDocumentsDemoModule()
		{
			UIDockingMap.UIApplicationUILayoutCWindow2.Size = new Size(REQUIRED_TABBED_DOCUMENTS_MODULE_WINDOW_WIDTH, UIDockingMap.UIApplicationUILayoutCWindow2.BoundingRectangle.Height);
		}
		void SetRequiredWindowSizeForDockingUIIntegrationDemoModule()
		{
			UIDockingMap.UIApplicationUILayoutCWindow.Size = new Size(REQUIRED_DOCKING_UI_INTEGRATION_MODULE_WINDOW_WIDTH, UIDockingMap.UIApplicationUILayoutCWindow.BoundingRectangle.Height);
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
