using System.Collections.Generic;
using System.Web.Helpers;

namespace OCC.UI.Webhost.Models
{
    public class MetroTileViewModel
    {
        public MetroTileViewModel()
        {
            InitializeListProperties();
            DefaultTileIcon = new MetroTileIcon()
                              {
                                  PathUri = "../../Content/themes/Metro/Images/OnetugTree.113x132.AlphaBackground.png",
                                  AltText = "Orlando .NET User Group Logo",
                                  Title = "Orlando .NET User Group"
                              };
        }

        public virtual string TileDisplayName { get; set; }
        public virtual MetroTileIcon DefaultTileIcon { get; set; }
        public virtual IList<MetroTileIcon> MetroTileIcons { get; protected set; }
        public virtual string TileLinkActionName { get; set; }
        public virtual string TileLinkControllerName { get; set; }
        public virtual string TileBackgroundCssClass { get; set; }

        private void InitializeListProperties()
        {
            MetroTileIcons = new List<MetroTileIcon>();
        }
    }

    public  class DoubleMetroTileViewModel : MetroTileViewModel
    {
        public DoubleMetroTileViewModel()
        {
            DefaultTileIcon = new MetroTileIcon(65, 65)
                              {
                                  PathUri = "../../Content/themes/Metro/WhiteIcons/48x48/flag.png",
                                  AltText = "No Picture",
                                  Title = "No Picture"
                              };
        }

        public override MetroTileIcon DefaultTileIcon { get; set; }
    }

    public class TwitterMetroTileViewModel 
    {
        public TwitterMetroTileViewModel()
        {
            Tweets = new List<TweetViewModel>();
        }

        public IList<TweetViewModel> Tweets { get; set; }
        public string TileDisplayName { get; set; }
        public string TileBackgroundCssClass { get; set; }
    }

    public class TweetViewModel
    {
        public TweetViewModel()
        {
            ProfilePhoto = new MetroTileIcon(52, 52)
                           {
                               PathUri = "../../Content/themes/Metro/Images/twitter_newbird_white.png",
                               AltText = "Follow us on Twitter @ONETUG",
                               Title = "Follow us on Twitter @ONETUG"
                           };
            TweetContent = "Test tweet for #OrlandoCC with consumption of all 146 characters.  This is for the new Orlando Code Camp site that we are currently working.";/*"Follow us on Twitter @ONETUG or use the hashtag #OrlandoCC";*/
            ProfileName = "Hallmanac";
            ActiveCssClass = "tweetVisible";
        }
        
        public string TweetContent { get; set; }
        public MetroTileIcon ProfilePhoto { get; set; }
        public string ProfileName { get; set; }
        public string ActiveCssClass { get; set; }
    }

    public class MetroTileIcon
    {
        private readonly int maxHeight;
        private readonly int maxWidth;
        private WebImage image;

        public MetroTileIcon(int maxHeight = 110, int maxWidth = 128)
        {
            this.maxHeight = maxHeight;
            this.maxWidth = maxWidth;
        }

        private string pathUri;

        public string PathUri
        {
            get { return this.pathUri; }
            set
            {
                this.pathUri = value;
                this.image = new WebImage(this.pathUri);
                Height = HeightExceedsMax() ? this.maxHeight : this.image.Height;
                Width = WidthExceedsMax() ? this.maxWidth : this.image.Width;
            }
        }

        public string AltText { get; set; }
        public string Title { get; set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        private bool WidthExceedsMax()
        {
            var imageWidth = this.image.Width;
            return (this.image.Width > this.maxWidth);
        }

        private bool HeightExceedsMax()
        {
            var imageHeight = this.image.Height;
            return (this.image.Height > this.maxHeight);
        }
    }
}