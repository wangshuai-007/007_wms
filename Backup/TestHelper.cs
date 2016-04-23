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
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace DevExpress.Win.FunctionalTests {
	public abstract class TestInitializer : IDisposable {
		Process process;
		public const Int32 timeOut = 70000;
		public const Int32 timeOutForSlowTests = 100000;
		public const Int32 timeOutForHandCodedTests = 120000;
		protected string GetBasePath() {
			Assembly asm = Assembly.GetExecutingAssembly();
			String temp = asm.CodeBase;
			temp = temp.Substring(8);
			temp = System.IO.Path.GetDirectoryName(temp);
			if(temp.Contains("TestResults")) {
				temp = temp.Substring(0, temp.IndexOf("TestResults") - 1);
				temp += @"\..";
			}
			return temp;
		}
		public void Start(string path) {
			string fileName = System.IO.Path.GetFileName(path);
			string realPath = GetBasePath() + @"\" + fileName;
			if(!System.IO.File.Exists(realPath)) {
				System.Diagnostics.Debug.WriteLine("Could not find:" + realPath);
				if(System.IO.Directory.Exists(GetBasePath() + @"\..\..\dlls\"))
					realPath = GetBasePath() + @"\..\..\dlls\" + fileName;
				else realPath = GetBasePath() + @"\..\..\" + fileName;
			}
			if(!System.IO.File.Exists(realPath)) {
				System.Diagnostics.Debug.WriteLine("Could not find:" + realPath);
				realPath = GetBasePath() + @"\..\..\" + path;
				if(!System.IO.File.Exists(realPath)) {
					System.Diagnostics.Debug.WriteLine("Could not find:" + realPath);
					realPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\DXperience " + AssemblyInfo.VersionShort + @" Demos\WinForms\Xtra";
					switch(fileName) {
						case "EditorsTutorials.exe": {
								realPath += "Editors";
								break;
							}
						case "GridMainDemo.exe": {
								realPath += "Grid";
								break;
							}
						case "NavBarMainDemo.exe": {
								realPath += "NavBar";
								break;
							}
						case "SimplePad.exe":
						case "BarTutorials.exe":
						case "RibbonSimplePad.exe":
						case "DockingDemo.exe": {
								realPath += "Bars";
								break;
							}
						case "PrintingMainDemo.exe": {
								realPath += "Printing";
								break;
							}
						case "VertGridTutorials.exe":
						case "VertGridMainDemo.exe": {
								realPath += "VerticalGrid";
								break;
							}
						case "TreeListTutorials.exe":
						case "TreeListMainDemo.exe": {
								realPath += "TreeList";
								break;
							}
						case "LayoutMainDemo.exe": {
								realPath += "Layout";
								break;
							}
					}
					realPath += @"\Bin\" + fileName;
				}
			}
			process = Process.Start(realPath);
			do {
				Application.DoEvents();
			} while(process.MainWindowHandle == IntPtr.Zero);
			const short SWP_NOZORDER = 0X4;
			const int SWP_SHOWWINDOW = 0x0040;
			SetWindowPos(process.MainWindowHandle, 0, 0, 0, 900, 700, SWP_NOZORDER | SWP_SHOWWINDOW);
		}
		[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
		public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
		void IDisposable.Dispose() {
			process.Kill();
		}
	}
	public class EditorsTestInitializer : TestInitializer {
		public EditorsTestInitializer() {
			Start(@"Demos.Win\EditorsDemos\CS\EditorsMainDemo\bin\Debug\EditorsMainDemo.exe");
		}
	}
	public class NavBarsTestInitializer : TestInitializer {
		public NavBarsTestInitializer() {
			Start(@"Demos.Win\NavBarDemos\CS\NavBarMainDemo\bin\Debug\NavBarMainDemo.exe");
		}
	}
	public class SimplePadTestInitializer : TestInitializer {
		public SimplePadTestInitializer() {
			Start(@"Demos.Win\BarDemos\CS\SimplePad\bin\Debug\SimplePad.exe");
		}
	}
	public class RibbonSimplePadTestInitializer : TestInitializer {
		public RibbonSimplePadTestInitializer() {
			Start(@"Demos.Win\BarDemos\CS\RibbonSimplePad\bin\Debug\RibbonSimplePad.exe");
		}
	}
	public class DockingDemoTestInitializer : TestInitializer {
		public DockingDemoTestInitializer() {
			Start(@"Demos.Win\BarDemos\CS\DockingDemo\bin\Debug\DockingDemo.exe");
		}
	}
	public class ApplicationUITestInitializer : TestInitializer {
		public ApplicationUITestInitializer() {
			Start(@"Demos.Win\ApplicationUIDemos\CS\ApplicationUIMainDemo\bin\Debug\ApplicationUIMainDemo.exe");
		}
	}
	public class PrintPreviewTestInitializer : TestInitializer {
		public PrintPreviewTestInitializer() {
			Start(@"Demos.Win\PrintSystemDemos\CS\PrintingMainDemo\bin\Debug\PrintingMainDemo.exe");
		}
	}
	public class GridsTestInitializer : TestInitializer {
		public GridsTestInitializer() {
			Start(@"Demos.Win\GridDemos\CS\GridMainDemo\bin\Debug\GridMainDemo.exe");
		}
	}
	public class VerticalGridTestInitializer : TestInitializer {
		protected const string verticalGridDemoTutorials = "verticalgridDemoTutorials";
		protected const string verticalGridFeaturesDemo = "verticalGridFeaturesDemo";
		public VerticalGridTestInitializer(string demo) {
			switch(demo) {
				case verticalGridDemoTutorials:
					Start(@"Demos.Win\VertGridDemos\CS\VertGridTutorials\bin\Debug\VertGridTutorials.exe");
					break;
				case verticalGridFeaturesDemo:
					Start(@"Demos.Win\VertGridDemos\CS\VertGridMainDemo\bin\Debug\VertGridMainDemo.exe");
					break;
			}
		}
	}
	public class TreeListTestInitializer : TestInitializer {
		protected const string treeListTutorials = "treeListTutorials";
		protected const string treeListMainDemo = "treeListMainDemo";
		public TreeListTestInitializer(string demo) {
			switch(demo) {
				case treeListTutorials:
					Start(@"Demos.Win\TreeListDemos\CS\TreeListTutorials\bin\Debug\TreeListTutorials.exe");
					break;
				case treeListMainDemo:
					Start(@"Demos.Win\TreeListDemos\CS\TreeListMainDemo\bin\Debug\TreeListMainDemo.exe");
					break;
			}
		}
	}
	public class LayoutTestInitializer : TestInitializer {
		public LayoutTestInitializer() {
			Start(@"Demos.Win\LayoutDemos\CS\LayoutMainDemo\bin\Debug\LayoutMainDemo.exe");
		}
	}
	public class PivotGridTestInitializer : TestInitializer {
		public PivotGridTestInitializer() {
			Start(@"Demos.Win\PivotGridDemos\CS\PivotGridMainDemo\bin\Debug\PivotGridMainDemo.exe");
		}
	}
}
