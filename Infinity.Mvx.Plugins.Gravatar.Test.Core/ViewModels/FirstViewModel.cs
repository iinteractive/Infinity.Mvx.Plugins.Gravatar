using Cirrious.MvvmCross.ViewModels;

namespace Infinity.Mvx.Plugins.Gravatar.Test.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly IMvxGravatarTask _gravatarTask;
        public FirstViewModel(IMvxGravatarTask gravatarTask)
        {
            _gravatarTask = gravatarTask;
        }
        public string ImageUrl
		{ 
			get { return _gravatarTask.CreateGravatarUrl("sean.sparkman@gmail.com", 100).ToString(); }
		}
    }
}
