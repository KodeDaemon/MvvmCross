﻿#region Copyright

// <copyright file="MvxTouchTask.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using Cirrious.MvvmCross.Interfaces.Services;
using Cirrious.MvvmCross.Platform;

namespace Cirrious.MvvmCross.Touch.Services
{
    public class MvxTouchFileStoreService : MvxBaseFileStoreService
    {
		public const string ResScheme = "res:";
		
        protected override string FullPath(string path)
        {
			if (path.StartsWith(ResScheme))
				return path.Substring(ResScheme.Length);
			
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), path);
        }
    }
}