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

using System.IO;
using System.Linq;

namespace DGrok.Framework {
	public class FileLoader : IFileLoader {
		public FileLoader(bool ignoreMissingFiles, params string[] includes) {
			IgnoreMissingFiles = ignoreMissingFiles;
			Includes = includes;
		}

		public bool IgnoreMissingFiles { get; }
		public string[] Includes { get; }

		public string ExpandFileName(string currentDirectory, string fileName) {
			var filePath = Path.Combine(currentDirectory, fileName);
			if(File.Exists(filePath)) return filePath;

			return Includes.Select(x => Path.Combine(x, fileName)).FirstOrDefault(x => File.Exists(x)) ?? filePath;
		}
		public string Load(string fileName) {
			return File.Exists(fileName) || !IgnoreMissingFiles ? File.ReadAllText(fileName) : "";
		}
	}
}
