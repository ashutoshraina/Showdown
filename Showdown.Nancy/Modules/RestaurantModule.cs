using System.Collections.Generic;
using Nancy;
using Showdown.Model;
using System.Linq;

namespace Showdown.Nancy.Modules
{
	public class RestaurantModule : BaseModule
	{
		public static List<Restaurant> Restaurants { get; set; }

		public RestaurantModule()
			: base("restaurant")
		{
			Get["/list/{id?}"] =
				parameter =>
				{
					return View["/Restaurants/Index", GetRestaurants()];
				};

			Get["/create"] =
				parameter =>
				{
					return View["/Restaurants/Create"];
				};

			Post["/create"] =
				parameter =>
				{
					var foo = Request.Files.Count();

					return View["/Restaurants/Create"];
				};

			Delete["/delete/{id}"] =
				parameter =>
				{
					var id = parameter.id;
					return Response.AsRedirect("/restaurant/list/" + (string) id);
				};
		}

		private static List<Restaurant> GetRestaurants ()
			{
			return Restaurants = new List<Restaurant>
								 {
									 new Restaurant
									 {
										 Id = 1, Name = "Restaurant 1", Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 2, Name = "Restaurant 2", Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 3, Name = "Restaurant 3", Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 1,
										 Name = "Restaurant 4 ",
										 Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 },
									 new Restaurant
									 {
										 Id = 1, Name = "Restaurant 5 ", Address = "Flat # 201 , Plot # 266 , Sector # 28 , Vashi",
										 UsefulLinks = new List<string> {"http://google.com", "http://yahoo.com"},
										 PhoneNumber = new List<string> {"+91-9699090749", "+91-020-6453245"},
										 Review = new List<Review> { new Review {Id = 1, Rating = 4, Content = "My awesome review" }}
									 }
								 };
			}
	}
}