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

namespace DevExpress.Win.FunctionalTests.UIMaps.LayoutControlUIMapClasses
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
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
	using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
	using MouseButtons = System.Windows.Forms.MouseButtons;
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public partial class LayoutControlUIMap
	{
		public void SwitchToNwindEmployeesDemoModule()
		{
			#region Variable Declarations
			DXTestControl uINwindEmployeesAccordionControlItem = this.UIXtraLayoutFeaturesDeWindow.UIGcNavigationsClient.UIAccordionControlControl1AccordionControl.UISampleLayoutsAccordionControlGroup.UINwindEmployeesAccordionControlItem;
			#endregion
			Mouse.Click(uINwindEmployeesAccordionControlItem, new Point(0, 0));
		}
		public void ChangeMemoEditTextInNoteTab()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup3TabbedGroupTabHeader = this.UIXtraLayoutFeaturesDeWindow1.UIPanelControl1Client.UIGcContainerClient.UIEmployeesCustom.UILayoutControl1Custom.UIRootLayoutGroup.UITabbedControlGroup1TabbedGroup.UILayoutControlGroup3TabbedGroupTabHeader;
			DXTextEdit uIMemoEdit2Edit = this.UIXtraLayoutFeaturesDeWindow1.UIPanelControl1Client.UIGcContainerClient.UIEmployeesCustom.UILayoutControl1Custom.UIRootLayoutGroup.UITabbedControlGroup1TabbedGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem4LayoutControlItem.UIMemoEdit2Edit;
			#endregion
			Mouse.Click(uILayoutControlGroup3TabbedGroupTabHeader, new Point(33, 11));
			uIMemoEdit2Edit.ValueAsString = this.ChangeMemoEditTextInNoteTabParams.UIMemoEdit2EditValueAsString;
		}
		public void CheckChangedMemoEditValue()
		{
			#region Variable Declarations
			DXTextEdit uIMemoEdit2Edit = this.UIXtraLayoutFeaturesDeWindow1.UIPanelControl1Client.UIGcContainerClient.UIEmployeesCustom.UILayoutControl1Custom.UIRootLayoutGroup.UITabbedControlGroup1TabbedGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem4LayoutControlItem.UIMemoEdit2Edit;
			#endregion
			Assert.AreEqual(this.CheckChangedMemoEditValueExpectedValues.UIMemoEdit2EditValueAsString, uIMemoEdit2Edit.ValueAsString);
		}
		public void CheckNoteTabSelectedState()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup3TabbedGroupTabHeader = this.UIXtraLayoutFeaturesDeWindow1.UIPanelControl1Client.UIGcContainerClient.UIEmployeesCustom.UILayoutControl1Custom.UIRootLayoutGroup.UITabbedControlGroup1TabbedGroup.UILayoutControlGroup3TabbedGroupTabHeader;
			#endregion
			Assert.AreEqual(this.CheckNoteTabSelectedStateExpectedValues.UILayoutControlGroup3TabbedGroupTabHeaderSelected, uILayoutControlGroup3TabbedGroupTabHeader.Selected);
		}
		public void SwitchToMasterDetailDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIMasterDetailAccordionControlItem = this.UIXtraLayoutFeaturesDeWindow.UIGcNavigationsClient.UIAccordionControlControl1AccordionControl.UISampleLayoutsAccordionControlGroup.UIMasterDetailAccordionControlItem;
			#endregion
			Mouse.Click(uIMasterDetailAccordionControlItem, new Point(0, 0));
		}
		public void CollapseAllGroupInMasterDetailDemoModule()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup2LayoutGroupExpandButton = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroupExpandButton;
			DXBaseLayoutItem uILayoutControlGroup3LayoutGroupExpandButton = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroupExpandButton;
			DXBaseLayoutItem uILayoutControlGroup4LayoutGroupExpandButton = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroupExpandButton;
			#endregion
			Mouse.Click(uILayoutControlGroup2LayoutGroupExpandButton, new Point(5, 9));
			Mouse.Click(uILayoutControlGroup3LayoutGroupExpandButton, new Point(7, 9));
			Mouse.Click(uILayoutControlGroup4LayoutGroupExpandButton, new Point(5, 9));
		}
		public void CheckAllGroupCollapsedStateInMasterDetailDemoModule()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup2LayoutGroup = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroup;
			DXBaseLayoutItem uILayoutControlGroup3LayoutGroup = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup;
			DXBaseLayoutItem uILayoutControlGroup4LayoutGroup = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup;
			#endregion
			Assert.AreEqual(this.CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues.UILayoutControlGroup2LayoutGroupExpanded, uILayoutControlGroup2LayoutGroup.Expanded);
			Assert.AreEqual(this.CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues.UILayoutControlGroup3LayoutGroupExpanded, uILayoutControlGroup3LayoutGroup.Expanded);
			Assert.AreEqual(this.CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues.UILayoutControlGroup4LayoutGroupExpanded, uILayoutControlGroup4LayoutGroup.Expanded);
		}
		public void ChangeValuesInCategoriesGroup()
		{
			#region Variable Declarations
			DXTextEdit uITextEdit1Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroup.UILayoutControlItem1LayoutControlItem.UITextEdit1Edit;
			DXTextEdit uIMemoEdit1Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroup.UILayoutControlItem8LayoutControlItem.UIMemoEdit1Edit;
			#endregion
			uITextEdit1Edit.ValueAsString = this.ChangeValuesInCategoriesGroupParams.UITextEdit1EditValueAsString;
			uIMemoEdit1Edit.ValueAsString = this.ChangeValuesInCategoriesGroupParams.UIMemoEdit1EditValueAsString;
		}
		public void CheckCategoriesGroupExpandedState()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup2LayoutGroup = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroup;
			#endregion
			Assert.AreEqual(this.CheckCategoriesGroupExpandedStateExpectedValues.UILayoutControlGroup2LayoutGroupExpanded, uILayoutControlGroup2LayoutGroup.Expanded);
		}
		public void ChangeValuesInProductsGroup()
		{
			#region Variable Declarations
			DXTextEdit uITextEdit2Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem3LayoutControlItem.UITextEdit2Edit;
			DXPopupEdit uICalcEdit1PopupEdit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem11LayoutControlItem.UICalcEdit1PopupEdit;
			DXTextEdit uISpinEdit1Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem12LayoutControlItem.UISpinEdit1Edit;
			DXTextEdit uISpinEdit2Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem13LayoutControlItem.UISpinEdit2Edit;
			#endregion
			uITextEdit2Edit.ValueAsString = this.ChangeValuesInProductsGroupParams.UITextEdit2EditValueAsString;
			uICalcEdit1PopupEdit.ValueAsString = this.ChangeValuesInProductsGroupParams.UICalcEdit1PopupEditValueAsString;
			uISpinEdit1Edit.ValueAsString = this.ChangeValuesInProductsGroupParams.UISpinEdit1EditValueAsString;
			uISpinEdit2Edit.ValueAsString = this.ChangeValuesInProductsGroupParams.UISpinEdit2EditValueAsString;
		}
		public void CheckChangedValuesInCategoriesGroup()
		{
			#region Variable Declarations
			DXTextEdit uITextEdit1Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroup.UILayoutControlItem1LayoutControlItem.UITextEdit1Edit;
			DXTextEdit uIMemoEdit1Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup2LayoutGroup.UILayoutControlItem8LayoutControlItem.UIMemoEdit1Edit;
			#endregion
			Assert.AreEqual(this.CheckChangedValuesInCategoriesGroupExpectedValues.UITextEdit1EditValueAsString, uITextEdit1Edit.ValueAsString);
			Assert.AreEqual(this.CheckChangedValuesInCategoriesGroupExpectedValues.UIMemoEdit1EditValueAsString, uIMemoEdit1Edit.ValueAsString);
		}
		public void CheckProductsGroupExpandedState()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup3LayoutGroup = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup;
			#endregion
			Assert.AreEqual(this.CheckProductsGroupExpandedStateExpectedValues.UILayoutControlGroup3LayoutGroupExpanded, uILayoutControlGroup3LayoutGroup.Expanded);
		}
		public void CheckChangedValuesInProductsGroup()
		{
			#region Variable Declarations
			DXPopupEdit uICalcEdit1PopupEdit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem11LayoutControlItem.UICalcEdit1PopupEdit;
			DXTextEdit uISpinEdit1Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem12LayoutControlItem.UISpinEdit1Edit;
			DXTextEdit uISpinEdit2Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup3LayoutGroup.UILayoutControlItem13LayoutControlItem.UISpinEdit2Edit;
			#endregion
			Assert.AreEqual(this.CheckChangedValuesInProductsGroupExpectedValues.UICalcEdit1PopupEditValueAsString, uICalcEdit1PopupEdit.ValueAsString);
			Assert.AreEqual(this.CheckChangedValuesInProductsGroupExpectedValues.UISpinEdit1EditValueAsString, uISpinEdit1Edit.ValueAsString);
			Assert.AreEqual(this.CheckChangedValuesInProductsGroupExpectedValues.UISpinEdit2EditValueAsString, uISpinEdit2Edit.ValueAsString);
		}
		public void ChangeValuesInOrderDetailGroup()
		{
			#region Variable Declarations
			DXTextEdit uITextEdit3Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup.UILayoutControlItem5LayoutControlItem.UITextEdit3Edit;
			DXPopupEdit uICalcEdit2PopupEdit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup.UILayoutControlItem16LayoutControlItem.UICalcEdit2PopupEdit;
			DXTextEdit uISpinEdit4Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup.UILayoutControlItem17LayoutControlItem.UISpinEdit4Edit;
			#endregion
			uITextEdit3Edit.ValueAsString = this.ChangeValuesInOrderDetailGroupParams.UITextEdit3EditValueAsString;
			uICalcEdit2PopupEdit.ValueAsString = this.ChangeValuesInOrderDetailGroupParams.UICalcEdit2PopupEditValueAsString;
			uISpinEdit4Edit.ValueAsString = this.ChangeValuesInOrderDetailGroupParams.UISpinEdit4EditValueAsString;
		}
		public void CheckOrderDetailGroupExpandedState()
		{
			#region Variable Declarations
			DXBaseLayoutItem uILayoutControlGroup4LayoutGroup = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup;
			#endregion
			Assert.AreEqual(this.CheckOrderDetailGroupExpandedStateExpectedValues.UILayoutControlGroup4LayoutGroupExpanded, uILayoutControlGroup4LayoutGroup.Expanded);
		}
		public void CheckChangedValuesInOrderDetailGroup()
		{
			#region Variable Declarations
			DXTextEdit uITextEdit3Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup.UILayoutControlItem5LayoutControlItem.UITextEdit3Edit;
			DXPopupEdit uICalcEdit2PopupEdit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup.UILayoutControlItem16LayoutControlItem.UICalcEdit2PopupEdit;
			DXTextEdit uISpinEdit4Edit = this.UIXtraLayoutFeaturesDeWindow2.UIPanelControl1Client.UIGcContainerClient.UIMasterDetailCustom.UILayoutControl1Custom.UIRootLayoutGroup.UILayoutControlGroup4LayoutGroup.UILayoutControlItem17LayoutControlItem.UISpinEdit4Edit;
			#endregion
			Assert.AreEqual(this.CheckChangedValuesInOrderDetailGroupExpectedValues.UITextEdit3EditValueAsString, uITextEdit3Edit.ValueAsString);
			Assert.AreEqual(this.CheckChangedValuesInOrderDetailGroupExpectedValues.UICalcEdit2PopupEditValueAsString, uICalcEdit2PopupEdit.ValueAsString);
			Assert.AreEqual(this.CheckChangedValuesInOrderDetailGroupExpectedValues.UISpinEdit4EditValueAsString, uISpinEdit4Edit.ValueAsString);
		}
		public void SwitchToItemsVisibilityDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIItemsVisibilitysimplAccordionControlItem = this.UIXtraLayoutFeaturesDeWindow.UIGcNavigationsClient.UIAccordionControlControl1AccordionControl.UIFeaturesAccordionControlGroup.UIItemsVisibilitysimplAccordionControlItem;
			#endregion
			Mouse.Click(uIItemsVisibilitysimplAccordionControlItem, new Point(0, 0));
		}
		public void MoveHorizontalSplitterToLeft()
		{
			#region Variable Declarations
			DXBaseLayoutItem uISplitterItem1LayoutControlItem = this.UIXtraLayoutFeaturesDeWindow3.UIPanelControl1Client.UIGcContainerClient.UIItemsVisibilityCustom.UILayoutControl1Custom.UILayoutControlGroup1LayoutGroup.UISplitterItem1LayoutControlItem;
			#endregion
			Mouse.StartDragging(uISplitterItem1LayoutControlItem, new Point(0, 128));
			Mouse.StopDragging(uISplitterItem1LayoutControlItem, -237, -19);
		}
		public void MoveVerticalSplitterToBottom()
		{
			#region Variable Declarations
			DXBaseLayoutItem uISplitterItem2LayoutControlItem = this.UIXtraLayoutFeaturesDeWindow3.UIPanelControl1Client.UIGcContainerClient.UIItemsVisibilityCustom.UILayoutControl1Custom.UILayoutControlGroup1LayoutGroup.UISplitterItem2LayoutControlItem;
			#endregion
			Mouse.StartDragging(uISplitterItem2LayoutControlItem, new Point(398, 2));
			Mouse.StopDragging(uISplitterItem2LayoutControlItem, 32, 197);
		}
		#region Properties
		public virtual ChangeMemoEditTextInNoteTabParams ChangeMemoEditTextInNoteTabParams
		{
			get
			{
				if ((this.mChangeMemoEditTextInNoteTabParams == null))
				{
					this.mChangeMemoEditTextInNoteTabParams = new ChangeMemoEditTextInNoteTabParams();
				}
				return this.mChangeMemoEditTextInNoteTabParams;
			}
		}
		public virtual CheckChangedMemoEditValueExpectedValues CheckChangedMemoEditValueExpectedValues
		{
			get
			{
				if ((this.mCheckChangedMemoEditValueExpectedValues == null))
				{
					this.mCheckChangedMemoEditValueExpectedValues = new CheckChangedMemoEditValueExpectedValues();
				}
				return this.mCheckChangedMemoEditValueExpectedValues;
			}
		}
		public virtual CheckNoteTabSelectedStateExpectedValues CheckNoteTabSelectedStateExpectedValues
		{
			get
			{
				if ((this.mCheckNoteTabSelectedStateExpectedValues == null))
				{
					this.mCheckNoteTabSelectedStateExpectedValues = new CheckNoteTabSelectedStateExpectedValues();
				}
				return this.mCheckNoteTabSelectedStateExpectedValues;
			}
		}
		public virtual CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues
		{
			get
			{
				if ((this.mCheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues == null))
				{
					this.mCheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues = new CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues();
				}
				return this.mCheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues;
			}
		}
		public virtual ChangeValuesInCategoriesGroupParams ChangeValuesInCategoriesGroupParams
		{
			get
			{
				if ((this.mChangeValuesInCategoriesGroupParams == null))
				{
					this.mChangeValuesInCategoriesGroupParams = new ChangeValuesInCategoriesGroupParams();
				}
				return this.mChangeValuesInCategoriesGroupParams;
			}
		}
		public virtual CheckCategoriesGroupExpandedStateExpectedValues CheckCategoriesGroupExpandedStateExpectedValues
		{
			get
			{
				if ((this.mCheckCategoriesGroupExpandedStateExpectedValues == null))
				{
					this.mCheckCategoriesGroupExpandedStateExpectedValues = new CheckCategoriesGroupExpandedStateExpectedValues();
				}
				return this.mCheckCategoriesGroupExpandedStateExpectedValues;
			}
		}
		public virtual ChangeValuesInProductsGroupParams ChangeValuesInProductsGroupParams
		{
			get
			{
				if ((this.mChangeValuesInProductsGroupParams == null))
				{
					this.mChangeValuesInProductsGroupParams = new ChangeValuesInProductsGroupParams();
				}
				return this.mChangeValuesInProductsGroupParams;
			}
		}
		public virtual CheckChangedValuesInCategoriesGroupExpectedValues CheckChangedValuesInCategoriesGroupExpectedValues
		{
			get
			{
				if ((this.mCheckChangedValuesInCategoriesGroupExpectedValues == null))
				{
					this.mCheckChangedValuesInCategoriesGroupExpectedValues = new CheckChangedValuesInCategoriesGroupExpectedValues();
				}
				return this.mCheckChangedValuesInCategoriesGroupExpectedValues;
			}
		}
		public virtual CheckProductsGroupExpandedStateExpectedValues CheckProductsGroupExpandedStateExpectedValues
		{
			get
			{
				if ((this.mCheckProductsGroupExpandedStateExpectedValues == null))
				{
					this.mCheckProductsGroupExpandedStateExpectedValues = new CheckProductsGroupExpandedStateExpectedValues();
				}
				return this.mCheckProductsGroupExpandedStateExpectedValues;
			}
		}
		public virtual CheckChangedValuesInProductsGroupExpectedValues CheckChangedValuesInProductsGroupExpectedValues
		{
			get
			{
				if ((this.mCheckChangedValuesInProductsGroupExpectedValues == null))
				{
					this.mCheckChangedValuesInProductsGroupExpectedValues = new CheckChangedValuesInProductsGroupExpectedValues();
				}
				return this.mCheckChangedValuesInProductsGroupExpectedValues;
			}
		}
		public virtual ChangeValuesInOrderDetailGroupParams ChangeValuesInOrderDetailGroupParams
		{
			get
			{
				if ((this.mChangeValuesInOrderDetailGroupParams == null))
				{
					this.mChangeValuesInOrderDetailGroupParams = new ChangeValuesInOrderDetailGroupParams();
				}
				return this.mChangeValuesInOrderDetailGroupParams;
			}
		}
		public virtual CheckOrderDetailGroupExpandedStateExpectedValues CheckOrderDetailGroupExpandedStateExpectedValues
		{
			get
			{
				if ((this.mCheckOrderDetailGroupExpandedStateExpectedValues == null))
				{
					this.mCheckOrderDetailGroupExpandedStateExpectedValues = new CheckOrderDetailGroupExpandedStateExpectedValues();
				}
				return this.mCheckOrderDetailGroupExpandedStateExpectedValues;
			}
		}
		public virtual CheckChangedValuesInOrderDetailGroupExpectedValues CheckChangedValuesInOrderDetailGroupExpectedValues
		{
			get
			{
				if ((this.mCheckChangedValuesInOrderDetailGroupExpectedValues == null))
				{
					this.mCheckChangedValuesInOrderDetailGroupExpectedValues = new CheckChangedValuesInOrderDetailGroupExpectedValues();
				}
				return this.mCheckChangedValuesInOrderDetailGroupExpectedValues;
			}
		}
		public UIXtraLayoutFeaturesDeWindow UIXtraLayoutFeaturesDeWindow
		{
			get
			{
				if ((this.mUIXtraLayoutFeaturesDeWindow == null))
				{
					this.mUIXtraLayoutFeaturesDeWindow = new UIXtraLayoutFeaturesDeWindow();
				}
				return this.mUIXtraLayoutFeaturesDeWindow;
			}
		}
		public UIXtraLayoutFeaturesDeWindow1 UIXtraLayoutFeaturesDeWindow1
		{
			get
			{
				if ((this.mUIXtraLayoutFeaturesDeWindow1 == null))
				{
					this.mUIXtraLayoutFeaturesDeWindow1 = new UIXtraLayoutFeaturesDeWindow1();
				}
				return this.mUIXtraLayoutFeaturesDeWindow1;
			}
		}
		public UIXtraLayoutFeaturesDeWindow2 UIXtraLayoutFeaturesDeWindow2
		{
			get
			{
				if ((this.mUIXtraLayoutFeaturesDeWindow2 == null))
				{
					this.mUIXtraLayoutFeaturesDeWindow2 = new UIXtraLayoutFeaturesDeWindow2();
				}
				return this.mUIXtraLayoutFeaturesDeWindow2;
			}
		}
		public UIXtraLayoutFeaturesDeWindow3 UIXtraLayoutFeaturesDeWindow3
		{
			get
			{
				if ((this.mUIXtraLayoutFeaturesDeWindow3 == null))
				{
					this.mUIXtraLayoutFeaturesDeWindow3 = new UIXtraLayoutFeaturesDeWindow3();
				}
				return this.mUIXtraLayoutFeaturesDeWindow3;
			}
		}
		#endregion
		#region Fields
		private ChangeMemoEditTextInNoteTabParams mChangeMemoEditTextInNoteTabParams;
		private CheckChangedMemoEditValueExpectedValues mCheckChangedMemoEditValueExpectedValues;
		private CheckNoteTabSelectedStateExpectedValues mCheckNoteTabSelectedStateExpectedValues;
		private CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues mCheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues;
		private ChangeValuesInCategoriesGroupParams mChangeValuesInCategoriesGroupParams;
		private CheckCategoriesGroupExpandedStateExpectedValues mCheckCategoriesGroupExpandedStateExpectedValues;
		private ChangeValuesInProductsGroupParams mChangeValuesInProductsGroupParams;
		private CheckChangedValuesInCategoriesGroupExpectedValues mCheckChangedValuesInCategoriesGroupExpectedValues;
		private CheckProductsGroupExpandedStateExpectedValues mCheckProductsGroupExpandedStateExpectedValues;
		private CheckChangedValuesInProductsGroupExpectedValues mCheckChangedValuesInProductsGroupExpectedValues;
		private ChangeValuesInOrderDetailGroupParams mChangeValuesInOrderDetailGroupParams;
		private CheckOrderDetailGroupExpandedStateExpectedValues mCheckOrderDetailGroupExpandedStateExpectedValues;
		private CheckChangedValuesInOrderDetailGroupExpectedValues mCheckChangedValuesInOrderDetailGroupExpectedValues;
		private UIXtraLayoutFeaturesDeWindow mUIXtraLayoutFeaturesDeWindow;
		private UIXtraLayoutFeaturesDeWindow1 mUIXtraLayoutFeaturesDeWindow1;
		private UIXtraLayoutFeaturesDeWindow2 mUIXtraLayoutFeaturesDeWindow2;
		private UIXtraLayoutFeaturesDeWindow3 mUIXtraLayoutFeaturesDeWindow3;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeMemoEditTextInNoteTabParams
	{
		#region Fields
		public string UIMemoEdit2EditValueAsString = "Education includes a BA in psychology from Colorado State University in 1970.  Sh" +
			"e also completed \"The Art of the Cold Call.\"  Nancy is a member of Toastmasters " +
			"International.Test";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckChangedMemoEditValueExpectedValues
	{
		#region Fields
		public string UIMemoEdit2EditValueAsString = "Education includes a BA in psychology from Colorado State University in 1970.  Sh" +
			"e also completed \"The Art of the Cold Call.\"  Nancy is a member of Toastmasters " +
			"International.Test";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckNoteTabSelectedStateExpectedValues
	{
		#region Fields
		public bool UILayoutControlGroup3TabbedGroupTabHeaderSelected = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckAllGroupCollapsedStateInMasterDetailDemoModuleExpectedValues
	{
		#region Fields
		public bool UILayoutControlGroup2LayoutGroupExpanded = false;
		public bool UILayoutControlGroup3LayoutGroupExpanded = false;
		public bool UILayoutControlGroup4LayoutGroupExpanded = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeValuesInCategoriesGroupParams
	{
		#region Fields
		public string UITextEdit1EditValueAsString = "Beverages test";
		public string UIMemoEdit1EditValueAsString = "Soft drinks, coffees, teas, beers, and ales Test description";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckCategoriesGroupExpandedStateExpectedValues
	{
		#region Fields
		public bool UILayoutControlGroup2LayoutGroupExpanded = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeValuesInProductsGroupParams
	{
		#region Fields
		public string UITextEdit2EditValueAsString = "Chai TEST";
		public string UICalcEdit1PopupEditValueAsString = "5 [SelectionStart]0[SelectionLength]1";
		public string UISpinEdit1EditValueAsString = "11";
		public string UISpinEdit2EditValueAsString = "2 [SelectionStart]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckChangedValuesInCategoriesGroupExpectedValues
	{
		#region Fields
		public string UITextEdit1EditValueAsString = "Beverages test";
		public string UIMemoEdit1EditValueAsString = "Soft drinks, coffees, teas, beers, and ales Test description";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckProductsGroupExpandedStateExpectedValues
	{
		#region Fields
		public bool UILayoutControlGroup3LayoutGroupExpanded = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckChangedValuesInProductsGroupExpectedValues
	{
		#region Fields
		public string UICalcEdit1PopupEditValueAsString = "5";
		public string UISpinEdit1EditValueAsString = "11";
		public string UISpinEdit2EditValueAsString = "2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeValuesInOrderDetailGroupParams
	{
		#region Fields
		public string UITextEdit3EditValueAsString = "10777";
		public string UICalcEdit2PopupEditValueAsString = "56 [SelectionStart]0[SelectionLength]2";
		public string UISpinEdit4EditValueAsString = "46";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckOrderDetailGroupExpandedStateExpectedValues
	{
		#region Fields
		public bool UILayoutControlGroup4LayoutGroupExpanded = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckChangedValuesInOrderDetailGroupExpectedValues
	{
		#region Fields
		public string UITextEdit3EditValueAsString = "10777";
		public string UICalcEdit2PopupEditValueAsString = "56";
		public string UISpinEdit4EditValueAsString = "46";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraLayoutFeaturesDeWindow : DXWindow
	{
		public UIXtraLayoutFeaturesDeWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "The XtraLayout Control by DevExpress (C# code)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
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
		#endregion
		#region Fields
		private UIGcNavigationsClient mUIGcNavigationsClient;
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
			#endregion
		}
		#region Properties
		public UIAccordionControlControl1AccordionControl UIAccordionControlControl1AccordionControl
		{
			get
			{
				if ((this.mUIAccordionControlControl1AccordionControl == null))
				{
					this.mUIAccordionControlControl1AccordionControl = new UIAccordionControlControl1AccordionControl(this);
				}
				return this.mUIAccordionControlControl1AccordionControl;
			}
		}
		#endregion
		#region Fields
		private UIAccordionControlControl1AccordionControl mUIAccordionControlControl1AccordionControl;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIAccordionControlControl1AccordionControl : DXTestControl
	{
		public UIAccordionControlControl1AccordionControl(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "accordionControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControl";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
			#endregion
		}
		#region Properties
		public UISampleLayoutsAccordionControlGroup UISampleLayoutsAccordionControlGroup
		{
			get
			{
				if ((this.mUISampleLayoutsAccordionControlGroup == null))
				{
					this.mUISampleLayoutsAccordionControlGroup = new UISampleLayoutsAccordionControlGroup(this);
				}
				return this.mUISampleLayoutsAccordionControlGroup;
			}
		}
		public UIFeaturesAccordionControlGroup UIFeaturesAccordionControlGroup
		{
			get
			{
				if ((this.mUIFeaturesAccordionControlGroup == null))
				{
					this.mUIFeaturesAccordionControlGroup = new UIFeaturesAccordionControlGroup(this);
				}
				return this.mUIFeaturesAccordionControlGroup;
			}
		}
		#endregion
		#region Fields
		private UISampleLayoutsAccordionControlGroup mUISampleLayoutsAccordionControlGroup;
		private UIFeaturesAccordionControlGroup mUIFeaturesAccordionControlGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UISampleLayoutsAccordionControlGroup : DXTestControl
	{
		public UISampleLayoutsAccordionControlGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Sample Layouts";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
			#endregion
		}
		#region Properties
		public DXTestControl UINwindEmployeesAccordionControlItem
		{
			get
			{
				if ((this.mUINwindEmployeesAccordionControlItem == null))
				{
					this.mUINwindEmployeesAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUINwindEmployeesAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Nwind Employees";
					this.mUINwindEmployeesAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUINwindEmployeesAccordionControlItem.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
					#endregion
				}
				return this.mUINwindEmployeesAccordionControlItem;
			}
		}
		public DXTestControl UIMasterDetailAccordionControlItem
		{
			get
			{
				if ((this.mUIMasterDetailAccordionControlItem == null))
				{
					this.mUIMasterDetailAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUIMasterDetailAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Master-Detail";
					this.mUIMasterDetailAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUIMasterDetailAccordionControlItem.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
					#endregion
				}
				return this.mUIMasterDetailAccordionControlItem;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUINwindEmployeesAccordionControlItem;
		private DXTestControl mUIMasterDetailAccordionControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIFeaturesAccordionControlGroup : DXTestControl
	{
		public UIFeaturesAccordionControlGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Features";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIItemsVisibilitysimplAccordionControlItem
		{
			get
			{
				if ((this.mUIItemsVisibilitysimplAccordionControlItem == null))
				{
					this.mUIItemsVisibilitysimplAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUIItemsVisibilitysimplAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Items Visibility (simple)";
					this.mUIItemsVisibilitysimplAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUIItemsVisibilitysimplAccordionControlItem.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code)");
					#endregion
				}
				return this.mUIItemsVisibilitysimplAccordionControlItem;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIItemsVisibilitysimplAccordionControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraLayoutFeaturesDeWindow1 : DXWindow
	{
		public UIXtraLayoutFeaturesDeWindow1()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "The XtraLayout Control by DevExpress (C# code) - Nwind Employees";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
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
		private UIPanelControl1Client mUIPanelControl1Client;
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public UIEmployeesCustom UIEmployeesCustom
		{
			get
			{
				if ((this.mUIEmployeesCustom == null))
				{
					this.mUIEmployeesCustom = new UIEmployeesCustom(this);
				}
				return this.mUIEmployeesCustom;
			}
		}
		#endregion
		#region Fields
		private UIEmployeesCustom mUIEmployeesCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIEmployeesCustom : DXTestControl
	{
		public UIEmployeesCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Employees";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "Employees";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public UILayoutControl1Custom UILayoutControl1Custom
		{
			get
			{
				if ((this.mUILayoutControl1Custom == null))
				{
					this.mUILayoutControl1Custom = new UILayoutControl1Custom(this);
				}
				return this.mUILayoutControl1Custom;
			}
		}
		#endregion
		#region Fields
		private UILayoutControl1Custom mUILayoutControl1Custom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControl1Custom : DXTestControl
	{
		public UILayoutControl1Custom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControl";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public UIRootLayoutGroup UIRootLayoutGroup
		{
			get
			{
				if ((this.mUIRootLayoutGroup == null))
				{
					this.mUIRootLayoutGroup = new UIRootLayoutGroup(this);
				}
				return this.mUIRootLayoutGroup;
			}
		}
		#endregion
		#region Fields
		private UIRootLayoutGroup mUIRootLayoutGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRootLayoutGroup : DXBaseLayoutItem
	{
		public UIRootLayoutGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Root";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public UITabbedControlGroup1TabbedGroup UITabbedControlGroup1TabbedGroup
		{
			get
			{
				if ((this.mUITabbedControlGroup1TabbedGroup == null))
				{
					this.mUITabbedControlGroup1TabbedGroup = new UITabbedControlGroup1TabbedGroup(this);
				}
				return this.mUITabbedControlGroup1TabbedGroup;
			}
		}
		#endregion
		#region Fields
		private UITabbedControlGroup1TabbedGroup mUITabbedControlGroup1TabbedGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UITabbedControlGroup1TabbedGroup : DXBaseLayoutItem
	{
		public UITabbedControlGroup1TabbedGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "tabbedControlGroup1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TabbedGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public DXBaseLayoutItem UILayoutControlGroup3TabbedGroupTabHeader
		{
			get
			{
				if ((this.mUILayoutControlGroup3TabbedGroupTabHeader == null))
				{
					this.mUILayoutControlGroup3TabbedGroupTabHeader = new DXBaseLayoutItem(this);
					#region Search Criteria
					this.mUILayoutControlGroup3TabbedGroupTabHeader.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup3";
					this.mUILayoutControlGroup3TabbedGroupTabHeader.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TabbedGroupTabHeader";
					this.mUILayoutControlGroup3TabbedGroupTabHeader.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
					#endregion
				}
				return this.mUILayoutControlGroup3TabbedGroupTabHeader;
			}
		}
		public UILayoutControlGroup3LayoutGroup UILayoutControlGroup3LayoutGroup
		{
			get
			{
				if ((this.mUILayoutControlGroup3LayoutGroup == null))
				{
					this.mUILayoutControlGroup3LayoutGroup = new UILayoutControlGroup3LayoutGroup(this);
				}
				return this.mUILayoutControlGroup3LayoutGroup;
			}
		}
		#endregion
		#region Fields
		private DXBaseLayoutItem mUILayoutControlGroup3TabbedGroupTabHeader;
		private UILayoutControlGroup3LayoutGroup mUILayoutControlGroup3LayoutGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlGroup3LayoutGroup : DXBaseLayoutItem
	{
		public UILayoutControlGroup3LayoutGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public UILayoutControlItem4LayoutControlItem UILayoutControlItem4LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem4LayoutControlItem == null))
				{
					this.mUILayoutControlItem4LayoutControlItem = new UILayoutControlItem4LayoutControlItem(this);
				}
				return this.mUILayoutControlItem4LayoutControlItem;
			}
		}
		#endregion
		#region Fields
		private UILayoutControlItem4LayoutControlItem mUILayoutControlItem4LayoutControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem4LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem4LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
			#endregion
		}
		#region Properties
		public DXTextEdit UIMemoEdit2Edit
		{
			get
			{
				if ((this.mUIMemoEdit2Edit == null))
				{
					this.mUIMemoEdit2Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUIMemoEdit2Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "memoEdit2";
					this.mUIMemoEdit2Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MemoEdit";
					this.mUIMemoEdit2Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Nwind Employees");
					#endregion
				}
				return this.mUIMemoEdit2Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUIMemoEdit2Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraLayoutFeaturesDeWindow2 : DXWindow
	{
		public UIXtraLayoutFeaturesDeWindow2()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "The XtraLayout Control by DevExpress (C# code) - Master-Detail";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public UIMasterDetailCustom UIMasterDetailCustom
		{
			get
			{
				if ((this.mUIMasterDetailCustom == null))
				{
					this.mUIMasterDetailCustom = new UIMasterDetailCustom(this);
				}
				return this.mUIMasterDetailCustom;
			}
		}
		#endregion
		#region Fields
		private UIMasterDetailCustom mUIMasterDetailCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMasterDetailCustom : DXTestControl
	{
		public UIMasterDetailCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MasterDetail";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MasterDetail";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public UILayoutControl1Custom1 UILayoutControl1Custom
		{
			get
			{
				if ((this.mUILayoutControl1Custom == null))
				{
					this.mUILayoutControl1Custom = new UILayoutControl1Custom1(this);
				}
				return this.mUILayoutControl1Custom;
			}
		}
		#endregion
		#region Fields
		private UILayoutControl1Custom1 mUILayoutControl1Custom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControl1Custom1 : DXTestControl
	{
		public UILayoutControl1Custom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControl";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public UIRootLayoutGroup1 UIRootLayoutGroup
		{
			get
			{
				if ((this.mUIRootLayoutGroup == null))
				{
					this.mUIRootLayoutGroup = new UIRootLayoutGroup1(this);
				}
				return this.mUIRootLayoutGroup;
			}
		}
		#endregion
		#region Fields
		private UIRootLayoutGroup1 mUIRootLayoutGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRootLayoutGroup1 : DXBaseLayoutItem
	{
		public UIRootLayoutGroup1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Root";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXBaseLayoutItem UILayoutControlGroup2LayoutGroupExpandButton
		{
			get
			{
				if ((this.mUILayoutControlGroup2LayoutGroupExpandButton == null))
				{
					this.mUILayoutControlGroup2LayoutGroupExpandButton = new DXBaseLayoutItem(this);
					#region Search Criteria
					this.mUILayoutControlGroup2LayoutGroupExpandButton.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup2";
					this.mUILayoutControlGroup2LayoutGroupExpandButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroupExpandButton";
					this.mUILayoutControlGroup2LayoutGroupExpandButton.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUILayoutControlGroup2LayoutGroupExpandButton;
			}
		}
		public DXBaseLayoutItem UILayoutControlGroup3LayoutGroupExpandButton
		{
			get
			{
				if ((this.mUILayoutControlGroup3LayoutGroupExpandButton == null))
				{
					this.mUILayoutControlGroup3LayoutGroupExpandButton = new DXBaseLayoutItem(this);
					#region Search Criteria
					this.mUILayoutControlGroup3LayoutGroupExpandButton.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup3";
					this.mUILayoutControlGroup3LayoutGroupExpandButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroupExpandButton";
					this.mUILayoutControlGroup3LayoutGroupExpandButton.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUILayoutControlGroup3LayoutGroupExpandButton;
			}
		}
		public DXBaseLayoutItem UILayoutControlGroup4LayoutGroupExpandButton
		{
			get
			{
				if ((this.mUILayoutControlGroup4LayoutGroupExpandButton == null))
				{
					this.mUILayoutControlGroup4LayoutGroupExpandButton = new DXBaseLayoutItem(this);
					#region Search Criteria
					this.mUILayoutControlGroup4LayoutGroupExpandButton.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup4";
					this.mUILayoutControlGroup4LayoutGroupExpandButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroupExpandButton";
					this.mUILayoutControlGroup4LayoutGroupExpandButton.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUILayoutControlGroup4LayoutGroupExpandButton;
			}
		}
		public UILayoutControlGroup2LayoutGroup UILayoutControlGroup2LayoutGroup
		{
			get
			{
				if ((this.mUILayoutControlGroup2LayoutGroup == null))
				{
					this.mUILayoutControlGroup2LayoutGroup = new UILayoutControlGroup2LayoutGroup(this);
				}
				return this.mUILayoutControlGroup2LayoutGroup;
			}
		}
		public UILayoutControlGroup3LayoutGroup1 UILayoutControlGroup3LayoutGroup
		{
			get
			{
				if ((this.mUILayoutControlGroup3LayoutGroup == null))
				{
					this.mUILayoutControlGroup3LayoutGroup = new UILayoutControlGroup3LayoutGroup1(this);
				}
				return this.mUILayoutControlGroup3LayoutGroup;
			}
		}
		public UILayoutControlGroup4LayoutGroup UILayoutControlGroup4LayoutGroup
		{
			get
			{
				if ((this.mUILayoutControlGroup4LayoutGroup == null))
				{
					this.mUILayoutControlGroup4LayoutGroup = new UILayoutControlGroup4LayoutGroup(this);
				}
				return this.mUILayoutControlGroup4LayoutGroup;
			}
		}
		#endregion
		#region Fields
		private DXBaseLayoutItem mUILayoutControlGroup2LayoutGroupExpandButton;
		private DXBaseLayoutItem mUILayoutControlGroup3LayoutGroupExpandButton;
		private DXBaseLayoutItem mUILayoutControlGroup4LayoutGroupExpandButton;
		private UILayoutControlGroup2LayoutGroup mUILayoutControlGroup2LayoutGroup;
		private UILayoutControlGroup3LayoutGroup1 mUILayoutControlGroup3LayoutGroup;
		private UILayoutControlGroup4LayoutGroup mUILayoutControlGroup4LayoutGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlGroup2LayoutGroup : DXBaseLayoutItem
	{
		public UILayoutControlGroup2LayoutGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public UILayoutControlItem1LayoutControlItem UILayoutControlItem1LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem1LayoutControlItem == null))
				{
					this.mUILayoutControlItem1LayoutControlItem = new UILayoutControlItem1LayoutControlItem(this);
				}
				return this.mUILayoutControlItem1LayoutControlItem;
			}
		}
		public UILayoutControlItem8LayoutControlItem UILayoutControlItem8LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem8LayoutControlItem == null))
				{
					this.mUILayoutControlItem8LayoutControlItem = new UILayoutControlItem8LayoutControlItem(this);
				}
				return this.mUILayoutControlItem8LayoutControlItem;
			}
		}
		#endregion
		#region Fields
		private UILayoutControlItem1LayoutControlItem mUILayoutControlItem1LayoutControlItem;
		private UILayoutControlItem8LayoutControlItem mUILayoutControlItem8LayoutControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem1LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem1LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UITextEdit1Edit
		{
			get
			{
				if ((this.mUITextEdit1Edit == null))
				{
					this.mUITextEdit1Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUITextEdit1Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "textEdit1";
					this.mUITextEdit1Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TextEdit";
					this.mUITextEdit1Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUITextEdit1Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUITextEdit1Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem8LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem8LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem8";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UIMemoEdit1Edit
		{
			get
			{
				if ((this.mUIMemoEdit1Edit == null))
				{
					this.mUIMemoEdit1Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUIMemoEdit1Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "memoEdit1";
					this.mUIMemoEdit1Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MemoEdit";
					this.mUIMemoEdit1Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUIMemoEdit1Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUIMemoEdit1Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlGroup3LayoutGroup1 : DXBaseLayoutItem
	{
		public UILayoutControlGroup3LayoutGroup1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public UILayoutControlItem3LayoutControlItem UILayoutControlItem3LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem3LayoutControlItem == null))
				{
					this.mUILayoutControlItem3LayoutControlItem = new UILayoutControlItem3LayoutControlItem(this);
				}
				return this.mUILayoutControlItem3LayoutControlItem;
			}
		}
		public UILayoutControlItem11LayoutControlItem UILayoutControlItem11LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem11LayoutControlItem == null))
				{
					this.mUILayoutControlItem11LayoutControlItem = new UILayoutControlItem11LayoutControlItem(this);
				}
				return this.mUILayoutControlItem11LayoutControlItem;
			}
		}
		public UILayoutControlItem12LayoutControlItem UILayoutControlItem12LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem12LayoutControlItem == null))
				{
					this.mUILayoutControlItem12LayoutControlItem = new UILayoutControlItem12LayoutControlItem(this);
				}
				return this.mUILayoutControlItem12LayoutControlItem;
			}
		}
		public UILayoutControlItem13LayoutControlItem UILayoutControlItem13LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem13LayoutControlItem == null))
				{
					this.mUILayoutControlItem13LayoutControlItem = new UILayoutControlItem13LayoutControlItem(this);
				}
				return this.mUILayoutControlItem13LayoutControlItem;
			}
		}
		#endregion
		#region Fields
		private UILayoutControlItem3LayoutControlItem mUILayoutControlItem3LayoutControlItem;
		private UILayoutControlItem11LayoutControlItem mUILayoutControlItem11LayoutControlItem;
		private UILayoutControlItem12LayoutControlItem mUILayoutControlItem12LayoutControlItem;
		private UILayoutControlItem13LayoutControlItem mUILayoutControlItem13LayoutControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem3LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem3LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UITextEdit2Edit
		{
			get
			{
				if ((this.mUITextEdit2Edit == null))
				{
					this.mUITextEdit2Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUITextEdit2Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "textEdit2";
					this.mUITextEdit2Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TextEdit";
					this.mUITextEdit2Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUITextEdit2Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUITextEdit2Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem11LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem11LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem11";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			#endregion
		}
		#region Properties
		public DXPopupEdit UICalcEdit1PopupEdit
		{
			get
			{
				if ((this.mUICalcEdit1PopupEdit == null))
				{
					this.mUICalcEdit1PopupEdit = new DXPopupEdit(this);
					#region Search Criteria
					this.mUICalcEdit1PopupEdit.SearchProperties[DXTestControl.PropertyNames.Name] = "calcEdit1";
					this.mUICalcEdit1PopupEdit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "CalcEdit";
					#endregion
				}
				return this.mUICalcEdit1PopupEdit;
			}
		}
		#endregion
		#region Fields
		private DXPopupEdit mUICalcEdit1PopupEdit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem12LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem12LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem12";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UISpinEdit1Edit
		{
			get
			{
				if ((this.mUISpinEdit1Edit == null))
				{
					this.mUISpinEdit1Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUISpinEdit1Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "spinEdit1";
					this.mUISpinEdit1Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SpinEdit";
					this.mUISpinEdit1Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUISpinEdit1Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUISpinEdit1Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem13LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem13LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem13";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UISpinEdit2Edit
		{
			get
			{
				if ((this.mUISpinEdit2Edit == null))
				{
					this.mUISpinEdit2Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUISpinEdit2Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "spinEdit2";
					this.mUISpinEdit2Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SpinEdit";
					this.mUISpinEdit2Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUISpinEdit2Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUISpinEdit2Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlGroup4LayoutGroup : DXBaseLayoutItem
	{
		public UILayoutControlGroup4LayoutGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public UILayoutControlItem5LayoutControlItem UILayoutControlItem5LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem5LayoutControlItem == null))
				{
					this.mUILayoutControlItem5LayoutControlItem = new UILayoutControlItem5LayoutControlItem(this);
				}
				return this.mUILayoutControlItem5LayoutControlItem;
			}
		}
		public UILayoutControlItem16LayoutControlItem UILayoutControlItem16LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem16LayoutControlItem == null))
				{
					this.mUILayoutControlItem16LayoutControlItem = new UILayoutControlItem16LayoutControlItem(this);
				}
				return this.mUILayoutControlItem16LayoutControlItem;
			}
		}
		public UILayoutControlItem17LayoutControlItem UILayoutControlItem17LayoutControlItem
		{
			get
			{
				if ((this.mUILayoutControlItem17LayoutControlItem == null))
				{
					this.mUILayoutControlItem17LayoutControlItem = new UILayoutControlItem17LayoutControlItem(this);
				}
				return this.mUILayoutControlItem17LayoutControlItem;
			}
		}
		#endregion
		#region Fields
		private UILayoutControlItem5LayoutControlItem mUILayoutControlItem5LayoutControlItem;
		private UILayoutControlItem16LayoutControlItem mUILayoutControlItem16LayoutControlItem;
		private UILayoutControlItem17LayoutControlItem mUILayoutControlItem17LayoutControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem5LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem5LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem5";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UITextEdit3Edit
		{
			get
			{
				if ((this.mUITextEdit3Edit == null))
				{
					this.mUITextEdit3Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUITextEdit3Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "textEdit3";
					this.mUITextEdit3Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TextEdit";
					this.mUITextEdit3Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUITextEdit3Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUITextEdit3Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem16LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem16LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem16";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			#endregion
		}
		#region Properties
		public DXPopupEdit UICalcEdit2PopupEdit
		{
			get
			{
				if ((this.mUICalcEdit2PopupEdit == null))
				{
					this.mUICalcEdit2PopupEdit = new DXPopupEdit(this);
					#region Search Criteria
					this.mUICalcEdit2PopupEdit.SearchProperties[DXTestControl.PropertyNames.Name] = "calcEdit2";
					this.mUICalcEdit2PopupEdit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "CalcEdit";
					#endregion
				}
				return this.mUICalcEdit2PopupEdit;
			}
		}
		#endregion
		#region Fields
		private DXPopupEdit mUICalcEdit2PopupEdit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlItem17LayoutControlItem : DXBaseLayoutItem
	{
		public UILayoutControlItem17LayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlItem17";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
			#endregion
		}
		#region Properties
		public DXTextEdit UISpinEdit4Edit
		{
			get
			{
				if ((this.mUISpinEdit4Edit == null))
				{
					this.mUISpinEdit4Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUISpinEdit4Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "spinEdit4";
					this.mUISpinEdit4Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SpinEdit";
					this.mUISpinEdit4Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Master-Detail");
					#endregion
				}
				return this.mUISpinEdit4Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUISpinEdit4Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraLayoutFeaturesDeWindow3 : DXWindow
	{
		public UIXtraLayoutFeaturesDeWindow3()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
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
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public UIItemsVisibilityCustom UIItemsVisibilityCustom
		{
			get
			{
				if ((this.mUIItemsVisibilityCustom == null))
				{
					this.mUIItemsVisibilityCustom = new UIItemsVisibilityCustom(this);
				}
				return this.mUIItemsVisibilityCustom;
			}
		}
		#endregion
		#region Fields
		private UIItemsVisibilityCustom mUIItemsVisibilityCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemsVisibilityCustom : DXTestControl
	{
		public UIItemsVisibilityCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ItemsVisibility";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ItemsVisibility";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public UILayoutControl1Custom2 UILayoutControl1Custom
		{
			get
			{
				if ((this.mUILayoutControl1Custom == null))
				{
					this.mUILayoutControl1Custom = new UILayoutControl1Custom2(this);
				}
				return this.mUILayoutControl1Custom;
			}
		}
		#endregion
		#region Fields
		private UILayoutControl1Custom2 mUILayoutControl1Custom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControl1Custom2 : DXTestControl
	{
		public UILayoutControl1Custom2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControl";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public UILayoutControlGroup1LayoutGroup UILayoutControlGroup1LayoutGroup
		{
			get
			{
				if ((this.mUILayoutControlGroup1LayoutGroup == null))
				{
					this.mUILayoutControlGroup1LayoutGroup = new UILayoutControlGroup1LayoutGroup(this);
				}
				return this.mUILayoutControlGroup1LayoutGroup;
			}
		}
		#endregion
		#region Fields
		private UILayoutControlGroup1LayoutGroup mUILayoutControlGroup1LayoutGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UILayoutControlGroup1LayoutGroup : DXBaseLayoutItem
	{
		public UILayoutControlGroup1LayoutGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "layoutControlGroup1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutGroup";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public UIPicture1ItemLayoutControlItem UIPicture1ItemLayoutControlItem
		{
			get
			{
				if ((this.mUIPicture1ItemLayoutControlItem == null))
				{
					this.mUIPicture1ItemLayoutControlItem = new UIPicture1ItemLayoutControlItem(this);
				}
				return this.mUIPicture1ItemLayoutControlItem;
			}
		}
		public UIPicture2ItemLayoutControlItem UIPicture2ItemLayoutControlItem
		{
			get
			{
				if ((this.mUIPicture2ItemLayoutControlItem == null))
				{
					this.mUIPicture2ItemLayoutControlItem = new UIPicture2ItemLayoutControlItem(this);
				}
				return this.mUIPicture2ItemLayoutControlItem;
			}
		}
		public UIDescriptionItemLayoutControlItem UIDescriptionItemLayoutControlItem
		{
			get
			{
				if ((this.mUIDescriptionItemLayoutControlItem == null))
				{
					this.mUIDescriptionItemLayoutControlItem = new UIDescriptionItemLayoutControlItem(this);
				}
				return this.mUIDescriptionItemLayoutControlItem;
			}
		}
		public DXBaseLayoutItem UISplitterItem1LayoutControlItem
		{
			get
			{
				if ((this.mUISplitterItem1LayoutControlItem == null))
				{
					this.mUISplitterItem1LayoutControlItem = new DXBaseLayoutItem(this);
					#region Search Criteria
					this.mUISplitterItem1LayoutControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "splitterItem1";
					this.mUISplitterItem1LayoutControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
					this.mUISplitterItem1LayoutControlItem.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
					#endregion
				}
				return this.mUISplitterItem1LayoutControlItem;
			}
		}
		public DXBaseLayoutItem UISplitterItem2LayoutControlItem
		{
			get
			{
				if ((this.mUISplitterItem2LayoutControlItem == null))
				{
					this.mUISplitterItem2LayoutControlItem = new DXBaseLayoutItem(this);
					#region Search Criteria
					this.mUISplitterItem2LayoutControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "splitterItem2";
					this.mUISplitterItem2LayoutControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
					this.mUISplitterItem2LayoutControlItem.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
					#endregion
				}
				return this.mUISplitterItem2LayoutControlItem;
			}
		}
		#endregion
		#region Fields
		private UIPicture1ItemLayoutControlItem mUIPicture1ItemLayoutControlItem;
		private UIPicture2ItemLayoutControlItem mUIPicture2ItemLayoutControlItem;
		private UIDescriptionItemLayoutControlItem mUIDescriptionItemLayoutControlItem;
		private DXBaseLayoutItem mUISplitterItem1LayoutControlItem;
		private DXBaseLayoutItem mUISplitterItem2LayoutControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPicture1ItemLayoutControlItem : DXBaseLayoutItem
	{
		public UIPicture1ItemLayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "picture1Item";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public DXTestControl UIPictureEdit2Image
		{
			get
			{
				if ((this.mUIPictureEdit2Image == null))
				{
					this.mUIPictureEdit2Image = new DXTestControl(this);
					#region Search Criteria
					this.mUIPictureEdit2Image.SearchProperties[DXTestControl.PropertyNames.Name] = "pictureEdit2";
					this.mUIPictureEdit2Image.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PictureEdit";
					this.mUIPictureEdit2Image.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
					#endregion
				}
				return this.mUIPictureEdit2Image;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIPictureEdit2Image;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPicture2ItemLayoutControlItem : DXBaseLayoutItem
	{
		public UIPicture2ItemLayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "picture2Item";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public DXTestControl UIPictureEdit1Image
		{
			get
			{
				if ((this.mUIPictureEdit1Image == null))
				{
					this.mUIPictureEdit1Image = new DXTestControl(this);
					#region Search Criteria
					this.mUIPictureEdit1Image.SearchProperties[DXTestControl.PropertyNames.Name] = "pictureEdit1";
					this.mUIPictureEdit1Image.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PictureEdit";
					this.mUIPictureEdit1Image.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
					#endregion
				}
				return this.mUIPictureEdit1Image;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIPictureEdit1Image;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDescriptionItemLayoutControlItem : DXBaseLayoutItem
	{
		public UIDescriptionItemLayoutControlItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "descriptionItem";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LayoutControlItem";
			this.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
			#endregion
		}
		#region Properties
		public DXTextEdit UIMemoEdit1Edit
		{
			get
			{
				if ((this.mUIMemoEdit1Edit == null))
				{
					this.mUIMemoEdit1Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUIMemoEdit1Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "memoEdit1";
					this.mUIMemoEdit1Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MemoEdit";
					this.mUIMemoEdit1Edit.WindowTitles.Add("The XtraLayout Control by DevExpress (C# code) - Items Visibility (simple)");
					#endregion
				}
				return this.mUIMemoEdit1Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUIMemoEdit1Edit;
		#endregion
	}
}
