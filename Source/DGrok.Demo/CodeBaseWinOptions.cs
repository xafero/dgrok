// Copyright (c) 2007-2014 Joe White
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using DGrok.Framework;
using Microsoft.Win32;

namespace DGrok.Demo {
	public class CodeBaseWinOptions : CodeBaseOptions {

		#pragma warning disable CA1416

		public void LoadFromRegistry() {
			using(RegistryKey key = Registry.CurrentUser.OpenSubKey(@"DGrok\Demo")) {
				if(key == null)
					return;
				CompilerOptionsSetOff = key.GetValue("CompilerOptionsSetOff", "").ToString();
				CompilerOptionsSetOn = key.GetValue("CompilerOptionsSetOn", "").ToString();
				CustomDefines = key.GetValue("CustomDefines", "").ToString();
				DelphiVersionDefine = key.GetValue("DelphiVersionDefine", "").ToString();
				FalseIfConditions = key.GetValue("FalseIfConditions", "").ToString();
				FileMasks = key.GetValue("FileMasks", DefaultFileMasks).ToString();
				ParserThreadCount = (int)key.GetValue("ParserThreadCount", Environment.ProcessorCount);
				SearchPaths = key.GetValue("SearchPaths", "").ToString();
				TrueIfConditions = key.GetValue("TrueIfConditions", "").ToString();
			}
		}
		public void SaveToRegistry() {
			using(RegistryKey key = Registry.CurrentUser.CreateSubKey(@"DGrok\Demo")) {
				key.SetValue("CompilerOptionsSetOff", CompilerOptionsSetOff);
				key.SetValue("CompilerOptionsSetOn", CompilerOptionsSetOn);
				key.SetValue("CustomDefines", CustomDefines);
				key.SetValue("DelphiVersionDefine", DelphiVersionDefine);
				key.SetValue("FalseIfConditions", FalseIfConditions);
				key.SetValue("FileMasks", FileMasks);
				key.SetValue("ParserThreadCount", ParserThreadCount);
				key.SetValue("SearchPaths", SearchPaths);
				key.SetValue("TrueIfConditions", TrueIfConditions);
			}
		}

		#pragma warning restore CA1416
	}
}
