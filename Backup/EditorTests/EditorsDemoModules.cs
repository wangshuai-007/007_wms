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
using System.Linq;
using System.Text;
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
using Microsoft.VisualStudio.TestTools.UITesting;
namespace DevExpress.Win.FunctionalTests.EditorsTests
{
	public class EditorsDemoModules
	{
		public class GroupNames
		{
			public const string MiltiPurpose = "Multi-Purpose";
		}
		public class ModuleNames
		{
			public const string ListBox = "List Box";
		}
		static string[] ModuleNamePostfixes = { 
										   " (updated)" 
									   };
		public static void SwitchToDemoModule(DXTestControl accordionControl, string groupName, string moduleName)
		{
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
		}
	}
}
