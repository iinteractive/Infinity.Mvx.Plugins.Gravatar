using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Infinity.Mvx.Plugins.Gravatar.Test.Touch.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        private UIImageView _imageView;
        private MvxImageViewLoader _loader;

        public FirstView()
        {
        }

        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;
			   
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            _imageView =
                new UIImageView(new RectangleF(10, 50, 300, 300));
            Add(_imageView);

            _loader = new MvxImageViewLoader(() => _imageView);
            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(label).To(vm => vm.ImageUrl);
            set.Bind(_loader).To(vm => vm.ImageUrl);
            //_loader.ImageUrl = "http://www.gravatar.com/avatar/2b1b7ec270fca3c60bafe1975c55d9d0.jpg?s=100&d=mm";
            set.Apply();
        }
    }
}