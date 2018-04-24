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
                    Url = "https://images.pexels.com/photos/771079/pexels-photo-771079.jpeg?cs=srgb&dl=backpack-clouds-cloudy-sky-771079.jpg&fm=jpg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },
                
                new GalleryImage()
                {
                    Title = "On the Trail",
                    Url = "https://images.pexels.com/photos/450597/pexels-photo-450597.jpeg?cs=srgb&dl=america-american-flag-architecture-450597.jpg&fm=jpg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                },

                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://images.pexels.com/photos/421927/pexels-photo-421927.jpeg?cs=srgb&dl=architecture-bridge-brooklyn-bridge-421927.jpg&fm=jpg",
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