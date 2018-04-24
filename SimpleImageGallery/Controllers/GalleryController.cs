using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Models;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3 });

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://www.pexels.com/photo/three-people-hiking-on-high-mountain-771079/",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                
                new GalleryImage()
                {
                    Title = "On the Trail",
                    Url = "https://www.pexels.com/photo/america-american-flag-architecture-bridge-450597/",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                },

                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://www.pexels.com/photo/architecture-art-clouds-landmark-290386/",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }

            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}