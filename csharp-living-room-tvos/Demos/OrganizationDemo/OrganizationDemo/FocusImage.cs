﻿using System;
using System.ComponentModel;
using Foundation;
using UIKit;

namespace OrganizationDemo
{
	[Register("FocusImage"), DesignTimeVisible()]
	public class FocusImage : UIImageView
	{
		public FocusImage()
		{
		}

		public FocusImage(IntPtr handle) : base(handle)
		{
			InitializeDisplay();
		}

		void InitializeDisplay()
		{
			UserInteractionEnabled = true;
			AdjustsImageWhenAncestorFocused = true;
		}

		public override bool CanBecomeFocused
		{
			get
			{
				return true;
			}
		}
	}
}


