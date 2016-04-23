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

namespace DevExpress.Win.FunctionalTests.UIMaps.DockingPanelsUIMapClasses
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
	using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
	using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
	using MouseButtons = System.Windows.Forms.MouseButtons;
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public partial class DockingPanelsUIMap
	{
		public void CheckHiddenUnpinnedPanel()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow2.UIBottomAutoHideContaiClient.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckHiddenUnpinnedPanelExpectedValues.UIPanelContainer2ClientLocation, uIPanelContainer2Client.GetProperty("Location").ToString());
		}
		public void CheckDisplayedPinnedPanel()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel6Client = this.UIDockingDemoCDemoWindow5.UIDockPanel6Client;
			#endregion
			Assert.AreEqual(this.CheckDisplayedPinnedPanelExpectedValues.UIDockPanel6ClientDockStyle, uIDockPanel6Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
		}
		public void ClosePanelViaClickCloseButton()
		{
			#region Variable Declarations
			DXButton uICloseButtonButton = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UICloseButtonButton;
			#endregion
			Mouse.Click(uICloseButtonButton, new Point(8, 5));
		}
		public void ClickPanelCaptionForCheckClosingPanel()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel2Client = this.UIDockingDemoCDemoWindow7.UIDockPanel2Client;
			#endregion
			Mouse.Click(uIDockPanel2Client, new Point(139, 11));
		}
		public void RestoreClosedPanelViaClickBar()
		{
			#region Variable Declarations
			DXMenuBaseButtonItem uISolutionExplorerBarBaseButtonItem = this.UIDockingDemoCDemoWindow8.UIBarDockControlCustom.UIViewMenuBar.UISolutionExplorerBarBaseButtonItem;
			#endregion
			uISolutionExplorerBarBaseButtonItem.PerformClick = this.RestoreClosedPanelViaClickBarParams.UISolutionExplorerBarBaseButtonItemPerformClick;
		}
		public void CheckPanelButtonLocation()
		{
			#region Variable Declarations
			DXButton uIDockPanel4Button = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UIDockPanel4Button;
			#endregion
			Assert.AreEqual(this.CheckPanelButtonLocationExpectedValues.UIDockPanel4ButtonLocation, uIDockPanel4Button.GetProperty("Location").ToString());
		}
		public void DockPanelToTopEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToTopEdgeOfFormParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void DockPanelToRightEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToRightEdgeOfFormParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void DockPanelToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToTopEdgeParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckWidth()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckWidthExpectedValues.UIPanelContainer2ClientSize, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.Size).ToString());
		}
		public void DockPanelToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToRightEdgeParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void DockPanelToBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIDockingDemoCDemoWindow6.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.DockPanelToBottomEdgeParams.UIDockPanelClientDockInfoAsString;
		}
		public void MakePanelFloatViaDragging()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.MakePanelFloatViaDraggingParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckFloatPanelDockStyle()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckFloatPanelDockStyleExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
		}
		public void MakePanelFloatViaDoubleClickPanelCaption()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Mouse.DoubleClick(uIPanelContainer2Client, new Point(102, 15));
		}
		public void RestorePanelDockStyleViaDoubleClickPanelCaption()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client;
			#endregion
			Mouse.DoubleClick(uIPanelContainer2Client, new Point(166, 13));
		}
		public void CheckPanelRestoredDockStyle()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelRestoredDockStyleExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
		}
		public void ClickPanelMaximizeButton()
		{
			#region Variable Declarations
			DXButton uIMaximizeButtonButton = this.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client.UIMaximizeButtonButton;
			#endregion
			Mouse.Click(uIMaximizeButtonButton, new Point(7, 5));
		}
		public void UnpinPanelViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			DXMenuBaseButtonItem uIAutoHideMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIAutoHideMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIPanelContainer2Client, MouseButtons.Right, ModifierKeys.None, new Point(705, 15));
			Mouse.Click(uIAutoHideMenuBaseButtonItem, new Point(84, 13));
		}
		public void RestorePanelDockStyleViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client;
			DXMenuBaseButtonItem uIDockMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIDockMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIPanelContainer2Client, MouseButtons.Right, ModifierKeys.None, new Point(142, 14));
			Mouse.Click(uIDockMenuBaseButtonItem, new Point(79, 15));
		}
		public void ClosePanelContainerViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIDockingDemoCDemoWindow6.UIDockPanelClient;
			DXMenuBaseButtonItem uICloseMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UICloseMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIDockPanelClient, MouseButtons.Right, ModifierKeys.None, new Point(135, 11));
			Mouse.Click(uICloseMenuBaseButtonItem, new Point(55, 9));
		}
		public void DockPanelToFormWithCreatingNewTabViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			DXMenuBaseButtonItem uIDockasTabbedDocumentMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIDockasTabbedDocumentMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIPanelContainer2Client, MouseButtons.Right, ModifierKeys.None, new Point(154, 10));
			Mouse.Click(uIDockasTabbedDocumentMenuBaseButtonItem, new Point(79, 14));
		}
		public void DockFloatPanelToFormWithCreatingNewTabViaContextMenu()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client;
			DXMenuBaseButtonItem uIDockasTabbedDocumentMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIDockasTabbedDocumentMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIPanelContainer2Client, MouseButtons.Right, ModifierKeys.None, new Point(123, 13));
			Mouse.Click(uIDockasTabbedDocumentMenuBaseButtonItem, new Point(88, 18));
		}
		public void CheckPanelDockStyleDockedToLeftEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void DockPanelToLeftEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToLeftEdgeOfFormParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckPanelDockStyleDockedToRightEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void CheckPanelDockStyleDockedToTopEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void DockPanelToBottomEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIDockingDemoCDemoWindow6.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.DockPanelToBottomEdgeOfFormParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckPanelDockStyleDockedToBottomEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void DockPanelToLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToLeftEdgeParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckPanelDockStyleDockedToLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToLeftEdgeExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToLeftEdgeExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToLeftEdgeExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void CheckPanelDockStyleDockedToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToRightEdgeExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToRightEdgeExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToRightEdgeExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void CheckPanelDockStyleDockedToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToTopEdgeExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToTopEdgeExpectedValues.UIPanelContainer2ClientIsTab, uIPanelContainer2Client.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToTopEdgeExpectedValues.UIPanelContainer2ClientIndex, uIPanelContainer2Client.Index);
		}
		public void CheckPanelDockStyleDockedToBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIDockingDemoCDemoWindow6.UIDockPanelClient;
			#endregion
			Assert.AreEqual(this.CheckPanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClientDockStyle, uIDockPanelClient.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckPanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClientIsTab, uIDockPanelClient.IsTab);
			Assert.AreEqual(this.CheckPanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClientIndex, uIDockPanelClient.Index);
		}
		public void SwitchToDockPanelsDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelsAccordionControlItem = this.UIApplicationUIWindow.UIGcNavigationsClient.UIAccordionControl1AccordionControl.UIDockingUIAccordionControlGroup.UIDockPanelsAccordionControlItem;
			#endregion
			Mouse.Click(uIDockPanelsAccordionControlItem, new Point(0, 0));
		}
		public void AddTwoSimpleDockPanels()
		{
			#region Variable Declarations
			DXButton uISbAddPanelButton = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlLeftClient.UIPnlControlsClient.UISbAddPanelButton;
			#endregion
			Mouse.Click(uISbAddPanelButton, new Point(1, 1));
			Mouse.Click(uISbAddPanelButton, new Point(1, 1));
		}
		public void DockSimplePanelToTopEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.DockSimplePanelToTopEdgeOfFormParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToTopEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient1;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
		}
		public void DockSimplePanelToLeftEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel1Client = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanel1Client;
			#endregion
			uIDockPanel1Client.DockInfoAsString = this.DockSimplePanelToLeftEdgeOfFormParams.UIDockPanel1ClientDockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToLeftEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel1Client = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanel1Client;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues.UIDockPanel1ClientDockStyle, uIDockPanel1Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues.UIDockPanel1ClientIsTab, uIDockPanel1Client.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues.UIDockPanel1ClientIndex, uIDockPanel1Client.Index);
		}
		public void DockSimplePanelToRightEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.DockSimplePanelToRightEdgeOfFormParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToRightEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient1;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
		}
		public void DockSimplePanelToBottomEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.DockSimplePanelToBottomEdgeOfFormParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToBottomEdgeOfForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient1;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
		}
		public void DockSimplePanelToLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel1Client = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanel1Client;
			#endregion
			uIDockPanel1Client.DockInfoAsString = this.DockSimplePanelToLeftEdgeParams.UIDockPanel1ClientDockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel1Client = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanel1Client;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues.UIDockPanel1ClientDockStyle, uIDockPanel1Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues.UIDockPanel1ClientIsTab, uIDockPanel1Client.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues.UIDockPanel1ClientIndex, uIDockPanel1Client.Index);
		}
		public void DockSimplePanelToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.DockSimplePanelToRightEdgeParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues.UIDockPanelClient2DockStyle, uIDockPanelClient2.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues.UIDockPanelClient2IsTab, uIDockPanelClient2.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues.UIDockPanelClient2Index, uIDockPanelClient2.Index);
		}
		public void DockSimplePanelToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.DockSimplePanelToTopEdgeParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient1;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues.UIDockPanelClient1ParentName, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.ParentName).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
		}
		public void DockSimplePanelToBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.DockSimplePanelToBottomEdgeParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient11 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient11;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClient11ParentName, uIDockPanelClient11.GetProperty(DXTestControl.PropertyNames.ParentName).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClient11DockStyle, uIDockPanelClient11.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClient11IsTab, uIDockPanelClient11.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues.UIDockPanelClient11Index, uIDockPanelClient11.Index);
		}
		public void CreateTabContainerViaDockPanelToAnotherPanel()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.CreateTabContainerViaDockPanelToAnotherPanelParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckSimplePanelDockStyleDockedToAnotherPanel()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient.UIDockPanelClient1;
			#endregion
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues.UIDockPanelClient1ParentName, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.ParentName).ToString());
			Assert.AreEqual(this.CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
		}
		public void SwitchToDocumentManagerDockingDemoModule()
		{
			#region Variable Declarations
			DXListBox uIListBoxControl1List = this.UIApplicationUIWindow.UIGcNavigationsClient.UIListBoxControl1List;
			#endregion
			uIListBoxControl1List.SelectedIndicesAsString = this.SwitchToDocumentManagerDockingDemoModuleParams.UIListBoxControl1ListSelectedIndicesAsString;
		}
		public void ClickLaunchSampleButton()
		{
			#region Variable Declarations
			DXButton uISbStartButton = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UISampleStartCustom.UISbStartButton;
			#endregion
			Mouse.Click(uISbStartButton, new Point(1, 1));
		}
		public void ClickDocumentManagerTabPreviousButton()
		{
			#region Variable Declarations
			DXButton uIPrevButton = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIItem0Group.UIPrevButton;
			#endregion
			Mouse.Click(uIPrevButton, new Point(7, 9));
		}
		public void ClickFirstDocumentManagerTab()
		{
			#region Variable Declarations
			DXTestControl uIDocument0csTabPage = this.UIDocumentManagerDockiWindow.UIMdiClientTabList.UIDocument0csTabPage;
			#endregion
			Mouse.Click(uIDocument0csTabPage, new Point(63, 11));
		}
		public void MakeDocumentFormFloatViaDragging()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.MakeDocumentFormFloatViaDraggingParams.UIDocument0TabPageDockInfoAsString;
		}
		public void MakeDocumentFormFloatViaDoubleClickCaption()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Mouse.DoubleClick(uIDocument0TabPage, new Point(64, 13));
		}
		public void MakeDocumentFormFloatViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			DXMenuBaseButtonItem uIBarButtonItemLink2MenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIBarButtonItemLink2MenuBaseButtonItem;
			#endregion
			Mouse.Click(uIDocument0TabPage, MouseButtons.Right, ModifierKeys.None, new Point(48, 15));
			Mouse.Click(uIBarButtonItemLink2MenuBaseButtonItem, new Point(56, 11));
		}
		public void DockDocumentFormToLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.DockDocumentFormToLeftEdgeParams.UIDocument0TabPageDockInfoAsString;
		}
		public void DockDocumentFormToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.DockDocumentFormToRightEdgeParams.UIDocument0TabPageDockInfoAsString;
		}
		public void DockDocumentFormToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.DockDocumentFormToTopEdgeParams.UIDocument0TabPageDockInfoAsString;
		}
		public void DockDocumentFormToBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.DockDocumentFormToBottomEdgeParams.UIDocument0TabPageDockInfoAsString;
		}
		public void ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherForm()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams.UIDocument0TabPageDockInfoAsString;
		}
		public void ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaption()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams.UIDocument0TabPageDockInfoAsString;
		}
		public void MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel3DockPanel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDockPanel3DockPanel;
			#endregion
			uIDockPanel3DockPanel.DockInfoAsString = this.MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams.UIDockPanel3DockPanelDockInfoAsString;
		}
		public void MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel2DockPanel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIPanelContainer1DockPanel.UIDockPanel2DockPanel;
			#endregion
			uIDockPanel2DockPanel.DockInfoAsString = this.MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams.UIDockPanel2DockPanelDockInfoAsString;
		}
		public void MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel1DockPanel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIPanelContainer1DockPanel.UIDockPanel1DockPanel;
			#endregion
			uIDockPanel1DockPanel.DockInfoAsString = this.MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams.UIDockPanel1DockPanelDockInfoAsString;
		}
		public void MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel1DockPanel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIPanelContainer1DockPanel.UIDockPanel1DockPanel;
			#endregion
			uIDockPanel1DockPanel.DockInfoAsString = this.MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams.UIDockPanel1DockPanelDockInfoAsString;
		}
		public void DockPanelToDocumentForm()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel1DockPanel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIPanelContainer1DockPanel.UIDockPanel1DockPanel;
			#endregion
			uIDockPanel1DockPanel.DockInfoAsString = this.DockPanelToDocumentFormParams.UIDockPanel1DockPanelDockInfoAsString;
		}
		public void DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTab()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel1DockPanel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIPanelContainer1DockPanel.UIDockPanel1DockPanel;
			#endregion
			uIDockPanel1DockPanel.DockInfoAsString = this.DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams.UIDockPanel1DockPanelDockInfoAsString;
		}
		public void ClickDocumentManagerTabNextButton()
		{
			#region Variable Declarations
			DXButton uINextButton = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIItem0Group.UINextButton;
			#endregion
			Mouse.Click(uINextButton, new Point(9, 7));
		}
		public void ClickDocumentTabForAssertNextButton()
		{
			#region Variable Declarations
			DXTestControl uIDocument2csTabPage = this.UIDocumentManagerDockiWindow.UIMdiClientTabList.UIDocument2csTabPage;
			#endregion
			Mouse.Click(uIDocument2csTabPage, new Point(65, 9));
		}
		public void CloseAllDocumentViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIDocumentsHostTabList = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList;
			DXMenuBaseButtonItem uIBarButtonItemLink0MenuBaseButtonItem1 = this.UIItemWindow.UIPopupMenuBarControlMenu.UIBarButtonItemLink0MenuBaseButtonItem1;
			#endregion
			Mouse.Click(uIDocumentsHostTabList, MouseButtons.Right, ModifierKeys.None, new Point(242, 14));
			Mouse.Click(uIBarButtonItemLink0MenuBaseButtonItem1, new Point(24, 14));
		}
		public void ShowDialogWindowsForm()
		{
			#region Variable Declarations
			DXTestControl uIDocumentsHostTabList = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList;
			DXMenuBaseButtonItem uIBarButtonItemLink0MenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIBarButtonItemLink0MenuBaseButtonItem;
			#endregion
			Mouse.Click(uIDocumentsHostTabList, MouseButtons.Right, ModifierKeys.None, new Point(242, 15));
			Mouse.Click(uIBarButtonItemLink0MenuBaseButtonItem, new Point(33, 8));
		}
		public void MakeDocumentFormActiveViaDialogWindowsForm()
		{
			#region Variable Declarations
			WinClient uIDocumentListBoxClient = this.UIWindowsWindow.UIPanelControl2Client.UIDocumentListBoxCustom.UIDocumentListBoxClient;
			DXButton uISimpleButtonButton = this.UIItemWindow1.UIPanelControlClient.UISimpleButtonButton;
			#endregion
			Mouse.Click(uIDocumentListBoxClient, new Point(127, 62));
			Mouse.Click(uISimpleButtonButton, new Point(1, 1));
		}
		public void CloseDocumentFormViaDialogWindowsForm()
		{
			#region Variable Declarations
			WinClient uIDocumentListBoxClient = this.UIWindowsWindow.UIPnlListClient.UIDocumentListBoxCustom.UIDocumentListBoxClient;
			DXButton uICloseDocumentButton = this.UIItemWindow1.UIPnlCommandsClient.UICloseDocumentButton;
			DXButton uISimpleButtonButton = this.UIItemWindow.UICloseDocumentWindow.UISimpleButtonButton;
			DXButton uIOKButton = this.UIItemWindow1.UIPnlCommandsClient.UIOKButton;
			#endregion
			Mouse.Click(uIDocumentListBoxClient, new Point(18, 30));
			Mouse.Click(uICloseDocumentButton, new Point(1, 1));
			Mouse.Click(uISimpleButtonButton, new Point(1, 1));
			Mouse.Click(uIOKButton, new Point(1, 1));
		}
		public void CloseAllDocumentFormViaDialogWindowsForm()
		{
			#region Variable Declarations
			DXButton uICloseAllDocumentsButton = this.UIItemWindow1.UIPnlCommandsClient.UICloseAllDocumentsButton;
			DXButton uISimpleButtonButton = this.UIItemWindow.UICloseAllDocumentsWindow.UISimpleButtonButton;
			#endregion
			Mouse.Click(uICloseAllDocumentsButton, new Point(1, 1));
			Mouse.Click(uISimpleButtonButton, new Point(1, 1));
		}
		public void SwitchToDocumentManagerNativeMdiViewDemoModule()
		{
			#region Variable Declarations
			DXListBox uIListBoxControl1List = this.UIApplicationUIWindow.UIGcNavigationsClient.UIListBoxControl1List;
			#endregion
			uIListBoxControl1List.SelectedIndicesAsString = this.SwitchToDocumentManagerNativeMdiViewDemoModuleParams.UIListBoxControl1ListSelectedIndicesAsString;
		}
		public void AddNewDocumentFormViaClickAddNewDocumentBar()
		{
			#region Variable Declarations
			DXRibbonButtonItem uIAddNewDocumentRibbonBaseButtonItem = this.UIApplicationUILayoutCWindow1.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup1RibbonPageGroup.UIAddNewDocumentRibbonBaseButtonItem;
			#endregion
			Mouse.Click(uIAddNewDocumentRibbonBaseButtonItem, new Point(29, 24));
		}
		public void SwitchToDocumentManagerTabbedViewDemoModule()
		{
			#region Variable Declarations
			DXListBox uIListBoxControl1List = this.UIApplicationUIWindow.UIGcNavigationsClient.UIListBoxControl1List;
			#endregion
			uIListBoxControl1List.SelectedIndicesAsString = this.SwitchToDocumentManagerTabbedViewDemoModuleParams.UIListBoxControl1ListSelectedIndicesAsString;
		}
		public void AddNewDocumentFormToHorizontalContainerLeftSide()
		{
			#region Variable Declarations
			DXRibbonButtonItem uIAddNewDocumentRibbonBaseButtonItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup1RibbonPageGroup.UIAddNewDocumentRibbonBaseButtonItem;
			#endregion
			Mouse.Click(uIAddNewDocumentRibbonBaseButtonItem, new Point(27, 21));
		}
		public void ClickNewDocumentFormTab()
		{
			#region Variable Declarations
			DXTestControl uIDocument5TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument5TabPage;
			#endregion
			Mouse.Click(uIDocument5TabPage, new Point(45, 10));
		}
		public void AddNewDocumentFormToHorizontalContainerRightSide()
		{
			#region Variable Declarations
			DXTestControl uIXtraUserControlCustom = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument4Custom.UIXtraUserControlCustom;
			DXRibbonButtonItem uIAddNewDocumentRibbonBaseButtonItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup1RibbonPageGroup.UIAddNewDocumentRibbonBaseButtonItem;
			#endregion
			Mouse.Click(uIXtraUserControlCustom, new Point(94, 274));
			Mouse.Click(uIAddNewDocumentRibbonBaseButtonItem, new Point(40, 33));
		}
		public void ClickActiveDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIDocument2TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument2TabPage;
			#endregion
			Mouse.Click(uIDocument2TabPage, new Point(63, 8));
		}
		public void MakeDocumentFormActiveViaClickDocumentsBar()
		{
			#region Variable Declarations
			DXMenuItem uIDocumentsBarItem = this.UIDocumentManagerTabbeWindow.UIBarDockControlCustom.UIMainmenuMenuBar.UIDocumentsBarItem;
			DXMenuBaseButtonItem uIItem3Document2MenuBaseButtonItem = this.UIDocumentManagerTabbeWindow.UIBarDockControlCustom.UIMainmenuMenuBar.UIDocumentsBarItem.UIItem3Document2MenuBaseButtonItem;
			#endregion
			Mouse.Click(uIDocumentsBarItem, new Point(40, 4));
			Mouse.Click(uIItem3Document2MenuBaseButtonItem, new Point(75, 7));
		}
		public void ChangeDocumentFormContainerOrientation()
		{
			#region Variable Declarations
			DXRibbonEditItem uIOrientationRibbonEditItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup2RibbonPageGroup.UIOrientationRibbonEditItem;
			DXListBoxItem uIVerticalListItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIImageComboBoxEditComboBox.UIPopupImageComboBoxEdWindow.UIPopupImageComboBoxEdList.UIVerticalListItem;
			#endregion
			Mouse.Click(uIOrientationRibbonEditItem, new Point(94, 9));
			Mouse.Click(uIVerticalListItem, new Point(54, 4));
		}
		public void MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIDockingDemoCDemoWindow6.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckLeftPanelInHorizontalSplitContainer()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel1DockPanel = this.UIDockingDemoCDemoWindow9.UIMdiClientTabList.UIDockPanel1Window.UIDockPanel1DockPanel;
			#endregion
			Assert.AreEqual(this.CheckLeftPanelInHorizontalSplitContainerExpectedValues.UIDockPanel1DockPanelOrientation, uIDockPanel1DockPanel.Orientation.ToString());
			Assert.AreEqual(this.CheckLeftPanelInHorizontalSplitContainerExpectedValues.UIDockPanel1DockPanelGroupIndex, uIDockPanel1DockPanel.GroupIndex);
			Assert.AreEqual(this.CheckLeftPanelInHorizontalSplitContainerExpectedValues.UIDockPanel1DockPanelIndex, uIDockPanel1DockPanel.Index);
		}
		public void MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckRightPanelInHorizontalSplitContainer()
		{
			#region Variable Declarations
			DXTestControl uIDockPanel3Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UIDockPanel3Client;
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Assert.AreEqual(this.CheckRightPanelInHorizontalSplitContainerExpectedValues.UIDockPanel3ClientDockStyle, uIDockPanel3Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckRightPanelInHorizontalSplitContainerExpectedValues.UIDockPanel3ClientIsTab, uIDockPanel3Client.IsTab);
			Assert.AreEqual(this.CheckRightPanelInHorizontalSplitContainerExpectedValues.UIDockPanel3ClientIndex, uIDockPanel3Client.Index);
			Assert.AreEqual(this.CheckRightPanelInHorizontalSplitContainerExpectedValues.UIPanelContainer2ClientDockStyle, uIPanelContainer2Client.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
		}
		public void MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckTopPanelInVerticalSplitContainer()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel5DockPanel = this.UIDockingDemoCDemoWindow9.UIMdiClientTabList.UIDockPanel5Window.UIDockPanel5DockPanel;
			#endregion
			Assert.AreEqual(this.CheckTopPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelOrientation, uIDockPanel5DockPanel.Orientation.ToString());
			Assert.AreEqual(this.CheckTopPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelIsFloating, uIDockPanel5DockPanel.IsFloating);
			Assert.AreEqual(this.CheckTopPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelGroupIndex, uIDockPanel5DockPanel.GroupIndex);
			Assert.AreEqual(this.CheckTopPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelIndex, uIDockPanel5DockPanel.Index);
		}
		public void MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckBottomPanelInVerticalSplitContainer()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel5DockPanel = this.UIDockingDemoCDemoWindow9.UIMdiClientTabList.UIDockPanel5Window.UIDockPanel5DockPanel;
			#endregion
			Assert.AreEqual(this.CheckBottomPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelIsFloating, uIDockPanel5DockPanel.IsFloating);
			Assert.AreEqual(this.CheckBottomPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelOrientation, uIDockPanel5DockPanel.Orientation.ToString());
			Assert.AreEqual(this.CheckBottomPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelGroupIndex, uIDockPanel5DockPanel.GroupIndex);
			Assert.AreEqual(this.CheckBottomPanelInVerticalSplitContainerExpectedValues.UIDockPanel5DockPanelIndex, uIDockPanel5DockPanel.Index);
		}
		public void DockPanelToFormViaDragging()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToFormViaDraggingParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckDockingPanelToFormViaContextMenuOption()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel5DockPanel = this.UIDockingDemoCDemoWindow9.UIMdiClientTabList.UIDockPanel5Window.UIDockPanel5DockPanel;
			#endregion
			Assert.AreEqual(this.CheckDockingPanelToFormViaContextMenuOptionExpectedValues.UIDockPanel5DockPanelOrientation, uIDockPanel5DockPanel.Orientation.ToString());
			Assert.AreEqual(this.CheckDockingPanelToFormViaContextMenuOptionExpectedValues.UIDockPanel5DockPanelGroupIndex, uIDockPanel5DockPanel.GroupIndex);
			Assert.AreEqual(this.CheckDockingPanelToFormViaContextMenuOptionExpectedValues.UIDockPanel5DockPanelIndex, uIDockPanel5DockPanel.Index);
		}
		public void DockFloatPanelToFormViaDragging()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIItemWindow.UIPanelContainer2Window.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockFloatPanelToFormViaDraggingParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void ClickPanelTabButtonForCheckRestoringClosedPanel()
		{
			#region Variable Declarations
			DXButton uISolutionExplorerDockButton = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UISolutionExplorerDockButton;
			#endregion
			Mouse.Click(uISolutionExplorerDockButton, new Point(56, 13));
		}
		public void PinPanelViaClickPinButton()
		{
			#region Variable Declarations
			DXButton uIToolboxButton = this.UIDockingDemoCDemoWindow3.UIAutoHideContainerClient.UIToolboxButton;
			DXButton uIPinButtonButton = this.UIDockingDemoCDemoWindow4.UIAutoHideControlClient.UIDockPanel6Client.UIPinButtonButton;
			#endregion
			Mouse.Click(uIToolboxButton, new Point(9, 23));
			Mouse.Click(uIPinButtonButton, new Point(9, 3));
		}
		public void PinPanelViaContextMenuOption()
		{
			#region Variable Declarations
			DXButton uIToolboxButton = this.UIDockingDemoCDemoWindow3.UIAutoHideContainerClient.UIToolboxButton;
			DXTestControl uIDockPanel6Client = this.UIDockingDemoCDemoWindow4.UIAutoHideControlClient.UIDockPanel6Client;
			DXMenuBaseButtonItem uIDockMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIDockMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIToolboxButton, new Point(15, 39));
			Mouse.Click(uIDockPanel6Client, MouseButtons.Right, ModifierKeys.None, new Point(116, 9));
			Mouse.Click(uIDockMenuBaseButtonItem, new Point(41, 14));
		}
		public void UnpinPanelViaClickPinButton()
		{
			#region Variable Declarations
			DXButton uIPinButtonButton = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UIPinButtonButton;
			#endregion
			Mouse.Click(uIPinButtonButton, new Point(11, 10));
		}
		public void CheckDockingPanelToForm()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel3DockPanel = this.UIDockingDemoCDemoWindow9.UIMdiClientTabList.UIDockPanel3Window.UIDockPanel3DockPanel;
			#endregion
			Assert.AreEqual(this.CheckDockingPanelToFormExpectedValues.UIDockPanel3DockPanelIsFloating, uIDockPanel3DockPanel.IsFloating);
			Assert.AreEqual(this.CheckDockingPanelToFormExpectedValues.UIDockPanel3DockPanelOrientation, uIDockPanel3DockPanel.Orientation.ToString());
			Assert.AreEqual(this.CheckDockingPanelToFormExpectedValues.UIDockPanel3DockPanelGroupIndex, uIDockPanel3DockPanel.GroupIndex);
			Assert.AreEqual(this.CheckDockingPanelToFormExpectedValues.UIDockPanel3DockPanelIndex, uIDockPanel3DockPanel.Index);
		}
		public void ChangeTabPositionInPanelContainer()
		{
			#region Variable Declarations
			DXButton uISolutionExplorerDockButton = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UISolutionExplorerDockButton;
			#endregion
			uISolutionExplorerDockButton.Index = this.ChangeTabPositionInPanelContainerParams.UISolutionExplorerDockButtonIndex;
			Mouse.Click(uISolutionExplorerDockButton, new Point(35, 5));
		}
		public void CheckPanelContainerTabIndexes()
		{
			#region Variable Declarations
			DXButton uISolutionExplorerDockButton = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UISolutionExplorerDockButton;
			DXButton uIPropertiesButton = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UIPropertiesButton;
			#endregion
			Assert.AreEqual(this.CheckPanelContainerTabIndexesExpectedValues.UISolutionExplorerDockButtonIndex, uISolutionExplorerDockButton.Index);
			Assert.AreEqual(this.CheckPanelContainerTabIndexesExpectedValues.UIPropertiesButtonIndex, uIPropertiesButton.Index);
		}
		public void ClickDocumentFormMinimizeButton()
		{
			#region Variable Declarations
			DXButton uIMaximizeButton = this.UIApplicationUILayoutCWindow1.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerNativCustom.UIDocumentsHostTabList.UIDocument4Custom.UIMaximizeButton;
			#endregion
			uIMaximizeButton.PerformClick = this.ClickDocumentFormMinimizeButtonParams.UIMaximizeButtonPerformClick;
		}
		public void ClickDocumentFormMaximizeButton()
		{
			#region Variable Declarations
			DXButton uIMaximizeButton = this.UIApplicationUILayoutCWindow1.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerNativCustom.UIDocumentsHostTabList.UIDocument4Custom.UIMaximizeButton;
			#endregion
			uIMaximizeButton.PerformClick = this.ClickDocumentFormMaximizeButtonParams.UIMaximizeButtonPerformClick;
		}
		public void CloseMaximizedDocumentForm()
		{
			#region Variable Declarations
			DXMenuBaseButtonItem uIBarMdiButtonItemLinkBarBaseButtonItem = this.UIDocumentManagerNativWindow1.UIBarDockControlCustom.UIMainmenuMenuBar.UIBarMdiButtonItemLinkBarBaseButtonItem;
			#endregion
			uIBarMdiButtonItemLinkBarBaseButtonItem.PerformClick = this.CloseMaximizedDocumentFormParams.UIBarMdiButtonItemLinkBarBaseButtonItemPerformClick;
		}
		public void ClickDocumentManagerDropDownButton()
		{
			#region Variable Declarations
			DXButton uIDropDownButton = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIItem0Group.UIDropDownButton;
			DXMenuBaseButtonItem uIBarButtonItemLink2MenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIBarButtonItemLink2MenuBaseButtonItem;
			#endregion
			Mouse.Click(uIDropDownButton, new Point(9, 7));
			Mouse.Click(uIBarButtonItemLink2MenuBaseButtonItem, new Point(47, 10));
		}
		public void DockPanelToAnotherPanel()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			uIPanelContainer2Client.DockInfoAsString = this.DockPanelToAnotherPanelParams.UIPanelContainer2ClientDockInfoAsString;
		}
		public void CheckDockingPanelToAnotherPanel()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel3DockPanel = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UIDockPanel3DockPanel;
			#endregion
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelExpectedValues.UIDockPanel3DockPanelParentName, uIDockPanel3DockPanel.GetProperty(DXTestControl.PropertyNames.ParentName).ToString());
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelExpectedValues.UIDockPanel3DockPanelDockStyle, uIDockPanel3DockPanel.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelExpectedValues.UIDockPanel3DockPanelIsTab, uIDockPanel3DockPanel.IsTab);
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelExpectedValues.UIDockPanel3DockPanelIndex, uIDockPanel3DockPanel.Index);
		}
		public void CloseDocumentFormViaClickCloseButton()
		{
			#region Variable Declarations
			DXButton uIDocument0Button = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage.UIDocument0Button;
			#endregion
			Mouse.Click(uIDocument0Button, new Point(7, 4));
		}
		public void MakePinnedPanelFloatViaContextMenuOption()
		{
			#region Variable Declarations
			DXButton uIToolboxButton = this.UIDockingDemoCDemoWindow3.UIAutoHideContainerClient.UIToolboxButton;
			DXTestControl uIDockPanel6Client = this.UIDockingDemoCDemoWindow4.UIAutoHideControlClient.UIDockPanel6Client;
			DXMenuBaseButtonItem uIFloatMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIFloatMenuBaseButtonItem;
			#endregion
			Mouse.Click(uIToolboxButton, new Point(9, 37));
			Mouse.Click(uIDockPanel6Client, MouseButtons.Right, ModifierKeys.None, new Point(147, 13));
			Mouse.Click(uIFloatMenuBaseButtonItem, new Point(14, 11));
		}
		public void CheckUnpinnedPanelFloatDockStyle()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel6DockPanel = this.UIItemWindow.UIDockPanel6Window.UIDockPanel6DockPanel;
			#endregion
			Assert.AreEqual(this.CheckUnpinnedPanelFloatDockStyleExpectedValues.UIDockPanel6DockPanelDockStyle, uIDockPanel6DockPanel.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
		}
		public void DockPanelToAnotherPanelAsTab()
		{
			#region Variable Declarations
			DXTestControl uIPanelContainer2Client = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client;
			#endregion
			Mouse.StartDragging(uIPanelContainer2Client, new Point(281, 12));
			Mouse.StopDragging(uIPanelContainer2Client, 504, 179);
		}
		public void CheckDockingPanelToAnotherPanelAsTab()
		{
			#region Variable Declarations
			DXDockPanel uIDockPanel3DockPanel = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UIDockPanel3DockPanel;
			#endregion
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelAsTabExpectedValues.UIDockPanel3DockPanelDockStyle, uIDockPanel3DockPanel.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelAsTabExpectedValues.UIDockPanel3DockPanelIsTab, uIDockPanel3DockPanel.IsTab);
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelAsTabExpectedValues.UIDockPanel3DockPanelParentName, uIDockPanel3DockPanel.GetProperty(DXTestControl.PropertyNames.ParentName).ToString());
			Assert.AreEqual(this.CheckDockingPanelToAnotherPanelAsTabExpectedValues.UIDockPanel3DockPanelIndex, uIDockPanel3DockPanel.Index);
		}
		public void CheckNewDocumentFormCaption()
		{
			#region Variable Declarations
			DXWindow uIDocument5Window1 = this.UIDocumentManagerNativWindow.UIMdiClientTabList.UIDocument5Window.UIDocument5Window1;
			#endregion
			Assert.AreEqual(this.CheckNewDocumentFormCaptionExpectedValues.UIDocument5Window1ControlName, uIDocument5Window1.GetProperty("ControlName").ToString());
		}
		public void CloseFloatDocumentFormViaClickCloseButton()
		{
			#region Variable Declarations
			DXButton uICloseButton = this.UIItemWindow.UIDocument0Window.UICloseButton;
			#endregion
			uICloseButton.PerformClick = this.CloseFloatDocumentFormViaClickCloseButtonParams.UICloseButtonPerformClick;
		}
		public void MaximizeFloatDocumentFormViaClickMaximizeButton()
		{
			#region Variable Declarations
			DXButton uIMaximizeButton = this.UIItemWindow.UIDocument0Window.UIMaximizeButton;
			#endregion
			uIMaximizeButton.PerformClick = this.MaximizeFloatDocumentFormViaClickMaximizeButtonParams.UIMaximizeButtonPerformClick;
		}
		public void MinimizeFloatDocumentFormViaClickRestoreButton()
		{
			#region Variable Declarations
			DXButton uIRestoreButton = this.UIItemWindow.UIDocument0Window.UIRestoreButton;
			#endregion
			uIRestoreButton.PerformClick = this.MinimizeFloatDocumentFormViaClickRestoreButtonParams.UIRestoreButtonPerformClick;
		}
		public void DockDocumentFormToTabbedViewLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			uIDocument3TabPage.DockInfoAsString = this.DockDocumentFormToTabbedViewLeftEdgeParams.UIDocument3TabPageDockInfoAsString;
		}
		public void DockDocumentFormToTabbedViewRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			uIDocument0TabPage.DockInfoAsString = this.DockDocumentFormToTabbedViewRightEdgeParams.UIDocument0TabPageDockInfoAsString;
		}
		public void DockDocumentFormToLeftHorizontalContainerAsTab()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			uIDocument3TabPage.DockInfoAsString = this.DockDocumentFormToLeftHorizontalContainerAsTabParams.UIDocument3TabPageDockInfoAsString;
		}
		public void MakeTabbedViewDocumentFormFloatViaDoubleClickCaption()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			Mouse.DoubleClick(uIDocument3TabPage, new Point(56, 14));
		}
		public void DockFloatDocumentFormToTabbedViewLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3WindowTitleBar = this.UIItemWindow.UIDocument3Window.UIDocument3WindowTitleBar;
			#endregion
			uIDocument3WindowTitleBar.DockInfoAsString = this.DockFloatDocumentFormToTabbedViewLeftEdgeParams.UIDocument3WindowTitleBarDockInfoAsString;
		}
		public void MakeTabbedViewDocumentFormFloatViaContextMenuOption()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			DXMenuBaseButtonItem uIBarButtonItemLink3MenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UIBarButtonItemLink3MenuBaseButtonItem;
			#endregion
			Mouse.Click(uIDocument3TabPage, MouseButtons.Right, ModifierKeys.None, new Point(56, 12));
			Mouse.Click(uIBarButtonItemLink3MenuBaseButtonItem, new Point(63, 14));
		}
		public void DockFloatDocumentFormToTabbedViewRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3WindowTitleBar = this.UIItemWindow.UIDocument3Window.UIDocument3WindowTitleBar;
			#endregion
			uIDocument3WindowTitleBar.DockInfoAsString = this.DockFloatDocumentFormToTabbedViewRightEdgeParams.UIDocument3WindowTitleBarDockInfoAsString;
		}
		public void MakeTabbedViewDocumentFormFloatViaDragging()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			uIDocument3TabPage.DockInfoAsString = this.MakeTabbedViewDocumentFormFloatViaDraggingParams.UIDocument3TabPageDockInfoAsString;
		}
		public void DockFloatDocumentFormToLeftHorizontalContainerAsTab()
		{
			#region Variable Declarations
			DXTestControl uIDocument3WindowTitleBar = this.UIItemWindow.UIDocument3Window.UIDocument3WindowTitleBar;
			#endregion
			uIDocument3WindowTitleBar.DockInfoAsString = this.DockFloatDocumentFormToLeftHorizontalContainerAsTabParams.UIDocument3WindowTitleBarDockInfoAsString;
		}
		public void CloseTabbedViewFloatDocumentFormViaCloseButton()
		{
			#region Variable Declarations
			DXButton uICloseButton = this.UIItemWindow.UIDocument3Window.UICloseButton;
			#endregion
			uICloseButton.PerformClick = this.CloseTabbedViewFloatDocumentFormViaCloseButtonParams.UICloseButtonPerformClick;
		}
		public void MaximizeTabbedViewFloatDocumentFormViaMaximizeButton()
		{
			#region Variable Declarations
			DXButton uIMaximizeButton = this.UIItemWindow3.UIMaximizeButton;
			#endregion
			Mouse.Click(uIMaximizeButton, new Point(15, 11));
		}
		public void MinimizeTabbedViewFloatDocumentFormViaMinimizeButton()
		{
			#region Variable Declarations
			DXButton uIMinimizeButton = this.UIItemWindow2.UIMinimizeButton;
			#endregion
			Mouse.Click(uIMinimizeButton, new Point(8, 12));
		}
		public void CloseDocumentFormViaClickHeaderCloseButton()
		{
			#region Variable Declarations
			DXButton uIDocument4Button = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument4TabPage.UIDocument4Button;
			#endregion
			Mouse.Click(uIDocument4Button, new Point(5, 8));
		}
		public void MakeVerticalContainerViaDockingDocumentFormToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			uIDocument3TabPage.DockInfoAsString = this.MakeVerticalContainerViaDockingDocumentFormToTopEdgeParams.UIDocument3TabPageDockInfoAsString;
		}
		public void MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3WindowTitleBar = this.UIItemWindow.UIDocument3Window.UIDocument3WindowTitleBar;
			#endregion
			uIDocument3WindowTitleBar.DockInfoAsString = this.MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams.UIDocument3WindowTitleBarDockInfoAsString;
		}
		public void SwitchToTabbedMDIDemoModule()
		{
			#region Variable Declarations
			DXListBox uIListBoxControl1List = this.UIApplicationUIWindow.UIGcNavigationsClient.UIListBoxControl1List;
			#endregion
			uIListBoxControl1List.SelectedIndicesAsString = this.SwitchToTabbedMDIDemoModuleParams.UIListBoxControl1ListSelectedIndicesAsString;
		}
		public void MakeTabbedMDIDocumentFormFloatViaDragging()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			uIForm2TabPage.DockInfoAsString = this.MakeTabbedMDIDocumentFormFloatViaDraggingParams.UIForm2TabPageDockInfoAsString;
		}
		public void CheckFloatTabbedMDIDocumentForm()
		{
			#region Variable Declarations
			DXWindow uIForm2Window1 = this.UIForm2Window.UIForm2Window1;
			#endregion
			Assert.AreEqual(this.CheckFloatTabbedMDIDocumentFormExpectedValues.UIForm2Window1ControlName, uIForm2Window1.GetProperty("ControlName").ToString());
		}
		public void DockFloatTabbedMDIDocumentFormAsTab()
		{
			#region Variable Declarations
			DXTestControl uIForm2WindowTitleBar = this.UIForm2Window.UIForm2WindowTitleBar;
			#endregion
			uIForm2WindowTitleBar.DockInfoAsString = this.DockFloatTabbedMDIDocumentFormAsTabParams.UIForm2WindowTitleBarDockInfoAsString;
		}
		public void MakeTabbedMDIDocumentFormFloatViaDoubleClick()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			Mouse.DoubleClick(uIForm2TabPage, new Point(41, 8));
		}
		public void UncheckFloatOnDragOption()
		{
			#region Variable Declarations
			DXMenuBaseButtonItem uIFloatOnDragBarBaseButtonItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarWindowsMenuBar.UIFloatOnDragBarBaseButtonItem;
			#endregion
			uIFloatOnDragBarBaseButtonItem.PerformClick = this.UncheckFloatOnDragOptionParams.UIFloatOnDragBarBaseButtonItemPerformClick;
		}
		public void DragTabbedMDIDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			uIForm2TabPage.DockInfoAsString = this.DragTabbedMDIDocumentFormParams.UIForm2TabPageDockInfoAsString;
		}
		public void CheckConservationTabbedMDIDocumentFormIndex()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			Assert.AreEqual(this.CheckConservationTabbedMDIDocumentFormIndexExpectedValues.UIForm2TabPageIndex, uIForm2TabPage.Index);
			Assert.AreEqual(this.CheckConservationTabbedMDIDocumentFormIndexExpectedValues.UIForm2TabPageText, uIForm2TabPage.Text);
		}
		public void UncheckFloatOnDoubleClickOption()
		{
			#region Variable Declarations
			DXMenuBaseButtonItem uIFloatOnDoubleClickBarBaseButtonItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarWindowsMenuBar.UIFloatOnDoubleClickBarBaseButtonItem;
			#endregion
			uIFloatOnDoubleClickBarBaseButtonItem.PerformClick = this.UncheckFloatOnDoubleClickOptionParams.UIFloatOnDoubleClickBarBaseButtonItemPerformClick;
		}
		public void ChangeClosePageButtonInTabbedMDIDemoModule()
		{
			#region Variable Declarations
			DXMenuEditItem uIClosePageButtonBarEditItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIClosePageButtonsMenuBar.UIClosePageButtonBarEditItem;
			DXComboBox uIClosePageButtonComboBox = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIClosePageButtonsMenuBar.UIClosePageButtonComboBox;
			DXMenu uIClosePageButtonsMenuBar = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIClosePageButtonsMenuBar;
			#endregion
			Mouse.Click(uIClosePageButtonBarEditItem, new Point(277, 6));
			uIClosePageButtonComboBox.ValueTypeName = this.ChangeClosePageButtonInTabbedMDIDemoModuleParams.UIClosePageButtonComboBoxValueTypeName;
			uIClosePageButtonComboBox.ValueAsString = this.ChangeClosePageButtonInTabbedMDIDemoModuleParams.UIClosePageButtonComboBoxValueAsString;
			uIClosePageButtonsMenuBar.CloseActiveEditor = this.ChangeClosePageButtonInTabbedMDIDemoModuleParams.UIClosePageButtonsMenuBarCloseActiveEditor;
		}
		public void ClickTabbedMDIDocumentFormHeaderCloseButton()
		{
			#region Variable Declarations
			DXButton uIForm1Button = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm1TabPage.UIForm1Button;
			#endregion
			Mouse.Click(uIForm1Button, new Point(8, 4));
		}
		public void CheckClosedTabbedMDIDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			Assert.AreEqual(this.CheckClosedTabbedMDIDocumentFormExpectedValues.UIForm2TabPageText, uIForm2TabPage.Text);
			Assert.AreEqual(this.CheckClosedTabbedMDIDocumentFormExpectedValues.UIForm2TabPageIndex, uIForm2TabPage.Index);
		}
		public void ReorderMDITabs()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			uIForm2TabPage.DockInfoAsString = this.ReorderMDITabsParams.UIForm2TabPageDockInfoAsString;
		}
		public void CheckMDITabIndex()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			Assert.AreEqual(this.CheckMDITabIndexExpectedValues.UIForm2TabPageIndex, uIForm2TabPage.Index);
		}
		public void ChangeTabbedMDIHeaderLocation()
		{
			#region Variable Declarations
			DXMenuEditItem uIHeaderLocationBarEditItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderLocationBarEditItem;
			DXComboBox uIHeaderLocationComboBox = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderLocationComboBox;
			DXMenu uIBarOptionsMenuBar = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar;
			#endregion
			Mouse.Click(uIHeaderLocationBarEditItem, new Point(176, 10));
			uIHeaderLocationComboBox.ValueTypeName = this.ChangeTabbedMDIHeaderLocationParams.UIHeaderLocationComboBoxValueTypeName;
			uIHeaderLocationComboBox.ValueAsString = this.ChangeTabbedMDIHeaderLocationParams.UIHeaderLocationComboBoxValueAsString;
			uIBarOptionsMenuBar.CloseActiveEditor = this.ChangeTabbedMDIHeaderLocationParams.UIBarOptionsMenuBarCloseActiveEditor;
		}
		public void ChangeTabbedMDIHeaderOrientation()
		{
			#region Variable Declarations
			DXMenuEditItem uIHeaderOrientationBarEditItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderOrientationBarEditItem;
			DXComboBox uIHeaderOrientationComboBox = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderOrientationComboBox;
			DXMenu uIBarOptionsMenuBar = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar;
			#endregion
			Mouse.Click(uIHeaderOrientationBarEditItem, new Point(186, 9));
			uIHeaderOrientationComboBox.ValueTypeName = this.ChangeTabbedMDIHeaderOrientationParams.UIHeaderOrientationComboBoxValueTypeName;
			uIHeaderOrientationComboBox.ValueAsString = this.ChangeTabbedMDIHeaderOrientationParams.UIHeaderOrientationComboBoxValueAsString;
			uIBarOptionsMenuBar.CloseActiveEditor = this.ChangeTabbedMDIHeaderOrientationParams.UIBarOptionsMenuBarCloseActiveEditor;
		}
		public void CloseMDITabViaTabCloseButton()
		{
			#region Variable Declarations
			DXTestControl uIForm1TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm1TabPage;
			DXButton uICloseButton = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIItem0Group.UICloseButton;
			#endregion
			Mouse.Click(uIForm1TabPage, new Point(38, 8));
			Mouse.Click(uICloseButton, new Point(14, 6));
		}
		public void ReorderTabsInTabbedViewDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIDocument4TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument4TabPage;
			#endregion
			uIDocument4TabPage.DockInfoAsString = this.ReorderTabsInTabbedViewDemoModuleParams.UIDocument4TabPageDockInfoAsString;
		}
		public void CheckTabIndexInTabbedViewDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIDocument4TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument4TabPage;
			#endregion
			Assert.AreEqual(this.CheckTabIndexInTabbedViewDemoModuleExpectedValues.UIDocument4TabPageOrientation, uIDocument4TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckTabIndexInTabbedViewDemoModuleExpectedValues.UIDocument4TabPageGroupIndex, uIDocument4TabPage.GroupIndex);
			Assert.AreEqual(this.CheckTabIndexInTabbedViewDemoModuleExpectedValues.UIDocument4TabPageIndex, uIDocument4TabPage.Index);
		}
		public void ChangeTabbedViewHeaderLocation()
		{
			#region Variable Declarations
			DXRibbonEditItem uILocationRibbonEditItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup3RibbonPageGroup.UILocationRibbonEditItem;
			DXListBoxItem uIBottomListItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIImageComboBoxEditComboBox.UIPopupImageComboBoxEdWindow.UIPopupImageComboBoxEdList.UIBottomListItem;
			#endregion
			Mouse.Click(uILocationRibbonEditItem, new Point(107, 11));
			Mouse.Click(uIBottomListItem, new Point(48, 9));
		}
		public void ChangeTabbedViewHeaderOrientation()
		{
			#region Variable Declarations
			DXRibbonEditItem uIOrientationRibbonEditItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup3RibbonPageGroup.UIOrientationRibbonEditItem;
			DXListBoxItem uIVerticalListItem1 = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIImageComboBoxEditComboBox.UIPopupImageComboBoxEdWindow.UIPopupImageComboBoxEdList.UIVerticalListItem1;
			#endregion
			Mouse.Click(uIOrientationRibbonEditItem, new Point(107, 11));
			Mouse.Click(uIVerticalListItem1, new Point(67, 10));
		}
		public void ChangeShowCloseButtonMode()
		{
			#region Variable Declarations
			DXMenuEditItem uIShowCloseButtonBarEditItem = this.UIDocumentManagerTabbeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIShowCloseButtonBarEditItem;
			DXComboBox uIShowCloseButtonComboBox = this.UIDocumentManagerTabbeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIShowCloseButtonComboBox;
			DXMenu uIBarOptionsMenuBar = this.UIDocumentManagerTabbeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar;
			#endregion
			Mouse.Click(uIShowCloseButtonBarEditItem, new Point(248, 3));
			uIShowCloseButtonComboBox.ValueTypeName = this.ChangeShowCloseButtonModeParams.UIShowCloseButtonComboBoxValueTypeName;
			uIShowCloseButtonComboBox.ValueAsString = this.ChangeShowCloseButtonModeParams.UIShowCloseButtonComboBoxValueAsString;
			uIBarOptionsMenuBar.CloseActiveEditor = this.ChangeShowCloseButtonModeParams.UIBarOptionsMenuBarCloseActiveEditor;
		}
		public void ClickTabbedViewHeaderCloseButton()
		{
			#region Variable Declarations
			DXButton uIDocument3Button = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument3TabPage.UIDocument3Button;
			#endregion
			Mouse.Click(uIDocument3Button, new Point(9, 8));
		}
		public void ClickTabCloseButtonInTabbedViewDemoModule()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument3TabPage;
			DXButton uICloseButton = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIItem0Group.UICloseButton;
			#endregion
			Mouse.Click(uIDocument3TabPage, new Point(61, 14));
			Mouse.Click(uICloseButton, new Point(12, 6));
		}
		public void MakeHeaderAutoFillBarVisible()
		{
			#region Variable Declarations
			DXMenu uIBarOptionsMenuBar = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar;
			DXMenuBaseButtonItem uICustomizeMenuBaseButtonItem = this.UIItemWindow.UIPopupMenuBarControlMenu.UICustomizeMenuBaseButtonItem;
			DXMenuEditItem uIHeaderLocationBarEditItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderLocationBarEditItem;
			DXWindow uIForm2Window = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2Window;
			DXButton uICloseButton = this.UIItemWindow11.UICloseButton;
			#endregion
			Mouse.Click(uIBarOptionsMenuBar, MouseButtons.Right, ModifierKeys.None, new Point(638, 11));
			Mouse.Click(uICustomizeMenuBaseButtonItem, new Point(61, 14));
			uIForm2Window.EnsureClickable(new Point(104, 58));
			Mouse.StartDragging(uIHeaderLocationBarEditItem, new Point(46, 7));
			Mouse.StopDragging(uIForm2Window, new Point(104, 58));
			Mouse.Click(uICloseButton, new Point(18, 8));
		}
		public void SwitchOnHeaderAutoFillOption()
		{
			#region Variable Declarations
			DXMenuEditItem uIHeaderAutoFillBarEditItem = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderAutoFillBarEditItem;
			DXComboBox uIHeaderAutoFillComboBox = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar.UIHeaderAutoFillComboBox;
			DXMenu uIBarOptionsMenuBar = this.UITabbedMDICcodeWindow.UIBarDockControlCustom.UIBarOptionsMenuBar;
			#endregion
			Mouse.Click(uIHeaderAutoFillBarEditItem, new Point(162, 9));
			uIHeaderAutoFillComboBox.ValueTypeName = this.SwitchOnHeaderAutoFillOptionParams.UIHeaderAutoFillComboBoxValueTypeName;
			uIHeaderAutoFillComboBox.ValueAsString = this.SwitchOnHeaderAutoFillOptionParams.UIHeaderAutoFillComboBoxValueAsString;
			uIBarOptionsMenuBar.CloseActiveEditor = this.SwitchOnHeaderAutoFillOptionParams.UIBarOptionsMenuBarCloseActiveEditor;
		}
		public void CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument4TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument4TabPage;
			DXTestControl uIDocument3TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument3TabPage;
			DXTestControl uIDocument2TabPage = this.UIDocumentManagerTabbeWindow.UIMdiClientTabList.UIDocument2TabPage;
			#endregion
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument4TabPageOrientation, uIDocument4TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument4TabPageGroupIndex, uIDocument4TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument4TabPageIndex, uIDocument4TabPage.Index);
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument3TabPageOrientation, uIDocument3TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument3TabPageGroupIndex, uIDocument3TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument3TabPageIndex, uIDocument3TabPage.Index);
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument2TabPageOrientation, uIDocument2TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument2TabPageGroupIndex, uIDocument2TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument2TabPageIndex, uIDocument2TabPage.Index);
		}
		public void MoveHorizontalSplitter()
		{
			#region Variable Declarations
			DXTestControl uILeftSeparator = this.UIDockingDemoCDemoWindow6.UIDockPanelClient.UILeftSeparator;
			DXGrid uIGridControl1Table = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UIDockPanel3Client.UIDockPanel3_ContainerCustom.UIGridControl1Table;
			#endregion
			uIGridControl1Table.EnsureClickable(new Point(142, 303));
			Mouse.StartDragging(uILeftSeparator, new Point(1, 327));
			Mouse.StopDragging(uIGridControl1Table, new Point(142, 303));
		}
		public void MoveVerticalSplitterDown()
		{
			#region Variable Declarations
			DXTestControl uITopSeparator = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UITopSeparator;
			DXGrid uIGridControl1Table = this.UIDockingDemoCDemoWindow.UIPanelContainer2Client.UIDockPanel3Client.UIDockPanel3_ContainerCustom.UIGridControl1Table;
			#endregion
			uIGridControl1Table.EnsureClickable(new Point(401, 65));
			Mouse.StartDragging(uITopSeparator, new Point(399, 0));
			Mouse.StopDragging(uIGridControl1Table, new Point(401, 65));
		}
		public void CreateTabContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.CreateTabContainerFromTwoUntitledPanelsParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckTabContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient1;
			DXTestControl uIDockPanelClient11 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient11;
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1Tabbed, uIDockPanelClient1.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11DockStyle, uIDockPanelClient11.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11IsTab, uIDockPanelClient11.IsTab);
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11Tabbed, uIDockPanelClient11.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient2Tabbed, uIDockPanelClient2.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient2DockStyle, uIDockPanelClient2.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient2IsTab, uIDockPanelClient2.IsTab);
		}
		public void CreateSplitContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.CreateSplitContainerFromTwoUntitledPanelsParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckSplitContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient1;
			DXTestControl uIDockPanelClient11 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient11;
			#endregion
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1Tabbed, uIDockPanelClient1.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11DockStyle, uIDockPanelClient11.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11IsTab, uIDockPanelClient11.IsTab);
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11Tabbed, uIDockPanelClient11.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClient11Index, uIDockPanelClient11.Index);
		}
		public void DockTabContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.DockTabContainerFromTwoUntitledPanelsParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckDockingTabContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient;
			DXButton uIDockPanelButton = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient.UIDockPanelButton;
			DXButton uIDockPanel1Button = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient.UIDockPanel1Button;
			#endregion
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClientDockStyle, uIDockPanelClient.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClientIsTab, uIDockPanelClient.IsTab);
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClientTabbed, uIDockPanelClient.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelClientIndex, uIDockPanelClient.Index);
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelButtonDockStyle, uIDockPanelButton.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanelButtonIndex, uIDockPanelButton.Index);
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanel1ButtonDockStyle, uIDockPanel1Button.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues.UIDockPanel1ButtonIndex, uIDockPanel1Button.Index);
		}
		public void CreateSplitContainerFromTabContainerAndUntitledPanel()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient;
			#endregion
			uIDockPanelClient.DockInfoAsString = this.CreateSplitContainerFromTabContainerAndUntitledPanelParams.UIDockPanelClientDockInfoAsString;
		}
		public void CheckSplitContainerFromTabContainerAndUntitledPanel()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient.UIDockPanelClient1;
			DXDockPanel uIDockPanelDockPanel1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient.UIDockPanelDockPanel1;
			#endregion
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelClient1Tabbed, uIDockPanelClient1.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelDockPanel1DockStyle, uIDockPanelDockPanel1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelDockPanel1IsTab, uIDockPanelDockPanel1.IsTab);
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelDockPanel1Tabbed, uIDockPanelDockPanel1.Tabbed);
			Assert.AreEqual(this.CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues.UIDockPanelDockPanel1Index, uIDockPanelDockPanel1.Index);
		}
		public void CreateSecondTabContainerFromTwoUntitledPanels()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.CreateSecondTabContainerFromTwoUntitledPanelsParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CreateSplitContainerFromTwoTabContainers()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.CreateSplitContainerFromTwoTabContainersParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckSplitContainerFromTwoTabContainers()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient1 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient1;
			DXTestControl uIDockPanelClient11 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelClient11;
			#endregion
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient1DockStyle, uIDockPanelClient1.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient1IsTab, uIDockPanelClient1.IsTab);
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient1Tabbed, uIDockPanelClient1.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient1Index, uIDockPanelClient1.Index);
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient11DockStyle, uIDockPanelClient11.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient11IsTab, uIDockPanelClient11.IsTab);
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient11Tabbed, uIDockPanelClient11.GetProperty("Tabbed").ToString());
			Assert.AreEqual(this.CheckSplitContainerFromTwoTabContainersExpectedValues.UIDockPanelClient11Index, uIDockPanelClient11.Index);
		}
		public void CreateTabContainerFromTwoTabContainers()
		{
			#region Variable Declarations
			DXTestControl uIDockPanelClient2 = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2;
			#endregion
			uIDockPanelClient2.DockInfoAsString = this.CreateTabContainerFromTwoTabContainersParams.UIDockPanelClient2DockInfoAsString;
		}
		public void CheckTabContainerFromTwoTabContainers()
		{
			#region Variable Declarations
			DXButton uIDockPanelButton = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanelButton;
			DXButton uIDockPanel1Button = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanel1Button;
			DXButton uIDockPanel2Button = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanel2Button;
			DXButton uIDockPanel3Button = this.UIApplicationUIWindow.UIPcMainClient.UIGcContainerClient.UIDockPanelsCustom.UIPnlContainerClient.UISimpleDockPanelCustom.UIDockPanelClient2.UIDockPanel3Button;
			#endregion
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanelButtonDockStyle, uIDockPanelButton.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanelButtonIndex, uIDockPanelButton.Index);
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanel1ButtonDockStyle, uIDockPanel1Button.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanel1ButtonIndex, uIDockPanel1Button.Index);
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanel2ButtonDockStyle, uIDockPanel2Button.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanel2ButtonIndex, uIDockPanel2Button.Index);
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanel3ButtonDockStyle, uIDockPanel3Button.GetProperty(DXTestControl.PropertyNames.DockStyle).ToString());
			Assert.AreEqual(this.CheckTabContainerFromTwoTabContainersExpectedValues.UIDockPanel3ButtonIndex, uIDockPanel3Button.Index);
		}
		public void ClickLaunchSampleButtonInTabbedMDIDemoModule()
		{
			#region Variable Declarations
			DXButton uILaunchSampleButton = this.UIApplicationUILayoutCWindow3.UIPanelControl1Client.UIGcContainerClient.UIStartupMDIDemosCustom.UIXtraTabControl1TabList.UIXtraTabPage1Client.UILaunchSampleButton;
			#endregion
			Mouse.Click(uILaunchSampleButton, new Point(1, 1));
		}
		public void CheckDockedTabbedMDIDocumentFormAsTab()
		{
			#region Variable Declarations
			DXTestControl uIForm2TabPage = this.UITabbedMDICcodeWindow.UIMdiClientTabList.UIForm2TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedTabbedMDIDocumentFormAsTabExpectedValues.UIForm2TabPageIndex, uIForm2TabPage.Index);
		}
		public void CheckLastDocumentIsVisible()
		{
			#region Variable Declarations
			DXTestControl uIDocument2TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument2TabPage;
			#endregion
			Assert.AreEqual(this.CheckLastDocumentIsVisibleExpectedValues.UIDocument2TabPageExists, uIDocument2TabPage.Exists);
		}
		public void CheckFloatDocumentFormDoesNotExist()
		{
			#region Variable Declarations
			DXTestControl uIDocument0WindowTitleBar = this.UIItemWindow.UIDocument0Window.UIDocument0WindowTitleBar;
			#endregion
			Assert.AreEqual(this.CheckFloatDocumentFormDoesNotExistExpectedValues.UIDocument0WindowTitleBarExists, uIDocument0WindowTitleBar.Exists);
		}
		public void CheckFloatingDocumentFormDockStyle()
		{
			#region Variable Declarations
			DXWindow uIDocument0Window = this.UIItemWindow.UIDocument0Window;
			#endregion
			Assert.AreEqual(this.CheckFloatingDocumentFormDockStyleExpectedValues.UIDocument0WindowIsFloating, uIDocument0Window.IsFloating);
		}
		public void CheckDocumentManagerTabIndex()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckDocumentManagerTabIndexExpectedValues.UIDocument0TabPageIndex, uIDocument0TabPage.Index);
		}
		public void CheckDockedFormToLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToLeftEdgeExpectedValues.UIDocument0TabPageOrientation, uIDocument0TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedFormToLeftEdgeExpectedValues.UIDocument0TabPageGroupIndex, uIDocument0TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToLeftEdgeExpectedValues.UIDocument0TabPageIndex, uIDocument0TabPage.Index);
		}
		public void CheckDockedFormToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToRightEdgeExpectedValues.UIDocument0TabPageOrientation, uIDocument0TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedFormToRightEdgeExpectedValues.UIDocument0TabPageGroupIndex, uIDocument0TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToRightEdgeExpectedValues.UIDocument0TabPageIndex, uIDocument0TabPage.Index);
		}
		public void CheckDockedFormToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToTopEdgeExpectedValues.UIDocument0TabPageOrientation, uIDocument0TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedFormToTopEdgeExpectedValues.UIDocument0TabPageGroupIndex, uIDocument0TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToTopEdgeExpectedValues.UIDocument0TabPageIndex, uIDocument0TabPage.Index);
		}
		public void CheckDockedFormToBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToBottomEdgeExpectedValues.UIDocument0TabPageOrientation, uIDocument0TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedFormToBottomEdgeExpectedValues.UIDocument0TabPageGroupIndex, uIDocument0TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToBottomEdgeExpectedValues.UIDocument0TabPageIndex, uIDocument0TabPage.Index);
		}
		public void CheckLeftPanelInDocumentManagerHorizontalSplitContainer()
		{
			#region Variable Declarations
			DXTestControl uIRightPanelTabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIRightPanelTabPage;
			#endregion
			Assert.AreEqual(this.CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues.UIRightPanelTabPageOrientation, uIRightPanelTabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues.UIRightPanelTabPageGroupIndex, uIRightPanelTabPage.GroupIndex);
			Assert.AreEqual(this.CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues.UIRightPanelTabPageIndex, uIRightPanelTabPage.Index);
		}
		public void CheckRightPanelInDocumentManagerHorizontalSplitContainer()
		{
			#region Variable Declarations
			DXTestControl uITopLeftPanelTabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UITopLeftPanelTabPage;
			#endregion
			Assert.AreEqual(this.CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues.UITopLeftPanelTabPageOrientation, uITopLeftPanelTabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues.UITopLeftPanelTabPageGroupIndex, uITopLeftPanelTabPage.GroupIndex);
			Assert.AreEqual(this.CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues.UITopLeftPanelTabPageIndex, uITopLeftPanelTabPage.Index);
		}
		public void CheckTopPanelInDocumentManagerVerticalSplitContainer()
		{
			#region Variable Declarations
			DXTestControl uIBottomLeftPanelTabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIBottomLeftPanelTabPage;
			#endregion
			Assert.AreEqual(this.CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues.UIBottomLeftPanelTabPageOrientation, uIBottomLeftPanelTabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues.UIBottomLeftPanelTabPageGroupIndex, uIBottomLeftPanelTabPage.GroupIndex);
			Assert.AreEqual(this.CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues.UIBottomLeftPanelTabPageIndex, uIBottomLeftPanelTabPage.Index);
		}
		public void CheckBottomPanelInDocumentManagerVerticalSplitContainer()
		{
			#region Variable Declarations
			DXTestControl uIBottomLeftPanelTabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIBottomLeftPanelTabPage;
			#endregion
			Assert.AreEqual(this.CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues.UIBottomLeftPanelTabPageOrientation, uIBottomLeftPanelTabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues.UIBottomLeftPanelTabPageGroupIndex, uIBottomLeftPanelTabPage.GroupIndex);
			Assert.AreEqual(this.CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues.UIBottomLeftPanelTabPageIndex, uIBottomLeftPanelTabPage.Index);
		}
		public void CheckDockedPanelToDocumentForm()
		{
			#region Variable Declarations
			DXTestControl uIBottomLeftPanelTabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIBottomLeftPanelTabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedPanelToDocumentFormExpectedValues.UIBottomLeftPanelTabPageOrientation, uIBottomLeftPanelTabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedPanelToDocumentFormExpectedValues.UIBottomLeftPanelTabPageGroupIndex, uIBottomLeftPanelTabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedPanelToDocumentFormExpectedValues.UIBottomLeftPanelTabPageIndex, uIBottomLeftPanelTabPage.Index);
		}
		public void CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTab()
		{
			#region Variable Declarations
			DXTestControl uIBottomLeftPanelTabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIBottomLeftPanelTabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues.UIBottomLeftPanelTabPageOrientation, uIBottomLeftPanelTabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues.UIBottomLeftPanelTabPageGroupIndex, uIBottomLeftPanelTabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues.UIBottomLeftPanelTabPageIndex, uIBottomLeftPanelTabPage.Index);
		}
		public void CheckFirstDocumentIsActive()
		{
			#region Variable Declarations
			DXTestControl uILabelControlLabel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0Custom.UIXtraUserControlCustom.UILabelControlLabel;
			#endregion
			Assert.AreEqual(this.CheckFirstDocumentIsActiveExpectedValues.UILabelControlLabelText, uILabelControlLabel.Text);
		}
		public void ClickThirdDocumentTab()
		{
			#region Variable Declarations
			DXTestControl uIDocument2TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument2TabPage;
			#endregion
			Mouse.Click(uIDocument2TabPage, new Point(39, 11));
		}
		public void CheckFirstDocumentIsActiveViaClickingOnItsContent()
		{
			#region Variable Declarations
			DXTestControl uILabelControlLabel = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0Custom.UIXtraUserControlCustom.UILabelControlLabel;
			#endregion
			Mouse.Click(uILabelControlLabel, new Point(18, 10));
		}
		public void CheckClosedDocumentFormViaDialogWindowsForm()
		{
			#region Variable Declarations
			DXTestControl uIDocument2TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument2TabPage;
			#endregion
			Assert.AreEqual(this.CheckClosedDocumentFormViaDialogWindowsFormExpectedValues.UIDocument2TabPageExists, uIDocument2TabPage.Exists);
		}
		public void CheckCloseAllDocumentOption()
		{
			#region Variable Declarations
			DXTestControl uIDocument2TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument2TabPage;
			DXTestControl uIDocument1TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument1TabPage;
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerDockiCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckCloseAllDocumentOptionExpectedValues.UIDocument2TabPageExists, uIDocument2TabPage.Exists);
			Assert.AreEqual(this.CheckCloseAllDocumentOptionExpectedValues.UIDocument1TabPageExists, uIDocument1TabPage.Exists);
			Assert.AreEqual(this.CheckCloseAllDocumentOptionExpectedValues.UIDocument0TabPageExists, uIDocument0TabPage.Exists);
		}
		public void CheckNewDocumentAdded()
		{
			#region Variable Declarations
			DXTestControl uIDocument5Custom = this.UIApplicationUILayoutCWindow1.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerNativCustom.UIDocumentsHostTabList.UIDocument5Custom;
			#endregion
			Assert.AreEqual(this.CheckNewDocumentAddedExpectedValues.UIDocument5CustomExists, uIDocument5Custom.Exists);
		}
		public void CheckNewTabAdded()
		{
			#region Variable Declarations
			DXTestControl uIDocument5TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument5TabPage;
			#endregion
			Assert.AreEqual(this.CheckNewTabAddedExpectedValues.UIDocument5TabPageExists, uIDocument5TabPage.Exists);
		}
		public void CheckNewTabAddedToRightGroup()
		{
			#region Variable Declarations
			DXTestControl uIDocument5TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument5TabPage;
			#endregion
			Assert.AreEqual(this.CheckNewTabAddedToRightGroupExpectedValues.UIDocument5TabPageExists, uIDocument5TabPage.Exists);
		}
		public void CheckChangedOrientation()
		{
			#region Variable Declarations
			DXTestControl uIDocument2TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument2TabPage;
			#endregion
			Assert.AreEqual(this.CheckChangedOrientationExpectedValues.UIDocument2TabPageOrientation, uIDocument2TabPage.Orientation.ToString());
		}
		public void CheckVerticalContainerAfterDockingDocumentFormToTopEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			Assert.AreEqual(this.CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues.UIDocument3TabPageOrientation, uIDocument3TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues.UIDocument3TabPageGroupIndex, uIDocument3TabPage.GroupIndex);
			Assert.AreEqual(this.CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues.UIDocument3TabPageIndex, uIDocument3TabPage.Index);
		}
		public void CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			Assert.AreEqual(this.CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument3TabPageOrientation, uIDocument3TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument3TabPageGroupIndex, uIDocument3TabPage.GroupIndex);
			Assert.AreEqual(this.CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues.UIDocument3TabPageIndex, uIDocument3TabPage.Index);
		}
		public void CheckDockedFormToTabbedViewLeftEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToTabbedViewLeftEdgeExpectedValues.UIDocument3TabPageOrientation, uIDocument3TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedFormToTabbedViewLeftEdgeExpectedValues.UIDocument3TabPageGroupIndex, uIDocument3TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToTabbedViewLeftEdgeExpectedValues.UIDocument3TabPageIndex, uIDocument3TabPage.Index);
		}
		public void CheckDockedFormToTabbedViewRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToTabbedViewRightEdgeExpectedValues.UIDocument3TabPageOrientation, uIDocument3TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckDockedFormToTabbedViewRightEdgeExpectedValues.UIDocument3TabPageGroupIndex, uIDocument3TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToTabbedViewRightEdgeExpectedValues.UIDocument3TabPageIndex, uIDocument3TabPage.Index);
		}
		public void SelectInTabControlHeaderOption()
		{
			#region Variable Declarations
			DXRibbonEditItem uIShowCloseButtonRibbonEditItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup3RibbonPageGroup.UIShowCloseButtonRibbonEditItem;
			DXListBoxItem uIVerticalListItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIImageComboBoxEditComboBox.UIPopupImageComboBoxEdWindow.UIPopupImageComboBoxEdList.UIVerticalListItem;
			#endregion
			Mouse.Click(uIShowCloseButtonRibbonEditItem, new Point(134, 14));
			Mouse.Click(uIVerticalListItem, new Point(99, 6));
		}
		public void CheckTabsHaveNoCloseButton()
		{
			#region Variable Declarations
			DXButton uIDocument0Button = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument0TabPage.UIDocument0Button;
			#endregion
			Assert.AreEqual(this.CheckTabsHaveNoCloseButtonExpectedValues.UIDocument0ButtonExists, uIDocument0Button.Exists);
		}
		public void CheckDockedFormToLeftHorizontalContainerAsTab()
		{
			#region Variable Declarations
			DXTestControl uIDocument3TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument3TabPage;
			#endregion
			Assert.AreEqual(this.CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues.UIDocument3TabPageIndex, uIDocument3TabPage.Index);
			Assert.AreEqual(this.CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues.UIDocument3TabPageGroupIndex, uIDocument3TabPage.GroupIndex);
			Assert.AreEqual(this.CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues.UIDocument3TabPageOrientation, uIDocument3TabPage.Orientation.ToString());
		}
		public void CheckFirstDocumentDockedToRightEdge()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckFirstDocumentDockedToRightEdgeExpectedValues.UIDocument0TabPageOrientation, uIDocument0TabPage.Orientation.ToString());
			Assert.AreEqual(this.CheckFirstDocumentDockedToRightEdgeExpectedValues.UIDocument0TabPageGroupIndex, uIDocument0TabPage.GroupIndex);
			Assert.AreEqual(this.CheckFirstDocumentDockedToRightEdgeExpectedValues.UIDocument0TabPageIndex, uIDocument0TabPage.Index);
		}
		public void CheckFloatDocumentFormClosed()
		{
			#region Variable Declarations
			DXWindow uIDocument3Window = this.UIItemWindow.UIDocument3Window;
			#endregion
			Assert.AreEqual(this.CheckFloatDocumentFormClosedExpectedValues.UIDocument3WindowExists, uIDocument3Window.Exists);
		}
		public void SetInTabControlHeaderOption()
		{
			#region Variable Declarations
			DXRibbonEditItem uIShowCloseButtonRibbonEditItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIRibbonPage1RibbonPage.UIRibbonPageGroup3RibbonPageGroup.UIShowCloseButtonRibbonEditItem;
			DXListBoxItem uIVerticalListItem = this.UIApplicationUILayoutCWindow2.UIRibbonControl1Ribbon.UIImageComboBoxEditComboBox.UIPopupImageComboBoxEdWindow.UIPopupImageComboBoxEdList.UIVerticalListItem;
			#endregion
			Mouse.Click(uIShowCloseButtonRibbonEditItem, new Point(136, 4));
			Mouse.Click(uIVerticalListItem, new Point(83, 8));
		}
		public void ClickTabControlHeaderCloseButton()
		{
			#region Variable Declarations
			DXButton uICloseButton = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIItem0Group.UICloseButton;
			#endregion
			Mouse.Click(uICloseButton, new Point(10, 7));
		}
		public void CheckDocument0Closed()
		{
			#region Variable Declarations
			DXTestControl uIDocument0TabPage = this.UIApplicationUILayoutCWindow2.UIPanelControl1Client.UIGcContainerClient.UIDocumentManagerTabbeCustom.UIDocumentsHostTabList.UIDocument0TabPage;
			#endregion
			Assert.AreEqual(this.CheckDocument0ClosedExpectedValues.UIDocument0TabPageExists, uIDocument0TabPage.Exists);
		}
		#region Properties
		public virtual CheckHiddenUnpinnedPanelExpectedValues CheckHiddenUnpinnedPanelExpectedValues
		{
			get
			{
				if ((this.mCheckHiddenUnpinnedPanelExpectedValues == null))
				{
					this.mCheckHiddenUnpinnedPanelExpectedValues = new CheckHiddenUnpinnedPanelExpectedValues();
				}
				return this.mCheckHiddenUnpinnedPanelExpectedValues;
			}
		}
		public virtual CheckDisplayedPinnedPanelExpectedValues CheckDisplayedPinnedPanelExpectedValues
		{
			get
			{
				if ((this.mCheckDisplayedPinnedPanelExpectedValues == null))
				{
					this.mCheckDisplayedPinnedPanelExpectedValues = new CheckDisplayedPinnedPanelExpectedValues();
				}
				return this.mCheckDisplayedPinnedPanelExpectedValues;
			}
		}
		public virtual RestoreClosedPanelViaClickBarParams RestoreClosedPanelViaClickBarParams
		{
			get
			{
				if ((this.mRestoreClosedPanelViaClickBarParams == null))
				{
					this.mRestoreClosedPanelViaClickBarParams = new RestoreClosedPanelViaClickBarParams();
				}
				return this.mRestoreClosedPanelViaClickBarParams;
			}
		}
		public virtual CheckPanelButtonLocationExpectedValues CheckPanelButtonLocationExpectedValues
		{
			get
			{
				if ((this.mCheckPanelButtonLocationExpectedValues == null))
				{
					this.mCheckPanelButtonLocationExpectedValues = new CheckPanelButtonLocationExpectedValues();
				}
				return this.mCheckPanelButtonLocationExpectedValues;
			}
		}
		public virtual DockPanelToTopEdgeOfFormParams DockPanelToTopEdgeOfFormParams
		{
			get
			{
				if ((this.mDockPanelToTopEdgeOfFormParams == null))
				{
					this.mDockPanelToTopEdgeOfFormParams = new DockPanelToTopEdgeOfFormParams();
				}
				return this.mDockPanelToTopEdgeOfFormParams;
			}
		}
		public virtual DockPanelToRightEdgeOfFormParams DockPanelToRightEdgeOfFormParams
		{
			get
			{
				if ((this.mDockPanelToRightEdgeOfFormParams == null))
				{
					this.mDockPanelToRightEdgeOfFormParams = new DockPanelToRightEdgeOfFormParams();
				}
				return this.mDockPanelToRightEdgeOfFormParams;
			}
		}
		public virtual DockPanelToTopEdgeParams DockPanelToTopEdgeParams
		{
			get
			{
				if ((this.mDockPanelToTopEdgeParams == null))
				{
					this.mDockPanelToTopEdgeParams = new DockPanelToTopEdgeParams();
				}
				return this.mDockPanelToTopEdgeParams;
			}
		}
		public virtual CheckWidthExpectedValues CheckWidthExpectedValues
		{
			get
			{
				if ((this.mCheckWidthExpectedValues == null))
				{
					this.mCheckWidthExpectedValues = new CheckWidthExpectedValues();
				}
				return this.mCheckWidthExpectedValues;
			}
		}
		public virtual DockPanelToRightEdgeParams DockPanelToRightEdgeParams
		{
			get
			{
				if ((this.mDockPanelToRightEdgeParams == null))
				{
					this.mDockPanelToRightEdgeParams = new DockPanelToRightEdgeParams();
				}
				return this.mDockPanelToRightEdgeParams;
			}
		}
		public virtual DockPanelToBottomEdgeParams DockPanelToBottomEdgeParams
		{
			get
			{
				if ((this.mDockPanelToBottomEdgeParams == null))
				{
					this.mDockPanelToBottomEdgeParams = new DockPanelToBottomEdgeParams();
				}
				return this.mDockPanelToBottomEdgeParams;
			}
		}
		public virtual MakePanelFloatViaDraggingParams MakePanelFloatViaDraggingParams
		{
			get
			{
				if ((this.mMakePanelFloatViaDraggingParams == null))
				{
					this.mMakePanelFloatViaDraggingParams = new MakePanelFloatViaDraggingParams();
				}
				return this.mMakePanelFloatViaDraggingParams;
			}
		}
		public virtual CheckFloatPanelDockStyleExpectedValues CheckFloatPanelDockStyleExpectedValues
		{
			get
			{
				if ((this.mCheckFloatPanelDockStyleExpectedValues == null))
				{
					this.mCheckFloatPanelDockStyleExpectedValues = new CheckFloatPanelDockStyleExpectedValues();
				}
				return this.mCheckFloatPanelDockStyleExpectedValues;
			}
		}
		public virtual CheckPanelRestoredDockStyleExpectedValues CheckPanelRestoredDockStyleExpectedValues
		{
			get
			{
				if ((this.mCheckPanelRestoredDockStyleExpectedValues == null))
				{
					this.mCheckPanelRestoredDockStyleExpectedValues = new CheckPanelRestoredDockStyleExpectedValues();
				}
				return this.mCheckPanelRestoredDockStyleExpectedValues;
			}
		}
		public virtual CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues = new CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues;
			}
		}
		public virtual DockPanelToLeftEdgeOfFormParams DockPanelToLeftEdgeOfFormParams
		{
			get
			{
				if ((this.mDockPanelToLeftEdgeOfFormParams == null))
				{
					this.mDockPanelToLeftEdgeOfFormParams = new DockPanelToLeftEdgeOfFormParams();
				}
				return this.mDockPanelToLeftEdgeOfFormParams;
			}
		}
		public virtual CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues = new CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues;
			}
		}
		public virtual CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues = new CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues;
			}
		}
		public virtual DockPanelToBottomEdgeOfFormParams DockPanelToBottomEdgeOfFormParams
		{
			get
			{
				if ((this.mDockPanelToBottomEdgeOfFormParams == null))
				{
					this.mDockPanelToBottomEdgeOfFormParams = new DockPanelToBottomEdgeOfFormParams();
				}
				return this.mDockPanelToBottomEdgeOfFormParams;
			}
		}
		public virtual CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues = new CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues;
			}
		}
		public virtual DockPanelToLeftEdgeParams DockPanelToLeftEdgeParams
		{
			get
			{
				if ((this.mDockPanelToLeftEdgeParams == null))
				{
					this.mDockPanelToLeftEdgeParams = new DockPanelToLeftEdgeParams();
				}
				return this.mDockPanelToLeftEdgeParams;
			}
		}
		public virtual CheckPanelDockStyleDockedToLeftEdgeExpectedValues CheckPanelDockStyleDockedToLeftEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToLeftEdgeExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToLeftEdgeExpectedValues = new CheckPanelDockStyleDockedToLeftEdgeExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToLeftEdgeExpectedValues;
			}
		}
		public virtual CheckPanelDockStyleDockedToRightEdgeExpectedValues CheckPanelDockStyleDockedToRightEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToRightEdgeExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToRightEdgeExpectedValues = new CheckPanelDockStyleDockedToRightEdgeExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToRightEdgeExpectedValues;
			}
		}
		public virtual CheckPanelDockStyleDockedToTopEdgeExpectedValues CheckPanelDockStyleDockedToTopEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToTopEdgeExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToTopEdgeExpectedValues = new CheckPanelDockStyleDockedToTopEdgeExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToTopEdgeExpectedValues;
			}
		}
		public virtual CheckPanelDockStyleDockedToBottomEdgeExpectedValues CheckPanelDockStyleDockedToBottomEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckPanelDockStyleDockedToBottomEdgeExpectedValues == null))
				{
					this.mCheckPanelDockStyleDockedToBottomEdgeExpectedValues = new CheckPanelDockStyleDockedToBottomEdgeExpectedValues();
				}
				return this.mCheckPanelDockStyleDockedToBottomEdgeExpectedValues;
			}
		}
		public virtual DockSimplePanelToTopEdgeOfFormParams DockSimplePanelToTopEdgeOfFormParams
		{
			get
			{
				if ((this.mDockSimplePanelToTopEdgeOfFormParams == null))
				{
					this.mDockSimplePanelToTopEdgeOfFormParams = new DockSimplePanelToTopEdgeOfFormParams();
				}
				return this.mDockSimplePanelToTopEdgeOfFormParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues = new CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues;
			}
		}
		public virtual DockSimplePanelToLeftEdgeOfFormParams DockSimplePanelToLeftEdgeOfFormParams
		{
			get
			{
				if ((this.mDockSimplePanelToLeftEdgeOfFormParams == null))
				{
					this.mDockSimplePanelToLeftEdgeOfFormParams = new DockSimplePanelToLeftEdgeOfFormParams();
				}
				return this.mDockSimplePanelToLeftEdgeOfFormParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues = new CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues;
			}
		}
		public virtual DockSimplePanelToRightEdgeOfFormParams DockSimplePanelToRightEdgeOfFormParams
		{
			get
			{
				if ((this.mDockSimplePanelToRightEdgeOfFormParams == null))
				{
					this.mDockSimplePanelToRightEdgeOfFormParams = new DockSimplePanelToRightEdgeOfFormParams();
				}
				return this.mDockSimplePanelToRightEdgeOfFormParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues = new CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues;
			}
		}
		public virtual DockSimplePanelToBottomEdgeOfFormParams DockSimplePanelToBottomEdgeOfFormParams
		{
			get
			{
				if ((this.mDockSimplePanelToBottomEdgeOfFormParams == null))
				{
					this.mDockSimplePanelToBottomEdgeOfFormParams = new DockSimplePanelToBottomEdgeOfFormParams();
				}
				return this.mDockSimplePanelToBottomEdgeOfFormParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues = new CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues;
			}
		}
		public virtual DockSimplePanelToLeftEdgeParams DockSimplePanelToLeftEdgeParams
		{
			get
			{
				if ((this.mDockSimplePanelToLeftEdgeParams == null))
				{
					this.mDockSimplePanelToLeftEdgeParams = new DockSimplePanelToLeftEdgeParams();
				}
				return this.mDockSimplePanelToLeftEdgeParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues = new CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues;
			}
		}
		public virtual DockSimplePanelToRightEdgeParams DockSimplePanelToRightEdgeParams
		{
			get
			{
				if ((this.mDockSimplePanelToRightEdgeParams == null))
				{
					this.mDockSimplePanelToRightEdgeParams = new DockSimplePanelToRightEdgeParams();
				}
				return this.mDockSimplePanelToRightEdgeParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToRightEdgeExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToRightEdgeExpectedValues = new CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToRightEdgeExpectedValues;
			}
		}
		public virtual DockSimplePanelToTopEdgeParams DockSimplePanelToTopEdgeParams
		{
			get
			{
				if ((this.mDockSimplePanelToTopEdgeParams == null))
				{
					this.mDockSimplePanelToTopEdgeParams = new DockSimplePanelToTopEdgeParams();
				}
				return this.mDockSimplePanelToTopEdgeParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToTopEdgeExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToTopEdgeExpectedValues = new CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToTopEdgeExpectedValues;
			}
		}
		public virtual DockSimplePanelToBottomEdgeParams DockSimplePanelToBottomEdgeParams
		{
			get
			{
				if ((this.mDockSimplePanelToBottomEdgeParams == null))
				{
					this.mDockSimplePanelToBottomEdgeParams = new DockSimplePanelToBottomEdgeParams();
				}
				return this.mDockSimplePanelToBottomEdgeParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues = new CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues;
			}
		}
		public virtual CreateTabContainerViaDockPanelToAnotherPanelParams CreateTabContainerViaDockPanelToAnotherPanelParams
		{
			get
			{
				if ((this.mCreateTabContainerViaDockPanelToAnotherPanelParams == null))
				{
					this.mCreateTabContainerViaDockPanelToAnotherPanelParams = new CreateTabContainerViaDockPanelToAnotherPanelParams();
				}
				return this.mCreateTabContainerViaDockPanelToAnotherPanelParams;
			}
		}
		public virtual CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues
		{
			get
			{
				if ((this.mCheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues == null))
				{
					this.mCheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues = new CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues();
				}
				return this.mCheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues;
			}
		}
		public virtual SwitchToDocumentManagerDockingDemoModuleParams SwitchToDocumentManagerDockingDemoModuleParams
		{
			get
			{
				if ((this.mSwitchToDocumentManagerDockingDemoModuleParams == null))
				{
					this.mSwitchToDocumentManagerDockingDemoModuleParams = new SwitchToDocumentManagerDockingDemoModuleParams();
				}
				return this.mSwitchToDocumentManagerDockingDemoModuleParams;
			}
		}
		public virtual MakeDocumentFormFloatViaDraggingParams MakeDocumentFormFloatViaDraggingParams
		{
			get
			{
				if ((this.mMakeDocumentFormFloatViaDraggingParams == null))
				{
					this.mMakeDocumentFormFloatViaDraggingParams = new MakeDocumentFormFloatViaDraggingParams();
				}
				return this.mMakeDocumentFormFloatViaDraggingParams;
			}
		}
		public virtual DockDocumentFormToLeftEdgeParams DockDocumentFormToLeftEdgeParams
		{
			get
			{
				if ((this.mDockDocumentFormToLeftEdgeParams == null))
				{
					this.mDockDocumentFormToLeftEdgeParams = new DockDocumentFormToLeftEdgeParams();
				}
				return this.mDockDocumentFormToLeftEdgeParams;
			}
		}
		public virtual DockDocumentFormToRightEdgeParams DockDocumentFormToRightEdgeParams
		{
			get
			{
				if ((this.mDockDocumentFormToRightEdgeParams == null))
				{
					this.mDockDocumentFormToRightEdgeParams = new DockDocumentFormToRightEdgeParams();
				}
				return this.mDockDocumentFormToRightEdgeParams;
			}
		}
		public virtual DockDocumentFormToTopEdgeParams DockDocumentFormToTopEdgeParams
		{
			get
			{
				if ((this.mDockDocumentFormToTopEdgeParams == null))
				{
					this.mDockDocumentFormToTopEdgeParams = new DockDocumentFormToTopEdgeParams();
				}
				return this.mDockDocumentFormToTopEdgeParams;
			}
		}
		public virtual DockDocumentFormToBottomEdgeParams DockDocumentFormToBottomEdgeParams
		{
			get
			{
				if ((this.mDockDocumentFormToBottomEdgeParams == null))
				{
					this.mDockDocumentFormToBottomEdgeParams = new DockDocumentFormToBottomEdgeParams();
				}
				return this.mDockDocumentFormToBottomEdgeParams;
			}
		}
		public virtual ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams
		{
			get
			{
				if ((this.mChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams == null))
				{
					this.mChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams = new ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams();
				}
				return this.mChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams;
			}
		}
		public virtual ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams
		{
			get
			{
				if ((this.mChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams == null))
				{
					this.mChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams = new ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams();
				}
				return this.mChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams;
			}
		}
		public virtual MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams == null))
				{
					this.mMakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams = new MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams();
				}
				return this.mMakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams;
			}
		}
		public virtual MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams == null))
				{
					this.mMakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams = new MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams();
				}
				return this.mMakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams;
			}
		}
		public virtual MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams == null))
				{
					this.mMakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams = new MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams();
				}
				return this.mMakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams;
			}
		}
		public virtual MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams == null))
				{
					this.mMakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams = new MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams();
				}
				return this.mMakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams;
			}
		}
		public virtual DockPanelToDocumentFormParams DockPanelToDocumentFormParams
		{
			get
			{
				if ((this.mDockPanelToDocumentFormParams == null))
				{
					this.mDockPanelToDocumentFormParams = new DockPanelToDocumentFormParams();
				}
				return this.mDockPanelToDocumentFormParams;
			}
		}
		public virtual DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams
		{
			get
			{
				if ((this.mDockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams == null))
				{
					this.mDockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams = new DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams();
				}
				return this.mDockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams;
			}
		}
		public virtual SwitchToDocumentManagerNativeMdiViewDemoModuleParams SwitchToDocumentManagerNativeMdiViewDemoModuleParams
		{
			get
			{
				if ((this.mSwitchToDocumentManagerNativeMdiViewDemoModuleParams == null))
				{
					this.mSwitchToDocumentManagerNativeMdiViewDemoModuleParams = new SwitchToDocumentManagerNativeMdiViewDemoModuleParams();
				}
				return this.mSwitchToDocumentManagerNativeMdiViewDemoModuleParams;
			}
		}
		public virtual SwitchToDocumentManagerTabbedViewDemoModuleParams SwitchToDocumentManagerTabbedViewDemoModuleParams
		{
			get
			{
				if ((this.mSwitchToDocumentManagerTabbedViewDemoModuleParams == null))
				{
					this.mSwitchToDocumentManagerTabbedViewDemoModuleParams = new SwitchToDocumentManagerTabbedViewDemoModuleParams();
				}
				return this.mSwitchToDocumentManagerTabbedViewDemoModuleParams;
			}
		}
		public virtual MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams == null))
				{
					this.mMakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams = new MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams();
				}
				return this.mMakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams;
			}
		}
		public virtual CheckLeftPanelInHorizontalSplitContainerExpectedValues CheckLeftPanelInHorizontalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckLeftPanelInHorizontalSplitContainerExpectedValues == null))
				{
					this.mCheckLeftPanelInHorizontalSplitContainerExpectedValues = new CheckLeftPanelInHorizontalSplitContainerExpectedValues();
				}
				return this.mCheckLeftPanelInHorizontalSplitContainerExpectedValues;
			}
		}
		public virtual MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams == null))
				{
					this.mMakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams = new MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams();
				}
				return this.mMakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams;
			}
		}
		public virtual CheckRightPanelInHorizontalSplitContainerExpectedValues CheckRightPanelInHorizontalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckRightPanelInHorizontalSplitContainerExpectedValues == null))
				{
					this.mCheckRightPanelInHorizontalSplitContainerExpectedValues = new CheckRightPanelInHorizontalSplitContainerExpectedValues();
				}
				return this.mCheckRightPanelInHorizontalSplitContainerExpectedValues;
			}
		}
		public virtual MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams == null))
				{
					this.mMakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams = new MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams();
				}
				return this.mMakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams;
			}
		}
		public virtual CheckTopPanelInVerticalSplitContainerExpectedValues CheckTopPanelInVerticalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckTopPanelInVerticalSplitContainerExpectedValues == null))
				{
					this.mCheckTopPanelInVerticalSplitContainerExpectedValues = new CheckTopPanelInVerticalSplitContainerExpectedValues();
				}
				return this.mCheckTopPanelInVerticalSplitContainerExpectedValues;
			}
		}
		public virtual MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams
		{
			get
			{
				if ((this.mMakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams == null))
				{
					this.mMakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams = new MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams();
				}
				return this.mMakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams;
			}
		}
		public virtual CheckBottomPanelInVerticalSplitContainerExpectedValues CheckBottomPanelInVerticalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckBottomPanelInVerticalSplitContainerExpectedValues == null))
				{
					this.mCheckBottomPanelInVerticalSplitContainerExpectedValues = new CheckBottomPanelInVerticalSplitContainerExpectedValues();
				}
				return this.mCheckBottomPanelInVerticalSplitContainerExpectedValues;
			}
		}
		public virtual DockPanelToFormViaDraggingParams DockPanelToFormViaDraggingParams
		{
			get
			{
				if ((this.mDockPanelToFormViaDraggingParams == null))
				{
					this.mDockPanelToFormViaDraggingParams = new DockPanelToFormViaDraggingParams();
				}
				return this.mDockPanelToFormViaDraggingParams;
			}
		}
		public virtual CheckDockingPanelToFormViaContextMenuOptionExpectedValues CheckDockingPanelToFormViaContextMenuOptionExpectedValues
		{
			get
			{
				if ((this.mCheckDockingPanelToFormViaContextMenuOptionExpectedValues == null))
				{
					this.mCheckDockingPanelToFormViaContextMenuOptionExpectedValues = new CheckDockingPanelToFormViaContextMenuOptionExpectedValues();
				}
				return this.mCheckDockingPanelToFormViaContextMenuOptionExpectedValues;
			}
		}
		public virtual DockFloatPanelToFormViaDraggingParams DockFloatPanelToFormViaDraggingParams
		{
			get
			{
				if ((this.mDockFloatPanelToFormViaDraggingParams == null))
				{
					this.mDockFloatPanelToFormViaDraggingParams = new DockFloatPanelToFormViaDraggingParams();
				}
				return this.mDockFloatPanelToFormViaDraggingParams;
			}
		}
		public virtual CheckDockingPanelToFormExpectedValues CheckDockingPanelToFormExpectedValues
		{
			get
			{
				if ((this.mCheckDockingPanelToFormExpectedValues == null))
				{
					this.mCheckDockingPanelToFormExpectedValues = new CheckDockingPanelToFormExpectedValues();
				}
				return this.mCheckDockingPanelToFormExpectedValues;
			}
		}
		public virtual ChangeTabPositionInPanelContainerParams ChangeTabPositionInPanelContainerParams
		{
			get
			{
				if ((this.mChangeTabPositionInPanelContainerParams == null))
				{
					this.mChangeTabPositionInPanelContainerParams = new ChangeTabPositionInPanelContainerParams();
				}
				return this.mChangeTabPositionInPanelContainerParams;
			}
		}
		public virtual CheckPanelContainerTabIndexesExpectedValues CheckPanelContainerTabIndexesExpectedValues
		{
			get
			{
				if ((this.mCheckPanelContainerTabIndexesExpectedValues == null))
				{
					this.mCheckPanelContainerTabIndexesExpectedValues = new CheckPanelContainerTabIndexesExpectedValues();
				}
				return this.mCheckPanelContainerTabIndexesExpectedValues;
			}
		}
		public virtual ClickDocumentFormMinimizeButtonParams ClickDocumentFormMinimizeButtonParams
		{
			get
			{
				if ((this.mClickDocumentFormMinimizeButtonParams == null))
				{
					this.mClickDocumentFormMinimizeButtonParams = new ClickDocumentFormMinimizeButtonParams();
				}
				return this.mClickDocumentFormMinimizeButtonParams;
			}
		}
		public virtual ClickDocumentFormMaximizeButtonParams ClickDocumentFormMaximizeButtonParams
		{
			get
			{
				if ((this.mClickDocumentFormMaximizeButtonParams == null))
				{
					this.mClickDocumentFormMaximizeButtonParams = new ClickDocumentFormMaximizeButtonParams();
				}
				return this.mClickDocumentFormMaximizeButtonParams;
			}
		}
		public virtual CloseMaximizedDocumentFormParams CloseMaximizedDocumentFormParams
		{
			get
			{
				if ((this.mCloseMaximizedDocumentFormParams == null))
				{
					this.mCloseMaximizedDocumentFormParams = new CloseMaximizedDocumentFormParams();
				}
				return this.mCloseMaximizedDocumentFormParams;
			}
		}
		public virtual DockPanelToAnotherPanelParams DockPanelToAnotherPanelParams
		{
			get
			{
				if ((this.mDockPanelToAnotherPanelParams == null))
				{
					this.mDockPanelToAnotherPanelParams = new DockPanelToAnotherPanelParams();
				}
				return this.mDockPanelToAnotherPanelParams;
			}
		}
		public virtual CheckDockingPanelToAnotherPanelExpectedValues CheckDockingPanelToAnotherPanelExpectedValues
		{
			get
			{
				if ((this.mCheckDockingPanelToAnotherPanelExpectedValues == null))
				{
					this.mCheckDockingPanelToAnotherPanelExpectedValues = new CheckDockingPanelToAnotherPanelExpectedValues();
				}
				return this.mCheckDockingPanelToAnotherPanelExpectedValues;
			}
		}
		public virtual CheckUnpinnedPanelFloatDockStyleExpectedValues CheckUnpinnedPanelFloatDockStyleExpectedValues
		{
			get
			{
				if ((this.mCheckUnpinnedPanelFloatDockStyleExpectedValues == null))
				{
					this.mCheckUnpinnedPanelFloatDockStyleExpectedValues = new CheckUnpinnedPanelFloatDockStyleExpectedValues();
				}
				return this.mCheckUnpinnedPanelFloatDockStyleExpectedValues;
			}
		}
		public virtual CheckDockingPanelToAnotherPanelAsTabExpectedValues CheckDockingPanelToAnotherPanelAsTabExpectedValues
		{
			get
			{
				if ((this.mCheckDockingPanelToAnotherPanelAsTabExpectedValues == null))
				{
					this.mCheckDockingPanelToAnotherPanelAsTabExpectedValues = new CheckDockingPanelToAnotherPanelAsTabExpectedValues();
				}
				return this.mCheckDockingPanelToAnotherPanelAsTabExpectedValues;
			}
		}
		public virtual CheckNewDocumentFormCaptionExpectedValues CheckNewDocumentFormCaptionExpectedValues
		{
			get
			{
				if ((this.mCheckNewDocumentFormCaptionExpectedValues == null))
				{
					this.mCheckNewDocumentFormCaptionExpectedValues = new CheckNewDocumentFormCaptionExpectedValues();
				}
				return this.mCheckNewDocumentFormCaptionExpectedValues;
			}
		}
		public virtual CloseFloatDocumentFormViaClickCloseButtonParams CloseFloatDocumentFormViaClickCloseButtonParams
		{
			get
			{
				if ((this.mCloseFloatDocumentFormViaClickCloseButtonParams == null))
				{
					this.mCloseFloatDocumentFormViaClickCloseButtonParams = new CloseFloatDocumentFormViaClickCloseButtonParams();
				}
				return this.mCloseFloatDocumentFormViaClickCloseButtonParams;
			}
		}
		public virtual MaximizeFloatDocumentFormViaClickMaximizeButtonParams MaximizeFloatDocumentFormViaClickMaximizeButtonParams
		{
			get
			{
				if ((this.mMaximizeFloatDocumentFormViaClickMaximizeButtonParams == null))
				{
					this.mMaximizeFloatDocumentFormViaClickMaximizeButtonParams = new MaximizeFloatDocumentFormViaClickMaximizeButtonParams();
				}
				return this.mMaximizeFloatDocumentFormViaClickMaximizeButtonParams;
			}
		}
		public virtual MinimizeFloatDocumentFormViaClickRestoreButtonParams MinimizeFloatDocumentFormViaClickRestoreButtonParams
		{
			get
			{
				if ((this.mMinimizeFloatDocumentFormViaClickRestoreButtonParams == null))
				{
					this.mMinimizeFloatDocumentFormViaClickRestoreButtonParams = new MinimizeFloatDocumentFormViaClickRestoreButtonParams();
				}
				return this.mMinimizeFloatDocumentFormViaClickRestoreButtonParams;
			}
		}
		public virtual DockDocumentFormToTabbedViewLeftEdgeParams DockDocumentFormToTabbedViewLeftEdgeParams
		{
			get
			{
				if ((this.mDockDocumentFormToTabbedViewLeftEdgeParams == null))
				{
					this.mDockDocumentFormToTabbedViewLeftEdgeParams = new DockDocumentFormToTabbedViewLeftEdgeParams();
				}
				return this.mDockDocumentFormToTabbedViewLeftEdgeParams;
			}
		}
		public virtual DockDocumentFormToTabbedViewRightEdgeParams DockDocumentFormToTabbedViewRightEdgeParams
		{
			get
			{
				if ((this.mDockDocumentFormToTabbedViewRightEdgeParams == null))
				{
					this.mDockDocumentFormToTabbedViewRightEdgeParams = new DockDocumentFormToTabbedViewRightEdgeParams();
				}
				return this.mDockDocumentFormToTabbedViewRightEdgeParams;
			}
		}
		public virtual DockDocumentFormToLeftHorizontalContainerAsTabParams DockDocumentFormToLeftHorizontalContainerAsTabParams
		{
			get
			{
				if ((this.mDockDocumentFormToLeftHorizontalContainerAsTabParams == null))
				{
					this.mDockDocumentFormToLeftHorizontalContainerAsTabParams = new DockDocumentFormToLeftHorizontalContainerAsTabParams();
				}
				return this.mDockDocumentFormToLeftHorizontalContainerAsTabParams;
			}
		}
		public virtual DockFloatDocumentFormToTabbedViewLeftEdgeParams DockFloatDocumentFormToTabbedViewLeftEdgeParams
		{
			get
			{
				if ((this.mDockFloatDocumentFormToTabbedViewLeftEdgeParams == null))
				{
					this.mDockFloatDocumentFormToTabbedViewLeftEdgeParams = new DockFloatDocumentFormToTabbedViewLeftEdgeParams();
				}
				return this.mDockFloatDocumentFormToTabbedViewLeftEdgeParams;
			}
		}
		public virtual DockFloatDocumentFormToTabbedViewRightEdgeParams DockFloatDocumentFormToTabbedViewRightEdgeParams
		{
			get
			{
				if ((this.mDockFloatDocumentFormToTabbedViewRightEdgeParams == null))
				{
					this.mDockFloatDocumentFormToTabbedViewRightEdgeParams = new DockFloatDocumentFormToTabbedViewRightEdgeParams();
				}
				return this.mDockFloatDocumentFormToTabbedViewRightEdgeParams;
			}
		}
		public virtual MakeTabbedViewDocumentFormFloatViaDraggingParams MakeTabbedViewDocumentFormFloatViaDraggingParams
		{
			get
			{
				if ((this.mMakeTabbedViewDocumentFormFloatViaDraggingParams == null))
				{
					this.mMakeTabbedViewDocumentFormFloatViaDraggingParams = new MakeTabbedViewDocumentFormFloatViaDraggingParams();
				}
				return this.mMakeTabbedViewDocumentFormFloatViaDraggingParams;
			}
		}
		public virtual DockFloatDocumentFormToLeftHorizontalContainerAsTabParams DockFloatDocumentFormToLeftHorizontalContainerAsTabParams
		{
			get
			{
				if ((this.mDockFloatDocumentFormToLeftHorizontalContainerAsTabParams == null))
				{
					this.mDockFloatDocumentFormToLeftHorizontalContainerAsTabParams = new DockFloatDocumentFormToLeftHorizontalContainerAsTabParams();
				}
				return this.mDockFloatDocumentFormToLeftHorizontalContainerAsTabParams;
			}
		}
		public virtual CloseTabbedViewFloatDocumentFormViaCloseButtonParams CloseTabbedViewFloatDocumentFormViaCloseButtonParams
		{
			get
			{
				if ((this.mCloseTabbedViewFloatDocumentFormViaCloseButtonParams == null))
				{
					this.mCloseTabbedViewFloatDocumentFormViaCloseButtonParams = new CloseTabbedViewFloatDocumentFormViaCloseButtonParams();
				}
				return this.mCloseTabbedViewFloatDocumentFormViaCloseButtonParams;
			}
		}
		public virtual MakeVerticalContainerViaDockingDocumentFormToTopEdgeParams MakeVerticalContainerViaDockingDocumentFormToTopEdgeParams
		{
			get
			{
				if ((this.mMakeVerticalContainerViaDockingDocumentFormToTopEdgeParams == null))
				{
					this.mMakeVerticalContainerViaDockingDocumentFormToTopEdgeParams = new MakeVerticalContainerViaDockingDocumentFormToTopEdgeParams();
				}
				return this.mMakeVerticalContainerViaDockingDocumentFormToTopEdgeParams;
			}
		}
		public virtual MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams
		{
			get
			{
				if ((this.mMakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams == null))
				{
					this.mMakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams = new MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams();
				}
				return this.mMakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams;
			}
		}
		public virtual SwitchToTabbedMDIDemoModuleParams SwitchToTabbedMDIDemoModuleParams
		{
			get
			{
				if ((this.mSwitchToTabbedMDIDemoModuleParams == null))
				{
					this.mSwitchToTabbedMDIDemoModuleParams = new SwitchToTabbedMDIDemoModuleParams();
				}
				return this.mSwitchToTabbedMDIDemoModuleParams;
			}
		}
		public virtual MakeTabbedMDIDocumentFormFloatViaDraggingParams MakeTabbedMDIDocumentFormFloatViaDraggingParams
		{
			get
			{
				if ((this.mMakeTabbedMDIDocumentFormFloatViaDraggingParams == null))
				{
					this.mMakeTabbedMDIDocumentFormFloatViaDraggingParams = new MakeTabbedMDIDocumentFormFloatViaDraggingParams();
				}
				return this.mMakeTabbedMDIDocumentFormFloatViaDraggingParams;
			}
		}
		public virtual CheckFloatTabbedMDIDocumentFormExpectedValues CheckFloatTabbedMDIDocumentFormExpectedValues
		{
			get
			{
				if ((this.mCheckFloatTabbedMDIDocumentFormExpectedValues == null))
				{
					this.mCheckFloatTabbedMDIDocumentFormExpectedValues = new CheckFloatTabbedMDIDocumentFormExpectedValues();
				}
				return this.mCheckFloatTabbedMDIDocumentFormExpectedValues;
			}
		}
		public virtual DockFloatTabbedMDIDocumentFormAsTabParams DockFloatTabbedMDIDocumentFormAsTabParams
		{
			get
			{
				if ((this.mDockFloatTabbedMDIDocumentFormAsTabParams == null))
				{
					this.mDockFloatTabbedMDIDocumentFormAsTabParams = new DockFloatTabbedMDIDocumentFormAsTabParams();
				}
				return this.mDockFloatTabbedMDIDocumentFormAsTabParams;
			}
		}
		public virtual UncheckFloatOnDragOptionParams UncheckFloatOnDragOptionParams
		{
			get
			{
				if ((this.mUncheckFloatOnDragOptionParams == null))
				{
					this.mUncheckFloatOnDragOptionParams = new UncheckFloatOnDragOptionParams();
				}
				return this.mUncheckFloatOnDragOptionParams;
			}
		}
		public virtual DragTabbedMDIDocumentFormParams DragTabbedMDIDocumentFormParams
		{
			get
			{
				if ((this.mDragTabbedMDIDocumentFormParams == null))
				{
					this.mDragTabbedMDIDocumentFormParams = new DragTabbedMDIDocumentFormParams();
				}
				return this.mDragTabbedMDIDocumentFormParams;
			}
		}
		public virtual CheckConservationTabbedMDIDocumentFormIndexExpectedValues CheckConservationTabbedMDIDocumentFormIndexExpectedValues
		{
			get
			{
				if ((this.mCheckConservationTabbedMDIDocumentFormIndexExpectedValues == null))
				{
					this.mCheckConservationTabbedMDIDocumentFormIndexExpectedValues = new CheckConservationTabbedMDIDocumentFormIndexExpectedValues();
				}
				return this.mCheckConservationTabbedMDIDocumentFormIndexExpectedValues;
			}
		}
		public virtual UncheckFloatOnDoubleClickOptionParams UncheckFloatOnDoubleClickOptionParams
		{
			get
			{
				if ((this.mUncheckFloatOnDoubleClickOptionParams == null))
				{
					this.mUncheckFloatOnDoubleClickOptionParams = new UncheckFloatOnDoubleClickOptionParams();
				}
				return this.mUncheckFloatOnDoubleClickOptionParams;
			}
		}
		public virtual ChangeClosePageButtonInTabbedMDIDemoModuleParams ChangeClosePageButtonInTabbedMDIDemoModuleParams
		{
			get
			{
				if ((this.mChangeClosePageButtonInTabbedMDIDemoModuleParams == null))
				{
					this.mChangeClosePageButtonInTabbedMDIDemoModuleParams = new ChangeClosePageButtonInTabbedMDIDemoModuleParams();
				}
				return this.mChangeClosePageButtonInTabbedMDIDemoModuleParams;
			}
		}
		public virtual CheckClosedTabbedMDIDocumentFormExpectedValues CheckClosedTabbedMDIDocumentFormExpectedValues
		{
			get
			{
				if ((this.mCheckClosedTabbedMDIDocumentFormExpectedValues == null))
				{
					this.mCheckClosedTabbedMDIDocumentFormExpectedValues = new CheckClosedTabbedMDIDocumentFormExpectedValues();
				}
				return this.mCheckClosedTabbedMDIDocumentFormExpectedValues;
			}
		}
		public virtual ReorderMDITabsParams ReorderMDITabsParams
		{
			get
			{
				if ((this.mReorderMDITabsParams == null))
				{
					this.mReorderMDITabsParams = new ReorderMDITabsParams();
				}
				return this.mReorderMDITabsParams;
			}
		}
		public virtual CheckMDITabIndexExpectedValues CheckMDITabIndexExpectedValues
		{
			get
			{
				if ((this.mCheckMDITabIndexExpectedValues == null))
				{
					this.mCheckMDITabIndexExpectedValues = new CheckMDITabIndexExpectedValues();
				}
				return this.mCheckMDITabIndexExpectedValues;
			}
		}
		public virtual ChangeTabbedMDIHeaderLocationParams ChangeTabbedMDIHeaderLocationParams
		{
			get
			{
				if ((this.mChangeTabbedMDIHeaderLocationParams == null))
				{
					this.mChangeTabbedMDIHeaderLocationParams = new ChangeTabbedMDIHeaderLocationParams();
				}
				return this.mChangeTabbedMDIHeaderLocationParams;
			}
		}
		public virtual ChangeTabbedMDIHeaderOrientationParams ChangeTabbedMDIHeaderOrientationParams
		{
			get
			{
				if ((this.mChangeTabbedMDIHeaderOrientationParams == null))
				{
					this.mChangeTabbedMDIHeaderOrientationParams = new ChangeTabbedMDIHeaderOrientationParams();
				}
				return this.mChangeTabbedMDIHeaderOrientationParams;
			}
		}
		public virtual ReorderTabsInTabbedViewDemoModuleParams ReorderTabsInTabbedViewDemoModuleParams
		{
			get
			{
				if ((this.mReorderTabsInTabbedViewDemoModuleParams == null))
				{
					this.mReorderTabsInTabbedViewDemoModuleParams = new ReorderTabsInTabbedViewDemoModuleParams();
				}
				return this.mReorderTabsInTabbedViewDemoModuleParams;
			}
		}
		public virtual CheckTabIndexInTabbedViewDemoModuleExpectedValues CheckTabIndexInTabbedViewDemoModuleExpectedValues
		{
			get
			{
				if ((this.mCheckTabIndexInTabbedViewDemoModuleExpectedValues == null))
				{
					this.mCheckTabIndexInTabbedViewDemoModuleExpectedValues = new CheckTabIndexInTabbedViewDemoModuleExpectedValues();
				}
				return this.mCheckTabIndexInTabbedViewDemoModuleExpectedValues;
			}
		}
		public virtual ChangeShowCloseButtonModeParams ChangeShowCloseButtonModeParams
		{
			get
			{
				if ((this.mChangeShowCloseButtonModeParams == null))
				{
					this.mChangeShowCloseButtonModeParams = new ChangeShowCloseButtonModeParams();
				}
				return this.mChangeShowCloseButtonModeParams;
			}
		}
		public virtual SwitchOnHeaderAutoFillOptionParams SwitchOnHeaderAutoFillOptionParams
		{
			get
			{
				if ((this.mSwitchOnHeaderAutoFillOptionParams == null))
				{
					this.mSwitchOnHeaderAutoFillOptionParams = new SwitchOnHeaderAutoFillOptionParams();
				}
				return this.mSwitchOnHeaderAutoFillOptionParams;
			}
		}
		public virtual CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues == null))
				{
					this.mCheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues = new CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues();
				}
				return this.mCheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues;
			}
		}
		public virtual CreateTabContainerFromTwoUntitledPanelsParams CreateTabContainerFromTwoUntitledPanelsParams
		{
			get
			{
				if ((this.mCreateTabContainerFromTwoUntitledPanelsParams == null))
				{
					this.mCreateTabContainerFromTwoUntitledPanelsParams = new CreateTabContainerFromTwoUntitledPanelsParams();
				}
				return this.mCreateTabContainerFromTwoUntitledPanelsParams;
			}
		}
		public virtual CheckTabContainerFromTwoUntitledPanelsExpectedValues CheckTabContainerFromTwoUntitledPanelsExpectedValues
		{
			get
			{
				if ((this.mCheckTabContainerFromTwoUntitledPanelsExpectedValues == null))
				{
					this.mCheckTabContainerFromTwoUntitledPanelsExpectedValues = new CheckTabContainerFromTwoUntitledPanelsExpectedValues();
				}
				return this.mCheckTabContainerFromTwoUntitledPanelsExpectedValues;
			}
		}
		public virtual CreateSplitContainerFromTwoUntitledPanelsParams CreateSplitContainerFromTwoUntitledPanelsParams
		{
			get
			{
				if ((this.mCreateSplitContainerFromTwoUntitledPanelsParams == null))
				{
					this.mCreateSplitContainerFromTwoUntitledPanelsParams = new CreateSplitContainerFromTwoUntitledPanelsParams();
				}
				return this.mCreateSplitContainerFromTwoUntitledPanelsParams;
			}
		}
		public virtual CheckSplitContainerFromTwoUntitledPanelsExpectedValues CheckSplitContainerFromTwoUntitledPanelsExpectedValues
		{
			get
			{
				if ((this.mCheckSplitContainerFromTwoUntitledPanelsExpectedValues == null))
				{
					this.mCheckSplitContainerFromTwoUntitledPanelsExpectedValues = new CheckSplitContainerFromTwoUntitledPanelsExpectedValues();
				}
				return this.mCheckSplitContainerFromTwoUntitledPanelsExpectedValues;
			}
		}
		public virtual DockTabContainerFromTwoUntitledPanelsParams DockTabContainerFromTwoUntitledPanelsParams
		{
			get
			{
				if ((this.mDockTabContainerFromTwoUntitledPanelsParams == null))
				{
					this.mDockTabContainerFromTwoUntitledPanelsParams = new DockTabContainerFromTwoUntitledPanelsParams();
				}
				return this.mDockTabContainerFromTwoUntitledPanelsParams;
			}
		}
		public virtual CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues
		{
			get
			{
				if ((this.mCheckDockingTabContainerFromTwoUntitledPanelsExpectedValues == null))
				{
					this.mCheckDockingTabContainerFromTwoUntitledPanelsExpectedValues = new CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues();
				}
				return this.mCheckDockingTabContainerFromTwoUntitledPanelsExpectedValues;
			}
		}
		public virtual CreateSplitContainerFromTabContainerAndUntitledPanelParams CreateSplitContainerFromTabContainerAndUntitledPanelParams
		{
			get
			{
				if ((this.mCreateSplitContainerFromTabContainerAndUntitledPanelParams == null))
				{
					this.mCreateSplitContainerFromTabContainerAndUntitledPanelParams = new CreateSplitContainerFromTabContainerAndUntitledPanelParams();
				}
				return this.mCreateSplitContainerFromTabContainerAndUntitledPanelParams;
			}
		}
		public virtual CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues
		{
			get
			{
				if ((this.mCheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues == null))
				{
					this.mCheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues = new CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues();
				}
				return this.mCheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues;
			}
		}
		public virtual CreateSecondTabContainerFromTwoUntitledPanelsParams CreateSecondTabContainerFromTwoUntitledPanelsParams
		{
			get
			{
				if ((this.mCreateSecondTabContainerFromTwoUntitledPanelsParams == null))
				{
					this.mCreateSecondTabContainerFromTwoUntitledPanelsParams = new CreateSecondTabContainerFromTwoUntitledPanelsParams();
				}
				return this.mCreateSecondTabContainerFromTwoUntitledPanelsParams;
			}
		}
		public virtual CreateSplitContainerFromTwoTabContainersParams CreateSplitContainerFromTwoTabContainersParams
		{
			get
			{
				if ((this.mCreateSplitContainerFromTwoTabContainersParams == null))
				{
					this.mCreateSplitContainerFromTwoTabContainersParams = new CreateSplitContainerFromTwoTabContainersParams();
				}
				return this.mCreateSplitContainerFromTwoTabContainersParams;
			}
		}
		public virtual CheckSplitContainerFromTwoTabContainersExpectedValues CheckSplitContainerFromTwoTabContainersExpectedValues
		{
			get
			{
				if ((this.mCheckSplitContainerFromTwoTabContainersExpectedValues == null))
				{
					this.mCheckSplitContainerFromTwoTabContainersExpectedValues = new CheckSplitContainerFromTwoTabContainersExpectedValues();
				}
				return this.mCheckSplitContainerFromTwoTabContainersExpectedValues;
			}
		}
		public virtual CreateTabContainerFromTwoTabContainersParams CreateTabContainerFromTwoTabContainersParams
		{
			get
			{
				if ((this.mCreateTabContainerFromTwoTabContainersParams == null))
				{
					this.mCreateTabContainerFromTwoTabContainersParams = new CreateTabContainerFromTwoTabContainersParams();
				}
				return this.mCreateTabContainerFromTwoTabContainersParams;
			}
		}
		public virtual CheckTabContainerFromTwoTabContainersExpectedValues CheckTabContainerFromTwoTabContainersExpectedValues
		{
			get
			{
				if ((this.mCheckTabContainerFromTwoTabContainersExpectedValues == null))
				{
					this.mCheckTabContainerFromTwoTabContainersExpectedValues = new CheckTabContainerFromTwoTabContainersExpectedValues();
				}
				return this.mCheckTabContainerFromTwoTabContainersExpectedValues;
			}
		}
		public virtual CheckDockedTabbedMDIDocumentFormAsTabExpectedValues CheckDockedTabbedMDIDocumentFormAsTabExpectedValues
		{
			get
			{
				if ((this.mCheckDockedTabbedMDIDocumentFormAsTabExpectedValues == null))
				{
					this.mCheckDockedTabbedMDIDocumentFormAsTabExpectedValues = new CheckDockedTabbedMDIDocumentFormAsTabExpectedValues();
				}
				return this.mCheckDockedTabbedMDIDocumentFormAsTabExpectedValues;
			}
		}
		public virtual CheckLastDocumentIsVisibleExpectedValues CheckLastDocumentIsVisibleExpectedValues
		{
			get
			{
				if ((this.mCheckLastDocumentIsVisibleExpectedValues == null))
				{
					this.mCheckLastDocumentIsVisibleExpectedValues = new CheckLastDocumentIsVisibleExpectedValues();
				}
				return this.mCheckLastDocumentIsVisibleExpectedValues;
			}
		}
		public virtual CheckFloatDocumentFormDoesNotExistExpectedValues CheckFloatDocumentFormDoesNotExistExpectedValues
		{
			get
			{
				if ((this.mCheckFloatDocumentFormDoesNotExistExpectedValues == null))
				{
					this.mCheckFloatDocumentFormDoesNotExistExpectedValues = new CheckFloatDocumentFormDoesNotExistExpectedValues();
				}
				return this.mCheckFloatDocumentFormDoesNotExistExpectedValues;
			}
		}
		public virtual CheckFloatingDocumentFormDockStyleExpectedValues CheckFloatingDocumentFormDockStyleExpectedValues
		{
			get
			{
				if ((this.mCheckFloatingDocumentFormDockStyleExpectedValues == null))
				{
					this.mCheckFloatingDocumentFormDockStyleExpectedValues = new CheckFloatingDocumentFormDockStyleExpectedValues();
				}
				return this.mCheckFloatingDocumentFormDockStyleExpectedValues;
			}
		}
		public virtual CheckDocumentManagerTabIndexExpectedValues CheckDocumentManagerTabIndexExpectedValues
		{
			get
			{
				if ((this.mCheckDocumentManagerTabIndexExpectedValues == null))
				{
					this.mCheckDocumentManagerTabIndexExpectedValues = new CheckDocumentManagerTabIndexExpectedValues();
				}
				return this.mCheckDocumentManagerTabIndexExpectedValues;
			}
		}
		public virtual CheckDockedFormToLeftEdgeExpectedValues CheckDockedFormToLeftEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToLeftEdgeExpectedValues == null))
				{
					this.mCheckDockedFormToLeftEdgeExpectedValues = new CheckDockedFormToLeftEdgeExpectedValues();
				}
				return this.mCheckDockedFormToLeftEdgeExpectedValues;
			}
		}
		public virtual CheckDockedFormToRightEdgeExpectedValues CheckDockedFormToRightEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToRightEdgeExpectedValues == null))
				{
					this.mCheckDockedFormToRightEdgeExpectedValues = new CheckDockedFormToRightEdgeExpectedValues();
				}
				return this.mCheckDockedFormToRightEdgeExpectedValues;
			}
		}
		public virtual CheckDockedFormToTopEdgeExpectedValues CheckDockedFormToTopEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToTopEdgeExpectedValues == null))
				{
					this.mCheckDockedFormToTopEdgeExpectedValues = new CheckDockedFormToTopEdgeExpectedValues();
				}
				return this.mCheckDockedFormToTopEdgeExpectedValues;
			}
		}
		public virtual CheckDockedFormToBottomEdgeExpectedValues CheckDockedFormToBottomEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToBottomEdgeExpectedValues == null))
				{
					this.mCheckDockedFormToBottomEdgeExpectedValues = new CheckDockedFormToBottomEdgeExpectedValues();
				}
				return this.mCheckDockedFormToBottomEdgeExpectedValues;
			}
		}
		public virtual CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues == null))
				{
					this.mCheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues = new CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues();
				}
				return this.mCheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues;
			}
		}
		public virtual CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues == null))
				{
					this.mCheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues = new CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues();
				}
				return this.mCheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues;
			}
		}
		public virtual CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues == null))
				{
					this.mCheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues = new CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues();
				}
				return this.mCheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues;
			}
		}
		public virtual CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues
		{
			get
			{
				if ((this.mCheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues == null))
				{
					this.mCheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues = new CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues();
				}
				return this.mCheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues;
			}
		}
		public virtual CheckDockedPanelToDocumentFormExpectedValues CheckDockedPanelToDocumentFormExpectedValues
		{
			get
			{
				if ((this.mCheckDockedPanelToDocumentFormExpectedValues == null))
				{
					this.mCheckDockedPanelToDocumentFormExpectedValues = new CheckDockedPanelToDocumentFormExpectedValues();
				}
				return this.mCheckDockedPanelToDocumentFormExpectedValues;
			}
		}
		public virtual CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues
		{
			get
			{
				if ((this.mCheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues == null))
				{
					this.mCheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues = new CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues();
				}
				return this.mCheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues;
			}
		}
		public virtual CheckFirstDocumentIsActiveExpectedValues CheckFirstDocumentIsActiveExpectedValues
		{
			get
			{
				if ((this.mCheckFirstDocumentIsActiveExpectedValues == null))
				{
					this.mCheckFirstDocumentIsActiveExpectedValues = new CheckFirstDocumentIsActiveExpectedValues();
				}
				return this.mCheckFirstDocumentIsActiveExpectedValues;
			}
		}
		public virtual CheckClosedDocumentFormViaDialogWindowsFormExpectedValues CheckClosedDocumentFormViaDialogWindowsFormExpectedValues
		{
			get
			{
				if ((this.mCheckClosedDocumentFormViaDialogWindowsFormExpectedValues == null))
				{
					this.mCheckClosedDocumentFormViaDialogWindowsFormExpectedValues = new CheckClosedDocumentFormViaDialogWindowsFormExpectedValues();
				}
				return this.mCheckClosedDocumentFormViaDialogWindowsFormExpectedValues;
			}
		}
		public virtual CheckCloseAllDocumentOptionExpectedValues CheckCloseAllDocumentOptionExpectedValues
		{
			get
			{
				if ((this.mCheckCloseAllDocumentOptionExpectedValues == null))
				{
					this.mCheckCloseAllDocumentOptionExpectedValues = new CheckCloseAllDocumentOptionExpectedValues();
				}
				return this.mCheckCloseAllDocumentOptionExpectedValues;
			}
		}
		public virtual CheckNewDocumentAddedExpectedValues CheckNewDocumentAddedExpectedValues
		{
			get
			{
				if ((this.mCheckNewDocumentAddedExpectedValues == null))
				{
					this.mCheckNewDocumentAddedExpectedValues = new CheckNewDocumentAddedExpectedValues();
				}
				return this.mCheckNewDocumentAddedExpectedValues;
			}
		}
		public virtual CheckNewTabAddedExpectedValues CheckNewTabAddedExpectedValues
		{
			get
			{
				if ((this.mCheckNewTabAddedExpectedValues == null))
				{
					this.mCheckNewTabAddedExpectedValues = new CheckNewTabAddedExpectedValues();
				}
				return this.mCheckNewTabAddedExpectedValues;
			}
		}
		public virtual CheckNewTabAddedToRightGroupExpectedValues CheckNewTabAddedToRightGroupExpectedValues
		{
			get
			{
				if ((this.mCheckNewTabAddedToRightGroupExpectedValues == null))
				{
					this.mCheckNewTabAddedToRightGroupExpectedValues = new CheckNewTabAddedToRightGroupExpectedValues();
				}
				return this.mCheckNewTabAddedToRightGroupExpectedValues;
			}
		}
		public virtual CheckChangedOrientationExpectedValues CheckChangedOrientationExpectedValues
		{
			get
			{
				if ((this.mCheckChangedOrientationExpectedValues == null))
				{
					this.mCheckChangedOrientationExpectedValues = new CheckChangedOrientationExpectedValues();
				}
				return this.mCheckChangedOrientationExpectedValues;
			}
		}
		public virtual CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues == null))
				{
					this.mCheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues = new CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues();
				}
				return this.mCheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues;
			}
		}
		public virtual CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues == null))
				{
					this.mCheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues = new CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues();
				}
				return this.mCheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues;
			}
		}
		public virtual CheckDockedFormToTabbedViewLeftEdgeExpectedValues CheckDockedFormToTabbedViewLeftEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToTabbedViewLeftEdgeExpectedValues == null))
				{
					this.mCheckDockedFormToTabbedViewLeftEdgeExpectedValues = new CheckDockedFormToTabbedViewLeftEdgeExpectedValues();
				}
				return this.mCheckDockedFormToTabbedViewLeftEdgeExpectedValues;
			}
		}
		public virtual CheckDockedFormToTabbedViewRightEdgeExpectedValues CheckDockedFormToTabbedViewRightEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToTabbedViewRightEdgeExpectedValues == null))
				{
					this.mCheckDockedFormToTabbedViewRightEdgeExpectedValues = new CheckDockedFormToTabbedViewRightEdgeExpectedValues();
				}
				return this.mCheckDockedFormToTabbedViewRightEdgeExpectedValues;
			}
		}
		public virtual CheckTabsHaveNoCloseButtonExpectedValues CheckTabsHaveNoCloseButtonExpectedValues
		{
			get
			{
				if ((this.mCheckTabsHaveNoCloseButtonExpectedValues == null))
				{
					this.mCheckTabsHaveNoCloseButtonExpectedValues = new CheckTabsHaveNoCloseButtonExpectedValues();
				}
				return this.mCheckTabsHaveNoCloseButtonExpectedValues;
			}
		}
		public virtual CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues
		{
			get
			{
				if ((this.mCheckDockedFormToLeftHorizontalContainerAsTabExpectedValues == null))
				{
					this.mCheckDockedFormToLeftHorizontalContainerAsTabExpectedValues = new CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues();
				}
				return this.mCheckDockedFormToLeftHorizontalContainerAsTabExpectedValues;
			}
		}
		public virtual CheckFirstDocumentDockedToRightEdgeExpectedValues CheckFirstDocumentDockedToRightEdgeExpectedValues
		{
			get
			{
				if ((this.mCheckFirstDocumentDockedToRightEdgeExpectedValues == null))
				{
					this.mCheckFirstDocumentDockedToRightEdgeExpectedValues = new CheckFirstDocumentDockedToRightEdgeExpectedValues();
				}
				return this.mCheckFirstDocumentDockedToRightEdgeExpectedValues;
			}
		}
		public virtual CheckFloatDocumentFormClosedExpectedValues CheckFloatDocumentFormClosedExpectedValues
		{
			get
			{
				if ((this.mCheckFloatDocumentFormClosedExpectedValues == null))
				{
					this.mCheckFloatDocumentFormClosedExpectedValues = new CheckFloatDocumentFormClosedExpectedValues();
				}
				return this.mCheckFloatDocumentFormClosedExpectedValues;
			}
		}
		public virtual CheckDocument0ClosedExpectedValues CheckDocument0ClosedExpectedValues
		{
			get
			{
				if ((this.mCheckDocument0ClosedExpectedValues == null))
				{
					this.mCheckDocument0ClosedExpectedValues = new CheckDocument0ClosedExpectedValues();
				}
				return this.mCheckDocument0ClosedExpectedValues;
			}
		}
		public UIDockingDemoCDemoWindow UIDockingDemoCDemoWindow
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow == null))
				{
					this.mUIDockingDemoCDemoWindow = new UIDockingDemoCDemoWindow();
				}
				return this.mUIDockingDemoCDemoWindow;
			}
		}
		public UIDockingDemoCDemoWindow1 UIDockingDemoCDemoWindow1
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow1 == null))
				{
					this.mUIDockingDemoCDemoWindow1 = new UIDockingDemoCDemoWindow1();
				}
				return this.mUIDockingDemoCDemoWindow1;
			}
		}
		public UIDockingDemoCDemoWindow2 UIDockingDemoCDemoWindow2
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow2 == null))
				{
					this.mUIDockingDemoCDemoWindow2 = new UIDockingDemoCDemoWindow2();
				}
				return this.mUIDockingDemoCDemoWindow2;
			}
		}
		public UIDockingDemoCDemoWindow3 UIDockingDemoCDemoWindow3
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow3 == null))
				{
					this.mUIDockingDemoCDemoWindow3 = new UIDockingDemoCDemoWindow3();
				}
				return this.mUIDockingDemoCDemoWindow3;
			}
		}
		public UIDockingDemoCDemoWindow4 UIDockingDemoCDemoWindow4
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow4 == null))
				{
					this.mUIDockingDemoCDemoWindow4 = new UIDockingDemoCDemoWindow4();
				}
				return this.mUIDockingDemoCDemoWindow4;
			}
		}
		public UIDockingDemoCDemoWindow5 UIDockingDemoCDemoWindow5
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow5 == null))
				{
					this.mUIDockingDemoCDemoWindow5 = new UIDockingDemoCDemoWindow5();
				}
				return this.mUIDockingDemoCDemoWindow5;
			}
		}
		public UIDockingDemoCDemoWindow6 UIDockingDemoCDemoWindow6
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow6 == null))
				{
					this.mUIDockingDemoCDemoWindow6 = new UIDockingDemoCDemoWindow6();
				}
				return this.mUIDockingDemoCDemoWindow6;
			}
		}
		public UIDockingDemoCDemoWindow7 UIDockingDemoCDemoWindow7
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow7 == null))
				{
					this.mUIDockingDemoCDemoWindow7 = new UIDockingDemoCDemoWindow7();
				}
				return this.mUIDockingDemoCDemoWindow7;
			}
		}
		public UIDockingDemoCDemoWindow8 UIDockingDemoCDemoWindow8
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow8 == null))
				{
					this.mUIDockingDemoCDemoWindow8 = new UIDockingDemoCDemoWindow8();
				}
				return this.mUIDockingDemoCDemoWindow8;
			}
		}
		public UIDockingDemoCDemoWindow9 UIDockingDemoCDemoWindow9
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow9 == null))
				{
					this.mUIDockingDemoCDemoWindow9 = new UIDockingDemoCDemoWindow9();
				}
				return this.mUIDockingDemoCDemoWindow9;
			}
		}
		public UIDockingDemoCDemoWindow10 UIDockingDemoCDemoWindow10
		{
			get
			{
				if ((this.mUIDockingDemoCDemoWindow10 == null))
				{
					this.mUIDockingDemoCDemoWindow10 = new UIDockingDemoCDemoWindow10();
				}
				return this.mUIDockingDemoCDemoWindow10;
			}
		}
		public UIItemWindow UIItemWindow
		{
			get
			{
				if ((this.mUIItemWindow == null))
				{
					this.mUIItemWindow = new UIItemWindow();
				}
				return this.mUIItemWindow;
			}
		}
		public UIApplicationUIWindow UIApplicationUIWindow
		{
			get
			{
				if ((this.mUIApplicationUIWindow == null))
				{
					this.mUIApplicationUIWindow = new UIApplicationUIWindow();
				}
				return this.mUIApplicationUIWindow;
			}
		}
		public UIDocumentManagerDockiWindow UIDocumentManagerDockiWindow
		{
			get
			{
				if ((this.mUIDocumentManagerDockiWindow == null))
				{
					this.mUIDocumentManagerDockiWindow = new UIDocumentManagerDockiWindow();
				}
				return this.mUIDocumentManagerDockiWindow;
			}
		}
		public UIWindowsWindow UIWindowsWindow
		{
			get
			{
				if ((this.mUIWindowsWindow == null))
				{
					this.mUIWindowsWindow = new UIWindowsWindow();
				}
				return this.mUIWindowsWindow;
			}
		}
		public UIItemWindow1 UIItemWindow1
		{
			get
			{
				if ((this.mUIItemWindow1 == null))
				{
					this.mUIItemWindow1 = new UIItemWindow1();
				}
				return this.mUIItemWindow1;
			}
		}
		public UIDocumentManagerNativWindow UIDocumentManagerNativWindow
		{
			get
			{
				if ((this.mUIDocumentManagerNativWindow == null))
				{
					this.mUIDocumentManagerNativWindow = new UIDocumentManagerNativWindow();
				}
				return this.mUIDocumentManagerNativWindow;
			}
		}
		public UIDocumentManagerTabbeWindow UIDocumentManagerTabbeWindow
		{
			get
			{
				if ((this.mUIDocumentManagerTabbeWindow == null))
				{
					this.mUIDocumentManagerTabbeWindow = new UIDocumentManagerTabbeWindow();
				}
				return this.mUIDocumentManagerTabbeWindow;
			}
		}
		public UIDocumentManagerNativWindow1 UIDocumentManagerNativWindow1
		{
			get
			{
				if ((this.mUIDocumentManagerNativWindow1 == null))
				{
					this.mUIDocumentManagerNativWindow1 = new UIDocumentManagerNativWindow1();
				}
				return this.mUIDocumentManagerNativWindow1;
			}
		}
		public UIItemWindow2 UIItemWindow2
		{
			get
			{
				if ((this.mUIItemWindow2 == null))
				{
					this.mUIItemWindow2 = new UIItemWindow2();
				}
				return this.mUIItemWindow2;
			}
		}
		public UIItemWindow3 UIItemWindow3
		{
			get
			{
				if ((this.mUIItemWindow3 == null))
				{
					this.mUIItemWindow3 = new UIItemWindow3();
				}
				return this.mUIItemWindow3;
			}
		}
		public UIItemWindow4 UIItemWindow4
		{
			get
			{
				if ((this.mUIItemWindow4 == null))
				{
					this.mUIItemWindow4 = new UIItemWindow4();
				}
				return this.mUIItemWindow4;
			}
		}
		public UIDocument3Window1 UIDocument3Window
		{
			get
			{
				if ((this.mUIDocument3Window == null))
				{
					this.mUIDocument3Window = new UIDocument3Window1();
				}
				return this.mUIDocument3Window;
			}
		}
		public UITabbedMDICcodeWindow UITabbedMDICcodeWindow
		{
			get
			{
				if ((this.mUITabbedMDICcodeWindow == null))
				{
					this.mUITabbedMDICcodeWindow = new UITabbedMDICcodeWindow();
				}
				return this.mUITabbedMDICcodeWindow;
			}
		}
		public UIForm2Window UIForm2Window
		{
			get
			{
				if ((this.mUIForm2Window == null))
				{
					this.mUIForm2Window = new UIForm2Window();
				}
				return this.mUIForm2Window;
			}
		}
		public UIDocument0Window1 UIDocument0Window
		{
			get
			{
				if ((this.mUIDocument0Window == null))
				{
					this.mUIDocument0Window = new UIDocument0Window1();
				}
				return this.mUIDocument0Window;
			}
		}
		public UIItemWindow11 UIItemWindow11
		{
			get
			{
				if ((this.mUIItemWindow11 == null))
				{
					this.mUIItemWindow11 = new UIItemWindow11();
				}
				return this.mUIItemWindow11;
			}
		}
		public UIApplicationUILayoutCWindow UIApplicationUILayoutCWindow
		{
			get
			{
				if ((this.mUIApplicationUILayoutCWindow == null))
				{
					this.mUIApplicationUILayoutCWindow = new UIApplicationUILayoutCWindow();
				}
				return this.mUIApplicationUILayoutCWindow;
			}
		}
		public UIApplicationUILayoutCWindow1 UIApplicationUILayoutCWindow1
		{
			get
			{
				if ((this.mUIApplicationUILayoutCWindow1 == null))
				{
					this.mUIApplicationUILayoutCWindow1 = new UIApplicationUILayoutCWindow1();
				}
				return this.mUIApplicationUILayoutCWindow1;
			}
		}
		public UIApplicationUILayoutCWindow2 UIApplicationUILayoutCWindow2
		{
			get
			{
				if ((this.mUIApplicationUILayoutCWindow2 == null))
				{
					this.mUIApplicationUILayoutCWindow2 = new UIApplicationUILayoutCWindow2();
				}
				return this.mUIApplicationUILayoutCWindow2;
			}
		}
		public UIApplicationUILayoutCWindow3 UIApplicationUILayoutCWindow3
		{
			get
			{
				if ((this.mUIApplicationUILayoutCWindow3 == null))
				{
					this.mUIApplicationUILayoutCWindow3 = new UIApplicationUILayoutCWindow3();
				}
				return this.mUIApplicationUILayoutCWindow3;
			}
		}
		public UIItemWindow5 UIItemWindow5
		{
			get
			{
				if ((this.mUIItemWindow5 == null))
				{
					this.mUIItemWindow5 = new UIItemWindow5();
				}
				return this.mUIItemWindow5;
			}
		}
		#endregion
		#region Fields
		private CheckHiddenUnpinnedPanelExpectedValues mCheckHiddenUnpinnedPanelExpectedValues;
		private CheckDisplayedPinnedPanelExpectedValues mCheckDisplayedPinnedPanelExpectedValues;
		private RestoreClosedPanelViaClickBarParams mRestoreClosedPanelViaClickBarParams;
		private CheckPanelButtonLocationExpectedValues mCheckPanelButtonLocationExpectedValues;
		private DockPanelToTopEdgeOfFormParams mDockPanelToTopEdgeOfFormParams;
		private DockPanelToRightEdgeOfFormParams mDockPanelToRightEdgeOfFormParams;
		private DockPanelToTopEdgeParams mDockPanelToTopEdgeParams;
		private CheckWidthExpectedValues mCheckWidthExpectedValues;
		private DockPanelToRightEdgeParams mDockPanelToRightEdgeParams;
		private DockPanelToBottomEdgeParams mDockPanelToBottomEdgeParams;
		private MakePanelFloatViaDraggingParams mMakePanelFloatViaDraggingParams;
		private CheckFloatPanelDockStyleExpectedValues mCheckFloatPanelDockStyleExpectedValues;
		private CheckPanelRestoredDockStyleExpectedValues mCheckPanelRestoredDockStyleExpectedValues;
		private CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues mCheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues;
		private DockPanelToLeftEdgeOfFormParams mDockPanelToLeftEdgeOfFormParams;
		private CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues mCheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues;
		private CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues mCheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues;
		private DockPanelToBottomEdgeOfFormParams mDockPanelToBottomEdgeOfFormParams;
		private CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues mCheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues;
		private DockPanelToLeftEdgeParams mDockPanelToLeftEdgeParams;
		private CheckPanelDockStyleDockedToLeftEdgeExpectedValues mCheckPanelDockStyleDockedToLeftEdgeExpectedValues;
		private CheckPanelDockStyleDockedToRightEdgeExpectedValues mCheckPanelDockStyleDockedToRightEdgeExpectedValues;
		private CheckPanelDockStyleDockedToTopEdgeExpectedValues mCheckPanelDockStyleDockedToTopEdgeExpectedValues;
		private CheckPanelDockStyleDockedToBottomEdgeExpectedValues mCheckPanelDockStyleDockedToBottomEdgeExpectedValues;
		private DockSimplePanelToTopEdgeOfFormParams mDockSimplePanelToTopEdgeOfFormParams;
		private CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues mCheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues;
		private DockSimplePanelToLeftEdgeOfFormParams mDockSimplePanelToLeftEdgeOfFormParams;
		private CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues mCheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues;
		private DockSimplePanelToRightEdgeOfFormParams mDockSimplePanelToRightEdgeOfFormParams;
		private CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues mCheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues;
		private DockSimplePanelToBottomEdgeOfFormParams mDockSimplePanelToBottomEdgeOfFormParams;
		private CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues mCheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues;
		private DockSimplePanelToLeftEdgeParams mDockSimplePanelToLeftEdgeParams;
		private CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues mCheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues;
		private DockSimplePanelToRightEdgeParams mDockSimplePanelToRightEdgeParams;
		private CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues mCheckSimplePanelDockStyleDockedToRightEdgeExpectedValues;
		private DockSimplePanelToTopEdgeParams mDockSimplePanelToTopEdgeParams;
		private CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues mCheckSimplePanelDockStyleDockedToTopEdgeExpectedValues;
		private DockSimplePanelToBottomEdgeParams mDockSimplePanelToBottomEdgeParams;
		private CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues mCheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues;
		private CreateTabContainerViaDockPanelToAnotherPanelParams mCreateTabContainerViaDockPanelToAnotherPanelParams;
		private CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues mCheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues;
		private SwitchToDocumentManagerDockingDemoModuleParams mSwitchToDocumentManagerDockingDemoModuleParams;
		private MakeDocumentFormFloatViaDraggingParams mMakeDocumentFormFloatViaDraggingParams;
		private DockDocumentFormToLeftEdgeParams mDockDocumentFormToLeftEdgeParams;
		private DockDocumentFormToRightEdgeParams mDockDocumentFormToRightEdgeParams;
		private DockDocumentFormToTopEdgeParams mDockDocumentFormToTopEdgeParams;
		private DockDocumentFormToBottomEdgeParams mDockDocumentFormToBottomEdgeParams;
		private ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams mChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams;
		private ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams mChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams;
		private MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams mMakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams;
		private MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams mMakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams;
		private MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams mMakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams;
		private MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams mMakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams;
		private DockPanelToDocumentFormParams mDockPanelToDocumentFormParams;
		private DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams mDockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams;
		private SwitchToDocumentManagerNativeMdiViewDemoModuleParams mSwitchToDocumentManagerNativeMdiViewDemoModuleParams;
		private SwitchToDocumentManagerTabbedViewDemoModuleParams mSwitchToDocumentManagerTabbedViewDemoModuleParams;
		private MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams mMakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams;
		private CheckLeftPanelInHorizontalSplitContainerExpectedValues mCheckLeftPanelInHorizontalSplitContainerExpectedValues;
		private MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams mMakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams;
		private CheckRightPanelInHorizontalSplitContainerExpectedValues mCheckRightPanelInHorizontalSplitContainerExpectedValues;
		private MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams mMakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams;
		private CheckTopPanelInVerticalSplitContainerExpectedValues mCheckTopPanelInVerticalSplitContainerExpectedValues;
		private MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams mMakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams;
		private CheckBottomPanelInVerticalSplitContainerExpectedValues mCheckBottomPanelInVerticalSplitContainerExpectedValues;
		private DockPanelToFormViaDraggingParams mDockPanelToFormViaDraggingParams;
		private CheckDockingPanelToFormViaContextMenuOptionExpectedValues mCheckDockingPanelToFormViaContextMenuOptionExpectedValues;
		private DockFloatPanelToFormViaDraggingParams mDockFloatPanelToFormViaDraggingParams;
		private CheckDockingPanelToFormExpectedValues mCheckDockingPanelToFormExpectedValues;
		private ChangeTabPositionInPanelContainerParams mChangeTabPositionInPanelContainerParams;
		private CheckPanelContainerTabIndexesExpectedValues mCheckPanelContainerTabIndexesExpectedValues;
		private ClickDocumentFormMinimizeButtonParams mClickDocumentFormMinimizeButtonParams;
		private ClickDocumentFormMaximizeButtonParams mClickDocumentFormMaximizeButtonParams;
		private CloseMaximizedDocumentFormParams mCloseMaximizedDocumentFormParams;
		private DockPanelToAnotherPanelParams mDockPanelToAnotherPanelParams;
		private CheckDockingPanelToAnotherPanelExpectedValues mCheckDockingPanelToAnotherPanelExpectedValues;
		private CheckUnpinnedPanelFloatDockStyleExpectedValues mCheckUnpinnedPanelFloatDockStyleExpectedValues;
		private CheckDockingPanelToAnotherPanelAsTabExpectedValues mCheckDockingPanelToAnotherPanelAsTabExpectedValues;
		private CheckNewDocumentFormCaptionExpectedValues mCheckNewDocumentFormCaptionExpectedValues;
		private CloseFloatDocumentFormViaClickCloseButtonParams mCloseFloatDocumentFormViaClickCloseButtonParams;
		private MaximizeFloatDocumentFormViaClickMaximizeButtonParams mMaximizeFloatDocumentFormViaClickMaximizeButtonParams;
		private MinimizeFloatDocumentFormViaClickRestoreButtonParams mMinimizeFloatDocumentFormViaClickRestoreButtonParams;
		private DockDocumentFormToTabbedViewLeftEdgeParams mDockDocumentFormToTabbedViewLeftEdgeParams;
		private DockDocumentFormToTabbedViewRightEdgeParams mDockDocumentFormToTabbedViewRightEdgeParams;
		private DockDocumentFormToLeftHorizontalContainerAsTabParams mDockDocumentFormToLeftHorizontalContainerAsTabParams;
		private DockFloatDocumentFormToTabbedViewLeftEdgeParams mDockFloatDocumentFormToTabbedViewLeftEdgeParams;
		private DockFloatDocumentFormToTabbedViewRightEdgeParams mDockFloatDocumentFormToTabbedViewRightEdgeParams;
		private MakeTabbedViewDocumentFormFloatViaDraggingParams mMakeTabbedViewDocumentFormFloatViaDraggingParams;
		private DockFloatDocumentFormToLeftHorizontalContainerAsTabParams mDockFloatDocumentFormToLeftHorizontalContainerAsTabParams;
		private CloseTabbedViewFloatDocumentFormViaCloseButtonParams mCloseTabbedViewFloatDocumentFormViaCloseButtonParams;
		private MakeVerticalContainerViaDockingDocumentFormToTopEdgeParams mMakeVerticalContainerViaDockingDocumentFormToTopEdgeParams;
		private MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams mMakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams;
		private SwitchToTabbedMDIDemoModuleParams mSwitchToTabbedMDIDemoModuleParams;
		private MakeTabbedMDIDocumentFormFloatViaDraggingParams mMakeTabbedMDIDocumentFormFloatViaDraggingParams;
		private CheckFloatTabbedMDIDocumentFormExpectedValues mCheckFloatTabbedMDIDocumentFormExpectedValues;
		private DockFloatTabbedMDIDocumentFormAsTabParams mDockFloatTabbedMDIDocumentFormAsTabParams;
		private UncheckFloatOnDragOptionParams mUncheckFloatOnDragOptionParams;
		private DragTabbedMDIDocumentFormParams mDragTabbedMDIDocumentFormParams;
		private CheckConservationTabbedMDIDocumentFormIndexExpectedValues mCheckConservationTabbedMDIDocumentFormIndexExpectedValues;
		private UncheckFloatOnDoubleClickOptionParams mUncheckFloatOnDoubleClickOptionParams;
		private ChangeClosePageButtonInTabbedMDIDemoModuleParams mChangeClosePageButtonInTabbedMDIDemoModuleParams;
		private CheckClosedTabbedMDIDocumentFormExpectedValues mCheckClosedTabbedMDIDocumentFormExpectedValues;
		private ReorderMDITabsParams mReorderMDITabsParams;
		private CheckMDITabIndexExpectedValues mCheckMDITabIndexExpectedValues;
		private ChangeTabbedMDIHeaderLocationParams mChangeTabbedMDIHeaderLocationParams;
		private ChangeTabbedMDIHeaderOrientationParams mChangeTabbedMDIHeaderOrientationParams;
		private ReorderTabsInTabbedViewDemoModuleParams mReorderTabsInTabbedViewDemoModuleParams;
		private CheckTabIndexInTabbedViewDemoModuleExpectedValues mCheckTabIndexInTabbedViewDemoModuleExpectedValues;
		private ChangeShowCloseButtonModeParams mChangeShowCloseButtonModeParams;
		private SwitchOnHeaderAutoFillOptionParams mSwitchOnHeaderAutoFillOptionParams;
		private CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues mCheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues;
		private CreateTabContainerFromTwoUntitledPanelsParams mCreateTabContainerFromTwoUntitledPanelsParams;
		private CheckTabContainerFromTwoUntitledPanelsExpectedValues mCheckTabContainerFromTwoUntitledPanelsExpectedValues;
		private CreateSplitContainerFromTwoUntitledPanelsParams mCreateSplitContainerFromTwoUntitledPanelsParams;
		private CheckSplitContainerFromTwoUntitledPanelsExpectedValues mCheckSplitContainerFromTwoUntitledPanelsExpectedValues;
		private DockTabContainerFromTwoUntitledPanelsParams mDockTabContainerFromTwoUntitledPanelsParams;
		private CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues mCheckDockingTabContainerFromTwoUntitledPanelsExpectedValues;
		private CreateSplitContainerFromTabContainerAndUntitledPanelParams mCreateSplitContainerFromTabContainerAndUntitledPanelParams;
		private CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues mCheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues;
		private CreateSecondTabContainerFromTwoUntitledPanelsParams mCreateSecondTabContainerFromTwoUntitledPanelsParams;
		private CreateSplitContainerFromTwoTabContainersParams mCreateSplitContainerFromTwoTabContainersParams;
		private CheckSplitContainerFromTwoTabContainersExpectedValues mCheckSplitContainerFromTwoTabContainersExpectedValues;
		private CreateTabContainerFromTwoTabContainersParams mCreateTabContainerFromTwoTabContainersParams;
		private CheckTabContainerFromTwoTabContainersExpectedValues mCheckTabContainerFromTwoTabContainersExpectedValues;
		private CheckDockedTabbedMDIDocumentFormAsTabExpectedValues mCheckDockedTabbedMDIDocumentFormAsTabExpectedValues;
		private CheckLastDocumentIsVisibleExpectedValues mCheckLastDocumentIsVisibleExpectedValues;
		private CheckFloatDocumentFormDoesNotExistExpectedValues mCheckFloatDocumentFormDoesNotExistExpectedValues;
		private CheckFloatingDocumentFormDockStyleExpectedValues mCheckFloatingDocumentFormDockStyleExpectedValues;
		private CheckDocumentManagerTabIndexExpectedValues mCheckDocumentManagerTabIndexExpectedValues;
		private CheckDockedFormToLeftEdgeExpectedValues mCheckDockedFormToLeftEdgeExpectedValues;
		private CheckDockedFormToRightEdgeExpectedValues mCheckDockedFormToRightEdgeExpectedValues;
		private CheckDockedFormToTopEdgeExpectedValues mCheckDockedFormToTopEdgeExpectedValues;
		private CheckDockedFormToBottomEdgeExpectedValues mCheckDockedFormToBottomEdgeExpectedValues;
		private CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues mCheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues;
		private CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues mCheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues;
		private CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues mCheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues;
		private CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues mCheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues;
		private CheckDockedPanelToDocumentFormExpectedValues mCheckDockedPanelToDocumentFormExpectedValues;
		private CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues mCheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues;
		private CheckFirstDocumentIsActiveExpectedValues mCheckFirstDocumentIsActiveExpectedValues;
		private CheckClosedDocumentFormViaDialogWindowsFormExpectedValues mCheckClosedDocumentFormViaDialogWindowsFormExpectedValues;
		private CheckCloseAllDocumentOptionExpectedValues mCheckCloseAllDocumentOptionExpectedValues;
		private CheckNewDocumentAddedExpectedValues mCheckNewDocumentAddedExpectedValues;
		private CheckNewTabAddedExpectedValues mCheckNewTabAddedExpectedValues;
		private CheckNewTabAddedToRightGroupExpectedValues mCheckNewTabAddedToRightGroupExpectedValues;
		private CheckChangedOrientationExpectedValues mCheckChangedOrientationExpectedValues;
		private CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues mCheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues;
		private CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues mCheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues;
		private CheckDockedFormToTabbedViewLeftEdgeExpectedValues mCheckDockedFormToTabbedViewLeftEdgeExpectedValues;
		private CheckDockedFormToTabbedViewRightEdgeExpectedValues mCheckDockedFormToTabbedViewRightEdgeExpectedValues;
		private CheckTabsHaveNoCloseButtonExpectedValues mCheckTabsHaveNoCloseButtonExpectedValues;
		private CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues mCheckDockedFormToLeftHorizontalContainerAsTabExpectedValues;
		private CheckFirstDocumentDockedToRightEdgeExpectedValues mCheckFirstDocumentDockedToRightEdgeExpectedValues;
		private CheckFloatDocumentFormClosedExpectedValues mCheckFloatDocumentFormClosedExpectedValues;
		private CheckDocument0ClosedExpectedValues mCheckDocument0ClosedExpectedValues;
		private UIDockingDemoCDemoWindow mUIDockingDemoCDemoWindow;
		private UIDockingDemoCDemoWindow1 mUIDockingDemoCDemoWindow1;
		private UIDockingDemoCDemoWindow2 mUIDockingDemoCDemoWindow2;
		private UIDockingDemoCDemoWindow3 mUIDockingDemoCDemoWindow3;
		private UIDockingDemoCDemoWindow4 mUIDockingDemoCDemoWindow4;
		private UIDockingDemoCDemoWindow5 mUIDockingDemoCDemoWindow5;
		private UIDockingDemoCDemoWindow6 mUIDockingDemoCDemoWindow6;
		private UIDockingDemoCDemoWindow7 mUIDockingDemoCDemoWindow7;
		private UIDockingDemoCDemoWindow8 mUIDockingDemoCDemoWindow8;
		private UIDockingDemoCDemoWindow9 mUIDockingDemoCDemoWindow9;
		private UIDockingDemoCDemoWindow10 mUIDockingDemoCDemoWindow10;
		private UIItemWindow mUIItemWindow;
		private UIApplicationUIWindow mUIApplicationUIWindow;
		private UIDocumentManagerDockiWindow mUIDocumentManagerDockiWindow;
		private UIWindowsWindow mUIWindowsWindow;
		private UIItemWindow1 mUIItemWindow1;
		private UIDocumentManagerNativWindow mUIDocumentManagerNativWindow;
		private UIDocumentManagerTabbeWindow mUIDocumentManagerTabbeWindow;
		private UIDocumentManagerNativWindow1 mUIDocumentManagerNativWindow1;
		private UIItemWindow2 mUIItemWindow2;
		private UIItemWindow3 mUIItemWindow3;
		private UIItemWindow4 mUIItemWindow4;
		private UIDocument3Window1 mUIDocument3Window;
		private UITabbedMDICcodeWindow mUITabbedMDICcodeWindow;
		private UIForm2Window mUIForm2Window;
		private UIDocument0Window1 mUIDocument0Window;
		private UIItemWindow11 mUIItemWindow11;
		private UIApplicationUILayoutCWindow mUIApplicationUILayoutCWindow;
		private UIApplicationUILayoutCWindow1 mUIApplicationUILayoutCWindow1;
		private UIApplicationUILayoutCWindow2 mUIApplicationUILayoutCWindow2;
		private UIApplicationUILayoutCWindow3 mUIApplicationUILayoutCWindow3;
		private UIItemWindow5 mUIItemWindow5;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckHiddenUnpinnedPanelExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientLocation = "0, 0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDisplayedPinnedPanelExpectedValues
	{
		#region Fields
		public string UIDockPanel6ClientDockStyle = "Left";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class RestoreClosedPanelViaClickBarParams
	{
		#region Fields
		public string UISolutionExplorerBarBaseButtonItemPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelButtonLocationExpectedValues
	{
		#region Fields
		public string UIDockPanel4ButtonLocation = "326, 609";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToTopEdgeOfFormParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Top[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToRightEdgeOfFormParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Right[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToTopEdgeParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Top[Index]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckWidthExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientSize = "861, 200";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToRightEdgeParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Right[Index]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToBottomEdgeParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Bottom[Index]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakePanelFloatViaDraggingParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Float[FloatLocation]61, 219";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFloatPanelDockStyleExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Float";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelRestoredDockStyleExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Bottom";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToLeftEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Left";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToLeftEdgeOfFormParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Left[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToRightEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Right";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToTopEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Top";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToBottomEdgeOfFormParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Bottom[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToBottomEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Bottom";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToLeftEdgeParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Left[Index]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToLeftEdgeExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Left";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToRightEdgeExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Right";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToTopEdgeExpectedValues
	{
		#region Fields
		public string UIPanelContainer2ClientDockStyle = "Top";
		public bool UIPanelContainer2ClientIsTab = false;
		public int UIPanelContainer2ClientIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelDockStyleDockedToBottomEdgeExpectedValues
	{
		#region Fields
		public string UIDockPanelClientDockStyle = "Bottom";
		public bool UIDockPanelClientIsTab = false;
		public int UIDockPanelClientIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToTopEdgeOfFormParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Top[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToTopEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Top";
		public bool UIDockPanelClient1IsTab = false;
		public int UIDockPanelClient1Index = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToLeftEdgeOfFormParams
	{
		#region Fields
		public string UIDockPanel1ClientDockInfoAsString = "[DockStyle]Left[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToLeftEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIDockPanel1ClientDockStyle = "Left";
		public bool UIDockPanel1ClientIsTab = false;
		public int UIDockPanel1ClientIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToRightEdgeOfFormParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Right[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToRightEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Right";
		public bool UIDockPanelClient1IsTab = false;
		public int UIDockPanelClient1Index = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToBottomEdgeOfFormParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Bottom[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToBottomEdgeOfFormExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Bottom";
		public bool UIDockPanelClient1IsTab = false;
		public int UIDockPanelClient1Index = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToLeftEdgeParams
	{
		#region Fields
		public string UIDockPanel1ClientDockInfoAsString = "[DockStyle]Left[Index]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToLeftEdgeExpectedValues
	{
		#region Fields
		public string UIDockPanel1ClientDockStyle = "Left";
		public bool UIDockPanel1ClientIsTab = false;
		public int UIDockPanel1ClientIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToRightEdgeParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Left[Index]3";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToRightEdgeExpectedValues
	{
		#region Fields
		public string UIDockPanelClient2DockStyle = "Left";
		public bool UIDockPanelClient2IsTab = false;
		public int UIDockPanelClient2Index = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToTopEdgeParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Fill[TargetPanelLayout]Left-1[Index]0[IsTab]False";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToTopEdgeExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1ParentName = "SimpleDockPanelDockPanel[0]";
		public string UIDockPanelClient1DockStyle = "Fill";
		public bool UIDockPanelClient1IsTab = false;
		public int UIDockPanelClient1Index = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockSimplePanelToBottomEdgeParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Fill[TargetPanelLayout]Left-2[Index]1[IsTab]False";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToBottomEdgeExpectedValues
	{
		#region Fields
		public string UIDockPanelClient11ParentName = "SimpleDockPanelDockPanel[0]";
		public string UIDockPanelClient11DockStyle = "Fill";
		public bool UIDockPanelClient11IsTab = false;
		public int UIDockPanelClient11Index = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateTabContainerViaDockPanelToAnotherPanelParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Fill[TargetPanel]dockPanel1[Index]0[IsTab]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSimplePanelDockStyleDockedToAnotherPanelExpectedValues
	{
		#region Fields
		public bool UIDockPanelClient1IsTab = true;
		public int UIDockPanelClient1Index = 0;
		public string UIDockPanelClient1ParentName = "SimpleDockPanelDockPanel[1]";
		public string UIDockPanelClient1DockStyle = "Fill";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class SwitchToDocumentManagerDockingDemoModuleParams
	{
		#region Fields
		public string UIListBoxControl1ListSelectedIndicesAsString = "10";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeDocumentFormFloatViaDraggingParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[IsFloating]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToLeftEdgeParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToRightEdgeParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]1[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToTopEdgeParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Vertical[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToBottomEdgeParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Vertical[GroupIndex]1[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeDocumentManagerTabOrderViaDockingDocumentFormToAnotherFormParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Vertical[GroupIndex]0[DocumentIndex]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeDocumentManagerTabOrderViaDraggingDocumentFormCaptionParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeHorizontalSplitContainerViaDockingPanelToLeftEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIDockPanel3DockPanelDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeHorizontalSplitContainerViaDockingPanelToRightEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIDockPanel2DockPanelDockInfoAsString = "[Orientation]Horizontal[GroupIndex]1[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeVerticalSplitContainerViaDockingPanelToTopEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIDockPanel1DockPanelDockInfoAsString = "[Orientation]Vertical[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeVerticalSplitContainerViaDockingPanelToBottomEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIDockPanel1DockPanelDockInfoAsString = "[Orientation]Vertical[GroupIndex]1[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToDocumentFormParams
	{
		#region Fields
		public string UIDockPanel1DockPanelDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]3";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabParams
	{
		#region Fields
		public string UIDockPanel1DockPanelDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class SwitchToDocumentManagerNativeMdiViewDemoModuleParams
	{
		#region Fields
		public string UIListBoxControl1ListSelectedIndicesAsString = "11";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class SwitchToDocumentManagerTabbedViewDemoModuleParams
	{
		#region Fields
		public string UIListBoxControl1ListSelectedIndicesAsString = "12";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeHorizontalSplitContainerViaDockPanelToLeftEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckLeftPanelInHorizontalSplitContainerExpectedValues
	{
		#region Fields
		public string UIDockPanel1DockPanelOrientation = "Horizontal";
		public int UIDockPanel1DockPanelGroupIndex = 0;
		public int UIDockPanel1DockPanelIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeHorizontalSplitContainerViaDockPanelToRightEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Right[Index]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckRightPanelInHorizontalSplitContainerExpectedValues
	{
		#region Fields
		public string UIDockPanel3ClientDockStyle = "Fill";
		public bool UIDockPanel3ClientIsTab = true;
		public int UIDockPanel3ClientIndex = 0;
		public string UIPanelContainer2ClientDockStyle = "Right";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeVerticalSplitContainerViaDockPanelToTopEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[Orientation]Vertical[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckTopPanelInVerticalSplitContainerExpectedValues
	{
		#region Fields
		public string UIDockPanel5DockPanelOrientation = "Vertical";
		public bool UIDockPanel5DockPanelIsFloating = false;
		public int UIDockPanel5DockPanelGroupIndex = 0;
		public int UIDockPanel5DockPanelIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeVerticalSplitContainerViaDockPanelToBottomEdgeOfDocumentFormParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[Orientation]Vertical[GroupIndex]1[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckBottomPanelInVerticalSplitContainerExpectedValues
	{
		#region Fields
		public bool UIDockPanel5DockPanelIsFloating = false;
		public string UIDockPanel5DockPanelOrientation = "Vertical";
		public int UIDockPanel5DockPanelGroupIndex = 1;
		public int UIDockPanel5DockPanelIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToFormViaDraggingParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockingPanelToFormViaContextMenuOptionExpectedValues
	{
		#region Fields
		public string UIDockPanel5DockPanelOrientation = "Horizontal";
		public int UIDockPanel5DockPanelGroupIndex = 0;
		public int UIDockPanel5DockPanelIndex = 3;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockFloatPanelToFormViaDraggingParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockingPanelToFormExpectedValues
	{
		#region Fields
		public bool UIDockPanel3DockPanelIsFloating = false;
		public string UIDockPanel3DockPanelOrientation = "Horizontal";
		public int UIDockPanel3DockPanelGroupIndex = 0;
		public int UIDockPanel3DockPanelIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeTabPositionInPanelContainerParams
	{
		#region Fields
		public int UISolutionExplorerDockButtonIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckPanelContainerTabIndexesExpectedValues
	{
		#region Fields
		public int UISolutionExplorerDockButtonIndex = 1;
		public int UIPropertiesButtonIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ClickDocumentFormMinimizeButtonParams
	{
		#region Fields
		public string UIMaximizeButtonPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ClickDocumentFormMaximizeButtonParams
	{
		#region Fields
		public string UIMaximizeButtonPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CloseMaximizedDocumentFormParams
	{
		#region Fields
		public string UIBarMdiButtonItemLinkBarBaseButtonItemPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockPanelToAnotherPanelParams
	{
		#region Fields
		public string UIPanelContainer2ClientDockInfoAsString = "[DockStyle]Fill[TargetPanel]1AncestorOfdockPanel1[Index]2[IsTab]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockingPanelToAnotherPanelExpectedValues
	{
		#region Fields
		public string UIDockPanel3DockPanelParentName = "panelContainer1";
		public string UIDockPanel3DockPanelDockStyle = "Fill";
		public bool UIDockPanel3DockPanelIsTab = true;
		public int UIDockPanel3DockPanelIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckUnpinnedPanelFloatDockStyleExpectedValues
	{
		#region Fields
		public string UIDockPanel6DockPanelDockStyle = "Float";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockingPanelToAnotherPanelAsTabExpectedValues
	{
		#region Fields
		public string UIDockPanel3DockPanelDockStyle = "Fill";
		public bool UIDockPanel3DockPanelIsTab = true;
		public string UIDockPanel3DockPanelParentName = "panelContainer1";
		public int UIDockPanel3DockPanelIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckNewDocumentFormCaptionExpectedValues
	{
		#region Fields
		public string UIDocument5Window1ControlName = "Document5";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CloseFloatDocumentFormViaClickCloseButtonParams
	{
		#region Fields
		public string UICloseButtonPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MaximizeFloatDocumentFormViaClickMaximizeButtonParams
	{
		#region Fields
		public string UIMaximizeButtonPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MinimizeFloatDocumentFormViaClickRestoreButtonParams
	{
		#region Fields
		public string UIRestoreButtonPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToTabbedViewLeftEdgeParams
	{
		#region Fields
		public string UIDocument3TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToTabbedViewRightEdgeParams
	{
		#region Fields
		public string UIDocument0TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]2[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockDocumentFormToLeftHorizontalContainerAsTabParams
	{
		#region Fields
		public string UIDocument3TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockFloatDocumentFormToTabbedViewLeftEdgeParams
	{
		#region Fields
		public string UIDocument3WindowTitleBarDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockFloatDocumentFormToTabbedViewRightEdgeParams
	{
		#region Fields
		public string UIDocument3WindowTitleBarDockInfoAsString = "[Orientation]Horizontal[GroupIndex]2[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeTabbedViewDocumentFormFloatViaDraggingParams
	{
		#region Fields
		public string UIDocument3TabPageDockInfoAsString = "[IsFloating]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockFloatDocumentFormToLeftHorizontalContainerAsTabParams
	{
		#region Fields
		public string UIDocument3WindowTitleBarDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CloseTabbedViewFloatDocumentFormViaCloseButtonParams
	{
		#region Fields
		public string UICloseButtonPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeVerticalContainerViaDockingDocumentFormToTopEdgeParams
	{
		#region Fields
		public string UIDocument3TabPageDockInfoAsString = "[Orientation]Vertical[GroupIndex]0[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeVerticalContainerViaDockingFloatDocumentFormToTabbedViewBottomEdgeParams
	{
		#region Fields
		public string UIDocument3WindowTitleBarDockInfoAsString = "[Orientation]Vertical[GroupIndex]1[DocumentIndex]-1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class SwitchToTabbedMDIDemoModuleParams
	{
		#region Fields
		public string UIListBoxControl1ListSelectedIndicesAsString = "24";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class MakeTabbedMDIDocumentFormFloatViaDraggingParams
	{
		#region Fields
		public string UIForm2TabPageDockInfoAsString = "[IsFloating]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFloatTabbedMDIDocumentFormExpectedValues
	{
		#region Fields
		public string UIForm2Window1ControlName = "Form 2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockFloatTabbedMDIDocumentFormAsTabParams
	{
		#region Fields
		public string UIForm2WindowTitleBarDockInfoAsString = "[Index]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UncheckFloatOnDragOptionParams
	{
		#region Fields
		public string UIFloatOnDragBarBaseButtonItemPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DragTabbedMDIDocumentFormParams
	{
		#region Fields
		public string UIForm2TabPageDockInfoAsString = "[Index]2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckConservationTabbedMDIDocumentFormIndexExpectedValues
	{
		#region Fields
		public int UIForm2TabPageIndex = 2;
		public string UIForm2TabPageText = "Form 2";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UncheckFloatOnDoubleClickOptionParams
	{
		#region Fields
		public string UIFloatOnDoubleClickBarBaseButtonItemPerformClick = "PerformClick";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeClosePageButtonInTabbedMDIDemoModuleParams
	{
		#region Fields
		public string UIClosePageButtonComboBoxValueTypeName = "DevExpress.XtraTab.ClosePageButtonShowMode";
		public string UIClosePageButtonComboBoxValueAsString = "InAllTabPageHeaders";
		public string UIClosePageButtonsMenuBarCloseActiveEditor = "CloseActiveEditor";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckClosedTabbedMDIDocumentFormExpectedValues
	{
		#region Fields
		public string UIForm2TabPageText = "Form 2";
		public int UIForm2TabPageIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ReorderMDITabsParams
	{
		#region Fields
		public string UIForm2TabPageDockInfoAsString = "[Index]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckMDITabIndexExpectedValues
	{
		#region Fields
		public int UIForm2TabPageIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeTabbedMDIHeaderLocationParams
	{
		#region Fields
		public string UIHeaderLocationComboBoxValueTypeName = "DevExpress.XtraTab.TabHeaderLocation";
		public string UIHeaderLocationComboBoxValueAsString = "Bottom";
		public string UIBarOptionsMenuBarCloseActiveEditor = "CloseActiveEditor";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeTabbedMDIHeaderOrientationParams
	{
		#region Fields
		public string UIHeaderOrientationComboBoxValueTypeName = "DevExpress.XtraTab.TabOrientation";
		public string UIHeaderOrientationComboBoxValueAsString = "Vertical";
		public string UIBarOptionsMenuBarCloseActiveEditor = "CloseActiveEditor";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ReorderTabsInTabbedViewDemoModuleParams
	{
		#region Fields
		public string UIDocument4TabPageDockInfoAsString = "[Orientation]Horizontal[GroupIndex]0[DocumentIndex]1";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckTabIndexInTabbedViewDemoModuleExpectedValues
	{
		#region Fields
		public string UIDocument4TabPageOrientation = "Horizontal";
		public int UIDocument4TabPageGroupIndex = 0;
		public int UIDocument4TabPageIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class ChangeShowCloseButtonModeParams
	{
		#region Fields
		public string UIShowCloseButtonComboBoxValueTypeName = "DevExpress.XtraTab.ClosePageButtonShowMode";
		public string UIShowCloseButtonComboBoxValueAsString = "InAllTabPagesAndTabControlHeader";
		public string UIBarOptionsMenuBarCloseActiveEditor = "CloseActiveEditor";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class SwitchOnHeaderAutoFillOptionParams
	{
		#region Fields
		public string UIHeaderAutoFillComboBoxValueTypeName = "DevExpress.Utils.DefaultBoolean";
		public string UIHeaderAutoFillComboBoxValueAsString = "True";
		public string UIBarOptionsMenuBarCloseActiveEditor = "CloseActiveEditor";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDocumentsAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues
	{
		#region Fields
		public string UIDocument4TabPageOrientation = "Vertical";
		public int UIDocument4TabPageGroupIndex = 0;
		public int UIDocument4TabPageIndex = 2;
		public string UIDocument3TabPageOrientation = "Vertical";
		public int UIDocument3TabPageGroupIndex = 0;
		public int UIDocument3TabPageIndex = 1;
		public string UIDocument2TabPageOrientation = "Vertical";
		public int UIDocument2TabPageGroupIndex = 0;
		public int UIDocument2TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateTabContainerFromTwoUntitledPanelsParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Fill[TargetPanelLayout]Left-1[Index]0[IsTab]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckTabContainerFromTwoUntitledPanelsExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Fill";
		public bool UIDockPanelClient1IsTab = true;
		public string UIDockPanelClient1Tabbed = "False";
		public string UIDockPanelClient11DockStyle = "Fill";
		public bool UIDockPanelClient11IsTab = true;
		public string UIDockPanelClient11Tabbed = "False";
		public string UIDockPanelClient2Tabbed = "True";
		public string UIDockPanelClient2DockStyle = "Left";
		public bool UIDockPanelClient2IsTab = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateSplitContainerFromTwoUntitledPanelsParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Fill[TargetPanelLayout]Left-1[Index]0[IsTab]False";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSplitContainerFromTwoUntitledPanelsExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Fill";
		public bool UIDockPanelClient1IsTab = false;
		public string UIDockPanelClient1Tabbed = "False";
		public int UIDockPanelClient1Index = 0;
		public string UIDockPanelClient11DockStyle = "Fill";
		public bool UIDockPanelClient11IsTab = false;
		public string UIDockPanelClient11Tabbed = "False";
		public int UIDockPanelClient11Index = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class DockTabContainerFromTwoUntitledPanelsParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Top[Index]0";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockingTabContainerFromTwoUntitledPanelsExpectedValues
	{
		#region Fields
		public string UIDockPanelClientDockStyle = "Top";
		public bool UIDockPanelClientIsTab = false;
		public string UIDockPanelClientTabbed = "True";
		public int UIDockPanelClientIndex = 0;
		public string UIDockPanelButtonDockStyle = "Fill";
		public int UIDockPanelButtonIndex = 0;
		public string UIDockPanel1ButtonDockStyle = "Fill";
		public int UIDockPanel1ButtonIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateSplitContainerFromTabContainerAndUntitledPanelParams
	{
		#region Fields
		public string UIDockPanelClientDockInfoAsString = "[DockStyle]Top[TargetPanelLayout]Left-1[Index]0[IsTab]False";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSplitContainerFromTabContainerAndUntitledPanelExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Top";
		public bool UIDockPanelClient1IsTab = false;
		public string UIDockPanelClient1Tabbed = "False";
		public int UIDockPanelClient1Index = 0;
		public string UIDockPanelDockPanel1DockStyle = "Top";
		public bool UIDockPanelDockPanel1IsTab = false;
		public bool UIDockPanelDockPanel1Tabbed = true;
		public int UIDockPanelDockPanel1Index = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateSecondTabContainerFromTwoUntitledPanelsParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Fill[TargetPanelLayout]Left-2[Index]0[IsTab]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateSplitContainerFromTwoTabContainersParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Top[TargetPanelLayout]Left-1[Index]0[IsTab]False";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckSplitContainerFromTwoTabContainersExpectedValues
	{
		#region Fields
		public string UIDockPanelClient1DockStyle = "Top";
		public bool UIDockPanelClient1IsTab = false;
		public string UIDockPanelClient1Tabbed = "True";
		public int UIDockPanelClient1Index = 0;
		public string UIDockPanelClient11DockStyle = "Top";
		public bool UIDockPanelClient11IsTab = false;
		public string UIDockPanelClient11Tabbed = "True";
		public int UIDockPanelClient11Index = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CreateTabContainerFromTwoTabContainersParams
	{
		#region Fields
		public string UIDockPanelClient2DockInfoAsString = "[DockStyle]Fill[TargetPanelLayout]Left-1[Index]1[IsTab]True";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckTabContainerFromTwoTabContainersExpectedValues
	{
		#region Fields
		public string UIDockPanelButtonDockStyle = "Fill";
		public int UIDockPanelButtonIndex = 0;
		public string UIDockPanel1ButtonDockStyle = "Fill";
		public int UIDockPanel1ButtonIndex = 1;
		public string UIDockPanel2ButtonDockStyle = "Fill";
		public int UIDockPanel2ButtonIndex = 2;
		public string UIDockPanel3ButtonDockStyle = "Fill";
		public int UIDockPanel3ButtonIndex = 3;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedTabbedMDIDocumentFormAsTabExpectedValues
	{
		#region Fields
		public int UIForm2TabPageIndex = 1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckLastDocumentIsVisibleExpectedValues
	{
		#region Fields
		public bool UIDocument2TabPageExists = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFloatDocumentFormDoesNotExistExpectedValues
	{
		#region Fields
		public bool UIDocument0WindowTitleBarExists = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFloatingDocumentFormDockStyleExpectedValues
	{
		#region Fields
		public bool UIDocument0WindowIsFloating = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDocumentManagerTabIndexExpectedValues
	{
		#region Fields
		public int UIDocument0TabPageIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToLeftEdgeExpectedValues
	{
		#region Fields
		public string UIDocument0TabPageOrientation = "Horizontal";
		public int UIDocument0TabPageGroupIndex = 0;
		public int UIDocument0TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToRightEdgeExpectedValues
	{
		#region Fields
		public string UIDocument0TabPageOrientation = "Horizontal";
		public int UIDocument0TabPageGroupIndex = 1;
		public int UIDocument0TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToTopEdgeExpectedValues
	{
		#region Fields
		public string UIDocument0TabPageOrientation = "Vertical";
		public int UIDocument0TabPageGroupIndex = 0;
		public int UIDocument0TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToBottomEdgeExpectedValues
	{
		#region Fields
		public string UIDocument0TabPageOrientation = "Vertical";
		public int UIDocument0TabPageGroupIndex = 1;
		public int UIDocument0TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckLeftPanelInDocumentManagerHorizontalSplitContainerExpectedValues
	{
		#region Fields
		public string UIRightPanelTabPageOrientation = "Horizontal";
		public int UIRightPanelTabPageGroupIndex = 0;
		public int UIRightPanelTabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckRightPanelInDocumentManagerHorizontalSplitContainerExpectedValues
	{
		#region Fields
		public string UITopLeftPanelTabPageOrientation = "Horizontal";
		public int UITopLeftPanelTabPageGroupIndex = 1;
		public int UITopLeftPanelTabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckTopPanelInDocumentManagerVerticalSplitContainerExpectedValues
	{
		#region Fields
		public string UIBottomLeftPanelTabPageOrientation = "Vertical";
		public int UIBottomLeftPanelTabPageGroupIndex = 0;
		public int UIBottomLeftPanelTabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckBottomPanelInDocumentManagerVerticalSplitContainerExpectedValues
	{
		#region Fields
		public string UIBottomLeftPanelTabPageOrientation = "Vertical";
		public int UIBottomLeftPanelTabPageGroupIndex = 1;
		public int UIBottomLeftPanelTabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedPanelToDocumentFormExpectedValues
	{
		#region Fields
		public string UIBottomLeftPanelTabPageOrientation = "Horizontal";
		public int UIBottomLeftPanelTabPageGroupIndex = 0;
		public int UIBottomLeftPanelTabPageIndex = 3;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedPanelToDocumentFormViaDraggingPanelCaptionAndDroppingToDocumentFormTabExpectedValues
	{
		#region Fields
		public string UIBottomLeftPanelTabPageOrientation = "Horizontal";
		public int UIBottomLeftPanelTabPageGroupIndex = 0;
		public int UIBottomLeftPanelTabPageIndex = 2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFirstDocumentIsActiveExpectedValues
	{
		#region Fields
		public string UILabelControlLabelText = @"Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit. Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc.";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckClosedDocumentFormViaDialogWindowsFormExpectedValues
	{
		#region Fields
		public bool UIDocument2TabPageExists = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckCloseAllDocumentOptionExpectedValues
	{
		#region Fields
		public bool UIDocument2TabPageExists = false;
		public bool UIDocument1TabPageExists = false;
		public bool UIDocument0TabPageExists = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckNewDocumentAddedExpectedValues
	{
		#region Fields
		public bool UIDocument5CustomExists = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckNewTabAddedExpectedValues
	{
		#region Fields
		public bool UIDocument5TabPageExists = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckNewTabAddedToRightGroupExpectedValues
	{
		#region Fields
		public bool UIDocument5TabPageExists = true;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckChangedOrientationExpectedValues
	{
		#region Fields
		public string UIDocument2TabPageOrientation = "Vertical";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckVerticalContainerAfterDockingDocumentFormToTopEdgeExpectedValues
	{
		#region Fields
		public string UIDocument3TabPageOrientation = "Vertical";
		public int UIDocument3TabPageGroupIndex = 0;
		public int UIDocument3TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckVerticalContainerAfterDockingFloatDocumentFormToTabbedViewBottomEdgeExpectedValues
	{
		#region Fields
		public string UIDocument3TabPageOrientation = "Vertical";
		public int UIDocument3TabPageGroupIndex = 1;
		public int UIDocument3TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToTabbedViewLeftEdgeExpectedValues
	{
		#region Fields
		public string UIDocument3TabPageOrientation = "Horizontal";
		public int UIDocument3TabPageGroupIndex = 0;
		public int UIDocument3TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToTabbedViewRightEdgeExpectedValues
	{
		#region Fields
		public string UIDocument3TabPageOrientation = "Horizontal";
		public int UIDocument3TabPageGroupIndex = 2;
		public int UIDocument3TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckTabsHaveNoCloseButtonExpectedValues
	{
		#region Fields
		public bool UIDocument0ButtonExists = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDockedFormToLeftHorizontalContainerAsTabExpectedValues
	{
		#region Fields
		public int UIDocument3TabPageIndex = 1;
		public int UIDocument3TabPageGroupIndex = 0;
		public string UIDocument3TabPageOrientation = "Horizontal";
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFirstDocumentDockedToRightEdgeExpectedValues
	{
		#region Fields
		public string UIDocument0TabPageOrientation = "Horizontal";
		public int UIDocument0TabPageGroupIndex = 2;
		public int UIDocument0TabPageIndex = 0;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckFloatDocumentFormClosedExpectedValues
	{
		#region Fields
		public bool UIDocument3WindowExists = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class CheckDocument0ClosedExpectedValues
	{
		#region Fields
		public bool UIDocument0TabPageExists = false;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow : DXWindow
	{
		public UIDockingDemoCDemoWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIPanelContainer2Client UIPanelContainer2Client
		{
			get
			{
				if ((this.mUIPanelContainer2Client == null))
				{
					this.mUIPanelContainer2Client = new UIPanelContainer2Client(this);
				}
				return this.mUIPanelContainer2Client;
			}
		}
		#endregion
		#region Fields
		private UIPanelContainer2Client mUIPanelContainer2Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelContainer2Client : DXTestControl
	{
		public UIPanelContainer2Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXButton UIPinButtonButton
		{
			get
			{
				if ((this.mUIPinButtonButton == null))
				{
					this.mUIPinButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUIPinButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "PinButton";
					this.mUIPinButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIPinButtonButton.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIPinButtonButton;
			}
		}
		public DXButton UIDockPanel4Button
		{
			get
			{
				if ((this.mUIDockPanel4Button == null))
				{
					this.mUIDockPanel4Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel4Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel4";
					this.mUIDockPanel4Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIDockPanel4Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel4Button;
			}
		}
		public DXButton UIDockPanel5Button
		{
			get
			{
				if ((this.mUIDockPanel5Button == null))
				{
					this.mUIDockPanel5Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel5Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel5";
					this.mUIDockPanel5Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIDockPanel5Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel5Button;
			}
		}
		public UIDockPanel5Client UIDockPanel5Client
		{
			get
			{
				if ((this.mUIDockPanel5Client == null))
				{
					this.mUIDockPanel5Client = new UIDockPanel5Client(this);
				}
				return this.mUIDockPanel5Client;
			}
		}
		public DXButton UIDockPanel3Button
		{
			get
			{
				if ((this.mUIDockPanel3Button == null))
				{
					this.mUIDockPanel3Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel3Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
					this.mUIDockPanel3Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIDockPanel3Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel3Button;
			}
		}
		public UIDockPanel3Client UIDockPanel3Client
		{
			get
			{
				if ((this.mUIDockPanel3Client == null))
				{
					this.mUIDockPanel3Client = new UIDockPanel3Client(this);
				}
				return this.mUIDockPanel3Client;
			}
		}
		public DXTestControl UITopSeparator
		{
			get
			{
				if ((this.mUITopSeparator == null))
				{
					this.mUITopSeparator = new DXTestControl(this);
					#region Search Criteria
					this.mUITopSeparator.SearchProperties[DXTestControl.PropertyNames.Name] = "Top";
					this.mUITopSeparator.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelResizeZone";
					this.mUITopSeparator.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUITopSeparator;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIPinButtonButton;
		private DXButton mUIDockPanel4Button;
		private DXButton mUIDockPanel5Button;
		private UIDockPanel5Client mUIDockPanel5Client;
		private DXButton mUIDockPanel3Button;
		private UIDockPanel3Client mUIDockPanel3Client;
		private DXTestControl mUITopSeparator;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel5Client : DXTestControl
	{
		public UIDockPanel5Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel5";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel5_ContainerCustom UIDockPanel5_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel5_ContainerCustom == null))
				{
					this.mUIDockPanel5_ContainerCustom = new UIDockPanel5_ContainerCustom(this);
				}
				return this.mUIDockPanel5_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel5_ContainerCustom mUIDockPanel5_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel5_ContainerCustom : DXTestControl
	{
		public UIDockPanel5_ContainerCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel5_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTextEdit UITextBox2Edit
		{
			get
			{
				if ((this.mUITextBox2Edit == null))
				{
					this.mUITextBox2Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUITextBox2Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "textBox2";
					this.mUITextBox2Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MemoEdit";
					this.mUITextBox2Edit.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUITextBox2Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUITextBox2Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3Client : DXTestControl
	{
		public UIDockPanel3Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel3_ContainerCustom UIDockPanel3_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel3_ContainerCustom == null))
				{
					this.mUIDockPanel3_ContainerCustom = new UIDockPanel3_ContainerCustom(this);
				}
				return this.mUIDockPanel3_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel3_ContainerCustom mUIDockPanel3_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3_ContainerCustom : DXTestControl
	{
		public UIDockPanel3_ContainerCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXGrid UIGridControl1Table
		{
			get
			{
				if ((this.mUIGridControl1Table == null))
				{
					this.mUIGridControl1Table = new DXGrid(this);
					#region Search Criteria
					this.mUIGridControl1Table.SearchProperties[DXTestControl.PropertyNames.Name] = "gridControl1";
					this.mUIGridControl1Table.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GridControl";
					this.mUIGridControl1Table.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIGridControl1Table;
			}
		}
		#endregion
		#region Fields
		private DXGrid mUIGridControl1Table;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow1 : WinWindow
	{
		public UIDockingDemoCDemoWindow1()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIFilecsWindow UIFilecsWindow
		{
			get
			{
				if ((this.mUIFilecsWindow == null))
				{
					this.mUIFilecsWindow = new UIFilecsWindow(this);
				}
				return this.mUIFilecsWindow;
			}
		}
		#endregion
		#region Fields
		private UIFilecsWindow mUIFilecsWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIFilecsWindow : WinWindow
	{
		public UIFilecsWindow(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIFilecsClient UIFilecsClient
		{
			get
			{
				if ((this.mUIFilecsClient == null))
				{
					this.mUIFilecsClient = new UIFilecsClient(this);
				}
				return this.mUIFilecsClient;
			}
		}
		#endregion
		#region Fields
		private UIFilecsClient mUIFilecsClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIFilecsClient : WinClient
	{
		public UIFilecsClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[WinControl.PropertyNames.Name] = "File.cs";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public WinWindow UIFilecsWindow
		{
			get
			{
				if ((this.mUIFilecsWindow == null))
				{
					this.mUIFilecsWindow = new WinWindow(this);
					#region Search Criteria
					this.mUIFilecsWindow.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "using System;using System.Windows.Forms;namespace DevExpress.XtraBars.Alerter {  " +
						"  class AlertPopupMenuButton : AlertPredefinedButton {        PopupMenu menu;   " +
						"     AlertButtonCollection collection;        public AlertPopupMenuButton(AlertF" +
						"orm form, AlertButtonCollection collection, PopupMenu menu)            : base(Al" +
						"ertControlHelper.WindowImages.Images[3]) {            this.menu = menu;         " +
						"   this.collection = collection;            SetOwner(form);            Bounds = " +
						"form.ViewInfo.GetControlBoxElementRectangle(collection.PredefinedButtonCount, th" +
						"is.GetButtonSize());            //Hint = \"Show popup menu\";            if(menu !" +
						"= null)                menu.CloseUp += new EventHandler(menu_CloseUp);        } " +
						"       public override void Dispose() {            if(menu != null)             " +
						"    menu.CloseUp -= new EventHandler(menu_CloseUp);            base.Dispose();  " +
						"      }        void menu_CloseUp(object sender, EventArgs e) {            Owner." +
						"Pin = IsPinDown;            actionElement = false;            Invalidate();     " +
						"   }        bool IsPinDown {            get {                foreach(AlertButton" +
						" item in collection) {                    if(item is AlertPinButton & item.Down)" +
						"                        return true;                }                return fals" +
						"e;            }        }        void SetInfoRecursion(object container) {       " +
						"     BarLinkContainerItem cont = container as BarLinkContainerItem;            i" +
						"f(cont == null) return;            foreach(BarItemLink link in cont.ItemLinks) {" +
						"                SetInfoRecursion(link.Item);                link.Item.Tag = new " +
						"AlertClickEventArgs(Owner.Info, Owner);            }        }        public over" +
						"ride void OnClick() {            base.OnClick();            Owner.Pin = true;   " +
						"         actionElement = true;            foreach(BarItemLink link in menu.ItemL" +
						"inks) {                SetInfoRecursion(link.Item);                link.Item.Tag" +
						" = new AlertClickEventArgs(Owner.Info, Owner);            }            this.menu" +
						".Activator = Owner;            this.menu.ShowPopup(Cursor.Position);        }   " +
						" }}";
					this.mUIFilecsWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
					this.mUIFilecsWindow.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIFilecsWindow;
			}
		}
		#endregion
		#region Fields
		private WinWindow mUIFilecsWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow2 : DXWindow
	{
		public UIDockingDemoCDemoWindow2()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIBottomAutoHideContaiClient UIBottomAutoHideContaiClient
		{
			get
			{
				if ((this.mUIBottomAutoHideContaiClient == null))
				{
					this.mUIBottomAutoHideContaiClient = new UIBottomAutoHideContaiClient(this);
				}
				return this.mUIBottomAutoHideContaiClient;
			}
		}
		#endregion
		#region Fields
		private UIBottomAutoHideContaiClient mUIBottomAutoHideContaiClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBottomAutoHideContaiClient : DXTestControl
	{
		public UIBottomAutoHideContaiClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BottomAutoHideContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AutoHideContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTestControl UIPanelContainer2Client
		{
			get
			{
				if ((this.mUIPanelContainer2Client == null))
				{
					this.mUIPanelContainer2Client = new DXTestControl(this);
					#region Search Criteria
					this.mUIPanelContainer2Client.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer2";
					this.mUIPanelContainer2Client.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIPanelContainer2Client.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIPanelContainer2Client;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIPanelContainer2Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow3 : DXWindow
	{
		public UIDockingDemoCDemoWindow3()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIAutoHideContainerClient UIAutoHideContainerClient
		{
			get
			{
				if ((this.mUIAutoHideContainerClient == null))
				{
					this.mUIAutoHideContainerClient = new UIAutoHideContainerClient(this);
				}
				return this.mUIAutoHideContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIAutoHideContainerClient mUIAutoHideContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIAutoHideContainerClient : DXTestControl
	{
		public UIAutoHideContainerClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "LeftAutoHideContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AutoHideContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXButton UIDockPanel6Button
		{
			get
			{
				if ((this.mUIDockPanel6Button == null))
				{
					this.mUIDockPanel6Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel6Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel6";
					this.mUIDockPanel6Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AutoHideContainerButton";
					this.mUIDockPanel6Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel6Button;
			}
		}
		public DXButton UIToolboxButton
		{
			get
			{
				if ((this.mUIToolboxButton == null))
				{
					this.mUIToolboxButton = new DXButton(this);
					#region Search Criteria
					this.mUIToolboxButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Toolbox";
					this.mUIToolboxButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AutoHideContainerButton";
					this.mUIToolboxButton.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIToolboxButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDockPanel6Button;
		private DXButton mUIToolboxButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow4 : DXWindow
	{
		public UIDockingDemoCDemoWindow4()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIAutoHideControlClient UIAutoHideControlClient
		{
			get
			{
				if ((this.mUIAutoHideControlClient == null))
				{
					this.mUIAutoHideControlClient = new UIAutoHideControlClient(this);
				}
				return this.mUIAutoHideControlClient;
			}
		}
		#endregion
		#region Fields
		private UIAutoHideControlClient mUIAutoHideControlClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIAutoHideControlClient : DXTestControl
	{
		public UIAutoHideControlClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "LeftAutoHideControl";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AutoHideControl";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel6Client UIDockPanel6Client
		{
			get
			{
				if ((this.mUIDockPanel6Client == null))
				{
					this.mUIDockPanel6Client = new UIDockPanel6Client(this);
				}
				return this.mUIDockPanel6Client;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel6Client mUIDockPanel6Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel6Client : DXTestControl
	{
		public UIDockPanel6Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel6";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXButton UIPinButtonButton
		{
			get
			{
				if ((this.mUIPinButtonButton == null))
				{
					this.mUIPinButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUIPinButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "PinButton";
					this.mUIPinButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIPinButtonButton.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIPinButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIPinButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow5 : DXWindow
	{
		public UIDockingDemoCDemoWindow5()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanel6Client
		{
			get
			{
				if ((this.mUIDockPanel6Client == null))
				{
					this.mUIDockPanel6Client = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanel6Client.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel6";
					this.mUIDockPanel6Client.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanel6Client.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel6Client;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanel6Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow6 : DXWindow
	{
		public UIDockingDemoCDemoWindow6()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanelClient UIDockPanelClient
		{
			get
			{
				if ((this.mUIDockPanelClient == null))
				{
					this.mUIDockPanelClient = new UIDockPanelClient(this);
				}
				return this.mUIDockPanelClient;
			}
		}
		#endregion
		#region Fields
		private UIDockPanelClient mUIDockPanelClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanelClient : DXTestControl
	{
		public UIDockPanelClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXButton UICloseButtonButton
		{
			get
			{
				if ((this.mUICloseButtonButton == null))
				{
					this.mUICloseButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "CloseButton";
					this.mUICloseButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUICloseButtonButton.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUICloseButtonButton;
			}
		}
		public DXButton UIDockPanel1Button
		{
			get
			{
				if ((this.mUIDockPanel1Button == null))
				{
					this.mUIDockPanel1Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel1Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
					this.mUIDockPanel1Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIDockPanel1Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel1Button;
			}
		}
		public DXButton UIDockPanel4Button
		{
			get
			{
				if ((this.mUIDockPanel4Button == null))
				{
					this.mUIDockPanel4Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel4Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel4";
					this.mUIDockPanel4Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIDockPanel4Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel4Button;
			}
		}
		public DXButton UIDockPanel2Button
		{
			get
			{
				if ((this.mUIDockPanel2Button == null))
				{
					this.mUIDockPanel2Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel2Button.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2";
					this.mUIDockPanel2Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					this.mUIDockPanel2Button.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel2Button;
			}
		}
		public UIDockPanel3DockPanel UIDockPanel3DockPanel
		{
			get
			{
				if ((this.mUIDockPanel3DockPanel == null))
				{
					this.mUIDockPanel3DockPanel = new UIDockPanel3DockPanel(this);
				}
				return this.mUIDockPanel3DockPanel;
			}
		}
		public DXButton UISolutionExplorerDockButton
		{
			get
			{
				if ((this.mUISolutionExplorerDockButton == null))
				{
					this.mUISolutionExplorerDockButton = new DXButton(this);
					#region Search Criteria
					this.mUISolutionExplorerDockButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Solution Explorer - Docking Demo";
					this.mUISolutionExplorerDockButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUISolutionExplorerDockButton.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUISolutionExplorerDockButton;
			}
		}
		public DXButton UIPropertiesButton
		{
			get
			{
				if ((this.mUIPropertiesButton == null))
				{
					this.mUIPropertiesButton = new DXButton(this);
					#region Search Criteria
					this.mUIPropertiesButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Properties";
					this.mUIPropertiesButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIPropertiesButton.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIPropertiesButton;
			}
		}
		public DXTestControl UILeftSeparator
		{
			get
			{
				if ((this.mUILeftSeparator == null))
				{
					this.mUILeftSeparator = new DXTestControl(this);
					#region Search Criteria
					this.mUILeftSeparator.SearchProperties[DXTestControl.PropertyNames.Name] = "Left";
					this.mUILeftSeparator.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelResizeZone";
					this.mUILeftSeparator.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUILeftSeparator;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseButtonButton;
		private DXButton mUIDockPanel1Button;
		private DXButton mUIDockPanel4Button;
		private DXButton mUIDockPanel2Button;
		private UIDockPanel3DockPanel mUIDockPanel3DockPanel;
		private DXButton mUISolutionExplorerDockButton;
		private DXButton mUIPropertiesButton;
		private DXTestControl mUILeftSeparator;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3DockPanel : DXDockPanel
	{
		public UIDockPanel3DockPanel(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel3_ContainerCustom1 UIDockPanel3_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel3_ContainerCustom == null))
				{
					this.mUIDockPanel3_ContainerCustom = new UIDockPanel3_ContainerCustom1(this);
				}
				return this.mUIDockPanel3_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel3_ContainerCustom1 mUIDockPanel3_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3_ContainerCustom1 : DXTestControl
	{
		public UIDockPanel3_ContainerCustom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXGrid UIGridControl1Table
		{
			get
			{
				if ((this.mUIGridControl1Table == null))
				{
					this.mUIGridControl1Table = new DXGrid(this);
					#region Search Criteria
					this.mUIGridControl1Table.SearchProperties[DXTestControl.PropertyNames.Name] = "gridControl1";
					this.mUIGridControl1Table.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GridControl";
					this.mUIGridControl1Table.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIGridControl1Table;
			}
		}
		#endregion
		#region Fields
		private DXGrid mUIGridControl1Table;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow7 : DXWindow
	{
		public UIDockingDemoCDemoWindow7()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanel2Client
		{
			get
			{
				if ((this.mUIDockPanel2Client == null))
				{
					this.mUIDockPanel2Client = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanel2Client.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2";
					this.mUIDockPanel2Client.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanel2Client.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIDockPanel2Client;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanel2Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow8 : DXWindow
	{
		public UIDockingDemoCDemoWindow8()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIBarDockControlCustom UIBarDockControlCustom
		{
			get
			{
				if ((this.mUIBarDockControlCustom == null))
				{
					this.mUIBarDockControlCustom = new UIBarDockControlCustom(this);
				}
				return this.mUIBarDockControlCustom;
			}
		}
		#endregion
		#region Fields
		private UIBarDockControlCustom mUIBarDockControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarDockControlCustom : DXTestControl
	{
		public UIBarDockControlCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BarDockControl[3]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarDockControl";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIViewMenuBar UIViewMenuBar
		{
			get
			{
				if ((this.mUIViewMenuBar == null))
				{
					this.mUIViewMenuBar = new UIViewMenuBar(this);
				}
				return this.mUIViewMenuBar;
			}
		}
		#endregion
		#region Fields
		private UIViewMenuBar mUIViewMenuBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIViewMenuBar : DXMenu
	{
		public UIViewMenuBar(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "View";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UISolutionExplorerBarBaseButtonItem
		{
			get
			{
				if ((this.mUISolutionExplorerBarBaseButtonItem == null))
				{
					this.mUISolutionExplorerBarBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUISolutionExplorerBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Solution Ex&plorer";
					this.mUISolutionExplorerBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarBaseButtonItem";
					this.mUISolutionExplorerBarBaseButtonItem.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUISolutionExplorerBarBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUISolutionExplorerBarBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow9 : DXWindow
	{
		public UIDockingDemoCDemoWindow9()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIMdiClientTabList UIMdiClientTabList
		{
			get
			{
				if ((this.mUIMdiClientTabList == null))
				{
					this.mUIMdiClientTabList = new UIMdiClientTabList(this);
				}
				return this.mUIMdiClientTabList;
			}
		}
		#endregion
		#region Fields
		private UIMdiClientTabList mUIMdiClientTabList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMdiClientTabList : DXTestControl
	{
		public UIMdiClientTabList(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MdiClient[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClient";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTestControl UITaskList0BuildErrorsTabPage
		{
			get
			{
				if ((this.mUITaskList0BuildErrorsTabPage == null))
				{
					this.mUITaskList0BuildErrorsTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUITaskList0BuildErrorsTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Task List - 0 Build Errors";
					this.mUITaskList0BuildErrorsTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUITaskList0BuildErrorsTabPage.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUITaskList0BuildErrorsTabPage;
			}
		}
		public UIDockPanel5Window UIDockPanel5Window
		{
			get
			{
				if ((this.mUIDockPanel5Window == null))
				{
					this.mUIDockPanel5Window = new UIDockPanel5Window(this);
				}
				return this.mUIDockPanel5Window;
			}
		}
		public UIDockPanel1Window UIDockPanel1Window
		{
			get
			{
				if ((this.mUIDockPanel1Window == null))
				{
					this.mUIDockPanel1Window = new UIDockPanel1Window(this);
				}
				return this.mUIDockPanel1Window;
			}
		}
		public UIDockPanel4Window UIDockPanel4Window
		{
			get
			{
				if ((this.mUIDockPanel4Window == null))
				{
					this.mUIDockPanel4Window = new UIDockPanel4Window(this);
				}
				return this.mUIDockPanel4Window;
			}
		}
		public UIDockPanel3Window UIDockPanel3Window
		{
			get
			{
				if ((this.mUIDockPanel3Window == null))
				{
					this.mUIDockPanel3Window = new UIDockPanel3Window(this);
				}
				return this.mUIDockPanel3Window;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUITaskList0BuildErrorsTabPage;
		private UIDockPanel5Window mUIDockPanel5Window;
		private UIDockPanel1Window mUIDockPanel1Window;
		private UIDockPanel4Window mUIDockPanel4Window;
		private UIDockPanel3Window mUIDockPanel3Window;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel5Window : DXWindow
	{
		public UIDockPanel5Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel5";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel5DockPanel UIDockPanel5DockPanel
		{
			get
			{
				if ((this.mUIDockPanel5DockPanel == null))
				{
					this.mUIDockPanel5DockPanel = new UIDockPanel5DockPanel(this);
				}
				return this.mUIDockPanel5DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel5DockPanel mUIDockPanel5DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel5DockPanel : DXDockPanel
	{
		public UIDockPanel5DockPanel(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel5";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel5_ContainerCustom1 UIDockPanel5_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel5_ContainerCustom == null))
				{
					this.mUIDockPanel5_ContainerCustom = new UIDockPanel5_ContainerCustom1(this);
				}
				return this.mUIDockPanel5_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel5_ContainerCustom1 mUIDockPanel5_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel5_ContainerCustom1 : DXTestControl
	{
		public UIDockPanel5_ContainerCustom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel5_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTextEdit UITextBox2Edit
		{
			get
			{
				if ((this.mUITextBox2Edit == null))
				{
					this.mUITextBox2Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUITextBox2Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "textBox2";
					this.mUITextBox2Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MemoEdit";
					this.mUITextBox2Edit.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUITextBox2Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUITextBox2Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel1Window : DXWindow
	{
		public UIDockPanel1Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel1DockPanel UIDockPanel1DockPanel
		{
			get
			{
				if ((this.mUIDockPanel1DockPanel == null))
				{
					this.mUIDockPanel1DockPanel = new UIDockPanel1DockPanel(this);
				}
				return this.mUIDockPanel1DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel1DockPanel mUIDockPanel1DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel1DockPanel : DXDockPanel
	{
		public UIDockPanel1DockPanel(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel1_ContainerCustom UIDockPanel1_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel1_ContainerCustom == null))
				{
					this.mUIDockPanel1_ContainerCustom = new UIDockPanel1_ContainerCustom(this);
				}
				return this.mUIDockPanel1_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel1_ContainerCustom mUIDockPanel1_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel1_ContainerCustom : DXTestControl
	{
		public UIDockPanel1_ContainerCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTestControl UITreeView1Custom
		{
			get
			{
				if ((this.mUITreeView1Custom == null))
				{
					this.mUITreeView1Custom = new DXTestControl(this);
					#region Search Criteria
					this.mUITreeView1Custom.SearchProperties[DXTestControl.PropertyNames.Name] = "treeView1";
					this.mUITreeView1Custom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TreeList";
					this.mUITreeView1Custom.SearchProperties[DXTestControl.PropertyNames.HierarchyLevel] = "3";
					this.mUITreeView1Custom.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUITreeView1Custom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUITreeView1Custom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel4Window : DXWindow
	{
		public UIDockPanel4Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel4DockPanel UIDockPanel4DockPanel
		{
			get
			{
				if ((this.mUIDockPanel4DockPanel == null))
				{
					this.mUIDockPanel4DockPanel = new UIDockPanel4DockPanel(this);
				}
				return this.mUIDockPanel4DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel4DockPanel mUIDockPanel4DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel4DockPanel : DXDockPanel
	{
		public UIDockPanel4DockPanel(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel4_ContainerCustom UIDockPanel4_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel4_ContainerCustom == null))
				{
					this.mUIDockPanel4_ContainerCustom = new UIDockPanel4_ContainerCustom(this);
				}
				return this.mUIDockPanel4_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel4_ContainerCustom mUIDockPanel4_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel4_ContainerCustom : DXTestControl
	{
		public UIDockPanel4_ContainerCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel4_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXTextEdit UITextBox1Edit
		{
			get
			{
				if ((this.mUITextBox1Edit == null))
				{
					this.mUITextBox1Edit = new DXTextEdit(this);
					#region Search Criteria
					this.mUITextBox1Edit.SearchProperties[DXTestControl.PropertyNames.Name] = "textBox1";
					this.mUITextBox1Edit.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MemoEdit";
					this.mUITextBox1Edit.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUITextBox1Edit;
			}
		}
		#endregion
		#region Fields
		private DXTextEdit mUITextBox1Edit;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3Window : DXWindow
	{
		public UIDockPanel3Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel3DockPanel1 UIDockPanel3DockPanel
		{
			get
			{
				if ((this.mUIDockPanel3DockPanel == null))
				{
					this.mUIDockPanel3DockPanel = new UIDockPanel3DockPanel1(this);
				}
				return this.mUIDockPanel3DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel3DockPanel1 mUIDockPanel3DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3DockPanel1 : DXDockPanel
	{
		public UIDockPanel3DockPanel1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public UIDockPanel3_ContainerCustom2 UIDockPanel3_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel3_ContainerCustom == null))
				{
					this.mUIDockPanel3_ContainerCustom = new UIDockPanel3_ContainerCustom2(this);
				}
				return this.mUIDockPanel3_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel3_ContainerCustom2 mUIDockPanel3_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3_ContainerCustom2 : DXTestControl
	{
		public UIDockPanel3_ContainerCustom2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3_Container";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXGrid UIGridControl1Table
		{
			get
			{
				if ((this.mUIGridControl1Table == null))
				{
					this.mUIGridControl1Table = new DXGrid(this);
					#region Search Criteria
					this.mUIGridControl1Table.SearchProperties[DXTestControl.PropertyNames.Name] = "gridControl1";
					this.mUIGridControl1Table.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GridControl";
					this.mUIGridControl1Table.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIGridControl1Table;
			}
		}
		#endregion
		#region Fields
		private DXGrid mUIGridControl1Table;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingDemoCDemoWindow10 : DXWindow
	{
		public UIDockingDemoCDemoWindow10()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockingDemo (C# Demo)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("DockingDemo (C# Demo)");
			#endregion
		}
		#region Properties
		public DXWindow UIAdornerLayeredWindowWindow
		{
			get
			{
				if ((this.mUIAdornerLayeredWindowWindow == null))
				{
					this.mUIAdornerLayeredWindowWindow = new DXWindow(this);
					#region Search Criteria
					this.mUIAdornerLayeredWindowWindow.SearchProperties[DXTestControl.PropertyNames.Name] = "AdornerLayeredWindow";
					this.mUIAdornerLayeredWindowWindow.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AdornerLayeredWindow";
					this.mUIAdornerLayeredWindowWindow.WindowTitles.Add("DockingDemo (C# Demo)");
					#endregion
				}
				return this.mUIAdornerLayeredWindowWindow;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIAdornerLayeredWindowWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow : WinWindow
	{
		public UIItemWindow()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Desktop";
			this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
			#endregion
		}
		#region Properties
		public UIPanelContainer2Window UIPanelContainer2Window
		{
			get
			{
				if ((this.mUIPanelContainer2Window == null))
				{
					this.mUIPanelContainer2Window = new UIPanelContainer2Window(this);
				}
				return this.mUIPanelContainer2Window;
			}
		}
		public UIPopupMenuBarControlMenu UIPopupMenuBarControlMenu
		{
			get
			{
				if ((this.mUIPopupMenuBarControlMenu == null))
				{
					this.mUIPopupMenuBarControlMenu = new UIPopupMenuBarControlMenu(this);
				}
				return this.mUIPopupMenuBarControlMenu;
			}
		}
		public UIDocument2csWindow UIDocument2csWindow
		{
			get
			{
				if ((this.mUIDocument2csWindow == null))
				{
					this.mUIDocument2csWindow = new UIDocument2csWindow(this);
				}
				return this.mUIDocument2csWindow;
			}
		}
		public UIDockPanel6Window UIDockPanel6Window
		{
			get
			{
				if ((this.mUIDockPanel6Window == null))
				{
					this.mUIDockPanel6Window = new UIDockPanel6Window(this);
				}
				return this.mUIDockPanel6Window;
			}
		}
		public UIDocument0Window UIDocument0Window
		{
			get
			{
				if ((this.mUIDocument0Window == null))
				{
					this.mUIDocument0Window = new UIDocument0Window(this);
				}
				return this.mUIDocument0Window;
			}
		}
		public UIDocument3Window UIDocument3Window
		{
			get
			{
				if ((this.mUIDocument3Window == null))
				{
					this.mUIDocument3Window = new UIDocument3Window(this);
				}
				return this.mUIDocument3Window;
			}
		}
		public UIDocument4Window UIDocument4Window
		{
			get
			{
				if ((this.mUIDocument4Window == null))
				{
					this.mUIDocument4Window = new UIDocument4Window(this);
				}
				return this.mUIDocument4Window;
			}
		}
		public UIRibbonMinimizedGroupCustom UIRibbonMinimizedGroupCustom
		{
			get
			{
				if ((this.mUIRibbonMinimizedGroupCustom == null))
				{
					this.mUIRibbonMinimizedGroupCustom = new UIRibbonMinimizedGroupCustom(this);
				}
				return this.mUIRibbonMinimizedGroupCustom;
			}
		}
		public UICloseAllDocumentsWindow UICloseAllDocumentsWindow
		{
			get
			{
				if ((this.mUICloseAllDocumentsWindow == null))
				{
					this.mUICloseAllDocumentsWindow = new UICloseAllDocumentsWindow(this);
				}
				return this.mUICloseAllDocumentsWindow;
			}
		}
		public UICloseDocumentWindow UICloseDocumentWindow
		{
			get
			{
				if ((this.mUICloseDocumentWindow == null))
				{
					this.mUICloseDocumentWindow = new UICloseDocumentWindow(this);
				}
				return this.mUICloseDocumentWindow;
			}
		}
		#endregion
		#region Fields
		private UIPanelContainer2Window mUIPanelContainer2Window;
		private UIPopupMenuBarControlMenu mUIPopupMenuBarControlMenu;
		private UIDocument2csWindow mUIDocument2csWindow;
		private UIDockPanel6Window mUIDockPanel6Window;
		private UIDocument0Window mUIDocument0Window;
		private UIDocument3Window mUIDocument3Window;
		private UIDocument4Window mUIDocument4Window;
		private UIRibbonMinimizedGroupCustom mUIRibbonMinimizedGroupCustom;
		private UICloseAllDocumentsWindow mUICloseAllDocumentsWindow;
		private UICloseDocumentWindow mUICloseDocumentWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelContainer2Window : DXWindow
	{
		public UIPanelContainer2Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			#endregion
		}
		#region Properties
		public UIPanelContainer2Client1 UIPanelContainer2Client
		{
			get
			{
				if ((this.mUIPanelContainer2Client == null))
				{
					this.mUIPanelContainer2Client = new UIPanelContainer2Client1(this);
				}
				return this.mUIPanelContainer2Client;
			}
		}
		#endregion
		#region Fields
		private UIPanelContainer2Client1 mUIPanelContainer2Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelContainer2Client1 : DXTestControl
	{
		public UIPanelContainer2Client1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			#endregion
		}
		#region Properties
		public DXButton UIMaximizeButtonButton
		{
			get
			{
				if ((this.mUIMaximizeButtonButton == null))
				{
					this.mUIMaximizeButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUIMaximizeButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "MaximizeButton";
					this.mUIMaximizeButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelButton";
					#endregion
				}
				return this.mUIMaximizeButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIMaximizeButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupMenuBarControlMenu : DXMenu
	{
		public UIPopupMenuBarControlMenu(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "PopupMenuBarControl";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupMenuBarControl";
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UIAutoHideMenuBaseButtonItem
		{
			get
			{
				if ((this.mUIAutoHideMenuBaseButtonItem == null))
				{
					this.mUIAutoHideMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIAutoHideMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Auto Hide";
					this.mUIAutoHideMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIAutoHideMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIDockMenuBaseButtonItem
		{
			get
			{
				if ((this.mUIDockMenuBaseButtonItem == null))
				{
					this.mUIDockMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIDockMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Dock";
					this.mUIDockMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIDockMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIFloatMenuBaseButtonItem
		{
			get
			{
				if ((this.mUIFloatMenuBaseButtonItem == null))
				{
					this.mUIFloatMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIFloatMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Float";
					this.mUIFloatMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIFloatMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UICloseMenuBaseButtonItem
		{
			get
			{
				if ((this.mUICloseMenuBaseButtonItem == null))
				{
					this.mUICloseMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUICloseMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUICloseMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIDockasTabbedDocumentMenuBaseButtonItem
		{
			get
			{
				if ((this.mUIDockasTabbedDocumentMenuBaseButtonItem == null))
				{
					this.mUIDockasTabbedDocumentMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIDockasTabbedDocumentMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Dock as Tabbed Document";
					this.mUIDockasTabbedDocumentMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIDockasTabbedDocumentMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIDocument0csMenuBaseButtonItem
		{
			get
			{
				if ((this.mUIDocument0csMenuBaseButtonItem == null))
				{
					this.mUIDocument0csMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIDocument0csMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0.cs";
					this.mUIDocument0csMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIDocument0csMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UICloseAllDocumentsMenuBaseButtonItem
		{
			get
			{
				if ((this.mUICloseAllDocumentsMenuBaseButtonItem == null))
				{
					this.mUICloseAllDocumentsMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUICloseAllDocumentsMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Close All Documents";
					this.mUICloseAllDocumentsMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUICloseAllDocumentsMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIWindowsMenuBaseButtonItem
		{
			get
			{
				if ((this.mUIWindowsMenuBaseButtonItem == null))
				{
					this.mUIWindowsMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIWindowsMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Windows...";
					this.mUIWindowsMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIWindowsMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UICustomizeMenuBaseButtonItem
		{
			get
			{
				if ((this.mUICustomizeMenuBaseButtonItem == null))
				{
					this.mUICustomizeMenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUICustomizeMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "&Customize ...";
					this.mUICustomizeMenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUICustomizeMenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIBarButtonItemLink2MenuBaseButtonItem
		{
			get
			{
				if ((this.mUIBarButtonItemLink2MenuBaseButtonItem == null))
				{
					this.mUIBarButtonItemLink2MenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIBarButtonItemLink2MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "BarButtonItemLink[2]";
					this.mUIBarButtonItemLink2MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIBarButtonItemLink2MenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIBarButtonItemLink0MenuBaseButtonItem
		{
			get
			{
				if ((this.mUIBarButtonItemLink0MenuBaseButtonItem == null))
				{
					this.mUIBarButtonItemLink0MenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIBarButtonItemLink0MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "BarButtonItemLink[1]";
					this.mUIBarButtonItemLink0MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIBarButtonItemLink0MenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIBarButtonItemLink1MenuBaseButtonItem
		{
			get
			{
				if ((this.mUIBarButtonItemLink1MenuBaseButtonItem == null))
				{
					this.mUIBarButtonItemLink1MenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIBarButtonItemLink1MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "BarButtonItemLink[2]";
					this.mUIBarButtonItemLink1MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIBarButtonItemLink1MenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIBarButtonItemLink3MenuBaseButtonItem
		{
			get
			{
				if ((this.mUIBarButtonItemLink3MenuBaseButtonItem == null))
				{
					this.mUIBarButtonItemLink3MenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIBarButtonItemLink3MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "BarButtonItemLink[3]";
					this.mUIBarButtonItemLink3MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIBarButtonItemLink3MenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIBarButtonItemLink0MenuBaseButtonItem1
		{
			get
			{
				if ((this.mUIBarButtonItemLink0MenuBaseButtonItem1 == null))
				{
					this.mUIBarButtonItemLink0MenuBaseButtonItem1 = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIBarButtonItemLink0MenuBaseButtonItem1.SearchProperties[DXTestControl.PropertyNames.Name] = "BarButtonItemLink[0]";
					this.mUIBarButtonItemLink0MenuBaseButtonItem1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					#endregion
				}
				return this.mUIBarButtonItemLink0MenuBaseButtonItem1;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUIAutoHideMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIDockMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIFloatMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUICloseMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIDockasTabbedDocumentMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIDocument0csMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUICloseAllDocumentsMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIWindowsMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUICustomizeMenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIBarButtonItemLink2MenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIBarButtonItemLink0MenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIBarButtonItemLink1MenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIBarButtonItemLink3MenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIBarButtonItemLink0MenuBaseButtonItem1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument2csWindow : DXWindow
	{
		public UIDocument2csWindow(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2.cs";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatDocumentForm";
			#endregion
		}
		#region Properties
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		public DXButton UIMaximizeButton
		{
			get
			{
				if ((this.mUIMaximizeButton == null))
				{
					this.mUIMaximizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Maximize";
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUIMaximizeButton;
			}
		}
		public DXButton UIRestoreButton
		{
			get
			{
				if ((this.mUIRestoreButton == null))
				{
					this.mUIRestoreButton = new DXButton(this);
					#region Search Criteria
					this.mUIRestoreButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Restore";
					this.mUIRestoreButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUIRestoreButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseButton;
		private DXButton mUIMaximizeButton;
		private DXButton mUIRestoreButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel6Window : DXWindow
	{
		public UIDockPanel6Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel6";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			#endregion
		}
		#region Properties
		public DXDockPanel UIDockPanel6DockPanel
		{
			get
			{
				if ((this.mUIDockPanel6DockPanel == null))
				{
					this.mUIDockPanel6DockPanel = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanel6DockPanel.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel6";
					this.mUIDockPanel6DockPanel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					#endregion
				}
				return this.mUIDockPanel6DockPanel;
			}
		}
		#endregion
		#region Fields
		private DXDockPanel mUIDockPanel6DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument0Window : DXWindow
	{
		public UIDocument0Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatDocumentForm";
			#endregion
		}
		#region Properties
		public DXTestControl UIDocument0WindowTitleBar
		{
			get
			{
				if ((this.mUIDocument0WindowTitleBar == null))
				{
					this.mUIDocument0WindowTitleBar = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument0WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.Name] = "WindowTitleBar";
					this.mUIDocument0WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					#endregion
				}
				return this.mUIDocument0WindowTitleBar;
			}
		}
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		public DXButton UIMaximizeButton
		{
			get
			{
				if ((this.mUIMaximizeButton == null))
				{
					this.mUIMaximizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Maximize";
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUIMaximizeButton;
			}
		}
		public DXButton UIRestoreButton
		{
			get
			{
				if ((this.mUIRestoreButton == null))
				{
					this.mUIRestoreButton = new DXButton(this);
					#region Search Criteria
					this.mUIRestoreButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Restore";
					this.mUIRestoreButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUIRestoreButton;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDocument0WindowTitleBar;
		private DXButton mUICloseButton;
		private DXButton mUIMaximizeButton;
		private DXButton mUIRestoreButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument3Window : DXWindow
	{
		public UIDocument3Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatDocumentForm";
			#endregion
		}
		#region Properties
		public DXTestControl UIDocument3WindowTitleBar
		{
			get
			{
				if ((this.mUIDocument3WindowTitleBar == null))
				{
					this.mUIDocument3WindowTitleBar = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument3WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.Name] = "WindowTitleBar";
					this.mUIDocument3WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					#endregion
				}
				return this.mUIDocument3WindowTitleBar;
			}
		}
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDocument3WindowTitleBar;
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument4Window : DXWindow
	{
		public UIDocument4Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatDocumentForm";
			#endregion
		}
		#region Properties
		public DXTestControl UIDocument4WindowTitleBar
		{
			get
			{
				if ((this.mUIDocument4WindowTitleBar == null))
				{
					this.mUIDocument4WindowTitleBar = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument4WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.Name] = "WindowTitleBar";
					this.mUIDocument4WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					#endregion
				}
				return this.mUIDocument4WindowTitleBar;
			}
		}
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDocument4WindowTitleBar;
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonMinimizedGroupCustom : DXTestControl
	{
		public UIRibbonMinimizedGroupCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupForm";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonMinimizedGroupPopupForm";
			#endregion
		}
		#region Properties
		public UIRibbonOneGroupControRibbon UIRibbonOneGroupControRibbon
		{
			get
			{
				if ((this.mUIRibbonOneGroupControRibbon == null))
				{
					this.mUIRibbonOneGroupControRibbon = new UIRibbonOneGroupControRibbon(this);
				}
				return this.mUIRibbonOneGroupControRibbon;
			}
		}
		#endregion
		#region Fields
		private UIRibbonOneGroupControRibbon mUIRibbonOneGroupControRibbon;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonOneGroupControRibbon : DXRibbon
	{
		public UIRibbonOneGroupControRibbon(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonOneGroupControl";
			#endregion
		}
		#region Properties
		public UIRibbonPage0RibbonPage UIRibbonPage0RibbonPage
		{
			get
			{
				if ((this.mUIRibbonPage0RibbonPage == null))
				{
					this.mUIRibbonPage0RibbonPage = new UIRibbonPage0RibbonPage(this);
				}
				return this.mUIRibbonPage0RibbonPage;
			}
		}
		public UIImageComboBoxEditComboBox UIImageComboBoxEditComboBox
		{
			get
			{
				if ((this.mUIImageComboBoxEditComboBox == null))
				{
					this.mUIImageComboBoxEditComboBox = new UIImageComboBoxEditComboBox(this);
				}
				return this.mUIImageComboBoxEditComboBox;
			}
		}
		#endregion
		#region Fields
		private UIRibbonPage0RibbonPage mUIRibbonPage0RibbonPage;
		private UIImageComboBoxEditComboBox mUIImageComboBoxEditComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPage0RibbonPage : DXRibbonPage
	{
		public UIRibbonPage0RibbonPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "RibbonPage0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPage";
			#endregion
		}
		#region Properties
		public UIRibbonPageGroup3RibbonPageGroup UIRibbonPageGroup3RibbonPageGroup
		{
			get
			{
				if ((this.mUIRibbonPageGroup3RibbonPageGroup == null))
				{
					this.mUIRibbonPageGroup3RibbonPageGroup = new UIRibbonPageGroup3RibbonPageGroup(this);
				}
				return this.mUIRibbonPageGroup3RibbonPageGroup;
			}
		}
		#endregion
		#region Fields
		private UIRibbonPageGroup3RibbonPageGroup mUIRibbonPageGroup3RibbonPageGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPageGroup3RibbonPageGroup : DXRibbonPageGroup
	{
		public UIRibbonPageGroup3RibbonPageGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPageGroup3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPageGroup";
			#endregion
		}
		#region Properties
		public DXRibbonEditItem UIShowCloseButtonRibbonEditItem
		{
			get
			{
				if ((this.mUIShowCloseButtonRibbonEditItem == null))
				{
					this.mUIShowCloseButtonRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUIShowCloseButtonRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiClosePageButton";
					this.mUIShowCloseButtonRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					#endregion
				}
				return this.mUIShowCloseButtonRibbonEditItem;
			}
		}
		public DXButton UIRibbonPageGroup3Button
		{
			get
			{
				if ((this.mUIRibbonPageGroup3Button == null))
				{
					this.mUIRibbonPageGroup3Button = new DXButton(this);
					#region Search Criteria
					this.mUIRibbonPageGroup3Button.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPageGroup3";
					this.mUIRibbonPageGroup3Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonGroupCaptionButton";
					#endregion
				}
				return this.mUIRibbonPageGroup3Button;
			}
		}
		public DXRibbonEditItem UILocationRibbonEditItem
		{
			get
			{
				if ((this.mUILocationRibbonEditItem == null))
				{
					this.mUILocationRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUILocationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiHeadeLocation";
					this.mUILocationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					#endregion
				}
				return this.mUILocationRibbonEditItem;
			}
		}
		public DXRibbonEditItem UIOrientationRibbonEditItem
		{
			get
			{
				if ((this.mUIOrientationRibbonEditItem == null))
				{
					this.mUIOrientationRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUIOrientationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiHeaderOrientation";
					this.mUIOrientationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					#endregion
				}
				return this.mUIOrientationRibbonEditItem;
			}
		}
		#endregion
		#region Fields
		private DXRibbonEditItem mUIShowCloseButtonRibbonEditItem;
		private DXButton mUIRibbonPageGroup3Button;
		private DXRibbonEditItem mUILocationRibbonEditItem;
		private DXRibbonEditItem mUIOrientationRibbonEditItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIImageComboBoxEditComboBox : DXComboBox
	{
		public UIImageComboBoxEditComboBox(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]ImageComboBoxEdit[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
			#endregion
		}
		#region Properties
		public UIPopupImageComboBoxEdWindow UIPopupImageComboBoxEdWindow
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdWindow == null))
				{
					this.mUIPopupImageComboBoxEdWindow = new UIPopupImageComboBoxEdWindow(this);
				}
				return this.mUIPopupImageComboBoxEdWindow;
			}
		}
		#endregion
		#region Fields
		private UIPopupImageComboBoxEdWindow mUIPopupImageComboBoxEdWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupImageComboBoxEdWindow : DXWindow
	{
		public UIPopupImageComboBoxEdWindow(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]ImageComboBoxEdit[0]P" +
				"opupForm";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxForm";
			#endregion
		}
		#region Properties
		public UIPopupImageComboBoxEdList UIPopupImageComboBoxEdList
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdList == null))
				{
					this.mUIPopupImageComboBoxEdList = new UIPopupImageComboBoxEdList(this);
				}
				return this.mUIPopupImageComboBoxEdList;
			}
		}
		#endregion
		#region Fields
		private UIPopupImageComboBoxEdList mUIPopupImageComboBoxEdList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupImageComboBoxEdList : DXListBox
	{
		public UIPopupImageComboBoxEdList(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]ImageComboBoxEdit[0]P" +
				"opupFormPopupImageComboBoxEditListBox[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBox";
			#endregion
		}
		#region Properties
		public DXListBoxItem UIPopupImageComboBoxEdListItem
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdListItem == null))
				{
					this.mUIPopupImageComboBoxEdListItem = new DXListBoxItem(this);
					#region Search Criteria
					this.mUIPopupImageComboBoxEdListItem.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]ImageComboBoxEdit[0]P" +
						"opupFormPopupImageComboBoxEditListBox[0]Item[1]";
					this.mUIPopupImageComboBoxEdListItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					#endregion
				}
				return this.mUIPopupImageComboBoxEdListItem;
			}
		}
		public DXListBoxItem UIPopupImageComboBoxEdListItem1
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdListItem1 == null))
				{
					this.mUIPopupImageComboBoxEdListItem1 = new DXListBoxItem(this);
					#region Search Criteria
					this.mUIPopupImageComboBoxEdListItem1.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]ImageComboBoxEdit[0]P" +
						"opupFormPopupImageComboBoxEditListBox[0]Item[3]";
					this.mUIPopupImageComboBoxEdListItem1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					#endregion
				}
				return this.mUIPopupImageComboBoxEdListItem1;
			}
		}
		public DXListBoxItem UIPopupImageComboBoxEdListItem2
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdListItem2 == null))
				{
					this.mUIPopupImageComboBoxEdListItem2 = new DXListBoxItem(this);
					#region Search Criteria
					this.mUIPopupImageComboBoxEdListItem2.SearchProperties[DXTestControl.PropertyNames.Name] = "UnknownRibbonMinimizedGroupPopupFormRibbonOneGroupControl[0]ImageComboBoxEdit[0]P" +
						"opupFormPopupImageComboBoxEditListBox[0]Item[2]";
					this.mUIPopupImageComboBoxEdListItem2.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					#endregion
				}
				return this.mUIPopupImageComboBoxEdListItem2;
			}
		}
		#endregion
		#region Fields
		private DXListBoxItem mUIPopupImageComboBoxEdListItem;
		private DXListBoxItem mUIPopupImageComboBoxEdListItem1;
		private DXListBoxItem mUIPopupImageComboBoxEdListItem2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UICloseAllDocumentsWindow : DXWindow
	{
		public UICloseAllDocumentsWindow(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Close All Documents";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraMessageBoxForm";
			#endregion
		}
		#region Properties
		public DXButton UISimpleButtonButton
		{
			get
			{
				if ((this.mUISimpleButtonButton == null))
				{
					this.mUISimpleButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close All DocumentsSimpleButton[0]";
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					#endregion
				}
				return this.mUISimpleButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISimpleButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UICloseDocumentWindow : DXWindow
	{
		public UICloseDocumentWindow(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Close Document";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraMessageBoxForm";
			#endregion
		}
		#region Properties
		public DXButton UISimpleButtonButton
		{
			get
			{
				if ((this.mUISimpleButtonButton == null))
				{
					this.mUISimpleButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close DocumentSimpleButton[0]";
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					#endregion
				}
				return this.mUISimpleButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISimpleButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIApplicationUIWindow : DXWindow
	{
		public UIApplicationUIWindow()
		{
			#region Search Criteria
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.Name, "Application UI Layout Controls Demo (C# code)", PropertyExpressionOperator.Contains));
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
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
		public UIPcMainClient UIPcMainClient
		{
			get
			{
				if ((this.mUIPcMainClient == null))
				{
					this.mUIPcMainClient = new UIPcMainClient(this);
				}
				return this.mUIPcMainClient;
			}
		}
		#endregion
		#region Fields
		private UIGcNavigationsClient mUIGcNavigationsClient;
		private UIPcMainClient mUIPcMainClient;
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXListBox UIListBoxControl1List
		{
			get
			{
				if ((this.mUIListBoxControl1List == null))
				{
					this.mUIListBoxControl1List = new DXListBox(this);
					#region Search Criteria
					this.mUIListBoxControl1List.SearchProperties[DXTestControl.PropertyNames.Name] = "listBoxControl1";
					this.mUIListBoxControl1List.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ListBoxControl";
					this.mUIListBoxControl1List.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIListBoxControl1List;
			}
		}
		public UIAccordionControl1AccordionControl UIAccordionControl1AccordionControl
		{
			get
			{
				if ((this.mUIAccordionControl1AccordionControl == null))
				{
					this.mUIAccordionControl1AccordionControl = new UIAccordionControl1AccordionControl(this);
				}
				return this.mUIAccordionControl1AccordionControl;
			}
		}
		#endregion
		#region Fields
		private DXListBox mUIListBoxControl1List;
		private UIAccordionControl1AccordionControl mUIAccordionControl1AccordionControl;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIAccordionControl1AccordionControl : DXTestControl
	{
		public UIAccordionControl1AccordionControl(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "accordionControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UIDockingUIAccordionControlGroup UIDockingUIAccordionControlGroup
		{
			get
			{
				if ((this.mUIDockingUIAccordionControlGroup == null))
				{
					this.mUIDockingUIAccordionControlGroup = new UIDockingUIAccordionControlGroup(this);
				}
				return this.mUIDockingUIAccordionControlGroup;
			}
		}
		#endregion
		#region Fields
		private UIDockingUIAccordionControlGroup mUIDockingUIAccordionControlGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockingUIAccordionControlGroup : DXTestControl
	{
		public UIDockingUIAccordionControlGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Docking UI";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanelsAccordionControlItem
		{
			get
			{
				if ((this.mUIDockPanelsAccordionControlItem == null))
				{
					this.mUIDockPanelsAccordionControlItem = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanelsAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Dock Panels";
					this.mUIDockPanelsAccordionControlItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "AccordionControlItem";
					this.mUIDockPanelsAccordionControlItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelsAccordionControlItem;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanelsAccordionControlItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPcMainClient : DXTestControl
	{
		public UIPcMainClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UIDockPanelsCustom UIDockPanelsCustom
		{
			get
			{
				if ((this.mUIDockPanelsCustom == null))
				{
					this.mUIDockPanelsCustom = new UIDockPanelsCustom(this);
				}
				return this.mUIDockPanelsCustom;
			}
		}
		public UISampleStartCustom UISampleStartCustom
		{
			get
			{
				if ((this.mUISampleStartCustom == null))
				{
					this.mUISampleStartCustom = new UISampleStartCustom(this);
				}
				return this.mUISampleStartCustom;
			}
		}
		public UISampleStartCustom1 UISampleStartCustom1
		{
			get
			{
				if ((this.mUISampleStartCustom1 == null))
				{
					this.mUISampleStartCustom1 = new UISampleStartCustom1(this);
				}
				return this.mUISampleStartCustom1;
			}
		}
		#endregion
		#region Fields
		private UIDockPanelsCustom mUIDockPanelsCustom;
		private UISampleStartCustom mUISampleStartCustom;
		private UISampleStartCustom1 mUISampleStartCustom1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanelsCustom : DXTestControl
	{
		public UIDockPanelsCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanels";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanels";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UIPnlLeftClient UIPnlLeftClient
		{
			get
			{
				if ((this.mUIPnlLeftClient == null))
				{
					this.mUIPnlLeftClient = new UIPnlLeftClient(this);
				}
				return this.mUIPnlLeftClient;
			}
		}
		public UIPnlContainerClient UIPnlContainerClient
		{
			get
			{
				if ((this.mUIPnlContainerClient == null))
				{
					this.mUIPnlContainerClient = new UIPnlContainerClient(this);
				}
				return this.mUIPnlContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIPnlLeftClient mUIPnlLeftClient;
		private UIPnlContainerClient mUIPnlContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPnlLeftClient : DXTestControl
	{
		public UIPnlLeftClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlLeft";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UIPnlControlsClient UIPnlControlsClient
		{
			get
			{
				if ((this.mUIPnlControlsClient == null))
				{
					this.mUIPnlControlsClient = new UIPnlControlsClient(this);
				}
				return this.mUIPnlControlsClient;
			}
		}
		#endregion
		#region Fields
		private UIPnlControlsClient mUIPnlControlsClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPnlControlsClient : DXTestControl
	{
		public UIPnlControlsClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlControls";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXButton UISbAddPanelButton
		{
			get
			{
				if ((this.mUISbAddPanelButton == null))
				{
					this.mUISbAddPanelButton = new DXButton(this);
					#region Search Criteria
					this.mUISbAddPanelButton.SearchProperties[DXTestControl.PropertyNames.Name] = "sbAddPanel";
					this.mUISbAddPanelButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUISbAddPanelButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUISbAddPanelButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISbAddPanelButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPnlContainerClient : DXTestControl
	{
		public UIPnlContainerClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UISimpleDockPanelCustom UISimpleDockPanelCustom
		{
			get
			{
				if ((this.mUISimpleDockPanelCustom == null))
				{
					this.mUISimpleDockPanelCustom = new UISimpleDockPanelCustom(this);
				}
				return this.mUISimpleDockPanelCustom;
			}
		}
		#endregion
		#region Fields
		private UISimpleDockPanelCustom mUISimpleDockPanelCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UISimpleDockPanelCustom : DXTestControl
	{
		public UISimpleDockPanelCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanel";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleDockPanel";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UIDockPanelClient2 UIDockPanelClient
		{
			get
			{
				if ((this.mUIDockPanelClient == null))
				{
					this.mUIDockPanelClient = new UIDockPanelClient2(this);
				}
				return this.mUIDockPanelClient;
			}
		}
		public DXTestControl UIDockPanelClient1
		{
			get
			{
				if ((this.mUIDockPanelClient1 == null))
				{
					this.mUIDockPanelClient1 = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanelClient1.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[2]";
					this.mUIDockPanelClient1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelClient1.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelClient1;
			}
		}
		public DXTestControl UIDockPanel1Client
		{
			get
			{
				if ((this.mUIDockPanel1Client == null))
				{
					this.mUIDockPanel1Client = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanel1Client.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
					this.mUIDockPanel1Client.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanel1Client.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanel1Client;
			}
		}
		public UIDockPanelClient21 UIDockPanelClient2
		{
			get
			{
				if ((this.mUIDockPanelClient2 == null))
				{
					this.mUIDockPanelClient2 = new UIDockPanelClient21(this);
				}
				return this.mUIDockPanelClient2;
			}
		}
		#endregion
		#region Fields
		private UIDockPanelClient2 mUIDockPanelClient;
		private DXTestControl mUIDockPanelClient1;
		private DXTestControl mUIDockPanel1Client;
		private UIDockPanelClient21 mUIDockPanelClient2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanelClient2 : DXTestControl
	{
		public UIDockPanelClient2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[1]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public UIDockPanelClient1 UIDockPanelClient1
		{
			get
			{
				if ((this.mUIDockPanelClient1 == null))
				{
					this.mUIDockPanelClient1 = new UIDockPanelClient1(this);
				}
				return this.mUIDockPanelClient1;
			}
		}
		public DXButton UIDockPanelButton
		{
			get
			{
				if ((this.mUIDockPanelButton == null))
				{
					this.mUIDockPanelButton = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanelButton.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanel";
					this.mUIDockPanelButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIDockPanelButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelButton;
			}
		}
		public DXButton UIDockPanel1Button
		{
			get
			{
				if ((this.mUIDockPanel1Button == null))
				{
					this.mUIDockPanel1Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel1Button.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanel[1]";
					this.mUIDockPanel1Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIDockPanel1Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanel1Button;
			}
		}
		public DXDockPanel UIDockPanelDockPanel1
		{
			get
			{
				if ((this.mUIDockPanelDockPanel1 == null))
				{
					this.mUIDockPanelDockPanel1 = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanelDockPanel1.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[1]DockPanel[1]";
					this.mUIDockPanelDockPanel1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelDockPanel1.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelDockPanel1;
			}
		}
		#endregion
		#region Fields
		private UIDockPanelClient1 mUIDockPanelClient1;
		private DXButton mUIDockPanelButton;
		private DXButton mUIDockPanel1Button;
		private DXDockPanel mUIDockPanelDockPanel1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanelClient1 : DXTestControl
	{
		public UIDockPanelClient1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[1]DockPanel[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIControlContainerCustom
		{
			get
			{
				if ((this.mUIControlContainerCustom == null))
				{
					this.mUIControlContainerCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUIControlContainerCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[1]DockPanel[0]ControlContainer[0]";
					this.mUIControlContainerCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
					this.mUIControlContainerCustom.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIControlContainerCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIControlContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanelClient21 : DXTestControl
	{
		public UIDockPanelClient21(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanelClient1
		{
			get
			{
				if ((this.mUIDockPanelClient1 == null))
				{
					this.mUIDockPanelClient1 = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanelClient1.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[0]DockPanel[0]";
					this.mUIDockPanelClient1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelClient1.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelClient1;
			}
		}
		public DXTestControl UIDockPanelClient11
		{
			get
			{
				if ((this.mUIDockPanelClient11 == null))
				{
					this.mUIDockPanelClient11 = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanelClient11.SearchProperties[DXTestControl.PropertyNames.Name] = "SimpleDockPanelDockPanel[0]DockPanel[1]";
					this.mUIDockPanelClient11.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelClient11.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelClient11;
			}
		}
		public DXButton UIDockPanelButton
		{
			get
			{
				if ((this.mUIDockPanelButton == null))
				{
					this.mUIDockPanelButton = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanelButton.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanel";
					this.mUIDockPanelButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIDockPanelButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanelButton;
			}
		}
		public DXButton UIDockPanel1Button
		{
			get
			{
				if ((this.mUIDockPanel1Button == null))
				{
					this.mUIDockPanel1Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel1Button.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanel[1]";
					this.mUIDockPanel1Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIDockPanel1Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanel1Button;
			}
		}
		public DXButton UIDockPanel2Button
		{
			get
			{
				if ((this.mUIDockPanel2Button == null))
				{
					this.mUIDockPanel2Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel2Button.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanel[2]";
					this.mUIDockPanel2Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIDockPanel2Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanel2Button;
			}
		}
		public DXButton UIDockPanel3Button
		{
			get
			{
				if ((this.mUIDockPanel3Button == null))
				{
					this.mUIDockPanel3Button = new DXButton(this);
					#region Search Criteria
					this.mUIDockPanel3Button.SearchProperties[DXTestControl.PropertyNames.Name] = "DockPanel[3]";
					this.mUIDockPanel3Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanelTabButton";
					this.mUIDockPanel3Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUIDockPanel3Button;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanelClient1;
		private DXTestControl mUIDockPanelClient11;
		private DXButton mUIDockPanelButton;
		private DXButton mUIDockPanel1Button;
		private DXButton mUIDockPanel2Button;
		private DXButton mUIDockPanel3Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UISampleStartCustom : DXTestControl
	{
		public UISampleStartCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SampleStart";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "DocumentManager", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXButton UISbStartButton
		{
			get
			{
				if ((this.mUISbStartButton == null))
				{
					this.mUISbStartButton = new DXButton(this);
					#region Search Criteria
					this.mUISbStartButton.SearchProperties[DXTestControl.PropertyNames.Name] = "sbStart";
					this.mUISbStartButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUISbStartButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUISbStartButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISbStartButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UISampleStartCustom1 : DXTestControl
	{
		public UISampleStartCustom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "SampleStart";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TabbedMDIStart";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
			#endregion
		}
		#region Properties
		public DXButton UILaunchSampleButton
		{
			get
			{
				if ((this.mUILaunchSampleButton == null))
				{
					this.mUILaunchSampleButton = new DXButton(this);
					#region Search Criteria
					this.mUILaunchSampleButton.SearchProperties[DXTestControl.PropertyNames.Name] = "sbStart";
					this.mUILaunchSampleButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUILaunchSampleButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code)");
					#endregion
				}
				return this.mUILaunchSampleButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUILaunchSampleButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerDockiWindow : DXWindow
	{
		public UIDocumentManagerDockiWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document Manager (Docking Integration)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public UIMdiClientTabList1 UIMdiClientTabList
		{
			get
			{
				if ((this.mUIMdiClientTabList == null))
				{
					this.mUIMdiClientTabList = new UIMdiClientTabList1(this);
				}
				return this.mUIMdiClientTabList;
			}
		}
		public DXDockPanel UIDockPanelDockPanel
		{
			get
			{
				if ((this.mUIDockPanelDockPanel == null))
				{
					this.mUIDockPanelDockPanel = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanelDockPanel.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
					this.mUIDockPanelDockPanel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelDockPanel.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDockPanelDockPanel;
			}
		}
		public UIDockPanelDockPanel2 UIDockPanelDockPanel2
		{
			get
			{
				if ((this.mUIDockPanelDockPanel2 == null))
				{
					this.mUIDockPanelDockPanel2 = new UIDockPanelDockPanel2(this);
				}
				return this.mUIDockPanelDockPanel2;
			}
		}
		#endregion
		#region Fields
		private UIMdiClientTabList1 mUIMdiClientTabList;
		private DXDockPanel mUIDockPanelDockPanel;
		private UIDockPanelDockPanel2 mUIDockPanelDockPanel2;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMdiClientTabList1 : DXTestControl
	{
		public UIMdiClientTabList1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MdiClient[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClient";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public UIItem0Group UIItem0Group
		{
			get
			{
				if ((this.mUIItem0Group == null))
				{
					this.mUIItem0Group = new UIItem0Group(this);
				}
				return this.mUIItem0Group;
			}
		}
		public DXTestControl UIDocument0csTabPage
		{
			get
			{
				if ((this.mUIDocument0csTabPage == null))
				{
					this.mUIDocument0csTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument0csTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0.cs";
					this.mUIDocument0csTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument0csTabPage.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDocument0csTabPage;
			}
		}
		public UIDocument2csTabPage UIDocument2csTabPage
		{
			get
			{
				if ((this.mUIDocument2csTabPage == null))
				{
					this.mUIDocument2csTabPage = new UIDocument2csTabPage(this);
				}
				return this.mUIDocument2csTabPage;
			}
		}
		public DXTestControl UIDocument1csTabPage
		{
			get
			{
				if ((this.mUIDocument1csTabPage == null))
				{
					this.mUIDocument1csTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument1csTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1.cs";
					this.mUIDocument1csTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument1csTabPage.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDocument1csTabPage;
			}
		}
		public UIDockPanel3Window1 UIDockPanel3Window
		{
			get
			{
				if ((this.mUIDockPanel3Window == null))
				{
					this.mUIDockPanel3Window = new UIDockPanel3Window1(this);
				}
				return this.mUIDockPanel3Window;
			}
		}
		public UIDockPanel2Window UIDockPanel2Window
		{
			get
			{
				if ((this.mUIDockPanel2Window == null))
				{
					this.mUIDockPanel2Window = new UIDockPanel2Window(this);
				}
				return this.mUIDockPanel2Window;
			}
		}
		public UIDockPanel1Window1 UIDockPanel1Window
		{
			get
			{
				if ((this.mUIDockPanel1Window == null))
				{
					this.mUIDockPanel1Window = new UIDockPanel1Window1(this);
				}
				return this.mUIDockPanel1Window;
			}
		}
		public DXTestControl UIBottomLeftPanelTabPage
		{
			get
			{
				if ((this.mUIBottomLeftPanelTabPage == null))
				{
					this.mUIBottomLeftPanelTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIBottomLeftPanelTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "BottomLeft Panel";
					this.mUIBottomLeftPanelTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIBottomLeftPanelTabPage.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIBottomLeftPanelTabPage;
			}
		}
		#endregion
		#region Fields
		private UIItem0Group mUIItem0Group;
		private DXTestControl mUIDocument0csTabPage;
		private UIDocument2csTabPage mUIDocument2csTabPage;
		private DXTestControl mUIDocument1csTabPage;
		private UIDockPanel3Window1 mUIDockPanel3Window;
		private UIDockPanel2Window mUIDockPanel2Window;
		private UIDockPanel1Window1 mUIDockPanel1Window;
		private DXTestControl mUIBottomLeftPanelTabPage;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItem0Group : DXTestControl
	{
		public UIItem0Group(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentGroup";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public DXButton UIPrevButton
		{
			get
			{
				if ((this.mUIPrevButton == null))
				{
					this.mUIPrevButton = new DXButton(this);
					#region Search Criteria
					this.mUIPrevButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Prev";
					this.mUIPrevButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabPrevButton";
					this.mUIPrevButton.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIPrevButton;
			}
		}
		public DXButton UIDropDownButton
		{
			get
			{
				if ((this.mUIDropDownButton == null))
				{
					this.mUIDropDownButton = new DXButton(this);
					#region Search Criteria
					this.mUIDropDownButton.SearchProperties[DXTestControl.PropertyNames.Name] = "DropDown";
					this.mUIDropDownButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabDropDownButton";
					this.mUIDropDownButton.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDropDownButton;
			}
		}
		public DXButton UINextButton
		{
			get
			{
				if ((this.mUINextButton == null))
				{
					this.mUINextButton = new DXButton(this);
					#region Search Criteria
					this.mUINextButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Next";
					this.mUINextButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabNextButton";
					this.mUINextButton.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUINextButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIPrevButton;
		private DXButton mUIDropDownButton;
		private DXButton mUINextButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument2csTabPage : DXTestControl
	{
		public UIDocument2csTabPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2.cs";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public DXButton UIDocument2csButton
		{
			get
			{
				if ((this.mUIDocument2csButton == null))
				{
					this.mUIDocument2csButton = new DXButton(this);
					#region Search Criteria
					this.mUIDocument2csButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2.cs";
					this.mUIDocument2csButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument2csButton.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDocument2csButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument2csButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3Window1 : DXWindow
	{
		public UIDockPanel3Window1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public UIDockPanel3DockPanel2 UIDockPanel3DockPanel
		{
			get
			{
				if ((this.mUIDockPanel3DockPanel == null))
				{
					this.mUIDockPanel3DockPanel = new UIDockPanel3DockPanel2(this);
				}
				return this.mUIDockPanel3DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel3DockPanel2 mUIDockPanel3DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel3DockPanel2 : DXDockPanel
	{
		public UIDockPanel3DockPanel2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanel3_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel3_ContainerCustom == null))
				{
					this.mUIDockPanel3_ContainerCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanel3_ContainerCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3_Container";
					this.mUIDockPanel3_ContainerCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
					this.mUIDockPanel3_ContainerCustom.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDockPanel3_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanel3_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel2Window : DXWindow
	{
		public UIDockPanel2Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public UIDockPanel2DockPanel UIDockPanel2DockPanel
		{
			get
			{
				if ((this.mUIDockPanel2DockPanel == null))
				{
					this.mUIDockPanel2DockPanel = new UIDockPanel2DockPanel(this);
				}
				return this.mUIDockPanel2DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel2DockPanel mUIDockPanel2DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel2DockPanel : DXDockPanel
	{
		public UIDockPanel2DockPanel(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanel2_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel2_ContainerCustom == null))
				{
					this.mUIDockPanel2_ContainerCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanel2_ContainerCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2_Container";
					this.mUIDockPanel2_ContainerCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
					this.mUIDockPanel2_ContainerCustom.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDockPanel2_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanel2_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel1Window1 : DXWindow
	{
		public UIDockPanel1Window1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FloatForm";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public UIDockPanel1DockPanel1 UIDockPanel1DockPanel
		{
			get
			{
				if ((this.mUIDockPanel1DockPanel == null))
				{
					this.mUIDockPanel1DockPanel = new UIDockPanel1DockPanel1(this);
				}
				return this.mUIDockPanel1DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDockPanel1DockPanel1 mUIDockPanel1DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanel1DockPanel1 : DXDockPanel
	{
		public UIDockPanel1DockPanel1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public DXTestControl UIDockPanel1_ContainerCustom
		{
			get
			{
				if ((this.mUIDockPanel1_ContainerCustom == null))
				{
					this.mUIDockPanel1_ContainerCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUIDockPanel1_ContainerCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1_Container";
					this.mUIDockPanel1_ContainerCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ControlContainer";
					this.mUIDockPanel1_ContainerCustom.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDockPanel1_ContainerCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDockPanel1_ContainerCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDockPanelDockPanel2 : DXDockPanel
	{
		public UIDockPanelDockPanel2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Document Manager (Docking Integration)");
			#endregion
		}
		#region Properties
		public DXDockPanel UIDockPanelDockPanel1
		{
			get
			{
				if ((this.mUIDockPanelDockPanel1 == null))
				{
					this.mUIDockPanelDockPanel1 = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanelDockPanel1.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2";
					this.mUIDockPanelDockPanel1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelDockPanel1.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDockPanelDockPanel1;
			}
		}
		public DXDockPanel UIDockPanelDockPanel11
		{
			get
			{
				if ((this.mUIDockPanelDockPanel11 == null))
				{
					this.mUIDockPanelDockPanel11 = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanelDockPanel11.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
					this.mUIDockPanelDockPanel11.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanelDockPanel11.WindowTitles.Add("Document Manager (Docking Integration)");
					#endregion
				}
				return this.mUIDockPanelDockPanel11;
			}
		}
		#endregion
		#region Fields
		private DXDockPanel mUIDockPanelDockPanel1;
		private DXDockPanel mUIDockPanelDockPanel11;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIWindowsWindow : WinWindow
	{
		public UIWindowsWindow()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.Name] = "Windows";
			this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public UIPanelControl2Pane UIPanelControl2Pane
		{
			get
			{
				if ((this.mUIPanelControl2Pane == null))
				{
					this.mUIPanelControl2Pane = new UIPanelControl2Pane(this);
				}
				return this.mUIPanelControl2Pane;
			}
		}
		public UIPanelControl2Client UIPanelControl2Client
		{
			get
			{
				if ((this.mUIPanelControl2Client == null))
				{
					this.mUIPanelControl2Client = new UIPanelControl2Client(this);
				}
				return this.mUIPanelControl2Client;
			}
		}
		public UIPnlListClient UIPnlListClient
		{
			get
			{
				if ((this.mUIPnlListClient == null))
				{
					this.mUIPnlListClient = new UIPnlListClient(this);
				}
				return this.mUIPnlListClient;
			}
		}
		#endregion
		#region Fields
		private UIPanelControl2Pane mUIPanelControl2Pane;
		private UIPanelControl2Client mUIPanelControl2Client;
		private UIPnlListClient mUIPnlListClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControl2Pane : WinPane
	{
		public UIPanelControl2Pane(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[WinControl.PropertyNames.Name] = "panelControl2";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public UIDocumentListBoxWindow UIDocumentListBoxWindow
		{
			get
			{
				if ((this.mUIDocumentListBoxWindow == null))
				{
					this.mUIDocumentListBoxWindow = new UIDocumentListBoxWindow(this);
				}
				return this.mUIDocumentListBoxWindow;
			}
		}
		#endregion
		#region Fields
		private UIDocumentListBoxWindow mUIDocumentListBoxWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentListBoxWindow : WinWindow
	{
		public UIDocumentListBoxWindow(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public WinClient UIDocumentListBoxClient
		{
			get
			{
				if ((this.mUIDocumentListBoxClient == null))
				{
					this.mUIDocumentListBoxClient = new WinClient(this);
					#region Search Criteria
					this.mUIDocumentListBoxClient.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUIDocumentListBoxClient;
			}
		}
		#endregion
		#region Fields
		private WinClient mUIDocumentListBoxClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControl2Client : DXTestControl
	{
		public UIPanelControl2Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public UIDocumentListBoxCustom UIDocumentListBoxCustom
		{
			get
			{
				if ((this.mUIDocumentListBoxCustom == null))
				{
					this.mUIDocumentListBoxCustom = new UIDocumentListBoxCustom(this);
				}
				return this.mUIDocumentListBoxCustom;
			}
		}
		#endregion
		#region Fields
		private UIDocumentListBoxCustom mUIDocumentListBoxCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentListBoxCustom : DXTestControl
	{
		public UIDocumentListBoxCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "documentListBox";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MultiColumnListBox";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public WinClient UIDocumentListBoxClient
		{
			get
			{
				if ((this.mUIDocumentListBoxClient == null))
				{
					this.mUIDocumentListBoxClient = new WinClient(this);
					#region Search Criteria
					this.mUIDocumentListBoxClient.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUIDocumentListBoxClient;
			}
		}
		#endregion
		#region Fields
		private WinClient mUIDocumentListBoxClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPnlListClient : DXTestControl
	{
		public UIPnlListClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlList";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public UIDocumentListBoxCustom1 UIDocumentListBoxCustom
		{
			get
			{
				if ((this.mUIDocumentListBoxCustom == null))
				{
					this.mUIDocumentListBoxCustom = new UIDocumentListBoxCustom1(this);
				}
				return this.mUIDocumentListBoxCustom;
			}
		}
		#endregion
		#region Fields
		private UIDocumentListBoxCustom1 mUIDocumentListBoxCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentListBoxCustom1 : DXTestControl
	{
		public UIDocumentListBoxCustom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "documentListBox";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MultiColumnListBox";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public WinClient UIDocumentListBoxClient
		{
			get
			{
				if ((this.mUIDocumentListBoxClient == null))
				{
					this.mUIDocumentListBoxClient = new WinClient(this);
					#region Search Criteria
					this.mUIDocumentListBoxClient.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUIDocumentListBoxClient;
			}
		}
		#endregion
		#region Fields
		private WinClient mUIDocumentListBoxClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow1 : DXWindow
	{
		public UIItemWindow1()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Windows";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public UIPanelControlClient UIPanelControlClient
		{
			get
			{
				if ((this.mUIPanelControlClient == null))
				{
					this.mUIPanelControlClient = new UIPanelControlClient(this);
				}
				return this.mUIPanelControlClient;
			}
		}
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUICloseButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		public UIPanelControlClient1 UIPanelControlClient1
		{
			get
			{
				if ((this.mUIPanelControlClient1 == null))
				{
					this.mUIPanelControlClient1 = new UIPanelControlClient1(this);
				}
				return this.mUIPanelControlClient1;
			}
		}
		public UIPanelControlClient2 UIPanelControlClient2
		{
			get
			{
				if ((this.mUIPanelControlClient2 == null))
				{
					this.mUIPanelControlClient2 = new UIPanelControlClient2(this);
				}
				return this.mUIPanelControlClient2;
			}
		}
		public UIPnlCommandsClient UIPnlCommandsClient
		{
			get
			{
				if ((this.mUIPnlCommandsClient == null))
				{
					this.mUIPnlCommandsClient = new UIPnlCommandsClient(this);
				}
				return this.mUIPnlCommandsClient;
			}
		}
		#endregion
		#region Fields
		private UIPanelControlClient mUIPanelControlClient;
		private DXButton mUICloseButton;
		private UIPanelControlClient1 mUIPanelControlClient1;
		private UIPanelControlClient2 mUIPanelControlClient2;
		private UIPnlCommandsClient mUIPnlCommandsClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControlClient : DXTestControl
	{
		public UIPanelControlClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public DXButton UISimpleButtonButton
		{
			get
			{
				if ((this.mUISimpleButtonButton == null))
				{
					this.mUISimpleButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "activateButton";
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUISimpleButtonButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUISimpleButtonButton;
			}
		}
		public DXButton UISimpleButtonButton1
		{
			get
			{
				if ((this.mUISimpleButtonButton1 == null))
				{
					this.mUISimpleButtonButton1 = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton1.SearchProperties[DXTestControl.PropertyNames.Name] = "closeButton";
					this.mUISimpleButtonButton1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUISimpleButtonButton1.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUISimpleButtonButton1;
			}
		}
		public DXButton UICloseAllButtonButton
		{
			get
			{
				if ((this.mUICloseAllButtonButton == null))
				{
					this.mUICloseAllButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseAllButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "closeAllButton";
					this.mUICloseAllButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUICloseAllButtonButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUICloseAllButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISimpleButtonButton;
		private DXButton mUISimpleButtonButton1;
		private DXButton mUICloseAllButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControlClient1 : DXTestControl
	{
		public UIPanelControlClient1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "PanelControl[1]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public DXButton UICloseDocumentButton
		{
			get
			{
				if ((this.mUICloseDocumentButton == null))
				{
					this.mUICloseDocumentButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseDocumentButton.SearchProperties[DXTestControl.PropertyNames.Name] = "PanelControl[1]SimpleButton[1]";
					this.mUICloseDocumentButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUICloseDocumentButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUICloseDocumentButton;
			}
		}
		public DXButton UISimpleButtonButton
		{
			get
			{
				if ((this.mUISimpleButtonButton == null))
				{
					this.mUISimpleButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "PanelControl[1]SimpleButton[2]";
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUISimpleButtonButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUISimpleButtonButton;
			}
		}
		public DXButton UIOKButton
		{
			get
			{
				if ((this.mUIOKButton == null))
				{
					this.mUIOKButton = new DXButton(this);
					#region Search Criteria
					this.mUIOKButton.SearchProperties[DXTestControl.PropertyNames.Name] = "PanelControl[1]SimpleButton[3]";
					this.mUIOKButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUIOKButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUIOKButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseDocumentButton;
		private DXButton mUISimpleButtonButton;
		private DXButton mUIOKButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControlClient2 : DXTestControl
	{
		public UIPanelControlClient2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "PanelControl[1]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public DXButton UISimpleButtonButton
		{
			get
			{
				if ((this.mUISimpleButtonButton == null))
				{
					this.mUISimpleButtonButton = new DXButton(this);
					#region Search Criteria
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.Name] = "PanelControl[1]SimpleButton[3]";
					this.mUISimpleButtonButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUISimpleButtonButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUISimpleButtonButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUISimpleButtonButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPnlCommandsClient : DXTestControl
	{
		public UIPnlCommandsClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlCommands";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Windows");
			#endregion
		}
		#region Properties
		public DXButton UICloseDocumentButton
		{
			get
			{
				if ((this.mUICloseDocumentButton == null))
				{
					this.mUICloseDocumentButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseDocumentButton.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlCommandsSimpleButton[1]";
					this.mUICloseDocumentButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUICloseDocumentButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUICloseDocumentButton;
			}
		}
		public DXButton UIOKButton
		{
			get
			{
				if ((this.mUIOKButton == null))
				{
					this.mUIOKButton = new DXButton(this);
					#region Search Criteria
					this.mUIOKButton.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlCommandsSimpleButton[3]";
					this.mUIOKButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUIOKButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUIOKButton;
			}
		}
		public DXButton UICloseAllDocumentsButton
		{
			get
			{
				if ((this.mUICloseAllDocumentsButton == null))
				{
					this.mUICloseAllDocumentsButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseAllDocumentsButton.SearchProperties[DXTestControl.PropertyNames.Name] = "pnlCommandsSimpleButton[2]";
					this.mUICloseAllDocumentsButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUICloseAllDocumentsButton.WindowTitles.Add("Windows");
					#endregion
				}
				return this.mUICloseAllDocumentsButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseDocumentButton;
		private DXButton mUIOKButton;
		private DXButton mUICloseAllDocumentsButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerNativWindow : DXWindow
	{
		public UIDocumentManagerNativWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document Manager (NativeMdi View)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (NativeMdi View)");
			#endregion
		}
		#region Properties
		public UIMdiClientTabList2 UIMdiClientTabList
		{
			get
			{
				if ((this.mUIMdiClientTabList == null))
				{
					this.mUIMdiClientTabList = new UIMdiClientTabList2(this);
				}
				return this.mUIMdiClientTabList;
			}
		}
		public UIBarDockControlCustom1 UIBarDockControlCustom
		{
			get
			{
				if ((this.mUIBarDockControlCustom == null))
				{
					this.mUIBarDockControlCustom = new UIBarDockControlCustom1(this);
				}
				return this.mUIBarDockControlCustom;
			}
		}
		#endregion
		#region Fields
		private UIMdiClientTabList2 mUIMdiClientTabList;
		private UIBarDockControlCustom1 mUIBarDockControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMdiClientTabList2 : DXTestControl
	{
		public UIMdiClientTabList2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MdiClient[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClient";
			this.WindowTitles.Add("Document Manager (NativeMdi View)");
			#endregion
		}
		#region Properties
		public DXWindow UIDocument2Window
		{
			get
			{
				if ((this.mUIDocument2Window == null))
				{
					this.mUIDocument2Window = new DXWindow(this);
					#region Search Criteria
					this.mUIDocument2Window.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2";
					this.mUIDocument2Window.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
					this.mUIDocument2Window.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIDocument2Window;
			}
		}
		public UIDocument4Window1 UIDocument4Window
		{
			get
			{
				if ((this.mUIDocument4Window == null))
				{
					this.mUIDocument4Window = new UIDocument4Window1(this);
				}
				return this.mUIDocument4Window;
			}
		}
		public UIDocument5Window UIDocument5Window
		{
			get
			{
				if ((this.mUIDocument5Window == null))
				{
					this.mUIDocument5Window = new UIDocument5Window(this);
				}
				return this.mUIDocument5Window;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIDocument2Window;
		private UIDocument4Window1 mUIDocument4Window;
		private UIDocument5Window mUIDocument5Window;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument4Window1 : DXWindow
	{
		public UIDocument4Window1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (NativeMdi View)");
			#endregion
		}
		#region Properties
		public DXWindow UIFormCaptionWindow
		{
			get
			{
				if ((this.mUIFormCaptionWindow == null))
				{
					this.mUIFormCaptionWindow = new DXWindow(this);
					#region Search Criteria
					this.mUIFormCaptionWindow.SearchProperties[DXTestControl.PropertyNames.Name] = "FormCaption";
					this.mUIFormCaptionWindow.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FormCaption";
					this.mUIFormCaptionWindow.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIFormCaptionWindow;
			}
		}
		public DXButton UIMinimizeButton
		{
			get
			{
				if ((this.mUIMinimizeButton == null))
				{
					this.mUIMinimizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMinimizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Minimize";
					this.mUIMinimizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUIMinimizeButton.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIMinimizeButton;
			}
		}
		public DXButton UIMaximizeButton
		{
			get
			{
				if ((this.mUIMaximizeButton == null))
				{
					this.mUIMaximizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Maximize";
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUIMaximizeButton.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIMaximizeButton;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIFormCaptionWindow;
		private DXButton mUIMinimizeButton;
		private DXButton mUIMaximizeButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument5Window : DXWindow
	{
		public UIDocument5Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document5";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (NativeMdi View)");
			#endregion
		}
		#region Properties
		public DXWindow UIFormCaptionWindow
		{
			get
			{
				if ((this.mUIFormCaptionWindow == null))
				{
					this.mUIFormCaptionWindow = new DXWindow(this);
					#region Search Criteria
					this.mUIFormCaptionWindow.SearchProperties[DXTestControl.PropertyNames.Name] = "FormCaption";
					this.mUIFormCaptionWindow.SearchProperties[DXTestControl.PropertyNames.ClassName] = "FormCaption";
					this.mUIFormCaptionWindow.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIFormCaptionWindow;
			}
		}
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUICloseButton.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		public DXWindow UIWindowTitleBarWindow
		{
			get
			{
				if ((this.mUIWindowTitleBarWindow == null))
				{
					this.mUIWindowTitleBarWindow = new DXWindow(this);
					#region Search Criteria
					this.mUIWindowTitleBarWindow.SearchProperties[DXTestControl.PropertyNames.Name] = "WindowTitleBar";
					this.mUIWindowTitleBarWindow.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIWindowTitleBarWindow.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIWindowTitleBarWindow;
			}
		}
		public DXWindow UIDocument5Window1
		{
			get
			{
				if ((this.mUIDocument5Window1 == null))
				{
					this.mUIDocument5Window1 = new DXWindow(this);
					#region Search Criteria
					this.mUIDocument5Window1.SearchProperties[DXTestControl.PropertyNames.Name] = "Document5";
					this.mUIDocument5Window1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIDocument5Window1.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIDocument5Window1;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIFormCaptionWindow;
		private DXButton mUICloseButton;
		private DXWindow mUIWindowTitleBarWindow;
		private DXWindow mUIDocument5Window1;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarDockControlCustom1 : DXTestControl
	{
		public UIBarDockControlCustom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BarDockControl[3]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarDockControl";
			this.WindowTitles.Add("Document Manager (NativeMdi View)");
			#endregion
		}
		#region Properties
		public UIMainmenuMenuBar UIMainmenuMenuBar
		{
			get
			{
				if ((this.mUIMainmenuMenuBar == null))
				{
					this.mUIMainmenuMenuBar = new UIMainmenuMenuBar(this);
				}
				return this.mUIMainmenuMenuBar;
			}
		}
		#endregion
		#region Fields
		private UIMainmenuMenuBar mUIMainmenuMenuBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMainmenuMenuBar : DXMenu
	{
		public UIMainmenuMenuBar(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Main menu";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("Document Manager (NativeMdi View)");
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UIAddNewDocumentBarBaseButtonItem
		{
			get
			{
				if ((this.mUIAddNewDocumentBarBaseButtonItem == null))
				{
					this.mUIAddNewDocumentBarBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIAddNewDocumentBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Add New Document";
					this.mUIAddNewDocumentBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarBaseButtonItem";
					this.mUIAddNewDocumentBarBaseButtonItem.WindowTitles.Add("Document Manager (NativeMdi View)");
					#endregion
				}
				return this.mUIAddNewDocumentBarBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUIAddNewDocumentBarBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerTabbeWindow : DXWindow
	{
		public UIDocumentManagerTabbeWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document Manager (Tabbed View)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public UIMdiClientTabList3 UIMdiClientTabList
		{
			get
			{
				if ((this.mUIMdiClientTabList == null))
				{
					this.mUIMdiClientTabList = new UIMdiClientTabList3(this);
				}
				return this.mUIMdiClientTabList;
			}
		}
		public UIBarDockControlCustom2 UIBarDockControlCustom
		{
			get
			{
				if ((this.mUIBarDockControlCustom == null))
				{
					this.mUIBarDockControlCustom = new UIBarDockControlCustom2(this);
				}
				return this.mUIBarDockControlCustom;
			}
		}
		#endregion
		#region Fields
		private UIMdiClientTabList3 mUIMdiClientTabList;
		private UIBarDockControlCustom2 mUIBarDockControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMdiClientTabList3 : DXTestControl
	{
		public UIMdiClientTabList3(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MdiClient[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClient";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public UIDocument4Window2 UIDocument4Window
		{
			get
			{
				if ((this.mUIDocument4Window == null))
				{
					this.mUIDocument4Window = new UIDocument4Window2(this);
				}
				return this.mUIDocument4Window;
			}
		}
		public DXTestControl UIDocument5TabPage
		{
			get
			{
				if ((this.mUIDocument5TabPage == null))
				{
					this.mUIDocument5TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument5TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document5";
					this.mUIDocument5TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument5TabPage.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIDocument5TabPage;
			}
		}
		public UIDocument1Window UIDocument1Window
		{
			get
			{
				if ((this.mUIDocument1Window == null))
				{
					this.mUIDocument1Window = new UIDocument1Window(this);
				}
				return this.mUIDocument1Window;
			}
		}
		public DXTestControl UIDocument2TabPage
		{
			get
			{
				if ((this.mUIDocument2TabPage == null))
				{
					this.mUIDocument2TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument2TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2";
					this.mUIDocument2TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument2TabPage.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIDocument2TabPage;
			}
		}
		public DXTestControl UIDocument4TabPage
		{
			get
			{
				if ((this.mUIDocument4TabPage == null))
				{
					this.mUIDocument4TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument4TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
					this.mUIDocument4TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument4TabPage.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIDocument4TabPage;
			}
		}
		public UIDocument1TabPage UIDocument1TabPage
		{
			get
			{
				if ((this.mUIDocument1TabPage == null))
				{
					this.mUIDocument1TabPage = new UIDocument1TabPage(this);
				}
				return this.mUIDocument1TabPage;
			}
		}
		public UIDocument3TabPage UIDocument3TabPage
		{
			get
			{
				if ((this.mUIDocument3TabPage == null))
				{
					this.mUIDocument3TabPage = new UIDocument3TabPage(this);
				}
				return this.mUIDocument3TabPage;
			}
		}
		public UIDocument0TabPage UIDocument0TabPage
		{
			get
			{
				if ((this.mUIDocument0TabPage == null))
				{
					this.mUIDocument0TabPage = new UIDocument0TabPage(this);
				}
				return this.mUIDocument0TabPage;
			}
		}
		public UIItem0Group1 UIItem0Group
		{
			get
			{
				if ((this.mUIItem0Group == null))
				{
					this.mUIItem0Group = new UIItem0Group1(this);
				}
				return this.mUIItem0Group;
			}
		}
		#endregion
		#region Fields
		private UIDocument4Window2 mUIDocument4Window;
		private DXTestControl mUIDocument5TabPage;
		private UIDocument1Window mUIDocument1Window;
		private DXTestControl mUIDocument2TabPage;
		private DXTestControl mUIDocument4TabPage;
		private UIDocument1TabPage mUIDocument1TabPage;
		private UIDocument3TabPage mUIDocument3TabPage;
		private UIDocument0TabPage mUIDocument0TabPage;
		private UIItem0Group1 mUIItem0Group;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument4Window2 : DXWindow
	{
		public UIDocument4Window2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXTestControl UILabelControlLabel
		{
			get
			{
				if ((this.mUILabelControlLabel == null))
				{
					this.mUILabelControlLabel = new DXTestControl(this);
					#region Search Criteria
					this.mUILabelControlLabel.SearchProperties[DXTestControl.PropertyNames.Name] = "LabelControl[0]";
					this.mUILabelControlLabel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LabelControl";
					this.mUILabelControlLabel.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUILabelControlLabel;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUILabelControlLabel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument1Window : DXWindow
	{
		public UIDocument1Window(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXTestControl UILabelControlLabel
		{
			get
			{
				if ((this.mUILabelControlLabel == null))
				{
					this.mUILabelControlLabel = new DXTestControl(this);
					#region Search Criteria
					this.mUILabelControlLabel.SearchProperties[DXTestControl.PropertyNames.Name] = "LabelControl[0]";
					this.mUILabelControlLabel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LabelControl";
					this.mUILabelControlLabel.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUILabelControlLabel;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUILabelControlLabel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument1TabPage : DXTestControl
	{
		public UIDocument1TabPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXButton UIDocument1Button
		{
			get
			{
				if ((this.mUIDocument1Button == null))
				{
					this.mUIDocument1Button = new DXButton(this);
					#region Search Criteria
					this.mUIDocument1Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1";
					this.mUIDocument1Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument1Button.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIDocument1Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument1Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument3TabPage : DXTestControl
	{
		public UIDocument3TabPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXButton UIDocument3Button
		{
			get
			{
				if ((this.mUIDocument3Button == null))
				{
					this.mUIDocument3Button = new DXButton(this);
					#region Search Criteria
					this.mUIDocument3Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
					this.mUIDocument3Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument3Button.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIDocument3Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument3Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument0TabPage : DXTestControl
	{
		public UIDocument0TabPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXButton UIDocument0Button
		{
			get
			{
				if ((this.mUIDocument0Button == null))
				{
					this.mUIDocument0Button = new DXButton(this);
					#region Search Criteria
					this.mUIDocument0Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
					this.mUIDocument0Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument0Button.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIDocument0Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument0Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItem0Group1 : DXTestControl
	{
		public UIItem0Group1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentGroup";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabCloseButton";
					this.mUICloseButton.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarDockControlCustom2 : DXTestControl
	{
		public UIBarDockControlCustom2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BarDockControl[3]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarDockControl";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public UIMainmenuMenuBar1 UIMainmenuMenuBar
		{
			get
			{
				if ((this.mUIMainmenuMenuBar == null))
				{
					this.mUIMainmenuMenuBar = new UIMainmenuMenuBar1(this);
				}
				return this.mUIMainmenuMenuBar;
			}
		}
		public UIBarOptionsMenuBar UIBarOptionsMenuBar
		{
			get
			{
				if ((this.mUIBarOptionsMenuBar == null))
				{
					this.mUIBarOptionsMenuBar = new UIBarOptionsMenuBar(this);
				}
				return this.mUIBarOptionsMenuBar;
			}
		}
		#endregion
		#region Fields
		private UIMainmenuMenuBar1 mUIMainmenuMenuBar;
		private UIBarOptionsMenuBar mUIBarOptionsMenuBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMainmenuMenuBar1 : DXMenu
	{
		public UIMainmenuMenuBar1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Main menu";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UIAddNewDocumentBarBaseButtonItem
		{
			get
			{
				if ((this.mUIAddNewDocumentBarBaseButtonItem == null))
				{
					this.mUIAddNewDocumentBarBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIAddNewDocumentBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Add New Document";
					this.mUIAddNewDocumentBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarBaseButtonItem";
					this.mUIAddNewDocumentBarBaseButtonItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIAddNewDocumentBarBaseButtonItem;
			}
		}
		public UIDocumentsBarItem UIDocumentsBarItem
		{
			get
			{
				if ((this.mUIDocumentsBarItem == null))
				{
					this.mUIDocumentsBarItem = new UIDocumentsBarItem(this);
				}
				return this.mUIDocumentsBarItem;
			}
		}
		public DXMenuEditItem UIOrientationBarEditItem
		{
			get
			{
				if ((this.mUIOrientationBarEditItem == null))
				{
					this.mUIOrientationBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIOrientationBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Orientation";
					this.mUIOrientationBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIOrientationBarEditItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIOrientationBarEditItem;
			}
		}
		public DXComboBox UIOrientationComboBox
		{
			get
			{
				if ((this.mUIOrientationComboBox == null))
				{
					this.mUIOrientationComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIOrientationComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Orientation";
					this.mUIOrientationComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIOrientationComboBox.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIOrientationComboBox;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUIAddNewDocumentBarBaseButtonItem;
		private UIDocumentsBarItem mUIDocumentsBarItem;
		private DXMenuEditItem mUIOrientationBarEditItem;
		private DXComboBox mUIOrientationComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentsBarItem : DXMenuItem
	{
		public UIDocumentsBarItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Documents";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarItem";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UIItem1Document0MenuBaseButtonItem
		{
			get
			{
				if ((this.mUIItem1Document0MenuBaseButtonItem == null))
				{
					this.mUIItem1Document0MenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIItem1Document0MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "&1 Document0";
					this.mUIItem1Document0MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					this.mUIItem1Document0MenuBaseButtonItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIItem1Document0MenuBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIItem3Document2MenuBaseButtonItem
		{
			get
			{
				if ((this.mUIItem3Document2MenuBaseButtonItem == null))
				{
					this.mUIItem3Document2MenuBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIItem3Document2MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "&3 Document2";
					this.mUIItem3Document2MenuBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuBaseButtonItem";
					this.mUIItem3Document2MenuBaseButtonItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIItem3Document2MenuBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUIItem1Document0MenuBaseButtonItem;
		private DXMenuBaseButtonItem mUIItem3Document2MenuBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarOptionsMenuBar : DXMenu
	{
		public UIBarOptionsMenuBar(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "barOptions";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("Document Manager (Tabbed View)");
			#endregion
		}
		#region Properties
		public DXMenuEditItem UIHeaderLocationBarEditItem
		{
			get
			{
				if ((this.mUIHeaderLocationBarEditItem == null))
				{
					this.mUIHeaderLocationBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIHeaderLocationBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Location";
					this.mUIHeaderLocationBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIHeaderLocationBarEditItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIHeaderLocationBarEditItem;
			}
		}
		public DXComboBox UIHeaderLocationComboBox
		{
			get
			{
				if ((this.mUIHeaderLocationComboBox == null))
				{
					this.mUIHeaderLocationComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIHeaderLocationComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Location";
					this.mUIHeaderLocationComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIHeaderLocationComboBox.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIHeaderLocationComboBox;
			}
		}
		public DXMenuEditItem UIHeaderOrientationBarEditItem
		{
			get
			{
				if ((this.mUIHeaderOrientationBarEditItem == null))
				{
					this.mUIHeaderOrientationBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIHeaderOrientationBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Orientation";
					this.mUIHeaderOrientationBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIHeaderOrientationBarEditItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIHeaderOrientationBarEditItem;
			}
		}
		public DXComboBox UIHeaderOrientationComboBox
		{
			get
			{
				if ((this.mUIHeaderOrientationComboBox == null))
				{
					this.mUIHeaderOrientationComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIHeaderOrientationComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Orientation";
					this.mUIHeaderOrientationComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIHeaderOrientationComboBox.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIHeaderOrientationComboBox;
			}
		}
		public DXMenuEditItem UIShowCloseButtonBarEditItem
		{
			get
			{
				if ((this.mUIShowCloseButtonBarEditItem == null))
				{
					this.mUIShowCloseButtonBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIShowCloseButtonBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Show Close Button";
					this.mUIShowCloseButtonBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIShowCloseButtonBarEditItem.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIShowCloseButtonBarEditItem;
			}
		}
		public DXComboBox UIShowCloseButtonComboBox
		{
			get
			{
				if ((this.mUIShowCloseButtonComboBox == null))
				{
					this.mUIShowCloseButtonComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIShowCloseButtonComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Show Close Button";
					this.mUIShowCloseButtonComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIShowCloseButtonComboBox.WindowTitles.Add("Document Manager (Tabbed View)");
					#endregion
				}
				return this.mUIShowCloseButtonComboBox;
			}
		}
		#endregion
		#region Fields
		private DXMenuEditItem mUIHeaderLocationBarEditItem;
		private DXComboBox mUIHeaderLocationComboBox;
		private DXMenuEditItem mUIHeaderOrientationBarEditItem;
		private DXComboBox mUIHeaderOrientationComboBox;
		private DXMenuEditItem mUIShowCloseButtonBarEditItem;
		private DXComboBox mUIShowCloseButtonComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerNativWindow1 : DXWindow
	{
		public UIDocumentManagerNativWindow1()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document Manager (NativeMdi View) - [Document4]";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document Manager (NativeMdi View) - [Document4]");
			#endregion
		}
		#region Properties
		public UIBarDockControlCustom3 UIBarDockControlCustom
		{
			get
			{
				if ((this.mUIBarDockControlCustom == null))
				{
					this.mUIBarDockControlCustom = new UIBarDockControlCustom3(this);
				}
				return this.mUIBarDockControlCustom;
			}
		}
		#endregion
		#region Fields
		private UIBarDockControlCustom3 mUIBarDockControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarDockControlCustom3 : DXTestControl
	{
		public UIBarDockControlCustom3(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BarDockControl[3]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarDockControl";
			this.WindowTitles.Add("Document Manager (NativeMdi View) - [Document4]");
			#endregion
		}
		#region Properties
		public UIMainmenuMenuBar2 UIMainmenuMenuBar
		{
			get
			{
				if ((this.mUIMainmenuMenuBar == null))
				{
					this.mUIMainmenuMenuBar = new UIMainmenuMenuBar2(this);
				}
				return this.mUIMainmenuMenuBar;
			}
		}
		#endregion
		#region Fields
		private UIMainmenuMenuBar2 mUIMainmenuMenuBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMainmenuMenuBar2 : DXMenu
	{
		public UIMainmenuMenuBar2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Main menu";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("Document Manager (NativeMdi View) - [Document4]");
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UIBarMdiButtonItemLinkBarBaseButtonItem
		{
			get
			{
				if ((this.mUIBarMdiButtonItemLinkBarBaseButtonItem == null))
				{
					this.mUIBarMdiButtonItemLinkBarBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIBarMdiButtonItemLinkBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "BarMdiButtonItemLink[2]";
					this.mUIBarMdiButtonItemLinkBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarBaseButtonItem";
					this.mUIBarMdiButtonItemLinkBarBaseButtonItem.WindowTitles.Add("Document Manager (NativeMdi View) - [Document4]");
					#endregion
				}
				return this.mUIBarMdiButtonItemLinkBarBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUIBarMdiButtonItemLinkBarBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow2 : DXWindow
	{
		public UIItemWindow2()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document1");
			#endregion
		}
		#region Properties
		public DXWindow UIDocument1Window
		{
			get
			{
				if ((this.mUIDocument1Window == null))
				{
					this.mUIDocument1Window = new DXWindow(this);
					#region Search Criteria
					this.mUIDocument1Window.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1";
					this.mUIDocument1Window.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIDocument1Window.WindowTitles.Add("Document1");
					#endregion
				}
				return this.mUIDocument1Window;
			}
		}
		public DXButton UIMinimizeButton
		{
			get
			{
				if ((this.mUIMinimizeButton == null))
				{
					this.mUIMinimizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMinimizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Minimize";
					this.mUIMinimizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUIMinimizeButton.WindowTitles.Add("Document1");
					#endregion
				}
				return this.mUIMinimizeButton;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIDocument1Window;
		private DXButton mUIMinimizeButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow3 : DXWindow
	{
		public UIItemWindow3()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document3");
			#endregion
		}
		#region Properties
		public DXWindow UIDocument3Window
		{
			get
			{
				if ((this.mUIDocument3Window == null))
				{
					this.mUIDocument3Window = new DXWindow(this);
					#region Search Criteria
					this.mUIDocument3Window.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
					this.mUIDocument3Window.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIDocument3Window.WindowTitles.Add("Document3");
					#endregion
				}
				return this.mUIDocument3Window;
			}
		}
		public DXButton UIMaximizeButton
		{
			get
			{
				if ((this.mUIMaximizeButton == null))
				{
					this.mUIMaximizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Maximize";
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUIMaximizeButton.WindowTitles.Add("Document3");
					#endregion
				}
				return this.mUIMaximizeButton;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIDocument3Window;
		private DXButton mUIMaximizeButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow4 : DXWindow
	{
		public UIItemWindow4()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document0");
			#endregion
		}
		#region Properties
		public DXWindow UIDocument0Window
		{
			get
			{
				if ((this.mUIDocument0Window == null))
				{
					this.mUIDocument0Window = new DXWindow(this);
					#region Search Criteria
					this.mUIDocument0Window.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
					this.mUIDocument0Window.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIDocument0Window.WindowTitles.Add("Document0");
					#endregion
				}
				return this.mUIDocument0Window;
			}
		}
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUICloseButton.WindowTitles.Add("Document0");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIDocument0Window;
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument3Window1 : WinWindow
	{
		public UIDocument3Window1()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.Name] = "Document3";
			this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document3");
			#endregion
		}
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UITabbedMDICcodeWindow : DXWindow
	{
		public UITabbedMDICcodeWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "TabbedMDI (C# code)";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public UIMdiClientTabList4 UIMdiClientTabList
		{
			get
			{
				if ((this.mUIMdiClientTabList == null))
				{
					this.mUIMdiClientTabList = new UIMdiClientTabList4(this);
				}
				return this.mUIMdiClientTabList;
			}
		}
		public UIBarDockControlCustom4 UIBarDockControlCustom
		{
			get
			{
				if ((this.mUIBarDockControlCustom == null))
				{
					this.mUIBarDockControlCustom = new UIBarDockControlCustom4(this);
				}
				return this.mUIBarDockControlCustom;
			}
		}
		#endregion
		#region Fields
		private UIMdiClientTabList4 mUIMdiClientTabList;
		private UIBarDockControlCustom4 mUIBarDockControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIMdiClientTabList4 : DXTestControl
	{
		public UIMdiClientTabList4(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "MdiClient[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClient";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXTestControl UIForm2TabPage
		{
			get
			{
				if ((this.mUIForm2TabPage == null))
				{
					this.mUIForm2TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIForm2TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Form 2";
					this.mUIForm2TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIForm2TabPage.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIForm2TabPage;
			}
		}
		public UIForm1TabPage UIForm1TabPage
		{
			get
			{
				if ((this.mUIForm1TabPage == null))
				{
					this.mUIForm1TabPage = new UIForm1TabPage(this);
				}
				return this.mUIForm1TabPage;
			}
		}
		public UIItem0Group2 UIItem0Group
		{
			get
			{
				if ((this.mUIItem0Group == null))
				{
					this.mUIItem0Group = new UIItem0Group2(this);
				}
				return this.mUIItem0Group;
			}
		}
		public DXWindow UIForm2Window
		{
			get
			{
				if ((this.mUIForm2Window == null))
				{
					this.mUIForm2Window = new DXWindow(this);
					#region Search Criteria
					this.mUIForm2Window.SearchProperties[DXTestControl.PropertyNames.Name] = "Form 2";
					this.mUIForm2Window.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
					this.mUIForm2Window.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIForm2Window;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIForm2TabPage;
		private UIForm1TabPage mUIForm1TabPage;
		private UIItem0Group2 mUIItem0Group;
		private DXWindow mUIForm2Window;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIForm1TabPage : DXTestControl
	{
		public UIForm1TabPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Form 1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXButton UIForm1Button
		{
			get
			{
				if ((this.mUIForm1Button == null))
				{
					this.mUIForm1Button = new DXButton(this);
					#region Search Criteria
					this.mUIForm1Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Form 1";
					this.mUIForm1Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIForm1Button.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIForm1Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIForm1Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItem0Group2 : DXTestControl
	{
		public UIItem0Group2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentGroup";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabCloseButton";
					this.mUICloseButton.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarDockControlCustom4 : DXTestControl
	{
		public UIBarDockControlCustom4(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BarDockControl[3]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarDockControl";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public UIBarWindowsMenuBar UIBarWindowsMenuBar
		{
			get
			{
				if ((this.mUIBarWindowsMenuBar == null))
				{
					this.mUIBarWindowsMenuBar = new UIBarWindowsMenuBar(this);
				}
				return this.mUIBarWindowsMenuBar;
			}
		}
		public UIClosePageButtonsMenuBar UIClosePageButtonsMenuBar
		{
			get
			{
				if ((this.mUIClosePageButtonsMenuBar == null))
				{
					this.mUIClosePageButtonsMenuBar = new UIClosePageButtonsMenuBar(this);
				}
				return this.mUIClosePageButtonsMenuBar;
			}
		}
		public UIBarOptionsMenuBar1 UIBarOptionsMenuBar
		{
			get
			{
				if ((this.mUIBarOptionsMenuBar == null))
				{
					this.mUIBarOptionsMenuBar = new UIBarOptionsMenuBar1(this);
				}
				return this.mUIBarOptionsMenuBar;
			}
		}
		#endregion
		#region Fields
		private UIBarWindowsMenuBar mUIBarWindowsMenuBar;
		private UIClosePageButtonsMenuBar mUIClosePageButtonsMenuBar;
		private UIBarOptionsMenuBar1 mUIBarOptionsMenuBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarWindowsMenuBar : DXMenu
	{
		public UIBarWindowsMenuBar(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "barWindows";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXMenuBaseButtonItem UIFloatOnDragBarBaseButtonItem
		{
			get
			{
				if ((this.mUIFloatOnDragBarBaseButtonItem == null))
				{
					this.mUIFloatOnDragBarBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIFloatOnDragBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "FloatOnDrag";
					this.mUIFloatOnDragBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarBaseButtonItem";
					this.mUIFloatOnDragBarBaseButtonItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIFloatOnDragBarBaseButtonItem;
			}
		}
		public DXMenuBaseButtonItem UIFloatOnDoubleClickBarBaseButtonItem
		{
			get
			{
				if ((this.mUIFloatOnDoubleClickBarBaseButtonItem == null))
				{
					this.mUIFloatOnDoubleClickBarBaseButtonItem = new DXMenuBaseButtonItem(this);
					#region Search Criteria
					this.mUIFloatOnDoubleClickBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "FloatOnDoubleClick";
					this.mUIFloatOnDoubleClickBarBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarBaseButtonItem";
					this.mUIFloatOnDoubleClickBarBaseButtonItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIFloatOnDoubleClickBarBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXMenuBaseButtonItem mUIFloatOnDragBarBaseButtonItem;
		private DXMenuBaseButtonItem mUIFloatOnDoubleClickBarBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIClosePageButtonsMenuBar : DXMenu
	{
		public UIClosePageButtonsMenuBar(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ClosePage Buttons";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXMenuEditItem UIClosePageButtonBarEditItem
		{
			get
			{
				if ((this.mUIClosePageButtonBarEditItem == null))
				{
					this.mUIClosePageButtonBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIClosePageButtonBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Close Page Button";
					this.mUIClosePageButtonBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIClosePageButtonBarEditItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIClosePageButtonBarEditItem;
			}
		}
		public DXComboBox UIClosePageButtonComboBox
		{
			get
			{
				if ((this.mUIClosePageButtonComboBox == null))
				{
					this.mUIClosePageButtonComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIClosePageButtonComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Close Page Button";
					this.mUIClosePageButtonComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIClosePageButtonComboBox.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIClosePageButtonComboBox;
			}
		}
		#endregion
		#region Fields
		private DXMenuEditItem mUIClosePageButtonBarEditItem;
		private DXComboBox mUIClosePageButtonComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarOptionsMenuBar1 : DXMenu
	{
		public UIBarOptionsMenuBar1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "barOptions";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockedBarControl";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXMenuEditItem UIHeaderLocationBarEditItem
		{
			get
			{
				if ((this.mUIHeaderLocationBarEditItem == null))
				{
					this.mUIHeaderLocationBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIHeaderLocationBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Location";
					this.mUIHeaderLocationBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIHeaderLocationBarEditItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderLocationBarEditItem;
			}
		}
		public DXComboBox UIHeaderLocationComboBox
		{
			get
			{
				if ((this.mUIHeaderLocationComboBox == null))
				{
					this.mUIHeaderLocationComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIHeaderLocationComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Location";
					this.mUIHeaderLocationComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIHeaderLocationComboBox.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderLocationComboBox;
			}
		}
		public DXMenuEditItem UIHeaderOrientationBarEditItem
		{
			get
			{
				if ((this.mUIHeaderOrientationBarEditItem == null))
				{
					this.mUIHeaderOrientationBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIHeaderOrientationBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Orientation";
					this.mUIHeaderOrientationBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIHeaderOrientationBarEditItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderOrientationBarEditItem;
			}
		}
		public DXComboBox UIHeaderOrientationComboBox
		{
			get
			{
				if ((this.mUIHeaderOrientationComboBox == null))
				{
					this.mUIHeaderOrientationComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIHeaderOrientationComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Header Orientation";
					this.mUIHeaderOrientationComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIHeaderOrientationComboBox.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderOrientationComboBox;
			}
		}
		public UIBarCustomizationItemBarItem UIBarCustomizationItemBarItem
		{
			get
			{
				if ((this.mUIBarCustomizationItemBarItem == null))
				{
					this.mUIBarCustomizationItemBarItem = new UIBarCustomizationItemBarItem(this);
				}
				return this.mUIBarCustomizationItemBarItem;
			}
		}
		public DXMenuEditItem UIHeaderAutoFillBarEditItem
		{
			get
			{
				if ((this.mUIHeaderAutoFillBarEditItem == null))
				{
					this.mUIHeaderAutoFillBarEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIHeaderAutoFillBarEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFill";
					this.mUIHeaderAutoFillBarEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarEditItem";
					this.mUIHeaderAutoFillBarEditItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderAutoFillBarEditItem;
			}
		}
		public DXComboBox UIHeaderAutoFillComboBox
		{
			get
			{
				if ((this.mUIHeaderAutoFillComboBox == null))
				{
					this.mUIHeaderAutoFillComboBox = new DXComboBox(this);
					#region Search Criteria
					this.mUIHeaderAutoFillComboBox.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFill";
					this.mUIHeaderAutoFillComboBox.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
					this.mUIHeaderAutoFillComboBox.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderAutoFillComboBox;
			}
		}
		#endregion
		#region Fields
		private DXMenuEditItem mUIHeaderLocationBarEditItem;
		private DXComboBox mUIHeaderLocationComboBox;
		private DXMenuEditItem mUIHeaderOrientationBarEditItem;
		private DXComboBox mUIHeaderOrientationComboBox;
		private UIBarCustomizationItemBarItem mUIBarCustomizationItemBarItem;
		private DXMenuEditItem mUIHeaderAutoFillBarEditItem;
		private DXComboBox mUIHeaderAutoFillComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIBarCustomizationItemBarItem : DXMenuItem
	{
		public UIBarCustomizationItemBarItem(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "BarCustomizationItem";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "BarItem";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXMenuEditItem UIHeaderAutoFillMenuEditItem
		{
			get
			{
				if ((this.mUIHeaderAutoFillMenuEditItem == null))
				{
					this.mUIHeaderAutoFillMenuEditItem = new DXMenuEditItem(this);
					#region Search Criteria
					this.mUIHeaderAutoFillMenuEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFill";
					this.mUIHeaderAutoFillMenuEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MenuEditItem";
					this.mUIHeaderAutoFillMenuEditItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUIHeaderAutoFillMenuEditItem;
			}
		}
		public UIQuickCustomizationBaMenu UIQuickCustomizationBaMenu
		{
			get
			{
				if ((this.mUIQuickCustomizationBaMenu == null))
				{
					this.mUIQuickCustomizationBaMenu = new UIQuickCustomizationBaMenu(this);
				}
				return this.mUIQuickCustomizationBaMenu;
			}
		}
		#endregion
		#region Fields
		private DXMenuEditItem mUIHeaderAutoFillMenuEditItem;
		private UIQuickCustomizationBaMenu mUIQuickCustomizationBaMenu;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIQuickCustomizationBaMenu : DXMenu
	{
		public UIQuickCustomizationBaMenu(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "QuickCustomizationBarControl";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "QuickCustomizationBarControl";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public UIHeaderAutoFillComboBox UIHeaderAutoFillComboBox
		{
			get
			{
				if ((this.mUIHeaderAutoFillComboBox == null))
				{
					this.mUIHeaderAutoFillComboBox = new UIHeaderAutoFillComboBox(this);
				}
				return this.mUIHeaderAutoFillComboBox;
			}
		}
		#endregion
		#region Fields
		private UIHeaderAutoFillComboBox mUIHeaderAutoFillComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIHeaderAutoFillComboBox : DXComboBox
	{
		public UIHeaderAutoFillComboBox(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFill";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public UIPopupImageComboBoxEdWindow1 UIPopupImageComboBoxEdWindow
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdWindow == null))
				{
					this.mUIPopupImageComboBoxEdWindow = new UIPopupImageComboBoxEdWindow1(this);
				}
				return this.mUIPopupImageComboBoxEdWindow;
			}
		}
		#endregion
		#region Fields
		private UIPopupImageComboBoxEdWindow1 mUIPopupImageComboBoxEdWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupImageComboBoxEdWindow1 : DXWindow
	{
		public UIPopupImageComboBoxEdWindow1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFillPopupForm";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxForm";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public UIPopupImageComboBoxEdList1 UIPopupImageComboBoxEdList
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdList == null))
				{
					this.mUIPopupImageComboBoxEdList = new UIPopupImageComboBoxEdList1(this);
				}
				return this.mUIPopupImageComboBoxEdList;
			}
		}
		#endregion
		#region Fields
		private UIPopupImageComboBoxEdList1 mUIPopupImageComboBoxEdList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupImageComboBoxEdList1 : DXListBox
	{
		public UIPopupImageComboBoxEdList1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFillPopupFormPopupImageComboBoxEditListBox[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBox";
			this.WindowTitles.Add("TabbedMDI (C# code)");
			#endregion
		}
		#region Properties
		public DXListBoxItem UITrueListItem
		{
			get
			{
				if ((this.mUITrueListItem == null))
				{
					this.mUITrueListItem = new DXListBoxItem(this);
					#region Search Criteria
					this.mUITrueListItem.SearchProperties[DXTestControl.PropertyNames.Name] = "Header AutoFillPopupFormPopupImageComboBoxEditListBox[0]Item[0]";
					this.mUITrueListItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					this.mUITrueListItem.WindowTitles.Add("TabbedMDI (C# code)");
					#endregion
				}
				return this.mUITrueListItem;
			}
		}
		#endregion
		#region Fields
		private DXListBoxItem mUITrueListItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIForm2Window : DXWindow
	{
		public UIForm2Window()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Form 2";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Form 2");
			#endregion
		}
		#region Properties
		public DXWindow UIForm2Window1
		{
			get
			{
				if ((this.mUIForm2Window1 == null))
				{
					this.mUIForm2Window1 = new DXWindow(this);
					#region Search Criteria
					this.mUIForm2Window1.SearchProperties[DXTestControl.PropertyNames.Name] = "Form 2";
					this.mUIForm2Window1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIForm2Window1.WindowTitles.Add("Form 2");
					#endregion
				}
				return this.mUIForm2Window1;
			}
		}
		public DXTestControl UIForm2WindowTitleBar
		{
			get
			{
				if ((this.mUIForm2WindowTitleBar == null))
				{
					this.mUIForm2WindowTitleBar = new DXTestControl(this);
					#region Search Criteria
					this.mUIForm2WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.Name] = "WindowTitleBar";
					this.mUIForm2WindowTitleBar.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleBar";
					this.mUIForm2WindowTitleBar.WindowTitles.Add("Form 2");
					#endregion
				}
				return this.mUIForm2WindowTitleBar;
			}
		}
		#endregion
		#region Fields
		private DXWindow mUIForm2Window1;
		private DXTestControl mUIForm2WindowTitleBar;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument0Window1 : WinWindow
	{
		public UIDocument0Window1()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.Name] = "Document0";
			this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Document0");
			#endregion
		}
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow11 : DXWindow
	{
		public UIItemWindow11()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Customization";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Customization");
			#endregion
		}
		#region Properties
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUICloseButton.WindowTitles.Add("Customization");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIApplicationUILayoutCWindow : DXWindow
	{
		public UIApplicationUILayoutCWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Application UI Layout Controls Demo (C# code) - Docking UI Integration";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public UIDocumentManagerDockiCustom UIDocumentManagerDockiCustom
		{
			get
			{
				if ((this.mUIDocumentManagerDockiCustom == null))
				{
					this.mUIDocumentManagerDockiCustom = new UIDocumentManagerDockiCustom(this);
				}
				return this.mUIDocumentManagerDockiCustom;
			}
		}
		#endregion
		#region Fields
		private UIDocumentManagerDockiCustom mUIDocumentManagerDockiCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerDockiCustom : DXTestControl
	{
		public UIDocumentManagerDockiCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DocumentManagerDocking";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentManagerDocking";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public UIDocumentsHostTabList UIDocumentsHostTabList
		{
			get
			{
				if ((this.mUIDocumentsHostTabList == null))
				{
					this.mUIDocumentsHostTabList = new UIDocumentsHostTabList(this);
				}
				return this.mUIDocumentsHostTabList;
			}
		}
		public DXDockPanel UIDockPanel3DockPanel
		{
			get
			{
				if ((this.mUIDockPanel3DockPanel == null))
				{
					this.mUIDockPanel3DockPanel = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanel3DockPanel.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel3";
					this.mUIDockPanel3DockPanel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanel3DockPanel.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDockPanel3DockPanel;
			}
		}
		public UIPanelContainer1DockPanel UIPanelContainer1DockPanel
		{
			get
			{
				if ((this.mUIPanelContainer1DockPanel == null))
				{
					this.mUIPanelContainer1DockPanel = new UIPanelContainer1DockPanel(this);
				}
				return this.mUIPanelContainer1DockPanel;
			}
		}
		#endregion
		#region Fields
		private UIDocumentsHostTabList mUIDocumentsHostTabList;
		private DXDockPanel mUIDockPanel3DockPanel;
		private UIPanelContainer1DockPanel mUIPanelContainer1DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentsHostTabList : DXTestControl
	{
		public UIDocumentsHostTabList(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DocumentManagerDockingDocumentsHost[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentsHost";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public UIItem0Group3 UIItem0Group
		{
			get
			{
				if ((this.mUIItem0Group == null))
				{
					this.mUIItem0Group = new UIItem0Group3(this);
				}
				return this.mUIItem0Group;
			}
		}
		public DXTestControl UIDocument2TabPage
		{
			get
			{
				if ((this.mUIDocument2TabPage == null))
				{
					this.mUIDocument2TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument2TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2";
					this.mUIDocument2TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument2TabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDocument2TabPage;
			}
		}
		public UIDocument0TabPage1 UIDocument0TabPage
		{
			get
			{
				if ((this.mUIDocument0TabPage == null))
				{
					this.mUIDocument0TabPage = new UIDocument0TabPage1(this);
				}
				return this.mUIDocument0TabPage;
			}
		}
		public DXTestControl UIRightPanelTabPage
		{
			get
			{
				if ((this.mUIRightPanelTabPage == null))
				{
					this.mUIRightPanelTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIRightPanelTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Right Panel";
					this.mUIRightPanelTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIRightPanelTabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIRightPanelTabPage;
			}
		}
		public DXTestControl UITopLeftPanelTabPage
		{
			get
			{
				if ((this.mUITopLeftPanelTabPage == null))
				{
					this.mUITopLeftPanelTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUITopLeftPanelTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "TopLeft Panel";
					this.mUITopLeftPanelTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUITopLeftPanelTabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUITopLeftPanelTabPage;
			}
		}
		public DXTestControl UIBottomLeftPanelTabPage
		{
			get
			{
				if ((this.mUIBottomLeftPanelTabPage == null))
				{
					this.mUIBottomLeftPanelTabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIBottomLeftPanelTabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "BottomLeft Panel";
					this.mUIBottomLeftPanelTabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIBottomLeftPanelTabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIBottomLeftPanelTabPage;
			}
		}
		public DXTestControl UIDocument1TabPage
		{
			get
			{
				if ((this.mUIDocument1TabPage == null))
				{
					this.mUIDocument1TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument1TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document1";
					this.mUIDocument1TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument1TabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDocument1TabPage;
			}
		}
		public UIDocument0Custom UIDocument0Custom
		{
			get
			{
				if ((this.mUIDocument0Custom == null))
				{
					this.mUIDocument0Custom = new UIDocument0Custom(this);
				}
				return this.mUIDocument0Custom;
			}
		}
		#endregion
		#region Fields
		private UIItem0Group3 mUIItem0Group;
		private DXTestControl mUIDocument2TabPage;
		private UIDocument0TabPage1 mUIDocument0TabPage;
		private DXTestControl mUIRightPanelTabPage;
		private DXTestControl mUITopLeftPanelTabPage;
		private DXTestControl mUIBottomLeftPanelTabPage;
		private DXTestControl mUIDocument1TabPage;
		private UIDocument0Custom mUIDocument0Custom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItem0Group3 : DXTestControl
	{
		public UIItem0Group3(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public DXButton UINextButton
		{
			get
			{
				if ((this.mUINextButton == null))
				{
					this.mUINextButton = new DXButton(this);
					#region Search Criteria
					this.mUINextButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Next";
					this.mUINextButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabNextButton";
					this.mUINextButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUINextButton;
			}
		}
		public DXButton UIPrevButton
		{
			get
			{
				if ((this.mUIPrevButton == null))
				{
					this.mUIPrevButton = new DXButton(this);
					#region Search Criteria
					this.mUIPrevButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Prev";
					this.mUIPrevButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabPrevButton";
					this.mUIPrevButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIPrevButton;
			}
		}
		public DXButton UIDropDownButton
		{
			get
			{
				if ((this.mUIDropDownButton == null))
				{
					this.mUIDropDownButton = new DXButton(this);
					#region Search Criteria
					this.mUIDropDownButton.SearchProperties[DXTestControl.PropertyNames.Name] = "DropDown";
					this.mUIDropDownButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabDropDownButton";
					this.mUIDropDownButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDropDownButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUINextButton;
		private DXButton mUIPrevButton;
		private DXButton mUIDropDownButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument0TabPage1 : DXTestControl
	{
		public UIDocument0TabPage1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public DXButton UIDocument0Button
		{
			get
			{
				if ((this.mUIDocument0Button == null))
				{
					this.mUIDocument0Button = new DXButton(this);
					#region Search Criteria
					this.mUIDocument0Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
					this.mUIDocument0Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument0Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDocument0Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument0Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument0Custom : DXTestControl
	{
		public UIDocument0Custom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentContainer";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public UIXtraUserControlCustom UIXtraUserControlCustom
		{
			get
			{
				if ((this.mUIXtraUserControlCustom == null))
				{
					this.mUIXtraUserControlCustom = new UIXtraUserControlCustom(this);
				}
				return this.mUIXtraUserControlCustom;
			}
		}
		#endregion
		#region Fields
		private UIXtraUserControlCustom mUIXtraUserControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraUserControlCustom : DXTestControl
	{
		public UIXtraUserControlCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0XtraUserControl[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraUserControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public DXTestControl UILabelControlLabel
		{
			get
			{
				if ((this.mUILabelControlLabel == null))
				{
					this.mUILabelControlLabel = new DXTestControl(this);
					#region Search Criteria
					this.mUILabelControlLabel.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0XtraUserControl[0]LabelControl[0]";
					this.mUILabelControlLabel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "LabelControl";
					this.mUILabelControlLabel.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUILabelControlLabel;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUILabelControlLabel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelContainer1DockPanel : DXDockPanel
	{
		public UIPanelContainer1DockPanel(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelContainer1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
			#endregion
		}
		#region Properties
		public DXDockPanel UIDockPanel1DockPanel
		{
			get
			{
				if ((this.mUIDockPanel1DockPanel == null))
				{
					this.mUIDockPanel1DockPanel = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanel1DockPanel.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel1";
					this.mUIDockPanel1DockPanel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanel1DockPanel.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDockPanel1DockPanel;
			}
		}
		public DXDockPanel UIDockPanel2DockPanel
		{
			get
			{
				if ((this.mUIDockPanel2DockPanel == null))
				{
					this.mUIDockPanel2DockPanel = new DXDockPanel(this);
					#region Search Criteria
					this.mUIDockPanel2DockPanel.SearchProperties[DXTestControl.PropertyNames.Name] = "dockPanel2";
					this.mUIDockPanel2DockPanel.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DockPanel";
					this.mUIDockPanel2DockPanel.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Docking UI Integration");
					#endregion
				}
				return this.mUIDockPanel2DockPanel;
			}
		}
		#endregion
		#region Fields
		private DXDockPanel mUIDockPanel1DockPanel;
		private DXDockPanel mUIDockPanel2DockPanel;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIApplicationUILayoutCWindow1 : DXWindow
	{
		public UIApplicationUILayoutCWindow1()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Application UI Layout Controls Demo (C# code) - Native Documents";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
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
		public UIRibbonControl1Ribbon UIRibbonControl1Ribbon
		{
			get
			{
				if ((this.mUIRibbonControl1Ribbon == null))
				{
					this.mUIRibbonControl1Ribbon = new UIRibbonControl1Ribbon(this);
				}
				return this.mUIRibbonControl1Ribbon;
			}
		}
		#endregion
		#region Fields
		private UIPanelControl1Client1 mUIPanelControl1Client;
		private UIRibbonControl1Ribbon mUIRibbonControl1Ribbon;
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public UIDocumentManagerNativCustom UIDocumentManagerNativCustom
		{
			get
			{
				if ((this.mUIDocumentManagerNativCustom == null))
				{
					this.mUIDocumentManagerNativCustom = new UIDocumentManagerNativCustom(this);
				}
				return this.mUIDocumentManagerNativCustom;
			}
		}
		#endregion
		#region Fields
		private UIDocumentManagerNativCustom mUIDocumentManagerNativCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerNativCustom : DXTestControl
	{
		public UIDocumentManagerNativCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DocumentManagerNative";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentManagerNative";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public UIDocumentsHostTabList1 UIDocumentsHostTabList
		{
			get
			{
				if ((this.mUIDocumentsHostTabList == null))
				{
					this.mUIDocumentsHostTabList = new UIDocumentsHostTabList1(this);
				}
				return this.mUIDocumentsHostTabList;
			}
		}
		#endregion
		#region Fields
		private UIDocumentsHostTabList1 mUIDocumentsHostTabList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentsHostTabList1 : DXTestControl
	{
		public UIDocumentsHostTabList1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DocumentManagerNativeDocumentsHost[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentsHost";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public UIDocument4Custom UIDocument4Custom
		{
			get
			{
				if ((this.mUIDocument4Custom == null))
				{
					this.mUIDocument4Custom = new UIDocument4Custom(this);
				}
				return this.mUIDocument4Custom;
			}
		}
		public DXTestControl UIDocument5Custom
		{
			get
			{
				if ((this.mUIDocument5Custom == null))
				{
					this.mUIDocument5Custom = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument5Custom.SearchProperties[DXTestControl.PropertyNames.Name] = "Document5";
					this.mUIDocument5Custom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentContainer";
					this.mUIDocument5Custom.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
					#endregion
				}
				return this.mUIDocument5Custom;
			}
		}
		#endregion
		#region Fields
		private UIDocument4Custom mUIDocument4Custom;
		private DXTestControl mUIDocument5Custom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument4Custom : DXTestControl
	{
		public UIDocument4Custom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentContainer";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public DXButton UIMaximizeButton
		{
			get
			{
				if ((this.mUIMaximizeButton == null))
				{
					this.mUIMaximizeButton = new DXButton(this);
					#region Search Criteria
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Maximize";
					this.mUIMaximizeButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "WindowTitleButton";
					this.mUIMaximizeButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
					#endregion
				}
				return this.mUIMaximizeButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIMaximizeButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonControl1Ribbon : DXRibbon
	{
		public UIRibbonControl1Ribbon(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public UIRibbonPage1RibbonPage UIRibbonPage1RibbonPage
		{
			get
			{
				if ((this.mUIRibbonPage1RibbonPage == null))
				{
					this.mUIRibbonPage1RibbonPage = new UIRibbonPage1RibbonPage(this);
				}
				return this.mUIRibbonPage1RibbonPage;
			}
		}
		#endregion
		#region Fields
		private UIRibbonPage1RibbonPage mUIRibbonPage1RibbonPage;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPage1RibbonPage : DXRibbonPage
	{
		public UIRibbonPage1RibbonPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPage1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPage";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public UIRibbonPageGroup1RibbonPageGroup UIRibbonPageGroup1RibbonPageGroup
		{
			get
			{
				if ((this.mUIRibbonPageGroup1RibbonPageGroup == null))
				{
					this.mUIRibbonPageGroup1RibbonPageGroup = new UIRibbonPageGroup1RibbonPageGroup(this);
				}
				return this.mUIRibbonPageGroup1RibbonPageGroup;
			}
		}
		#endregion
		#region Fields
		private UIRibbonPageGroup1RibbonPageGroup mUIRibbonPageGroup1RibbonPageGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPageGroup1RibbonPageGroup : DXRibbonPageGroup
	{
		public UIRibbonPageGroup1RibbonPageGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPageGroup1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPageGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
			#endregion
		}
		#region Properties
		public DXRibbonButtonItem UIAddNewDocumentRibbonBaseButtonItem
		{
			get
			{
				if ((this.mUIAddNewDocumentRibbonBaseButtonItem == null))
				{
					this.mUIAddNewDocumentRibbonBaseButtonItem = new DXRibbonButtonItem(this);
					#region Search Criteria
					this.mUIAddNewDocumentRibbonBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "biAddDocument";
					this.mUIAddNewDocumentRibbonBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonBaseButtonItem";
					this.mUIAddNewDocumentRibbonBaseButtonItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Native Documents");
					#endregion
				}
				return this.mUIAddNewDocumentRibbonBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXRibbonButtonItem mUIAddNewDocumentRibbonBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIApplicationUILayoutCWindow2 : DXWindow
	{
		public UIApplicationUILayoutCWindow2()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Application UI Layout Controls Demo (C# code) - Tabbed Documents";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIRibbonControl1Ribbon1 UIRibbonControl1Ribbon
		{
			get
			{
				if ((this.mUIRibbonControl1Ribbon == null))
				{
					this.mUIRibbonControl1Ribbon = new UIRibbonControl1Ribbon1(this);
				}
				return this.mUIRibbonControl1Ribbon;
			}
		}
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
		private UIRibbonControl1Ribbon1 mUIRibbonControl1Ribbon;
		private UIPanelControl1Client2 mUIPanelControl1Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonControl1Ribbon1 : DXRibbon
	{
		public UIRibbonControl1Ribbon1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIRibbonPage1RibbonPage1 UIRibbonPage1RibbonPage
		{
			get
			{
				if ((this.mUIRibbonPage1RibbonPage == null))
				{
					this.mUIRibbonPage1RibbonPage = new UIRibbonPage1RibbonPage1(this);
				}
				return this.mUIRibbonPage1RibbonPage;
			}
		}
		public UIImageComboBoxEditComboBox1 UIImageComboBoxEditComboBox
		{
			get
			{
				if ((this.mUIImageComboBoxEditComboBox == null))
				{
					this.mUIImageComboBoxEditComboBox = new UIImageComboBoxEditComboBox1(this);
				}
				return this.mUIImageComboBoxEditComboBox;
			}
		}
		#endregion
		#region Fields
		private UIRibbonPage1RibbonPage1 mUIRibbonPage1RibbonPage;
		private UIImageComboBoxEditComboBox1 mUIImageComboBoxEditComboBox;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPage1RibbonPage1 : DXRibbonPage
	{
		public UIRibbonPage1RibbonPage1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPage1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPage";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIRibbonPageGroup1RibbonPageGroup1 UIRibbonPageGroup1RibbonPageGroup
		{
			get
			{
				if ((this.mUIRibbonPageGroup1RibbonPageGroup == null))
				{
					this.mUIRibbonPageGroup1RibbonPageGroup = new UIRibbonPageGroup1RibbonPageGroup1(this);
				}
				return this.mUIRibbonPageGroup1RibbonPageGroup;
			}
		}
		public UIRibbonPageGroup2RibbonPageGroup UIRibbonPageGroup2RibbonPageGroup
		{
			get
			{
				if ((this.mUIRibbonPageGroup2RibbonPageGroup == null))
				{
					this.mUIRibbonPageGroup2RibbonPageGroup = new UIRibbonPageGroup2RibbonPageGroup(this);
				}
				return this.mUIRibbonPageGroup2RibbonPageGroup;
			}
		}
		public UIRibbonPageGroup3RibbonPageGroup1 UIRibbonPageGroup3RibbonPageGroup
		{
			get
			{
				if ((this.mUIRibbonPageGroup3RibbonPageGroup == null))
				{
					this.mUIRibbonPageGroup3RibbonPageGroup = new UIRibbonPageGroup3RibbonPageGroup1(this);
				}
				return this.mUIRibbonPageGroup3RibbonPageGroup;
			}
		}
		#endregion
		#region Fields
		private UIRibbonPageGroup1RibbonPageGroup1 mUIRibbonPageGroup1RibbonPageGroup;
		private UIRibbonPageGroup2RibbonPageGroup mUIRibbonPageGroup2RibbonPageGroup;
		private UIRibbonPageGroup3RibbonPageGroup1 mUIRibbonPageGroup3RibbonPageGroup;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPageGroup1RibbonPageGroup1 : DXRibbonPageGroup
	{
		public UIRibbonPageGroup1RibbonPageGroup1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPageGroup1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPageGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXRibbonButtonItem UIAddNewDocumentRibbonBaseButtonItem
		{
			get
			{
				if ((this.mUIAddNewDocumentRibbonBaseButtonItem == null))
				{
					this.mUIAddNewDocumentRibbonBaseButtonItem = new DXRibbonButtonItem(this);
					#region Search Criteria
					this.mUIAddNewDocumentRibbonBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.Name] = "biAddDocument";
					this.mUIAddNewDocumentRibbonBaseButtonItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonBaseButtonItem";
					this.mUIAddNewDocumentRibbonBaseButtonItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIAddNewDocumentRibbonBaseButtonItem;
			}
		}
		#endregion
		#region Fields
		private DXRibbonButtonItem mUIAddNewDocumentRibbonBaseButtonItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPageGroup2RibbonPageGroup : DXRibbonPageGroup
	{
		public UIRibbonPageGroup2RibbonPageGroup(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPageGroup2";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPageGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXRibbonEditItem UIOrientationRibbonEditItem
		{
			get
			{
				if ((this.mUIOrientationRibbonEditItem == null))
				{
					this.mUIOrientationRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUIOrientationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiOrientation";
					this.mUIOrientationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					this.mUIOrientationRibbonEditItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIOrientationRibbonEditItem;
			}
		}
		#endregion
		#region Fields
		private DXRibbonEditItem mUIOrientationRibbonEditItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIRibbonPageGroup3RibbonPageGroup1 : DXRibbonPageGroup
	{
		public UIRibbonPageGroup3RibbonPageGroup1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonPageGroup3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonPageGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXRibbonEditItem UILocationRibbonEditItem
		{
			get
			{
				if ((this.mUILocationRibbonEditItem == null))
				{
					this.mUILocationRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUILocationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiHeadeLocation";
					this.mUILocationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					this.mUILocationRibbonEditItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUILocationRibbonEditItem;
			}
		}
		public DXRibbonEditItem UIOrientationRibbonEditItem
		{
			get
			{
				if ((this.mUIOrientationRibbonEditItem == null))
				{
					this.mUIOrientationRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUIOrientationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiHeaderOrientation";
					this.mUIOrientationRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					this.mUIOrientationRibbonEditItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIOrientationRibbonEditItem;
			}
		}
		public DXRibbonEditItem UIShowCloseButtonRibbonEditItem
		{
			get
			{
				if ((this.mUIShowCloseButtonRibbonEditItem == null))
				{
					this.mUIShowCloseButtonRibbonEditItem = new DXRibbonEditItem(this);
					#region Search Criteria
					this.mUIShowCloseButtonRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.Name] = "beiClosePageButton";
					this.mUIShowCloseButtonRibbonEditItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "RibbonEditItem";
					this.mUIShowCloseButtonRibbonEditItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIShowCloseButtonRibbonEditItem;
			}
		}
		#endregion
		#region Fields
		private DXRibbonEditItem mUILocationRibbonEditItem;
		private DXRibbonEditItem mUIOrientationRibbonEditItem;
		private DXRibbonEditItem mUIShowCloseButtonRibbonEditItem;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIImageComboBoxEditComboBox1 : DXComboBox
	{
		public UIImageComboBoxEditComboBox1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1ImageComboBoxEdit[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "ImageComboBoxEdit";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIPopupImageComboBoxEdWindow2 UIPopupImageComboBoxEdWindow
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdWindow == null))
				{
					this.mUIPopupImageComboBoxEdWindow = new UIPopupImageComboBoxEdWindow2(this);
				}
				return this.mUIPopupImageComboBoxEdWindow;
			}
		}
		#endregion
		#region Fields
		private UIPopupImageComboBoxEdWindow2 mUIPopupImageComboBoxEdWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupImageComboBoxEdWindow2 : DXWindow
	{
		public UIPopupImageComboBoxEdWindow2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1ImageComboBoxEdit[0]PopupForm";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxForm";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIPopupImageComboBoxEdList2 UIPopupImageComboBoxEdList
		{
			get
			{
				if ((this.mUIPopupImageComboBoxEdList == null))
				{
					this.mUIPopupImageComboBoxEdList = new UIPopupImageComboBoxEdList2(this);
				}
				return this.mUIPopupImageComboBoxEdList;
			}
		}
		#endregion
		#region Fields
		private UIPopupImageComboBoxEdList2 mUIPopupImageComboBoxEdList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPopupImageComboBoxEdList2 : DXListBox
	{
		public UIPopupImageComboBoxEdList2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1ImageComboBoxEdit[0]PopupFormPopupImageComboBoxEditListBox[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBox";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXListBoxItem UIVerticalListItem
		{
			get
			{
				if ((this.mUIVerticalListItem == null))
				{
					this.mUIVerticalListItem = new DXListBoxItem(this);
					#region Search Criteria
					this.mUIVerticalListItem.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1ImageComboBoxEdit[0]PopupFormPopupImageComboBoxEditListBox[0]Item[1" +
						"]";
					this.mUIVerticalListItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					this.mUIVerticalListItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIVerticalListItem;
			}
		}
		public DXListBoxItem UIBottomListItem
		{
			get
			{
				if ((this.mUIBottomListItem == null))
				{
					this.mUIBottomListItem = new DXListBoxItem(this);
					#region Search Criteria
					this.mUIBottomListItem.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1ImageComboBoxEdit[0]PopupFormPopupImageComboBoxEditListBox[0]Item[3" +
						"]";
					this.mUIBottomListItem.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					this.mUIBottomListItem.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIBottomListItem;
			}
		}
		public DXListBoxItem UIVerticalListItem1
		{
			get
			{
				if ((this.mUIVerticalListItem1 == null))
				{
					this.mUIVerticalListItem1 = new DXListBoxItem(this);
					#region Search Criteria
					this.mUIVerticalListItem1.SearchProperties[DXTestControl.PropertyNames.Name] = "ribbonControl1ImageComboBoxEdit[0]PopupFormPopupImageComboBoxEditListBox[0]Item[2" +
						"]";
					this.mUIVerticalListItem1.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PopupImageComboBoxEditListBoxItem";
					this.mUIVerticalListItem1.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIVerticalListItem1;
			}
		}
		#endregion
		#region Fields
		private DXListBoxItem mUIVerticalListItem;
		private DXListBoxItem mUIBottomListItem;
		private DXListBoxItem mUIVerticalListItem1;
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
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIGcContainerClient3 UIGcContainerClient
		{
			get
			{
				if ((this.mUIGcContainerClient == null))
				{
					this.mUIGcContainerClient = new UIGcContainerClient3(this);
				}
				return this.mUIGcContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIGcContainerClient3 mUIGcContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIGcContainerClient3 : DXTestControl
	{
		public UIGcContainerClient3(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIDocumentManagerTabbeCustom UIDocumentManagerTabbeCustom
		{
			get
			{
				if ((this.mUIDocumentManagerTabbeCustom == null))
				{
					this.mUIDocumentManagerTabbeCustom = new UIDocumentManagerTabbeCustom(this);
				}
				return this.mUIDocumentManagerTabbeCustom;
			}
		}
		#endregion
		#region Fields
		private UIDocumentManagerTabbeCustom mUIDocumentManagerTabbeCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentManagerTabbeCustom : DXTestControl
	{
		public UIDocumentManagerTabbeCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DocumentManagerTabbedDocuments";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentManagerTabbedDocuments";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public UIDocumentsHostTabList2 UIDocumentsHostTabList
		{
			get
			{
				if ((this.mUIDocumentsHostTabList == null))
				{
					this.mUIDocumentsHostTabList = new UIDocumentsHostTabList2(this);
				}
				return this.mUIDocumentsHostTabList;
			}
		}
		#endregion
		#region Fields
		private UIDocumentsHostTabList2 mUIDocumentsHostTabList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocumentsHostTabList2 : DXTestControl
	{
		public UIDocumentsHostTabList2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "DocumentManagerTabbedDocumentsDocumentsHost[0]";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentsHost";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXTestControl UIDocument5TabPage
		{
			get
			{
				if ((this.mUIDocument5TabPage == null))
				{
					this.mUIDocument5TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument5TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document5";
					this.mUIDocument5TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument5TabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIDocument5TabPage;
			}
		}
		public UIDocument4Custom1 UIDocument4Custom
		{
			get
			{
				if ((this.mUIDocument4Custom == null))
				{
					this.mUIDocument4Custom = new UIDocument4Custom1(this);
				}
				return this.mUIDocument4Custom;
			}
		}
		public DXTestControl UIDocument2TabPage
		{
			get
			{
				if ((this.mUIDocument2TabPage == null))
				{
					this.mUIDocument2TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument2TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document2";
					this.mUIDocument2TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument2TabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIDocument2TabPage;
			}
		}
		public UIDocument4TabPage UIDocument4TabPage
		{
			get
			{
				if ((this.mUIDocument4TabPage == null))
				{
					this.mUIDocument4TabPage = new UIDocument4TabPage(this);
				}
				return this.mUIDocument4TabPage;
			}
		}
		public UIDocument0TabPage2 UIDocument0TabPage
		{
			get
			{
				if ((this.mUIDocument0TabPage == null))
				{
					this.mUIDocument0TabPage = new UIDocument0TabPage2(this);
				}
				return this.mUIDocument0TabPage;
			}
		}
		public DXTestControl UIDocument3TabPage
		{
			get
			{
				if ((this.mUIDocument3TabPage == null))
				{
					this.mUIDocument3TabPage = new DXTestControl(this);
					#region Search Criteria
					this.mUIDocument3TabPage.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
					this.mUIDocument3TabPage.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
					this.mUIDocument3TabPage.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIDocument3TabPage;
			}
		}
		public UIDocument3Custom UIDocument3Custom
		{
			get
			{
				if ((this.mUIDocument3Custom == null))
				{
					this.mUIDocument3Custom = new UIDocument3Custom(this);
				}
				return this.mUIDocument3Custom;
			}
		}
		public UIItem0Group4 UIItem0Group
		{
			get
			{
				if ((this.mUIItem0Group == null))
				{
					this.mUIItem0Group = new UIItem0Group4(this);
				}
				return this.mUIItem0Group;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIDocument5TabPage;
		private UIDocument4Custom1 mUIDocument4Custom;
		private DXTestControl mUIDocument2TabPage;
		private UIDocument4TabPage mUIDocument4TabPage;
		private UIDocument0TabPage2 mUIDocument0TabPage;
		private DXTestControl mUIDocument3TabPage;
		private UIDocument3Custom mUIDocument3Custom;
		private UIItem0Group4 mUIItem0Group;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument4Custom1 : DXTestControl
	{
		public UIDocument4Custom1(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentContainer";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXTestControl UIXtraUserControlCustom
		{
			get
			{
				if ((this.mUIXtraUserControlCustom == null))
				{
					this.mUIXtraUserControlCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUIXtraUserControlCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4XtraUserControl[0]";
					this.mUIXtraUserControlCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraUserControl";
					this.mUIXtraUserControlCustom.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIXtraUserControlCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIXtraUserControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument4TabPage : DXTestControl
	{
		public UIDocument4TabPage(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXButton UIDocument4Button
		{
			get
			{
				if ((this.mUIDocument4Button == null))
				{
					this.mUIDocument4Button = new DXButton(this);
					#region Search Criteria
					this.mUIDocument4Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Document4";
					this.mUIDocument4Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument4Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIDocument4Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument4Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument0TabPage2 : DXTestControl
	{
		public UIDocument0TabPage2(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentHeader";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXButton UIDocument0Button
		{
			get
			{
				if ((this.mUIDocument0Button == null))
				{
					this.mUIDocument0Button = new DXButton(this);
					#region Search Criteria
					this.mUIDocument0Button.SearchProperties[DXTestControl.PropertyNames.Name] = "Document0";
					this.mUIDocument0Button.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentCloseButton";
					this.mUIDocument0Button.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIDocument0Button;
			}
		}
		#endregion
		#region Fields
		private DXButton mUIDocument0Button;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIDocument3Custom : DXTestControl
	{
		public UIDocument3Custom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "DocumentContainer";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXTestControl UIXtraUserControlCustom
		{
			get
			{
				if ((this.mUIXtraUserControlCustom == null))
				{
					this.mUIXtraUserControlCustom = new DXTestControl(this);
					#region Search Criteria
					this.mUIXtraUserControlCustom.SearchProperties[DXTestControl.PropertyNames.Name] = "Document3XtraUserControl[0]";
					this.mUIXtraUserControlCustom.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraUserControl";
					this.mUIXtraUserControlCustom.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUIXtraUserControlCustom;
			}
		}
		#endregion
		#region Fields
		private DXTestControl mUIXtraUserControlCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItem0Group4 : DXTestControl
	{
		public UIItem0Group4(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "0";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientDocumentGroup";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
			#endregion
		}
		#region Properties
		public DXButton UICloseButton
		{
			get
			{
				if ((this.mUICloseButton == null))
				{
					this.mUICloseButton = new DXButton(this);
					#region Search Criteria
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.Name] = "Close";
					this.mUICloseButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "MdiClientTabCloseButton";
					this.mUICloseButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed Documents");
					#endregion
				}
				return this.mUICloseButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUICloseButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIApplicationUILayoutCWindow3 : DXWindow
	{
		public UIApplicationUILayoutCWindow3()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
			#endregion
		}
		#region Properties
		public UIPanelControl1Client3 UIPanelControl1Client
		{
			get
			{
				if ((this.mUIPanelControl1Client == null))
				{
					this.mUIPanelControl1Client = new UIPanelControl1Client3(this);
				}
				return this.mUIPanelControl1Client;
			}
		}
		#endregion
		#region Fields
		private UIPanelControl1Client3 mUIPanelControl1Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIPanelControl1Client3 : DXTestControl
	{
		public UIPanelControl1Client3(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
			#endregion
		}
		#region Properties
		public UIGcContainerClient4 UIGcContainerClient
		{
			get
			{
				if ((this.mUIGcContainerClient == null))
				{
					this.mUIGcContainerClient = new UIGcContainerClient4(this);
				}
				return this.mUIGcContainerClient;
			}
		}
		#endregion
		#region Fields
		private UIGcContainerClient4 mUIGcContainerClient;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIGcContainerClient4 : DXTestControl
	{
		public UIGcContainerClient4(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
			#endregion
		}
		#region Properties
		public UIStartupMDIDemosCustom UIStartupMDIDemosCustom
		{
			get
			{
				if ((this.mUIStartupMDIDemosCustom == null))
				{
					this.mUIStartupMDIDemosCustom = new UIStartupMDIDemosCustom(this);
				}
				return this.mUIStartupMDIDemosCustom;
			}
		}
		#endregion
		#region Fields
		private UIStartupMDIDemosCustom mUIStartupMDIDemosCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIStartupMDIDemosCustom : DXTestControl
	{
		public UIStartupMDIDemosCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "StartupMDIDemos";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TabbedMDIStart";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
			#endregion
		}
		#region Properties
		public UIXtraTabControl1TabList UIXtraTabControl1TabList
		{
			get
			{
				if ((this.mUIXtraTabControl1TabList == null))
				{
					this.mUIXtraTabControl1TabList = new UIXtraTabControl1TabList(this);
				}
				return this.mUIXtraTabControl1TabList;
			}
		}
		#endregion
		#region Fields
		private UIXtraTabControl1TabList mUIXtraTabControl1TabList;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraTabControl1TabList : DXTestControl
	{
		public UIXtraTabControl1TabList(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "xtraTabControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraTabControl";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
			#endregion
		}
		#region Properties
		public UIXtraTabPage1Client UIXtraTabPage1Client
		{
			get
			{
				if ((this.mUIXtraTabPage1Client == null))
				{
					this.mUIXtraTabPage1Client = new UIXtraTabPage1Client(this);
				}
				return this.mUIXtraTabPage1Client;
			}
		}
		#endregion
		#region Fields
		private UIXtraTabPage1Client mUIXtraTabPage1Client;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIXtraTabPage1Client : DXTestControl
	{
		public UIXtraTabPage1Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "xtraTabPage1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "XtraTabPage";
			this.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
			#endregion
		}
		#region Properties
		public DXButton UILaunchSampleButton
		{
			get
			{
				if ((this.mUILaunchSampleButton == null))
				{
					this.mUILaunchSampleButton = new DXButton(this);
					#region Search Criteria
					this.mUILaunchSampleButton.SearchProperties[DXTestControl.PropertyNames.Name] = "sbStart";
					this.mUILaunchSampleButton.SearchProperties[DXTestControl.PropertyNames.ClassName] = "SimpleButton";
					this.mUILaunchSampleButton.SearchProperties[DXTestControl.PropertyNames.HierarchyLevel] = "2";
					this.mUILaunchSampleButton.WindowTitles.Add("Application UI Layout Controls Demo (C# code) - Tabbed MDI Manager");
					#endregion
				}
				return this.mUILaunchSampleButton;
			}
		}
		#endregion
		#region Fields
		private DXButton mUILaunchSampleButton;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIItemWindow5 : WinWindow
	{
		public UIItemWindow5()
		{
			#region Search Criteria
			this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Context";
			this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32768";
			#endregion
		}
		#region Properties
		public UIContextMenu UIContextMenu
		{
			get
			{
				if ((this.mUIContextMenu == null))
				{
					this.mUIContextMenu = new UIContextMenu(this);
				}
				return this.mUIContextMenu;
			}
		}
		#endregion
		#region Fields
		private UIContextMenu mUIContextMenu;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
	public class UIContextMenu : WinMenu
	{
		public UIContextMenu(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[WinMenu.PropertyNames.Name] = "Context";
			#endregion
		}
		#region Properties
		public WinMenuItem UIFloatMenuItem
		{
			get
			{
				if ((this.mUIFloatMenuItem == null))
				{
					this.mUIFloatMenuItem = new WinMenuItem(this);
					#region Search Criteria
					this.mUIFloatMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Float";
					#endregion
				}
				return this.mUIFloatMenuItem;
			}
		}
		#endregion
		#region Fields
		private WinMenuItem mUIFloatMenuItem;
		#endregion
	}
}
