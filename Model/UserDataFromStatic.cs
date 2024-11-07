namespace BlazorLabbv3
{
	public class UserDataFromStatic : IUserData
	{
		public async Task<List<User>> GetUsersAsync()
		{
			var users = Task.Run(GetUsers);
			return await users;
		}
		private List<User> GetUsers()
		{
			var users = new List<User>();
			users.Add(
				new User
				{
					id = 1,
					name = "Lukas Malki",
					username = "lukii2003",
					email = "lukas@iths.se",
					address = new Address
					{
						street = "Småbrukets backe",
						suite = "5 star suite",
						city = "Huddinge",
						zipcode = "141 58",
						geo = new Geo
						{
							lat = 12317.341,
							lng = -834278.4
						}
					},
					phone = "07070707070",
					website = "blazorlabb.com",
					company = new Company
					{
						name = "blazorExpert",
						catchPhrase = "expert in blaazor",
						bs = "blazor king"
					}

			});
			users.Add(
				new User
				{
					id = 2,
					name = "Alice Mendez",
					username = "alicia22",
					email = "alice.mendez@techworld.com",
					address = new Address
					{
						street = "Sunset Boulevard",
						suite = "Penthouse 24B",
						city = "Los Angeles",
						zipcode = "90028",
						geo = new Geo
						{
							lat = 34.0522,
							lng = -118.2437
						}
					},
					phone = "213-555-1234",
					website = "techworld.com",
					company = new Company
					{
						name = "TechWorld Innovations",
						catchPhrase = "Innovating the future",
						bs = "futuristic tech"
					}
				});

			users.Add(
				new User
				{
					id = 3,
					name = "John Doe",
					username = "johnny_d",
					email = "johndoe@gmail.com",
					address = new Address
					{
						street = "Elm Street",
						suite = "Suite 13",
						city = "Springfield",
						zipcode = "62704",
						geo = new Geo
						{
							lat = 39.7817,
							lng = -89.6501
						}
					},
					phone = "217-555-9876",
					website = "johndoe.com",
					company = new Company
					{
						name = "Doe Enterprises",
						catchPhrase = "Excellence in everything",
						bs = "business solutions"
					}
				});

			users.Add(
				new User
				{
					id = 4,
					name = "Samantha Green",
					username = "sammy_grn",
					email = "sam.green@greenfields.com",
					address = new Address
					{
						street = "Greenfield Avenue",
						suite = "Garden Suite 21",
						city = "Chicago",
						zipcode = "60611",
						geo = new Geo
						{
							lat = 41.8781,
							lng = -87.6298
						}
					},
					phone = "312-555-2244",
					website = "greenfields.com",
					company = new Company
					{
						name = "Green Fields Corp.",
						catchPhrase = "Green energy, better tomorrow",
						bs = "sustainable solutions"
					}
				});

			users.Add(
				new User
				{
					id = 5,
					name = "Mike Johnson",
					username = "mike_j90",
					email = "mike.johnson@techhub.com",
					address = new Address
					{
						street = "Techpark Road",
						suite = "TechHub Building 2A",
						city = "San Francisco",
						zipcode = "94105",
						geo = new Geo
						{
							lat = 37.7749,
							lng = -122.4194
						}
					},
					phone = "415-555-3456",
					website = "techhub.com",
					company = new Company
					{
						name = "TechHub Solutions",
						catchPhrase = "Technology that matters",
						bs = "cutting-edge tech"
					}
				});

			users.Add(
				new User
				{
					id = 6,
					name = "Emma Riley",
					username = "emmar_88",
					email = "emma.riley@rileycorp.com",
					address = new Address
					{
						street = "Main Street",
						suite = "Suite 2B",
						city = "Austin",
						zipcode = "73301",
						geo = new Geo
						{
							lat = 30.2672,
							lng = -97.7431
						}
					},
					phone = "512-555-1122",
					website = "rileycorp.com",
					company = new Company
					{
						name = "Riley Corporation",
						catchPhrase = "Driving growth through innovation",
						bs = "enterprise solutions"
					}
				});

			users.Add(
				new User
				{
					id = 7,
					name = "David O'Connor",
					username = "docon",
					email = "david.oconnor@occovation.com",
					address = new Address
					{
						street = "Oakwood Lane",
						suite = "Occovation Tower, 7th Floor",
						city = "New York",
						zipcode = "10005",
						geo = new Geo
						{
							lat = 40.7128,
							lng = -74.0060
						}
					},
					phone = "212-555-3434",
					website = "occovation.com",
					company = new Company
					{
						name = "Occovation Tech",
						catchPhrase = "Innovative solutions for modern businesses",
						bs = "advanced software"
					}
				});

			users.Add(
				new User
				{
					id = 8,
					name = "Sophia Lee",
					username = "sophie_lee",
					email = "sophia.lee@techgiant.com",
					address = new Address
					{
						street = "Silicon Valley Road",
						suite = "SV Building, 5th Floor",
						city = "Palo Alto",
						zipcode = "94301",
						geo = new Geo
						{
							lat = 37.4419,
							lng = -122.143
						}
					},
					phone = "650-555-6789",
					website = "techgiant.com",
					company = new Company
					{
						name = "TechGiant Inc.",
						catchPhrase = "Leading the way in tech",
						bs = "global tech leader"
					}
				});

			users.Add(
				new User
				{
					id = 9,
					name = "Ethan Clark",
					username = "ethan_clark92",
					email = "ethan.clark@cloudsolutions.com",
					address = new Address
					{
						street = "Cloud Street",
						suite = "Cloud Office 34",
						city = "Seattle",
						zipcode = "98101",
						geo = new Geo
						{
							lat = 47.6062,
							lng = -122.3321
						}
					},
					phone = "206-555-9876",
					website = "cloudsolutions.com",
					company = new Company
					{
						name = "Cloud Solutions Inc.",
						catchPhrase = "The future is in the cloud",
						bs = "cloud computing"
					}
				});

			users.Add(
				new User
				{
					id = 10,
					name = "Olivia Martinez",
					username = "olivia_martinez",
					email = "olivia.martinez@futuredigital.com",
					address = new Address
					{
						street = "Digital Park",
						suite = "Suite 99",
						city = "Austin",
						zipcode = "73301",
						geo = new Geo
						{
							lat = 30.2672,
							lng = -97.7431
						}
					},
					phone = "512-555-4567",
					website = "futuredigital.com",
					company = new Company
					{
						name = "Future Digital",
						catchPhrase = "Revolutionizing digital experiences",
						bs = "immersive tech"
					}
				});

			return users;
		}
	}
}
