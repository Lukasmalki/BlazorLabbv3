namespace BlazorLabbv3
{
	public static class UserExtensions
	{

		public static List<User> SortUsersByName(this List<User> users)
		{
			var sortedUsers = users?.OrderBy(user => user.name).ToList();
			return sortedUsers;
		}



		public static List<User> Show5Users(this List<User> users)
		{
			var show5Users = users.Take(5).ToList();
			return show5Users;
		}
	}
}
