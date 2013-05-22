using System.Collections.Generic;
using Nancy;
using Showdown.Model;

namespace Showdown.Nancy.Modules
{
	public class ReviewModule : BaseModule
	{
		public static List<Restaurant> Restaurants { get; set; }
		
		public ReviewModule() : base("review")
		{
			Get["/list/{id?}"] =
				parameter =>
				{
					return View["/Reviews/Index" ,GetRestaurants()];
				};

			Post["/create"] =
				parameter =>
				{
					var restaurantId = Request.Form["restaurant"];
					var review = Request.Form["new-review"];
					var id = 1;
					
					return Response.AsRedirect("/review/list/" + id);
				};

			Delete["/delete/{id}"] =
				parameter =>
				{
					return View["/Reviews/Index"];
				};
		}

		private static List<Restaurant> GetRestaurants ()
			{
			return Restaurants = new List<Restaurant>
								 {
									 new Restaurant
									 {
										 Id = 1,
										 Name = "Restaurant 1",
										 Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 2,
										 Name = "Restaurant 2",
										 Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 3,
										 Name = "Restaurant 3",
										 Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 4,
										 Name = "Restaurant 4 ",
										 Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 5,
										 Name = "Restaurant 5 ",
										 Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 }
								 };
			}
	}
}