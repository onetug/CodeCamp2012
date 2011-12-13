using System.Web.Mvc;
using OCC.UI.Webhost.CodeCampService;
using OCC.UI.Webhost.Models;

namespace OCC.UI.Webhost.Controllers
{
    public class MetroTileController : BaseController
    {
        private readonly MetroTileIcon defaultDoubleIcon = new MetroTileIcon(110, 278)
                                                           {
                                                               PathUri =
                                                                   "../../Content/themes/Metro/Images/twitter_newbird_white.png"
                                                           };

        private readonly MetroTileIcon defaultSingleIcon = new MetroTileIcon
                                                           {
                                                               PathUri =
                                                                   "../../Content/themes/Metro/Images/OnetugTree.113x132.AlphaBackground.png",
                                                               AltText = "@ONETUG Logo",
                                                               Title = "@ONETUG Logo"
                                                           };

        [ChildActionOnly]
        public PartialViewResult SingleMetroTileForAccount()
        {
            /* We'll probably want to check to see if the user is logged in and if so, show their 
             * profile picture as the main image on the tile (referencing a path to the "IconUri")
             * and then change the "TileDisplayName" to their username or first and last name. Also change
             * the tile's link to go to the users profile page instead of the login page.
             * 
             * An idea I had was to put a notification icon overlayed on their profile picture for times when
             * we need them to address an issue with their profile (i.e. T-shirt size, food requirements, etc).
             * 
             * Also might want to add some logic that checks to see if the retrieved image is larger than 
             * (height)110 x (width)128.  If it is larger than that, set the "IconHeight" and "IconWidth" to the max 
             * values of 110x128, otherwise set them to the height and width of the image.*/

            var tileViewModel = new MetroTileViewModel
                                {
                                    TileLinkActionName = "LogOn",
                                    TileLinkControllerName = "Account",
                                    TileDisplayName = "Login",
                                    TileBackgroundCssClass = "singleTileGreenImage",
                                    DefaultTileIcon = this.defaultSingleIcon
                                };
            tileViewModel.MetroTileIcons.Add(item: new MetroTileIcon
                                                   {
                                                       PathUri = "../../Content/themes/Shared/BlankUser.png",
                                                       AltText = "Login or sign up",
                                                       Title = "Login or Sign up"
                                                   });
            tileViewModel.MetroTileIcons.Add(new MetroTileIcon
                                             {
                                                 PathUri = "../../Content/themes/Shared/onetug.113x132.jpg",
                                                 AltText = "The only tug",
                                                 Title = "The only tug"
                                             });
            return PartialView("_SingleMetroTile", tileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult SingleMetroTileForSponsors()
        {
            var tileViewModel = new MetroTileViewModel
                                {
                                    TileLinkActionName = "Sponsors",
                                    TileLinkControllerName = "Home",
                                    TileDisplayName = "Sponsors",
                                    TileBackgroundCssClass = "singleTileGreenImage",
                                    DefaultTileIcon = this.defaultSingleIcon
                                };

                var sponsors = service.GetSponsors(1);
                foreach (var sponsor in sponsors)
                {
                    if (!string.IsNullOrEmpty(sponsor.Name) && !string.IsNullOrEmpty(sponsor.ImageUrl))
                    {
                        tileViewModel.MetroTileIcons.Add(new MetroTileIcon
                                                         {
                                                             PathUri = sponsor.ImageUrl,
                                                             AltText = sponsor.Name,
                                                             Title = sponsor.Name
                                                         });
                    }
                }

            return PartialView("_SingleMetroTile", tileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult SingleMetroTileForAgenda()
        {
            var tileViewModel = new MetroTileViewModel
                                {
                                    TileLinkActionName = "Agenda",
                                    TileLinkControllerName = "Home",
                                    TileDisplayName = "Agenda",
                                    TileBackgroundCssClass = "singleTileGreenImage",
                                    DefaultTileIcon = this.defaultSingleIcon
                                };

            return PartialView("_SingleMetroTile", tileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult SingleMetroTileForVenue()
        {
            var tileViewModel = new MetroTileViewModel
                                {
                                    TileLinkActionName = "Venue",
                                    TileLinkControllerName = "Home",
                                    TileDisplayName = "Venue",
                                    TileBackgroundCssClass = "singleTileGreenImage",
                                    DefaultTileIcon = this.defaultSingleIcon
                                };

            return PartialView("_SingleMetroTile", tileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult SingleMetroTileForSpeakers()
        {
            var tileViewModel = new MetroTileViewModel
                                {
                                    TileLinkActionName = "Speakers",
                                    TileLinkControllerName = "Home",
                                    TileDisplayName = "Speakers",
                                    TileBackgroundCssClass = "singleTileGreenImage",
                                    DefaultTileIcon = this.defaultSingleIcon
                                };

            return PartialView("_SingleMetroTile", tileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult SingleMetroTileForVolunteers()
        {
            var tileViewModel = new MetroTileViewModel
                                {
                                    TileLinkActionName = "Volunteers",
                                    TileLinkControllerName = "Home",
                                    TileDisplayName = "Volunteers",
                                    TileBackgroundCssClass = "singleTileGreenImage",
                                    DefaultTileIcon = this.defaultSingleIcon
                                };

            return PartialView("_SingleMetroTile", tileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult DoubleMetroTileForSessions()
        {
            var doubleTileViewModel = new DoubleMetroTileViewModel();

            return PartialView("_DoubleMetroTile", doubleTileViewModel);
        }

        [ChildActionOnly]
        public PartialViewResult DoubleMetroTileForTwitter()
        {
            var twitterTileViewModel = new TwitterMetroTileViewModel 
                                       {
                                           TileBackgroundCssClass = "doubleTileBlueImage",
                                           TileDisplayName = "#OrlandoCC"
                                       };

            //insert some logic to go get tweets with the #OrlandoCC hashtag or tweets mentioning @ONETUG or tweets that @ONETUG puts out

            //If no data is returned from the twitter stream create two default tweets
            if (twitterTileViewModel.Tweets.Count < 1)
            {
                twitterTileViewModel.Tweets.Add(new TweetViewModel());
                twitterTileViewModel.Tweets.Add(new TweetViewModel());
            }

            return PartialView("_TwitterMetroTile", twitterTileViewModel);
        }
    }
}