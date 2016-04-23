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

namespace DevExpress.Win.FunctionalTests.UIMaps.UIMapForHandCodingTestsClasses
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
	[GeneratedCode("Coded UITest Builder", "10.0.40219.415")]
	public partial class UIMapForHandCodingTests
	{
		#region Properties
		public UIXtraGridFeaturesDemoWindow UIXtraGridFeaturesDemoWindow
		{
			get
			{
				if ((this.mUIXtraGridFeaturesDemoWindow == null))
				{
					this.mUIXtraGridFeaturesDemoWindow = new UIXtraGridFeaturesDemoWindow();
				}
				return this.mUIXtraGridFeaturesDemoWindow;
			}
		}
		#endregion
		#region Fields
		private UIXtraGridFeaturesDemoWindow mUIXtraGridFeaturesDemoWindow;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.415")]
	public class UIXtraGridFeaturesDemoWindow : DXWindow
	{
		public UIXtraGridFeaturesDemoWindow()
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "The XtraGrid Suite by DevExpress (C# code) - Table View";
			this.SearchProperties.Add(new PropertyExpression(DXTestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
			this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Table View");
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
	[GeneratedCode("Coded UITest Builder", "10.0.40219.415")]
	public class UIPanelControl1Client : DXTestControl
	{
		public UIPanelControl1Client(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "panelControl1";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "PanelControl";
			this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Table View");
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
	[GeneratedCode("Coded UITest Builder", "10.0.40219.415")]
	public class UIGcContainerClient : DXTestControl
	{
		public UIGcContainerClient(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "gcContainer";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "GroupControl";
			this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Table View");
			#endregion
		}
		#region Properties
		public UITableViewCustom UITableViewCustom
		{
			get
			{
				if ((this.mUITableViewCustom == null))
				{
					this.mUITableViewCustom = new UITableViewCustom(this);
				}
				return this.mUITableViewCustom;
			}
		}
		#endregion
		#region Fields
		private UITableViewCustom mUITableViewCustom;
		#endregion
	}
	[GeneratedCode("Coded UITest Builder", "10.0.40219.415")]
	public class UITableViewCustom : DXTestControl
	{
		public UITableViewCustom(UITestControl searchLimitContainer) : 
				base(searchLimitContainer)
		{
			#region Search Criteria
			this.SearchProperties[DXTestControl.PropertyNames.Name] = "TableView";
			this.SearchProperties[DXTestControl.PropertyNames.ClassName] = "TableView";
			this.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Table View");
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
					this.mUIGridControl1Table.WindowTitles.Add("The XtraGrid Suite by DevExpress (C# code) - Table View");
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
}
