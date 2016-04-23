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
namespace DevExpress.Win.FunctionalTests {
	[CodedUITest]
	public class GridLookUpEditorTests {
		public GridLookUpEditorTests() {
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridLookUpEditorValueViaNextButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.ChangeGridLookUpEditorValueViaButtonNext();
				this.UIMap.CheckChangedGridLookUpEditorValueViaButtonNext();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridLookUpEditorValueViaPreviousButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.ChangeGridLookUpEditorValueViaButtonNext();
				this.UIMap.ChangeGridLookUpEditorValueViaButtonPrevious();
				this.UIMap.CheckChangedGridLookUpEditorValueViaButtonPrevious();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridLookUpEditorValueViaEndButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.ChangeGridLookUpEditorValueViaButtonLast();
				this.UIMap.CheckChangedGridLookUpEditorValueViaButtonLast();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridLookUpEditorValueViaFirstButtonTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.ChangeGridLookUpEditorValueViaMouse();
				this.UIMap.ChangeGridLookUpEditorValueViaButtonNext();
				this.UIMap.ChangeGridLookUpEditorValueViaButtonFirst();
				this.UIMap.CheckChangedGridLookUpEditorValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridLookUpEditorValueViaMouseTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.ChangeGridLookUpEditorValueViaMouse();
				this.UIMap.CheckChangedGridLookUpEditorValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeGridLookUpEditorValueViaKeyboardTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.ChangeGridLookUpEditorValueViaKeyboard();
				this.UIMap.CheckChangedGridLookUpEditorValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeInPlaceGridLookUpEditorValueViaMouseTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.SwitchGridLookUpEditorDemoModuleToInPlaceTab();
				this.UIMap.ChangeInPlaceGridLookUpEditorValueViaMouse();
				this.UIMap.CheckChangedInPlaceGridLookUpEditorValue();
			}
		}
		[Timeout(TestInitializer.timeOut), TestCategory("WorkOnFarm"), TestCategory("GridEditorsNavBar"), TestCategory("VS11"), TestMethod]
		public void ChangeInPlaceGridLookUpEditorValueViaKeyboardTest() {
			using(new GridsTestInitializer()) {
				this.UIMap.SwitchToGridLookUpEditorDemoModule();
				this.UIMap.SwitchGridLookUpEditorDemoModuleToInPlaceTab();
				this.UIMap.ChangeInPlaceGridLookUpEditorValueViaKeyboard();
				this.UIMap.CheckChangedInPlaceGridLookUpEditorValue();
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
