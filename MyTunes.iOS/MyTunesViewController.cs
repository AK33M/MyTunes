using UIKit;
using System.Linq;

namespace MyTunes
{
	public class MyTunesViewController : UITableViewController
	{
		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			if (UIDevice.CurrentDevice.CheckSystemVersion(7,0)) {
				TableView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);
			}
		}

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//TableView.Source = new ViewControllerSource<string>(TableView) {
			//	DataSource = new string[] { "One", "Two", "Three" },
			//};

			var songList = await SongLoader.Load();

			var viewControllerSource = new ViewControllerSource<Song>(TableView)
			{
				DataSource = songList.ToList(),
				TextProc = (arg) => arg.Name,
				DetailTextProc = (arg) => $"{arg.Artist} - {arg.Album}"
			};

			TableView.Source = viewControllerSource;
		}
	}

}

