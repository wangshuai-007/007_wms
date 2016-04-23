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
using DevExpress.CodedUIExtension.DXTestControls.v15_2;
using DevExpress.Win.FunctionalTests.UIMaps.LayoutControlUIMapClasses;
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class LayoutControlTests {
		public LayoutControlTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void AutoChangeTabInNwindEmployeesDemoModuleTest() {
			using(new LayoutTestInitializer()) {
				this.LayoutControlUIMap.SwitchToNwindEmployeesDemoModule();
				this.LayoutControlUIMap.ChangeMemoEditTextInNoteTab();
				this.LayoutControlUIMap.CheckChangedMemoEditValue();
				this.LayoutControlUIMap.CheckNoteTabSelectedState();
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("REWRITE"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void AutoChangeTabInCarsExampleDemoModuleTest() {
			using(new LayoutTestInitializer()) {
			}
		}
		[Timeout(TestInitializer.timeOutForSlowTests), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void AutoExpandGroupInMasterDetailDemoModuleTest() {
			using(new LayoutTestInitializer()) {
				this.LayoutControlUIMap.SwitchToMasterDetailDemoModule();
				this.LayoutControlUIMap.CollapseAllGroupInMasterDetailDemoModule();
				this.LayoutControlUIMap.CheckAllGroupCollapsedStateInMasterDetailDemoModule();
				this.LayoutControlUIMap.ChangeValuesInCategoriesGroup();
				this.LayoutControlUIMap.CheckCategoriesGroupExpandedState();
				this.LayoutControlUIMap.CheckChangedValuesInCategoriesGroup();
				this.LayoutControlUIMap.ChangeValuesInProductsGroup();
				this.LayoutControlUIMap.CheckProductsGroupExpandedState();
				this.LayoutControlUIMap.CheckChangedValuesInProductsGroup();
				this.LayoutControlUIMap.ChangeValuesInOrderDetailGroup();
				this.LayoutControlUIMap.CheckOrderDetailGroupExpandedState();
				this.LayoutControlUIMap.CheckChangedValuesInOrderDetailGroup();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("REWRITE"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void AutoExpandGroupForAssertionInValidatingDemoModuleTest() {
			using(new LayoutTestInitializer()) {
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("PrintingReportsLayout"), TestCategory("VS11"), TestMethod]
		public void ChangeLayoutItemsSizeViaSplitterTest() {
			using(new LayoutTestInitializer()) {
				this.LayoutControlUIMap.SwitchToItemsVisibilityDemoModule();
				DXTestControl pictureLeft = UILayoutControlMap.UIXtraLayoutFeaturesDeWindow3.UIPanelControl1Client.UIGcContainerClient.UIItemsVisibilityCustom.UILayoutControl1Custom.UILayoutControlGroup1LayoutGroup.UIPicture1ItemLayoutControlItem.UIPictureEdit2Image;
				DXTestControl pictureRight = UILayoutControlMap.UIXtraLayoutFeaturesDeWindow3.UIPanelControl1Client.UIGcContainerClient.UIItemsVisibilityCustom.UILayoutControl1Custom.UILayoutControlGroup1LayoutGroup.UIPicture2ItemLayoutControlItem.UIPictureEdit1Image;
				DXTextEdit memo = UILayoutControlMap.UIXtraLayoutFeaturesDeWindow3.UIPanelControl1Client.UIGcContainerClient.UIItemsVisibilityCustom.UILayoutControl1Custom.UILayoutControlGroup1LayoutGroup.UIDescriptionItemLayoutControlItem.UIMemoEdit1Edit;
				Size oldLeftPictureSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)pictureLeft.GetProperty("Size"), typeof(Size).FullName);
				Size oldRightPictureSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)pictureRight.GetProperty("Size"), typeof(Size).FullName);
				this.LayoutControlUIMap.MoveHorizontalSplitterToLeft();
				Size newLeftPictureSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)pictureLeft.GetProperty("Size"), typeof(Size).FullName);
				Size newRightPictureSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)pictureRight.GetProperty("Size"), typeof(Size).FullName);
				Size oldBottomMemoEditSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)memo.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newLeftPictureSize.Width < oldLeftPictureSize.Width);
				Assert.IsTrue(newRightPictureSize.Width > oldRightPictureSize.Width);
				Assert.AreEqual(newLeftPictureSize.Height, oldLeftPictureSize.Height);
				Assert.AreEqual(newRightPictureSize.Height, oldRightPictureSize.Height);
				this.LayoutControlUIMap.MoveVerticalSplitterToBottom();
				Size newBottomMemoEditSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)memo.GetProperty("Size"), typeof(Size).FullName);
				newLeftPictureSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)pictureLeft.GetProperty("Size"), typeof(Size).FullName);
				newRightPictureSize = (Size)DevExpress.Utils.CodedUISupport.CodedUIUtils.ConvertFromString((String)pictureRight.GetProperty("Size"), typeof(Size).FullName);
				Assert.IsTrue(newBottomMemoEditSize.Height < oldBottomMemoEditSize.Height);
				Assert.IsTrue(newLeftPictureSize.Height > oldLeftPictureSize.Height);
				Assert.IsTrue(newRightPictureSize.Height > oldRightPictureSize.Height);
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
		public LayoutControlUIMap UILayoutControlMap {
			get {
				if((this.map == null)) {
					this.map = new LayoutControlUIMap();
				}
				return this.map;
			}
		}
		private LayoutControlUIMap map;
		public LayoutControlUIMap LayoutControlUIMap {
			get {
				if((this.map == null)) {
					this.map = new LayoutControlUIMap();
				}
				return this.map;
			}
		}
	}
}
