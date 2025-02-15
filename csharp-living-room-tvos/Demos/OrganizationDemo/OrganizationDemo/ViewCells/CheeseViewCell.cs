// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using CoreGraphics;

namespace OrganizationDemo
{
	public partial class CheeseViewCell : UICollectionViewCell
	{
		#region UI Elements

		public UIImageView CheeseImage { get; set; }
		public UILabel CheeseName { get; set; }

		#endregion

		#region Properties

		CheeseDetail _cheeseDetail;
		public CheeseDetail TheCheese
		{
			get
			{
				return _cheeseDetail;
			}
			set
			{
				_cheeseDetail = value;

				if (!string.IsNullOrEmpty(_cheeseDetail.Image))
				{
					CheeseImage.Image = UIImage.FromBundle(_cheeseDetail.Image);
				}
				else {
					CheeseImage.Image = UIImage.FromBundle("Parmesan");
				}

				CheeseName.Text = _cheeseDetail.CheeseName;
			}
		}

		#endregion

		public CheeseViewCell(IntPtr handle) : base(handle)
		{
			CheeseImage = new UIImageView(new CGRect(0, 0, 525, 460));
			CheeseImage.AdjustsImageWhenAncestorFocused = true;
			CheeseImage.Layer.BorderWidth = (nfloat)4.0;
			CheeseImage.Layer.BorderColor = UIColor.Black.CGColor;

			AddSubview(CheeseImage);

			CheeseName = new UILabel(new CGRect(0, 470, 525, 100)) { TextAlignment = UITextAlignment.Center };
			CheeseName.TextColor = UIColor.White;
			CheeseName.Font = UIFont.PreferredBody;
			CheeseName.Alpha = 0f;

			AddSubview(CheeseName);
		}

	}
}
